using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace NIRAV;

class Student3
{
    int rolno;
    string name;
    public Student(int rollNo, string name)//parameterized constructor
    {
        Console.WriteLine("Parameterized Constructor Called");
        this.rolno = rollNo;
        this.name = name;
    }
    public Student()//defaul constructor
    {
        Console.WriteLine("Default Constructor Called");
        Console.WriteLine("Enter Roll No ");
        rolno = Convert.ToInt32((Console.ReadLine()));
        Console.WriteLine("Enter Name ");
        name = Console.ReadLine();
    }
    public Student(Student s)
    {
        rolno = s.rolno;
        name = s.name;
    }
    static Student()
    {
        Console.WriteLine("Static Constructor Called");
    }
    public void showData()
    {
        Console.WriteLine("Roll No: " + rolno);
        Console.WriteLine("Name: " + name);
    }
}
internal class constructor
{
    public static void Main(string[] args)
    {
        //Student s1 = new Student();//default constructor
        //s1.showData();  
        //Student s2 = new Student();
        //s2.showData();
        //Student s3 = new Student();
        //s3.showData();
        //Student s4 = new Student(101, "John Doe");//parameterized constructor
        //s4.showData();
        //int x = 458;
        //string y = "Jane Smith";
        //Student s5 = new Student(x, y);
        //s5.showData();
        //Student s6 = new Student(s4);//copy constructor
        //s6.showData();
        //Student s7 = new Student();
        //s7.showData();
        Student[] s = new Student[2];
        for (int i = 0; i < s.Length; i++)
        {
            Console.WriteLine("Enter Roll No and Name for Student " + (i + 1));
            s[i] = new Student();
        }
        for (int i = 0; i < s.Length; i++)
        {
            Console.WriteLine("Details of Student " + (i + 1) + ":");
            s[i].showData();
        }
    }
}