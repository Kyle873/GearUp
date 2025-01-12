using ProtoBuf;
using System.IO;

namespace GearUp.Common.Protocol
{
    public static class ProtocolExtensions
    {
        public static T Deserialize<T>(this Stream stream) where T : IProtocol
        {
            return Serializer.Deserialize<T>(stream);
        }

        public static void Serialize<T>(this T proto, Stream dest) where T : IProtocol
        {
            Serializer.Serialize(dest, proto);
        }
    }
}
