using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_HomeWork
{
    public class Node //Вершина
    {
        public string Name { get; set; }
        public override string ToString() => Name;
        public List<Edge> Edges { get; set; } //исходящие связи

        public Node(string name)
        {
            this.Name = name;
        }


        public void PrintConnections(List<Edge> Edges)
        {
            foreach (var item in Edges)
            {
                Console.WriteLine($"{Name} reffers to {item.Node.Name}, weight {item.Weight}");
            }
        }
    }

    public class Edge //Ребро
    {
       
        public int Weight { get; set; } //вес связи
        public Node Node { get; set; } // узел, на который связь ссылается
        public override string ToString() => Node.Name;

        public Edge(Node node, int weight)
        {
            this.Node = node;
            this.Weight = weight;
        }
    }
}
