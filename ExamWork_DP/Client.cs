using System;

namespace ExamWork_DP
{
    public class Client
    {
        public void ClientCode(ComputerComponent component)
        {
            Console.WriteLine("Configuration: " + component.GetNameComponent());
            Console.WriteLine("Price: " + component.GetPriceComponent());
        }
    }
}
