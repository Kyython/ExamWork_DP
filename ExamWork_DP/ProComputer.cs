namespace ExamWork_DP
{
    class ProComputer : ComputerType
    {
        public ProComputer(ComputerComponent computerComponent) : base(computerComponent)
        {
        }

        public override string GetNameComponent()
        {
            return "Pro computer " + base.GetNameComponent();
        }

        public override int GetPriceComponent()
        {
            return 100000 + base.GetPriceComponent();
        }
    }
}
