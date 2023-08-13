using SurvivalOfTheUnfit.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SurvivalOfTheUnfit
{
    /* The game world */
    /* Grid where (0,0) = top-left. */
    public class World
    {
        public static World? CurrentWorld { get; private set; }
        public static Tile? CurrentTile { get; private set; }
        public static Point CurrentLocation { get; private set; }
        public static event EventHandler? TileUpdated;

        public int Width { get; private set; }
        public int Height { get; private set; }
        public Tile[,]? Map { get; private set; }

        public World(int width, int height)
        {
            Width = width;
            Height = height;
            Map = new Tile[width, height];
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                    Map[x, y] = new Tile(this, x, y);

        } // end constructor

        /* Tile updated event */
        public static void TileChanged()
        {
            if (TileUpdated == null) return;

            TileUpdated.Invoke(null, EventArgs.Empty);

        } // end OnTileChanged

        /* Create a World instance from a bitmap image */
        public static World CreateFromBitmap(Bitmap bitmap)
        {
            Bitmap pixelMap = Resources.sprPixelWorldMap;

            int width = pixelMap.Width;
            int height = pixelMap.Height;
            World world = new World(width, height);

            for (int x = 0; x < world.Map.GetLength(0); x++)
                for (int y = 0; y < world.Map.GetLength(1); y++)
                {
                    Tile newTile = new Tile(world, x, y);
                    Color pixelColor = pixelMap.GetPixel(x, y);
                    foreach (Biome.Types biomeType in Enum.GetValues(typeof(Biome.Types)))
                        if (Biome.GetColor(biomeType) == pixelColor)
                        {
                            newTile.SetBiome(biomeType);
                            break;
                        }
                    world.Map[x, y] = newTile;
                }

            return world;
        }

        /* Sets new current world */
        public static void SetCurrentWorld(World newWorld)
        {
            if (newWorld == null || newWorld.Map == null)
                return;

            CurrentWorld = newWorld;
            SetCurrentTile(0, 0);

        } // end SetCurrentWorld

        /* Change the current tile */
        public static void SetCurrentTile(int x, int y)
        {
            if (CurrentWorld == null || CurrentWorld.Map == null)
                return;

            x = Math.Clamp(x, 0, CurrentWorld.Width - 1);
            y = Math.Clamp(y, 0, CurrentWorld.Height - 1);

            CurrentLocation = new Point(x, y);
            CurrentTile = CurrentWorld.Map[x, y];
            TileChanged();

        } // end SetCurrentTile

    } // end class World

} // end namespace
