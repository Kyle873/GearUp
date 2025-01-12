using GearUp.GameServer.Models;
using Microsoft.AspNetCore.Mvc;

namespace GearUp.GameServer.Controllers.SDK
{
    [ApiController]
    [Route("/api/sdk/[controller]")]
    public class RequestController : ControllerBase
    {
        [HttpPost]
        public SdkResponse SDKRequest([FromBody] SdkReqeust reqeust)
        {
            return new()
            {
                ResultCode = 0,
                AcceptTime = DateTimeOffset.Now.ToUnixTimeSeconds(),
                InstallStatus = "1",
                OnetimeToken = reqeust.OnetimeToken
            };
        }
    }
}
