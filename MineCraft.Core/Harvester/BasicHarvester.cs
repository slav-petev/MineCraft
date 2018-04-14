namespace MineCraft.Core.Harvester
{
    public class BasicHarvester
    {
        public int Id { get; protected set; }
        public double OreOutput { get; protected set; }
        public double EnergyRequirement { get; protected set; }
        public double Durability { get; protected set; }

        public BasicHarvester(double initialDurability)
        {
            this.Durability = initialDurability;
        }
    }
}
