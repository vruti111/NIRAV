using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIRAV;

class Student1
{
    int rlno;
    string name;

}
class Student1(int r, string n)  // Parameterized Constructor
{
    rlno = r;
    name = n;
}
public void showData()
    {
        Console.WriteLine("Roll no. is : " + rlno);
        Console.WriteLine("Name is : " + name);
    }
internal class Parameter_Constructor
{
    public static void Main(string[] args)
    {
        Student1 s1 = new Student1(35, "Ayushi");  // Constructor is called here.
        s1.showData(); // This will call the method to display student data.
        Console.WriteLine("");
    }
}

