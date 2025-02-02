﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Tree Problem!");

            BinaryTree<int> binarySearch = new BinaryTree<int>(56);

            //Add Elements
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            binarySearch.Insert(22);
            binarySearch.Insert(40);
            binarySearch.Insert(60);
            binarySearch.Insert(95);
            binarySearch.Insert(11);
            binarySearch.Insert(65);
            binarySearch.Insert(3);
            binarySearch.Insert(16);
            binarySearch.Insert(63);
            binarySearch.Insert(67);
            binarySearch.Display();

            //Get the size of the tree
            binarySearch.GetSize();

            // Finding the element
            bool result = binarySearch.IfExists(63, binarySearch);
            Console.ReadLine();

           
        }
    }
}
