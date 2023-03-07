using Moryx.AbstractionLayer.Resources;
using Moryx.Factory;

namespace Moryx.Simulation.Resources
{
    public interface IMachineLocation : ILocation, IPublicResource
    {
        ISimulationCell Machine { get; }
    }
}