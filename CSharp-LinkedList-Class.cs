// C# LinkedList<T> Class
// Represents a doubly linked list
// T - Specifies the element type of the linked-list
// Example - Friendship Linked-List

using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace LinkedList
{
    class Program
    {
        public static void Display(LinkedList<string> myList)
        {
            foreach (var item in myList)
            {
                Write($"{item} ");
            }
            WriteLine("\n");
        }
        static void Main(string[] args)
        {
            string[] names = {"Ahmad", "Bilal", "Khalil", "Kamal"};

            // Create the linked-list
            LinkedList<string> list = new LinkedList<string>(names);
            WriteLine("The linked list names ...");
            Display(list);

            // Add the name 'Rizwan' to the beginning of the linked-list
            list.AddFirst("Rizwan");
            WriteLine("List 1: Add 'Rizwan' to beginning of the list ...");
            Display(list);

            // Move the first node to be the last node
            LinkedListNode<string> node1 = list.First;
            list.RemoveFirst();
            list.AddLast(node1);
            WriteLine("List 2: Move first node to be last node ...");
            Display(list);

            // Change the last node to 'Anayat'
            list.RemoveLast();
            list.AddLast("Anayat");
            WriteLine("List 3: Change the last node to 'Anayat' ...");
            Display(list);

            // Move the last node to be the first node
            LinkedListNode<string> node2 = list.Last;
            list.RemoveLast();
            list.AddFirst(node2);
            WriteLine("List 4: Move last node to be first node ...");
            Display(list);

            // LinkedList Methods ..................
            // AddFirst()
            // AddLast()
            // RemoveFirst()
            // RemoveLast()
            // LinkedList Properties ..................
            // First
            // Last

            //...........

            // Add a node 'Rizwan' before the 'Khalil'
            LinkedListNode<string> node3 = list.Find("Khalil");
            list.AddBefore(node3, "Rizwan");
            WriteLine("List 5: Add a node 'Rizwan' before the 'Khalil' ...");
            Display(list);

            // Add nodes 'Faizan' and 'Haris' after the 'Kamal'
            LinkedListNode<string> node4 = list.Find("Kamal");
            list.AddAfter(node4, "Haris");
            list.AddAfter(node4, "Faizan");
            WriteLine("List 6: Add nodes 'Faizan' and 'Haris' after the 'Kamal' ...");
            Display(list);

            // Current node 'Rizwan',
            // and to the previous node & next node in the list.
            LinkedListNode<string> current = list.Find("Rizwan");
            LinkedListNode<string> previous = current.Previous;
            LinkedListNode<string> next = current.Next;
            WriteLine($"Previous Node {previous.Value}, Current Node {current.Value}, Next Node {next.Value}");

            // Total Nodes in the list  
            WriteLine($"\nTotal Friends : {list.Count}\n");
            
            WriteLine("Friend List <3");
            var friends = from d in list
                          orderby d ascending
                          select d;

            foreach (var friend in friends)
            {
                WriteLine(friend);
            }

            // LinkedList Methods ..................
            // Find()
            // AddBefore()
            // AddAfter()
            // LinkedList Property ..................
            // Count
            // LinkedListNode Properties ..................
            // Next
            // Previous
            // Value
            // LINQ Query - orderby clause .....................

            ReadKey(true);
        }
    }
}
