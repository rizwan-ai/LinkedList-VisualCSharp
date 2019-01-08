using System;

namespace DLL1_CSharp
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }
    }
    public class LinkedList
    {
        private Node start, temp, current;
        public LinkedList() => start = temp = current = null;
  
        // Insertion in DLL (Add Last)
        public void AddLast(int value)
        {
            // Create Node & assign data to it ...
            temp = new Node();
            temp.Previous = null;
            temp.Data = value;
            temp.Next = null;
            if(start == null)
            {
                start = temp;
                return;
            }

            // Go to end of linked-list ...
            current = start;
            while (current.Next != null)
                current = current.Next;

            temp.Previous = current;   // **
            current.Next = temp;
        }
        // Insertion in DLL (Add First)
        public void AddFirst(int value)
        {
            // Create Node & assign data to it ...
            temp = new Node();
            temp.Previous = null;
            temp.Data = value;
            temp.Next = null;
            if (start == null)
            {
                start = temp;
                return;
            }

            start.Previous = temp;
            temp.Next = start;
            start = temp;
        }
        // Traversing in DLL (Display List)
        public string DisplayList()
        {
            string list = "";
            if (start == null)
            {
                list += "List is Empty!";
                return list;
            }
            current = start;
            // Forward Traversing
            while (current != null)
            {
                list += current.Data + " ";
                current = current.Next;
            }
            return list;
        }
        // Reverse Traversing in DLL (Reverse Display List)
        public string ReverseDisplayList()
        {
            string list = "";
            if (start == null)
            {
                list += "List is Empty!";
                return list;
            }
            // Go to end of linked-list ...
            current = start;
            while (current.Next != null)
                current = current.Next;

            // Reverse Traversing
            while (current != null)
            {
                list += current.Data + " ";
                current = current.Previous;
            }

            return list;
        }
        // Traversing in DLL (Sum of Nodes)
        public int SumOfNodes()
        {
            int sum = 0;
            current = start;
            while (current != null)
            {
                sum += current.Data;
                current = current.Next;
            }
            return sum;
        }
    }
}