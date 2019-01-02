// Circularly Linked-List

using System;

namespace CSLL1
{
    public class Node
    {
        public int roll_no;
        public string name;
        public string degree;
        public double cgpa;
        public Node link;
    }
    public class LinkedList
    {
        private Node start, temp, current;
        public LinkedList()
        {
            start = temp = current = null;
        }
        // Insertion in CSLL (Insert Node)
        public void InsertNode(int _rollNo, string _name, string _degree, double _cgpa)
        {
            // Create Node ...
            temp = new Node();
            temp.roll_no = _rollNo;
            temp.name = _name;
            temp.degree = _degree;
            temp.cgpa = _cgpa;

            if(start == null)
            {
                start = temp;
                temp.link = start;  // * Assign the address of starting node in the pointer field of last node ...
                return;
            }

            // Go to end of linked-list ...
            current = start;
            while (current.link != start)
                current = current.link;

            current.link = temp;
            temp.link = start;      // * Assign the address of starting node in the pointer field of last node ...
        }
        // Traversing in CSLL (Display List)
        public string DisplayList()
        {
            string list = "";
            if (start == null)
            {
                list += "List is Empty!";
                return list;
            }
            current = start;
            do
            {
                list += $"RollNo: {current.roll_no} - Name: {current.name} - Degree: {current.degree} - CGPA: {current.cgpa}\n";
                current = current.link;
            } while (current != start);
            return list;
        }
    }
}
