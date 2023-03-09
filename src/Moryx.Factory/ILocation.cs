using System.Collections.Generic;
using System.Collections.Specialized;
using Moryx.AbstractionLayer.Resources;

namespace Moryx.Factory
{
    public interface ILocation : IResource
    {
        string Image { get; set; }

        Position Position { get; set; }

        IEnumerable<ITransportPath> Origins { get; }

        IEnumerable<ITransportPath> Destinations { get; }
    }
}