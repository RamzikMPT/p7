using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pw7
{
    public class Cursor
    {
        public int max, min, pos;
        public Cursor(int max, int min, int pos)
        {
            this.max = max;
            this.min = min;
            this.pos = pos;
        }
    }
}