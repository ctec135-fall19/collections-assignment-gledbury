
/*
Author: George Ledbury 
Date: 10/25/19
CTEC 135: Microsoft Software Development with C#
Module 5, Programming Assignment 4, Problem 2

            Stacks and Queues

1. Region1  -Stack
            -declare and initialize a stack with the numbers 1 - 5
             using initialization syntax.
            -demonstrate use of the enumerator to print out the members
             in the stack, i.e. write a foreach loop
            -print a peek at the top member in the stack
            -write a loop that pops the elements off of the stack and 
             prints each

2. Region2  -Queue
            -declare a queue
            -initialize the queue with the numbers 1-5 using a for loop.
            -demonstrate use of the enumerator to print out the members 
             in the queue, i.e. write a foreach loop
            -print a peek at the top member in the stack
            -write a loop that dequeues the elements from the stack and 
             prints each
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2_Stacks_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            #region: 1 Stack
            // declare and initialize a stack with the numbers 1 - 5
            Stack<int> myInts = new Stack<int>();

            // push objects onto stack
            myInts.Push(1);
            myInts.Push(2);
            myInts.Push(3);
            myInts.Push(4); 
            myInts.Push(5);
            //demonstrate use of the enumerator to print out the members
            //in the stack, i.e.write a foreach loop
            Console.WriteLine("The numbers in the stack are:");
            foreach (var num in myInts)
            {
                Console.WriteLine(num);
            }

            // print a peak at the top number in the stack
            Console.WriteLine();
            Console.WriteLine("The number at the top of the stack is: "
                + myInts.Peek());
            Console.WriteLine();

            //write a loop that pops the elements off of the stack and 
            //prints each
            int size = myInts.Count;
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Pop off this number: {0}", myInts.Pop());
                Console.WriteLine("There are now {0} elements in the stack\n"
                    , myInts.Count());
            }
            Console.WriteLine();
            Console.WriteLine("We have popped all the numbers from the stack.");
            Console.WriteLine();
            #endregion 1

            #region: 2 Queue
            // declare a queu
            Queue<int> myQueue = new Queue<int>();

            // use a for loop to initialize the Queue with nums 1-5
            for (int i = 1; i < 6; i++)
            {
                myQueue.Enqueue(i);
            }
            Console.WriteLine("The numbers in the queue are:");

            // use a foreach loop to print out the numbers in the queue
            foreach(int value in myQueue)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();

            // peek at the top number in the stack and print it
            Console.WriteLine("The top number in the stack is: {0}\n", myQueue.Peek());

            // write a loop that dequeues the elements from the stack and 
            // prints each
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("DeQueuing: {0}", myQueue.Dequeue());
                Console.WriteLine();
            }
            Console.WriteLine("There are no numbers left in the queue!", myQueue);

            #endregion 2

        }
    }
}
