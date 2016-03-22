using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnionFiind;

namespace MainProgram.UnionFind
{
    public class QuickFindTest
    {
        public static void TestQuickFind()
        {
            Console.WriteLine("=======================QuickFindTest");
            Console.WriteLine("Initialize to array with 10 elements");
            IUnionFind unionFind = new QuickFind(10);

            Console.WriteLine("Before union: Connected(0, 2) : {0}", unionFind.Connected(0, 2));

            Console.WriteLine("Union(0,2)");
            unionFind.Union(0, 2);
            Console.WriteLine("After union: Connected(0, 2): {0}", unionFind.Connected(0, 2));

            Console.WriteLine("Union(3, 0)");
            unionFind.Union(3, 0);
            Console.WriteLine("After union: Connected(3, 2): {0}", unionFind.Connected(3, 2));

            Console.WriteLine("array structure:");
            
        }

    }
}
