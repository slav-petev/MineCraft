using System;
using System.Collections.Generic;
using System.Text;

namespace MineCraft.Core.Provider
{
    public class StandardProvider
    {
        public int Id { get; protected set; }
        public double EnergyOutput { get; protected set; }
        public double Durability { get; protected set; }

        public StandardProvider(double initialDurability)
        {
            this.Durability = initialDurability;
        }
    }
}
