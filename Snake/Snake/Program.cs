using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            Point p = new Point(1, 1, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            while(true) {
                if(Console.KeyAvailable) {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.LeftArrow) {
                        snake.direction = Direction.LEFT;
                    }
                    else if (key.Key == ConsoleKey.RightArrow) {
                        snake.direction = Direction.RIGHT;
                    }
                    else if(key.Key == ConsoleKey.UpArrow) {
                        snake.direction = Direction.UP;
                    }
                    else if (key.Key == ConsoleKey.DownArrow) {
                        snake.direction = Direction.DOWN;
                    }                                                    
                }
                Thread.Sleep(100);
                snake.Move();
            }
            Console.ReadLine();
        }
    }
}
