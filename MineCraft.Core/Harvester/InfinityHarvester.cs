namespace MineCraft.Core.Harvester
{
    public class InfinityHarvester : StandardHarvester
    {
        public InfinityHarvester(string id, double oreOutput,
            double energyRequirement, double initialDurability) 
            : base(id, oreOutput, energyRequirement, initialDurability)
        {
            this.OreOutput /= 10;
        }
    }
}
