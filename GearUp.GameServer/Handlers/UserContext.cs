using GearUp.Common.Database;

namespace GearUp.GameServer.Handlers
{
    public class UserContext
    {
        public required DataStore DataStore { get; set; }
        public required ILogger Logger { get; set; }
    }
}
