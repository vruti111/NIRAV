// command line argument
using System;

namespace NIRAV;
{



public void showData()
    {
        COnsole.WriteLine("Employee id is:" + eId);
        COnsole.WriteLine("Employee name is:" + eName);
        COnsole.WriteLine("Employee salary is:" + esalary);
    }
}
 internal class Democlass2
{
    public static void Main(string[] args)
    {
        Employee1 emp = new Employee1();
        emp.showData();
    }
}
}
