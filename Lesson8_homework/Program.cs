using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray myArray = new();

            myArray.EasyWayToSortArray(myArray.CreateArray());
            Console.WriteLine();

            //Задание 1.
            //Реализовать Bucketsort, проверить корректность работы.

            myArray.BucketSort(myArray.CreateArray());
            Console.WriteLine();

        }
    }
}
