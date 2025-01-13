using GearUp.Common.Protocol;
using Serilog;
using System.Reflection;

namespace GearUp.GameServer.Handlers;

public delegate ResponseOperation OperationHandlerDelegate(RequestOperation req);

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class OperationHandlerAttribute : Attribute
{
    public OperationCode OpCode { get; }

    public OperationHandlerAttribute(OperationCode opCode)
    {
        OpCode = opCode;
    }
}

public static class OperationHandlerFactory
{
    static readonly Dictionary<OperationCode, OperationHandlerDelegate> handlers = [];

    public static void RegisterHandlers()
    {
        foreach (var method in Assembly.GetExecutingAssembly().GetTypes().SelectMany(t => t.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Where(m => m.GetCustomAttribute<OperationHandlerAttribute>() is not null)))
        {
            var attr = method.GetCustomAttribute<OperationHandlerAttribute>()!;

            handlers.Add(attr.OpCode, (OperationHandlerDelegate)Delegate.CreateDelegate(typeof(OperationHandlerDelegate), method));
        }

        Log.Information($"Registered {handlers.Count} Operation handlers");
    }

    public static OperationHandlerDelegate? GetHandler(OperationCode opCode)
    {
        if (handlers.TryGetValue(opCode, out var handler))
        {
            return handler;
        }

        return null;
    }
}

public abstract class OperationHandlerBase
{
    public static ResponseOperation CreateResponse(RequestOperation req)
    {
        return new ResponseOperation()
        {
            UserId = req.UserId,
            SessionId = "",
            Operation = req.OpCode,
            ResponseType = DataType.Response
        };
    }
}
