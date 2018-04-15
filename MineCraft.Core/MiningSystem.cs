using MineCraft.Core.Harvester;
using MineCraft.Core.Mode;
using MineCraft.Core.Provider;
using System.Collections.Generic;
using System.Linq;

namespace MineCraft.Core
{
    public class MiningSystem
    {
        private readonly Dictionary<string, StandardProvider> _providers =
            new Dictionary<string, StandardProvider>();
        private readonly Dictionary<string, StandardHarvester> _harvesters =
            new Dictionary<string, StandardHarvester>();

        private SystemMode _systemMode;

        public double AvailableEnergy { get; private set; }
        public double AvailableOre { get; private set; }
        
        public MiningEntity FindById(string id)
        {
            if (_providers.ContainsKey(id)) return _providers[id];
            if (_harvesters.ContainsKey(id)) return _harvesters[id];

            return new NullMiningEntity();
        }

        public void RegisterProvider(StandardProvider provider)
        {
            _providers.Add(provider.Id, provider);
            this.AvailableEnergy += provider.EnergyOutput;
        }

        public void RegisterHarvester(StandardHarvester harvester)
        { 
            _harvesters.Add(harvester.Id, harvester);
        }
        
        public void Mine()
        {
            var totalEnergyNeeded = _harvesters.Sum(harvester => 
                harvester.Value.EnergyRequirement);

            if (totalEnergyNeeded > this.AvailableEnergy) return;

            var totalOreAmount = _harvesters.Sum(harvester => 
                harvester.Value.OreOutput);
            this.AvailableOre += totalOreAmount;
            this.AvailableEnergy -= totalEnergyNeeded;
        }

        public void Shutdown()
        {

        }
    }
}
