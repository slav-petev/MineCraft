namespace MineCraft.Core.Harvester
{
    public class InfinityHarvester : StandardHarvester
    {
        public InfinityHarvester(double initialDurability) 
            : base(initialDurability)
        {
            this.OreOutput /= 10;
        }
    }
}
