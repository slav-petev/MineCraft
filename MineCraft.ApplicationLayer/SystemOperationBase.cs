using MineCraft.Core;

namespace MineCraft.ApplicationLayer
{
    public abstract class SystemOperationBase
    {
        protected MiningSystem System { get; }

        protected SystemOperationBase(MiningSystem system)
        {
            this.System = system;
        }
    }
}
