using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign0307
{
    class Ball
    {
        private int size;
        private Color color;
        private int numThrows;

        public Ball(int size, Color color)
        {
            this.size = size;
            this.color = color;
            numThrows = 0;
        }

        public void Pop()
        {
            size = 0;
        }

        public void Throw()
        {
            if (size != 0)
            {
                numThrows++;
            }
        }

        public int getNumThrows()
        {
            return numThrows;
        }
    }
}
