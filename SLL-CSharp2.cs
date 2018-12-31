using System;
using static System.Console;

namespace LinkedList
{
    public class Node
    {
        public string name;   // or  public object Name { get; set; }
        public Node link;     //     public Node Link { get; set; }
    }
    public class SLL
    {
        private Node start;
        private Node temp;
        public SLL()          
        {
            start = null;
        }
        // Insertion in SLL
        public void InsertNodes(string _name)
        {
            temp = new Node();
            temp.name = _name;    // or temp = new Node {name = _name, link = start};
            temp.link = start;    //    ...
            start = temp;
        }
        // Traversing in SLL
        public void DisplayNodes()
        {
            temp = start;
            Write("List is : ");
            while (temp != null)
            {
                Write($"{temp.name} ");
                temp = temp.link;
            }
            WriteLine();
        }
    }
}

// Important Links  ...  Microsoft Visual C#.NET

// using System;                   using directive
// using static System.Console;    using static directive
// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using

// namespace 
// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/namespace
// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/namespaces/

// Classes (C# Programming Guide)
// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/classes

// Fields (C# Programming Guide)
// Properties (C# Programming Guide)
// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/fields
// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties

// Methods (C# Programming Guide)
// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods

// $ - string interpolation
// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated

// Constructors (C# Programming Guide)
// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors

// Pointer types (C# Programming Guide)
// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/unsafe-code-pointers/pointer-types
// 

// -> Operator (C# Reference)
// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/dereference-operator
// . Operator (C# Reference)
// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/member-access-operator


//..............................................................................


// C# - .NET Blog
// C# - The Visual Studio Blog
// https://blogs.msdn.microsoft.com/dotnet/tag/c/
// https://blogs.msdn.microsoft.com/visualstudio/tag/c/


// Get Started with C# and Visual Studio Code
// https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code


// C# 6 Programming with Visual Studio 2015
// by wrox 
// https://drive.google.com/file/d/1OCMtnjctkrdgCUAqrV5xR6lK31SWo0qj/view?usp=sharing


// Books on C# 
// https://www.microsoftpressstore.com/store/browse/programming/c-sharp
// C# Fundamentals for Absolute Beginners
// https://mva.microsoft.com/en-us/training-courses/c-fundamentals-for-absolute-beginners-16169?l=Lvld4EQIC_2706218949
// C# Courses
// https://mva.microsoft.com/training-topics/c-app-development#!jobf=Developer&lang=1033


// C# Guide
// https://docs.microsoft.com/en-us/dotnet/csharp/


// C# programming guide
// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/index


// C# Reference
// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/index
