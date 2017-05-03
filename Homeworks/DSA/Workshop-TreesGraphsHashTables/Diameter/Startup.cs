using System;
using System.Collections.Generic;
using System.Linq;

namespace Diameter
{
    internal class Startup
    {
        internal static void Main()
        {
            var nodesCount = int.Parse(Console.ReadLine());
            var edges = new List<Edge>();
            for (int i = 0; i < nodesCount - 1; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                var currentEdge = new Edge(input[0], input[1], input[2]);
                edges.Add(currentEdge);
            }

            var nodes = edges.Select(e => e.FirstNode).ToList();
            nodes.AddRange(edges.Select(e => e.SecondNode).ToList());
            var startNodes = nodes
                .GroupBy(i => i)
                .Where(g => g.Count() == 1)
                .Select(g => g.Key)
                .ToList();


        }
    }

    public class Edge
    {
        public Edge(int firstNode, int secondNode, int value)
        {
            this.FirstNode = firstNode;
            this.SecondNode = secondNode;
            this.Value = value;
        }

        public int FirstNode { get; set; }

        public int SecondNode { get; set; }

        public int Value { get; set; }
    }
}
