namespace MineCraft.Core.Operation
{
    public interface IOperation
    {
        void Execute();
    }

    public abstract class NotifyOnCompletionOperation<TNotificationData> : IOperation
    {
        private readonly INotifier<TNotificationData> _notifier;

        protected NotifyOnCompletionOperation(INotifier<TNotificationData> notifier)
        {
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

    public interface INotifier<TNotificationData>
    {
        void Notify(TNotificationData data);
    }

}
