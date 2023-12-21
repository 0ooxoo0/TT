using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var graph = new Graph();

            var v1 = new Vertex(1);
            var v2 = new Vertex(2);
            var v3 = new Vertex(3);
            var v4 = new Vertex(4);
            var v5 = new Vertex(5);
            var v6 = new Vertex(6);

            graph.AddVertex(v1);
            graph.AddVertex(v2);
            graph.AddVertex(v3);
            graph.AddVertex(v4);
            graph.AddVertex(v5);
            graph.AddVertex(v6);

            graph.AddEdge(v1, v2);
            graph.AddEdge(v2, v3);
            graph.AddEdge(v2, v4);
            graph.AddEdge(v2, v6);
            graph.AddEdge(v3, v2);
            graph.AddEdge(v3, v4);
            graph.AddEdge(v3, v5);
            graph.AddEdge(v4, v2);
            graph.AddEdge(v4, v3);
            graph.AddEdge(v4, v5);
            graph.AddEdge(v4, v6);
            graph.AddEdge(v5, v3);
            graph.AddEdge(v5, v4);
            graph.AddEdge(v5, v6);
            graph.AddEdge(v6, v2);
            graph.AddEdge(v6, v4);
            graph.AddEdge(v6, v5);

            GetMatrix(graph);

            Console.WriteLine();
            Console.WriteLine();

            GetVariants(graph);
            Console.ReadLine();
        }

        private static void GetVariants(Graph graph)
        {
            int final = 5;
            var matrix = graph.GetMatrix();
            int perelet = 0;
            for (int i = 0; i < graph.VertexCount;)
            {
                if(perelet!= 0)
                {
                    i = perelet;
                }
                for (int j = graph.VertexCount-1; j > 0; j--)
                {
                    if (matrix[i, j] == 1)
                    {
                        if (i == final)
                        {
                            Console.Write(i+1);
                            return;
                        }
                        perelet = j;
                        Console.Write(i+1 + " => ");
                        break;
                    }
                }
                if (perelet == 0)
                {
                    i++;
                }
            }
        }
           
        private static void GetMatrix(Graph graph)
        {
            var matrix = graph.GetMatrix();
            for (int i = 0; i < graph.VertexCount; i++)
            {
                Console.Write(i + 1);
                for (int j = 0; j < graph.VertexCount; j++)
                {
                    Console.Write(" | " + matrix[i, j] + " | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("_________________________________________________");
            Console.Write(" ");
            for (int i = 0; i < graph.VertexCount; i++)
            {
                Console.Write($" | {i + 1} | ");
            }
        }   
    }
}
