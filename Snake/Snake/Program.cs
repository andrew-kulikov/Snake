using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake {
    class Program {
        static void Main(string[] args) {
            Point p1 = new Point(1, 1, '%');
            p1.Draw();
            Point p2 = new Point(7, 6, '#');
            p2.Draw();
            HorizontalLine line1 = new HorizontalLine(0, 15, 0, '+');
            line1.Draw();
            HorizontalLine line2 = new HorizontalLine(0, 15, 8, '+');
            line2.Draw();
        }
    }
}
