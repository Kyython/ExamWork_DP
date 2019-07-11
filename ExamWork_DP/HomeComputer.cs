namespace ExamWork_DP
{
    public class HomeComputer : ComputerType
    {
        public HomeComputer(ComputerComponent computerComponent) : base(computerComponent)
        {
        }

        public override string GetNameComponent()
        {
            return "Home computer " + base.GetNameComponent();
        }

        public override int GetPriceComponent()
        {
            return 20000 + base.GetPriceComponent();
        }
    }
}
