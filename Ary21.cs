

using System;
namespace NIRAV
{
    public class Ary21
    {
        public static void Main(string[] args)
        {
            // 2x2 array
            int[,] ary = new int[2, 2];
            ary[0, 0] = 1;
            ary[0, 1] = 2;
            ary[1, 0] = 3;
            ary[1, 1] = 4; // ✅ fixed index

            Console.WriteLine("First element: " + ary[0, 0]);
        }
    }
}



