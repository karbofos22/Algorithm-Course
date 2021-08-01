using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_homework
{
    public class MyArray
    {
        public int[] CreateArray()
        {
            Random random = new();

            int[] arrayForHoarsr = new int[10];
            for (int i = 0; i < arrayForHoarsr.Length; i++)
            {
                arrayForHoarsr[i] = random.Next(100);
            }
            return arrayForHoarsr;
        }
        public void EasyWayToSortArray(int[] arrayForHoarsr)
        {
            Console.WriteLine("Input Array:");
            foreach (var item in arrayForHoarsr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Array.Sort(arrayForHoarsr);
            Console.WriteLine();

            Console.WriteLine("EasyWay Sorted input Array:");
            foreach (var item in arrayForHoarsr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public void BucketSort(int[] array)
        {
            Console.WriteLine("Input Array:");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            int numOfBuckets = 10;
            List<int>[] buckets = new List<int>[numOfBuckets];

            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<int>();
            }
            // 2) Put array elements in different buckets
            for (int i = 0; i < array.Length; i++)
            {
                int bucket = array[i] / numOfBuckets;
                buckets[bucket].Add(array[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                buckets[i].Sort();
            }
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    array[index++] = buckets[i][j];
                }
            }
            Console.WriteLine();
            Console.WriteLine("BuckedSorted input Array:");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}
