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
            Width = width;
            Height = height;
            Map = new Tile[width, height];
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                    Map[x, y] = new Tile(this, x, y);

        } // end constructor

        /*
        // Resize a TableLayoutPanel to match given World
        public static void UpdateWorldMapTable(TableLayoutPanel table, World world)
        {
            table.RowStyles.Clear();
            table.ColumnStyles.Clear();

            table.RowCount = world.Width;
            table.ColumnCount = world.Height;

            table.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            int cellWidth = table.Size.Width / (world.Width + 1) + 1; // extra +1 at end is to compensate for cell borders
            int cellHeight = table.Size.Height / (world.Height + 1) + 1;

            table.Size = new Size((cellWidth + 1) * world.Width, (cellHeight + 1) * world.Height);

            for (int i = 0; i < world.Width; i++)
                table.RowStyles.Add(new RowStyle(SizeType.Absolute, cellWidth));
            for (int i = 0; i < world.Height; i++)
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, cellHeight));

        } // end UpdateWorldMapTable
        */

    } // end class World

} // end namespace
