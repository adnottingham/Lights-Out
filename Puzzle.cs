using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightsOut
{
    class Puzzle
    {
        Tuple<int, int>[] p;
        int next = 0;
        int addCount = 0;

        public Puzzle(int size)
        {
            p = new Tuple<int, int>[size];
        }

        public Tuple<int, int> getNext()
        {
            next++;
            return p[next - 1];
        }

        public void addLight(int r, int c)
        {
            p[addCount] = Tuple.Create(r, c);
            addCount++;
        }
        public void restart()
        {
            next = 0;
        }

    }
}
