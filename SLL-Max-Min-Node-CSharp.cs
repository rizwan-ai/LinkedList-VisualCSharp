using System;

namespace SLL_Max_Min_Node_CSharp
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
        // Find Max value
        public int Max()
        {
            current = start;
            int max = current.Data;
            while(current != null)
            {
                if (current.Data > max)
                    max = current.Data;
                current = current.Next;
            }
            return max;
        }
        // Find Min value
        public int Min()
        {
            current = start;
            int min = current.Data;
            while (current != null)
            {
                if (current.Data < min)
                    min = current.Data;
                current = current.Next;
            }
            return min;
        }
    }
}
