using System;

namespace SLL_SumOfNodes_CSharp
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
    }
    public class LinkedList
    {
        private Node start, temp, current;
        public LinkedList() => start = temp = current = null;
        // Insertion in SLL (Add Last)
        public void AddLast(int value)
        {
            // Create Node ...
            temp = new Node
            {
                Data = value,
                Next = null
            };

            if (start == null)
            {
                start = temp;
                return;
            }

            // Go to end of linked-list ...
            current = start;
            while (current.Next != null)
                current = current.Next;

            current.Next = temp;
        }
        // Traversing in SLL (Display Nodes)
        public string DisplayList()
        {
            string list = "";
            current = start;
            while(current != null)
            {
                list += current.Data + " ";
                current = current.Next;
            }
            return list;
        }
        // Traversing in SLL (Sum of Nodes)
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