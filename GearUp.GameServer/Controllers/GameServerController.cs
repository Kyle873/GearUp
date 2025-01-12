using GearUp.Common.Protocol;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.IO.Compression;

namespace GearUp.GameServer.Controllers;

[ApiController]
[Route("gs")]
public class GameServerController : ControllerBase
{
    [HttpPut("{Op}")]
    public void RequestOp(string Op)
    {
        Op = Op.Split("=").Last();
        Log.Information("Operation: {Op}", Op);

        var req = Request.Body.Deserialize<RequestOperation>();
        var res = new ResponseOperation() { UserId = req.UserId, SessionId = "", Operation = req.OpCode };

        if (req.OpCode == OperationCode.Login)
        {
            res.ResponseType = DataType.Response;
            
            res.ReturnCache.Add(DataTypes.ProtoPlayer, [new ProtoPlayer()
            {
                UserId = req.UserId,
                Name = "Test",
                Level = 1,
                CreateTime = 1699518332261,
                AttackLevel = 1,
                DefenceLevel = 1,
                ProtectLevel = 1,
                LeaderLevel = 1,
                OpenedRecruitQueueNum = 2,
                OpenedBuildQueueNum = 5,
                BgGirlId = 1,
                PlayerTitle = 1,
                LastRefreshTime = DateTimeOffset.Now.ToUnixTimeMilliseconds(),
                BgId = 10001,
                MaxPersonalStoryDailyCount = 2,
                MaxPersonalCopyDailyCount = 5,
                IsRepairCorberoPointReward = true,
                IsRepairedGirlAboutMCV = true,
                IsRepairExpeditionMission = true,
                IsRepairDailyMission = true,
                IsRepairedAisimeiladaSkill = true,
                RepairMonthCard = true,
                IsRepairCriticalPointStage = true,
                IsRepairGirlQuality = true
            }]);
            res.ReturnCache.Add(DataTypes.ProtoGirl, [new ProtoGirl()
            {
                UserId = req.UserId,
                Id = 1,
                WidgetGroupId = "1",
                Level = 1,
                Exp = 0,
                StarLevel = 3,
                SkillLeveList =
                {
                    { 10101, 1 },
                    { 10102, 1 }
                },
                CurrentSKinId = 101,
                Skins = [101],
                CreateTime = 1699518332261,
                Energy = 1000,
                GirlQualityType = GirlQualityType.SR
            }]);
            res.ReturnCache.Add(DataTypes.ProtoItem, [new ProtoItem()
            {
                UserId = req.UserId,
                Id = 17300142,
                Num = 3
            }]);
            res.ReturnCache.Add(DataTypes.ProtoStage, [new ProtoStage()
            {
                UserId = req.UserId,
                Id = 1,
                StarMark = 7,
                Status = StageStatus.NoFighting,
                CompleteCount = 1
            }]);
            res.ReturnCache.Add(DataTypes.ProtoPang, [new ProtoPang()
            {
                UserId = req.UserId,
                ServerTime = DateTimeOffset.Now.ToUnixTimeMilliseconds(),
                DelaySeconds = 25,
                Timezone = 7
            }]);
            res.ReturnCache.Add(DataTypes.ProtoCG, [new ProtoCG()
            {
                UserId = req.UserId,
                Id = 10001,
                CreateTime = 1699518332261
            }]);
            res.ReturnCache.Add(DataTypes.ProtoDailyFlag, [new ProtoDailyFlag()
            {
                UserId = req.UserId,
                Id = 1,
            }]);
        }
        else if (req.OpCode == OperationCode.Ping)
        {
            res.ResponseType = DataType.Response;
            
            res.ReturnCache.Add(DataTypes.ProtoPang, [new ProtoPang()
            {
                UserId = req.UserId,
                ServerTime = DateTimeOffset.Now.ToUnixTimeMilliseconds(),
                DelaySeconds = 25,
                Timezone = 7
            }]);
        }
        else
        {
            Log.Warning("Unhandled Operation: {Op}", req.OpCode);

            // This will block the client and force implementations to be made. Comment out to push further, but with undefined behavior.
            res.ErrorCode = ErrorCode.ServerError;
        }

        Log.Debug("{@Msg}", res);
        
        using var resMs = new MemoryStream();
        resMs.Position = 0;
        
        res.Serialize(resMs);
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
