namespace Tortik
{
    internal class Program
    {
        static void Main()
        {
            Zakaz Menu = new Zakaz();
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Escape)
            {
                Menu.MainMenu();
                Strelka.Show();
            }
        }
    }
}