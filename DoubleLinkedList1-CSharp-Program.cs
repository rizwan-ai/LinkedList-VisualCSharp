using System;
using static System.Console;

namespace DLL1_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddLast(5);
            list.AddLast(10);
            list.AddLast(15);
            list.AddFirst(20);
            list.AddFirst(25);

            WriteLine($"List values are : {list.DisplayList()}");
            WriteLine($"Reverse List values are : {list.ReverseDisplayList()}");

            WriteLine($"Sum of Nodes is : {list.SumOfNodes()}");

            
            ReadKey(true);
        }
    }
}
