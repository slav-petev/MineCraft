namespace MineCraft.Core.Harvester
{
    public class HammerHarvester : BasicHarvester
    {
        public HammerHarvester(double initialDurability) 
            : base(initialDurability)
        {
            this.EnergyRequirement *= 2;
            this.OreOutput *= 4;
        }
    }
}
