using MineCraft.Core.Mode;

namespace MineCraft.Core
{
    public abstract class MiningEntity
    {
        public string Id { get; }
        public SystemMode Mode { get; private set; }

        protected MiningEntity(string id)
        {
            this.Id = id;
        }

        public void ChangeMode(SystemMode newMode)
        {
            Mode = newMode;
            ChangeModeInternal(newMode);
        }

        protected abstract void ChangeModeInternal(SystemMode newMode);
    }
}
