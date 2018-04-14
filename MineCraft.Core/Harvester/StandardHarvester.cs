namespace MineCraft.Core.Harvester
{
    public class StandardHarvester
    {
        public int Id { get; protected set; }
        public double OreOutput { get; protected set; }
        public double EnergyRequirement { get; protected set; }
        public double Durability { get; protected set; }

        public StandardHarvester(int id, double oreOutput,
            double energyRequirement, double initialDurability)
        {
            this.Id = id;
            this.OreOutput = oreOutput;
            this.EnergyRequirement = energyRequirement;
            this.Durability = initialDurability;
        }
    }
}
