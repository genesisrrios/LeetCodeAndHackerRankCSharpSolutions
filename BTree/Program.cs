using System;
using System.Collections.Generic;
using System.Linq;

namespace BTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new BTreeSolutions();
            var node = solution.GetNode();
            var list = solution.LevelOrderTraversal(node);
            foreach(var list2 in list)
            {
                Console.Write("[");
                foreach(var number in list2)
                {
                    Console.Write(number);
                }
                Console.Write("]");
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
