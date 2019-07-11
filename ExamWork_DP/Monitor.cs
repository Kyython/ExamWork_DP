namespace ExamWork_DP
{
    public class Monitor : ComputerComponent
    {
        public Monitor(ComputerType type) : base(type)
        {
        }

        public override string GetNameComponent()
        {
            return "Monitor + " + base.GetNameComponent();
        }

        public override int GetPriceComponent()
        {
            return 1000 + base.GetPriceComponent();
        }
    }
}
