using System;

namespace SatrancTahtasi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            short[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            

            for (int i = 0; i < letters.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    Console.Write($"{letters[j]}{numbers[i]}, ");
                }
                Console.Write("\n");
            }
            */

            /*
            string[,] squares = { { "a", "b", "c", "d", "e", "f", "g", "h" }, { "1", "2", "3", "4", "5", "6", "7", "8" } };
            int target = 0;
            while (target < squares.Length / squares.Rank)
            {
                for (int i = 0; i < squares.Length / squares.Rank; i++)
                {
                    Console.Write(squares[0, i] + squares[1, target]);
                }
                Console.WriteLine();
                target++;

            }
            */

            char[] letters = "ABCDEFGH".ToCharArray();
            for (int i = 0; i < letters.Length; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    Console.Write($"{letters[j]}{(i + 1)}{(j == letters.Length - 1 ? "\n" : "")}");
                }
            }

            for (int j = 1; j <= 8; j++)
            {
                for (char i = 'A'; i <= 'H'; i++)
                {
                    Console.Write($"{i}{j}");
                }
                Console.WriteLine();
            }


            Console.Read();
        }
    }
}
