using GearUp.Common.Protocol;
using ProtoBuf.Meta;
using System.IO.Compression;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace GearUp.CaptureReader
{
    internal class CaptureReader
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
                throw new ArgumentException("Needs .json capture file as input!");
            if (!File.Exists(args[0]))
                throw new ArgumentException("Capture file doesn't exists!");

            var jsonOptions = new JsonSerializerOptions()
            {
                Converters =
                {
                    new JsonStringEnumConverter()
                },
                WriteIndented = true
            };

            var capture = JsonSerializer.Deserialize<List<CaptureEntry>>(File.ReadAllText(args[0]))!;
            Console.WriteLine($"Found {capture.Count} entries in the capture");

            var entries = new List<ParsedEntry>();
            foreach (var entry in capture)
            {
                var parsedEntry = new ParsedEntry();
                if (entry.Request is not null)
                {
                    using var reqMs = new MemoryStream(Convert.FromBase64String(entry.Request));
                    parsedEntry.Request = reqMs.Deserialize<RequestOperation>();
                }
                if (entry.Response is not null)
                {
                    using var rspMs = new MemoryStream(Convert.FromBase64String(entry.Response));
                    var rspPack = rspMs.Deserialize<ResponsePack>();
                    using var rspOpMs = new MemoryStream();
                    if (!rspPack.IsGZip)
                    {
                        rspOpMs.Write(rspPack.Data);
                    }
                    else
                    {
                        using var compressedMs = new MemoryStream(rspPack.Data);
                        using var gzStream = new GZipStream(compressedMs, CompressionMode.Decompress);
                        gzStream.CopyTo(rspOpMs);
                    }

                    rspOpMs.Position = 0;

                    parsedEntry.Response = rspOpMs.Deserialize<ResponseOperation>();

                    foreach (var ret in (parsedEntry.Response as ResponseOperation)!.ReturnCache)
                    {
                        if (Assembly.GetAssembly(typeof(DataTypes))!.GetType($"GearUp.Common.Protocol.{ret.Key}") is Type protoType)
                        {
                            try
                            {
                                parsedEntry.ParsedResponseDatas[ret.Key] = JsonSerializer.SerializeToDocument(ret.Value.Select(x => Convert.ChangeType(x, protoType)), jsonOptions);
                                // Console.WriteLine(JsonSerializer.Serialize(ret.Value.Select(x => Convert.ChangeType(x, protoType)), jsonOptions));
                                // parsedEntry.Response.ReturnCache[ret.Key] = new HashSet<ProtoBase>(new List<ProtoBase> { (ProtoBase)Convert.ChangeType(ret.Value.First(), protoType) });
                            }
                            catch (Exception ex)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"Error casting {ret.Key} to {protoType}, {ex}");
                                Console.ResetColor();
                            }
                        }
                    }
                    parsedEntry.Response.ReturnCache = null;
                    parsedEntry.Response.ReturnCacheBytes = null;
                }

                entries.Add(parsedEntry);
            }
            Console.WriteLine(JsonSerializer.Serialize(entries, jsonOptions));
        }

        private class ParsedEntry
        {
            public RequestOperation? Request { get; set; }
            public dynamic? Response { get; set; }
            public Dictionary<DataTypes, JsonDocument> ParsedResponseDatas { get; set; } = [];
        }

        private class CaptureEntry
        {
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("request")]
            public string? Request { get; set; }

            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("response")]
            public string? Response { get; set; }
        }
    }
}
