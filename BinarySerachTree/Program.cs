using System;
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

            BinarySearchTree<int> tree = new BinarySearchTree<int>(56);

            Console.WriteLine("Welcome to the Binary Search Problems:");
            while (true)
            {
                Console.WriteLine("Please select given options");
                Console.WriteLine("1.Insert value in BST\n" +
                    "2.Display\n" +
                    "3.GetSize" +
                    "4.SearchElement" +
                    "6.Exit\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        tree.Insert(30);
                        tree.Insert(70);
                        tree.Display();
                        //tree.GetSize();
                        Console.Write("\nPress any key to continue...... ");
                        break;
                    case 2:
                        tree.Display();
                        Console.Write("\nPress any key to continue...... ");
                        break;
                    case 3:
                        tree.GetSize();
                        Console.Write("\nPress any key to continue...... ");
                        break;
                    case 4:
                        Console.Write("Enter the element which you want to search: ");
                        int element = Convert.ToInt32(Console.ReadLine());
                        tree.IfExits(element, tree);
                        Console.Write("\nPress any key to continue...... ");
                        break;
                    case 6:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Please select only given options");
                        Console.Write("\nPress any key to continue...... ");
                        break;
                }
                Console.ReadLine();
            
            }
       
        }
    }
}

