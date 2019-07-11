namespace ExamWork_DP
{
    public class VideoCard : ComputerComponent
    {
        public VideoCard(ComputerType type) : base(type)
        {
        }

        public override string GetNameComponent()
        {
            return "VideoCard + " + base.GetNameComponent();
        }

        public override int GetPriceComponent()
        {
            return 2000 + base.GetPriceComponent();
        }
    }
}
