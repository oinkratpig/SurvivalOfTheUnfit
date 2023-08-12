using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalOfTheUnfit
{
    /* The game world */
    /* Grid where (0,0) = top-left. */
    public class World
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public Tile[,]? Map { get; private set; }

        public World(int width, int height)
        {
            Map = new Tile[width, height];
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                    Map[x, y] = new Tile(this, x, y);

        } // end constructor

    } // end class World

} // end namespace
