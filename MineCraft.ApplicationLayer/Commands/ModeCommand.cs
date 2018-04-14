using MineCraft.Core.Mode;
using System;
using System.Collections.Generic;

namespace MineCraft.ApplicationLayer.Commands
{
    public class ModeCommand
    {
        private static readonly Dictionary<string, SystemMode> _modes =
            new Dictionary<string, SystemMode>
            {
                { "Energy", SystemMode.Energy },
                { "Half", SystemMode.Half },
                { "Full", SystemMode.Full }
            };

        private SystemMode _mode;

        private ModeCommand(SystemMode mode)
        {
            _mode = mode;
        }

        public void Execute()
        {

        }
            
        public static ModeCommand Create(string mode)
        {
            if (!_modes.ContainsKey(mode))
                throw new ArgumentException("Invalid mode");

            return new ModeCommand(_modes[mode]);
        }
    }
}
