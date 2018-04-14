namespace MineCraft.Core.Harvester
{
    public class StandardHarvester
    {
        public int Id { get; protected set; }
        public double OreOutput { get; protected set; }
        public double EnergyRequirement { get; protected set; }
        public double Durability { get; protected set; }

        public StandardHarvester(double initialDurability)
        {
            this.Durability = initialDurability;
        }
    }
}
