using System.Collections.Generic;
using Moryx.AbstractionLayer.Resources;

namespace Moryx.Factory
{
    public interface ITransportPath : IResource
    {
        ILocation Origin { get; }

        ILocation Destination { get; }

        List<Position> WayPoints { get; set; }
    }
}