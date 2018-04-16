using MineCraft.Core;
using MineCraft.Core.Operation;

namespace MineCraft.ApplicationLayer.Operation
{
    public class InspectOperation : NotifyOnCompletionOperation<string>
    {
        private MiningEntity _entity;

        public string MiningEntityId { get; }

        public InspectOperation(MiningSystem system, INotifier<string> notifier, 
            string miningEntityId) 
            : base(system, notifier)
        {
            this.MiningEntityId = miningEntityId;
        }

        protected override void ExecuteInternal()
        {
            _entity = this.System.FindById(this.MiningEntityId);
        }

        protected override string GetNotificationData()
        {
            return _entity.ToString();
        }
    }
}
