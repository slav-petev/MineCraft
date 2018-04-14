namespace MineCraft.Core.Mode
{
    public class SystemMode
    {
        public static readonly SystemMode Energy = new SystemMode(20);
        public static readonly SystemMode Half = new SystemMode(50);
        public static readonly SystemMode Full = new SystemMode(100);

        public double PercentChange { get; }

        private SystemMode(double percentChange)
        {
            this.PercentChange = percentChange;
        }
    }
}
