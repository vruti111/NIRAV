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

        public double getSalary()
        {
            return salary;
        }
    }

    // ✅ New Time class
    public class Time
    {
        int hour;
        int min;
        int sec;

        public void setTime(int h, int m, int s)
        {
            hour = h;
            min = m;
            sec = s;
        }

        public void showTime()
        {
            Console.WriteLine("Time: {0:D2}:{1:D2}:{2:D2}", hour, min, sec);
        }
    }

    internal class ClassDemo1
    {
        public static void Main(string[] args)
        {
            // Employee comparison
            Employee e1 = new Employee();
            e1.getData(111, 10, "vvvv");

            Employee e2 = new Employee();
            e2.getData(222, 20, "bbbb");

            if (e1.getSalary() > e2.getSalary())
                e1.showData();
            else
                e2.showData();

            // Time display
            Time t = new Time();
            t.setTime(11, 28, 35);
            t.showTime();
        }
    }
}
// create time class with hour min sec member 
display the time 11:28:35 gie changes in thyis
//increment second = (print updated time )==> 