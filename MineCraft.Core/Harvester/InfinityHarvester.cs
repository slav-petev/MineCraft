namespace MineCraft.Core.Harvester
{
    public class InfinityHarvester : BasicHarvester
    {
        public InfinityHarvester(double initialDurability) 
            : base(initialDurability)
        {
            this.OreOutput /= 10;
        }
    }
}
