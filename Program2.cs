//   Linked-List - Implementation in Visual C#
//2: Insert a one Node at the beginning of a Singly-Linked-List

using System;
using static System.Console;
using static System.Convert;
//using LinkedList;

namespace SLL2_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList.SLL obj = new LinkedList.SLL();

            for (int i = 0; i < 2; i++)
            {
                Write($"Enter Name {i + 1} : ");
                string name = ReadLine();
                obj.InsertNodes(name);
                obj.DisplayNodes();
            }

            ReadKey(true);
        }
    }
}
