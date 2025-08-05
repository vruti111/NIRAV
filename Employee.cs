using System;

namespace NIRAV
{
    public class Employee
    {
        int empId;
        string eName;
        double salary;

        public void getData(int id, double sal, string name)
        {
            empId = id;
            eName = name;
            salary = sal;
        }

        public void showData()
        {
            Console.WriteLine("Emp id: " + empId);
            Console.WriteLine("Emp name: " + eName);
            Console.WriteLine("Emp salary: " + salary);
        }

        // New method to return salary
        public double getSalary()
        {
            return salary;
        }
    }

    internal class ClassDemo1
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.getData(111, 10, "vvvv");

            Employee e2 = new Employee();
            e2.getData(222, 20, "bbbb");

            if (e1.getSalary() > e2.getSalary())
                e1.showData();
            else
                e2.showData();
        }
    }
}
