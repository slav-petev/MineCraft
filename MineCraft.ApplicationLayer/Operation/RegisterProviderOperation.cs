using MineCraft.Core;
using MineCraft.Core.Operation;
using MineCraft.Core.Provider;

namespace MineCraft.ApplicationLayer.Operation
{
    public class RegisterProviderOperation : NotifyOnCompletionOperation<string>
    {
        public StandardProvider Provider { get; }

        public RegisterProviderOperation(MiningSystem system, 
            INotifier<string> notifier) : base(system, notifier)
        {
        }

        protected override void ExecuteInternal()
        {
            this.System.RegisterProvider(this.Provider);
        }

        protected override string GetNotificationData()
        {
            return $"Successfully registered {this.Provider.GetType().Name}";
        }
    }
}
