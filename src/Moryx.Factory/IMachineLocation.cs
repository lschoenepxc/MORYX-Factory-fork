using Moryx.AbstractionLayer.Resources;

namespace Moryx.Factory
{
    public interface IMachineLocation : ILocation, IPublicResource
    {
        IPublicResource Machine { get; }
    }
}