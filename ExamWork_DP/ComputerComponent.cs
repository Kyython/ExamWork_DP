namespace ExamWork_DP
{
    public abstract class ComputerComponent : ComputerType
    {
        protected ComputerType _computerType;

        public ComputerComponent(ComputerType computerType)
        {
            _computerType = computerType;
        }

        public void SetComponent(ComputerType computerType)
        {
            _computerType = computerType;
        }

        public override int GetPriceComponent()
        {
            if (_computerType != null)
            {
                return _computerType.GetPriceComponent();
            }
            else
            {
                return 0;
            }
        }

        public override string GetNameComponent()
        {
            if (_computerType != null)
            {
                return _computerType.GetNameComponent();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
