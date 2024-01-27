using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tortik
{
    internal class Zakaz
    {
        int TotalCost = 0;
        ConsoleKeyInfo choice;
        SubMenu Shape = new SubMenu()
        {
            ProductName1 = "Круглый",
            Price1 = 1000,
            ProductName2 = "Квадратный",
            Price2 = 1000,
            ProductName3 = "Шар",
            Price3 = 1200
        };
        SubMenu Size = new SubMenu()
        {
            ProductName1 = "Маленький",
            Price1 = 200,
            ProductName2 = "Средний",
            Price2 = 800,
            ProductName3 = "Громаднейший",
            Price3 = 1500
        };
        SubMenu Flavor = new SubMenu()
        {
            ProductName1 = "Вкусный",
            Price1 = 150,
            ProductName2 = "Невкусный",
            Price2 = 300,
            ProductName3 = "Не уверен",
            Price3 = 1500
        };
        SubMenu Amount = new SubMenu()
        {
            ProductName1 = "1",
            Price1 = 1,
            ProductName2 = "2",
            Price2 = 2,
            ProductName3 = "3",
            Price3 = 3
        };
        SubMenu Icying = new SubMenu()
        {
            ProductName1 = "Шоколад",
            Price1 = 500,
            ProductName2 = "Шоколад",
            Price2 = 1000,
            ProductName3 = "Шоколад",
            Price3 = 1500
        };
        SubMenu Decor = new SubMenu()
        {
            ProductName1 = "2 башни",
            Price1 = 1000,
            ProductName2 = "Лягушка",
            Price2 = 100,
            ProductName3 = "Олег",
            Price3 = 1200
        };
        public void SubMenu()
        {
            int option = Strelka.Show();
            if (option == 1)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("  " + Shape.ProductName1 + " " + Shape.Price1);
                Console.WriteLine("  " + Shape.ProductName2 + " " + Shape.Price2);
                Console.WriteLine("  " + Shape.ProductName3 + " " + Shape.Price3);
                choice = Console.ReadKey();
                if (choice.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    MainMenu();
                }
                Console.Clear();
                MainMenu();
            }
        }
        public void MainMenu()
        {
            Console.WriteLine("Торты");
            Console.WriteLine("  Форма");
            Console.WriteLine("  Размер");
            Console.WriteLine("  Вкус");
            Console.WriteLine("  Количество");
            Console.WriteLine("  Глазурь");
            Console.WriteLine("  Декорь");
            Console.WriteLine("  Закончить заказ");
            Console.WriteLine();
            Console.WriteLine("Цена: " + TotalCost + " Рублей");
            Console.WriteLine("Торт: ");
            choice = Console.ReadKey();
            if (choice.Key == ConsoleKey.Enter)
            {
                SubMenu();
            }
        }
    }
}
