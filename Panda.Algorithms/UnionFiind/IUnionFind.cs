using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFiind
{
    public interface IUnionFind
    {
        bool Connected(int p, int q);

        void Union(int p, int q);
    }
}
