using GearUp.Common.Database;
using GearUp.Common.Protocol;

namespace GearUp.GameServer.Handlers
{
    public class UserContext
    {
        public required DataStore DataStore { get; set; }
        public required ILogger Logger { get; set; }
        public required string Token { get; set; }

        public List<ProtoGirl> PlayerGirls =>
            DataStore.GameServer.PlayerGirls[RequiredPlayer.UserId];

        public ProtoPlayer RequiredPlayer => 
            DataStore.GameServer.Players[Token];
        public ProtoPlayer? Player => 
            DataStore.GameServer.Players.GetValueOrDefault(Token);
        public void SetPlayerNickName(string name)
        {
            var player = RequiredPlayer;
            player.Name = name;
            player.IsPlayerInfoComplete = true;
            DataStore.GameServer.Players[Token] = player;
        }
        public ProtoPlayer CreateNewPlayer()
        {
            var newId = ++DataStore.GameServer.UserIdCounter;
            var player = new ProtoPlayer
            {
                UserId = newId,
                Name = string.Empty,
                Level = 1,
                CreateTime = DateTimeOffset.Now.ToUnixTimeMilliseconds(),
                AttackLevel = 1,
                DefenceLevel = 1,
                ProtectLevel = 1,
                LeaderLevel = 1,
                BgGirlId = 1,
                PlayerTitle = 1,
                LastRefreshTime = DateTimeOffset.Now.ToUnixTimeMilliseconds(),
                LastLoginTime = DateTimeOffset.Now.ToUnixTimeMilliseconds(),
                Logintimes = 1,
                BgId = 10001,
                MaxPersonalStoryDailyCount = 2,
                MaxPersonalCopyDailyCount = 5,
                IsRepairCorberoPointReward = true,
                IsRepairedGirlAboutMCV = true,
                IsRepairExpeditionMission = true,
                IsRepairDailyMission = true,
                IsRepairedAisimeiladaSkill = true,
                Battle_DailyStageDayOfWeek = -1,
                RepairMonthCard = true,
                IsRepairCriticalPointStage = true,
                IsRepairGirlQuality = true
            };
            DataStore.GameServer.Players[Token] = player;
            DataStore.GameServer.PlayerGirls[player.UserId] = [new ProtoGirl() {
                UserId = player.UserId,
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
                CreateTime = DateTimeOffset.Now.ToUnixTimeMilliseconds(),
                Energy = 1000,
                GirlQualityType = GirlQualityType.SR
            }];

            return player;
        }
    }
}
