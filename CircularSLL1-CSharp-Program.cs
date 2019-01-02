using System;
using static System.Console;
using static System.Convert;

namespace CSLL1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            Write("Enter Total Number of Nodes : ");
            int n = ToInt32(ReadLine());
            for (int i = 0; i < n; i++)
            {
                WriteLine($"Enter Record {i + 1}");

                Write("Enter Roll-No : ");
                int rollNo = ToInt32(ReadLine());
                Write("Enter Name : ");
                string name = ReadLine();
                Write("Enter Degree : ");
                string degree = ReadLine();
                Write("Enter CGPA : ");
                double cgpa = ToDouble(ReadLine());

                list.InsertNode(rollNo, name, degree, cgpa);
            }

            WriteLine("Display Records of Students");
            WriteLine(list.DisplayList());

            ReadKey(true);
        }
    }
}
