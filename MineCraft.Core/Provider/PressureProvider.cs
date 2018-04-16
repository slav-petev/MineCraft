namespace MineCraft.Core.Provider
{
    public class PressureProvider : StandardProvider
    {
        public PressureProvider(string id, double energyOutput,
            double initialDurability) 
            : base(id, energyOutput, initialDurability)
        {
            this.Durability -= 300;
            this.EnergyOutput *= 2;
        }
    }
}
