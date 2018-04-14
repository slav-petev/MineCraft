﻿namespace MineCraft.Core.Provider
{
    public class PressureProvider : StandardProvider
    {
        public PressureProvider(double initialDurability) 
            : base(initialDurability)
        {
            this.Durability -= 300;
            this.EnergyOutput *= 2;
        }
    }
}
