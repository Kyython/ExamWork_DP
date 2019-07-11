namespace ExamWork_DP
{
    public class Keyboard : ComputerComponent
    {
        public Keyboard(ComputerType type) : base(type)
        {
        }

        public override string GetNameComponent()
        {
            return "Keyboard + " + base.GetNameComponent();
        }

        public override int GetPriceComponent()
        {
            return 500 + base.GetPriceComponent();
        }
    }
}
