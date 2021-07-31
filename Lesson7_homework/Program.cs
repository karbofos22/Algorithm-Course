using System;
using System.Linq;


namespace Lesson7_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Задача
            //Для прямоугольного поля размера M на N клеток, подсчитать количество путей из верхней левой клетки в правую нижнюю.
            //Известно что ходить можно только на одну клетку вправо или вниз.

            int[,] test = new int[3, 6];
            int i, j;
            int ways = 0;
            
            for (j = 0; j < test.GetLength(1); j++)
                test[0, j] = 1; 
            for (i = 1; i < test.GetLength(0); i++)
            {
                test[i, 0] = 1;
                
                for (j = 1; j < test.GetLength(1); j++)
                {
                    test[i, j] = test[i, j - 1] + test[i - 1, j];
                }
            }
            foreach (int item in test)
            {
                ways = ways < item ? item : ways;
            }

            PrintArray(test);
            Console.WriteLine($"Кол-во маршрутов из верхней левой клетки в правую нижнюю равно {ways}");
        }
        static void PrintArray(int[,] num)
        {
            int i, j;
            for (i = 0; i < num.GetLength(0); i++)
            {
                for (j = 0; j < num.GetLength(1); j++)
                    Console.Write(num[i, j] + "\t");
                Console.Write("\r\n");
            }
        }


    }
}
