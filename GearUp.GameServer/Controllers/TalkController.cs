using Microsoft.AspNetCore.Mvc;
using System.Buffers.Binary;

namespace GearUp.GameServer.Controllers;

[ApiController]
[Route("[controller]")]
public class TalkController : ControllerBase
{
    [HttpPut("get")]
    public Task Get()
    {
        var retBytes = GC.AllocateUninitializedArray<byte>(16);
        BinaryPrimitives.WriteInt64BigEndian(retBytes.AsSpan(), 0);
        BinaryPrimitives.WriteInt64BigEndian(retBytes.AsSpan(8), DateTimeOffset.Now.ToUnixTimeSeconds());

        return Response.Body.WriteAsync(retBytes).AsTask();
    }
}
