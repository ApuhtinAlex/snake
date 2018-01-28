using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizLine : Figure
    {
        

        public HorizLine(int xleft, int xRight, int y, char sym)
        {
            plist = new List<ClassPoint>();
            for (int x = xleft; x <= xRight; x++)
            {
                ClassPoint p = new ClassPoint(x, y, sym);
                plist.Add(p);

            }

        }

       
    }
}
