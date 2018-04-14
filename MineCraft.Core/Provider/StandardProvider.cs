namespace MineCraft.Core.Provider
{
    public class StandardProvider
    {
        public int Id { get; protected set; }
        public double EnergyOutput { get; protected set; }
        public double Durability { get; protected set; }

        public StandardProvider(int id, double energyOutput,
            double initialDurability)
        {
            this.Id = id;
            this.EnergyOutput = energyOutput;
            this.Durability = initialDurability;
        }
    }
}
