using System;
namespace NIRAV
{
    public class Ary22
    {
        public static void Main(string[] args)
        //3*2 ARRAY
        {
            int[,] ary = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            Console.WriteLine("3x2 2D array:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)  // columns
                {
                    Console.Write(ary[i, j] + " ");
                }
                Console.WriteLine();  // new line after each row
            }
        }
    }
}









        