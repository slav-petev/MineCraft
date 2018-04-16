using MineCraft.Core;
using MineCraft.Core.Operation;
using System;
using System.Text;

namespace MineCraft.ApplicationLayer.Operation
{
    public class ShutdownOperation : NotifyOnCompletionOperation<string>
    {
        public ShutdownOperation(MiningSystem system, INotifier<string> notifier) 
            : base(system, notifier)
        {
        }

        protected override void ExecuteInternal()
        {
            this.System.Shutdown();
        }

        protected override string GetNotificationData()
        {
            var notificationBuilder = new StringBuilder();
            notificationBuilder.AppendLine("System Shutdown");
            notificationBuilder.AppendFormat(
                $"Total Energy Produced: {this.System.TotalEnergyProduced}{Environment.NewLine}");
            notificationBuilder.AppendFormat(
                $"Total Mined Plumbus Ore: {this.System.TotalPlumbusOreMined}{Environment.NewLine}");

            return notificationBuilder.ToString();
        }
    }
}
