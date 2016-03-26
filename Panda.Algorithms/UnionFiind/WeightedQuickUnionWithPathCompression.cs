using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFiind
{
    public class WeightedQuickUnionWithPathCompression : IUnionFind
    {
        private int[] id;
        private int[] size;

        public WeightedQuickUnionWithPathCompression(int N)
        {
            id = new int[N];
            size = new int[N];

            for (int i = 0; i < N; i++)
            {
                id[i] = i;
                size[i] = 1;
            }
        }

        public bool Connected(int p, int q)
        {
            return Root(p) == Root(q);
        }

        public void Union(int p, int q)
        {
            var pRoot = Root(p);
            var qRoot = Root(q);
            if (pRoot == qRoot) return;

            if (size[pRoot] > size[qRoot])
            {
                id[qRoot] = pRoot;
            }
        }

        private int Root(int p)
        {
            while (id[p] != p)
            {
                id[p] = id[id[p]];
                p = id[p];
            }

            return p;
        }
    }
}
