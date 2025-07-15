using System;
namespace NIRAV
{
    public class Ary23
    {
        public static void Main(string[] args)
        // 2×3 ARRAY
        {
            int[,] ary = { { 1, 2, 3 }, { 4, 5, 6 } };

            Console.WriteLine("2x3 2D array:");
            for (int i = 0; i < 2; i++) // 2 rows
            {
                for (int j = 0; j < 3; j++) // 3 columns
                {
                    Console.Write(ary[i, j] + " ");
                }
                Console.WriteLine(); // new line after each row
            }
        }
    }
}
