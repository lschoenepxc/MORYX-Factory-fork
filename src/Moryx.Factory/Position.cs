using System.Runtime.Serialization;

namespace Moryx.Simulation.Resources
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