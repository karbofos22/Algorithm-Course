using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;


namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }
    public class BechmarkClass
    {
        // Протестируйте разные методы расчёта дистанции
        // Обычный метод расчёта дистанции со ссылочным типом (PointClass — координаты типа float).
        // Обычный метод расчёта дистанции со значимым типом (PointStruct — координаты типа float).
        // Обычный метод расчёта дистанции со значимым типом (PointStruct — координаты типа double).
        // Метод расчёта дистанции без квадратного корня со значимым типом (PointStruct — координаты типа float).
        [Benchmark]
        public float TestPointDistanceStructFloat()
        {
            var pointOne = new PointStruct();
            var pointTwo = new PointStruct();
            pointOne.X = 2302323.2f;
            pointTwo.Y = 3232233.4f;
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((pointOne.X * pointOne.X) + (pointOne.Y * pointOne.Y));
        }
        [Benchmark]
        public float TestPointDistanceClassFloat()
        {
            var pointOne = new PointClass();
            var pointTwo = new PointClass();
            pointOne.X = 2302323.2f;
            pointTwo.Y = 3232233.4f;
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((pointOne.X * pointOne.X) + (pointOne.Y * pointOne.Y));
        }
        [Benchmark]
        public double TestPointDistanceStructDouble()
        {
            var pointOne = new PointStruct();
            var pointTwo = new PointStruct();
            pointOne.DX = 2302323.232;
            pointTwo.DY = 3232233.423;
            return Math.Sqrt((pointOne.DX * pointOne.DX) + (pointOne.DY * pointOne.DY));
        }
        [Benchmark]
        public float TestPointDistanceShortStructFloat()
        {
            var pointOne = new PointStruct();
            var pointTwo = new PointStruct();
            pointOne.X = 2302323.2f;
            pointTwo.Y = 3232233.4f;
            return (pointOne.X * pointOne.X) + (pointOne.Y * pointOne.Y);
        }
        [Benchmark]
        public void TestArrayAddSpeedClassFloat()
        {
            var point = new PointClass() { X = 42.4f, Y = 22.3f };
            var array = new PointClass[15];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = point;
            }
        }
        [Benchmark]
        public void TestArrayAddSpeedStructFloat()
        {
            var point = new PointStruct() { X = 42.4f, Y = 22.3f };
            var array = new PointStruct[15];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = point;
            }
        }
    }
}
