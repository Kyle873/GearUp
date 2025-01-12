using System.Text.Json.Serialization;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace GearUp.GameServer.Models;

public class VersionRsp
{
    [JsonPropertyName("ABAddr")]
    public string AbAddr { get; set; }

    [JsonPropertyName("ABAddr2")]
    public string AbAddr2 { get; set; }

    [JsonPropertyName("ABAddr3")]
    public string AbAddr3 { get; set; }

    [JsonPropertyName("CheckResource")]
    public int CheckResource { get; set; }

    [JsonPropertyName("ClientVer")]
    public int ClientVer { get; set; }

    [JsonPropertyName("ClientVer2")]
    public int ClientVer2 { get; set; }

    [JsonPropertyName("ResourceDownAddr")]
    public string ResourceDownAddr { get; set; }

    [JsonPropertyName("ResourceVer")]
    public int ResourceVer { get; set; }

    [JsonPropertyName("ResourceVer2")]
    public int ResourceVer2 { get; set; }

    [JsonPropertyName("code")]
    public int Code { get; set; }
}

public class ServerListRsp
{
    [JsonPropertyName("antid")]
    public string Antid { get; set; }

    [JsonPropertyName("authtoken")]
    public string Authtoken { get; set; }

    [JsonPropertyName("code")]
    public int Code { get; set; }

    [JsonPropertyName("last_zone")]
    public int LastZone { get; set; }

    [JsonPropertyName("roles")]
    public string Roles { get; set; }

    [JsonPropertyName("state")]
    public int State { get; set; }

    [JsonPropertyName("zones")]
    public string Zones { get; set; }

    public class ServerData
    {
        public string Serialize() => $"{Id},{Name},{Recommend},{State},{ShowState},{Sort}";

        public int Id { get; set; }
        public string Name { get; set; }
        public int Recommend { get; set; }
        public int State { get; set; }
        public int ShowState { get; set; }
        public int Sort { get; set; }
    }
}

public class PlayRsp
{
    [JsonPropertyName("chatdelay")]
    public int Chatdelay { get; set; }

    [JsonPropertyName("code")]
    public int Code { get; set; }

    [JsonPropertyName("gs")]
    public List<string> Gs { get; set; }

    [JsonPropertyName("notice_ver")]
    public int NoticeVer { get; set; }

    [JsonPropertyName("talk")]
    public List<string> Talk { get; set; }

    [JsonPropertyName("timeout")]
    public int Timeout { get; set; }

    [JsonPropertyName("token")]
    public string Token { get; set; }

    [JsonPropertyName("uid")]
    public string Uid { get; set; }
}

public class PlatRsp
{
    [JsonPropertyName("code")]
    public int Code { get; set; }

    [JsonPropertyName("web")]
    public List<string> Web { get; set; }
}

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
