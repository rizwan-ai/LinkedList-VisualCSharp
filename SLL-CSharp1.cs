using System;
using static System.Console;

namespace LinkedList
{
    public class Node           // Declare Node class type
    {
        public int roll_no;
        public string name;
        public Node next_link;  // Define field "next_link" Node type 
    }
    public class SLL            // Declare SLL class type
    {
        private Node start;
        // Define field "start"
        // that points to the class type object "Node"
        public SLL()            // Constructor 
        {
            start = null;
        }
        public void AddNewNode(int r, string n)
        {
            start = new Node();   // Node (Object) is created dynamically **
            start.roll_no = r;    // Operator . is uesd to access the field of Node type object
            start.name = n;
            start.next_link = null;
        }
        public void DisplayNode()
        {
            WriteLine("List is : ");
            Write($"{start.roll_no} , ");
            WriteLine(start.name);
        }
    }
}