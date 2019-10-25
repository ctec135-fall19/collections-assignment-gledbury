/*
Author: George Ledbury 
Date: 10/25/19
CTEC 135: Microsoft Software Development with C#
Module 5, Programming Assignment 4, Problem 3

            Dictionary

1. Region1  -Dictionary use
            -declare a dictionary and initialize it to create 3 entries:
             (1, "one"), (2, "two"), and (3, "three"). Use a combination of 
             initialization syntax, Add() and [] in your initialization code.
            -add an additional entry: (99, "ninety-nine")
            -show use of enumerator to see all entries. Print both the key
             and value
            -reassign the value of 99 to "99" using indexing notation
            -print the new value using indexing notation
            -remove the 2 item and enumerate over the whole dictionary to show 
             it's gone

*/





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            #region: 1 Dictionary use
            // declare a dictionary and initialize it to create 3 entries:
            //(1, "one"), (2, "two"), and(3, "three").Use a combination of
            //initialization syntax, Add() and[] in your initialization code.

            //declare
            Dictionary<int, string> myDictionary = new Dictionary
                <int, string>();
            // initialize
            myDictionary.Add(1, "one");
            myDictionary[2] = "two"; //another way to initialize
            myDictionary.Add(3, "three");

            // add an additional entry: (99, "ninety-nine")
            myDictionary[99] = "ninety-nine";

            // show use of enumerator to see all entries. Print both the key
            // and value
            Console.WriteLine();
            foreach( KeyValuePair<int, string> kvp in myDictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value);
            }
            Console.WriteLine();

            // reassign the value of 99 to "99" using indexing notation
            myDictionary[99] = "99";

            // print the new value using indexing notation
            Console.WriteLine("The new value of the 99 Key is: " + myDictionary[99] + "\n");

            // remove the 2 item and enumerate over the whole dictionary to show 
            // it's gone
            Console.WriteLine("Remove Key 2 and Value pair.\n");
            myDictionary.Remove(2);

            foreach (KeyValuePair<int, string> kvp in myDictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value);
            }
            Console.WriteLine();

            #endregion
        }
    }
}
