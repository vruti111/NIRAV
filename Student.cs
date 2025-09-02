using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIRAV;

class Student
{
    int rlno;
    string name;

    public Student() // Default Constructor
    {
        Console.Write("Enter roll no: ");
        rlno = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter name: ");
        name = Console.ReadLine();
    }
    public void showData()
    {
        Console.WriteLine("Roll no. is : " + rlno);
        Console.WriteLine("Name is : " + name);
    }
}
internal class Constructor
{
    public static void Main(string[] args)
    {
        Student s1 = new Student( 11,"vvv");  // constructor called here 
        s1.showData();
        Console.WriteLine();
        Student s2 = new Student();
        s2.showData();
        Console.WriteLine();
        Student s3 = new Student();
        s3.showData();
    }
}