using Moryx.AbstractionLayer.Resources;
using Moryx.Simulation.Resources;
namespace Moryx.Factory
{
    public interface IMachineLocation : ILocation, IPublicResource
    {
        ISimulationCell Machine { get; }
    }
}