// C# code to illustrate the Stack.Peek Method 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackTop
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creating a Stack 
           // Stack myStack = new Stack();
            Stack<string> myStack = new Stack<string>();

            // Inserting the elements into the Stack 
            myStack.Push("1st Element");
            myStack.Push("2nd Element");
            myStack.Push("3rd Element");
            myStack.Push("4th Element");
            myStack.Push("5th Element");
            myStack.Push("6th Element");

            // Displaying the count of elements 
            // contained in the Stack 
            Console.Write("Total number of elements" +
                             " in the Stack are : ");

            Console.WriteLine(myStack.Count);

            // Displaying the top element of Stack 
            // without removing it from the Stack 
            Console.WriteLine("Element at the top is : "
                                      + myStack.Peek());

            // Displaying the top element of Stack 
            // without removing it from the Stack 
            Console.WriteLine("Element at the top is : "
                                    + myStack.Peek());

            // Displaying the count of elements 
            // contained in the Stack 
            Console.Write("Total number of elements " +
                               "in the Stack are : ");

            Console.WriteLine(myStack.Count);
        }
    }
}