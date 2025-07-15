using System;

namespace NIRAV
{
    public class jary3
    {
        public static void Main(string[] args)
        {
            // Declare jagged array with 7 rows
            int[][] jAry = new int[7][];
            jAry[0] = new int[1];
            jAry[1] = new int[2];
            jAry[2] = new int[3];
            jAry[3] = new int[4];
            jAry[4] = new int[3];
            jAry[5] = new int[2];
            jAry[6] = new int[1];

            // Fill jagged array with increasing numbers
            for (int i = 0; i < jAry.Length; i++)
            {
                for (int j = 0; j < jAry[i].Length; j++)
                {
                    jAry[i][j] = j + 1;
                }
            }

            // Print jagged array
            for (int i = 0; i < jAry.Length; i++)
            {
                for (int j = 0; j < jAry[i].Length; j++)
                {
                    Console.Write(jAry[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
