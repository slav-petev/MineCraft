using MineCraft.Core;
using MineCraft.Core.Operation;

namespace MineCraft.ApplicationLayer.Operation
{
    public abstract class NotifyOnCompletionOperation<TNotificationData> : IOperation
    {
        private readonly INotifier<TNotificationData> _notifier;

        protected MiningSystem System { get; }

        protected NotifyOnCompletionOperation(MiningSystem system,
            INotifier<TNotificationData> notifier)
        {
            this.System = system;
            _notifier = notifier;
        }

        public void Execute()
        {
            ExecuteInternal();
            OnExecuted();
        }

        protected virtual void OnExecuted()
        {
            _notifier.Notify(GetNotificationData());
        }

        protected abstract void ExecuteInternal();

        protected abstract TNotificationData GetNotificationData();
    }
}
