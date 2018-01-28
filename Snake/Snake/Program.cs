using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

          
            ClassPoint p1 = new ClassPoint(4,5,'#');
            p1.Draw();


            // рисуем рамку

            HorizLine upline = new HorizLine(0, 78, 0, '+');
            upline.Drow();
            HorizLine downline = new HorizLine(0, 78, 24, '+');
            downline.Drow();



            VertLine leftline = new VertLine(0, 24, 0, '+');
            leftline.Drow();
            VertLine rightline = new VertLine(0, 24, 78, '+');
            rightline.Drow();

            Console.ReadLine();
        }

    }
}
