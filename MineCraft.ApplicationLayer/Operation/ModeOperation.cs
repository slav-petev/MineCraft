using System.Collections.Generic;
using MineCraft.Core;
using MineCraft.Core.Mode;
using MineCraft.Core.Operation;

namespace MineCraft.ApplicationLayer.Operation
{
    public class ModeOperation : NotifyOnCompletionOperation<string>
    {
        private static readonly Dictionary<string, SystemMode> _validModes =
            new Dictionary<string, SystemMode>
            {
                { SystemMode.Energy.Name, SystemMode.Energy },
                { SystemMode.Half.Name, SystemMode.Half },
                { SystemMode.Full.Name, SystemMode.Full }
            };

        public SystemMode NewMode { get; }
        
        public ModeOperation(MiningSystem system, INotifier<string> notifier, 
            string newMode) 
            : base(system, notifier)
        {
            this.NewMode = _validModes[newMode];
        }

        protected override void ExecuteInternal()
        {
            //Implement System Change Mode
        }

        protected override string GetNotificationData()
        {
            return $"Mode changed to {this.NewMode.Name}";
        }
    }
}
