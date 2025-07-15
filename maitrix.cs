using System;

namespace NIRAV
{
    public class maitrix
    {
        public static void Main(string[] args)
        {
            // Fixed size 2x2 arrays
            int[,] ary1 = new int[2, 2];
            int[,] ary2 = new int[2, 2];
            int[,] sum = new int[2, 2];

            Console.WriteLine("Enter elements for ary1 (2x2):");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"ary1[{i},{j}] = ");
                    ary1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nEnter elements for ary2 (2x2):");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"ary2[{i},{j}] = ");
                    ary2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Perform addition using nested loop
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    sum[i, j] = ary1[i, j] + ary2[i, j];
                }
            }

            Console.WriteLine("\nSum of two matrices:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(sum[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
