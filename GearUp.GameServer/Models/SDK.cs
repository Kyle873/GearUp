using System.Text.Json.Serialization;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace GearUp.GameServer.Models;

public class SdkReqeust
{
    [JsonPropertyName("viewer_id")]
    public string ViewerId { get; set; }

    [JsonPropertyName("access_token")]
    public string AccessToken { get; set; }

    [JsonPropertyName("command")]
    public string Command { get; set; }

    [JsonPropertyName("onetime_token")]
    public string OnetimeToken { get; set; }

    [JsonPropertyName("sdk_version")]
    public string SdkVersion { get; set; }
}

public class SdkResponse
{
    [JsonPropertyName("result_code")]
    public int ResultCode { get; set; }

    [JsonPropertyName("onetime_token")]
    public string OnetimeToken { get; set; }

    [JsonPropertyName("install_status")]
    public string InstallStatus { get; set; }

    [JsonPropertyName("accept_time")]
    public long AcceptTime { get; set; }
}

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
