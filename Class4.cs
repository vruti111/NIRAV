//the employee list for a company contains employee code, name, designation, instname and basic pay . the employee is given a house rent allware(HRA) of 10%of basic pay and dearness allowance(DA)  of 45% of the basic pay the total pay of the employee is calculated as basic pay+HRA+DA.write a class to define a employee.write a  constructor to assign the required initial values.w
using System;

namespace NIARV
{
    public class Employee
    {
        public int EmpCode;
        public string Name;
        public string Designation;
        public string InstName;
        public double BasicPay;

        // Constructor
        public Employee(int empCode, string name, string designation, string instName, double basicPay)
        {
            EmpCode = empCode;
            Name = name;
            Designation = designation;
            InstName = instName;
            BasicPay = basicPay;
        }

        // HRA (10%)
        public double CalculateHRA()
        {
            return BasicPay * 0.10;
        }

        // DA (45%)
        public double CalculateDA()
        {
            return BasicPay * 0.45;
        }

        //  Total Salary
        public double TotalSalary()
        {
            return BasicPay + CalculateHRA() + CalculateDA();
        }

    
        public void Display()
        {
            Console.WriteLine("\nEmployee Code : " + EmpCode);
            Console.WriteLine("Name          : " + Name);
            Console.WriteLine("Designation   : " + Designation);
            Console.WriteLine("Institute     : " + InstName);
            Console.WriteLine("Basic Pay     : " + BasicPay);
            Console.WriteLine("HRA (10%)     : " + CalculateHRA());
            Console.WriteLine("DA (45%)      : " + CalculateDA());
            Console.WriteLine("Total Salary  : " + TotalSalary());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Employee Code: ");
            int code = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Designation: ");
            string designation = Console.ReadLine();

            Console.Write("Enter Institute Name: ");
            string instName = Console.ReadLine();

            Console.Write("Enter Basic Pay: ");
            double basicPay = Convert.ToDouble(Console.ReadLine());

            Employee emp = new Employee(code, name, designation, instName, basicPay);

            emp.Display();

            Console.ReadLine();
        }
    }
}
