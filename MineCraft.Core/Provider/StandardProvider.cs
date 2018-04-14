using MineCraft.Core.Mode;

namespace MineCraft.Core.Provider
{
    public class StandardProvider : MiningEntity
    {
        public double EnergyOutput { get; protected set; }
        public double Durability { get; protected set; }

        public StandardProvider(string id, double energyOutput,
            double initialDurability) : base(id)
        {
            this.EnergyOutput = energyOutput;
            this.Durability = initialDurability;
        }

        protected override void ChangeModeInternal(SystemMode newMode)
        {
            
        }
    }
}
