using System.Collections.Generic;

namespace GearUp.Common.Database
{
    public class SDKData
    {
        public Dictionary<string, SDKUser> SDKUsers { get; set; } = [];

        public class SDKUser
        {
            public required string UserToken { get; set; }
        }
    }
}
