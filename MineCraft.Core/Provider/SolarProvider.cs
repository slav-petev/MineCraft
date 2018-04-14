using System;
using System.Collections.Generic;
using System.Text;

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
