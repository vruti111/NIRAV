using System;

namespace mira_nb
{
    class A
    {
        public A()
        {
            Console.WriteLine("Constructor from Base A...");
        }

        public void methodA1()
        {
            Console.WriteLine("Method-1 from Base A");
        }

        protected void methodA2()
        {
            Console.WriteLine("Method-2 from Base A");
        }
    }

    class B : A
    {
        public B()
        {

            Console.WriteLine("Constructor from child B...");
        }
        public void methodB1()
        {
            methodA2();
            Console.WriteLine("Method-1 from Derived B");
        }
    }
    internal class DemoInh1
    {
        public static void Main(string[] args)
        {
            B obj = new B();
            obj.methodA1();
            obj.methodB1();
        }
    }
}