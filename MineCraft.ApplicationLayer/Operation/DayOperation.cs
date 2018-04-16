using System;
using MineCraft.Core;
using MineCraft.Core.Operation;

namespace MineCraft.ApplicationLayer.Operation
{
    public class DayOperation : NotifyOnCompletionOperation<string>
    {
        public DayOperation(MiningSystem system, INotifier<string> notifier) 
            : base(system, notifier)
        {
        }

        protected override void ExecuteInternal()
        {
            this.System.Mine();
        }

        protected override string GetNotificationData()
        {
            throw new NotImplementedException();
        }
    }
}
