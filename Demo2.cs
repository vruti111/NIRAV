using System;

namespace NIRAV
{
    public class Demo2
    {
        int x; // private member of class
        int y;

        public int x { get; set; }
        public int y { get; set; }

        get { return y; }  // read-write property
        }
    }
    internal class PropertyDemo
    {
        static void Main(string[] args)
        {
            Demo1 ob = new Demo1(100, 200);
            ob.X = 50;
            ob.Y = 150;
         
            Console.WriteLine("Addition of x and y:" + (ob.X + ob.Y));
        }
    }
}