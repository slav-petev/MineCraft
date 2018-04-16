using MineCraft.Core;
using MineCraft.Core.Harvester;
using MineCraft.Core.Operation;

namespace MineCraft.ApplicationLayer.Operation
{
    public class RegisterHarvesterOperation : NotifyOnCompletionOperation<string>,
        IRegisterOperation
    {
        public StandardHarvester Harvester { get; }

        public RegisterHarvesterOperation(MiningSystem system, 
            INotifier<string> notifier) : base(system, notifier)
        {
        }

        protected override void ExecuteInternal()
        {
            this.System.RegisterHarvester(this.Harvester);
        }

        protected override string GetNotificationData()
        {
            return $"Successfully registered {this.Harvester.GetType().Name}";
        }
    }
}
