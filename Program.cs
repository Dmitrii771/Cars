using System;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            //if (transp.GetType() == typeof(Transport))
            //{

            //}
            //if (transp is Transport)
            //{

            //}

            StartGame();
            
            //Console.WriteLine($"Количество четырехпалубных кораблей: {1}");
            //Console.WriteLine($"Количество трехпалубных кораблей: {1}");
            //Console.WriteLine($"Количество двухпалубных кораблей: {1}");
            //Console.WriteLine($"Количество однопалубных кораблей: {1}");

            //Ship ship = new Ship("mark1","model1","number1");
            //ship.ShowInfo();
            //ship.Move();
            //Console.ReadKey();

            // создать класс player который будет содержать список кораблей. добавить в него необх кол-во кораблей
        }

        private static void StartGame()
        {
            Console.Write("Введите имя первого игрока: ");
            Player player1 = new Player()
            {
                Name = Console.ReadLine()
            };

            Console.Write("Введите имя второго игрока: ");
            Player player2 = new Player()
            {
                Name = Console.ReadLine()
            };

            Field field = new Field();
            field.Show();
            Console.WriteLine("Расставьте корабли");
            // Вывести информацию о количестве кораблей
            Console.Write("Выберите корабль: "); // Корабли могут быть 1-4 палубными, остальные случаи обработать
            int c = Int32.Parse(Console.ReadLine()); // использовать TryParse

            Console.Write("Выберите позицию (цифра,буква): "); // если корабль однопалубный направление не выбираем

            string pos = Console.ReadLine();
            field.SetShip(player1.Set(c, pos));
            Console.Clear();
            field.Show();
        }
    }
}
