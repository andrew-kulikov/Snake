﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake {
    class Program {
        static void Main(string[] args) {
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 25);
            HorizontalLine topLine = new HorizontalLine(0, 78, 0, '+');            
            HorizontalLine bottomLine = new HorizontalLine(0, 78, 24, '+');            
            VerticalLine leftLine = new VerticalLine(0, 0, 24, '+');           
            VerticalLine rightLine = new VerticalLine(78, 0, 24, '+');
            topLine.Draw();
            bottomLine.Draw();
            leftLine.Draw();
            rightLine.Draw();
            Point p1 = new Point(1, 1, '%');
            p1.Draw();          
            Console.ReadLine();
        }
    }
}
