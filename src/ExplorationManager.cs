namespace Subnautica2BlueprintTracker
{
    public class ExplorationManager
    {
        public int DiscoveredBiomes { get; set; }

        public int TotalBiomes { get; set; }

        public bool IsWorldFullyExplored()
        {
            return DiscoveredBiomes >= TotalBiomes;
        }
    }
}
