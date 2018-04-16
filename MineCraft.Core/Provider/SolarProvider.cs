namespace MineCraft.Core.Provider
{
    public class SolarProvider : StandardProvider
    {
        public SolarProvider(string id, double energyOutput, 
            double initialDurability) 
            : base(id, energyOutput, initialDurability)
        {
            this.Durability += 500;
        }
    }
}
