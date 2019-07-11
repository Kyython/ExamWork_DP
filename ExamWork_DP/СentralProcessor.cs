namespace ExamWork_DP
{
    public class СentralProcessor : ComputerComponent
    {
        public СentralProcessor(ComputerType type) : base(type)
        {
        }

        public override string GetNameComponent()
        {
            return "СentralProcessor + " + base.GetNameComponent();
        }

        public override int GetPriceComponent()
        {
            return 50000 + base.GetPriceComponent();
        }
    }
}
