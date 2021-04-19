using System;

namespace Lesson1_Homework
{
    class Program
    {

        public class TestCase
        {
            public int X { get; set; }
            public bool Expected { get; set; }
            public int ExpectedFibo { get; set; }
            public Exception ExpectedException { get; set; }
        }

        static void Main(string[] args)
        {
            //Задание 1. Написать приложение согласно блок схеме и протестировать его

            //var testCase1 = new TestCase() { X = 5, Expected = true };
            //TestSimpleOrNot(testCase1);
            //var testCase2 = new TestCase() { X = 10, Expected = false };
            //TestSimpleOrNot(testCase2);
            //var testCase3 = new TestCase() { X = 2, Expected = false };
            //TestSimpleOrNot(testCase3);
            //var testCase4 = new TestCase() { X = 0, Expected = false };
            //TestSimpleOrNot(testCase4);
            //var testCase5 = new TestCase() { X = -5, Expected = false };
            //TestSimpleOrNot(testCase5);
            var testCase6 = new TestCase() { X = 22, ExpectedFibo = FibonachiCycle(22) };
            TestFibonachiCycle(testCase6);
            var testCase7 = new TestCase() { X = 76, ExpectedFibo = FibonachiCycle(22) };
            TestFibonachiCycle(testCase7);
            var testCase8 = new TestCase() { X = -3, ExpectedFibo = FibonachiCycle(22) };
            TestFibonachiCycle(testCase8);

            //Задание 2. Определить сложность функции
            //StrangeSum();  // -- сложность функции равняется O(F(N*N*N))

            //Задание 3. Определить сложность функции
            //Console.WriteLine(FibonachiRecurs(0));
            //Console.WriteLine(FibonachiCycle(22));
        }

        static bool SimpleOrNot(int x)
        {
            if (x == 0 || x < 0)
            {
                throw new ArgumentException("Введенное число 0 либо меньше нуля");

            }

            int d = 0;
            int i = 2;
            while (i < x)
            {
                if (x % i == 0)
                {
                    d++;
                    i++;
                }
                else
                    i++;
            }
            if (d == 0)
                return true;
            else
                return false;
        }
        static void TestSimpleOrNot(TestCase testCase)
        {
            try
            {
                var actual = SimpleOrNot(testCase.X);
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


        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                {
                    for (int k = 0; k < inputArray.Length; k++)
                    {
                        int y = 0;

                        if (j != 0)
                        {
                            y = k / j;
                        }
                        sum += inputArray[i] + i + k + j + y;
                    }
                }
            }
            return sum;
        }


        static int FibonachiRecurs(int fiboNumber)
        {
            if (fiboNumber < 0)
            {
                throw new ArgumentException("Введенное число меньше нуля");
            }
            if (fiboNumber == 0)
                return 0;
            if (fiboNumber == 1)
                return 1;
            return FibonachiRecurs(fiboNumber - 2) + FibonachiRecurs(fiboNumber - 1);
        }
        static int FibonachiCycle(int fiboNumber)
        {
            if (fiboNumber < 0)
            {
                throw new ArgumentException("Введенное число меньше нуля");
            }
            int finalFibo = 0;
            int fiboNumber1 = 1;
            int num;

            for (int i = 0; i < fiboNumber; i++)
            {
                num = finalFibo;
                finalFibo = fiboNumber1;
                fiboNumber1 += num;
            }

            return finalFibo;
        }
        static void TestFibonachiCycle(TestCase testCase)
        {
            try
            {
                var actual = FibonachiCycle(testCase.X);
                if (actual == testCase.ExpectedFibo)
                {
                    Console.WriteLine($"VALID TEST\tРезультат расчета введеного числа {testCase.X} - совпадет с расчетом ожидаемого {FibonachiCycle(22)} ");
                }
                else
                {
                    Console.WriteLine($"INVALID TEST\tРезультат расчета введеного числа {testCase.X} - НЕ совпадет с расчетом ожидаемого {FibonachiCycle(22)}");
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
    }
}
