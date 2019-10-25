/*
Author: George Ledbury 
Date: 10/25/19
CTEC 135: Microsoft Software Development with C#
Module 5, Programming Assignment 4, Problem 1

            Arrays and Lists

1. Region1  -Simple Array
            -Create an array of int of size 5
            -use a for loop to initialize it to the numbers 11-15
            -use a foreach loop to print out the values in the array.

2. Region2  -List<T>
            -Create a list of int
            -Use a for loop to initialize the list to the nums 21-25
            -use a foreach loop to print out the values in the list
            -update the values in the list to 31-35 using indexing
            -repeat the print using a for loop and indexing
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1_Arrays_and_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            #region:1 *Simple Array
            // create an array of int with the size of 5
            int[] simpleArray = new int[5];

            // for loop to initialize it to the values 11-15
            for(int i=0; i < simpleArray.Length; i++)
            {
                simpleArray[i] = i + 11;
            }

            int[] a2 = { 1, 2, 3, 4, 5 };

            // foreach loop for traversal
            Console.WriteLine("\nThe values in the array are:");
            foreach(int element in simpleArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            #endregion

            #region:2 List<T>
            // create a List<int> 
            List<int> listExample = new List<int>() { 1, 2, 3, 4, 5 };

            // Use a for loop to initialize the list to the nums 21-25
            for(int i = 0; i < listExample.Count; i++)
            {
                listExample[i] = (i + 11) + 10;
            }

            // use a foreach loop to print out the values in the list
            Console.WriteLine("The values in the list are:");
            foreach(int element in listExample)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            // update the values in the list to 31-35 using indexing
            listExample.Clear();
            listExample.Insert(0, 31);
            listExample.Insert(1, 32);
            listExample.Insert(2, 33);
            listExample.Insert(3, 34);
            listExample.Insert(4, 35);
            

            Console.WriteLine("The updated values in the list are:");
            foreach (int element in listExample)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            #endregion
        }
    }
}
