using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFiind
{
    public class QuickUnion : IUnionFind
    {
        private int[] id;

        public QuickUnion(int N)
        {
            id = new int[N];

            for (int i = 0; i < N; i++)
            {
                id[i] = i;
            }
        }

        public bool Connected(int p, int q)
        {
            var pRoot = FindRoot(p);
            var qRoot = FindRoot(q);

            return pRoot == qRoot;
        }

        public void Union(int p, int q)
        {
            var pRoot = FindRoot(p);
            var qRoot = FindRoot(q);

            id[pRoot] = qRoot;
        }

        private int FindRoot(int p)
        {
            var root = p;
            while (id[root] != root)
            {
                root = id[root];
            }
            return root;
        }
    }
}
