using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIRAV
{
    public class Demo3
    {
        int x;
        static int y = 20;
        public Demo3() { }
        public Demo3(int x)
        {
            this.x = x;
        }


        public static int addNum()
        {
            Demo3 ob = new Demo3(10);
            return (ob.x + y);
        }
        public void show()
        {
            Console.WriteLine("X is :" + x);
            Console.WriteLine("Y is :" + y);

        }
    }
    internal class staticdemo
    {
        public static void Main(String[] args)
        {
            Demo3 ob = new Demo3(30);
            Console.WriteLine("Addition of X and Y is  :" + Demo3.addNum());
            ob.show();

        }
    }
}