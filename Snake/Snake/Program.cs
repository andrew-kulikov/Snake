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
            Point p2 = new Point(7, 6, '*');
            p2.Draw();
            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);
            numList.RemoveAt(0);
            foreach(int i in numList) {
                Console.WriteLine(i);
            }
            Point p3 = new Point(2, 3, '-');
            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
        }
    }
}
