using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VertLine : Figure
    {
       

        public VertLine (int yUp, int yDown, int x, char sym)
        {
            plist = new List<ClassPoint>();
            for (int y = yUp; y <= yDown; y++)
            {
                ClassPoint p = new ClassPoint(x, y, sym);
                plist.Add(p);

            }

        }

        
    }
}

