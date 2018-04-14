namespace MineCraft.Core.Mode
{
    public class EntityMode
    {
        public static readonly EntityMode Energy = new EntityMode(20);
        public static readonly EntityMode Half = new EntityMode(50);
        public static readonly EntityMode Full = new EntityMode(100);

        public double PercentChange { get; }

        private EntityMode(double percentChange)
        {
            this.PercentChange = percentChange;
        }
    }
}
