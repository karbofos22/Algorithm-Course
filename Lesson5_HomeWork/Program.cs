using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new();

            tree.AddItem(22);
            tree.AddItem(45);
            tree.AddItem(4);
            tree.AddItem(99);
            tree.AddItem(6);
            tree.AddItem(1);
            tree.AddItem(33);



            Console.WriteLine("Дерево элементов");
            tree.Print(tree.GetRoot(), 0, 2);
            Console.WriteLine("\n");

            var root = tree.GetRoot();
            Console.WriteLine("BFS");
            tree.QueueSearch(root, 6);
            Console.WriteLine();
            Console.WriteLine("BFS");
            tree.QueueSearch(root, 13);
            Console.WriteLine();
            Console.WriteLine("DFS");
            tree.StackSearch(root, 99);
            Console.WriteLine();
            Console.WriteLine("DFS");
            tree.StackSearch(root, 13);
        }
    }
    
}

