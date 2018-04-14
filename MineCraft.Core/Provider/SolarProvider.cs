namespace MineCraft.Core.Provider
{
    public class SolarProvider : StandardProvider
    {
        public SolarProvider(double initialDurability) 
            : base(initialDurability)
        {
            this.Durability += 500;
        }
    }
}
