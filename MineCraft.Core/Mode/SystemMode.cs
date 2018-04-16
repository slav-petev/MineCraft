namespace MineCraft.Core.Mode
{
    public class SystemMode
    {
        public static readonly SystemMode Energy = new SystemMode("Energy", 20);
        public static readonly SystemMode Half = new SystemMode("Half", 50);
        public static readonly SystemMode Full = new SystemMode("Full", 100);

        public string Name { get; }

        public double PercentChange { get; }

        private SystemMode(string name, double percentChange)
        {
            this.Name = name;
            this.PercentChange = percentChange;
        }
    }
}
