namespace ExamWork_DP
{
    public abstract class ComputerType : ComputerComponent
    {
        protected ComputerComponent _computerComponent;

        public ComputerType(ComputerComponent computerComponent)
        {
            _computerComponent = computerComponent;
        }

        public void SetComponent(ComputerComponent computerComponent)
        {
            _computerComponent = computerComponent;
        }

        public override int GetPriceComponent()
        {
            if (_computerComponent != null)
            {
                return _computerComponent.GetPriceComponent();
            }
            else
            {
                return 0;
            }
        }

        public override string GetNameComponent()
        {
            if (_computerComponent != null)
            {
                return _computerComponent.GetNameComponent();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
