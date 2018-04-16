namespace MineCraft.Core.Harvester
{
    public class HammerHarvester : StandardHarvester
    {
        public HammerHarvester(string id, double oreOutput,
            double energyRequirement, double initialDurability) 
            : base(id, oreOutput, energyRequirement, initialDurability)
        {
            this.EnergyRequirement *= 2;
            this.OreOutput *= 4;
        }
    }
}
