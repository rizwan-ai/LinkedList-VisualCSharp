//   Linked-List - Implementation in Visual C#
//1: Create a new Node in Singly-Linked-List

using System;
using static System.Console;
using static System.Convert;
using LinkedList;

namespace SLL1_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter Your Roll-No : ");
            int rollNo = ToInt32(ReadLine());
            Write("Enter Your Name : ");
            string name = ReadLine();

            SLL obj = new SLL(); ;
            obj.AddNewNode(rollNo, name);
            obj.DisplayNode();

            
            ReadKey(true);
        }
    }
}
