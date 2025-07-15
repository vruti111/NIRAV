using System;
namespace NIRAV
{
    // jagged array
    public class jary1
    {
        public static void Main(string[] args)
        {
            int[][] jAry = new int[4][];
            jAry[0] = new int[4]; // 4 elements
            jAry[1] = new int[3]; // 3 elements
            jAry[2] = new int[2]; // 2 elements
            jAry[3] = new int[1]; // 1 element

            Console.WriteLine("Enter jagged array elements:");
            for (int i = 0; i < jAry.Length; i++)
            {
                for (int j = 0; j < jAry[i].Length; j++)
                {
                    Console.Write($"Enter element [{i}][{j}]: ");
                    jAry[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nJagged array is:");
            for (int i = 0; i < jAry.Length; i++)
            {
                for (int j = 0; j < jAry[i].Length; j++)
                {
                    Console.Write(jAry[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
