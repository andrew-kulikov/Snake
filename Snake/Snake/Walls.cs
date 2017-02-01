using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake {
    class Walls {
        List<Figure> wallList;
        private int mapHeight;
        private int mapWidth;
        public Walls(int mapWidth, int mapHeight) {
            wallList = new List<Figure>();
            HorizontalLine topLine = new HorizontalLine(0, mapWidth - 2, 0, '+');
            HorizontalLine bottomLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
            VerticalLine leftLine = new VerticalLine(0, 0, mapHeight - 1, '+');
            VerticalLine rightLine = new VerticalLine(mapWidth - 2, 0, mapHeight - 1, '+');
            wallList.Add(topLine);
            wallList.Add(bottomLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
            this.mapHeight = mapHeight;
            this.mapWidth = mapWidth;
        }
        public void Draw() {
            foreach(var figure in wallList) {
                figure.Draw();
            }
        }
        public bool IsHit(Figure figure) {
           foreach(var wall in wallList) {
                if(wall.IsHit(figure)) {
                    return true;
                }
            }
            return false;
        }
    }
}
