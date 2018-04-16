using MineCraft.Core.Mode;

namespace MineCraft.Core
{
    public class NullMiningEntity : MiningEntity
    {
        public NullMiningEntity(string id) : base(id)
        {
        }

        protected override void ChangeModeInternal(SystemMode newMode)
        {
            
        }

        public override string ToString()
        {
            return $"No entity found with id - {this.Id}";
        }
    }
}
