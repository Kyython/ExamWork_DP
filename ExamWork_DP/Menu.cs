using System;

namespace ExamWork_DP
{
    public class Menu
    {
        public void ShowBase()
        {
            Console.Clear();
            Client client = new Client();

            var home = new HomeComputer();
            ComputerComponent keyboard = new Keyboard(home);
            ComputerComponent monitor = new Monitor(keyboard);
            ComputerComponent centralProcessor = new СentralProcessor(monitor);

            Console.WriteLine("Home computer base - ");
            client.ClientCode(centralProcessor);

            Console.WriteLine();

            ComputerType pro = new ProComputer();
            ComputerComponent proKeyboard = new Keyboard(pro);
            ComputerComponent proMonitor = new Monitor(proKeyboard);
            ComputerComponent proVideoCard = new VideoCard(proMonitor);
            ComputerComponent proCentralProcessor = new СentralProcessor(proVideoCard);

            Console.WriteLine("Pro computer base - ");
            client.ClientCode(proCentralProcessor);


            Console.WriteLine("Нажмите Enter чтобы продолжить!");
            Console.ReadKey();
        }
    }
}
