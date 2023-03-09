using System.Runtime.Serialization;

namespace Moryx.Factory
{
    [DataContract]
    public class Position
    {
        [DataMember]
        public int PositionX { get; set; }

        [DataMember]
        public int PositionY { get; set; }
    }
}