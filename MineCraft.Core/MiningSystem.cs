using MineCraft.Core.Harvester;
using MineCraft.Core.Mode;
using MineCraft.Core.Provider;
using System.Collections.Generic;
using System.Linq;

namespace MineCraft.Core
{
    public class MiningSystem
    {
        private readonly HashSet<StandardProvider> _providers =
            new HashSet<StandardProvider>();
        public IEnumerable<StandardProvider> Providers => _providers;

        private readonly HashSet<StandardHarvester> _harvesters =
            new HashSet<StandardHarvester>();
        public IEnumerable<StandardHarvester> Harvesters => _harvesters;

        private SystemMode _systemMode;

        public double AvailableEnergy { get; private set; }
        public double AvailableOre { get; private set; }
        
        public MiningEntity FindById(string id)
        {
            return null;
        }

        public void RegisterProvider(StandardProvider provider)
        {
            _providers.Add(provider);
            this.AvailableEnergy += provider.EnergyOutput;
        }

        public void RegisterHarvester(StandardHarvester harvester)
        { 
            _harvesters.Add(harvester);
        }
        
        public void Mine()
        {
            var totalEnergyNeeded = _harvesters.Sum(harvester => harvester.EnergyRequirement);

            if (totalEnergyNeeded > this.AvailableEnergy) return;

            var totalOreAmount = _harvesters.Sum(harvester => harvester.OreOutput);
            this.AvailableOre += totalOreAmount;
            this.AvailableEnergy -= totalEnergyNeeded;
        }

        public void Shutdown()
        {

        }
    }
}
