using Moryx.AbstractionLayer.Resources;

namespace Moryx.Factory
{
    public interface IManufacturingFactory : IPublicResource
    {
        /// <summary>
        /// Background URL of factory monitor
        /// </summary>
        string BackgroundUrl { get; set; }
    }
}
