using MineCraft.Core.Mode;

namespace MineCraft.Core.Harvester
{
    public class StandardHarvester : MiningEntity
    {
        public double OreOutput { get; protected set; }
        public double EnergyRequirement { get; protected set; }
        public double Durability { get; protected set; }

        public StandardHarvester(string id, double oreOutput,
            double energyRequirement, double initialDurability) : base(id)
        {
            this.OreOutput = oreOutput;
            this.EnergyRequirement = energyRequirement;
            this.Durability = initialDurability;
        }

        protected override void ChangeModeInternal(SystemMode newMode)
        {
            this.Durability -= 100;
            var multiplier = 1 + (newMode.PercentChange / 100.0);
            this.EnergyRequirement *= multiplier;
            this.OreOutput *= multiplier;
        }
    }
}
