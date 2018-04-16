namespace MineCraft.Core.Operation.Notification
{
    public interface INotifier<TNotificationData>
    {
        void Notify(TNotificationData notificationData);
    }
}
