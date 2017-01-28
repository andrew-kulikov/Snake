using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake {
    class HorizontalLine {
        public List<Point> pList;
        public HorizontalLine(int x1, int x2, int y, char sym) {
            pList = new List<Point>();
            for (int x = x1; x <= x2; x++) {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
        public void Draw() {
            foreach(Point p in pList) {
                p.Draw();
            }
        }
    }
}
