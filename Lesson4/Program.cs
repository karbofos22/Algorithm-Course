using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            //BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);

            //2.Реализуйте двоичное дерево и метод вывода его в консоль
            //Реализуйте класс двоичного дерева поиска с операциями вставки, удаления, поиска. 
            //Дерево должно быть сбалансированным(это требование не обязательно). 
            //Также напишите метод вывода в консоль дерева, чтобы увидеть, насколько корректно работает ваша реализация. 

            Tree tree = new();

            tree.AddItem(22);
            tree.AddItem(45);
            tree.AddItem(4);
            tree.AddItem(99);
            tree.AddItem(6);
            tree.AddItem(1);
            tree.AddItem(33);
            tree.AddItem(100);
            tree.AddItem(5);

            Console.WriteLine("Дерево элементов");
            tree.Print(tree.GetRoot(), 0, 2);
            Console.WriteLine("\n");

            TreeNode nodeToFound = tree.GetNodeByValue(tree.GetRoot(), 22);
            tree.RemoveItem(nodeToFound);
            Console.WriteLine($"Изменение дерева после удаления элемента {nodeToFound.Value}");
            tree.Print(tree.GetRoot(), 0, 14);
            Console.WriteLine("\n");

            tree.AddItem(50);
            tree.AddItem(8);
            Console.WriteLine("Добавили элементы 50 и 8");
            tree.Print(tree.GetRoot(), 0, 26);
            Console.WriteLine("\n");

            TreeNode nodeToFound1 = tree.GetNodeByValue(tree.GetRoot(), 45);
            tree.RemoveItem(nodeToFound1);
            Console.WriteLine($"Изменение дерева после удаления элемента {nodeToFound1.Value}");
            tree.Print(tree.GetRoot(), 0, 40);
            Console.WriteLine("\n");

            TreeNode nodeToFound2 = tree.GetNodeByValue(tree.GetRoot(), 4);
            tree.RemoveItem(nodeToFound2);
            Console.WriteLine($"Изменение дерева после удаления элемента {nodeToFound2.Value}");
            tree.Print(tree.GetRoot(), 0, 54);
            Console.WriteLine("\n");
        }
        
    }
    //1.Протестируйте поиск строки в HashSet и в массиве
    //Заполните массив и HashSet случайными строками, не менее 10 000 строк.Строки можно сгенерировать.
    //Потом выполните замер производительности проверки наличия строки в массиве и HashSet.Выложите код и результат замеров.

    //public class BechmarkClass
    //{
    //    [Benchmark]
    //    public bool TestHashSearch()
    //    {
    //        var randomArray = new Strings();
    //        var hashSet = new HashSet<HashSetThing>();
    //        var testStringForHash = new HashSetThing() { RandomString = "TESTSTRING" };

    //        for (int i = 0; i < 15000; i++)
    //        {
    //            var wordToAdd = new HashSetThing() { RandomString = randomArray.StringGenerator() };
    //            hashSet.Add(wordToAdd);

    //            if (hashSet.Count == 2000)
    //            {
    //                hashSet.Add(testStringForHash);
    //            }
    //        }
    //        var searchString = new HashSetThing() { RandomString = "TESTSTRING" };
    //        if (hashSet.Contains(testStringForHash) == hashSet.Contains(searchString))
    //        {
    //            return true;
    //        }
    //        else
    //        {
    //            return false;
    //        }
    //    }

    //    [Benchmark]
    //    public bool TestArraySearch()
    //    {
    //        var randomArray = new Strings();
    //        string[] array = randomArray.CreateArray();
    //        string testString = "TESTSTRING";
    //        array[2000] = testString;

    //        foreach (var data in array)
    //        {
    //            if (testString == data)
    //                return true;
    //        }
    //        return false;
    //    }
    //}
}

