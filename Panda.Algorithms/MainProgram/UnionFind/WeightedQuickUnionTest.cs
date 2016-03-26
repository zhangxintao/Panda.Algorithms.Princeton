using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnionFiind;

namespace MainProgram.UnionFind
{
    public static class WeightedQuickUnionTest
    {
        public static void Test()
        {
            Console.WriteLine("=======================WeightedQuickUnionTest");
            Console.WriteLine("Initialize to 10 elements");
            var weightedQuickUnion = new WeightedQuickUnion(10);

            Console.WriteLine("Before union: Connected(0, 2) : {0}", weightedQuickUnion.Connected(0, 2));
            Console.WriteLine();

            Console.WriteLine("Union(2,0)");
            weightedQuickUnion.Union(2, 0);
            Console.WriteLine("After union:  Connected(0, 2) : {0}", weightedQuickUnion.Connected(0, 2));
            Console.WriteLine();

            Console.WriteLine("Union(3,2)");
            weightedQuickUnion.Union(3, 2);
            Console.WriteLine("After union: Connected(3, 0): {0}", weightedQuickUnion.Connected(3, 0));
            Console.WriteLine();

            Console.WriteLine("Union(5, 6)");
            weightedQuickUnion.Union(5, 6);
            Console.WriteLine("Union(5, 3)");
            weightedQuickUnion.Union(5, 3);
            Console.WriteLine("Connected(6, 0): {0}", weightedQuickUnion.Connected(6, 0));
        }
    }
}
