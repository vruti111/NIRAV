using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIRAV

{
    public class Student29
    {
        int rlno;
        string name;
        string branch;
        static int sem = 5;
        int s1, s2, s3;
        double avg;

        public Student29(int rlno, string name, string branch, int s1, int s2, int s3)
        {
            this.rlno = rlno;
            this.name = name;
            this.branch = branch;
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
        }
        public void calAvg()
        {
            avg = (s1 + s2 + s3) / 3.0;
        }

        public double Avg
        {
            get { return avg; }                //read-only property
        }

        public void showDetail()
        {
            Console.WriteLine("Roll No: " + rlno);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Branch: " + branch);
            Console.WriteLine("Sem: " + sem);
            Console.WriteLine("Avg:" + avg);
        }
    }
    internal class StudentExe
    {
        public static void Main(string[] args)
        {
            Student1 s1 = new Student1(101, "Priya", "CE", 85, 90, 95);
            s1.calAvg();
            s1.showDetail();
            Console.WriteLine("-------------------");
            Student1 s2 = new Student1(102, "AAAA", "IT", 75, 80, 85);
            s2.calAvg();
            s2.showDetail();
            Console.WriteLine("-------------------");

            if (s1.Avg > s2.Avg)
            {
                s1.showDetail();
            }
            else
            {
                s2.showDetail();
            }
        }
    }
}