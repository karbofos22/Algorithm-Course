using System;

namespace Lesson7_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //            1.Задача
            //Для прямоугольного поля размера M на N клеток, подсчитать количество путей из верхней левой клетки в правую нижнюю.
            //Известно что ходить можно только на одну клетку вправо или вниз.

            int[,] test = new int[3, 6];
            int i, j;
            for (j = 0; j < test.GetLength(1); j++)
                test[0, j] = 1; // Первая строка заполнена единицами
            for (i = 1; i < test.GetLength(0); i++)
            {
                test[i, 0] = 1;
                for (j = 1; j < test.GetLength(1); j++)
                {
                    if (test[i])
                    {

                    }
                    test[i, j] = test[i, j - 1] + test[i - 1, j];
                }
                  
            }

            Print2(test);


        }
        static void Print2(int[,] a)
        {
            int i, j;
            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                    Console.Write(a[i, j] + "\t");
                Console.Write("\r\n");
            }
        }


    }
}
