using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnionFiind;

namespace MainProgram.UnionFind
{
    public class QuickUnionTest
    {
        public static void Test()
        {
            Console.WriteLine("=======================QuickUnionTest");
            Console.WriteLine("Initialize to array with 10 elements");
            var quickUnion = new QuickUnion(10);

            Console.WriteLine("Before union: Connected(0, 2) : {0}", quickUnion.Connected(0, 2));
            Console.WriteLine();

            Console.WriteLine("Union(0,2)");
            quickUnion.Union(0, 2);
            Console.WriteLine("After union: Connected(0, 2) : {0}", quickUnion.Connected(0, 2));
            Console.WriteLine();

            Console.WriteLine("Union(3, 5)");
            quickUnion.Union(3, 5);
            Console.WriteLine("After union: Connected(3, 5) : {0}", quickUnion.Connected(3,5));
            Console.WriteLine();

            Console.WriteLine("Union(3, 0)");
            quickUnion.Union(3, 0);
            Console.WriteLine("After union: Connected(3, 0): {0}", quickUnion.Connected(3, 0));
            Console.WriteLine("After union: Connected(3, 9): {0}", quickUnion.Connected(3, 9));
            Console.WriteLine();
        }
    }
}
