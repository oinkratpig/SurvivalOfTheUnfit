using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurvivalOfTheUnfit
{
    public partial class FormWorldMap : Form
    {
        public FormWorldMap()
        {
            InitializeComponent();

            // Theme
            ColorTheme.ThemeUpdated += OnThemeUpdated;
            ColorTheme.UpdateFormThemes();

            this.Select();

        } // end FormWorldMap

        /* Whenever the color theme is changed. */
        public void OnThemeUpdated(object sender, EventArgs e)
        {
            ColorTheme.ApplyFormTheme(this, ColorTheme.CurrentTheme);

        } // end OnThemeUpdated

        /* Color each table cell in world map */
        // https://stackoverflow.com/questions/34064499/how-to-set-cell-color-in-tablelayoutpanel-dynamically
        private void tableWorldMap_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if ((e.Column + e.Row) % 2 == 1)
                e.Graphics.FillRectangle(Brushes.Black, e.CellBounds);
            else
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);

        } // end tableWorldMap_CellPaint

    } // end class FormWorldMap

} // end namespace