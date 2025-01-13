using System;
using System.IO;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace GearUp.Common.Database
{
    public class DataStore : IDisposable
    {
        public GameServerData GameServer { get; set; } = new();

        private readonly ILogger logger;
        private readonly FileStream file;

        public DataStore(ILogger<DataStore> _logger, string filePath)
        {
            logger = _logger;

            var dir = Path.GetDirectoryName(filePath);
            if (dir is not null && !Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            readFile:
            file = File.Open(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            if (file.Length == 0)
            {
                Save();
                file.Dispose();
                goto readFile;
            }

            var jsonElement = JsonSerializer.Deserialize<JsonElement>(file);
            JsonExt.PopulateObject(this, jsonElement, JsonSerializerOptions.Default);
            logger.LogInformation("{Store} loaded", nameof(DataStore));
        }

        public void Save()
        {
            file.Position = 0;
            JsonSerializer.Serialize(file, this);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            Save();
            file.Dispose();

            logger.LogInformation("{Store} closed", nameof(DataStore));
            GC.ReRegisterForFinalize(this);
        }
    }
}
