﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake {
    class Snake : Figure {
        Direction direction;
        public Snake(Point tail, int length, Direction _direction) {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < length; i++) {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }
        public void Move() {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNewPoint();
            pList.Add(head);
            tail.Clear();
            head.Draw();

        }
        private Point GetNewPoint() {
            Point head = pList.Last();
            Point newPoint = new Point(head);
            newPoint.Move(1, direction);
            return newPoint;
        }
        public void HandleKey(ConsoleKey key) {
            if (key == ConsoleKey.LeftArrow) {
                direction = Direction.LEFT;
            }
            else if (key == ConsoleKey.RightArrow) {
                direction = Direction.RIGHT;
            }
            else if (key == ConsoleKey.UpArrow) {
                direction = Direction.UP;
            }
            else if (key == ConsoleKey.DownArrow) {
                direction = Direction.DOWN;
            }
        }
    }
}
