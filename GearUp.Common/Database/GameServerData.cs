using GearUp.Common.Protocol;
using System.Collections.Generic;

namespace GearUp.Common.Database
{
    public class GameServerData
    {
        /// <summary>
        /// String key uniquely is <see cref="SDKData.SDKUser.UserToken"/> 
        /// instead of some sort of "primary key"
        /// </summary>
        public Dictionary<string, ProtoPlayer> Players { get; set; } = [];
    }
}
