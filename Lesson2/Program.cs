using System;

namespace Lesson2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Задание 1. Требуется реализовать класс двусвязного списка и операции вставки
                       //удаления и поиска элемента в нём в соответствии с интерфейсом.

            LinkedList linkedList = new();
           
            linkedList.AddNode(44);
            linkedList.AddNode(2);
            linkedList.AddNode(22);
            var newNode = linkedList.FindNode(2);
            linkedList.AddNodeAfter(newNode, 76);
            linkedList.AddNode(543);
            linkedList.AddNode(9);
            Console.WriteLine($"Общее кол-во элементов в списке {linkedList}: {linkedList.GetCount()}");
            Console.WriteLine();
            var nodeToRemove = linkedList.FindNode(22);
            linkedList.RemoveNode(nodeToRemove);
            linkedList.RemoveNodeByIndex(0);
            Console.WriteLine($"Общее кол-во элементов в списке {linkedList}: {linkedList.GetCount()}");
            Console.WriteLine();

            Console.WriteLine("LinkedList tests:");
            var testCaseNode1 = new TestCase() {LinkedList = linkedList, Expected = 22 };
            TestForFindNodeforError(testCaseNode1, linkedList);  //корректная работа данного метода доступна только если запускать в релизе...

            var testCaseNode2 = new TestCase() { LinkedList = linkedList, Expected = 76 };
            TestForFindNode(testCaseNode2, linkedList);

            var testCaseNode3 = new TestCase() { LinkedList = linkedList, Expected = 2 };
            TestForFindNode(testCaseNode3, linkedList);

            var testCaseNode4 = new TestCase() { LinkedList = linkedList, Expected = 300 };
            TestForAddNode(testCaseNode4, linkedList);

            var testCaseNode5 = new TestCase() { LinkedList = linkedList, Expected = 600 };
            TestForAddNodeAfter(testCaseNode5, linkedList);

            var testNodeSearch = linkedList.FindNode(76);
            var testCaseNode6 = new TestCase() { LinkedList = linkedList, ExpectedNode = testNodeSearch};
            TestForRemoveNode(testCaseNode6, linkedList);


            Console.WriteLine();
            //Задание 2. Написать функцию бинарного поиска, посчитать его асимптотическую сложность и проверить работоспособность функции.

            int[] myArray = { 5, 5, 23, 555, 323, 231, 423, 232 };
            Array.Sort(myArray);

            Console.WriteLine("BinarySearch tests:");
            var testCase1 = new TestCase() { MyArray = myArray, SearchValue = 23, Expected = 2 };
            TestBinarySearch(testCase1);
            var testCase2 = new TestCase() { MyArray = myArray, SearchValue = 1, Expected = -1 };
            TestBinarySearch(testCase2);
            var testCase3 = new TestCase() { MyArray = myArray, SearchValue = 3, Expected = 5 };
            TestBinarySearch(testCase3);
        }

        static int BinarySearch(int[] myArray, int searchValue)      // Сложность данного метода - O(N)
        {
            int min = 0;
            int max = myArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (searchValue == myArray[mid])
                {
                    return mid;
                }
                else if (searchValue < myArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
        static void TestBinarySearch(TestCase testCase)
        {
            try
            {
                var actual = BinarySearch(testCase.MyArray, testCase.SearchValue);

                if (actual == testCase.Expected)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch (Exception ex)
            {
                if (testCase.ExpectedException != null)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        static void TestForFindNode(TestCase testCase, LinkedList linkedList)
        {
            try
            {
                var actual = linkedList.FindNode(76).Value;
                

                if (actual == testCase.Expected)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Error while testing:  No such value - i.e. search return null");
            }
            catch (Exception ex)
            {
                if (testCase.ExpectedException != null)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        static void TestForFindNodeforError(TestCase testCase, LinkedList linkedList)
        {
            try
            {
                var actual = linkedList.FindNode(22).Value;


                if (actual == testCase.Expected)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Error while testing:  No such value - i.e. search return null");
            }
            catch (Exception ex)
            {
                if (testCase.ExpectedException != null)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        static void TestForAddNode(TestCase testCase, LinkedList linkedList)
        {
            try
            {
                linkedList.AddNode(300);
                var addedOrNot = linkedList.FindNode(300);
               

                if (addedOrNot.Value == testCase.Expected)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Error while testing:  No such value - i.e. search return null");
            }
            catch (Exception ex)
            {
                if (testCase.ExpectedException != null)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        static void TestForAddNodeAfter(TestCase testCase, LinkedList linkedList)
        {
            try
            {
                var newNode = linkedList.FindNode(76);
                linkedList.AddNodeAfter(newNode, 600);

                if (newNode.NextNode.Value == testCase.Expected)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Error while testing:  No such value - i.e. search return null");
            }
            catch (Exception ex)
            {
                if (testCase.ExpectedException != null)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        static void TestForRemoveNode(TestCase testCase, LinkedList linkedList)
        {
            try
            {
                var nodeToDelete = linkedList.FindNode(76);
                linkedList.RemoveNode(nodeToDelete);

                if (linkedList.FindNode(76) != testCase.ExpectedNode)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Error while testing:  No such value - i.e. search return null");
            }
            catch (Exception ex)
            {
                if (testCase.ExpectedException != null)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
 