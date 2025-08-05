using System;
namespace NIRAV
{//jagged array
    public class jary1
    {
        public static void Main(string[] args)
        {
            int[][] jAry = new int[4][];
            jAry[0] = new int[4];
            jAry[1] = new int[3];
            jAry[2] = new int[2];
            jAry[1] = new int[1];
            Console.WriteLine("enter jarray element:");
            for (int i = 0; i < jAry.Length; i++)
            {
                for (int j = 0; i < jAry[i].Length; j++)
                {
                    jAry[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("jarray array is:");
            for (int i = 0; i < jAry.Length; i++)
            {
                for (int j = 0; i < jAry[i].Length; j++)
                {
                    Console.Write(jAry[i][j]);
                }
                Console.WriteLine();
            }     
        }
    }
}

