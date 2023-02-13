﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BinarySerachTree
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
            binarySearchTree.InsertData(56);
            binarySearchTree.InsertData(30);
            binarySearchTree.InsertData(70);
            binarySearchTree.Display(binarySearchTree.GetRoot());
            Console.WriteLine("Count Of Element in Binary Search Tree is : " + binarySearchTree.GetSize());


            Console.ReadLine();
        }
    }
}
