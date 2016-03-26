using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFiind
{
    public class WeightedQuickUnion : IUnionFind
    {
        private int[] id;
        private int[] size;

        public WeightedQuickUnion(int N)
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

            var pRootSize = size[pRoot];
            var qRootSize = size[qRoot];

            if (pRootSize > qRootSize)
            {
                id[qRoot] = pRoot;
                size[pRoot] += size[qRoot];
            }
            else
            {
                id[pRoot] = qRoot;
                size[qRoot] += size[pRoot];
            }
        }

        private int Root(int p)
        {
            while (id[p] != p)
            {
                p = id[p];
            }

            return p;
        }
    }
}
