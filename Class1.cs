using System;

public class Employee
{
    // Data members with properties
     int EmpCode { get; set; }
     string Name { get; set; }
     string Designation { get; set; }
     string InstituteName { get; set; }
     double BasicPay { get; set; }
     double HRA { get; private set; }
     double DA { get; private set; }
     double TotalPay { get; private set; }

    // Static members
    private static int count = 0;          // total employees created
    private static double highestPay = 0;  // highest total pay
    private static Employee highestEmp;    // employee with highest pay

    // Default Constructor
    public Employee()
    {
        EmpCode = 0;
        Name = "Unknown";
        Designation = "Not Assigned";
        InstituteName = "Not Assigned";
        BasicPay = 0;
        CalculatePay();
        count++;
    }

    // Parameterized Constructor
    public Employee(int code, string name, string designation, string institute, double basic)
    {
        EmpCode = code;
        Name = name;
        Designation = designation;
        InstituteName = institute;
        BasicPay = basic;
        CalculatePay();
        count++;
    }

    // Copy Constructor
    public Employee(Employee other)
    {
        EmpCode = other.EmpCode;
        Name = other.Name;
        Designation = other.Designation;
        InstituteName = other.InstituteName;
        BasicPay = other.BasicPay;
        CalculatePay();
        count++;
    }

    // Method to calculate HRA, DA, and Total Pay
    public void CalculatePay()
    {
        HRA = 0.10 * BasicPay;
        DA = 0.45 * BasicPay;
        TotalPay = BasicPay + HRA + DA;

        // Track highest pay employee
        if (TotalPay > highestPay)
        {
            highestPay = TotalPay;
            highestEmp = this;
        }
    }

    // Method to display details
    public void Display()
    {
        Console.WriteLine("Emp Code     : " + EmpCode);
        Console.WriteLine("Name         : " + Name);
        Console.WriteLine("Designation  : " + Designation);
        Console.WriteLine("Institute    : " + InstituteName);
        Console.WriteLine("Basic Pay    : " + BasicPay);
        Console.WriteLine("HRA (10%)    : " + HRA);
        Console.WriteLine("DA (45%)     : " + DA);
        Console.WriteLine("Total Pay    : " + TotalPay);
        Console.WriteLine();
    }

    // Static method to display count
    public static void DisplayCount()
    {
        Console.WriteLine("Total Employees: " + count);
    }

    // Static method to display highest paid employee
    public static void DisplayHighest()
    {
        Console.WriteLine("\nEmployee with Highest Pay:");
        highestEmp.Display();
    }
}

class Program
{
    static void Main()
    {
        // Using Parameterized Constructor
        Employee e1 = new Employee(101, "Vruti", "Developer", "RK University", 50000);

        
        Employee e2 = new Employee();
        e2.EmpCode = 102;
        e2.Name = "Amit";
        e2.Designation = "Tester";
        e2.InstituteName = "RK University";
        e2.BasicPay = 45000;
        e2.CalculatePay();

        // Using Copy Constructor
        Employee e3 = new Employee(e1);

       
        Console.WriteLine("Employee Details:\n");
        e1.Display();
        e2.Display();
        e3.Display();

        // Show total count
        Employee.DisplayCount();

        // Show highest paid employee
        Employee.DisplayHighest();
    }
}
w