namespace MineCraft.Core.Harvester
{
    public class SonicHarvester : StandardHarvester
    {
        public SonicHarvester(string id, double oreOutput,
            double energyRequirement, double initialDurability) 
            : base(id, oreOutput, energyRequirement, initialDurability)
        {
            this.EnergyRequirement /= 2;
            this.Durability -= 300;
        }
    }
}
