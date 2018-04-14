namespace MineCraft.Core.Harvester
{
    public class SonicHarvester : BasicHarvester
    {
        public SonicHarvester(double initialDurability) 
            : base(initialDurability)
        {
            this.EnergyRequirement /= 2;
            this.Durability -= 300;
        }
    }
}
