using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GearUp.Common.Protocol;

public interface IProtocol { }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

[Serializable]
[ProtoContract]
public class ATBossRankAwardView : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public long PlayerId
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public string PlayerName
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int ViewIcon
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int DamageValue
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int TitleId
    {
        get;
        set;
    }

    public ATBossRankAwardView()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ATBossView : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public long Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public string OriginPlayerName
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int BossConfID
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public ATBossStatus BossStatus
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public Dictionary<long, int> DamageValueDic
    {
        get;
        set;
    } = [];

    [ProtoMember(6)]
    public long StartBossBattleTS
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public int BornRuleID
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public Dictionary<int, int> MonserDamageInfo
    {
        get;
        set;
    } = [];

    [ProtoMember(9)]
    public long OriginPlayerId
    {
        get;
        set;
    }

    public ATBossView()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class BeforeDawnOrder : IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Count
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public long EndTime
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public bool HaveReceived
    {
        get;
        set;
    }

    public BeforeDawnOrder()
    {
    }
}


[Serializable]
[ProtoContract]
public class BigEventMission : IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Process
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public RewardGetState RewardState
    {
        get;
        set;
    }

    public BigEventMission()
    {
    }
}


[Serializable]
[ProtoContract]
public class BigEventStage : IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int CompleteNum
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int StarMark
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int TodayComplteNum
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public List<ProtoBattleMonsterStatus> MonsterStatus
    {
        get;
        set;
    } = [];

    public BigEventStage()
    {
    }
}


[Serializable]
[ProtoContract]
public class BikiniBossMission : IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Proc
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public RewardGetState State
    {
        get;
        set;
    }

    public BikiniBossMission()
    {
    }
}


[Serializable]
[ProtoContract]
public class BubbleInfo : IProtocol
{
    [ProtoMember(1)]
    public int BubbleId
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public long CanRecieveTS
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public bool IsReceived
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int StepId
    {
        get;
        set;
    }

    public BubbleInfo()
    {
    }
}


[Serializable]
[ProtoContract]
public class ChatResponse : IProtocol
{
    [ProtoMember(1)]
    public List<ProtoChatMessage> chats
    {
        get;
        set;
    } = [];

    [ProtoMember(2)]
    public long chatServerTime
    {
        get;
        set;
    }

    public ChatResponse()
    {
    }
}


[Serializable]
[ProtoContract]
public class CriticalPointRewardPoolCell : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int ItemId
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int Count
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int MaxCount
    {
        get;
        set;
    }

    public CriticalPointRewardPoolCell()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class DailyStageCount : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int UsedCount
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int LeftCount
    {
        get;
        set;
    }

    public DailyStageCount()
    {
        base.IsNew = true;
    }
}


public enum DataType : byte
{
    Kill = 0,
    Request = 1,
    Response = 2,
    Event = 3,
    Publish = 4,
    Confirm = 5,
    PublicKey = 6,
    GZip = 128
}


[Serializable]
[ProtoContract]
public class DropItem : IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Num
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public StuffType StuffType
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int WidgetLevel
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int UseLevel
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public WidgetQualityType WidgetQualityType
    {
        get;
        set;
    }

    public DropItem()
    {
    }
}


[Serializable]
[ProtoContract]
public class EventData : IProtocol
{
    [ProtoMember(1)]
    public int EID
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Data
    {
        get;
        set;
    }

    public EventData()
    {
    }
}


[Serializable]
[ProtoContract]
public class FloorInfo : IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Step
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public List<EventData> RndEID
    {
        get;
        set;
    } = [];

    [ProtoMember(4)]
    public EventData EID
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public List<int> Treasure
    {
        get;
        set;
    } = [];

    [ProtoMember(6)]
    public int WeakenId
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public int Fnum
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public bool Finish
    {
        get;
        set;
    }

    public FloorInfo()
    {
    }
}


[Serializable]
[ProtoContract]
public class GirlNature : IProtocol
{
    [ProtoMember(1)]
    public int AttrId
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int AttrLvl
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int AttrExp
    {
        get;
        set;
    }

    public GirlNature()
    {
    }
}


[Serializable]
[ProtoContract]
public class HistoryReportPlayerInfo : IProtocol
{
    [ProtoMember(1)]
    public long Uid
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public string Name
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int Level
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int Ranking
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int BattlePower
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public int HeadGirlSkinId
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public int Title
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public bool IsMonster
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public int Point
    {
        get;
        set;
    }

    [ProtoMember(10)]
    public List<ProtoStarshipMirror> Starships
    {
        get;
        set;
    } = [];

    public HistoryReportPlayerInfo()
    {
    }
}


[ProtoContract]
public class MapBattleData : IProtocol
{
    [ProtoMember(7)]
    public int enemyIndex;

    [ProtoMember(1)]
    public int battleIndex;

    [ProtoMember(2)]
    public int isBattleWin;

    [ProtoMember(3)]
    public string sceneName;

    [ProtoMember(4)]
    public int sceneMusic;

    [ProtoMember(5)]
    public float enemyBuffvalues;

    [ProtoMember(6)]
    public float playerBuffvalues;

    public MapBattleData()
    {
    }
}


[Serializable]
[ProtoContract]
public class MiniMission : IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Process
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public RewardGetState RewardState
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int CompleteTime
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public ObjState State
    {
        get;
        set;
    }

    public MiniMission()
    {
    }
}


[Serializable]
[ProtoContract]
public class MonthLevelReward : IProtocol
{
    [ProtoMember(1)]
    public int Lv
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Proc
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public RewardGetState FState
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public RewardGetState RState
    {
        get;
        set;
    }

    public MonthLevelReward()
    {
    }
}


[Serializable]
[ProtoContract]
public class MonthMission : IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Proc
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public RewardGetState State
    {
        get;
        set;
    }

    public MonthMission()
    {
    }
}


[ProtoContract]
public struct NavAIProtoBufData() : IProtocol
{
    [ProtoMember(1)]
    public int navAgentType;

    [ProtoMember(2)]
    public string agentName;

    [ProtoMember(3)]
    public int uniqueIndex;

    [ProtoMember(4)]
    public float[] position;

    [ProtoMember(5)]
    public float eyeRotation;

    [ProtoMember(6)]
    public int index;

    [ProtoMember(7)]
    public int customIndex;

    [ProtoMember(8)]
    public int navOutcomeType;

    [ProtoMember(9)]
    public List<NavBuffProtoBufData> buffs = [];

    [ProtoMember(10)]
    public int nextWayPoint;

    [ProtoMember(11)]
    public int targetIndex;

    [ProtoMember(12)]
    public List<string> sharedVariablesName = [];

    [ProtoMember(13)]
    public List<string> sharedVariablesType = [];

    [ProtoMember(14)]
    public List<int> sharedVariablesInt = [];

    [ProtoMember(15)]
    public List<float> sharedVariablesFloat = [];

    [ProtoMember(16)]
    public List<string> sharedVariablesString = [];

    [ProtoMember(17)]
    public float curHP;
}


[ProtoContract]
public struct NavBombAreaData : IProtocol
{
    [ProtoMember(1)]
    public float timer;

    [ProtoMember(2)]
    public float[] position;
}


[ProtoContract]
public struct NavBuffProtoBufData : IProtocol
{
    [ProtoMember(1)]
    public int index;

    [ProtoMember(2)]
    public float startTime;
}


[ProtoContract]
public struct NavCameraProtoBufData : IProtocol
{
    [ProtoMember(1)]
    public float cameraSize;

    [ProtoMember(2)]
    public float[] cameraPosition;

    [ProtoMember(3)]
    public int obstacleEdge;

    [ProtoMember(4)]
    public float obstacleScale;

    [ProtoMember(5)]
    public bool overall;

    [ProtoMember(6)]
    public int areaIndex;
}


[ProtoContract]
public struct NavEventData : IProtocol
{
    [ProtoMember(1)]
    public bool on;

    [ProtoMember(2)]
    public float workingTime;

    [ProtoMember(3)]
    public bool mute;
}


[ProtoContract]
public struct NavMapProtoBufData : IProtocol
{
    [ProtoMember(1)]
    public long userIndex;

    [ProtoMember(2)]
    public int stageIndex;

    [ProtoMember(3)]
    public float navTimeScale;

    [ProtoMember(4)]
    public float navTime;

    [ProtoMember(5)]
    public int maxUniqueIndex;

    [ProtoMember(6)]
    public int playerIndex;

    [ProtoMember(7)]
    public int selectedNavPlayerIndex;

    [ProtoMember(8)]
    public string Ticks;
}


[ProtoContract]
public struct NavPlayerProtoBufData() : IProtocol
{
    [ProtoMember(1)]
    public int uniqueIndex;

    [ProtoMember(2)]
    public float[] position;

    [ProtoMember(3)]
    public float eyeRotation;

    [ProtoMember(4)]
    public List<NavBuffProtoBufData> buffs = [];

    [ProtoMember(5)]
    public int curBulletNumber;

    [ProtoMember(6)]
    public float skillCurCD;

    [ProtoMember(7)]
    public float[] points;

    [ProtoMember(8)]
    public int[] lockedAIUniqueIndexs;

    [ProtoMember(9)]
    public bool beChased;

    [ProtoMember(10)]
    public bool procedureMove;
}


[ProtoContract]
public struct NavStatisticsProtoBufData() : IProtocol
{
    [ProtoMember(1)]
    public float time;

    [ProtoMember(2)]
    public int enemyKilledNum;

    [ProtoMember(3)]
    public int maximumDamage;

    [ProtoMember(4)]
    public int skillCastTimes;

    [ProtoMember(5)]
    public float sceneIndex;

    [ProtoMember(6)]
    public List<ProtoViewItem> protoViewItems = [];
}


[ProtoContract]
public struct NavTriggerData : IProtocol
{
    [ProtoMember(1)]
    public bool occupied;

    [ProtoMember(2)]
    public float curLatency;

    [ProtoMember(3)]
    public float floatRegister;

    [ProtoMember(4)]
    public int intRegister;
}


[ProtoContract]
public struct NavTriggerOnceData : IProtocol
{
    [ProtoMember(1)]
    public bool worked;
}


[Serializable]
[ProtoContract]
public class NewYearBossMissions : IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Process
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public RewardGetState RewardState
    {
        get;
        set;
    }

    public NewYearBossMissions()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoAccumulateLogin : ProtoBase, IProtocol
{
    public static string TableName => "accumulateLogin";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int LoginDaysInActivity
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public Dictionary<int, RewardGetState> AwardSequence
    {
        get;
        set;
    } = [];

    [ProtoMember(4)]
    public long LastGetAwardTime
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public bool IsPlayedAnimation
    {
        get;
        set;
    }

    public ProtoAccumulateLogin()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoAchievement : ProtoBase, IProtocol
{
    public static string TableName => "achievement";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Process
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public RewardGetState AchvState
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public Achievement AchievementType
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public int AchievementId
    {
        get;
        set;
    }

    public ProtoAchievement()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoAchiRankLvl : ProtoBase, IProtocol
{
    public static string TableName => "achiranklvl";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Exp
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int Lvl
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public List<int> HaveRecievedLvlLst
    {
        get;
        set;
    } = [];

    public ProtoAchiRankLvl()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoActivity : ProtoBase, IProtocol
{
    public static string TableName => "activity";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public Dictionary<int, ProtoActivityAchievement> ActivityAchievements
    {
        get;
        set;
    } = [];

    [ProtoMember(3)]
    public Dictionary<int, ProtoActivityMission> ActivityMissions
    {
        get;
        set;
    } = [];

    [ProtoMember(4)]
    public Dictionary<int, ProtoActivityDailyMission> ActivityDailyMissions
    {
        get;
        set;
    } = [];

    [ProtoMember(5)]
    public List<byte> CorberoPointRewardGetList
    {
        get;
        set;
    } = [];

    [ProtoMember(6)]
    public RewardPool CurrentRewardPool
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public Dictionary<int, int> PointConversionDatas
    {
        get;
        set;
    } = [];

    [ProtoMember(8)]
    public int ActivityMissionDailyCompleteCount
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public long ActivityOpenTime
    {
        get;
        set;
    }

    [ProtoMember(10)]
    public long ActivityCloseTime
    {
        get;
        set;
    }

    public ProtoActivity()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoActivityAchievement : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public short Process
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public RewardGetState RewardState
    {
        get;
        set;
    }

    public ProtoActivityAchievement()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoActivityConfig : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public string OpenTime
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public string CloseTime
    {
        get;
        set;
    }

    public ProtoActivityConfig()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoActivityDailyMission : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public short Process
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public RewardGetState RewardState
    {
        get;
        set;
    }

    public ProtoActivityDailyMission()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoActivityMission : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public short CompleteCount
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public byte StarMark
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int DropCtrlCount
    {
        get;
        set;
    }

    public ProtoActivityMission()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoArea : ProtoBase, IProtocol
{
    public static string TableName => "area";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public List<int> AreaBlock
    {
        get;
        set;
    } = [];

    [ProtoMember(3)]
    public List<int> MissionGroup
    {
        get;
        set;
    } = [];

    public ProtoArea()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoAreaDailyMission : ProtoBase, IProtocol
{
    public static string TableName => "areaDailyMission";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int MissionNo
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public short Process
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public RewardGetState RewardState
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int AreaId
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public ObjState State
    {
        get;
        set;
    }

    public ProtoAreaDailyMission()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoAreaMission : ProtoBase, IProtocol
{
    public static string TableName => "areaMission";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int AreaId
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public SceneType SceneType
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public SceneSubType SceneSubType
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public long MissionEndTime
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public bool DailyMissionCompleted
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public ObjState State
    {
        get;
        set;
    }

    [ProtoMember(10)]
    public int RegionMapLocation
    {
        get;
        set;
    }

    [ProtoMember(11)]
    public StageStatus Status
    {
        get;
        set;
    }

    [ProtoMember(12)]
    public Dictionary<int, ProtoGirlBattleStatus> GirlsStatus
    {
        get;
        set;
    } = [];

    [ProtoMember(13)]
    public List<int> BattleIds
    {
        get;
        set;
    } = [];

    [ProtoMember(14)]
    public long CreateTime
    {
        get;
        set;
    }

    [ProtoMember(15)]
    public int TotalExp
    {
        get;
        set;
    }

    [ProtoMember(16)]
    public int TotalCoin
    {
        get;
        set;
    }

    [ProtoMember(17)]
    public int MissionLevel
    {
        get;
        set;
    }

    [ProtoMember(18)]
    public int MissionGroupId
    {
        get;
        set;
    }

    [ProtoMember(19)]
    public string AuthCode
    {
        get;
        set;
    }

    [ProtoMember(20)]
    public Dictionary<int, ProtoCombinedMachineStatus> CombinedMachineStatus
    {
        get;
        set;
    } = [];

    public ProtoAreaMission()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoATAssistRecord : ProtoBase, IProtocol
{
    public static string TableName => "atassistrecord";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public List<long> IInitiateOthersLst
    {
        get;
        set;
    } = [];

    [ProtoMember(3)]
    public List<long> OthersInviteMeLst
    {
        get;
        set;
    } = [];

    [ProtoMember(4)]
    public List<long> IHelpedOthersLst
    {
        get;
        set;
    } = [];

    [ProtoMember(5)]
    public long LastRefreshOthersInviteMeLstTS
    {
        get;
        set;
    }

    public ProtoATAssistRecord()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoATBossInfo : ProtoBase, IProtocol
{
    public static string TableName => "atbossinfo";

    [ProtoMember(1)]
    public long Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public long OriginPlayerID
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int BossConfID
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public long KillerPlayerID
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public Dictionary<long, int> DamageValueDic
    {
        get;
        set;
    } = [];

    [ProtoMember(6)]
    public long StartBossBattleTS
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public int BornRuleID
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public Dictionary<int, int> MonserDamageInfo
    {
        get;
        set;
    } = [];

    [ProtoMember(9)]
    public bool IsSendKillAward
    {
        get;
        set;
    }

    [ProtoMember(10)]
    public bool IsSendRankAward
    {
        get;
        set;
    }

    public ProtoATBossInfo()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoATBossRankView : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public long Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public string OriginPlayerName
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int BossConfID
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public List<ATBossRankAwardView> RankInfo
    {
        get;
        set;
    } = [];

    [ProtoMember(6)]
    public long KillerId
    {
        get;
        set;
    }

    public ProtoATBossRankView()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoATPlayer : ProtoBase, IProtocol
{
    public static string TableName => "atplayer";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int AssistEnergy
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public long LastCalcEnergyTS
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public Dictionary<int, int> ATBattleCountDic
    {
        get;
        set;
    } = [];

    [ProtoMember(5)]
    public int LastChallengeBossConfId
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public long LastChallengeEffeciveTS
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public Dictionary<int, int> MonsterDamageInfo
    {
        get;
        set;
    } = [];

    [ProtoMember(8)]
    public long PreBossUuid
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public List<int> ChallengeSuccBossIds
    {
        get;
        set;
    } = [];

    public ProtoATPlayer()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoATRecordForView : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public List<ATBossView> IInitiateOthersLst
    {
        get;
        set;
    } = [];

    [ProtoMember(3)]
    public List<ATBossView> OthersInviteMeLst
    {
        get;
        set;
    } = [];

    [ProtoMember(4)]
    public List<ATBossView> IHelpedOthersLst
    {
        get;
        set;
    } = [];

    [ProtoMember(5)]
    public long LastRefreshOthersInviteMeLstTS
    {
        get;
        set;
    }

    public ProtoATRecordForView()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoAttribute : IProtocol
{
    [ProtoMember(1)]
    public string AttributeName
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public float AttributeValue
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public float Min
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public float Max
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public bool IsNew
    {
        get;
        set;
    }

    public ProtoAttribute()
    {
    }
}


[Serializable]
[ProtoContract]
[ProtoInclude(133, typeof(ProtoURAwakeConfig))]
[ProtoInclude(153, typeof(ProtoBigEvent))]
[ProtoInclude(152, typeof(ProtoGacyaHistory))]
[ProtoInclude(151, typeof(ProtoPayRecruit))]
[ProtoInclude(137, typeof(ProtoBeforeDawn))]
[ProtoInclude(132, typeof(ProtoGirlSkinConfig))]
[ProtoInclude(149, typeof(ProtoOrderLoginNine))]
[ProtoInclude(143, typeof(ProtoStarshipFetter))]
[ProtoInclude(131, typeof(ProtoActivityConfig))]
[ProtoInclude(144, typeof(ProtoStarshipExplore))]
[ProtoInclude(148, typeof(ProtoTeachingRecruit))]
[ProtoInclude(147, typeof(ProtoStarshipChip))]
[ProtoInclude(150, typeof(ProtoPopupPackage))]
[ProtoInclude(134, typeof(ProtoRiceCake))]
[ProtoInclude(142, typeof(ProtoStarshipBase))]
[ProtoInclude(135, typeof(ProtoNewYearBoss))]
[ProtoInclude(203, typeof(ProtoStarTowerTask))]
[ProtoInclude(210, typeof(ProtoStarshipPVP))]
[ProtoInclude(211, typeof(ProtoPlayerMirrorSP))]
[ProtoInclude(212, typeof(ProtoStarshipGuessing))]
[ProtoInclude(213, typeof(ProtoStarshipPVPLogDetails))]
[ProtoInclude(214, typeof(ProtoStarshipPVPHistoryReport))]
[ProtoInclude(136, typeof(ProtoTexun))]
[ProtoInclude(215, typeof(ProtoStarshipPVPRanking))]
[ProtoInclude(141, typeof(ProtoStarshipWeaponFavor))]
[ProtoInclude(140, typeof(ProtoStarshipWeapon))]
[ProtoInclude(139, typeof(ProtoStarship))]
[ProtoInclude(138, typeof(ProtoStageDropView))]
[ProtoInclude(145, typeof(ProtoBattleReport))]
[ProtoInclude(202, typeof(ProtoMonthMission))]
[ProtoInclude(146, typeof(ProtoStarTowerStage))]
[ProtoInclude(106, typeof(ProtoEveOfNationalWarPVE))]
[ProtoInclude(127, typeof(ProtoBikiniSeaFloor))]
[ProtoInclude(37, typeof(ProtoRoleBattleGroup))]
[ProtoInclude(51, typeof(ProtoWidgetExchange))]
[ProtoInclude(52, typeof(ProtoBikiniTask))]
[ProtoInclude(36, typeof(ProtoBuild))]
[ProtoInclude(35, typeof(ProtoAreaMission))]
[ProtoInclude(34, typeof(ProtoPang))]
[ProtoInclude(33, typeof(ProtoRanking))]
[ProtoInclude(53, typeof(ProtoBikiniBackground))]
[ProtoInclude(54, typeof(ProtoWeeklyStage))]
[ProtoInclude(32, typeof(RewardPool))]
[ProtoInclude(31, typeof(ProtoActivityDailyMission))]
[ProtoInclude(30, typeof(ProtoActivityMission))]
[ProtoInclude(50, typeof(ProtoBeachVolleyball))]
[ProtoInclude(55, typeof(ProtoWeeklyShop))]
[ProtoInclude(25, typeof(ProtoCharge))]
[ProtoInclude(56, typeof(ProtoSuitDevelop))]
[ProtoInclude(26, typeof(ProtoBattleDrop))]
[ProtoInclude(27, typeof(ProtoCollect))]
[ProtoInclude(57, typeof(ProtoMCVBase))]
[ProtoInclude(58, typeof(ProtoMCVRoom))]
[ProtoInclude(59, typeof(ProtoGirlBubble))]
[ProtoInclude(60, typeof(ProtoMCVPreTaskActivity))]
[ProtoInclude(61, typeof(ProtoTechTree))]
[ProtoInclude(62, typeof(ProtoGhostMission))]
[ProtoInclude(63, typeof(ProtoSignInMonth))]
[ProtoInclude(64, typeof(ProtoCriticalPointStage))]
[ProtoInclude(24, typeof(ProtoActivityDailyMission))]
[ProtoInclude(65, typeof(ProtoChristmas))]
[ProtoInclude(49, typeof(ProtoBikiniStageMission))]
[ProtoInclude(47, typeof(ProtoGacya))]
[ProtoInclude(23, typeof(ProtoAreaDailyMission))]
[ProtoInclude(22, typeof(ProtoWeeklyMission))]
[ProtoInclude(21, typeof(ProtoExpeditionMission))]
[ProtoInclude(19, typeof(ProtoActivity))]
[ProtoInclude(18, typeof(ProtoShopItem))]
[ProtoInclude(42, typeof(ProtoCG))]
[ProtoInclude(43, typeof(ProtoEffectiveTenRecruitTime))]
[ProtoInclude(44, typeof(ProtoTenRecruit))]
[ProtoInclude(45, typeof(ProtoTenRecruitConfig))]
[ProtoInclude(17, typeof(ProtoArea))]
[ProtoInclude(15, typeof(ProtoAchievement))]
[ProtoInclude(39, typeof(ProtoTodayTotalInfo))]
[ProtoInclude(48, typeof(ProtoBikiniStage))]
[ProtoInclude(14, typeof(ProtoNotice))]
[ProtoInclude(13, typeof(ProtoRecruit))]
[ProtoInclude(12, typeof(ProtoPlayerInfo))]
[ProtoInclude(11, typeof(ProtoMail))]
[ProtoInclude(10, typeof(ProtoStage))]
[ProtoInclude(8, typeof(ProtoItem))]
[ProtoInclude(5, typeof(ProtoBattleGroup))]
[ProtoInclude(4, typeof(ProtoWidgetGroup))]
[ProtoInclude(3, typeof(ProtoWidget))]
[ProtoInclude(2, typeof(ProtoGirl))]
[ProtoInclude(1, typeof(ProtoPlayer))]
[ProtoInclude(46, typeof(ProtoShopItemLikeInfo))]
[ProtoInclude(38, typeof(ProtoSevenLogin))]
[ProtoInclude(129, typeof(ProtoSakuraWars))]
[ProtoInclude(66, typeof(ProtoChristmasMission))]
[ProtoInclude(68, typeof(ProtoCriticalPointMission))]
[ProtoInclude(99, typeof(ProtoEVAAreaRepairInfo))]
[ProtoInclude(101, typeof(ProtoDailyFlag))]
[ProtoInclude(102, typeof(ProtoHistoryView))]
[ProtoInclude(103, typeof(ProtoAccumulateLogin))]
[ProtoInclude(104, typeof(ProtoAchiRankLvl))]
[ProtoInclude(105, typeof(ProtoMiniMission))]
[ProtoInclude(40, typeof(ProtoNightmareStage))]
[ProtoInclude(107, typeof(ProtoEveOfNationalWarPVP))]
[ProtoInclude(108, typeof(ProtoHonor))]
[ProtoInclude(109, typeof(ProtoPlayerMirror))]
[ProtoInclude(110, typeof(ProtoGirlMirror))]
[ProtoInclude(111, typeof(ProtoHonorBase))]
[ProtoInclude(98, typeof(ProtoEVABase))]
[ProtoInclude(112, typeof(ProtoStoryStage))]
[ProtoInclude(114, typeof(ProtoSeasonFighter))]
[ProtoInclude(115, typeof(ProtoSeasonFightLog))]
[ProtoInclude(116, typeof(ProtoBattleDesc))]
[ProtoInclude(117, typeof(ProtoFighterDesc))]
[ProtoInclude(119, typeof(ProtoSeasonBattleGroup))]
[ProtoInclude(120, typeof(ProtoSpecialRanking))]
[ProtoInclude(121, typeof(ProtoNationalWar))]
[ProtoInclude(122, typeof(ProtoNationalWarHexStatus))]
[ProtoInclude(123, typeof(ProtoNationalWarCampInfo))]
[ProtoInclude(124, typeof(ProtoNationalWarFightLog))]
[ProtoInclude(125, typeof(ProtoBikiniBoss))]
[ProtoInclude(126, typeof(ProtoBikiniBBQ))]
[ProtoInclude(113, typeof(ProtoSweetActivity))]
[ProtoInclude(67, typeof(CriticalPointRewardPoolCell))]
public class ProtoBase : IProtocol
{
    [ProtoMember(100)]
    public long UserId
    {
        get;
        set;
    }

    [ProtoIgnore]
    [JsonIgnore]
    public bool IsNew
    {
        get;
        set;
    }

    protected ProtoBase()
    {
        IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoBattleDesc : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public ProtoFighterDesc Winner
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public ProtoFighterDesc Loser
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public long FightBackUserId
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int PointChange
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public int BattleLogType
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public long BattleEndTime
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public bool Reported
    {
        get;
        set;
    }

    public ProtoBattleDesc()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoBattleDrop : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int DropId
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int DropNum
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public StuffType DropStuffType
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int WidgetLevel
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int UseLevel
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public WidgetQualityType WidgetQualityType
    {
        get;
        set;
    }

    public ProtoBattleDrop()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoBattleEventData : IProtocol
{
    [ProtoMember(1)]
    public int Turn
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public BattleEventTypes BattleEventType
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int AttackerHP
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int AttackerShieldHp
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public StarshipMoveAction AttackerMoveAction
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public int AttackerInitPosition
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public int DefenderHP
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public int DefenderShieldHp
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public StarshipMoveAction DefenderMoveAction
    {
        get;
        set;
    }

    [ProtoMember(10)]
    public int DefenderInitPosition
    {
        get;
        set;
    }

    [ProtoMember(11)]
    public int PositionBefore
    {
        get;
        set;
    }

    [ProtoMember(12)]
    public int PositionAfter
    {
        get;
        set;
    }

    [ProtoMember(13)]
    public StarshipAttackUnitTypes AttackerType
    {
        get;
        set;
    }

    [ProtoMember(14)]
    public StarshipAttackUnitTypes TargetType
    {
        get;
        set;
    }

    [ProtoMember(15)]
    public List<StarshipAttackUnitTypes> AttackUnits
    {
        get;
        set;
    } = [];

    [ProtoMember(16)]
    public int SkillId
    {
        get;
        set;
    }

    [ProtoMember(17)]
    public int Damage
    {
        get;
        set;
    }

    [ProtoMember(18)]
    public int ShieldDamage
    {
        get;
        set;
    }

    [ProtoMember(19)]
    public DamageTypes DamageType
    {
        get;
        set;
    }

    [ProtoMember(20)]
    public Dictionary<StarshipAttackUnitTypes, List<ProtoEffectChange>> BuffEffectChange
    {
        get;
        set;
    } = [];

    public ProtoBattleEventData()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoBattleGroup : ProtoBase, IProtocol
{
    public static string TableName => "battleGroup";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public string[] WidgetGroups
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public BattleGroupFightingStatus FightingStatus
    {
        get;
        set;
    }

    public ProtoBattleGroup()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoBattleMonsterStatus : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int MonsterID
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int HP
    {
        get;
        set;
    }

    public ProtoBattleMonsterStatus()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoBattleReport : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int BattleReportNum
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int BattleId
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int MaxTurn
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int EndTurn
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public bool BattleWin
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public bool BattleEnd
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public List<ProtoBattleEventData> EventQueue
    {
        get;
        set;
    } = [];

    public ProtoBattleReport()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoBeachVolleyball : ProtoBase, IProtocol
{
    public static string TableName => "beachvolleyball";

    [ProtoMember(1)]
    public int CurActiveID
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public bool IsSuccess
    {
        get;
        set;
    }

    public ProtoBeachVolleyball()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoBeforeDawn : ProtoBase, IProtocol
{
    public static string TableName => "beforedawn";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public Dictionary<int, BeforeDawnOrder> BeforeDawnOrders
    {
        get;
        set;
    } = [];

    public ProtoBeforeDawn()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoBigEvent : ProtoBase, IProtocol
{
    public static string TableName => "bigevents";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public Dictionary<int, BigEventStage> StageList
    {
        get;
        set;
    } = [];

    [ProtoMember(3)]
    public Dictionary<int, BigEventMission> MissionList
    {
        get;
        set;
    } = [];

    [ProtoMember(4)]
    public long OpenTime
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public long CloseTime
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public List<int> EVAAreaStartsAward
    {
        get;
        set;
    } = [];

    [ProtoMember(7)]
    public long BigLstReTime
    {
        get;
        set;
    }

    public ProtoBigEvent()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoBikiniBackground : ProtoBase, IProtocol
{
    public static string TableName => "bikiniBackGround";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public RookieTaskState FirstState
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public RewardGetState SecondState
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int Process
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public ObjState State
    {
        get;
        set;
    }

    public ProtoBikiniBackground()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoBikiniBBQ : ProtoBase, IProtocol
{
    public static string TableName => "bikiniBBQ";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Score
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int BBQID
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public bool IsSuccess
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int Rank
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public int EndlessTimes
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public bool BattleStart
    {
        get;
        set;
    }

    public ProtoBikiniBBQ()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoBikiniBoss : ProtoBase, IProtocol
{
    public static string TableName => "bikiniBoss";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int BattleNum
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int WinNum
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int Score
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int[] Sockets
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public Dictionary<int, BikiniBossMission> Missions
    {
        get;
        set;
    } = [];

    public ProtoBikiniBoss()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoBikiniSeaFloor : ProtoBase, IProtocol
{
    public static string TableName => "bikiniSeaFloor";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int CurFloor
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public Dictionary<int, FloorInfo> Floors
    {
        get;
        set;
    } = [];

    [ProtoMember(4)]
    public List<int> DeadGirls
    {
        get;
        set;
    } = [];

    [ProtoMember(5)]
    public List<ProtoBattleMonsterStatus> Monster
    {
        get;
        set;
    } = [];

    [ProtoMember(6)]
    public Dictionary<int, ProtoRoleBattleGroup> BattleGroup
    {
        get;
        set;
    } = [];

    [ProtoMember(15)]
    public Dictionary<int, ProtoGirlBattleStatus> GirlsStatus
    {
        get;
        set;
    } = [];

    [ProtoMember(7)]
    public Dictionary<int, int> Treasure
    {
        get;
        set;
    } = [];

    [ProtoMember(8)]
    public long LastWeek
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public int WeekNum
    {
        get;
        set;
    }

    [ProtoMember(10)]
    public int Revive
    {
        get;
        set;
    }

    [ProtoMember(11)]
    public int Bless
    {
        get;
        set;
    }

    [ProtoMember(12)]
    public long NextWeek
    {
        get;
        set;
    }

    [ProtoMember(13)]
    public List<int> PassStageIds
    {
        get;
        set;
    } = [];

    [ProtoMember(14)]
    public bool UseBless
    {
        get;
        set;
    }

    public ProtoBikiniSeaFloor()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoBikiniStage : ProtoBase, IProtocol
{
    public static string TableName => "bikiniStage";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int StarMark
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public StageStatus Status
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public int CompleteCount
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public ObjState State
    {
        get;
        set;
    }

    public ProtoBikiniStage()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoBikiniStageMission : ProtoBase, IProtocol
{
    public static string TableName => "bikiniStageMission";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int StarMark
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public int CompleteCount
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public ObjState State
    {
        get;
        set;
    }

    [ProtoMember(14)]
    public long CreateTime
    {
        get;
        set;
    }

    public ProtoBikiniStageMission()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoBikiniTask : ProtoBase, IProtocol
{
    public static string TableName => "bikiniTask";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public short Process
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public RewardGetState RewardState
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public ObjState State
    {
        get;
        set;
    }

    public ProtoBikiniTask()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoBuild : ProtoBase, IProtocol
{
    public static string TableName => "build";

    [ProtoMember(1)]
    public string Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int RecruitDataId
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public long StartTime
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public long EndTime
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public int RecruitLibraryId
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public ObjState State
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public RecruitSubTypes RecruitSubType
    {
        get;
        set;
    }

    [ProtoMember(220)]
    public string CostInfo
    {
        get;
        set;
    }

    public ProtoBuild()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoCG : ProtoBase, IProtocol
{
    public static string TableName => "cg";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public long CreateTime
    {
        get;
        set;
    }

    public ProtoCG()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoCharge : ProtoBase, IProtocol
{
    public static string TableName => "charge";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int TotalTimes
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public long ResetTime
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int Times
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public long EndTime
    {
        get;
        set;
    }

    public ProtoCharge()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoChatMessage : IProtocol
{
    [ProtoMember(1)]
    public string ChatMessageId
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public ChatChannels ChatType
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public NoticeTypes NoticeType
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public long FromId
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public string FromName
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public int BountyPoint
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public string UnionId
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public long ToId
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public string ToName
    {
        get;
        set;
    }

    [ProtoMember(10)]
    public int ToBountyPoint
    {
        get;
        set;
    }

    [ProtoMember(11)]
    public string Content
    {
        get;
        set;
    }

    [ProtoMember(12)]
    public long SendTime
    {
        get;
        set;
    }

    [ProtoMember(13)]
    public ProtoWidget Widget
    {
        get;
        set;
    }

    [ProtoMember(14)]
    public ProtoGirl Girl
    {
        get;
        set;
    }

    [ProtoMember(15)]
    public string Param1
    {
        get;
        set;
    }

    [ProtoMember(16)]
    public string Param2
    {
        get;
        set;
    }

    [ProtoMember(17)]
    public string Param3
    {
        get;
        set;
    }

    [ProtoMember(18)]
    public int ItemId
    {
        get;
        set;
    }

    [ProtoMember(19)]
    public int IconID
    {
        get;
        set;
    }

    [ProtoMember(20)]
    public int NationRoomId
    {
        get;
        set;
    }

    [ProtoMember(21)]
    public NationWarFalg NationCampType
    {
        get;
        set;
    }

    [ProtoMember(22)]
    public string Param4
    {
        get;
        set;
    }

    public ProtoChatMessage()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoChipAttribute : IProtocol
{
    [ProtoMember(1)]
    public string AttributeName
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public float AttributeValue
    {
        get;
        set;
    }

    public ProtoChipAttribute()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoChristmas : ProtoBase, IProtocol
{
    [ProtoMember(25)]
    public SortedDictionary<int, int> CellRndPrize;

    public static string TableName => "christmas";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int TotalStage
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int Stage
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int Pos
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int NextPos
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public bool IsFate
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public int EventId
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public int EventArg1
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public int EventArg2
    {
        get;
        set;
    }

    [ProtoMember(10)]
    public int ReFreshCount
    {
        get;
        set;
    }

    [ProtoMember(11)]
    public List<string> EventHistory
    {
        get;
        set;
    } = [];

    [ProtoMember(12)]
    public int SlowNum
    {
        get;
        set;
    }

    [ProtoMember(13)]
    public int StayStatus
    {
        get;
        set;
    }

    [ProtoMember(14)]
    public int TotalCellNum
    {
        get;
        set;
    }

    [ProtoMember(15)]
    public List<int> TotalCellPrizes
    {
        get;
        set;
    } = [];

    [ProtoMember(17)]
    public int LuckCount
    {
        get;
        set;
    }

    [ProtoMember(18)]
    public int Doubled
    {
        get;
        set;
    }

    [ProtoMember(19)]
    public int Dreamed
    {
        get;
        set;
    }

    [ProtoMember(20)]
    public bool Stayed
    {
        get;
        set;
    }

    [ProtoMember(21)]
    public bool Slowed
    {
        get;
        set;
    }

    [ProtoMember(22)]
    public bool God
    {
        get;
        set;
    }

    [ProtoMember(23)]
    public int StaedNum
    {
        get;
        set;
    }

    public ProtoChristmas()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoChristmasMission : ProtoBase, IProtocol
{
    public static string TableName => "christmasMission";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Process
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public RewardGetState RewardState
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public ObjState State
    {
        get;
        set;
    }

    public ProtoChristmasMission()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoCollect : ProtoBase, IProtocol
{
    public static string TableName => "collect";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int CollectCount
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public CollectTypes CollectType
    {
        get;
        set;
    }

    public ProtoCollect()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoCombinedMachineStatus : IProtocol
{
    [ProtoMember(1)]
    public int Process
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Hp
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int Mp
    {
        get;
        set;
    }

    public ProtoCombinedMachineStatus()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoCriticalPointAchievement : ProtoBase, IProtocol
{
    public static string TableName => "criticalPointAchievement";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public short Process
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public RewardGetState RewardState
    {
        get;
        set;
    }

    public ProtoCriticalPointAchievement()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoCriticalPointJackpot : ProtoBase, IProtocol
{
    public static string TableName => "criticalPointJackpot";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public List<CriticalPointRewardPoolCell> CurrentRewardPool
    {
        get;
        set;
    } = [];

    [ProtoMember(3)]
    public List<int> RewardIndexList
    {
        get;
        set;
    } = [];

    [ProtoMember(4)]
    public Dictionary<int, int> RewardedDatas
    {
        get;
        set;
    } = [];

    [ProtoMember(5)]
    public bool IsHaveFreeResetTimes
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public int LuckyValue
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public JackpotID JackpotType
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public int RewardPoolFreeResetTimes
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public int RewardPoolGoldResetTimes
    {
        get;
        set;
    }

    [ProtoMember(10)]
    public int CurrJackpotDrawTimes
    {
        get;
        set;
    }

    public ProtoCriticalPointJackpot()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoCriticalPointMission : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public short CompleteCount
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public byte StarMark
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int DropCtrlCount
    {
        get;
        set;
    }

    public ProtoCriticalPointMission()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoCriticalPointStage : ProtoBase, IProtocol
{
    public static string TableName => "criticalPointStage";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public Dictionary<int, ProtoCriticalPointMission> ActivityMissions
    {
        get;
        set;
    } = [];

    [ProtoMember(3)]
    public int ChallengeTimes
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public long ChallengeRefreshTime
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public long ActivityOpenTime
    {
        get;
        set;
    }

    [ProtoMember(10)]
    public long ActivityCloseTime
    {
        get;
        set;
    }

    public ProtoCriticalPointStage()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoDailyFlag : ProtoBase, IProtocol
{
    public static string TableName => "dailyflag";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int FreeTenRecruitTimes
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int FreeATBossChallengeTimes
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int NationalWarPVETimes
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int NationalWarPVPTimes
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public int FreeReviveTimes
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public int PaidReviveTimes
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public int RecievePhaseAwardTimes
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public int SeasonBuyTicketTimes
    {
        get;
        set;
    }

    [ProtoMember(10)]
    public int NationFinalWarBuyTicketTimes
    {
        get;
        set;
    }

    [ProtoMember(11)]
    public int SakuraWarsShootingTimes
    {
        get;
        set;
    }

    [ProtoMember(12)]
    public int BeforeDawnShootingTimes
    {
        get;
        set;
    }

    [ProtoMember(13)]
    public int StarShipWeaponShopBuyTimes
    {
        get;
        set;
    }

    public ProtoDailyFlag()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoEffectChange : IProtocol
{
    [ProtoMember(1)]
    public int BuffId
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public BuffType EffectChangeType
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int ChangeValue
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public BuffExclusionStatus BuffExclusionStatus
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public AddBuffTiming BuffTiming
    {
        get;
        set;
    }

    public ProtoEffectChange()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoEffectiveTenRecruitTime : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public List<ProtoTenRecruitConfig> EffectiveCfgs
    {
        get;
        set;
    } = [];

    public ProtoEffectiveTenRecruitTime()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoEVAAreaRepairInfo : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public Dictionary<int, int> AreaRepairInfo
    {
        get;
        set;
    } = [];

    public ProtoEVAAreaRepairInfo()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoEVABase : ProtoBase, IProtocol
{
    public static string TableName => "evabase";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Phy
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int ChallengedTimes
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int BoughtTicketTimes
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public Dictionary<int, int> AreaDonation
    {
        get;
        set;
    } = [];

    [ProtoMember(6)]
    public long LastCalcPhyTimestamp
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public long LastRecoverChallengeTimesTS
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public int BoughtPhyTimes
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public Dictionary<int, int> LimitBossDic
    {
        get;
        set;
    } = [];

    [ProtoMember(10)]
    public List<string> HaveRecievedAwardFlags
    {
        get;
        set;
    } = [];

    [ProtoMember(11)]
    public List<int> AreaAwardFlags
    {
        get;
        set;
    } = [];

    [ProtoMember(12)]
    public List<int> ShopAwardFlag
    {
        get;
        set;
    } = [];

    [ProtoMember(13)]
    public int StageDropPilotItemNum
    {
        get;
        set;
    }

    [ProtoMember(14)]
    public Dictionary<string, List<ProtoBattleMonsterStatus>> LimitBossHP
    {
        get;
        set;
    } = [];

    public ProtoEVABase()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoEVAChapter : ProtoBase, IProtocol
{
    public static string TableName => "evachapter";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public Dictionary<int, ProtoEVADiffDesc> StageInfo
    {
        get;
        set;
    } = [];

    public ProtoEVAChapter()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoEVADiffDesc : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int DiffId
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int CurOrder
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public Dictionary<int, int> StarInfo
    {
        get;
        set;
    } = [];

    [ProtoMember(4)]
    public List<int> RecieveAreaStarAward
    {
        get;
        set;
    } = [];

    [ProtoMember(5)]
    public Dictionary<int, int> DailyBattleTimes
    {
        get;
        set;
    } = [];

    public ProtoEVADiffDesc()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoEVAGirl : ProtoBase, IProtocol
{
    public static string TableName => "evagirl";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Likeability
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public List<int> RecievedAwards
    {
        get;
        set;
    } = [];

    public ProtoEVAGirl()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoEVAOrder : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int ID
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public bool IsUnlock
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int OrderID
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int ReduceTimeLength
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public long StartTimestamp
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public int TechEffectReduceTimeLength
    {
        get;
        set;
    }

    public ProtoEVAOrder()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoEVATechRoom : ProtoBase, IProtocol
{
    public static string TableName => "evatechroom";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Level
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int Exp
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public Dictionary<int, ProtoEVAOrder> ResearchInfo
    {
        get;
        set;
    } = [];

    [ProtoMember(5)]
    public Dictionary<int, int> OrderCount
    {
        get;
        set;
    } = [];

    public ProtoEVATechRoom()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoEveOfNationalWarPVE : ProtoBase, IProtocol
{
    public static string TableName => "eveofnationalwarpve";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int CurTier
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public Dictionary<int, ProtoRoleBattleGroup> CurGirls
    {
        get;
        set;
    } = [];

    [ProtoMember(4)]
    public Dictionary<int, ProtoGirlBattleStatus> GirlsStatus
    {
        get;
        set;
    } = [];

    [ProtoMember(5)]
    public List<ProtoBattleMonsterStatus> CurMonstersHP
    {
        get;
        set;
    } = [];

    [ProtoMember(6)]
    public Dictionary<int, ProtoCombinedMachineStatus> CombinedMachineStatus
    {
        get;
        set;
    } = [];

    public ProtoEveOfNationalWarPVE()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoEveOfNationalWarPVP : ProtoBase, IProtocol
{
    public static string TableName => "eveofnationalwarpvp";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public long EnemyUserId
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public long EffectiveTS
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public Dictionary<int, ProtoRoleBattleGroup> CurGirls
    {
        get;
        set;
    } = [];

    [ProtoMember(5)]
    public bool IsClear
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public int point
    {
        get;
        set;
    }

    public ProtoEveOfNationalWarPVP()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoExpeditionMission : ProtoBase, IProtocol
{
    public static string TableName => "expeditionMission";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int MissionId
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public long StartTime
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public long EndTime
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public bool IsBigSuccess
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public Dictionary<string, ProtoGirlLevelInfo> WidgetGroups
    {
        get;
        set;
    } = [];

    [ProtoMember(7)]
    public int AreaId
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public ExpeditionMissionGetTypes MissionGetTypes
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public ExpeditionMissionStatus MissionStatus
    {
        get;
        set;
    }

    [ProtoMember(10)]
    public ExpeditionMissionTypes MissionType
    {
        get;
        set;
    }

    [ProtoMember(11)]
    public long MissionTime
    {
        get;
        set;
    }

    [ProtoMember(12)]
    public ObjState State
    {
        get;
        set;
    }

    public ProtoExpeditionMission()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoExploreEventsLog : IProtocol
{
    [ProtoMember(1)]
    public ExploreEventType Type
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public long Time
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public string ItemStr
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int Value
    {
        get;
        set;
    }

    public ProtoExploreEventsLog()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoFighterDesc : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public long Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public string BattleDesc
    {
        get;
        set;
    }

    public ProtoFighterDesc()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoFriend : ProtoBase, IProtocol
{
    public static string TableName => "friend";

    [ProtoMember(1)]
    public long Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public FriendTypes FriendType
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public RewardGetState FriendGiftState
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public long GiveGiftTime
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public long BecomeFriendTime
    {
        get;
        set;
    }

    [ProtoMember(10)]
    public ObjState State
    {
        get;
        set;
    }

    public ProtoFriend()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoFriendData : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int StoryProgress
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int UnLockArea
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int StageProgress
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int WidgetCount
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int WeaponCount
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public int GirlCount
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public int GirlSSRCount
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public int BountyPoint
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public int MissionCompleteCount
    {
        get;
        set;
    }

    [ProtoMember(10)]
    public int HotMissionCompleteCount
    {
        get;
        set;
    }

    [ProtoMember(11)]
    public int BattleMaxDamage
    {
        get;
        set;
    }

    [ProtoMember(12)]
    public int StageMaxDamage
    {
        get;
        set;
    }

    [ProtoMember(13)]
    public int SkillEnemyCount
    {
        get;
        set;
    }

    [ProtoMember(14)]
    public int UseSkillCount
    {
        get;
        set;
    }

    [ProtoMember(15)]
    public DateTime BirthDay
    {
        get;
        set;
    }

    [ProtoMember(16)]
    public int PlayerExp
    {
        get;
        set;
    }

    [ProtoMember(17)]
    public int FriendCount
    {
        get;
        set;
    }

    [ProtoMember(18)]
    public int CollectWidgetCount
    {
        get;
        set;
    }

    public ProtoFriendData()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoFriendGirlInfo : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int GirlId
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int GirlSkinId
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int Level
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int StarLevel
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int BattlePower
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public Dictionary<WidgetType, int> Widgets
    {
        get;
        set;
    } = [];

    public ProtoFriendGirlInfo()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoFriendInfo : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public long Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int HeadGirlId
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int HeadGirlSkinId
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int HeadGirlLevel
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int HeadGirlStarLevel
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public int Level
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public string Name
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public int PlayerTitle
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public long LastLoginTime
    {
        get;
        set;
    }

    [ProtoMember(10)]
    public int BattlePower
    {
        get;
        set;
    }

    [ProtoMember(11)]
    public ProtoFriendGirlInfo[] Girls
    {
        get;
        set;
    }

    [ProtoMember(12)]
    public ProtoFriendData FriendData
    {
        get;
        set;
    }

    public ProtoFriendInfo()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoGacya : ProtoBase, IProtocol
{
    public static string TableName => "gacya";

    [ProtoMember(1)]
    public BikiniGacyaType Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int GacyaId
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public Dictionary<int, int> CurRaffleInfo
    {
        get;
        set;
    } = [];

    [ProtoMember(4)]
    public int LeftNum
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public List<int> CompleteGacyaIds
    {
        get;
        set;
    } = [];

    [ProtoMember(6)]
    public Dictionary<int, ProtoGacyaHistory> RaffleHistories
    {
        get;
        set;
    } = [];

    public ProtoGacya()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoGacyaHistory : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public Dictionary<int, int> RaffleInfo
    {
        get;
        set;
    } = [];

    [ProtoMember(3)]
    public int LeftNum
    {
        get;
        set;
    }

    public ProtoGacyaHistory()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoGhostMission : ProtoBase, IProtocol
{
    public static string TableName => "ghostMission";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Process
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public RewardGetState RewardState
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int CompleteTime
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public ObjState State
    {
        get;
        set;
    }

    public ProtoGhostMission()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoGirl : ProtoBase, IProtocol
{
    public static string TableName => "girl";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public string WidgetGroupId
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int Level
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int Exp
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public int StarLevel
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public Dictionary<int, int> SkillLeveList
    {
        get;
        set;
    } = [];

    [ProtoMember(10)]
    public int CurrentSKinId
    {
        get;
        set;
    }

    [ProtoMember(12)]
    public List<int> Skins
    {
        get;
        set;
    } = [];

    [ProtoMember(13)]
    public long CreateTime
    {
        get;
        set;
    }

    [ProtoMember(14)]
    public int GoodwillExp
    {
        get;
        set;
    }

    [ProtoMember(15)]
    public int GoodwillLevel
    {
        get;
        set;
    }

    [ProtoMember(16)]
    public bool Wedding
    {
        get;
        set;
    }

    [ProtoMember(17)]
    public int RoomPos
    {
        get;
        set;
    }

    [ProtoMember(18)]
    public int Energy
    {
        get;
        set;
    }

    [ProtoMember(19)]
    public Dictionary<int, GirlNature> NatureDic
    {
        get;
        set;
    } = [];

    [ProtoMember(20)]
    public List<int> UsedSkillIDs
    {
        get;
        set;
    } = [];

    [ProtoMember(21)]
    public List<int> UnusedSkillIDs
    {
        get;
        set;
    } = [];

    [ProtoMember(22)]
    public bool ActiveBirth
    {
        get;
        set;
    }

    [ProtoMember(23)]
    public int BirthdayPresentGetYear
    {
        get;
        set;
    }

    [ProtoMember(24)]
    public int TouchSoundID
    {
        get;
        set;
    }

    [ProtoMember(25)]
    public bool GetWeddingDress
    {
        get;
        set;
    }

    [ProtoMember(26)]
    public int TalentLayer
    {
        get;
        set;
    }

    [ProtoMember(27)]
    public List<int> TalentID
    {
        get;
        set;
    } = [];

    [ProtoMember(28)]
    public GirlQualityType GirlQualityType
    {
        get;
        set;
    }

    [ProtoMember(29)]
    public int AwakeLevel
    {
        get;
        set;
    }

    [ProtoMember(30)]
    public int StarShipId
    {
        get;
        set;
    }

    [ProtoMember(31)]
    public int GrilScore
    {
        get;
        set;
    }

    public ProtoGirl()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoGirlBattleStatus : IProtocol
{
    [ProtoMember(1)]
    public int Hp
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Power
    {
        get;
        set;
    }

    public ProtoGirlBattleStatus()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoGirlBubble : ProtoBase, IProtocol
{
    public static string TableName => "girlbubblestep";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Step
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public BubbleProcessStatus Status
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int RefreshNum
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public Dictionary<int, int> RandomBubbleDic
    {
        get;
        set;
    } = [];

    [ProtoMember(6)]
    public BubbleInfo BubbleInfo
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public int TodayEnergyCost
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public int TodayExpedition
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public long TimeFlag
    {
        get;
        set;
    }

    [ProtoMember(10)]
    public List<int> UnlockSlots
    {
        get;
        set;
    } = [];

    public ProtoGirlBubble()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoGirlLevelInfo : IProtocol
{
    [ProtoMember(1)]
    public int Level
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Exp
    {
        get;
        set;
    }

    public ProtoGirlLevelInfo()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoGirlMirror : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int GirlId
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int SkinId
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int Power
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public bool IsActivated
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public Dictionary<string, float> AttrDic
    {
        get;
        set;
    } = [];

    [ProtoMember(6)]
    public Dictionary<WidgetType, int> WidgetDic
    {
        get;
        set;
    } = [];

    [ProtoMember(7)]
    public Dictionary<int, int> SkillDic
    {
        get;
        set;
    } = [];

    [ProtoMember(8)]
    public GirlQualityType GirlQuality
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public int GirlLevel
    {
        get;
        set;
    }

    public ProtoGirlMirror()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoGirlSkinConfig : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public string OpenTime
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public string CloseTime
    {
        get;
        set;
    }

    public ProtoGirlSkinConfig()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoHistoryView : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public Dictionary<HistoricalRecordTypes, int> HistoricalRecordDatas
    {
        get;
        set;
    } = [];

    public ProtoHistoryView()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoHonor : ProtoBase, IProtocol
{
    public static string TableName => "honor";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public Dictionary<OpenArea, int> HonorAreaLock
    {
        get;
        set;
    } = [];

    [ProtoMember(3)]
    public Dictionary<int, int> HonorItemList
    {
        get;
        set;
    } = [];

    [ProtoMember(4)]
    public Dictionary<int, int> QuestionList
    {
        get;
        set;
    } = [];

    [ProtoMember(5)]
    public int Level
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public long HonorVal
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public Dictionary<int, int> HonorAllItemList
    {
        get;
        set;
    } = [];

    [ProtoMember(8)]
    public bool GetTodayReward
    {
        get;
        set;
    }

    public ProtoHonor()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoHonorBase : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public Dictionary<OpenArea, int> HonorAreaLock
    {
        get;
        set;
    } = [];

    [ProtoMember(3)]
    public Dictionary<int, int> HonorItemList
    {
        get;
        set;
    } = [];

    [ProtoMember(5)]
    public int Level
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public long HonorVal
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public Dictionary<int, int> HonorAllItemList
    {
        get;
        set;
    } = [];

    public ProtoHonorBase()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoItem : ProtoBase, IProtocol
{
    public static string TableName => "item";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Num
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public ObjState State
    {
        get;
        set;
    }

    public ProtoItem()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoMail : ProtoBase, IProtocol
{
    public static string TableName => "mail";

    [ProtoMember(1)]
    public string Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public string Title
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public string Content
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public string Attachment
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public long CreateTime
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public long ExpirationTime
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public string SysMailId
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public int MailTemplateId
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public string MailTemplateParam1
    {
        get;
        set;
    }

    [ProtoMember(10)]
    public string MailTemplateParam2
    {
        get;
        set;
    }

    [ProtoMember(11)]
    public string MailTemplateParam3
    {
        get;
        set;
    }

    [ProtoMember(12)]
    public bool IsDeleted
    {
        get;
        set;
    }

    [ProtoMember(13)]
    public bool IsCharge
    {
        get;
        set;
    }

    [ProtoMember(220)]
    public FGMailType MailType
    {
        get;
        set;
    }

    public ProtoMail()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoMCVBase : ProtoBase, IProtocol
{
    public static string TableName => "mcvbase";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int CurLevel
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public List<int> UnlockRoomIds
    {
        get;
        set;
    } = [];

    [ProtoMember(4)]
    public int CurStatus
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public long StartTimestamp
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public ProtoMCVLowCostInfo LowCostInfo
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public ProtoMCVLeakSourceInfo LeakSourceInfo
    {
        get;
        set;
    }

    public ProtoMCVBase()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoMCVDispatchGirlInfo : IProtocol
{
    [ProtoMember(1)]
    public long EnterTimestamp
    {
        get;
        set;
    }

    public ProtoMCVDispatchGirlInfo()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoMCVLeakSourceInfo : IProtocol
{
    [ProtoMember(1)]
    public bool IsLeakSourceStatus
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public long LastCostSourceTimestamp
    {
        get;
        set;
    }

    public ProtoMCVLeakSourceInfo()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoMCVLowCostInfo : IProtocol
{
    [ProtoMember(1)]
    public bool IsLowCostStatus
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public long EnterLowCostTimestamp
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public long EnterHours
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public long HaveUsedHours
    {
        get;
        set;
    }

    public ProtoMCVLowCostInfo()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoMCVPreTaskActivity : ProtoBase, IProtocol
{
    public static string TableName => "mvcpretask";

    [ProtoMember(1)]
    public int ActId
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public List<ProtoMCVPreTaskRoomInfo> RoomsInfo
    {
        get;
        set;
    } = [];

    [ProtoMember(3)]
    public string StageIds
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public bool IsFistPlayPlot
    {
        get;
        set;
    }

    public ProtoMCVPreTaskActivity()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoMCVPreTaskRoomInfo : IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int RoomId
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public EPreCarRoomState CurStatus
    {
        get;
        set;
    }

    [ProtoMember(220)]
    public long BeginRepairTime
    {
        get;
        set;
    }

    public ProtoMCVPreTaskRoomInfo()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoMCVRoom : ProtoBase, IProtocol
{
    public static string TableName => "mcvroom";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int RoomID
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int RoomLevel
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int RoomPos
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int SrcRoom
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public int CurStatus
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public int DesRoom
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public long StartTimestamp
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public Dictionary<int, ProtoMCVDispatchGirlInfo> DispatchedGirls
    {
        get;
        set;
    } = [];

    [ProtoMember(10)]
    public int ProduceStatus
    {
        get;
        set;
    }

    [ProtoMember(11)]
    public ProtoMCVRoomProduce ProduceSourceInfo
    {
        get;
        set;
    }

    [ProtoMember(12)]
    public ProtoMCVRoomOrderProcess ProduceOrderInfo
    {
        get;
        set;
    }

    public ProtoMCVRoom()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoMCVRoomOrder : IProtocol
{
    [ProtoMember(1)]
    public int OrderID
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public long StartCountDownTS
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int OrderCompleteCycle
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int AddPercent
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int OrderStatus
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public bool CostEnergyFlag
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public List<int> CostSuccGirlIds
    {
        get;
        set;
    } = [];

    [ProtoMember(8)]
    public int UsedChips
    {
        get;
        set;
    }

    public ProtoMCVRoomOrder()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoMCVRoomOrderProcess : IProtocol
{
    [ProtoMember(1)]
    public long LastStopTimestamp
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public List<ProtoMCVRoomOrder> OrderList
    {
        get;
        set;
    } = [];

    [ProtoMember(3)]
    public Dictionary<int, List<int>> OrderConfIds
    {
        get;
        set;
    } = [];

    public ProtoMCVRoomOrderProcess()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoMCVRoomProduce : IProtocol
{
    [ProtoMember(1)]
    public long LastStopTimestamp
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public long LastStartTimestamp
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public long CurEffectCycle
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int AddPercent
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public bool CostEnergyFlag
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public List<int> CostSuccGirlIds
    {
        get;
        set;
    } = [];

    [ProtoMember(7)]
    public Dictionary<int, int> haveProduced
    {
        get;
        set;
    } = [];

    public ProtoMCVRoomProduce()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoMiniMission : ProtoBase, IProtocol
{
    public static string TableName => "miniMission";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public Dictionary<int, MiniMission> MissionList
    {
        get;
        set;
    } = [];

    [ProtoMember(3)]
    public int Ver
    {
        get;
        set;
    }

    public ProtoMiniMission()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoMonthMission : ProtoBase, IProtocol
{
    [ProtoMember(5)]
    public Dictionary<int, MonthLevelReward> LevelRewardState = [];

    public static string TableName => "monthMission";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int ActivityId
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int LevelProc
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int CurrLevel
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public Dictionary<int, MonthMission> MissionList
    {
        get;
        set;
    } = [];

    [ProtoMember(7)]
    public bool Mainlock
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public long LastWeek
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public bool RewardFinished
    {
        get;
        set;
    }

    public ProtoMonthMission()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoNationalWar : ProtoBase, IProtocol
{
    public static string TableName => "nationalwar";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public NationWarFalg RegisterCampType
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public NationWarFalg CampType
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int BornHex
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int CurrArmyId
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public Dictionary<int, ProtoRoleBattleGroup> PVEGroup
    {
        get;
        set;
    } = [];

    [ProtoMember(7)]
    public Dictionary<int, ProtoRoleBattleGroup> PVPGroup
    {
        get;
        set;
    } = [];

    [ProtoMember(8)]
    public int RoomID
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public Dictionary<int, List<int>> StationedGirlIds
    {
        get;
        set;
    } = [];

    [ProtoMember(10)]
    public Dictionary<int, int> StationedMirror
    {
        get;
        set;
    } = [];

    [ProtoMember(11)]
    public bool IsRecieveAward
    {
        get;
        set;
    }

    [ProtoMember(12)]
    public int pvpTimes
    {
        get;
        set;
    }

    [ProtoMember(13)]
    public int pvpWinTimes
    {
        get;
        set;
    }

    [ProtoMember(14)]
    public long SilverTicketTS
    {
        get;
        set;
    }

    [ProtoMember(15)]
    public long GoldenTicketTS
    {
        get;
        set;
    }

    [ProtoMember(16)]
    public int TotalHonorPoints
    {
        get;
        set;
    }

    [ProtoMember(17)]
    public int TmpStationNum
    {
        get;
        set;
    }

    [ProtoMember(18)]
    public int TmpPvpTimes
    {
        get;
        set;
    }

    [ProtoMember(19)]
    public int TmpPvpWinTimes
    {
        get;
        set;
    }

    [ProtoMember(20)]
    public long SilverTicket
    {
        get;
        set;
    }

    [ProtoMember(21)]
    public long GoldenTicket
    {
        get;
        set;
    }

    public ProtoNationalWar()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoNationalWarBattleDesc : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public ProtoNationalWarFighterDesc Winner
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public ProtoNationalWarFighterDesc Loser
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public long BattleEndTime
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public bool Reported
    {
        get;
        set;
    }

    public ProtoNationalWarBattleDesc()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoNationalWarCampInfo : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public long Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int BgGirl
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int Level
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public string Name
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int PlayerTitle
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public long LastLoginTime
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public long Power
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public NationWarFalg CampType
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public int CurrArmyId
    {
        get;
        set;
    }

    public ProtoNationalWarCampInfo()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoNationalWarFighterDesc : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public long Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public string BattleDesc
    {
        get;
        set;
    }

    public ProtoNationalWarFighterDesc()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoNationalWarFightLog : ProtoBase, IProtocol
{
    public static string TableName => "nationalwarfightlog";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public List<ProtoNationalWarBattleDesc> BattleLogs
    {
        get;
        set;
    } = [];

    [ProtoMember(3)]
    public int BattleCount
    {
        get;
        set;
    }

    public ProtoNationalWarFightLog()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoNationalWarHexStatus : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public long OwnerID
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public NationWarFalg CampID
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public List<int> GirlIds
    {
        get;
        set;
    } = [];

    [ProtoMember(5)]
    public long MirrorID
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public long TmpUserID
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public bool TmpIsWin
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public long TmpEffectTS
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public long TmpDispatchTS
    {
        get;
        set;
    }

    [ProtoMember(10)]
    public List<int> TmpUsedGirlIds
    {
        get;
        set;
    } = [];

    [ProtoMember(11)]
    public long monsterDamage
    {
        get;
        set;
    }

    [ProtoMember(12)]
    public long LastDispatchHonorTS
    {
        get;
        set;
    }

    [ProtoMember(13)]
    public long LastOwnerID
    {
        get;
        set;
    }

    [ProtoMember(14)]
    public List<ProtoBattleMonsterStatus> CurMonstersHP
    {
        get;
        set;
    } = [];

    public ProtoNationalWarHexStatus()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoNationalWarRoomInfo : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public Dictionary<int, Dictionary<int, List<long>>> players
    {
        get;
        set;
    } = [];

    public ProtoNationalWarRoomInfo()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoNavSceneData : IProtocol
{
    [ProtoMember(1)]
    public NavMapProtoBufData navMapData;

    [ProtoMember(2)]
    public NavCameraProtoBufData navCameraProtoBufData;

    [ProtoMember(3)]
    public List<NavStatisticsProtoBufData> navStatisticsDatas = [];

    [ProtoMember(4)]
    public List<MapBattleData> mapBattleDatas = [];

    [ProtoMember(10)]
    public List<NavPlayerProtoBufData> navPlayerDatas = [];

    [ProtoMember(11)]
    public List<NavAIProtoBufData> navAIDatas = [];

    [ProtoMember(12)]
    public List<NavTriggerData> navTriggerDatas = [];

    [ProtoMember(13)]
    public List<NavEventData> navEventDatas = [];

    [ProtoMember(14)]
    public List<NavTriggerOnceData> navTriggerOnceDatas = [];

    [ProtoMember(20)]
    public List<NavBombAreaData> navBombAreaDatas = [];

    public ProtoNavSceneData()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoNewYearBoss : ProtoBase, IProtocol
{
    public static string TableName => "newYearBoss";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int CurrentFloor
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int LestSpendTime
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public Dictionary<int, long> Scores
    {
        get;
        set;
    } = [];

    [ProtoMember(5)]
    public Dictionary<int, NewYearBossMissions> Missions
    {
        get;
        set;
    } = [];

    [ProtoMember(6)]
    public long LastRefreshTime
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public int WeekNum
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public long NextWeek
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public List<int> SelectedSkill
    {
        get;
        set;
    } = [];

    [ProtoMember(10)]
    public int BattleFloor
    {
        get;
        set;
    }

    [ProtoMember(11)]
    public int FloorMaxDamage
    {
        get;
        set;
    }

    [ProtoMember(12)]
    public int FinalyRank
    {
        get;
        set;
    }

    [ProtoMember(13)]
    public List<TeamMember> BattleTeam
    {
        get;
        set;
    } = [];

    [ProtoMember(14)]
    public int Ver
    {
        get;
        set;
    }

    [ProtoMember(15)]
    public int BuyTimes
    {
        get;
        set;
    }

    [ProtoMember(16)]
    public List<int> CalOk
    {
        get;
        set;
    } = [];

    public ProtoNewYearBoss()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoNightmareStage : ProtoBase, IProtocol
{
    public static string TableName => "nightmareStage";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int DailyCompleteCount
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public bool IsGetFirstCompleteReward
    {
        get;
        set;
    }

    public ProtoNightmareStage()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoNotice : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public string NoticeName
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public string NoticeContent
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int Array
    {
        get;
        set;
    }

    public ProtoNotice()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoOrderLoginNine : ProtoBase, IProtocol
{
    public static string TableName => "orderLoginNine";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public RewardGetState SevenSigninStatus
    {
        get;
        set;
    }

    public ProtoOrderLoginNine()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoPang : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public long ServerTime
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public long DelaySeconds
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int Timezone
    {
        get;
        set;
    }

    [ProtoMember(200)]
    public int NoticeVer
    {
        get;
        set;
    }

    public ProtoPang()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoPayRecruit : ProtoBase, IProtocol
{
    [ProtoMember(2)]
    public int Round;

    public static string TableName => "payrecruit";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    public ProtoPayRecruit()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoPlayer : ProtoBase, IProtocol
{
    public static string TableName => "player";

    [ProtoMember(2)]
    public string Name
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int Level
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int Exp
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public long CreateTime
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public long LastLoginTime
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public long LastLogoutTime
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public int AttackLevel
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public int AttackExp
    {
        get;
        set;
    }

    [ProtoMember(10)]
    public int DefenceLevel
    {
        get;
        set;
    }

    [ProtoMember(11)]
    public int DefenceExp
    {
        get;
        set;
    }

    [ProtoMember(12)]
    public int ProtectLevel
    {
        get;
        set;
    }

    [ProtoMember(13)]
    public int ProtectExp
    {
        get;
        set;
    }

    [ProtoMember(14)]
    public int LeaderLevel
    {
        get;
        set;
    }

    [ProtoMember(15)]
    public int LeaderExp
    {
        get;
        set;
    }

    [ProtoMember(16)]
    public int PromotionMissionId
    {
        get;
        set;
    }

    [ProtoMember(17)]
    public int OpenedRecruitQueueNum
    {
        get;
        set;
    }

    [ProtoMember(18)]
    public int OpenedBuildQueueNum
    {
        get;
        set;
    }

    [ProtoMember(19)]
    public int WidgetPackageCount
    {
        get;
        set;
    }

    [ProtoMember(20)]
    public int RecruitValue
    {
        get;
        set;
    }

    [ProtoMember(21)]
    public int BuildValue
    {
        get;
        set;
    }

    [ProtoMember(22)]
    public int BgGirlId
    {
        get;
        set;
    }

    [ProtoMember(23)]
    public int LimitBuildValue
    {
        get;
        set;
    }

    [ProtoMember(24)]
    public bool IsPlayerInfoComplete
    {
        get;
        set;
    }

    [ProtoMember(25)]
    public DateTime BirthDay
    {
        get;
        set;
    }

    [ProtoMember(26)]
    public Dictionary<int, int> Guides
    {
        get;
        set;
    } = [];

    [ProtoMember(28)]
    public int PlayerTitle
    {
        get;
        set;
    }

    [ProtoMember(29)]
    public int TotalRecharge
    {
        get;
        set;
    }

    [ProtoMember(30)]
    public long MonthCardTimeout
    {
        get;
        set;
    }

    [ProtoMember(31)]
    public long LastGetMonthCardRewardTime
    {
        get;
        set;
    }

    [ProtoMember(32)]
    public int GetTotalRewardDays
    {
        get;
        set;
    }

    [ProtoMember(33)]
    public long LastGetTotalRechargeRewardTime
    {
        get;
        set;
    }

    [ProtoMember(34)]
    public long LastRefreshTime
    {
        get;
        set;
    }

    [ProtoMember(35)]
    public int LastStageId
    {
        get;
        set;
    }

    [ProtoMember(36)]
    public Dictionary<int, int> AreaMissionHistory
    {
        get;
        set;
    } = [];

    [ProtoMember(37)]
    public long SixHourMissionRefreshTime
    {
        get;
        set;
    }

    [ProtoMember(39)]
    public int PersonalStoryDailyCount
    {
        get;
        set;
    }

    [ProtoMember(40)]
    public long LastActivityTime
    {
        get;
        set;
    }

    [ProtoMember(41)]
    public int Battle_StageId
    {
        get;
        set;
    }

    [ProtoMember(42)]
    public int Battle_BattleId
    {
        get;
        set;
    }

    [ProtoMember(43)]
    public int Battle_BattleGroupId
    {
        get;
        set;
    }

    [ProtoMember(44)]
    public long BattleStartTime
    {
        get;
        set;
    }

    [ProtoMember(45)]
    public List<DropItem> Battle_Drops
    {
        get;
        set;
    }

    [ProtoMember(46)]
    public int JingGongMissionCompleteCount
    {
        get;
        set;
    }

    [ProtoMember(47)]
    public int FangShouMissionCompleteCount
    {
        get;
        set;
    }

    [ProtoMember(48)]
    public int HuSongMissionCompleteCount
    {
        get;
        set;
    }

    [ProtoMember(49)]
    public int HotMissionCompleteCount
    {
        get;
        set;
    }

    [ProtoMember(50)]
    public int DailyHotMissionCompleteCount
    {
        get;
        set;
    }

    [ProtoMember(51)]
    public int NormalMissionCompleteCount
    {
        get;
        set;
    }

    [ProtoMember(52)]
    public List<string> SuccessOrders
    {
        get;
        set;
    } = [];

    [ProtoMember(53)]
    public bool HasExpedition
    {
        get;
        set;
    }

    [ProtoMember(54)]
    public int RankingBattlePower
    {
        get;
        set;
    }

    [ProtoMember(55)]
    public int RankingBountyPoint
    {
        get;
        set;
    }

    [ProtoMember(56)]
    public int RankingAchievement
    {
        get;
        set;
    }

    [ProtoMember(57)]
    public int Logintimes
    {
        get;
        set;
    }

    [ProtoMember(58)]
    public int RecruitCount
    {
        get;
        set;
    }

    [ProtoMember(59)]
    public byte FunctionVal
    {
        get;
        set;
    }

    [ProtoMember(60)]
    public long SysMailTime
    {
        get;
        set;
    }

    [ProtoMember(61)]
    public int BgId
    {
        get;
        set;
    }

    [ProtoMember(62)]
    public bool ActiveBirth
    {
        get;
        set;
    }

    [ProtoMember(63)]
    public int NewUnlockMissionId
    {
        get;
        set;
    }

    [ProtoMember(64)]
    public int MaxPersonalStoryDailyCount
    {
        get;
        set;
    }

    [ProtoMember(65)]
    public int MaxPersonalCopyDailyCount
    {
        get;
        set;
    }

    [ProtoMember(66)]
    public int PersonalCopyDailyCount
    {
        get;
        set;
    }

    [ProtoMember(67)]
    public bool IsClearActivityRewardList
    {
        get;
        set;
    }

    [ProtoMember(68)]
    public bool MonthCardCompensation
    {
        get;
        set;
    }

    [ProtoMember(69)]
    public bool IsSycUserInfoOk
    {
        get;
        set;
    }

    [ProtoMember(70)]
    public bool IsRechargeCompensation
    {
        get;
        set;
    }

    [ProtoMember(71)]
    public bool IsResetCorberoActivity
    {
        get;
        set;
    }

    [ProtoMember(72)]
    public bool IsRepairCorberoPointReward
    {
        get;
        set;
    }

    [ProtoMember(73)]
    public bool IsRepairedGirlAboutMCV
    {
        get;
        set;
    }

    [ProtoMember(74)]
    public bool IsCompletedMCVPreTask
    {
        get;
        set;
    }

    [ProtoMember(75)]
    public bool IsRepairExpeditionMission
    {
        get;
        set;
    }

    [ProtoMember(76)]
    public bool IsRepairDailyMission
    {
        get;
        set;
    }

    [ProtoMember(77)]
    public int GhostVer
    {
        get;
        set;
    }

    [ProtoMember(78)]
    public bool IsRepairedAisimeiladaSkill
    {
        get;
        set;
    }

    [ProtoMember(79)]
    public Dictionary<int, DailyStageCount> DailyStage
    {
        get;
        set;
    } = [];

    [ProtoMember(80)]
    public int Battle_TowerLayerId
    {
        get;
        set;
    }

    [ProtoMember(81)]
    public bool IsComeBackPlayer
    {
        get;
        set;
    }

    [ProtoMember(82)]
    public Dictionary<int, RewardGetState> ComeBackPlayerReward
    {
        get;
        set;
    } = [];

    [ProtoMember(83)]
    public int Battle_DailyStageDayOfWeek
    {
        get;
        set;
    }

    [ProtoMember(84)]
    public int Battle_ATID
    {
        get;
        set;
    }

    [ProtoMember(85)]
    public int DailyGetFriendGiftNum
    {
        get;
        set;
    }

    [ProtoMember(86)]
    public int DailyGiveFriendGiftNum
    {
        get;
        set;
    }

    [ProtoMember(87)]
    public long LastGetRecommendFriend
    {
        get;
        set;
    }

    [ProtoMember(88)]
    public long SevenLoginJoinTime
    {
        get;
        set;
    }

    [ProtoMember(89)]
    public bool IsFreeChangedName
    {
        get;
        set;
    }

    [ProtoMember(90)]
    public List<int> Titles
    {
        get;
        set;
    } = [];

    [ProtoMember(103)]
    public int BattleTimes
    {
        get;
        set;
    }

    [ProtoMember(104)]
    public bool RepairMonthCard
    {
        get;
        set;
    }

    [ProtoMember(211)]
    public bool IsRepairCriticalPointStage
    {
        get;
        set;
    }

    [ProtoMember(212)]
    public bool IsRepairGirlQuality
    {
        get;
        set;
    }

    [ProtoMember(220)]
    public long TotalOnlineTime
    {
        get;
        set;
    }

    [ProtoMember(221)]
    public long LastStageTime
    {
        get;
        set;
    }

    [ProtoMember(222)]
    public long LastUserInfoTime
    {
        get;
        set;
    }

    [ProtoMember(223)]
    public long LastLogin
    {
        get;
        set;
    }

    [ProtoMember(224)]
    public int MissionCurCount
    {
        get;
        set;
    }

    [ProtoMember(225)]
    public int MissionBuyCount
    {
        get;
        set;
    }

    [ProtoMember(226)]
    public int CurDataFlag
    {
        get;
        set;
    }

    [ProtoMember(227)]
    public MonthlyRechargeLimitAgeType MonthlyRechargeLimitType
    {
        get;
        set;
    }

    [ProtoMember(228)]
    public int MonthlyRecharge
    {
        get;
        set;
    }

    [ProtoMember(229)]
    public long LastGetSmallMonthCardRewardTime
    {
        get;
        set;
    }

    [ProtoMember(230)]
    public long SmallMonthCardTimeout
    {
        get;
        set;
    }

    [ProtoMember(231)]
    public long LstReTime
    {
        get;
        set;
    }

    [ProtoMember(232)]
    public long Battle_EnemyUserId
    {
        get;
        set;
    }

    [ProtoMember(233)]
    public Dictionary<int, int> SumConsume
    {
        get;
        set;
    } = [];

    [ProtoMember(234)]
    public Dictionary<int, int> SumConsumeRewardDays
    {
        get;
        set;
    } = [];

    [ProtoMember(235)]
    public Dictionary<int, long> LastGetSumConsumeRewardTime
    {
        get;
        set;
    } = [];

    [ProtoMember(236)]
    public Dictionary<int, int> TotalRecharges
    {
        get;
        set;
    } = [];

    [ProtoMember(237)]
    public List<int> SelSkill
    {
        get;
        set;
    } = [];

    [ProtoMember(238)]
    public List<int> AllSkill
    {
        get;
        set;
    } = [];

    [ProtoMember(327)]
    public Dictionary<int, int> GetTotalRechargeRewardDays
    {
        get;
        set;
    } = [];

    [ProtoMember(328)]
    public Dictionary<ActivityType, long> ActivityLastResetTime
    {
        get;
        set;
    } = [];

    [ProtoMember(301)]
    public long BigLstReTime
    {
        get;
        set;
    }

    [ProtoMember(302)]
    public int Battle_NationWarId
    {
        get;
        set;
    }

    [ProtoMember(303)]
    public int Battle_NationRoomId
    {
        get;
        set;
    }

    [ProtoMember(304)]
    public int Battle_NationHexId
    {
        get;
        set;
    }

    [ProtoMember(305)]
    public Dictionary<int, int> NationWarStory
    {
        get;
        set;
    } = [];

    public ProtoPlayer()
    {
        base.IsNew = true;
    }
}


[Serializable]
[ProtoContract]
public class ProtoPlayerConfig : ProtoBase, IProtocol
{
    public static string TableName => "playerconfig";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public string OsVersion
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public string MarketId
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public string Udid
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public string AdConfig
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public string PfInfo
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public string BangTime
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public string LeaveTime
    {
        get;
        set;
    }

    public ProtoPlayerConfig()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoPlayerInfo : ProtoBase, IProtocol
{
    public static string TableName => "playerInfo";

    [ProtoMember(1)]
    public DisplayType Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int ConfigId
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int Count
    {
        get;
        set;
    }

    public ProtoPlayerInfo()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoPlayerMirror : ProtoBase, IProtocol
{
    public static string TableName => "playermirror";

    [ProtoMember(1)]
    public long Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public List<ProtoGirlMirror> Girls
    {
        get;
        set;
    } = [];

    [ProtoMember(3)]
    public int BGGirlId
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int PlayerLvl
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public string PlayerName
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public int TitleId
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public int SeasonRank
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public int SeasonPoint
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public int CurrArmyId
    {
        get;
        set;
    }

    public ProtoPlayerMirror()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoPlayerMirrorSP : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public long Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public string Name
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int HeadGirlSkinId
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int PlayerTitle
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int Level
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public int BattlePower
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public int Point
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public int Ranking
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public Dictionary<int, ProtoStarshipMirror> Starships
    {
        get;
        set;
    } = [];

    [ProtoMember(10)]
    public ProtoStarshipPVPFormation[] Formation
    {
        get;
        set;
    }

    [ProtoMember(11)]
    public bool IsMonster
    {
        get;
        set;
    }

    public ProtoPlayerMirrorSP()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoPlayerStarshipCannonMirror : IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int StarLevel
    {
        get;
        set;
    }

    public ProtoPlayerStarshipCannonMirror()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoPlayerStarshipChipMirror : IProtocol
{
    [ProtoMember(1)]
    public string Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public string BaseAttrName
    {
        get;
        set;
    }

    [ProtoMember(33)]
    public int BaseAttrValue
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public Dictionary<string, float> ChipAttributes
    {
        get;
        set;
    } = [];

    [ProtoMember(5)]
    public LocationType LocationType
    {
        get;
        set;
    }

    public ProtoPlayerStarshipChipMirror()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoPlayerStarshipGirlMirror : IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int GrilScore
    {
        get;
        set;
    }

    public ProtoPlayerStarshipGirlMirror()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoPopupPackage : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    public ProtoPopupPackage()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoQuickCollectBubble : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public Dictionary<int, List<int>> GirlID2BubbleDic
    {
        get;
        set;
    } = [];

    public ProtoQuickCollectBubble()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoQuickCollectMCV : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public Dictionary<int, List<DropItem>> DropItemDic
    {
        get;
        set;
    } = [];

    public ProtoQuickCollectMCV()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoRanking : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int Rank
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public long Id
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public string Name
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int Level
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int BgGirl
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public long Value
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public int BossLevel
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public int BossCompleteSecond
    {
        get;
        set;
    }

    [ProtoMember(10)]
    public long BossCompleteTime
    {
        get;
        set;
    }

    [ProtoMember(11)]
    public int PlayerTitle
    {
        get;
        set;
    }

    [ProtoMember(12)]
    public NationWarFalg CampType
    {
        get;
        set;
    }

    [ProtoMember(13)]
    public int CurrArmyId
    {
        get;
        set;
    }

    [ProtoMember(14)]
    public long UserNum
    {
        get;
        set;
    }

    [ProtoMember(15)]
    public List<TeamMember> BattleGirls
    {
        get;
        set;
    } = [];

    public ProtoRanking()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoRecruit : ProtoBase, IProtocol
{
    public static string TableName => "recruit";

    [ProtoMember(1)]
    public string Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int RecruitDataId
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public long StartTime
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public long EndTime
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public int RecruitLibraryId
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public ObjState State
    {
        get;
        set;
    }

    [ProtoMember(220)]
    public string CostInfo
    {
        get;
        set;
    }

    public ProtoRecruit()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoRiceCake : ProtoBase, IProtocol
{
    public static string TableName => "riceCake";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int HighestScore
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public Dictionary<int, int> ScoreReward
    {
        get;
        set;
    } = [];

    [ProtoMember(4)]
    public bool GotTodayReward
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public long FirstPlayTime
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public long LastPlayTime
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public int PlayTimes
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public int VerNo
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public int LastScore
    {
        get;
        set;
    }

    public ProtoRiceCake()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoRoleBattleGroup : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int BattleGroupId
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public List<int> Girls
    {
        get;
        set;
    } = [];

    public ProtoRoleBattleGroup()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoRookieTask : ProtoBase, IProtocol
{
    public static string TableName => "rookietask";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public RookieTaskState FirstState
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public RewardGetState SecondState
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int Process
    {
        get;
        set;
    }

    public ProtoRookieTask()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoSakuraWars : ProtoBase, IProtocol
{
    public static string TableName => "sakurawars";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Level
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int Exp
    {
        get;
        set;
    }

    public ProtoSakuraWars()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoSeasonBattleGroup : ProtoBase, IProtocol
{
    public static string TableName => "seasonbattlegroup";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public Dictionary<int, ProtoRoleBattleGroup> BattleGroupDic
    {
        get;
        set;
    } = [];

    public ProtoSeasonBattleGroup()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoSeasonFighter : ProtoBase, IProtocol
{
    public static string TableName => "protoseasonfighter";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Area
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int Point
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public Dictionary<int, List<long>> EnemyIdDic
    {
        get;
        set;
    } = [];

    [ProtoMember(5)]
    public long LastRefreshEnemyTS
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public int RankingWhenRefresh
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public int BestRanking
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public bool IsReceviedRankingAward
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public bool IsReceviedPointAward
    {
        get;
        set;
    }

    [ProtoMember(10)]
    public List<int> ReceviedFirstAward
    {
        get;
        set;
    } = [];

    public ProtoSeasonFighter()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoSeasonFightLog : ProtoBase, IProtocol
{
    public static string TableName => "seasonfightlog";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public List<ProtoBattleDesc> SeasonBattleLogs
    {
        get;
        set;
    } = [];

    [ProtoMember(3)]
    public int BattleCount
    {
        get;
        set;
    }

    public ProtoSeasonFightLog()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoSeriesLogin : ProtoBase, IProtocol
{
    public static string TableName => "serieslogin";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int CurDay
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public long LastRecievedTS
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public long EndActivityTS
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public long StartActivityTs
    {
        get;
        set;
    }

    public ProtoSeriesLogin()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoSevenLogin : ProtoBase, IProtocol
{
    public static string TableName => "sevenLogin";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public RewardGetState SevenSigninStatus
    {
        get;
        set;
    }

    public ProtoSevenLogin()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoShopItem : ProtoBase, IProtocol
{
    public static string TableName => "shopitem";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int ShopId
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int BuyCount
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public long RefreshTime
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int LikeCount
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public ObjState State
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public long GiftEndTime
    {
        get;
        set;
    }

    public ProtoShopItem()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoShopItemLikeInfo : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int LikeCount
    {
        get;
        set;
    }

    public ProtoShopItemLikeInfo()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoSignInMonth : ProtoBase, IProtocol
{
    public static string TableName => "signinmonth";

    [ProtoMember(1)]
    public int ID
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Count
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int SignDay
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int Month
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int Year
    {
        get;
        set;
    }

    public ProtoSignInMonth()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoSpecialRanking : ProtoBase, IProtocol
{
    [ProtoMember(2)]
    public RankingTypes rankingType;

    [ProtoMember(1)]
    public long Id
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int Rank
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public long Value
    {
        get;
        set;
    }

    public ProtoSpecialRanking()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoStage : ProtoBase, IProtocol
{
    public static string TableName => "stage";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int StarMark
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public StageStatus Status
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public List<int> BattleIds
    {
        get;
        set;
    } = [];

    [ProtoMember(5)]
    public Dictionary<int, int> GirlsHp
    {
        get;
        set;
    } = [];

    [ProtoMember(6)]
    public int CompleteCount
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public ObjState State
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public Dictionary<int, ProtoGirlBattleStatus> GirlsStatus
    {
        get;
        set;
    } = [];

    [ProtoMember(9)]
    public Dictionary<int, ProtoRoleBattleGroup> PersonalStoryBattleGroup
    {
        get;
        set;
    } = [];

    [ProtoMember(10)]
    public int TotalExp
    {
        get;
        set;
    }

    [ProtoMember(11)]
    public int TotalCoin
    {
        get;
        set;
    }

    [ProtoMember(12)]
    public int DungeonDropCtrlCount
    {
        get;
        set;
    }

    [ProtoMember(13)]
    public string AuthCode
    {
        get;
        set;
    }

    [ProtoMember(14)]
    public Dictionary<int, ProtoCombinedMachineStatus> CombinedMachineStatus
    {
        get;
        set;
    } = [];

    public ProtoStage()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoStageDropView : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int StageId
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public string FirstAwardProview
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public string AwardProview
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public string ActivityAwardProview
    {
        get;
        set;
    }

    public ProtoStageDropView()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoStarship : ProtoBase, IProtocol
{
    public static string TableName => "starship";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Level
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int Exp
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int StarLevel
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int StarModule
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public ShipQualityType ShipQualityType
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public List<int> Girls
    {
        get;
        set;
    } = [];

    [ProtoMember(8)]
    public int[] PosLevel
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public Dictionary<StarshipGunType, int> Weapons
    {
        get;
        set;
    } = [];

    [ProtoMember(10)]
    public int BattlePower
    {
        get;
        set;
    }

    [ProtoMember(11)]
    public Dictionary<LocationType, string> Chips
    {
        get;
        set;
    } = [];

    [ProtoMember(12)]
    public Dictionary<string, float> ChipSuitAttr
    {
        get;
        set;
    } = [];

    [ProtoMember(13)]
    public int Suit4Id
    {
        get;
        set;
    }

    [ProtoMember(14)]
    public List<int> Suit2Ids
    {
        get;
        set;
    } = [];

    public ProtoStarship()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoStarshipBase : ProtoBase, IProtocol
{
    public static string TableName => "starshipBase";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int TechTreeId
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int StarshipAttachedWeaponNum
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int cost
    {
        get;
        set;
    }

    public ProtoStarshipBase()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoStarshipChip : ProtoBase, IProtocol
{
    public static string TableName => "starshipchip";

    [ProtoMember(1)]
    public string Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int ConfigId
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int ShipId
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int Level
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int Exp
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public bool IsLock
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public long CreateTime
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public string BaseAttrName
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public int BaseAttrValue
    {
        get;
        set;
    }

    [ProtoMember(10)]
    public List<ProtoChipAttribute> ChipAttributes
    {
        get;
        set;
    } = [];

    [ProtoMember(11)]
    public ObjState State
    {
        get;
        set;
    }

    public ProtoStarshipChip()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoStarshipCollect : ProtoBase, IProtocol
{
    public static string TableName => "starshipCollet";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int MainProc
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int MainState
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public Dictionary<int, StarshipSubCollect> SubMissions
    {
        get;
        set;
    } = [];

    public ProtoStarshipCollect()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoStarshipExplore : ProtoBase, IProtocol
{
    public static string TableName => "starshipExplore";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int ExplorePhy
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int ExplorePhyCount
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int OpenChapter
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int Chapter
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public Dictionary<int, ProtoStarshipExploreChapter> ExploreChapters
    {
        get;
        set;
    } = [];

    [ProtoMember(7)]
    public Dictionary<int, int> ExploreBuffs
    {
        get;
        set;
    } = [];

    [ProtoMember(8)]
    public Dictionary<ExploreEventType, ProtoStarshipExploreEvent> ExploreEvents
    {
        get;
        set;
    } = [];

    [ProtoMember(9)]
    public ExploreEventType EventType
    {
        get;
        set;
    }

    [ProtoMember(10)]
    public List<int> Ships
    {
        get;
        set;
    } = [];

    [ProtoMember(11)]
    public List<ProtoExploreEventsLog> ExploreEventsLogs
    {
        get;
        set;
    } = [];

    [ProtoMember(12)]
    public int PayDiscount
    {
        get;
        set;
    }

    public ProtoStarshipExplore()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoStarshipExploreChapter : IProtocol
{
    [ProtoMember(1)]
    public Dictionary<int, int> Stars
    {
        get;
        set;
    } = [];

    [ProtoMember(2)]
    public List<int> StarAward
    {
        get;
        set;
    } = [];

    [ProtoMember(3)]
    public int CheckPointValue
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public bool IsChapterComplete
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int CheckPoint
    {
        get;
        set;
    }

    public ProtoStarshipExploreChapter()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoStarshipExploreEvent : IProtocol
{
    [ProtoMember(1)]
    public List<int> ExploreEventValue
    {
        get;
        set;
    } = [];

    [ProtoMember(2)]
    public StarshipExploreEventStarType EventQuality
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public StarshipExploreEventTerrainType EventTerrain
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int EventPos
    {
        get;
        set;
    }

    public ProtoStarshipExploreEvent()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoStarshipFetter : ProtoBase, IProtocol
{
    public static string TableName => "starshipFetter";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public Dictionary<int, StarshipFetter> Fetters
    {
        get;
        set;
    } = [];

    [ProtoMember(3)]
    public int MaxEftCfgId
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int MaxEftCfgVal
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int TotalEftOkNum
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public int EftCfgId
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public int EftOkNum
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public int EftCfgNum
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public int EftState
    {
        get;
        set;
    }

    public ProtoStarshipFetter()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoStarshipGuessing : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int BlueSupportCount
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int RedSupportCount
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public ProtoStarshipMirror Blue
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public ProtoStarshipMirror Red
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public ProtoBattleReport Report
    {
        get;
        set;
    }

    public ProtoStarshipGuessing()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoStarshipMirror : IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int BattlePower
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int Level
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int StarLevel
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public List<ProtoPlayerStarshipGirlMirror> Girls
    {
        get;
        set;
    } = [];

    [ProtoMember(6)]
    public List<ProtoPlayerStarshipCannonMirror> Cannons
    {
        get;
        set;
    } = [];

    [ProtoMember(7)]
    public List<ProtoPlayerStarshipChipMirror> Chips
    {
        get;
        set;
    } = [];

    [ProtoMember(8)]
    public Dictionary<string, float> StarshipCollectProperty
    {
        get;
        set;
    } = [];

    [ProtoMember(9)]
    public int TechTreeId
    {
        get;
        set;
    }

    [ProtoMember(10)]
    public Dictionary<StarshipGunType, int> Weapons
    {
        get;
        set;
    } = [];

    [ProtoMember(11)]
    public int Suit4Id
    {
        get;
        set;
    }

    [ProtoMember(12)]
    public List<int> Suit2Id
    {
        get;
        set;
    } = [];

    [ProtoMember(13)]
    public Dictionary<string, float> ChipSuitAttr
    {
        get;
        set;
    } = [];

    [ProtoMember(14)]
    public int StarModule
    {
        get;
        set;
    }

    [ProtoMember(15)]
    public int[] PosLevel
    {
        get;
        set;
    }

    [ProtoMember(16)]
    public StarshipMoveAction MoveAction
    {
        get;
        set;
    }

    public ProtoStarshipMirror()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoStarshipPVP : ProtoBase, IProtocol
{
    public static string TableName => "starshippvp";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Point
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public long LastGuessingTime
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int GuessingTimes
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int RefreshRivalNum
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public int BuyTicketCount
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public int Ranking
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public ProtoStarshipPVPFormation[] Formation
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public Dictionary<string, long> PVPHistoryReports
    {
        get;
        set;
    } = [];

    [ProtoMember(10)]
    public List<string> LockingPVPHistoryReports
    {
        get;
        set;
    } = [];

    public ProtoStarshipPVP()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoStarshipPVPFormation : IProtocol
{
    [ProtoMember(1)]
    public int StarshipId
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public StarshipMoveAction MoveAction
    {
        get;
        set;
    }

    public ProtoStarshipPVPFormation()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoStarshipPVPHistoryReport : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public string Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public HistoryReportPlayerInfo Info
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public HistoryReportPlayerInfo RivalInfo
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public bool IsWin
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int GettingPoint
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public long Endtime
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public bool IsLock
    {
        get;
        set;
    }

    public ProtoStarshipPVPHistoryReport()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoStarshipPVPLogDetails : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public string Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public HistoryReportPlayerInfo Attacker
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public HistoryReportPlayerInfo Defender
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public ProtoBattleReport[] BattleReports
    {
        get;
        set;
    }

    public ProtoStarshipPVPLogDetails()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoStarshipPVPRanking : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int Rank
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public ProtoPlayerMirrorSP Mirror
    {
        get;
        set;
    }

    public ProtoStarshipPVPRanking()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoStarshipPVPRivalInfo : IProtocol
{
    [ProtoMember(1)]
    public long RivalId
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public bool IsMonster
    {
        get;
        set;
    }

    public ProtoStarshipPVPRivalInfo()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoStarshipPVPRivalList : IProtocol
{
    [ProtoMember(1)]
    public List<ProtoStarshipPVPRivalInfo> Rivals
    {
        get;
        set;
    } = [];

    public ProtoStarshipPVPRivalList()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoStarshipWeapon : ProtoBase, IProtocol
{
    public static string TableName => "starshipWeapon";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int ConfigId
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int ShipId
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public string UpdateDes
    {
        get;
        set;
    }

    public ProtoStarshipWeapon()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoStarshipWeaponFavor : ProtoBase, IProtocol
{
    public static string TableName => "starshipWeaponFavor";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public Dictionary<StarshipGunType, int> Favor1
    {
        get;
        set;
    } = [];

    [ProtoMember(3)]
    public Dictionary<StarshipGunType, int> Favor2
    {
        get;
        set;
    } = [];

    [ProtoMember(4)]
    public Dictionary<StarshipGunType, int> Favor3
    {
        get;
        set;
    } = [];

    public ProtoStarshipWeaponFavor()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoStarTowerStage : ProtoBase, IProtocol
{
    public static string TableName => "startowerstage";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public Dictionary<int, int> CurLayer
    {
        get;
        set;
    } = [];

    [ProtoMember(3)]
    public int BuyTimes
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int LastConfigId
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public List<int> BatGirl
    {
        get;
        set;
    } = [];

    [ProtoMember(6)]
    public Dictionary<int, StarTowerStageInfo> Tower1
    {
        get;
        set;
    } = [];

    [ProtoMember(7)]
    public Dictionary<int, StarTowerStageInfo> Tower2
    {
        get;
        set;
    } = [];

    [ProtoMember(8)]
    public Dictionary<int, StarTowerStageInfo> Tower3
    {
        get;
        set;
    } = [];

    public ProtoStarTowerStage()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoStarTowerTask : ProtoBase, IProtocol
{
    public static string TableName => "startowertask";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public Dictionary<int, StarTowerTaskInfo> DailyTasks
    {
        get;
        set;
    } = [];

    [ProtoMember(3)]
    public Dictionary<int, StarTowerTaskInfo> WeeklyTasks
    {
        get;
        set;
    } = [];

    [ProtoMember(4)]
    public Dictionary<int, StarTowerTaskInfo> Achievement
    {
        get;
        set;
    } = [];

    public ProtoStarTowerTask()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoStoryStage : ProtoBase, IProtocol
{
    public static string TableName => "storystage";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public List<int> PassedPoints
    {
        get;
        set;
    } = [];

    public ProtoStoryStage()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoSuitDevelop : ProtoBase, IProtocol
{
    public static string TableName => "suitdevelop";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public Dictionary<int, long> DevelopCoolDown
    {
        get;
        set;
    } = [];

    [ProtoMember(3)]
    public bool IsGirlCompensation
    {
        get;
        set;
    }

    public ProtoSuitDevelop()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoSweetActivity : ProtoBase, IProtocol
{
    [ProtoMember(8)]
    public long LastRestoreTime;

    [ProtoMember(9)]
    public int TotalExp;

    [ProtoMember(10)]
    public int TotalCoin;

    public static string TableName => "sweetactivity";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public long ActivityOpenTime
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public long ActivityCloseTime
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int PhyBuyTimes
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public Dictionary<int, SweetGirl> SweetGirls
    {
        get;
        set;
    } = [];

    [ProtoMember(6)]
    public Dictionary<int, SweetStage> SweetStages
    {
        get;
        set;
    } = [];

    [ProtoMember(7)]
    public Dictionary<int, SweetAchievement> SweetAchievements
    {
        get;
        set;
    } = [];

    public ProtoSweetActivity()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoTalentPlayer : ProtoBase, IProtocol
{
    public static string TableName => "talentplayer";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int ChallengeTimes
    {
        get;
        set;
    }

    public ProtoTalentPlayer()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoTalentTower : ProtoBase, IProtocol
{
    public static string TableName => "talenttower";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int CurDifficulty
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int CurTier
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int MaxDifficulty
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public Dictionary<int, ProtoRoleBattleGroup> CurGirls
    {
        get;
        set;
    } = [];

    [ProtoMember(6)]
    public Dictionary<int, ProtoGirlBattleStatus> GirlsStatus
    {
        get;
        set;
    } = [];

    [ProtoMember(7)]
    public List<ProtoBattleMonsterStatus> CurMonstersHP
    {
        get;
        set;
    } = [];

    [ProtoMember(8)]
    public Dictionary<int, ProtoCombinedMachineStatus> CombinedMachineStatus
    {
        get;
        set;
    } = [];

    public ProtoTalentTower()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoTask : ProtoBase, IProtocol
{
    public static string TableName => "task";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int TaskId
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public byte Status
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int Process
    {
        get;
        set;
    }

    public ProtoTask()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoTeachingRecruit : ProtoBase, IProtocol
{
    public static string TableName => "teachingRecruit";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public bool IsCompletedTeachingRecruit
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public string cardStr
    {
        get;
        set;
    }

    public ProtoTeachingRecruit()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoTechTree : ProtoBase, IProtocol
{
    public static string TableName => "techtree";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public Dictionary<int, int> TechDic
    {
        get;
        set;
    } = [];

    public ProtoTechTree()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoTenRecruit : ProtoBase, IProtocol
{
    public static string TableName => "tenRecruit";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Num
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int TotalNum
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int SSRN
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int SSRUPN
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public int URNum
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public int PayOnceCount
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public long PayOnceRefreshTimestamp
    {
        get;
        set;
    }

    public ProtoTenRecruit()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoTenRecruitConfig : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int ID
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public string Name
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public string IosOpenTime
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public string IosCloseTime
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public string AndOpenTime
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public string AndCloseTime
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public string ResourceName
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public int ListOrder
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public RecruitActivityType RecruitActivityType
    {
        get;
        set;
    }

    [ProtoMember(10)]
    public int LibraryID
    {
        get;
        set;
    }

    [ProtoMember(11)]
    public int Roundlimit
    {
        get;
        set;
    }

    [ProtoMember(12)]
    public int RecruitingType
    {
        get;
        set;
    }

    [ProtoMember(13)]
    public string URExchangeShopID
    {
        get;
        set;
    }

    public ProtoTenRecruitConfig()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoTexun : ProtoBase, IProtocol
{
    public static string TableName => "texun";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public Dictionary<int, NewYearBossMissions> Missions
    {
        get;
        set;
    } = [];

    [ProtoMember(3)]
    public Dictionary<int, ProtoRoleBattleGroup> PersonalStoryBattleGroup
    {
        get;
        set;
    } = [];

    [ProtoMember(4)]
    public int Ver
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int LastFight
    {
        get;
        set;
    }

    public ProtoTexun()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoTodayTotalInfo : ProtoBase, IProtocol
{
    public static string TableName => "todaytotal";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int TodayTotalExp
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int TodayTotalCoin
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public long PreStartBattleTime
    {
        get;
        set;
    }

    public ProtoTodayTotalInfo()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoTower : ProtoBase, IProtocol
{
    public static string TableName => "tower";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int TowerEnergy
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public long LastCalcEnergyTime
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int TowerPoint
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int TowerBossCount
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public int UsedAwardTicketNum
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public List<int> ClearAchievementIds
    {
        get;
        set;
    } = [];

    [ProtoMember(10)]
    public List<string> HaveRecievedRankingAward
    {
        get;
        set;
    } = [];

    public ProtoTower()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoTowerBossProperty : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public Dictionary<int, string> BossProperty
    {
        get;
        set;
    } = [];

    public ProtoTowerBossProperty()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoTowerStage : ProtoBase, IProtocol
{
    public static string TableName => "towerstage";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int CurTowerLayer
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public List<int> SuccStageIDs
    {
        get;
        set;
    } = [];

    [ProtoMember(4)]
    public Dictionary<int, List<int>> SuccExtraStageIDs
    {
        get;
        set;
    } = [];

    [ProtoMember(5)]
    public int AutoBattleStageId
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public long AutoBattleStopTS
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public int AutoBattleNum
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public int KillFinalBossNumToday
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public int AutoBattleLayerId
    {
        get;
        set;
    }

    [ProtoMember(10)]
    public bool AutoBattleUseTickets
    {
        get;
        set;
    }

    [ProtoMember(11)]
    public Dictionary<int, int> FinalBossStageExpandInfo
    {
        get;
        set;
    } = [];

    [ProtoMember(12)]
    public bool IsFinalBossClear
    {
        get;
        set;
    }

    public ProtoTowerStage()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoURAwakeConfig : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public string OpenTime
    {
        get;
        set;
    }

    public ProtoURAwakeConfig()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoViewItem : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Num
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public StuffType StuffType
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public string WidgetId
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public int GroupId
    {
        get;
        set;
    }

    public ProtoViewItem()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoWeeklyMission : ProtoBase, IProtocol
{
    public static string TableName => "weeklyMission";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Day
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public short Process
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public RewardGetState RewardState
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public ObjState State
    {
        get;
        set;
    }

    public ProtoWeeklyMission()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoWeeklyShop : ProtoBase, IProtocol
{
    public static string TableName => "weeklyShop";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public string WeeklyShopList
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public long LastRefreshTime
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int RefreshCount
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int TotalRefreshCount
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public ObjState State
    {
        get;
        set;
    }

    public ProtoWeeklyShop()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoWeeklyStage : ProtoBase, IProtocol
{
    public static string TableName => "weeklyStage";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int StarMark
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int ExtCount
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int CompleteCount
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int Unlock
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public ObjState State
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public int TotalCompCount
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public int MaxStartCount
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public int CompleteSecond
    {
        get;
        set;
    }

    [ProtoMember(10)]
    public long CompleteTime
    {
        get;
        set;
    }

    [ProtoMember(11)]
    public Dictionary<int, ProtoRoleBattleGroup> PersonalStoryBattleGroup
    {
        get;
        set;
    } = [];

    public ProtoWeeklyStage()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoWidget : ProtoBase, IProtocol
{
    public static string TableName => "widget";

    [ProtoMember(1)]
    public string Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int WidgetConfigId
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public string WidgetGroupId
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int Level
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int UseLevel
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public WidgetQualityType QualityType
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public int StrengthLevel
    {
        get;
        set;
    }

    [ProtoMember(10)]
    public List<ProtoAttribute> DeputyAttributes
    {
        get;
        set;
    } = [];

    [ProtoMember(11)]
    public int BattlePower
    {
        get;
        set;
    }

    [ProtoMember(12)]
    public bool Locked
    {
        get;
        set;
    }

    [ProtoMember(14)]
    public ObjState State
    {
        get;
        set;
    }

    [ProtoMember(15)]
    public int QualityUpTimes
    {
        get;
        set;
    }

    [ProtoMember(16)]
    public int ModuleLevel
    {
        get;
        set;
    }

    [ProtoMember(17)]
    public int ModuleExp
    {
        get;
        set;
    }

    [ProtoMember(18)]
    public int HeresyBreakLevel
    {
        get;
        set;
    }

    [ProtoMember(19)]
    public List<ProtoAttribute> ModuleAttributes
    {
        get;
        set;
    } = [];

    [ProtoMember(20)]
    public bool IsInherit
    {
        get;
        set;
    }

    [ProtoMember(21)]
    public Dictionary<int, List<ProtoAttribute>> RefineAttributes
    {
        get;
        set;
    } = [];

    [ProtoMember(22)]
    public int OpenPositionNum
    {
        get;
        set;
    }

    [ProtoMember(23)]
    public int RefineTimes
    {
        get;
        set;
    }

    public ProtoWidget()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoWidgetExchange : ProtoBase, IProtocol
{
    public static string TableName => "widgetexchange";

    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public Dictionary<int, int> ExchangeInfo
    {
        get;
        set;
    } = [];

    [ProtoMember(3)]
    public List<int> GetAwardInfo
    {
        get;
        set;
    } = [];

    [ProtoMember(4)]
    public List<int> GetBigSaleInfo
    {
        get;
        set;
    } = [];

    public ProtoWidgetExchange()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoWidgetGroup : ProtoBase, IProtocol
{
    public static string TableName => "widgetGroup";

    [ProtoMember(1)]
    public string Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int GirlId
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public Dictionary<WidgetType, string> Widgets
    {
        get;
        set;
    } = [];

    [ProtoMember(4)]
    public int BattleGroupId
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int BattlePower
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public bool IsActivated
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public bool IsExpedition
    {
        get;
        set;
    }

    public ProtoWidgetGroup()
    {
    }
}


[Serializable]
[ProtoContract]
public class ProtoXMessage : IProtocol
{
    [ProtoMember(1)]
    public string Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public long CreateAt
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public XMessageType MessageType
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public string Message
    {
        get;
        set;
    }

    public ProtoXMessage()
    {
    }
}


[Serializable]
[ProtoContract]
public class RequestOperation : IProtocol
{
    [ProtoMember(1)]
    public OperationCode OpCode
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int RetailType
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public string RetailID
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public string RetailUid
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int MsgId
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public string SessionId
    {
        get;
        set;
    }

    [ProtoMember(7)]
    public int ActionId
    {
        get;
        set;
    }

    [ProtoMember(8)]
    public long UserId
    {
        get;
        set;
    }

    [ProtoMember(9)]
    public string UserToken
    {
        get;
        set;
    }

    [ProtoMember(10)]
    public string PackageSign
    {
        get;
        set;
    }

    [ProtoMember(11)]
    public string Channel
    {
        get;
        set;
    }

    [ProtoMember(12)]
    public string Bid
    {
        get;
        set;
    }

    [ProtoMember(13)]
    public string ServerId
    {
        get;
        set;
    }

    [ProtoMember(14)]
    public string AppId
    {
        get;
        set;
    }

    [ProtoMember(15)]
    public string Udid
    {
        get;
        set;
    }

    [ProtoMember(16)]
    public string PhoneType
    {
        get;
        set;
    }

    [ProtoMember(17)]
    public string Sys_Version
    {
        get;
        set;
    }

    [ProtoMember(18)]
    public string ClientVer
    {
        get;
        set;
    }

    [ProtoMember(30)]
    public string Bundle
    {
        get;
        set;
    }

    [ProtoMember(101)]
    public int I32_1
    {
        get;
        set;
    }

    [ProtoMember(102)]
    public int I32_2
    {
        get;
        set;
    }

    [ProtoMember(103)]
    public int I32_3
    {
        get;
        set;
    }

    [ProtoMember(104)]
    public int I32_4
    {
        get;
        set;
    }

    [ProtoMember(105)]
    public int I32_5
    {
        get;
        set;
    }

    [ProtoMember(106)]
    public int? I32_6
    {
        get;
        set;
    }

    [ProtoMember(111)]
    public string Str_1
    {
        get;
        set;
    }

    [ProtoMember(112)]
    public string Str_2
    {
        get;
        set;
    }

    [ProtoMember(113)]
    public string Str_3
    {
        get;
        set;
    }

    [ProtoMember(116)]
    public long I64_1
    {
        get;
        set;
    }

    [ProtoMember(117)]
    public long I64_2
    {
        get;
        set;
    }

    [ProtoMember(118)]
    public long I64_3
    {
        get;
        set;
    }

    [ProtoMember(121)]
    public bool Bool_1
    {
        get;
        set;
    }

    [ProtoMember(122)]
    public bool Bool_2
    {
        get;
        set;
    }

    [ProtoMember(123)]
    public bool Bool_3
    {
        get;
        set;
    }

    [ProtoMember(131)]
    public byte Byte_1
    {
        get;
        set;
    }

    [ProtoMember(132)]
    public byte Byte_2
    {
        get;
        set;
    }

    [ProtoMember(133)]
    public byte Byte_3
    {
        get;
        set;
    }

    [ProtoMember(201)]
    public string[] Str_Array
    {
        get;
        set;
    }

    [ProtoMember(202)]
    public int[] Int32_Array
    {
        get;
        set;
    }

    [ProtoMember(203)]
    public long[] Int64_Array
    {
        get;
        set;
    }

    [ProtoMember(204)]
    public byte[] Byte_Array
    {
        get;
        set;
    }

    [ProtoMember(211)]
    public Dictionary<int, int> Int32_Dic
    {
        get;
        set;
    }

    [ProtoMember(212)]
    public Dictionary<int, ProtoGirlBattleStatus> GirlsStatus
    {
        get;
        set;
    } = [];

    [ProtoMember(213)]
    public Dictionary<int, ProtoRoleBattleGroup> PersonalStoryBattleGroup
    {
        get;
        set;
    } = [];

    [ProtoMember(214)]
    public List<ProtoBattleMonsterStatus> MonsterStatus
    {
        get;
        set;
    } = [];

    [ProtoMember(215)]
    public Dictionary<int, ProtoCombinedMachineStatus> CombinedMachineStatus
    {
        get;
        set;
    } = [];

    [ProtoMember(216)]
    public ProtoStarshipPVPFormation[] StarshipPVPFormation
    {
        get;
        set;
    }

    public RequestOperation()
    {
    }
}


[Serializable]
[ProtoContract]
public class ResponseOperation : IProtocol
{
    [ProtoMember(1)]
    public OperationCode Operation
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public DataType ResponseType
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public ErrorCode ErrorCode
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public long UserId
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public string SessionId
    {
        get;
        set;
    }

    [ProtoMember(6)]
    public Dictionary<DataTypes, HashSet<ProtoBase>> ReturnCache
    {
        get;
        set;
    } = [];

    [ProtoMember(7)]
    public Dictionary<DataTypes, HashSet<byte[]>> ReturnCacheBytes
    {
        get;
        set;
    } = [];

    public ResponseOperation()
    {
    }

    public ResponseOperation(OperationCode operation, long userId, DataType type = DataType.Response)
    {
        Operation = operation;
        UserId = userId;
        ResponseType = type;
    }
}


[Serializable]
[ProtoContract]
public class ResponsePack : IProtocol
{
    [ProtoMember(1)]
    public bool IsGZip
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public byte[] Data
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int DataLen
    {
        get;
        set;
    }

    public ResponsePack()
    {
    }

    public ResponsePack(byte[] data)
    {
        //Discarded unreachable code: IL_001c
        Data = data;
        int length = data.Length;
        DataLen = length;
    }
}


[Serializable]
[ProtoContract]
public class RewardPool : ProtoBase, IProtocol
{
    [ProtoMember(1)]
    public int PoolId
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int SelectLevelIndex
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public Dictionary<int, int> RewardList
    {
        get;
        set;
    } = [];

    public RewardPool()
    {
    }
}


public class Rsp
{
    public OperationCode op;

    public ErrorCode rCode;

    public Rsp()
    {
    }
}


[Serializable]
[ProtoContract]
public class StarshipFetter : IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public Dictionary<int, StarshipFetterTask> FetterTask
    {
        get;
        set;
    } = [];

    [ProtoMember(3)]
    public int CfgNum
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int OkNum
    {
        get;
        set;
    }

    public StarshipFetter()
    {
    }
}


[Serializable]
[ProtoContract]
public class StarshipFetterTask : IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Proc
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int State
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public bool Show
    {
        get;
        set;
    }

    public StarshipFetterTask()
    {
    }
}


[Serializable]
[ProtoContract]
public class StarshipSubCollect : IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Proc
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int State
    {
        get;
        set;
    }

    public StarshipSubCollect()
    {
    }
}


[Serializable]
[ProtoContract]
public class StarTowerStageInfo : IProtocol
{
    [ProtoMember(1)]
    public int Diff
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Stage
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int ShipStage
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int FastRound
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public int FastTime
    {
        get;
        set;
    }

    public StarTowerStageInfo()
    {
    }
}


[Serializable]
[ProtoContract]
public class StarTowerTaskInfo : IProtocol
{
    [ProtoMember(1)]
    public int Id
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Proc
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public RewardGetState State
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int IsShow
    {
        get;
        set;
    }

    public StarTowerTaskInfo()
    {
    }
}


[Serializable]
[ProtoContract]
public class SweetAchievement : IProtocol
{
    [ProtoMember(1)]
    public int GroupId
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int TableId
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int Process
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public RewardGetState RewardState
    {
        get;
        set;
    }

    public SweetAchievement()
    {
    }
}


[Serializable]
[ProtoContract]
public class SweetGirl : IProtocol
{
    [ProtoMember(1)]
    public int GirlId
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int FavorExp
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int FavorLevel
    {
        get;
        set;
    }

    public SweetGirl()
    {
    }
}


[Serializable]
[ProtoContract]
public class SweetStage : IProtocol
{
    [ProtoMember(1)]
    public int StageId
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int CompleteCount
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public Dictionary<int, ProtoGirlBattleStatus> GirlsStatus
    {
        get;
        set;
    } = [];

    [ProtoMember(4)]
    public string AuthCode
    {
        get;
        set;
    }

    [ProtoMember(5)]
    public Dictionary<int, ProtoCombinedMachineStatus> CombinedMachineStatus
    {
        get;
        set;
    } = [];

    [ProtoMember(6)]
    public Dictionary<int, ProtoRoleBattleGroup> PersonalStoryBattleGroup
    {
        get;
        set;
    } = [];

    [ProtoMember(7)]
    public StageStatus Status
    {
        get;
        set;
    }

    public SweetStage()
    {
    }
}


[Serializable]
[ProtoContract]
public class TeamMember : IProtocol
{
    [ProtoMember(1)]
    public int GirlId
    {
        get;
        set;
    }

    [ProtoMember(2)]
    public int Level
    {
        get;
        set;
    }

    [ProtoMember(3)]
    public int Start
    {
        get;
        set;
    }

    [ProtoMember(4)]
    public int Skin
    {
        get;
        set;
    }

    public TeamMember()
    {
    }
}


public enum XMessageType
{
    GmGift = 0,
    Charge = 1,
    ChargeReturn = 2,
    RequestAddFriend = 3,
    AgreeRequest = 4,
    RefuseRequest = 5,
    Shield = 6,
    DeleteFriend = 7,
    GiveFriendGift = 8,
    SendATRankAward = 9,
    SendATKillAward = 10,
    SendUpdateOthersInviteMeLst = 11,
    SendSeasonFightPoint = 12,
    SendSeasonFightLog = 13,
    SendNationWarAssignRoom = 14,
    SendNationWarHonorInfo = 15,
    SendNationWarFightLog = 16,
    CostDiamond = 20,
    CostFreeDiamond = 21,
    CostTotalPay = 22,
    ModifyGuides = 23
}

public enum A2GE : byte
{
    Handshake0 = 0,
    Handshake = 1,
    Message = 2,
    Terminate = 3,
    Error = 4,
    HealthCheck = 5,
    CTL_E = 64,
    CTL_C = 128
}

public enum AccountSync
{
    facebook,
    google,
    nexonplay,
    naver,
    kakao,
    other
}

public enum ActionRecordType
{
    None,
    商店
}

public enum AddBuffTiming
{
    无,
    造成伤害前,
    造成伤害后
}

public enum AdjustSubType
{
    开始,
    完成,
    立即完成,
    期间到期,
    激活,
    加速,
    取消,
    指定,
    解除
}

public enum AdjustType
{
    房间升级,
    房间改造,
    修复
}

public enum ATAssistBattleMode
{
    OPEN,
    PERSONAL,
    FRIEND
}

public enum ATBossStatus
{
    WAITING,
    INBATTLE,
    EXPIRE
}

public enum ATChallengeMode
{
    EASY,
    NORMAL,
    HARD,
    HELL,
    HERO
}

public enum AttendType
{
    七日 = 1
}

public enum AttributeOpType
{
    部件强化 = 1,
    部件异端化升级,
    部件继承,
    部件模块升级,
    部件精制,
    完成部件精制,
    增加精炼槽位,
    装备品质提升
}

public enum AttributeType
{
    异端化等级 = -50,
    异端化经验,
    进阶次数,
    模块等级,
    模块经验,
    开启槽位数量,
    精炼次数,
    部件继承,
    继承模式,
    品质,
    品质经验,
    品质提升次数,
    装备进阶次数
}

public enum AutoFightType
{
    MANUAL,
    SEMI_AUTO,
    AUTO
}

public enum BattleEventTypes
{
    Init = 1,
    FightTurn = 21,
    Move = 3,
    Attack = 4,
    BuffChange = 5
}

public enum BattleGroupFightingStatus
{
    None,
    Fighting1,
    Fighting2,
    Fighting3,
    Fighting4
}

public enum BattleGroupPositionLimit
{
    Back = 1,
    Front,
    All
}

public enum BgItemChangeType
{
    获得 = 1,
    消耗
}

public enum BiAchieveMentType
{
    主线成就 = 100,
    支线成就 = 200,
    活动成就 = 600,
    其他成就 = 1000
}

public enum BiItemActionType
{
    购买_兑换行为 = 100,
    交易行为_与其他玩家 = 200,
    通过关卡产出或消耗 = 300,
    通过任务产出或消耗 = 400,
    通过公会产出或消耗 = 500,
    通过成就产出或消耗 = 600,
    通过邮件产出或消耗 = 700,
    其他行为 = 1000
}

public enum BiItemChangeType
{
    消耗,
    获得
}

public enum BiItemType
{
    游戏内的基础代币 = 100,
    付费代币 = 200,
    卡牌类 = 300,
    直接使用的消耗品类 = 400,
    材料消耗品类 = 500,
    装备类 = 600,
    特殊类 = 700,
    任务类道具 = 800,
    礼包类道具 = 900,
    活动产出类 = 1000,
    其他 = 2000
}

public enum BikiniStageLevel : byte
{
    简单,
    普通,
    困难,
    极难
}

public enum BikiniStageType : byte
{
    主线关卡,
    复刷关卡,
    BOSS关卡,
    挑战Boss
}

public enum BikiniTaskReset : byte
{
    日常,
    周常,
    一次性
}

public enum BonusFlag
{
    Y,
    N,
    None
}

public enum BoxOpenFlag
{
    Other,
    IsBox
}

public enum BubbleProcessStatus : byte
{
    Normal,
    Bubble,
    AlreadyRandom,
    Selected,
    Received
}

public enum BuffExclusionStatus
{
    无,
    偏折,
    悬浮,
    免疫
}

[Flags]
public enum CardStatus : byte
{
    Default = 0,
    LifeMemberMark = 1,
    LifeMemberRewardMark = 2,
    LifeMemberReward = 3,
    MonthCardMark = 4,
    MonthCardRewardMark = 8,
    MonthCardReward = 0xC
}

public enum CashShopBuyResult
{
    Failed,
    Success
}

public enum ChapterCompleteStatus
{
    None,
    Complete
}

public enum ChapterMissionStatus
{
    None,
    Accept
}

public enum ChatChannels : byte
{
    Notice,
    World,
    Union,
    Private,
    NationWar
}

public enum CollectTypes : byte
{
    Girl,
    Widget,
    NormalSuit,
    Suit
}

public enum CreateBonusFlag
{
    不是,
    创建指定品质等级的道具
}

public enum CreateCompleteType
{
    立即完成,
    过一段时间完成
}

public enum CreateSingleFlag
{
    单个制作,
    多个制作
}

public enum CrystalEvemtTypes
{
    Recharge = 1,
    ItemGet,
    GrowthFund,
    NestReset,
    NestRecoverGirlHp,
    OpenClimbTowerBox,
    BuyClimbTowerChallengeCount,
    WorldBossEncourage,
    BuyWorldBossChallengeCd,
    Develop,
    ResetSceneChallengeCount,
    RefreshShop,
    BuyShop,
    UpdateName,
    BuyEnergy,
    BuyCoin,
    BuyPVPChallengeCount,
    BuyPVPChallengeCd,
    RefreshPVPEnermy,
    BuyGrowthFund,
    BuyVIPWeeklyGift,
    ExtendWidgetPackage,
    ExtendItemPackage,
    ExtendChipPackage,
    UnionDonate,
    SceneRelive,
    RecoverSevenSignIn,
    CreateUnion,
    SellItem
}

public enum CurrentDataFlagBitDes : ushort
{
    赏金次数,
    黑色方舟称号补发,
    任务类型17修复,
    任务类型26修复,
    修复protobas104冲突,
    任务类型13修复,
    修复克尔贝洛活动成就数据,
    修复货币为0且未删除,
    国服圣诞复刻去除场景进度,
    删除非法碎片,
    泳装烧烤榜单名次奖励发放,
    樱花机娘星级修复,
    樱花大战区域修复排行榜奖励,
    星舰已初始化标记,
    星舰版本回流玩家标记,
    国服圣诞复刻去除场景进度2022
}

public enum DamageTypes
{
    无,
    正常,
    治疗,
    未触发,
    反击,
    起火,
    沉默,
    暴击,
    反击暴击,
    反击未触发,
    未在射程,
    反击未在射程,
    蓄力中
}

public enum DataTypes : byte
{
    ProtoPlayer,
    ProtoGirl,
    ProtoWidget,
    ProtoWidgetGroup,
    ProtoBattleGroup,
    ProtoItem,
    ProtoStage,
    ProtoViewItem,
    ProtoMail,
    ProtoBattleDrop,
    ProtoPang,
    ProtoNotice,
    ProtoRecruit,
    ProtoPlayerInfo,
    ProtoCollect,
    ProtoAchievement,
    ProtoArea,
    ProtoRanking,
    ProtoShopItem,
    ProtoActivity,
    ProtoExpeditionMission,
    ProtoWeeklyMission,
    ProtoAreaDailyMission,
    ProtoActivityDailyMission,
    ProtoCharge,
    ProtoAreaMission,
    ProtoBuild,
    ProtoSevenLogin,
    ProtoTodayTotalInfo,
    ProtoNightmareStage,
    ProtoRookieTask,
    ProtoCG,
    ProtoShopItemLikeInfo,
    ProtoEffectiveTenRecruitTime,
    ProtoTenRecruit,
    ProtoGacya,
    ProtoBikiniStage,
    ProtoBikiniStageMission,
    ProtoBeachVolleyball,
    ProtoWidgetExchange,
    ProtoBikiniTask,
    ProtoBikiniBackground,
    ProtoMCVBase,
    ProtoMCVRoom,
    ProtoWeeklyStage,
    ProtoWeeklyShop,
    ProtoSuitDevelop,
    ProtoGirlBubble,
    ProtoTechTree,
    ProtoMCVPreTaskActivity,
    ProtoGhostMission,
    ProtoSignInMonth,
    ProtoCriticalPointStage,
    ProtoChristmas,
    ProtoChristmasMission,
    ProtoCriticalPointAchievement,
    ProtoCriticalPointJackpot,
    ProtoTower,
    ProtoTowerStage,
    ProtoTowerBossProperty,
    ProtoFriend,
    ProtoATPlayer,
    ProtoATBossInfo,
    ProtoATAssistRecord,
    ProtoFriendInfo,
    ProtoATRecordForView,
    ATBossView,
    ProtoATBossRankView,
    ATBossRankAwardView,
    ProtoQuickCollectBubble,
    ProtoQuickCollectMCV,
    ProtoSeriesLogin,
    ProtoTalentTower,
    ProtoTalentPlayer,
    ProtoTask,
    ProtoEVAChapter,
    ProtoEVATechRoom,
    ProtoEVAGirl,
    ProtoEVABase,
    ProtoEVAAreaRepairInfo,
    ProtoDailyFlag,
    ProtoHistoryView,
    ProtoAccumulateLogin,
    ProtoTeachingRecruit,
    ProtoPopupPackage,
    ProtoOrderLoginNine,
    ProtoAchiRankLvl,
    ProtoMiniMission,
    ProtoEveOfNationalWarPVE,
    ProtoEveOfNationalWarPVP,
    ProtoHonor,
    ProtoPlayerMirror,
    ProtoHonorBase,
    ProtoStoryStage,
    ProtoSweetActivity,
    ProtoPayRecruit,
    ProtoSeasonFighter,
    ProtoSeasonFightLog,
    ProtoBattleDesc,
    ProtoFighterDesc,
    ProtoSeasonBattleGroup,
    ProtoSpecialRanking,
    ProtoBigEvent,
    ProtoNationalWarHexStatus,
    ProtoNationalWarRoomInfo,
    ProtoNationalWar,
    ProtoNationalWarCampInfo,
    ProtoNationalWarFightLog,
    ProtoBikiniBoss,
    ProtoBikiniBBQ,
    ProtoBikiniSeaFloor,
    ProtoSakuraWars,
    ProtoGirlSkinConfig,
    ProtoActivityConfig,
    ProtoURAwakeConfig,
    ProtoRiceCake,
    ProtoNewYearBoss,
    ProtoTexun,
    ProtoBeforeDawn,
    ProtoStageDropView,
    ProtoStarship,
    ProtoStarshipWeapon,
    ProtoStarshipWeaponFavor,
    ProtoStarshipBase,
    ProtoStarshipFetter,
    ProtoStarshipExplore,
    ProtoBattleReport,
    ProtoMonthMission,
    ProtoStarTowerStage,
    ProtoStarshipChip,
    ProtoStarTowerTask,
    ProtoStarshipPVP,
    ProtoPlayerMirrorSP,
    ProtoStarshipPVPRanking,
    ProtoStarshipGuessing,
    ProtoStarshipPVPHistoryReport,
    ProtoStarshipPVPLogDetails
}

public enum DifficultyFlag
{
    Easy,
    Normal,
    Hard,
    Hell,
    Hero
}

public enum DispatchFlowType
{
    开始 = 1,
    放弃,
    完成并获得奖励
}

public enum DispatchResult
{
    失败,
    成功,
    大成功
}

public enum DispatchType
{
    搜索 = 1,
    调查,
    收集,
    战斗
}

public enum DropWidgetType : byte
{
    None,
    领取累积充值奖励,
    部件分解,
    兑换奖池奖励,
    完成机师招募,
    新手任务版本奖励,
    新手任务奖励,
    完成建造部件,
    出售道具,
    商店购买,
    晋级任务完成,
    关卡完成,
    战斗结束,
    邮件,
    克尔贝洛点数奖励,
    使用物品,
    七日奖励,
    自动使用,
    充值,
    完成远征任务,
    领取月卡奖励,
    领取活动成就奖励,
    领取活动日常奖励,
    领取周任务奖励,
    领取区域每日任务奖励,
    礼包,
    个人副本,
    关卡奖励的赏金值和任务经验,
    领取成就奖励,
    单抽,
    商店购买赠送,
    十连抽,
    十连抽额外奖励,
    特殊部件兑换,
    扭蛋抽奖,
    沙滩排球,
    领取机甲兑换奖励,
    泳装送背景,
    夏日回忆活动任务,
    泳装皮肤返利,
    基地车房间拆解返还,
    基地车房间产出,
    B站联动点数兑换,
    B站联动购买兑换次数,
    套装开发,
    基地车前置任务修复房间,
    领取万圣节任务奖励,
    生日送礼,
    低功耗产出,
    基地车更换订单返还,
    技能重复折算道具,
    初始化,
    月签到,
    圣诞节累计格子奖励,
    圣诞节完成关卡,
    圣诞节格子战斗奖励,
    圣诞任务奖励,
    圣诞节格子奖励,
    临界点活动,
    春节活动,
    部件异端化升级,
    部件继承,
    回流玩家登陆奖励,
    模拟训练点数奖励,
    能力测验排行奖励,
    友情点,
    连续登陆奖励,
    天赋爬塔扫荡,
    月面的大暴走,
    EVA,
    无保底单抽,
    无保底十连抽,
    免费十连抽,
    周年庆七日登录奖励,
    夏日复刻扫荡,
    新手教学抽卡,
    卡牌重复折算,
    等不到的黎明,
    预约登陆奖励,
    成就段位,
    整活小活动,
    国战前夕PVE,
    国战前夕PVP,
    有偿抽卡,
    竞技场,
    大型活动攻壳,
    国战,
    轩辕剑联动,
    泳装,
    领取累积消费奖励,
    樱花大战射击小游戏,
    暴风雨之夜,
    彼方之风烹饪取消订单,
    彼方之风烹饪加速完成订单,
    彼方之风烹饪完成订单,
    彼方之风射击小游戏,
    空镜,
    小心陷阱,
    幻想朋友,
    星舰解锁科技树,
    星舰探索,
    星舰交易,
    商业活动领取奖励,
    星舰芯片回收,
    星舰芯片升级,
    星舰pvp战斗
}

public enum DungeOnEndType
{
    中途退出,
    副本结束,
    非正常结束
}

public enum DungeOnResult
{
    Failed,
    Success
}

public enum DungeOnStartType
{
    进入副本,
    战斗开始,
    战斗结束,
    完成副本
}

public enum DungeOnStatusType
{
    关卡阶段有变更 = 1,
    梯队编队有变更
}

public enum EBaseCarRoomClassify : byte
{
    eRoomRest,
    eRoomResource,
    eRoomFactory,
    eCount
}

public enum EBaseCarRoomProduceStatus : byte
{
    eFree,
    eWork,
    eStop,
    eCount
}

public enum EBaseCarRoomType : byte
{
    eRoomDorm = 1,
    eRoom2,
    eRoom3,
    eRoom4,
    eRoomInfo,
    eRoomBar,
    eRoomLutai,
    eRoomRecycle,
    eRoomProdution,
    eRoomWater,
    eRoomFood,
    eRoomPower,
    eRoomDevelop,
    eCount
}

public enum EBaseCarStatus : byte
{
    eNormal = 1,
    eBlue,
    eYellow,
    eOrange,
    eCount
}

public enum ECriticalPointRest : byte
{
    系统重置,
    免费次数重置,
    晶石重置,
    黄金券重置,
    钻石券重置
}

public enum EnergyAddType : byte
{
    UpdateGet,
    LevelUpGet,
    BuyGet,
    UseItemGet,
    GM
}

public enum EPreCarRoomState : byte
{
    未开放,
    已开放,
    修复中,
    修复完成,
    领奖播放剧情
}

public enum EquipChangeType
{
    Equip = 1,
    Dequip,
    Change,
    Auto,
    ChangeAll
}

public enum EventTypes : byte
{
    无,
    充值,
    开启招募队列,
    开启建造队列,
    系统赠送,
    区域日常,
    区域周长,
    成就,
    任务,
    通关关卡,
    通关任务,
    七日奖励领取,
    机娘升级,
    机娘升星,
    机娘好感度升级,
    加速招募,
    购买招募队列,
    加速建造,
    商城购买,
    使用道具,
    出售道具,
    部件强化,
    掉落,
    初始,
    GM,
    个人副本重置,
    机娘技能升级,
    招募机师,
    建造部件,
    章节任务手动刷新,
    兑换奖池奖励,
    购买建造队列,
    单抽,
    十连抽,
    十连抽额外奖励,
    自动补齐,
    购买角色列传次数,
    购买个人副本次数挑战次数,
    扭蛋抽奖,
    基地车升级,
    基地车房间升级,
    基地车房间改造,
    基地车资源扣减,
    基地车订单房间,
    商店购买赠送,
    周常副本手动刷新,
    B站联动点数兑换,
    B站联动购买兑换次数,
    克尔贝洛副刷关卡挑战,
    套装开发,
    基地车前置任务修复房间,
    科技树升级,
    机娘学习技能,
    缔结契约,
    切换机娘被动技能,
    过载模式,
    月签到,
    圣诞节累计格子奖励,
    圣诞节完成关卡,
    骰子奖励,
    骰子惩罚,
    抛骰子,
    圣诞节格子战斗奖励,
    圣诞任务奖励,
    圣诞节任务手动刷新,
    德洛丽丝活动体力,
    德洛丽丝活动重置奖池,
    德洛丽丝活动抽奖,
    德洛丽丝复刷关卡挑战,
    限时部件建造,
    特殊部件兑换,
    装备模块突破,
    装备模块继承,
    装备模块升级,
    装备属性精炼数量增加,
    装备精炼,
    购买曜日副本挑战次数,
    春节活动,
    模拟训练关卡挑战,
    能力测验,
    背包扩容,
    改名,
    装备分解,
    天赋爬塔,
    机娘天赋激活,
    EVA,
    无保底单抽,
    无保底十连抽,
    免费十连抽,
    夏日复刻扫荡,
    机娘觉醒,
    商城刷新购买数量,
    常住商店刷新,
    领取累积充值奖励,
    部件分解,
    新手任务版本奖励,
    新手任务奖励,
    完成建造部件,
    晋级任务完成,
    关卡完成,
    战斗结束,
    邮件,
    克尔贝洛点数奖励,
    自动使用,
    完成远征任务,
    领取月卡奖励,
    领取活动成就奖励,
    领取活动委托奖励,
    领取周任务奖励,
    领取每日委托奖励,
    礼包,
    个人副本,
    沙滩排球,
    领取机甲兑换奖励,
    泳装送背景,
    夏日回忆活动任务,
    泳装皮肤返利,
    基地车房间拆解返还,
    基地车房间产出,
    领取万圣节任务奖励,
    生日送礼,
    基地车低功耗产出,
    基地车更换订单返还,
    技能重复折算道具,
    奈布拉区域10001,
    克格亚区域10002,
    爱蕾塔区域10004,
    海克塞尔区域10005,
    购买赏金次数,
    新手教学抽卡,
    额外付费单抽,
    天赋爬塔扫荡,
    整活小活动,
    国战前夕PVE,
    国战前夕PVP,
    荣誉室升级,
    删除妮娅觉醒碎片,
    删除伊丽莎白觉醒碎片,
    删除什米丽觉醒碎片,
    有偿抽卡,
    竞技场,
    大型活动攻壳,
    国战,
    泳装,
    大型活动樱花,
    元旦2022,
    合成,
    彼方之风烹饪,
    彼方之风烹饪订单加速,
    彼方之风,
    彼方之风射击小游戏,
    怪诞艺术家,
    星舰,
    商业活动晶石购买等级解,
    星舰芯片拆解回收,
    星舰芯片升级,
    春节2023,
    购买星舰pvp门票,
    初始赠送pvp门票3张,
    星舰pvp竞猜下注,
    星舰pvp刷新对手列表,
    星舰pvp开始战斗
}

public enum ExpeditionMissionGetTypes : byte
{
    None,
    Normal,
    Response1,
    Response2
}

public enum ExpeditionMissionStatus : byte
{
    NoAccept,
    Accepted,
    Completed
}

public enum ExpeditionMissionTypes : byte
{
    RefreshMission,
    HistoryMission
}

public enum ExpType
{
    好感度经验 = 1
}

public enum FGMailType
{
    无,
    商店购买,
    系统发送,
    签到奖励,
    新手玩家签到奖励,
    完成成就奖励,
    客服中心发放,
    元旦2022挑战Boss排名奖励邮件,
    泳装小游戏排名奖励邮件,
    区域修复榜单奖励邮件
}

public enum FirstNickNameCreateFlag
{
    usernicknamechange,
    usernicknamecreate
}

public enum FriendTypes
{
    None,
    Friend,
    ByRequest,
    Shield
}

public enum FunctionState : byte
{
    Init,
    Open,
    Finished
}

public enum GachaGender
{
    无性别,
    男性道具,
    女性道具
}

public enum GameOptionCategory
{
    自动战斗,
    基地车低耗能模式,
    激活专用机,
    系统设置
}

public enum GameOptionType
{
    auto,
    hour,
    geartransform,
    system
}

public enum GirlFightStatus : byte
{
    Normal,
    MainGirl,
    SecondGirl,
    SupportGirl1,
    SupportGirl2
}

public enum GirlNatureAttribute
{
    不大于 = -20,
    智慧 = -21,
    制造 = -22,
    灵活 = -23,
    体质 = -24,
    情感 = -25,
    不小于 = -26
}

public enum GmCode
{
    AllItem,
    AllWidget,
    AllGirl,
    AllChapter,
    AddCoin,
    AddDiamond,
    AddLevel,
    MiniGm,
    AddRookbieTaskProc,
    ChangeRookbieTaskState,
    OhMYGodSetGoldNum,
    OhMyGodTtReCharge,
    AddWidgetExchange,
    CodeCommand
}

public enum GoodWillExpGetType
{
    送礼物给角色
}

public enum GotCmd
{
    None,
    DelMail
}

[Flags]
public enum GrowthFundStatus
{
    None = 0,
    GrowthFund = 1,
    Level10 = 2,
    Level20 = 4,
    Level30 = 8,
    Level40 = 0x10,
    Level50 = 0x20,
    Level60 = 0x40,
    Level70 = 0x80,
    Level80 = 0x100
}

public enum HistoricalRecordTypes
{
    无,
    累计登录天数,
    满星角色总数量,
    皮肤总数量,
    专用机收集度,
    基地车科技树升级次数,
    发起远征任务的总次数,
    赏金战斗总次数,
    角色总数,
    基地车房间升级次数
}

public enum InGameEventCateGory
{
    克尔贝洛,
    临界点,
    B站联动,
    累计充值奖励,
    七日登录奖励,
    新手任务
}

public enum InGameEventResult
{
    完成 = 1,
    放弃,
    失败,
    重置,
    进行,
    开始,
    获得奖励
}

public enum InGameEventSubResult
{
    None,
    OneShot,
    TenShot,
    SingleReward,
    VerReward
}

public enum InGameRewardEventType
{
    每日任务,
    每周任务,
    养成活动,
    兑换点数奖励,
    新手任务奖励
}

public enum InventoryExpandType
{
    UseItem,
    Buy
}

public enum InventoryType
{
    Recruit,
    DevelopEquip,
    Mall,
    WidgetRefinePosition
}

public enum ItemBoxType
{
    箱子,
    礼包,
    扭蛋,
    建造,
    招募,
    十连招,
    商店购买,
    角色列传兑换
}

public enum ItemBoxType2
{

}

public enum ItemCreatereSult
{
    Success,
    Failed
}

public enum ItemCreateSubType
{
    普通,
    特殊,
    限时,
    套装,
    基地车
}

public enum ItemCreateType
{
    招募,
    限时招募,
    开发,
    限时开发,
    指定开发,
    指定商店购买,
    合成
}

public enum ItemFlowType
{
    Add = 1,
    Dec
}

public enum ItemIdCategory
{
    角色皮肤 = 100,
    背景,
    角色,
    装备,
    天赋属性
}

public enum ItemUpGradeResult
{
    Failed,
    Success
}

public enum ItemUpGradeType
{
    装备强化,
    角色升级,
    角色升星,
    角色好感度,
    异端化强化,
    异端化经验值阶段,
    异端化突破等级,
    品质提升,
    道具继承,
    道具精制,
    道具精炼次数扩充
}

public enum JoinActibityFalg
{
    二零二一情人节活动
}

public enum LeveType
{
    Req = 11,
    CancelReq = 21,
    LeveNow = 31
}

public enum LogDamageType
{
    竞技场PVP,
    国战PVP,
    国战boss,
    Gm
}

public enum MailFlowType
{
    发送邮件 = 1,
    收到邮件,
    阅读并删除邮件,
    GOT删除邮件
}

public enum MailOpType
{
    发送邮件 = 100,
    接收邮件 = 200,
    读取邮件 = 300,
    删除邮件 = 400,
    清空邮箱 = 500,
    领取道具 = 600,
    领取全部道具 = 700,
    其他行为 = 1000
}

public enum MapAreaTypes : byte
{
    All,
    A1,
    A2,
    A3,
    A4
}

public enum McvActionFlowType
{
    进驻角色 = 11,
    变更进驻的角色 = 21,
    获得奖励 = 31,
    消耗超载芯片变更制造时间 = 41
}

public enum MCVBaseStatus : byte
{
    Normal,
    LevelUP,
    Reform
}

public enum MissionLevelTypes
{
    AttackLevel,
    DefenceLevel,
    ProtectLevel,
    LeaderLevel
}

public enum MissionType
{
    最快任务 = 1,
    较快任务,
    较慢任务,
    最慢任务
}

public enum MonthlyRechargeLimitAgeType : byte
{
    未设置,
    Age15,
    Age16_19,
    Age20
}

public enum NationWarFalg
{
    无,
    A,
    H,
    K,
    R
}

public enum NoticeTypes
{
    None,
    WidgetDevelop,
    WidgetDrop,
    GirlDevelop,
    GirlStarLevelUp,
    GirlAwake,
    NationWarDispatch,
    NationWarPointTaken,
    NationWarSharePoint,
    NationWarBossDeath
}

public enum NxlogAttributeType
{
    角色技能1等级 = -20,
    角色技能2等级 = -19,
    角色技能3等级 = -18,
    角色技能4等级 = -17,
    装备强化等级 = -100,
    角色等级 = -99,
    角色星级 = -98,
    角色好感度等级 = -97,
    缔结契约 = -96,
    装备品质 = -95,
    装备模块经验提升 = -94,
    装备异端化升级 = -93,
    是否继承过 = -92,
    精炼次数上限 = -91
}

public enum NxlogBuffChangeType
{
    通过契约获得加成,
    科技树升级后获得加成奖励,
    通关周常副本获得
}

public enum NxlogBufferChangeBuffType
{
    无,
    契约加成,
    周常副本挑战成功后第一次获得加成,
    科技树加成
}

public enum NxlogChangeType
{
    契约加成,
    科技树加成,
    周常副本通关
}

public enum NXlogMoneyType
{
    AUD,
    CAD,
    CHF,
    CNY,
    EUR,
    GBP,
    JPY,
    NZD,
    XAG,
    XAU,
    XCP
}

public enum NxLogQuestResult
{
    符合条件完成 = 1,
    领取奖励
}

public enum NxLogQuestType
{
    每日委托 = 1,
    每周委托,
    七日登录,
    充值累计,
    月签到,
    活动委托,
    活动点数,
    活动成就,
    新手任务,
    夏日回忆任务,
    夏日回忆送背景
}

public enum NxlogShopType
{
    商城推荐,
    礼包商店,
    皮肤商店,
    道具商店,
    技能商店,
    晶石商店
}

public enum NxLogSkillType
{
    主动,
    被动,
    通用,
    战备,
    设施
}

public enum NxLogType
{
    User_Create,
    User_AccessConnect,
    User_AccessDisconnect,
    User_IngameShopBuy,
    AssetFlow,
    ItemFlow,
    User_AccountSync,
    User_TitleDequip,
    User_TitleEquip,
    User_TitleGet,
    ItemEquipChange,
    User_NameChange,
    User_Levelup,
    User_ItemUpgrade,
    ItemCreate,
    User_CashShopBuy,
    User_IngameShopSell,
    User_InventoryExpand,
    User_Coupon,
    GachaItemGet,
    User_DungeonStart,
    DungeonStatusChange,
    User_DungeonEnd,
    User_QuestAccept,
    User_QuestComplete,
    User_Attend,
    IngameEventReward,
    MailFlow,
    User_Leave,
    User_TrophyComplete,
    User_ItemEvaluate,
    Info_User,
    DispatchFlow,
    Info_UserItem,
    QuestFlow,
    User_GameOptionChange,
    User_TutorialComplete,
    User_UnitAdjust,
    MCVActionFlow,
    User_SelectValue,
    User_SkillGet,
    User_SkillSetChange,
    User_BuffChange,
    User_StatUpgrade,
    User_ShopUIEvent
}

public enum ObjState : byte
{
    Default,
    New,
    Deleted,
    Changed
}

public enum OpenItemOpenType
{
    Init = -1,
    直接打开,
    使用货币或道具打开,
    到期而自动打开
}

public enum OperationCode : short
{
    Ping,
    Login,
    TestDrop,
    Embattle,
    WidgetChange,
    WidgetIntensify,
    WidgetResolve,
    ChangeGirlInWidgetGroup,
    GirlLevelUp,
    GirlStarUp,
    GirlSkillLevelUp,
    GirlSkillBreakthrough,
    GoodwillLevelUp,
    BattleStart,
    BattleEnd,
    EnterStage,
    ExitStage,
    StageComplete,
    DeployBattleGroup,
    QuickDeployBattleGroup,
    RefreshChapterMission,
    ItemSell,
    ItemUse,
    ReadMail,
    ActivateWidgetGroup,
    RecruitGirl,
    CompleteRecruitGirl,
    BuyRecruitQueue,
    QuickCompleteRecruitGirl,
    BuildWidget,
    CompleteBuildWidget,
    BuyBuildQueue,
    QuickCompleteBuildWidget,
    BuyGirlFragment,
    SetBgGirl,
    SetPlayerNickName,
    SetPlayerBirthday,
    SaveGuide,
    Gm,
    AutoEquip,
    AutoDeployBattleGroup,
    SetGirlSKin,
    GetAchievementReward,
    GetRanking,
    BuyShopItem,
    GetSevenLoginReward,
    WidgetLock,
    GetCorberoPointReward,
    ExchangeActivityRewardPool,
    ResetActivityRewardPool,
    GetActivityDailyReward,
    GetActivityAchiReward,
    SetRewardPoolLvIndex,
    AccetpExpeditionMission,
    CompleteExpeditionMission,
    GetAreaDailyMissionReward,
    GetWeeklyMissionReward,
    SetPlayerTitle,
    GetMonthCardReward,
    GetTotalChargeReward,
    GetOrderStatus,
    PersonalStoryBuildWidget,
    CancelExpeditionMission,
    GetGiftByCode,
    GetChargeList,
    GetShopList,
    GetNoticeList,
    GetAchivementList,
    GetCollectList,
    GetAllMail,
    GetRecruitList,
    GetBuildList,
    GetPlayerInfo,
    GetWeeklyMissonList,
    GetAreaDailyMissonList,
    GetActivityList,
    GetExpeditionMissionList,
    ClickLog,
    ResetNightmareStageCd,
    GetRookieTaskList,
    GetRookieTaskReward,
    GetRookieTaskIDReward,
    GetNightmareFirstCompleteReward,
    AcceptRookieTask,
    ChangeCG,
    LikeShopItem,
    GetShopItemLikeInfo,
    GetCurTenRecruitId,
    TenRecruitAction,
    GetCurLimitBuildId,
    LimitBuildWidget,
    WidgetExchange,
    BuyPersonalStoryDailyCount,
    BuyPersonalCopyDailyCount,
    GacyaRaffleAction,
    GetCurGacyaInfo,
    GetBikiniStageList,
    GetCurBeachVolleyballInfo,
    PassBeachVolleyballAction,
    GetWidgetExchangeInfo,
    GetWidgetExchangeAward,
    GetBikiniRefreshMissionList,
    GetBikiniTaskList,
    GetBikiniTaskReward,
    GetBikiniBackGroundTaskIDReward,
    GetBikiniBackGroundTaskList,
    GetBikiniBigSaleAward,
    UnloadAllWidget,
    AcceptBikiniBackGroundTask,
    GetMCVInfo,
    GetMCVRoomInfo,
    MCVLevelUp,
    CompleteMCVLevelUp,
    FastCompleteMCVLevelUp,
    EnterLowCostStatus,
    LeaveLowCostStatus,
    CalcLeakSourceStatus,
    MCVRoomLevelUp,
    CompleteMCVRoomLevelUp,
    FastCompleteMCVRoomLevelUp,
    MCVReformRoom,
    CompleteMCVReformRoom,
    FastCompleteMCVReformRoom,
    DestroyRoom,
    DispatchGirl,
    SwitchGirlRoom,
    UnDispatchGirl,
    GatherSource,
    PlaceOrder,
    PlaceMultiOrder,
    ChangeOrder,
    GatherOrder,
    GatherAllOrder,
    UseOverloadChips,
    GetWeeklyStageList,
    GetWeeklyShopList,
    RefreshWeeklyShop,
    ActivityPointConversion,
    BuyPointConversionCount,
    SuitDevelopGetData,
    SuitDevelopExecute,
    SuitDevelopAccelerate,
    SwitchUsedMCVSkill,
    ClickRandomBubble,
    RefreshBubble,
    SelectBubble,
    RecieveBubbleAward,
    GetPreBaseCarInfo,
    RepairPreBaseCar,
    ChangePreBaseCarState,
    GetTechTreeInfo,
    TechTreeNodeLevelUp,
    GirlLearnSkill,
    GirlWedding,
    GetGhostMissionList,
    GetGhostMissionReward,
    GetBirthdayPresent,
    RefreshTechRoomOrder,
    SetTouchSound,
    ResetAllOrder,
    RecoverLeakSourceStatus,
    SwitchMultiGirls2Room,
    SetFistPlayPreMCVPlot,
    Logout,
    UserAccountSync,
    UserLeave,
    FreeSign,
    ExtraSign,
    GetSignInfo,
    GetDoloresActivityInfo,
    BuyDoloresActivityChallengeCount,
    ResetDoloresActivityRewardPool,
    ExchangeRewardDoloresActivity,
    GetDoloresActivityAchiReward,
    GetChristmasInfo,
    PlayDice,
    PlayComplete,
    GetChristmasMissionList,
    GetChristmasMissionReward,
    RefreshChristmasMission,
    CompleteRecruitAllGirl,
    GetCellPrize,
    CompleteBuildAllWidget,
    Try2AppearBubble,
    GetDoloresAchiInfo,
    GetDoloresJackpotInfo,
    GatherAllRoom,
    WidgetQualityUp,
    WidgetModuleLevelUp,
    WidgetBreakThrough,
    WidgetInherit,
    WidgetRefine,
    CompleteWidgetRefine,
    AddWidgetRefinePosition,
    BuyDailyStageCount,
    TowerBattleStart,
    TowerBattleEnd,
    SetupUsedAwardTicketNum,
    GetTowerInfo,
    FreshTowerShop,
    RecoverTowerEnergy,
    GetTowerBossProperty,
    CompleteTowerAchievement,
    GetComeBackReward,
    GetTowerStageInfo,
    SweepOutTowerStage,
    TryRecieveRankingAward,
    CheckSweepOutClear,
    RefreshFinalBossStage,
    SearchFriend,
    RecommendFriend,
    RequestAddFriend,
    AgreeAddFriend,
    RefuseAddFriend,
    ShieldFriend,
    UnShieldFriend,
    DeleteFriend,
    GiveFriendGift,
    GetFriendGift,
    GiveAllFriendGift,
    GetAllFriendGift,
    GetFriendList,
    GetFriendRequestList,
    GetFriendShieldList,
    GetFriendInfo,
    ATChallengeBattleStart,
    ATChallengeBattleEnd,
    ATAssistBattleStart,
    ATAssistBattleEnd,
    ATGetAssistRecord,
    ATInitiateAssistBattle,
    ATSearchBoss,
    ATGetRankInfo,
    FriendEmbattle,
    QuickCollectBubble,
    QuickCollectMCVRoom,
    WidgetBagExpand,
    RecieveSeriesLoginAward,
    TalentActivate,
    TalentTowerBattleStart,
    TalentTowerBattleEnd,
    GetTalentTowerInfo,
    TalentTowerQuickBattle,
    ResetTalentTower,
    SetTalentTowerBattleGroup,
    SelectDifficulty,
    GetTaskInfoByFunction,
    RecieveTaskReaward,
    GetProtoEVAChapterInfo,
    EVABattleStart,
    EVABattleEnd,
    SweepStage,
    GetProtoEVATechRoomInfo,
    AddTechRoomExp,
    PlaceTechRoomOrder,
    ReduceCompleteCycle,
    CompleteTechOrder,
    GetEVAGirlsInfo,
    GiveGiftsToEVAGirl,
    RecieveEVALikeabilityAward,
    PhyExchange,
    EVABossBattleStart,
    EVABossBattleEnd,
    BuyEVABossTicket,
    GetProtoEVABaseInfo,
    GetAreaRepairInfo,
    RecieveAreaRepairAward,
    DiamondCompleteTask,
    NoTurnTenRecruit,
    DonateAction,
    RecieveShopAward,
    RecieveAreaStarsAward,
    GetHistoryView,
    GetAnniversaryLoginAward,
    GetAnniversaryLoginDatas,
    AnniversaryAnimationEnd,
    BikiniSweepStage,
    BuyAreaMissionTimes,
    TeachingRecruitInfo,
    TeachingRecruit,
    CompletedTeachingRecruit,
    SetMonthlyRechargeType,
    PromoteGirlQuality,
    RefreshBuyNum,
    RecieveProcessAward,
    FreshSuitShop,
    GetOrderLoginNineReward,
    UseItems,
    GetAchiRankLvl,
    RecieveAward,
    GetMiniMissionList,
    GetMiniMissionReward,
    RecieveMultiTaskAward,
    GetEveOfNationalWarPVEInfo,
    SetNationalWarPVEBattleGroup,
    EveOfNationalWarPVEBattleStart,
    EveOfNationalWarPVEBattleEnd,
    EveOfNationalWarPVPBattleStart,
    EveOfNationalWarPVPBattleEnd,
    GetEveOfNationalWarPVPInfo,
    SetNationalWarPVPBattleGroup,
    FreeReviveBattleGroup,
    PaidReviveGirl,
    GetHonorInfo,
    HonorLevelUp,
    HonorUnlock,
    HonorSet,
    AnswerHonorQuest,
    GetFriendHonorInfo,
    RefreshPVPEnemy,
    RecievePhaseAward,
    GetStoryStageInfo,
    StoryPointBattleStart,
    StoryPointBattleEnd,
    PassStoryPointDriectly,
    FavorInfo,
    FavorGift,
    FavorAchiReward,
    FavorSweep,
    FavorBuyTili,
    PayRecruitRound,
    GetSeasonFighterInfo,
    SetSeasonBattleGroup,
    GetProtoSeasonBattleGroupInfo,
    RefreshEnemy,
    SeasonFightBattleStart,
    SeasonFightBattleEnd,
    GetSpecialRanking,
    GetSpecialPlayerMirror,
    GetProtoSeasonFightLogInfo,
    BuyFightSeasonTickets,
    GetBigEventInfo,
    GetBigEventReward,
    BigEventBattleStart,
    BigEventBattleEnd,
    BigEventBuyTili,
    RecieveBigEventAreaStarsAward,
    BigEventSweep,
    ReportEnemy,
    GetNationalWarInfo,
    RegisterForNationalWar,
    NationalWarBuyTickets,
    SetNationalWarBattleGroup,
    NationWarPrepareForBattle,
    NationalPveBattleStart,
    NationalPveBattleEnd,
    NationalPVPBattleStart,
    NationalPVPBattleEnd,
    NationalWarBossBattleStart,
    NationalWarBossBattleEnd,
    NationalWarReceiveArmy,
    NationalWarHonor,
    NationalWarDispatch,
    NationalSetStroy,
    NationalWarGiveUpHex,
    NationalWarGetCampInfo,
    NationalWarGetPlayerMirror,
    NationalWarUpdateHexs,
    NationalWarGetFightLog,
    NationalWarReportEnemy,
    BikiniGacyaRaffle,
    BikiniJumpNextPool,
    GetBikiniBossInfo,
    BikiniBossSetSocket,
    BikiniBossGetFractionReward,
    BikiniBossBattleStart,
    BikiniBossBattleEnd,
    BikiniSeaFloorGetInfo,
    BikiniSeaFloorSelect,
    BikiniSeaFloorOpenBox,
    BikiniSeaFloorSelectLuck,
    BikiniSeaFloorBattleStart,
    BikiniSeaFloorBattleEnd,
    BikiniSeaFloorSelectTreasure,
    BikiniSeaFloorUserRevive,
    BikiniSeaFloorUserBless,
    BikiniSeaFloorSetBattleGroup,
    BikiniSeaFloorGetBBQInfo,
    BikiniBBQBattleStart,
    BikiniBBQBattleEnd,
    GetProtoSakuraWarsInfo,
    GetSumConsumeReward,
    EndSakuraWarsShooting,
    GetGirlSkinConfig,
    GetActivityConfig,
    GetURAwakeConfig,
    GetRiceCakeInfo,
    SetRiceCakeScore,
    GetRiceCakeScoreReward,
    ItemComposition,
    GetYear2022BossInifo,
    NewYear2022BattleStart,
    NetYear2022BattleEnd,
    GetYear2022MissionReward,
    GetTexunInifo,
    TexunBattleStart,
    TexunBattleEnd,
    BuyNewYearBuff,
    SetTexunBattleGroup,
    GetBeforeDawnInfo,
    BeginCooking,
    CancelCooking,
    AccelerateCooking,
    RecieveCookingAward,
    BeforeDawnShooting,
    GetStageDrpView,
    GetStarshipInfo,
    StarshipPosLevelUp,
    StarshipLevelUp,
    StarshipStarLevelUp,
    StarshipDispatchGirl,
    StarshipSwitchGirl,
    StarshipUnDispatchGirl,
    GetStarshipWeapons,
    StarshipWeaponStarLevelUp,
    StarshipWeaponUpload,
    StarshipWeaponUnload,
    GetStarshipWeaponFavors,
    StarshipWeaponFavorSave,
    StarshipWeaponFavorEdit,
    StarshipUseWeaponFavor,
    GetStarshipBaseInfo,
    StarshipUnlockTechTree,
    StarshipFragmentExchange,
    GetStarshipCollects,
    StarshipFetterAction,
    StarshipFetterEffectAction,
    GetStarshipExploreInfo,
    StarshipSetChapter,
    StarshipBeginExplore,
    StarshipEndExplore,
    StarshipBeginEvent,
    StarshipBeginQuizEvent,
    StarshipBeginTradeEvent,
    StarshipBeginStoryEvent,
    StarshipBeginFightEvent,
    StarshipBeginSPEvent,
    StarshipWatchThePlot,
    StarshipBuyShip,
    StarshipBuyExplorePhy,
    StarshipGetStarReward,
    TenStarshipRecruitAction,
    GetMonthMissionInfo,
    GetMonthMissionReward,
    BuyMonthMissionReward,
    GetStarshipChipInfo,
    StarshipChipLoad,
    StarshipChipUnLoad,
    StarshipChipLock,
    StarshipChipLevelUp,
    StarshipChipResolve,
    GetStarshipTowerInfo,
    ResetStarshipTower,
    BuyStarshipTowerTimes,
    StarshipTowerGirlBattleStart,
    StarshipTowerGirlBattleEnd,
    StarshipTowerShipBattleAction,
    GetStarTowerTaskList,
    GetStarTowerTaskReward,
    StarshipSelectedSkill,
    GetStarshipPVPRivals,
    GetStarshipPVPTop,
    StarshipPVPSaveFormation,
    GetStarshipPVPReports,
    GetHistoryReportBattleDetails,
    LockStarshipPVPReport,
    GetStarshipPVPGuessBattle,
    StarshipPVPGuess,
    StarshipPVPGuessBattleReview,
    BuyStarshipPVPTicket,
    FightStarshipPVP,
    RefreshRivalList
}

public enum OrderStatus
{
    开始下单 = 100,
    支付完成并发货 = 200,
    订单被取消 = 300,
    其他 = 1000
}

public enum PcType
{
    User = 1,
    Character,
    Guild
}

public enum QuestCategory
{
    Quset = 1,
    Achievement = 2,
    Mission = 3,
    Etc = 9
}

public enum QuestCause
{
    刷新,
    完成,
    取消,
    过期
}

public enum QuestFlowType
{
    接受 = 11,
    达成条件 = 21,
    领取奖励 = 22,
    放弃 = 31,
    失败 = 32
}

public enum QuestType
{
    无,
    主线任务,
    赏金,
    紧急赏金,
    每日委托,
    每周任务,
    远征,
    新手任务,
    贝洛儿主线任务,
    贝洛儿每日任务,
    贝洛儿成就,
    主线成就,
    夏日活动主线,
    夏日活动任务,
    夏日活动送背景,
    B站联动主线任务,
    B站联动每日任务,
    万圣节任务,
    圣诞任务,
    临界点任务,
    临界点成就,
    B站活动换皮,
    万圣节2020任务,
    日服攻壳
}

public enum RankingTypes : byte
{
    BountyPoint,
    BattlePower,
    AchievementPoint,
    TowerPoint,
    WeeklyBoss,
    EVAAreaRepair,
    HonorPoint,
    SeasonAreaPoint,
    GirlsPowerSum,
    NationalSingleBossDamage,
    NationalTotalBossDamage,
    NationalPvpKill,
    BikiniBBQ,
    NewYear2022Boss,
    StarshipPVP
}

public enum RecruitSubTypes : byte
{
    Normal,
    PersonalStory
}

public enum RecruitTypes : byte
{
    机师,
    部件
}

public enum RefreshShopType : byte
{
    Free,
    SliverKey,
    Crystal
}

public enum ResultDetailType
{
    装备强化等级提升,
    角色等级提升,
    角色星级提升,
    角色技能等级提升,
    角色好感度等级提升,
    角色契约成立
}

public enum RewardarrayType
{
    assettype,
    itemtype,
    bufftype,
    exptype,
    exttype,
    wisdom,
    manufacture,
    flexible,
    constitution,
    emotion
}

public enum RewardCategory
{
    免费货币类型 = 1,
    游戏货币类型 = 2,
    疲劳度类型 = 3,
    道具类型 = 4,
    buff类型 = 5,
    其他货币类型 = 6,
    付费货币类型 = 7,
    经验值类型 = 8,
    其他 = 99
}

public enum RewardGetState : byte
{
    Uncompleted,
    Completed,
    Received
}

public enum RookieLevelType
{
    All,
    Attack,
    Defence,
    Protect
}

public enum RookieTaskState : byte
{
    WaitAccept,
    Progress,
    Completed,
    Received
}

public enum SelectValueType
{
    金币,
    道具,
    天赋属性点,
    后勤技能
}

public enum ShopSellType
{
    出售,
    批量出售,
    再出售
}

public enum ShopType : byte
{
    None,
    General,
    General15,
    General25,
    GuildShop,
    Test,
    Activity1,
    Activity2_1,
    PartsShop,
    Activity2_2
}

public enum ShopUIEventType
{
    进入商店,
    退出商店,
    切换Tap
}

public enum SkillArrayTypes
{
    SkillArray1,
    SkillArray2,
    SkillArray3,
    SkillArray4
}

public enum SkillCategory
{
    战斗技能,
    科技树
}

public enum SkillChangeType
{
    startLevel,
    skillLele
}

public enum SkillUpgradeResult
{
    Failed,
    Success
}

public enum SkillUpgradeType
{
    SkillLevel
}

public enum SpediaMoney
{
    不大于 = -10,
    角色列传 = -11,
    个人副本 = -12,
    克尔贝洛之影 = -13,
    夏日回忆 = -14,
    不小于 = -15
}

public enum StageStatus : byte
{
    NoFighting,
    Fighting
}

public enum StageTypes : byte
{
    主线关卡,
    任务关,
    克尔贝洛活动关,
    夏日回忆,
    无
}

public enum StarshipAttackUnitTypes : byte
{
    无,
    我方主炮,
    我方基础炮,
    我方副炮1,
    我方副炮2,
    我方副炮3,
    我方副炮4,
    我方船体,
    敌方主炮,
    敌方基础炮,
    敌方副炮1,
    敌方副炮2,
    敌方副炮3,
    敌方副炮4,
    敌方船体
}

public enum StarshipCollectTaskState
{
    初始化 = -1,
    进行中,
    已完成,
    已激活
}

public enum StarshipExploreEventStarType
{
    星1 = 1,
    星2,
    星3
}

public enum StarshipExploreEventTerrainType
{
    平原 = 1,
    森林,
    海面,
    雪原
}

public enum StarshipGunType
{
    主炮 = 1,
    基础炮,
    副炮1,
    副炮2,
    副炮3,
    副炮4,
    Max
}

public enum StarshipOperableUnit : byte
{
    无,
    船体,
    主炮,
    基础炮,
    副炮1,
    副炮2,
    副炮3,
    副炮4
}

public enum StatChangeType
{
    级别,
    经验
}

public enum StatUpgradeType
{
    升星,
    升级,
    初始化
}

public enum TowerMissionType
{
    日常任务 = 1,
    周常任务,
    成就
}

public enum TrophyResult
{
    符合条件完成,
    领取奖励
}

public enum TrophyType
{
    主线,
    活动成就
}

public enum TutorialResult
{
    Failed,
    Success
}

public enum UnionLogTypes : byte
{
    CreateUnion = 1,
    DonateCoin = 2,
    ChangePosition = 3,
    JoinUnion = 4,
    QuitUnion = 5,
    DonateCrystal = 6,
    UnionSignin = 7,
    GuildUpgrade = 14,
    GuildWarRecordPlayer = 100,
    GuildWarRecordNpc = 101,
    GuildWarRecordFinish = 102
}

public enum UnitStatus
{
    房间未开放,
    房间已开放,
    房间修复中,
    房间修复完成,
    领奖播放剧情,
    房间普通状态,
    房间升级中,
    房间改造中
}

public enum UnitType
{
    舰桥,
    宿舍类,
    资源类,
    订单类
}

public enum UpdateRoleType
{
    None,
    AttackLevel,
    DefenceLevel,
    ProtectLevel,
    LeaderLevel,
    GirlLevel,
    GirlStart,
    GirlSkillLevel,
    Widget
}

public enum UpTypes : byte
{
    None = 99,
    PlayerExp = 0,
    GirlExp = 1,
    Coin = 2,
    DropRate = 3,
    DailyMaxExp = 4,
    DailyMaxCoin = 5
}

public enum UserLevelUpType
{
    Init,
    UseItem,
    Activity,
    Normal,
    GM
}

[Flags]
public enum VIPLevelGiftStatus
{
    None = 0,
    VIP0 = 1,
    VIP1 = 2,
    VIP2 = 4,
    VIP3 = 8,
    VIP4 = 0x10,
    VIP5 = 0x20,
    VIP6 = 0x40,
    VIP7 = 0x80,
    VIP8 = 0x100,
    VIP9 = 0x200,
    VIP10 = 0x400,
    VIP11 = 0x800,
    VIP12 = 0x1000
}

[Flags]
public enum VIPWeeklyShopStatus
{
    None = 0,
    VIP0 = 1,
    VIP1 = 2,
    VIP2 = 4,
    VIP3 = 8,
    VIP4 = 0x10,
    VIP5 = 0x20,
    VIP6 = 0x40,
    VIP7 = 0x80,
    VIP8 = 0x100,
    VIP9 = 0x200,
    VIP10 = 0x400,
    VIP11 = 0x800,
    VIP12 = 0x1000
}

public enum WeeklyStageDifficulty
{
    普通,
    挑战模式
}

public enum WidgetType
{
    Weapon,
    Lorica,
    Legs,
    Back,
    Parts1,
    Parts2
}

public enum WindConiType
{
    无 = 0,
    消灭敌人数 = 1,
    消灭指定目标 = 2,
    时间到 = 4,
    到达目的地 = 8,
    到达目的地2限制怪物在镜头内 = 16,
    到达终点 = 101,
    全部占领 = 102,
    占领任意 = 103,
    占领全部敌方 = 104,
    击败目标 = 105,
    击败全部 = 106
}
public enum AccumulateLoginTypes
{
    无,
    周年庆福利,
    多日登录,
    单日奖励
}

public enum Achievement
{
    无,
    佣兵团等级,
    将一定数量的机师提升到一定等级,
    分解次数,
    装备开发次数,
    机师招募次数,
    拥有一定品质的机师数量,
    机师强化次数,
    机师技能升级次数,
    将一定数量的机师提升到一定星级,
    将一定数量的机师技能提升到一定等级,
    强化部件次数,
    将一定数量的部件强化到一定等级,
    收集一定品质的一定数量的武器,
    收集一定品质的一定数量的胸甲,
    收集一定品质的一定数量的腿甲,
    收集一定品质的一定数量的挂载,
    通关关卡,
    完成进攻类型的任务次数,
    完成防守类型的任务次数,
    完成护送类型的任务次数,
    完成紧急类型的任务次数,
    击杀怪物总数量,
    战斗最高伤害,
    任务最高伤害,
    任务中技能释放次数,
    任务手动刷新次数,
    攻击任务等级,
    防守任务等级,
    护送任务等级,
    命令任务等级,
    赏金值,
    结交一定数量好友,
    与好友结伴作战次数,
    三星通关关卡,
    区域解锁度,
    套装获取,
    远征成功次数,
    远征大成功次数,
    在某区域远征次数,
    图鉴机师收集数,
    图鉴量产机收集数,
    图鉴专用机收集数,
    分解次数熟悉,
    分解次数精通,
    将一定数量的机师提升到一定等级8,
    将一定数量的机师提升到一定等级14,
    将一定数量的机师提升到一定等级角色,
    收集一定品质的一定数量的挂载48,
    收集一定品质的一定数量的挂载52,
    收集一定品质的一定数量的挂载56,
    区域解锁度91,
    区域解锁度92,
    区域解锁度93,
    将一定数量的机师提升到一定等级9,
    将一定数量的机师提升到一定等级15,
    将一定数量的机师提升到一定等级3,
    将一定数量的部件强化到一定等级37,
    将一定数量的部件强化到一定等级38,
    将一定数量的部件强化到一定等级39,
    将一定数量的部件强化到一定等级40,
    机师招募次数12,
    机师招募次数18,
    收集一定品质的一定数量的腿甲47,
    收集一定品质的一定数量的腿甲51,
    收集一定品质的一定数量的腿甲55,
    收集一定品质的一定数量的武器45,
    收集一定品质的一定数量的武器49,
    收集一定品质的一定数量的武器53,
    收集一定品质的一定数量的胸甲46,
    收集一定品质的一定数量的胸甲50,
    收集一定品质的一定数量的胸甲54,
    套装获取78,
    套装获取79,
    套装获取80,
    通关关卡75,
    通关关卡76,
    佣兵团等级7,
    佣兵团等级13,
    拥有一定品质的机师数量20,
    拥有一定品质的机师数量21,
    拥有一定品质的机师数量22,
    在某区域远征次数84,
    在某区域远征次数85,
    在某区域远征次数86,
    装备开发次数11,
    装备开发次数17,
    将一定数量的机师提升到一定星级32,
    将一定数量的机师提升到一定星级33,
    将一定数量的机师提升到一定星级34,
    将一定数量的机师提升到一定等级角色26,
    将一定数量的机师提升到一定等级角色27,
    将一定数量的机师提升到一定等级角色28,
    将一定数量的机师提升到一定等级角色29,
    将一定数量的机师提升到一定等级角色30,
    周常副本三星通关,
    拥有一定品质的机师数量23,
    将一定数量机师觉醒至SSR,
    将一定数量机师觉醒至UR,
    竞技场首次达到某一段位1,
    竞技场首次达到某一段位2,
    竞技场首次达到某一段位3,
    竞技场首次达到某一段位4
}

public enum AchievementSubType
{
    无,
    入门,
    熟悉,
    精通,
    角色,
    装备,
    主线剧情,
    任务,
    好友,
    角色剧情,
    远征,
    区域探索,
    机师,
    量产机,
    专用机
}

public enum AchievementType
{
    无,
    新手,
    战斗力,
    探索,
    社交,
    图鉴
}

public enum ActivityOpenLimitType
{
    无,
    佣兵团等级,
    通关特定关卡
}

public enum ActivityType
{
    无,
    克尔贝洛,
    泳装活动1,
    泳装活动2,
    泳装活动3,
    泳装活动4,
    B站联动,
    一体机改造,
    基地车前置,
    基地车正式版,
    万圣狂欢,
    临界点,
    圣诞活动,
    春节活动1,
    春节活动2,
    春节活动3,
    春节活动4,
    月面的大暴走,
    EVA活动总,
    EVA活动一期,
    EVA活动二期,
    等不到的黎明,
    黑色方舟计划,
    昨日头条,
    给糖也捣蛋,
    称号任务,
    EVA2活动总,
    EVA2活动一期,
    EVA2活动二期,
    情人节japan2021,
    轩辕剑联动,
    特殊活动1,
    特殊活动2,
    特殊活动3,
    特殊活动4,
    攻壳机动队,
    樱花大战,
    暴风雨之夜,
    元旦活动2022,
    彼方之风,
    空镜,
    怪诞艺术家,
    小心陷阱,
    幻想朋友,
    勇士,
    莎伦的一天,
    春节活动2023,
    红线,
    占位8,
    占位9,
    占位10,
    占位11,
    占位12,
    占位13,
    占位14,
    占位15,
    占位16,
    占位17,
    占位18,
    占位19,
    占位20
}

public enum ActType
{
    Recharge,
    TenGacha,
    SuitCollet,
    EquipGrade,
    EquipLevel,
    EquipStar,
    TeamLevel,
    LimitedBuy,
    SearchTreature
}

public enum AddEffectType
{
    无,
    添加BUFF,
    被动属性加成,
    实时属性加成,
    获取能量,
    驱散增益效果,
    净化负面效果,
    复活,
    反伤,
    反射减益状态,
    吸血,
    召唤,
    造成伤害,
    耐久关联,
    敌人数量关联,
    队友数量关联,
    吸收回血,
    免疫死亡,
    吸取属性,
    损失耐久,
    刷新减益效果,
    伤害倍增,
    伤害倍增通过BUFF层数,
    随机添加随机数量BUFF,
    移除指定BUFF,
    添加目标异常状态临时属性,
    增加Buff叠加层数,
    禁止指定BUFF,
    禁止被动触发,
    伤害关联BUFF,
    目标耐久关联属性,
    减少本次伤害,
    移除指定个数召唤物,
    召唤物数量关联属性,
    指定召唤物数量关联属性,
    随机多次添加BUFF,
    刷新指定Buff,
    实时多倍属性加成,
    指定BUFF延长,
    释放技能,
    血量比例关联BUFF,
    添加BUFF根据层数添加额外BUFF,
    回复耐久,
    延长或添加BUFF,
    添加光环,
    修改当前BUFF层数,
    造成伤害通过其他参数,
    修改BUFF层数通过战场BUFF数量,
    修改BUFF层数通过随机数,
    耐久比例关联,
    目标强制死亡,
    AOE驱散,
    AOE净化,
    随机移除指定类型的BUFF,
    造成直接伤害,
    技能效果占位1,
    技能效果占位2,
    技能效果占位3,
    技能效果占位4
}

public enum AnimationCycleType
{
    无,
    整体循环,
    射击循环
}

public enum Armortype
{
    轻型装甲,
    重型装甲,
    生物装甲,
    能量装甲
}

public enum AssistAddType
{
    无,
    添加Buff
}

public enum AssistTargetType
{
    无,
    自己,
    全体队友,
    随机一名队友,
    随机一名挂载有负面状态的队友,
    随机一名已经死亡的队友
}

public enum AssistType
{
    无,
    复活,
    清除负面状态,
    添加Buff,
    不消耗子弹,
    随机添加Buff,
    重置冷却
}

public enum AuraEffectType
{
    无,
    增加属性,
    减少属性,
    获得状态
}

public enum AuraRangeType
{
    无,
    自己,
    全体友军,
    全体敌军
}

public enum AutoUsedType
{
    无,
    冷却结束
}

public enum AwardType
{
    无,
    无条件获得,
    获得SSR机师时获得,
    随机获得一个,
    获得UR机师时获得
}

public enum BackGroundType
{
    无,
    背景,
    CG,
    静态舰桥背景
}

public enum BattleValueType
{
    无,
    固定数值,
    随等级变化
}

public enum BeforeDawntMonsterType
{
    小怪,
    BOSS,
    哥布林
}

public enum BigEventsTaskType
{
    无,
    通关指定关卡次数,
    消耗一定数量道具,
    三星通关指定关卡次数,
    通关指定类型关卡次数,
    捐献指定次数
}

public enum BikiniBackgroundType
{
    无,
    完成一定次数的夏日回忆活动关卡,
    机师招募次数,
    装备开发次数,
    强化部件次数,
    快速招募次数,
    击败敌人数量,
    远征成功次数,
    个人副本完成次数,
    通关角色列传的探索关卡
}

public enum BikiniGacyaType
{
    无,
    扭蛋抽取,
    EVA有限奖池,
    泳装2020,
    EVA2有限奖池,
    泳装2021,
    攻壳有限奖池,
    樱花有限奖池,
    元旦2022有限奖池,
    春节2023有限奖池
}

public enum BikiniTaskType
{
    无,
    完成泳装副本次数,
    招募次数,
    击败泳装副本敌人,
    完成泳装BOSS副本次数,
    研发次数,
    远征次数,
    三星通关关卡,
    获得道具
}

public enum BornBuff
{
    无,
    伤害提高,
    特殊奖励翻倍,
    全部奖励翻倍
}

public enum BOSSTaskType
{
    完成阶段X,
    Y秒内通关X阶段,
    不禁用技能的情况下通关阶段X,
    阶段X伤害达到Z
}

public enum BuffEffectType
{
    无,
    减益,
    增益,
    控制
}

public enum BuffEndType
{
    无,
    命中次数,
    受击次数,
    指定Buff结束,
    命中延迟结束,
    状态移除,
    叠加层数,
    修改指定buff层数
}

public enum BuffParameterType
{
    无,
    兑换币掉落量提高,
    图纸掉落率提高,
    头目战挑战次数增加
}

public enum BuffPropertySource
{
    无,
    自己,
    目标
}

public enum BuffTakeEffectType
{
    挂载生效,
    条件生效
}

public enum BuffTriggerTargetType
{
    无,
    攻击者,
    承载者,
    挂载者,
    全体友军,
    全体敌军,
    当前攻击目标
}

public enum BuffTriggerType
{
    无,
    受到伤害时,
    使用普通攻击命中目标时,
    当前耐久低于一定比例,
    移动状态时,
    拥有者死亡时
}

public enum BuffType
{
    火力,
    脱力,
    护盾,
    上限提高,
    下限提高,
    上限降低,
    下限降低,
    全速,
    干扰,
    装甲,
    破甲,
    动力,
    止步,
    迟缓,
    偏折,
    悬浮,
    免疫,
    起火,
    触发几率提高1,
    触发几率提高2,
    触发几率提高3,
    触发几率提高4,
    触发几率提高5,
    触发几率提高6,
    触发几率提高7,
    触发几率提高8,
    触发几率提高9,
    触发几率提高10,
    触发几率提高11,
    触发几率提高12,
    触发几率提高13,
    触发几率提高14,
    触发几率提高15,
    触发几率提高16,
    触发几率提高17,
    触发几率提高18,
    触发几率提高19,
    触发几率提高20,
    触发几率提高21,
    触发几率提高22,
    触发几率提高23,
    触发几率提高24,
    触发几率提高25,
    触发几率提高26,
    触发几率提高27,
    触发几率提高28,
    触发几率提高29,
    触发几率提高30,
    触发概率31,
    触发概率32,
    套装火力,
    暴击率提高,
    套装动力,
    伪报
}

public enum BuyLimitType
{
    无,
    周期限制,
    账号限制,
    周限定,
    月限定,
    周常交换所,
    春节活动,
    弹出时限
}

public enum Category
{
    无,
    主武器,
    副武器,
    普攻
}

public enum ChapterType
{
    Normal,
    Elite,
    DailyMoney,
    DailyWidgetExp,
    DailyWidgetStar,
    NestStage,
    TowerStage,
    WorldBoss,
    PVPStage,
    ActivityChapter,
    Activity2Chapter
}

public enum CheckPointStarRequestType
{
    指定场次胜利,
    累积胜利场次,
    指定场次回合限制
}

public enum Chipquality
{
    R,
    SR,
    SSR
}

public enum ChipQualityType
{
    无,
    R,
    SR,
    SSR
}

public enum ChristmasEventType
{
    无,
    圣诞老人的祝福,
    好人好报,
    神秘礼物,
    伙伴的激励,
    路边的圣诞礼物,
    捣乱的圣诞老人,
    命运格子,
    战斗,
    我要冬眠了,
    不务正业,
    被乌龟附身,
    努力的伊芙琳,
    起点,
    终点,
    碰到坏人,
    迷迷糊糊,
    财神附体,
    梦游,
    圣诞礼物
}

public enum ChristmasTaskType
{
    无,
    装备开发次数,
    机师招募次数,
    远征成功次数,
    装备分解次数,
    专用机副本,
    机师技能升级次数,
    强化部件次数,
    快速招募次数,
    快速制造次数,
    赏金任务完成次数,
    紧急任务完成次数,
    特殊装备开发次数,
    特殊招募次数,
    完成击杀敌人数量,
    升星
}

public enum ControlAddType
{
    无,
    添加Buff
}

public enum ControlTargetType
{
    无,
    全体敌人,
    随机一名敌人
}

public enum ControlType
{
    无,
    击退,
    清除有益状态
}

public enum CorberoAchieveType
{
    无,
    通关指定关卡,
    三星通关指定关卡,
    五分钟内完成指定关卡,
    抽奖一定次数
}

public enum CorberoDailyMissionType
{
    无,
    通关任意关卡一定次数,
    通关指定关卡一定次数,
    通关关卡获得一定活动点数,
    通关关卡获得一定数量道具,
    完成机师招募,
    完成击杀敌人数量,
    完成远征指定次数,
    完成部件研发,
    获得B站联动点数,
    获得B站联动B站小电视,
    使用B站联动点数兑换奖励,
    完成委托任务,
    通关任意关卡单次,
    通关任意关卡多次,
    获得万圣节糖果,
    获得万圣节面具,
    通关赏金关卡多次,
    完成赏金内击杀敌人数量,
    获得2020万圣节糖果,
    获得2023元旦抽奖券
}

public enum CorberoMissionType
{
    无,
    主线任务,
    复刷任务
}

public enum CriticalPointAchieveType
{
    无,
    通关指定关卡,
    三星通关指定关卡,
    五分钟内完成指定关卡,
    抽奖一定次数,
    三分钟内完成指定关卡
}

public enum CriticalPointJackpotType
{
    稀有,
    高价值,
    中价值,
    低价值
}

public enum CriticalPointMissionType
{
    无,
    主线任务,
    复刷任务
}

public enum DailyMissionLimit
{
    无,
    玩家等级大于,
    玩家等级大于等于,
    玩家等级等于,
    玩家等级小于等于,
    玩家等级小于,
    通关指定关卡,
    禁用
}

public enum DailyMissionType
{
    无,
    完成一定次数的赏金任务,
    完成一定次数的紧急任务,
    完成一定次数的副本任务,
    完成一定次数的日常任务,
    招募一定次数,
    开发一定次数,
    远征一定次数,
    完成所有其他每日委托,
    强化部件一定次数,
    完成个人剧情关卡一定次数,
    完成异端化关卡一定次数,
    基地车领取任意房间资源一定次数,
    经过指定时间,
    完成协力本多次,
    完成天赋本多次
}

public enum DailyQuestType
{
    None,
    NormalBattle,
    EliteBattle,
    BuyMoney,
    BuyEnergy,
    Develop,
    Strengthen,
    ChipLevelUp,
    GirlLevelUp,
    GirlSkillLevelUp,
    GiveFriendEnergy,
    PVPWin,
    TowerBattle,
    NestClear,
    EquipDevelop,
    EquipLevel,
    MainClear,
    ChipDevelop,
    TeamLevel,
    EquipGet,
    AllClear,
    DailyBattle,
    ConsumeOil,
    GetPoint,
    ConsumeDiamon,
    PrestigeLevel,
    Pokedex
}

public enum DailyStageOpenTime
{
    周日,
    周一,
    周二,
    周三,
    周四,
    周五,
    周六
}

public enum DamagePropertySource
{
    无,
    自身,
    目标
}

public enum Damagevaluetype
{
    无,
    正常,
    上限,
    下限,
    耐久值,
    装甲值,
    治疗公式
}

public enum DisplayType
{
    无,
    任务完成总数量,
    普通任务完成数量,
    紧急任务完成数量,
    杀敌总数量,
    战斗最高伤害,
    战役最高伤害,
    技能释放总次数,
    SSR机师数量,
    SR机师数量,
    R机师数量,
    N机师数量,
    壁垒武器收集数量,
    片手武器收集数量,
    强袭武器收集数量,
    突击武器收集数量,
    机枪武器收集数量,
    冲锋武器收集数量,
    火炮武器收集数量,
    狙击武器收集数量,
    投射武器收集数量,
    胸甲收集数量,
    腿甲收集数量,
    挂载收集数量,
    配件收集数量,
    满级成员数量,
    满星成员数量,
    满级技能数量,
    参与战斗次数,
    胜利次数,
    失败次数,
    结交好友数量,
    公会签到次数,
    UR机师数量,
    招募总次数,
    开发总次数,
    赏金战总次数,
    远征任务的总次数,
    基地车科技树升级次数,
    基地车房间升级次数,
    装备分解总次数,
    装备强化总次数
}

public enum DistanceType
{
    无,
    前排,
    中排,
    后排
}

public enum EffectImpactCondition
{
    无,
    目标血量条件,
    自身血量条件,
    队友存在数量,
    敌人存在数量,
    处于被控制状态,
    处于减益状态,
    目标处于指定State状态,
    子弹序号,
    单位朝向,
    命中单位数量,
    BUFF层数,
    负面BUFF,
    持续攻击时间,
    触发BUFFID,
    目标拥有指定BUFF,
    自身拥有指定BUFF,
    召唤单位个数,
    指定召唤单位个数,
    释放角色ID,
    自己穿戴指定类型装备,
    BUFF层数到达指定倍数,
    目标拥有护盾,
    标记数量,
    指定stageID,
    指定角色在场,
    触发角色ID,
    目标怪物类型,
    激活专用机,
    伤害技能来源,
    目标角色阵营,
    目标阵营角色存活数量,
    是否存在BUFF,
    目标单位移动距离,
    攻击目标单位距离,
    目标是否拥有负面buff,
    自身与目标血量条件比较,
    是否受到致命伤害,
    是否是暴击伤害,
    普通攻击次数,
    目标增益buff数量,
    目标减益buff数量,
    自身增益buff数量,
    自身减益buff数量,
    伤害与目标属性比较,
    目标是指定职业,
    条件占位1,
    条件占位2,
    条件占位3,
    条件占位4
}

public enum EffectTargetType
{
    无,
    碰撞目标,
    自己,
    选择目标,
    全体敌人,
    全体队友,
    随机数量队友,
    血量最少队友,
    触发目标,
    攻击者,
    随机数量敌人,
    BOSS,
    其他友军,
    血量百分比最低队友,
    全体召唤物,
    指定属性最高队友,
    指定属性最低队友,
    损失耐久最多队友,
    指定友方ID怪物,
    指定敌方ID怪物
}

public enum EffectTriggerEvent
{
    无,
    战斗开始触发,
    受到伤害概率触发,
    造成伤害概率触发,
    命中目标概率触发,
    周期触发,
    造成暴击触发,
    受到暴击概率触发,
    闪避攻击概率触发,
    击杀单位触发,
    队友死亡触发,
    BUFF变动触发,
    血量变化触发,
    治疗目标时,
    添加BUFF触发,
    技能释放结束触发,
    技能释放结束触发_只判断主干,
    普通攻击触发,
    BUFF结束触发,
    持续攻击触发,
    跟随指定效果触发,
    跟随指定效果成功后触发,
    击中友方触发,
    受致命攻击触发,
    血量低于指定比例触发,
    召唤物造成伤害触发,
    友方单位受到攻击,
    友方BUFF结束触发,
    技能动画节点触发,
    受到攻击触发,
    自己死亡触发,
    敌方单位死亡触发,
    全单位BUFF数变动触发,
    单位动画变动触发,
    友方单位产生暴击,
    单位移动触发,
    指定次数弹药命中触发,
    连续未暴击次数触发,
    事件占位1,
    事件占位2,
    事件占位3,
    事件占位4
}

public enum EffectTriggerTypeCondition
{
    无,
    技能,
    普攻
}

public enum EffectType
{
    产出加成,
    交易折扣,
    不消耗体力
}

public enum EndlessBattleWinCondition
{
    指定场次胜利,
    累积胜利场次
}

public enum EquipSubType
{
    壁垒武器,
    片手武器,
    突击武器,
    强袭武器,
    机枪武器,
    冲锋武器,
    狙击武器,
    火炮武器,
    投射武器,
    轻型输出胸甲,
    中型输出胸甲,
    重型输出胸甲,
    中型生存胸甲,
    重型生存胸甲,
    轻型输出腿甲,
    中型输出腿甲,
    重型输出腿甲,
    中型生存腿甲,
    重型生存腿甲,
    轻型输出挂载,
    中型输出挂载,
    重型输出挂载,
    中型生存挂载,
    重型生存挂载,
    生存配件,
    输出配件,
    无,
    特殊配件
}

public enum EquipType
{
    武器,
    胸甲,
    腿甲,
    挂载,
    配件,
    无
}

public enum ErrorCode
{
    OK = 0,
    NoSuchServer = 1,
    DupLogin = 2,
    NoSuchRetailType = 3,
    InvaildActivationCode = 4,
    AccountIsFrozen = 5,
    SessionExpires = 6,
    LoginFail = 7,
    ServerMaintenance = 8,
    ServerFull = 9,
    IllegalUser = 10,
    TokenVerifyError = 11,
    ClientVerMismatch = 13,
    Unknown = 255,
    IpLimit = 256,
    AuthorizeFailed = 257,
    ServerError = 500,
    NotExists = 501,
    ParamError = 502,
    ConfigError = 503,
    DiamondNotEnough = 511,
    CoinsNotEnough = 512,
    OverTheLimit = 520,
    WidgetMaterialNotDressed = 601,
    IntensifyLevelLimit = 602,
    LastGirlNotDown = 603,
    ItemNumNotEnough = 604,
    ItemTypeError = 605,
    ItemNotFound = 606,
    StarLevelLimit = 607,
    BrekthoughLevelNotEnough = 608,
    PackageNotEnough = 609,
    NotInBattle = 610,
    BattleGroupInFighting = 611,
    StageFighting = 612,
    MissionNotOpen = 613,
    PreStageNotComplete = 614,
    PowerNotEnough = 615,
    FragmentNumNotEnough = 616,
    MissionLevelLimit = 617,
    ItemNotSell = 618,
    ItemNotUse = 619,
    MailGeted = 620,
    WidgetGroupNotActivate = 621,
    WidgetNotResolve = 622,
    TargetGirlPowerNotEnough = 623,
    RecruitQueueLimit = 624,
    BuildQueueLimit = 625,
    NotGirl = 626,
    SexInputError = 627,
    NotEquipedSamePart = 628,
    WidgetTypeError = 629,
    IllegalLength = 630,
    NickNameExists = 631,
    IllegalCharacter = 632,
    BirthdayError = 633,
    BirthdayNotModify = 634,
    NotNeedQuick = 635,
    TimeNotOver = 636,
    NotMorePlayerLevel = 637,
    InBattleGroup = 638,
    NotSkin = 639,
    NotGetAchiReward = 640,
    NotGetSevenLoginReward = 641,
    ShopItemBuyLimit = 642,
    GirlSkillLevelLimit = 643,
    WidgetLocked = 644,
    CorberoPointNotEnough = 645,
    CorberoPointRewardGeted = 646,
    AreaNotOpen = 647,
    ActivityRewardPoolNotEmpty = 648,
    NotExchangeableItem = 649,
    AllRewardGeted = 650,
    NotGetActivityDailyReward = 651,
    NotGetActivityAchiReward = 652,
    ExpeditionMissionLimit = 653,
    ExpeditionRoleNumNotEnough = 654,
    ExpeditionProfessionError = 655,
    ExpeditionMissionResponseTypeError = 656,
    ActivityNotOpen = 657,
    NotGetDailyReward = 658,
    NotGetWeeklyReward = 659,
    ExpeditionMissionAlreadyAccept = 660,
    ChapterNotOpen = 661,
    PlayerLevelLimit = 662,
    Expeditioning = 663,
    NotTitle = 664,
    ChallengeStageLimit = 665,
    GirlLevelLimit = 666,
    OrderNotFound = 667,
    TodayGetedTotalRechargeReward = 668,
    TodayGetedMonthCardReward = 669,
    MonthCardTimeout = 670,
    TicketNotEnough = 671,
    AutoDeployNotNull = 672,
    RoleStageNotOpen = 673,
    PersonalStoryDailyCountLimit = 674,
    CodeInvalid = 675,
    CodeUsed = 676,
    CodeTimeNotStart = 677,
    CodeExpire = 678,
    CodeAgainGet = 679,
    CodeGetFail = 680,
    ExpeditionMissionNotComplete = 681,
    ExpeditionMissionNotAccept = 682,
    BountyPointNotEnough = 683,
    Coolingdown = 684,
    ChanllengeCoinNotEnough = 685,
    CommonSkillItemNotEnough = 686,
    StageNotComplete = 687,
    RewardGeted = 688,
    NotExistsRookieTask = 689,
    RookieRewardNotComplete = 690,
    RookieTaskIdNotComplete = 691,
    CanNotAcceptRookieTask = 692,
    AllRookieTaskDone = 693,
    CanNotRepeatLikeShopItem = 694,
    WidgetStrengMax = 695,
    NotInActivityTime = 696,
    MaxBuyTimesLimit = 697,
    StageCompleted = 698,
    GetWidgetExchangeAwardFailed = 699,
    NoCompleted = 700,
    Received = 701,
    BattlePowerNotEnough = 702,
    BigSaleAwardFailed = 703,
    StageChallengeCountLimit = 704,
    ChallengeItemNotEnough = 705,
    PointConversionCountNotEnough = 706,
    PointConversionPointNotEnough = 707,
    PoolEmpty = 708,
    MCVLevelLimit = 709,
    MCVRoomLevelLimit = 710,
    CurStatusIsNotLevelUp = 711,
    CurStatusCanNotAction = 712,
    CannotDestroyRoom = 713,
    GirlCondNotOK = 714,
    MCVBaseCondNotOK = 715,
    MCVRoomCondNotOK = 716,
    MCVRoomOppsite = 717,
    MCVRoomDispatchLimit = 718,
    MCVRoomDonotDispatchGirl = 719,
    MCVOrderIsFull = 720,
    MCVOrderIsNotBelong2Group = 721,
    MCVRoomIsNotOrderRoom = 722,
    MCVOrderIsNotExists = 723,
    MCVCannotChangeCompleteOrder = 724,
    MCVOrderCannotGather = 725,
    MCVBaseStatusCannotLvlUp = 726,
    MCVCannotEnterLowCostStatus = 727,
    MCVLowCostHourLeak = 728,
    MCVIsNotLowCostStatus = 729,
    MCVLowCostHaveCalced = 730,
    MCVOrderIsNotProcess = 731,
    BubbleStatusCannotRandom = 732,
    BubbleRefreshNumLimit = 733,
    BubbleNotAlreadyRandom = 734,
    SlotDonotHaveBubble = 735,
    BubbleHaveRecievedAward = 736,
    RecievedTimeIsNotOK = 737,
    GirlMCVSkillNotExists = 738,
    SwitchGirlOnly2RestRoom = 739,
    MCVPreTaskCurStatusCanNotAction = 740,
    GirlIsInExpeditionCannotDispatch = 741,
    GirlIsInBattleGroupCannotDispatch = 742,
    GirlHasDispatched = 743,
    TechTreeNodeUnlock = 744,
    TechTreeNodeLevelLimit = 745,
    ItemIsNotSkillType = 746,
    GirlSkillDuplicate = 747,
    SwitchSkillIsNotChange = 748,
    GoodWillNotEnough = 749,
    BirthdayNotActive = 750,
    BirthdayNotTime = 751,
    OnlyTechRoomCanRefresh = 752,
    SourceStoreLimit = 753,
    MCVIsNotLeakSourceStatus = 754,
    GirlMCVSkillHaveLearned = 755,
    GirlMCVHighSkillHaveLearned = 756,
    HaveSignedToday = 757,
    HaveNoSignTimes = 758,
    PreEventNotCompleted = 759,
    SignedLimitMonth = 760,
    TotalCellNumNotEnough = 761,
    CriticalPointChallengeTimesLimit = 762,
    PlayTimesLimit = 763,
    CriticalPointHaveNoFreeReset = 764,
    CriticalPointHaveNoChallengeTimes = 765,
    CriticalPointJackpotCreateFailed = 766,
    NotGetCriticalPointAchiReward = 767,
    WidgetStrengNotMax = 768,
    QualityUpTimesLimit = 769,
    QualityLimit = 770,
    ModuleLevelMax = 771,
    HeresyBreakLevelLimit = 772,
    TheSameWidgt = 773,
    WidgtTypeNotSame = 774,
    HasInherited = 775,
    DailyStageMaxBuyTimesLimit = 776,
    DailyStageHaveNoChallengeTimes = 777,
    PropertyTypeLimit = 778,
    AttrPosLimit = 779,
    MultiAwardTicketLimit = 780,
    TowerLayerAndStageNotMatch = 781,
    StageAndBattleNotMatch = 782,
    PreTowerLayerNotClear = 783,
    SpringFestivalAchievementNotExist = 784,
    SpringFestivalAchievementCondLeak = 785,
    NotComebackPlayer = 786,
    CannotSweepOutUnlockStage = 787,
    TowerEnergyLeak = 788,
    SweepOutActionIsBusying = 789,
    TowerLayerConfLeak = 790,
    FinalBossCountLimit = 791,
    SweepOutNotComplete = 792,
    SweepInfoNotExists = 793,
    StageCannotSweepOut = 794,
    CurStageIsNotFinalStage = 795,
    PlayerEnergyNotEnough = 796,
    PlayerEnergyLimit = 797,
    ATConfigNotFound = 798,
    ATChallengeNotOpen = 799,
    ATCannotInitiateAssistBattle = 800,
    ATAssistBossIsOccupy = 801,
    ATAssistBossNotExist = 802,
    ATAssistBossExpire = 803,
    ATAssistBossOverdue = 804,
    ATAssistNumLimit = 805,
    ATChallengeNumIsLeak = 806,
    ATChallengeModeDescLeak = 807,
    FriendMaxCount = 808,
    FriendBlackMaxCount = 810,
    GiveFriendGiftMaxCount = 811,
    GetFriendGiftMaxCount = 812,
    FirendGiftNotGet = 813,
    CannotAssistSelf = 814,
    CannotRefreshRandomLst = 815,
    BossIsNotKilled = 816,
    DailyAlreadyGiveGift = 817,
    RecommandFriendListDown = 818,
    PlayerShield = 819,
    NotFoundFriend = 820,
    AssistEnergyLeak = 821,
    TargetFriendRequestMax = 822,
    TargetFriendMax = 823,
    NotSearchSelf = 824,
    WidgetBagExpandLimit = 825,
    HaveRecievedLoginAward = 826,
    NoCurDayAwardConf = 827,
    ChangeNameItemNotEnough = 828,
    TalentTowerNotExists = 829,
    TalentTowerTierNotExists = 830,
    TalentTowerStageBattleNotMatch = 831,
    TalentTowerIsNotOpen = 832,
    TalentTowerProfessionLimitLeak = 833,
    TalentTowerNoQuickWar = 834,
    FreeQuickWarLeak = 835,
    CostQuickWarLeak = 836,
    CannotChallengeTier = 837,
    GirlTalentUnlockNoCondition = 838,
    ChallengeTimesLeak = 839,
    SelectTowerDifficultyError = 840,
    MaxDifficultyLimit = 841,
    GirlsStatusError = 842,
    EVAPhyIsFull = 843,
    EVABuyTimesLeak = 844,
    EVAPhyLeak = 845,
    EVAChallengeTimesLeak = 846,
    EVABossIsNotOpenDay = 847,
    EVABossDifficultyLeak = 848,
    EVAAreaRepairLeak = 849,
    HaveRecievedAward = 850,
    DiamondComTimeLimit = 851,
    EVATechRoomLevelLeak = 852,
    EVAStagePhyLeak = 853,
    DonateValueLeak = 854,
    HaveRecievedShopAward = 855,
    TimesLeak = 856,
    SequenceGet = 857,
    BikiniBossTicketNotEnough = 858,
    BikiniEnergyNotEnough = 859,
    BikiniStartNotEnough = 860,
    CannotAwake = 861,
    CompletedTeachingRecruit = 862,
    AchiLvlLeak = 863,
    TickNotEnough = 864,
    CurTierStageNotOpen = 865,
    PVPEnemyCannotChallenge = 866,
    PVEBattleGroupNotExists = 867,
    PVEFreeReviveTimesLimit = 868,
    BuyAreaMissionTimesLimit = 869,
    HonorMaxLevelLimit = 870,
    HonorUnlock = 871,
    HonorPosLimit = 872,
    HonorLevelLimitForUnlock = 873,
    MedalNotEnough = 874,
    TrophyNotExists = 875,
    DailyPVPTimesLimit = 876,
    PVPEnemyExists = 877,
    StoryPointNotOpen = 878,
    CannotPassBattlePoint = 879,
    GirlWeddingLimit = 880,
    FavorGirlNotExist = 881,
    FavorGirlLevelLimit = 882,
    FavorItemNotEnough = 883,
    FavorTiliNotEnough = 884,
    FavorTiliBuyTimesLimit = 885,
    FavorLevelNotEnough = 886,
    FavorStagePassLimit = 887,
    SeasonEnemyCannotChallenge = 888,
    SeasonIsNotOpen = 889,
    HaveReceivedAward = 890,
    CannotReceivedAward = 891,
    CannotFightBack = 892,
    PVPTicketNotEnough = 893,
    NationWarNotOpen = 894,
    NationWarAlreadyRegister = 895,
    NationWarRegisterStaageLimit = 896,
    NationWarTicketsError = 897,
    NationWarTicketNotEnough = 898,
    NationWarBuyTicketsError = 899,
    NationWarHexCanNotArrive = 900,
    NationWarNotSignup = 901,
    NationWarBossIsDead = 902,
    NationWarArmyConditionFail = 903,
    NationWarReceiveHonorFail = 904,
    NationWarDispatchFail = 905,
    NationWarStopTime = 906,
    NationWarGiveUpHexFail = 907,
    NationWarInBattle = 908,
    NationWarDispatchLimit = 909,
    NationWarDispatchGirlAlreadyUsed = 910,
    NationWarrBattleGroupGirlAlreadyUsed = 911,
    NationWarArmyLimit = 912,
    NationNotPveBattle = 913,
    NationNotPvpBattle = 914,
    BattleDataIllegal = 915,
    NationWarSignUpNotOpen = 916,
    MainPrizeNotClear = 917,
    MissionNotComplete = 918,
    WidgetNotExist = 919,
    ReviveNotEnough = 920,
    BlessNotEnough = 921,
    StageNotPassed = 922,
    BBQLevelNotStart = 923,
    BikiniSeabedMaxFloor = 924,
    BattleGroupNotExists = 925,
    BigEventNotEnoughStar = 2001,
    BigEventRewardGeted = 2002,
    BigEventNotPassed = 2003,
    TiliLimit = 2004,
    TicketLimit = 2005,
    RoundLimit = 2006,
    BigEventStageTimeLimit = 2007,
    BeforeDawnOrderTimeLimit = 932,
    StarShipNoExist = 933,
    StarshipItemCostLimit = 934,
    StarShipLevelLimit = 935,
    StarPosLevelMax = 936,
    StarShipPosLevelLimit = 937,
    StarShipLevelMax = 938,
    StarShipStarLevelMax = 939,
    StarShipGirlHasDispatched = 940,
    StarShipCostLimit = 941,
    StarshipWeaponNoExist = 942,
    StarshipWeaponPosLocked = 943,
    StarshipMainWeaponLimit = 944,
    StarshipWeaponFavorLenLimit = 945,
    StarshipWeaponFavorNoExist = 946,
    StarshipPreTechTreeNotComplete = 947,
    StarshipFragmentNoExist = 948,
    StarshipWeaponStarLimit = 949,
    StarshipFetterNotExist = 950,
    StarshipFetterTaskNotExist = 951,
    StarshipFetterTaskConLimit = 952,
    StarshipFetterTaskPreConLimit = 953,
    StarshipFetterEffectConLimit = 954,
    StarshipFetterEffectAll = 955,
    StarshipSetChapterError = 956,
    StarshipExplorePhyNotEnough = 957,
    StarshipExploreEventNotExists = 958,
    StarshipExploreShipCountLimit = 959,
    StarshipExploreBuyPhyLimit = 960,
    StarshipExploreCheckPointLocked = 961,
    StarshipExploreBuyPhyNotOpen = 962,
    TotalRechargeNotOpen = 963,
    StarShipChipHasLoaded = 964,
    StarShipChipIsLocked = 965,
    StarShipChipIsLoaded = 966,
    StarshipPVPTicketNotEnough = 1501,
    LockingReportLimit = 1502,
    LockingReportNotFound = 1503,
    FormationSetError = 1504,
    StarshipPVPGuessingCoinNotEnough = 1505,
    RefreshRivalNumLimit = 1506,
    ReportAlreadLocked = 1507,
    ReportNotLocked = 1508,
    NotInGuessTime = 1509,
    E_100000 = 100000,
    E_100001 = 100001,
    E_100002 = 100002,
    E_100003 = 100003,
    E_100004 = 100004,
    E_100005 = 100005,
    E_100006 = 100006
}

public enum EVATaskType
{
    玩家等级,
    进攻类赏金完成次数,
    机师收集率,
    机师招募次数,
    部件制造次数,
    赏金值,
    防守类赏金完成次数,
    部件收集率,
    基地车等级,
    远征次数,
    天赋突破至5层,
    拥有SR机师数量,
    物资副本完成次数,
    协力副本完成次数,
    拥有SSR机师数量,
    护送类赏金完成次数
}

public enum ExploreEventQualityType
{
    普通,
    高级,
    稀有
}

public enum ExploreEventType
{
    战斗,
    对话,
    问答,
    交易,
    无
}

public enum ExploreTradeGoodsType
{
    道具,
    BUFF
}

public enum FetterTaskType
{
    获得X名羁绊机师,
    X名机师星级达到Y,
    X名机师等级达到Y,
    X名机师好感度达到Y,
    X名机师技能总等级达到Y,
    X名机师一体机总等级达到Y,
    X名机师一体机异端化总进度达到Y,
    X名机师一体机总副词条数达到Y,
    X名机师启用一体机,
    X名机师一体机品质达到Y,
    总皮肤数达到X,
    机师天赋激活总点数达到X,
    机师总UR技能等级达到X,
    X名机师品质达到Y,
    X名机师结婚
}

public enum FetterType
{
    宿命,
    挚友,
    纷争,
    战队
}

public enum Fixedevent
{
    无,
    小怪,
    精英,
    BOSS,
    宝箱,
    祝福
}

public enum Fragmentquality
{
    R,
    SR,
    SSR,
    UR
}

public enum GetLimitType
{
    无,
    赏金值,
    进攻等级,
    防守等级,
    护送等级,
    领导等级,
    全等级,
    玩家等级,
    总战斗力,
    开启时间
}

public enum GiftBagConditions
{
    无,
    佣兵团等级提升,
    首次获得特定角色,
    将特定角色提升到一定星级,
    获得特定角色
}

public enum GirlCamp
{
    Blacark,
    Paranoid,
    HHED,
    Haxel,
    Arita,
    Kegha,
    NoGenera,
    Nerv,
    WILLE,
    WIlle
}

public enum GirlGrade
{
    N,
    R,
    SR,
    SSR
}

public enum GirlGradeColorType
{
    WHITE,
    GREEN,
    BLUE,
    PURPLE,
    ORANGE,
    RED
}

public enum GirlKinds
{
    Biological,
    SpecialAbility,
    Mechanical
}

public enum GirlProfession
{
    ShortRange,
    LongRange,
    Assassin,
    Tank
}

public enum GirlQualityType
{
    N,
    R,
    SR,
    SSR,
    无,
    UR
}

public enum GoodsOpenType
{
    无,
    获得对应机师,
    EVA贡献度等级,
    机师誓约,
    EVA2贡献度等级
}

public enum GoodwillRewardType
{
    无,
    奖励道具,
    解锁技能,
    机师专属任务,
    解锁语音,
    生日祝词
}

public enum GradeColorType
{
    GREEN,
    BLUE,
    PURPLE,
    ORANGE,
    RED
}

public enum GuideType
{
    ButtonClick,
    ScreenClick,
    PlayDialoge,
    SceneChange,
    DynamicButton,
    BattleWin,
    SetActive,
    EmptyGuide,
    PlayBattleDialoge
}

public enum HeresyType
{
    增加属性,
    次要属性解锁,
    品质提升
}

public enum HistoricalRecord
{
    无,
    累计登录天数,
    满星角色总数量,
    皮肤总数量,
    专用机收集度,
    基地车科技树升级次数,
    发起远征任务的总次数,
    赏金战斗总次数,
    角色总数,
    基地车房间升级次数
}

public enum Hurttype
{
    无,
    实弹,
    能量,
    光束,
    贯穿
}

public enum Icontype
{
    核心点,
    普通点
}

public enum InjuryAddEffectType
{
    无,
    吸血,
    击退,
    添加Buff
}

public enum InjuryTargetType
{
    无,
    碰撞目标
}

public enum IntType
{
    Int,
    Ceil,
    Round0,
    Round4
}

public enum ItemClassify
{
    无,
    材料,
    消耗品,
    其他
}

public enum ItemQualityType
{
    N,
    R,
    SR,
    SSR,
    UR
}

public enum ItemType
{
    货币类型,
    机师经验道具,
    技能经验道具,
    货币道具,
    机师道具,
    机师碎片,
    随机宝箱,
    招募道具,
    加速道具,
    好感度礼物,
    招募图纸,
    机师皮肤,
    升星道具,
    技能升级道具,
    活动道具,
    部件预览道具,
    测试道具,
    列传开发道具,
    任务刷新道具,
    基地车情报道具,
    基地车回收道具,
    基地车道具,
    基地车机师技能书,
    圣诞节活动,
    异端化突破,
    属性洗练,
    春节活动,
    能力测验,
    称号道具,
    定制礼包,
    可选礼包,
    月卡道具,
    黑色方舟经验,
    珍贵,
    海报,
    手办,
    其他,
    副炮道具,
    星舰属性展示道具,
    回想道具
}

public enum JackpotID
{
    钻石,
    黄金,
    白银
}

public enum KindnessGift
{
    无,
    宝石,
    书籍,
    武器,
    服饰,
    食物,
    玩具,
    通用
}

public enum LimitConditionType
{
    常驻,
    道具触发
}

public enum LinkPage
{
    无,
    皮肤特惠,
    累计充值,
    招募,
    开发,
    活动界面,
    月卡季卡,
    七日登录,
    伊芙琳剧情,
    泳装活动,
    联动活动,
    万圣狂欢,
    临界点,
    圣诞节,
    春节活动,
    礼包商城,
    月面大暴走,
    EVA联动,
    等不到的黎明,
    昨日头条,
    给糖也捣蛋,
    盛夏邀约,
    荣耀室,
    玛格丽特剧情,
    情人节japan2021,
    轩辕剑联动,
    攻壳机动队,
    樱花大战,
    樱花祭,
    元旦活动2022,
    彼方之风,
    空镜,
    怪诞艺术家,
    小心陷阱,
    幻想朋友,
    勇士,
    四日登录,
    出战,
    远征,
    莎伦的一天,
    春节活动2023,
    红线,
    占位11,
    占位12,
    占位13,
    占位14,
    占位15,
    占位16,
    占位17,
    占位18,
    占位19,
    占位20,
    有偿招募,
    跳转web链接
}

public enum LocationType
{
    无,
    战术,
    阵线,
    支援,
    奇袭
}

public enum ManualSelectRangeType
{
    无,
    单体,
    群体
}

public enum ManualSelectType
{
    无,
    选择敌人,
    选择坐标
}

public enum MapFailCondition
{
    无,
    被到达终点,
    全部被占领,
    被占领任意,
    己方全部被占领,
    全部死亡,
    AI死亡
}

public enum MapType
{
    无,
    目标击破,
    全体歼灭,
    据点攻占,
    目标追击,
    目标搜索,
    潜入战,
    竞速战,
    据点防卫,
    目标拦截,
    生存,
    目标护送,
    机关解谜,
    攻防一体,
    全部据点攻占,
    全部据点防卫
}

public enum MapWinCondition
{
    无,
    到达终点,
    全部占领,
    占领任意,
    占领全部敌方,
    击败目标,
    击败全部
}

public enum MCVProductionType
{
    全部产品,
    基础素材,
    建造材料,
    支援内容
}

// TODO: Namespace collision
/*public enum MissionType
{
        进攻,
        防守,
        护送,
        紧急,
        晋级,
        引导任务
}*/

public enum Modetype
{
    无,
    伤害,
    治疗
}

public enum MoneyType
{
    无,
    通用碎片,
    钻石,
    金币,
    贸易券,
    通用技能道具,
    挑战币,
    泳装1期代币,
    泳装2期代币,
    泳装3期代币,
    泳装4期代币,
    泳装特殊代币,
    周常副本挑战币,
    部件兑换1,
    部件兑换2,
    部件兑换3,
    部件兑换4,
    万圣节特殊1代币,
    万圣节特殊2代币,
    德洛丽丝体力,
    德洛丽丝代币,
    德洛丽丝奖池黄金券,
    德洛丽丝奖池钻石券,
    春节货币,
    能力测验代币,
    友情点数,
    周常二期挑战币,
    初级战斗序列,
    中级战斗序列,
    高级战斗序列,
    特级战斗序列,
    EVA活动代币,
    觉醒兑换代币,
    顶级战斗序列,
    晶石,
    有偿晶石,
    无偿晶石,
    UR专用机兑换代币,
    荣耀室活动代币,
    国战前夕兑换代币,
    荣耀室特殊代币1,
    荣耀室特殊代币2,
    荣耀室特殊代币3,
    荣耀室特殊代币4,
    国战前夕兑换代币2,
    国战前夕兑换代币3,
    国战前夕兑换代币4,
    EVA2活动代币,
    荣耀室特殊代币5,
    荣耀室特殊代币6,
    荣耀室特殊代币7,
    荣耀室特殊代币8,
    荣耀室特殊代币9,
    荣耀室特殊代币10,
    荣耀室特殊代币11,
    竞技场商店代币,
    荣耀室特殊代币12,
    荣耀室特殊代币13,
    荣耀室特殊代币14,
    荣耀室特殊代币15,
    荣耀室特殊代币16,
    荣耀室特殊代币17,
    荣耀室特殊代币18,
    荣耀室特殊代币19,
    荣耀室特殊代币20,
    荣耀室特殊代币21,
    荣耀室特殊代币22,
    荣耀室特殊代币23,
    荣耀室特殊代币24,
    荣耀室特殊代币25,
    大活动通用代币,
    大活动通用代币2,
    荣耀室特殊代币26,
    荣耀室特殊代币27,
    荣耀室特殊代币28,
    荣耀室特殊代币29,
    荣耀室特殊代币30,
    荣耀室特殊代币31,
    荣耀室特殊代币32,
    荣耀室特殊代币33,
    荣耀室特殊代币34,
    荣耀室特殊代币35,
    荣耀室特殊代币36,
    荣耀室特殊代币37,
    荣耀室特殊代币38,
    荣耀室特殊代币39,
    荣耀室特殊代币40,
    大活动2022春节通用代币,
    UR专用机兑换代币2,
    大活动怪诞艺术家通用代币,
    探索商店代币,
    回收核心代币,
    回归UR专用机兑换代币,
    常驻开发池商店代币,
    荣耀室特殊代币41,
    荣耀室特殊代币42,
    荣耀室特殊代币43,
    荣耀室特殊代币44,
    荣耀室特殊代币45,
    荣耀室特殊代币46,
    荣耀室特殊代币47,
    荣耀室特殊代币48,
    荣耀室特殊代币49,
    荣耀室特殊代币50,
    荣耀室特殊代币51,
    荣耀室特殊代币52,
    荣耀室特殊代币53,
    荣耀室特殊代币54,
    荣耀室特殊代币55,
    荣耀室特殊代币56,
    荣耀室特殊代币57,
    荣耀室特殊代币58,
    荣耀室特殊代币59,
    荣耀室特殊代币60,
    荣耀室特殊代币61,
    荣耀室特殊代币62,
    荣耀室特殊代币63,
    荣耀室特殊代币64,
    荣耀室特殊代币65,
    荣耀室特殊代币66,
    荣耀室特殊代币67,
    荣耀室特殊代币68,
    荣耀室特殊代币69,
    荣耀室特殊代币70,
    协同作战代币,
    部件兑换5,
    部件兑换6,
    常驻一体机货币,
    有偿卡池商店代币,
    部件兑换7,
    基地车竞技场代币C,
    基地车竞技场代币D
}

public enum MonsterType
{
    无,
    炮灰怪物,
    普通怪物,
    精英怪物,
    BOSS,
    特殊怪物,
    召唤装饰,
    支援基地车
}

public enum NationalWarGridType
{
    无,
    阻挡物,
    小怪据点,
    BOSS总据点,
    BOSS普通据点,
    大本营,
    神庙塔
}

public enum NatureType
{
    None,
    Physical,
    Energy,
    Electricity
}

public enum NavBuffType
{
    麻痹,
    加速,
    属性,
    隐身,
    减速,
    持续掉血
}

public enum NCVUnlockMissionType
{
    无,
    重要任务
}

public enum OpenArea
{
    无,
    珍贵,
    海报,
    手办,
    其他
}

public enum OpenType
{
    Stage,
    Level,
    Tower
}

public enum PlayerInfoSubType
{
    无,
    任务相关,
    收集相关,
    培养相关,
    竞技场,
    好友,
    公会,
    次数统计
}

public enum PlayerInfoType
{
    无,
    探索生涯,
    赏金生涯,
    社交生涯,
    服务器统计
}

public enum PriceType
{
    无,
    基准价格,
    固定价格
}

public enum ProfessionType
{
    守护,
    格斗,
    射击,
    爆破,
    狙击,
    轰炸
}

public enum PropertyType
{
    无,
    随机属性,
    固定属性,
    随机属性4条副属性
}

public enum QueueType
{
    招募队列,
    建造队列
}

public enum RandomDropType
{
    无,
    重复抽取,
    非重复抽取
}

public enum Ranking
{
    zhanli,
    moni,
    gonghui,
    jingji,
    shijie,
    zhuxian,
    jingying,
    chaoxue,
    huodong,
    shouji
}

public enum RechargeType
{
    Normal,
    Month,
    Season,
    Double,
    IAP,
    GB,
    GB_ZiXuan,
    SmallMonth
}

public enum RecoveryAddEffectType
{
    无,
    清除负面状态,
    添加Buff
}

public enum RecoveryTargeType
{
    无,
    自己,
    全体队友,
    随机一名队友,
    耐久最低队友
}

public enum RecruitActivityType
{
    无,
    十连抽,
    限时开发,
    无保底十连抽,
    免费十连抽,
    UR十连抽,
    SSR保底十连抽,
    额外付费单抽,
    武器十连抽,
    武器十连抽限时,
    有偿十连抽
}

public enum RecruitSubType
{
    机师招募,
    部件建造,
    指定建造,
    限定部件建造,
    列传建造,
    限时部件建造
}

public enum RecruitType
{
    机师招募,
    机甲建造
}

public enum ReloadType
{
    无,
    更换弹匣,
    自动恢复
}

public enum Repeat
{
    是,
    否,
    无
}

public enum RoleStageType
{
    复刷关
}

public enum RookieTaskType
{
    无,
    装备开发次数,
    将一定数量的机师提升到一定等级,
    机师招募次数,
    赏金值,
    攻击任务等级,
    远征成功次数,
    装备分解次数,
    通关关卡,
    机师技能升级次数,
    将一定数量的机师提升到一定星级,
    强化部件次数,
    将一定数量的部件强化到一定等级,
    拥有R品质的机师数量,
    登陆次数,
    图鉴机师收集数,
    快速招募次数,
    快速制造次数,
    通关角色列传的探索关卡,
    佣兵团等级,
    通关活动关卡,
    SR部件数量,
    赏金任务完成次数,
    日常任务完成次数,
    拥有SR品质的机师数量,
    进行十连抽的次数,
    紧急任务完成次数,
    远征大成功次数,
    收集套装,
    特殊装备开发次数,
    基地车科研升级指定次数,
    基地车任意房间升级指定次数,
    基地车指定分类房间到达指定级别,
    将一定数量的机师好感度升级至指定等级,
    解锁基地车所有房间,
    进攻防守护送到达指定级别,
    前几队战力到达指定分数,
    收集指定ID一体机套装,
    通关指定ID个人副本一定次数,
    通关指定等级个人副本一定次数,
    通关指定类型关卡一定次数,
    完成远征任务指定次数,
    完成指定数量每日委托任务,
    在指定地区完成一定数量赏金任务
}

public enum SakuraWarsTargetType
{
    小怪,
    BOSS,
    宝箱,
    友军
}

public enum SameBuffType
{
    无效,
    重置,
    叠加
}

public enum SameStateType
{
    共存,
    排斥
}

public enum SceneFunctionType
{
    无,
    激活区域,
    激活区块,
    激活赏金任务组,
    激活区块并激活赏金任务组,
    激活区域并激活赏金任务组,
    激活区块并激活日常任务,
    副本出现,
    关联副本,
    激活区域并激活赏金任务组并副本出现,
    激活赏金任务组并副本出现,
    激活区域并激活区块并激活赏金任务组,
    激活区块并激活赏金任务组并激活日常任务,
    激活区域并激活区块
}

public enum SceneSubType
{
    无,
    进攻,
    防守,
    护送,
    紧急,
    角色列传计数关卡,
    单挑挑战,
    随机挑战,
    头目挑战,
    武器突破,
    胸甲突破,
    腿甲突破,
    挂载突破,
    芯片突破,
    全副武装,
    多队接力,
    泳装BOSS普通,
    泳装BOSS困难,
    泳装BOSS挑战,
    海底两万里,
    暴击特训,
    命中特训,
    闪避特训
}

public enum SceneType
{
    无,
    剧情任务,
    解锁任务,
    普通赏金,
    简单赏金,
    困难赏金,
    紧急赏金,
    晋级任务,
    日常任务,
    角色列传,
    引导任务,
    克尔贝洛之影,
    区域解锁任务,
    测试关卡,
    个人副本,
    夏日回忆,
    周常副本,
    B站联动,
    基地车前置任务,
    临界点,
    曜日副本,
    春节2019,
    能力测验,
    天赋爬塔,
    月面的大暴走,
    EVA限时BOSS,
    EVA关卡,
    等不到的黎明,
    给糖也捣蛋,
    国战前夕PVE,
    国战前夕PVP,
    国战前夕剧情,
    情人节japan2021,
    竞技场PVP,
    国战小怪,
    国战BOSS,
    国战PVP,
    轩辕剑联动,
    泳装活动关卡,
    海底两万里,
    攻壳联动,
    樱花联动小怪,
    樱花联动BOSS,
    暴风雨之夜,
    元旦2022小怪,
    元旦2022BOSS,
    元旦活动BOSS,
    特训BOSS,
    彼方之风小怪,
    彼方之风BOSS,
    彼方之风小游戏,
    空镜,
    怪诞艺术家小怪,
    怪诞艺术家BOSS,
    小心陷阱,
    幻想朋友,
    勇士,
    木桩测试,
    莎伦的一天,
    基地车爬塔关,
    春节2023小怪,
    春节2023BOSS,
    红线,
    占位12,
    占位13,
    占位14,
    占位15,
    占位16,
    占位17,
    占位18,
    占位19,
    占位20
}

public enum SeriesLoginType
{
    无,
    回归奖励,
    七日登陆,
    预约登陆
}

public enum ShipBuffEffectType
{
    无,
    增益,
    减益,
    护盾,
    伤害
}

public enum ShipBuffPropertySource
{
    无,
    己方星舰,
    敌方星舰
}

public enum ShipGirlScoreSouce
{
    机师等级,
    机师星级,
    机师技能等级,
    机师UR技能等级,
    机师觉醒品质,
    机师天赋,
    机师誓约,
    机师部件等级,
    机师部件异端化品质,
    机师部件精制,
    机师部件芯片,
    机师一体机激活
}

public enum ShipQualityType
{
    无,
    SR,
    SSR
}

public enum ShipSameBuffType
{
    覆盖,
    叠加,
    无效
}

public enum ShipStageType
{
    普通事件战斗关卡,
    特殊事件战斗关卡,
    爬塔关卡,
    PVP竞猜关卡,
    PVP机器人关卡,
    PVP对战场景
}

public enum ShipWeaponType
{
    无,
    实弹,
    贯穿,
    光束,
    能量
}

public enum ShopOpenType
{
    无,
    佣兵团等级,
    通关特定关卡
}

public enum ShopSubtagType
{
    无,
    新手礼包,
    回归礼包,
    定制礼包,
    限时礼包,
    日礼包,
    周礼包,
    月礼包,
    弹出礼包,
    EVA一期礼包,
    EVA二期礼包
}

// TODO: Namespace collision
/*public enum ShopType
{
        全部,
        近程,
        中程,
        远程,
        轻型,
        中型,
        重型
}*/

public enum SkillCostType
{
    None,
    Boost,
    Energy
}

public enum SkillRangeType
{
    无,
    自己,
    全屏范围,
    自身圆周范围,
    自身圆锥范围,
    前方圆周范围,
    随机圆周范围,
    直线范围
}

public enum SkillRepeatType
{
    无,
    效果重复,
    重新开始
}

public enum SkillSelectConditionType
{
    无,
    当前耐久比例最低,
    死亡,
    身上挂载有负面状态,
    处于死亡状态,
    身上存在特定状态
}

public enum SkillSelectType
{
    无,
    手动选择目标,
    自动选择目标
}

public enum SkillSubType
{
    射击技能,
    召唤技能,
    伤害技能,
    治疗技能,
    辅助技能,
    控制技能,
    被动附加技能,
    光环技能
}

public enum SkillTargetType
{
    无,
    敌方目标,
    友方目标
}

public enum SkillTriggerType
{
    无,
    战斗开始触发,
    受到伤害触发,
    攻击暴击触发,
    队友死亡触发,
    时间间隔触发,
    战斗结束且当前耐久低于一定比例,
    自己死亡触发,
    主动技能触发
}

public enum SkillType
{
    无,
    主动触发技能,
    被动触发技能,
    面板触发技能
}

public enum SkillType1
{
    主动触发技能,
    被动触发技能,
    被动附加技能
}

public enum SkinShopItemType
{
    无,
    开服纪念,
    夏日回忆
}

public enum SpecialContditionType
{
    无,
    武器子类型,
    量级限定
}

public enum SpringFestivalAchievement
{
    击杀成就,
    积分成就
}

public enum SpringFestivalActivityType
{
    击杀,
    积分,
    最终BOSS
}

public enum SpringFestivalAwardShowType
{
    装备奖励,
    物品奖励
}

public enum SpringFestivalItemLevel
{
    SS,
    S,
    A,
    B,
    C,
    D
}

public enum SpringFestivalRankAwardType
{
    积分排行奖励,
    击杀排行奖励
}

public enum SpringFestivalTierStageType
{
    普通,
    BOSS,
    最终BOSS
}

public enum SpringFestivalTierType
{
    主线,
    支线
}

public enum StarRequestType
{
    无,
    战斗胜利,
    死亡数量,
    时间限制,
    最低耐久,
    携带机师,
    携带职业
}

public enum StarshipEffectImpactCondition
{
    无,
    目标血量条件,
    目标buff判定,
    自身buff判定,
    距离判定,
    命中目标概率触发,
    添加buff概率,
    自身所处位置,
    相距距离,
    跟随攻击后判定触发
}

public enum StarshipEffectTriggerEvent
{
    无,
    释放触发,
    受击触发,
    攻击触发,
    跟随指定效果触发后触发,
    目标buff判定触发,
    回合触发,
    全场生效
}

public enum StarshipMoveAction
{
    前进,
    后退,
    维持
}

public enum StarshipSkillTriggerrtakeeffect
{
    无,
    额外触发技能,
    添加buff,
    远程递增,
    近战递增,
    初始位置,
    精准值转化武器性能,
    射程变化,
    远程暴击率递增
}

public enum Starshiptarget
{
    无,
    自身,
    我方船,
    我方主炮,
    我方副炮,
    我方普攻,
    敌方船,
    敌方主炮,
    敌方副炮,
    敌方普攻,
    我方主动炮,
    敌方主动炮,
    攻击者,
    我方被动炮,
    敌方被动炮
}

public enum StuffType
{
    道具,
    部件,
    副炮,
    芯片
}

public enum SuitType
{
    无,
    普通套装,
    专属套装
}

public enum TaskType
{
    通过关卡次数,
    通过个人副本次数,
    完成每日任务次数,
    完成每周委托次数,
    完成关卡内杀敌数,
    完成远征次数,
    完成指定区域远征次数,
    完成招募次数,
    完成开发次数,
    完成拆解次数,
    完成异端化次数,
    收集指定id道具数量,
    收集指定id机师,
    收集指定id套装
}

public enum TerrainType
{
    无,
    森林,
    平原,
    海面,
    雪原
}

public enum TitleMold
{
    无,
    角色,
    赏金称号,
    道具称号
}

public enum TitleTask
{
    无,
    拥有指定数量的机师,
    拥有一定品质的机师数量,
    赏金值达到指定数值,
    使用道具
}

public enum TitleType
{
    无,
    赏金称号,
    道具称号
}

public enum TowerTaskConditionType
{
    探索进行X次,
    协同作战进行机娘战斗X次,
    协同作战进行基地车战斗X次,
    协同作战通过机娘战斗X次,
    协同作战破坏基地车X次,
    协同作战通关X次,
    升级战略回想X次,
    基地车改造X次,
    完成X次日常任务,
    获得X个Y等级战略回想,
    完成X次周常任务,
    协同作战通关X基地车战斗难度Y,
    协同作战不进行机娘战斗的情况下破坏Y难度下的X基地车,
    探索通过Y关,
    探索3星通过Y关,
    探索一回合通过Y关,
    探索交易进行X次,
    探索战斗进行X次,
    探索问答进行X次,
    探索剧情进行X次,
    获得X个Y星级基地车,
    不灭要塞达到Y星,
    夜枭达到Y星,
    瓦尔基丽娅达到Y星,
    黑色方舟到Y星
}

public enum TrunkSkillHaveEffectType
{
    无,
    武器子类型
}

public enum TrunkSkillType
{
    无,
    主动技能,
    被动技能,
    面板技能
}

public enum uffTriggerTargetType
{
    无,
    攻击者,
    Buff拥有者,
    Buff挂载者,
    己方全体,
    敌方全体
}

public enum UnlockCondition
{
    无,
    赏金值
}

public enum Unlocktype
{
    解锁副武器槽,
    道具奖励,
    增加Cost
}

public enum UsedGetType
{
    无,
    跳转机师界面,
    获得道具,
    获得机师,
    掉落物品,
    激活机师皮肤,
    获得佣兵团经验,
    获得进攻经验,
    获得防守经验,
    获得护送经验,
    获得领导经验,
    道具预览,
    增加好感度,
    激活机师皮肤和BG,
    激活BG,
    随机属性部件,
    好感度,
    获得爬塔体力,
    能力测验体力恢复,
    获得称号,
    EVA通用,
    选择定制礼包,
    选择可选礼包,
    激活月卡,
    获得方舟经验,
    荣耀室模型资源,
    获得月卡,
    获得红蓝工厂经验,
    获得副炮,
    获得探索体力点,
    商业活动,
    自动使用,
    获得回想
}

public enum ValueRandomType
{
    无,
    随机范围,
    固定范围
}

public enum ValueType
{
    无,
    整数,
    百分比
}

public enum ValueTypes
{
    Int,
    Random
}

public enum VicePropertyType
{
    无,
    主要,
    次要,
    新增次要
}

public enum WeaponQuality
{
    无,
    R,
    SR,
    SSR,
    UR
}

public enum Weapontype
{
    无,
    主动,
    被动,
    套装
}

public enum WeeklyMissionType
{
    无,
    完成一定次数特定类型的随机任务,
    完成一定次数的赏金任务,
    完成一定次数的紧急任务,
    完成一定次数的副本任务,
    完成一定次数的日常任务,
    招募一定次数,
    开发一定次数,
    远征一定次数,
    强化部件一定次数,
    完成个人剧情关卡一定次数,
    完成异端化关卡一定次数,
    基地车领取任意房间资源一定次数,
    完成协力本多次,
    完成天赋本多次
}

public enum WeightSeries
{
    精英轻型,
    骑士中型,
    主教重型,
    领主超重型,
    教皇巨作型,
    君王超弩型,
    四级装甲轻型,
    三级装甲中型,
    二级装甲重型,
    一级装甲超重型,
    零级装甲巨作型,
    特技装甲超弩型,
    水流轻型,
    沼泽中型,
    风暴重型,
    沙漠超重型,
    极夜巨作型,
    魔女超弩型,
    轻型,
    中型,
    重型,
    超重型,
    巨作型,
    超弩型
}

public enum WeightType
{
    无,
    轻,
    中,
    重
}

public enum WholeLifeDailyMissionType
{
    无,
    通关赏金关卡次数,
    完成赏金内击杀敌人数量,
    完成机师招募,
    完成部件研发,
    完成远征指定次数,
    通关关卡获得一定数量道具,
    完成所有委托任务
}

public enum WidgetCamp
{
    无,
    Normal,
    Blacark,
    Paranoid,
    HHED,
    Haxel,
    Arita,
    Kegha,
    NoGenera,
    Nerv,
    WILLE,
    WIlle
}

public enum WidgetLevelGetType
{
    无,
    随机等级,
    固定等级,
    配置等级
}

public enum WidgetLevelType
{
    无,
    配置等级,
    随机等级,
    固定等级
}

public enum WidgetQualityGetType
{
    无,
    随机品质,
    固定品质
}

public enum WidgetQualityType
{
    N,
    R,
    SR,
    SSR,
    UR
}

public enum WidgetSeries
{
    反抗者,
    AX试作型,
    RN试验型,
    长牙狮,
    月光,
    冰鸟,
    强盗团,
    宇宙人,
    和平使者,
    沙漠切割者,
    物理学,
    绿蟹,
    狂躁之王,
    壳之守卫,
    苍鹰,
    虎鲨,
    锤头鲨,
    先驱者,
    审判者,
    惩罚者,
    镇压者,
    暗夜,
    沙漠风暴,
    怪雨,
    夏日回忆,
    源代码,
    圣诞套2019,
    邮差套2019,
    快乐套2019
}
