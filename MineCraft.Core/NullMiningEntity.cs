using MineCraft.Core.Mode;

namespace MineCraft.Core
{
    public class NullMiningEntity : MiningEntity
    {
        public NullMiningEntity() : base(string.Empty)
        {
        }

        protected override void ChangeModeInternal(SystemMode newMode)
        {
            
        }
    }
}
