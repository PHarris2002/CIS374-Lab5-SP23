using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            UndirectedGraph undirectedGraph = new UndirectedGraph("../../../graphs/graph3.txt");

            Console.WriteLine(undirectedGraph);


            var startingNode = undirectedGraph.GetNodeByName("i");
            undirectedGraph.DFS(startingNode);
        }
    }
}
