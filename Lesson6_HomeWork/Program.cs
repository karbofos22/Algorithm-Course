using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Node v1 = new("V1"); //создать ноду v1
            Node v2 = new("V2");
            Node v3 = new("V3");
            Node v4 = new("V4");
            Node v5 = new("V5");
            Node v6 = new("V6");
            Node v7 = new("V7");
            Node v8 = new("V8");

            v1.Edges = new();   //список ребер
            v2.Edges = new();
            v3.Edges = new();
            v4.Edges = new();
            v5.Edges = new();
            v6.Edges = new();
            v7.Edges = new();
            v8.Edges = new();

            Edge v1Tov2 = new(v2, 32);  //создать новое ребро от v1 к v2, с весом 32 согласно нарисованному графу
            Edge v1Tov3 = new(v3, 95);  //создать новое ребро от v1 к v3, с весом 95 согласно нарисованному графу
            Edge v1Tov4 = new(v4, 75);
            Edge v1Tov5 = new(v5, 57);
            v1.Edges.Add(v1Tov2);       //добавить в список созданное ребро
            v1.Edges.Add(v1Tov3);
            v1.Edges.Add(v1Tov4);
            v1.Edges.Add(v1Tov5);

            Edge v2Tov1 = new(v1, 32);
            Edge v2Tov3 = new(v3, 5);
            Edge v2Tov5 = new(v5, 23);
            Edge v2Tov8 = new(v8, 16);
            v2.Edges.Add(v2Tov1);
            v2.Edges.Add(v2Tov3);
            v2.Edges.Add(v2Tov5);
            v2.Edges.Add(v2Tov8);

            Edge v3Tov1 = new(v1, 95);
            Edge v3Tov2 = new(v2, 5);
            Edge v3Tov4 = new(v4, 18);
            Edge v3Tov6 = new(v6, 6);
            v3.Edges.Add(v3Tov1);
            v3.Edges.Add(v3Tov2);
            v3.Edges.Add(v3Tov4);
            v3.Edges.Add(v3Tov6);

            Edge v4Tov1 = new(v1, 75);
            Edge v4Tov3 = new(v3, 18);
            Edge v4Tov5 = new(v5, 24);
            Edge v4Tov6 = new(v6, 9);
            v4.Edges.Add(v4Tov1);
            v4.Edges.Add(v4Tov3);
            v4.Edges.Add(v4Tov5);
            v4.Edges.Add(v4Tov6);

            Edge v5Tov1 = new(v1, 57);
            Edge v5Tov2 = new(v2, 23);
            Edge v5Tov4 = new(v4, 24);
            Edge v5Tov6 = new(v6, 11);
            Edge v5Tov7 = new(v7, 20);
            Edge v5Tov8 = new(v8, 94);
            v5.Edges.Add(v5Tov1);
            v5.Edges.Add(v5Tov2);
            v5.Edges.Add(v5Tov4);
            v5.Edges.Add(v5Tov6);
            v5.Edges.Add(v5Tov7);
            v5.Edges.Add(v5Tov8);

            Edge v6Tov3 = new(v3, 6);
            Edge v6Tov4 = new(v4, 9);
            Edge v6Tov5 = new(v5, 11);
            Edge v6Tov7 = new(v7, 7);
            v6.Edges.Add(v6Tov3);
            v6.Edges.Add(v6Tov4);
            v6.Edges.Add(v6Tov5);
            v6.Edges.Add(v6Tov7);

            Edge v7Tov5 = new(v5, 20);
            Edge v7Tov6 = new(v6, 7);
            Edge v7Tov8 = new(v8, 81);
            v7.Edges.Add(v7Tov5);
            v7.Edges.Add(v7Tov6);
            v7.Edges.Add(v7Tov8);

            Edge v8Tov2 = new(v2, 16);
            Edge v8Tov5 = new(v5, 94);
            Edge v8Tov7 = new(v7, 81);
            v8.Edges.Add(v8Tov2);
            v8.Edges.Add(v8Tov5);
            v8.Edges.Add(v8Tov7);

            //v1.PrintConnections(v1.Edges);
            //Console.WriteLine();
            //v2.PrintConnections(v2.Edges);
            //Console.WriteLine();
            //v3.PrintConnections(v3.Edges);
            //Console.WriteLine();
            //v4.PrintConnections(v4.Edges);
            //Console.WriteLine();
            //v5.PrintConnections(v5.Edges);
            //Console.WriteLine();
            //v6.PrintConnections(v6.Edges);
            //Console.WriteLine();
            //v7.PrintConnections(v7.Edges);
            //Console.WriteLine();
            //v8.PrintConnections(v8.Edges);

            
            List<int> route = new();

            for (int i = 0; i < v2.Edges.Count; i++)
            {
                route.Add(v2.Edges[i].Weight);
            }
            foreach (var item in route)
            {
                Console.WriteLine(item + " ");
            }


        }







    }
}


 