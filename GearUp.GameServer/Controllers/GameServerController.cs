using GearUp.Common.Database;
using GearUp.Common.Protocol;
using GearUp.GameServer.Handlers;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.IO.Compression;

namespace GearUp.GameServer.Controllers;

[ApiController]
[Route("gs")]
public class GameServerController(DataStore dataStore, ILogger<GameServerController> logger) : ControllerBase
{
    [HttpPut("{Op}")]
    public void RequestOp(string Op)
    {
        Op = Op.Split("=").Last();
        Log.Information("Operation: {Op}", Op);

        var req = Request.Body.Deserialize<RequestOperation>();
        var handler = OperationHandlerFactory.GetHandler(req.OpCode);
        var res = handler?.Invoke(req, new()
        {
            DataStore = dataStore,
            Logger = logger
        }) ?? OperationHandlerBase.CreateResponse(req);

        if (handler is null)
        {
            Log.Warning("Unhandled Operation {Op} : {@Data}", req.OpCode, req);

            // This will block the client and force implementations to be made. Comment out to push further, but with undefined behavior.
            res.ErrorCode = ErrorCode.ServerError;
        }

        Log.Debug("{@Msg}", res);
        
        using var resMs = new MemoryStream();
        res.Serialize(resMs);
        resMs.Position = 0;
        
        using var compressedResMs = new MemoryStream();
        using (var gzipStream = new GZipStream(compressedResMs, CompressionMode.Compress))
        {
            resMs.CopyTo(gzipStream);
        }
        
        Response.ContentType = "application/octet-stream";

        new ResponsePack()
        {
            Data = compressedResMs.ToArray(),
            DataLen = (int)resMs.Length,
            IsGZip = true
        }.Serialize(Response.Body);
    }
}
