/*
Author: George Ledbury 
Date: 10/25/19
CTEC 135: Microsoft Software Development with C#
Module 5, Programming Assignment 4, Problem 4

            Linked List

1. Region1  -LinkedList use
            -Demonstrate use of constructor taking an IEnumerable object. 
             Create a string array having the first 5-10 words of your favorite
             nursery rhyme. Use it as the argument when constructing the 
             LinkedList object.
            -Print out the rhyme on a single line.
            -The traditional way to walk a linked list is to start at the head, 
             process the node, then set the node variable to the next node in 
             the list. Create a node variable and walk the list to print out 
             the values. The line printed should be the same as the one above.
            -Remove a word from the middle of the list. Print the list on a 
             single line to demonstrate this
            -Add the word back in and print the list again to demonstrate.

*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            // Demonstrate use of constructor taking an IEnumerable object. 
            //Create a string array having the first 5 - 10 words of your 
            //favorite nursery rhyme. Use it as the argument when 
            //constructing the LinkedList object.
            string[] nurseryRhyme = new string[5] { "Georgie", "Porgie",
            "Puddin", "and", "Pie"};

            // Linked List
            //LinkedListNode<string> lNode = new LinkedListNode<string>(nurseryRhyme);
            LinkedList<string> rhyme = new LinkedList<string>(nurseryRhyme);

            // Print out the rhyme on a single line.
            Console.WriteLine("Print each word in the array on a single line:\n");
            foreach(string word in nurseryRhyme)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nprint node by node on a single line:\n");
            LinkedListNode<string> node = rhyme.First;
            while(node != null)
            {
                Console.Write("{0} ", node.Value);
                node = node.Next;
            }
            Console.WriteLine();

            // Remove a word from the middle of the list. Print the list on a 
            // single line to demonstrate this

            //remove
            rhyme.Remove("Puddin");
            Console.WriteLine("\nremove the word 'Puddin' and reprint:\n");
            LinkedListNode<string> removeNode = rhyme.First;
            while (removeNode != null)
            {
                Console.Write("{0} ", removeNode.Value);
                removeNode = removeNode.Next;
            }
            Console.WriteLine();

            // Add the word back in and print the list again to demonstrate.
            LinkedListNode<string> addNode = rhyme.Find("Porgie");
            rhyme.AddAfter(addNode, "Puddin");
            Console.WriteLine("\nprint after adding 'Puddin' back in:\n");
            LinkedListNode<string> newAddNode = rhyme.First;
            while (newAddNode != null)
            {
                Console.Write("{0} ", newAddNode.Value);
                newAddNode = newAddNode.Next;
            }
            Console.WriteLine();


            #endregion

        }
        
        


    }
}
