using System;

namespace GameOfLife
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cell[,] plain = CreatePlain(10, 10);
            var world = new World(plain);
            var time = new Time(world);

            while (Console.KeyAvailable)
            {
                Console.ReadKey();
            }

            Console.WriteLine();
            Console.WriteLine("Hello World!");

            while (true)
            {
                DisplayPlain(plain);

                ConsoleKey key = GetKey();

                if (key == ConsoleKey.N)
                {
                    break;
                }

                time.Tick();
            }

            Console.WriteLine();
            Console.WriteLine("Goodbye World!");
        }

        private static ConsoleKey GetKey()
        {
            Console.WriteLine();
            Console.Write("Another round (Y/n)? ");
            ConsoleKey key = Console.ReadKey().Key;
            Console.WriteLine();
            return key;
        }

        private static Cell[,] CreatePlain(int x, int y)
        {
            var rand = new Random();

            var plain = new Cell[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    plain[i, j] = new Cell(rand.NextDouble() > 0.5);
                }
            }

            return plain;
        }

        private static void DisplayPlain(Cell[,] plain)
        {

            Console.WriteLine();
            Console.WriteLine("Current plain state");

            for (int i = 0; i < plain.GetLength(0); i++)
            {
                for (int j = 0; j < plain.GetLength(1); j++)
                {
                    Console.Write(plain[i,j].IsAlive ? "X " : "  ");
                }

                Console.WriteLine();
            }
        }
    }
}