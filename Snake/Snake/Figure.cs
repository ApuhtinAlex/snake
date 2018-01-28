using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<ClassPoint> plist;

        public void Drow()
        {
            foreach (ClassPoint p in plist)
            {
                p.Draw();
            }
        }
    }
}
