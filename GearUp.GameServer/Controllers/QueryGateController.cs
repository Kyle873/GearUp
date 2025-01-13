using GearUp.Common.Database;
using GearUp.GameServer.Models;
using Microsoft.AspNetCore.Mvc;

namespace GearUp.GameServer.Controllers;

[ApiController]
public class QueryGateController(ILogger<QueryGateController> logger, DataStore dataStore) : ControllerBase
{
    [Route("/")]
    [HttpPost]
    [HttpGet]
    public IResult GateServerQuery([FromQuery(Name = "q")] string query)
    {
        switch (query)
        {
            case "gateway":
                return Results.Json(new PlatRsp()
                {
                    Web = ["https://localhost"]
                });   
            case "getresver":
                return Results.Json(new VersionRsp()
                {
                    AbAddr = "https://l3-prod-patch-zzzj.bilibiligame.jp/TS/",
                    AbAddr2 = "https://l13-prod-patch-zzzj.bilibiligame.jp/TS/",
                    AbAddr3 = "https://l13-prod-patch-zzzj.bilibiligame.jp/TS/",
                    ClientVer = 1460000,
                    ClientVer2 = 1460000,
                    ResourceDownAddr = string.Empty,
                    ResourceVer = 1470073,
                    ResourceVer2 = 1470073
                });
            case "login":
                return Results.Json(new ServerListRsp()
                {
                    Antid = "deafbeef",
                    Authtoken = "deadbeef",
                    Roles = "1",
                    LastZone = 1,
                    Zones = new ServerListRsp.ServerData()
                    {
                        Id = 1,
                        Name = nameof(GearUp),
                        Recommend = 1,
                        State = 0,
                        ShowState = 0,
                        Sort = 600
                    }.Serialize()
                });
            case "play":
                return Results.Json(new PlayRsp()
                {
                    Uid = "1",
                    Token = "deadbeef",
                    Timeout = 1123200,
                    Chatdelay = 5,
                    Gs = ["https://localhost/gs/"],
                    Talk = ["https://localhost/talk/"],
                });
            default:
                logger.LogWarning("Unhandled {ControllerAction} q={Query}!", nameof(GateServerQuery), query);
                break;
        }

        return Results.NotFound();
    }
}
