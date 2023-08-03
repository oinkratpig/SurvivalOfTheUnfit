using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurvivalOfTheUnfit
{
    public partial class FormInventory : Form
    {
        private const int ITEM_SPRITE_SIZE = 32;
        private const int INVENTORY_PADDING_HORIZONTAL = 5;
        private const int INVENTORY_PADDING_VERTICAL = 5;

        public FormInventory()
        {
            InitializeComponent();

            ColorTheme.ThemeUpdated += OnThemeUpdated;
            ColorTheme.UpdateFormThemes();

            UpdateInventory();

        } // end constructor

        /* Whenever the color theme is changed. */
        public void OnThemeUpdated(object sender, EventArgs e)
        {
            ColorTheme.ApplyFormTheme(this, ColorTheme.CurrentTheme);

        } // end OnThemeUpdated

        /* Unsubscribe event when form is closed. */
        private void FormInventory_FormClosed(object sender, FormClosedEventArgs e)
        {
            ColorTheme.ThemeUpdated -= OnThemeUpdated;

        } // end FormInventory_FormClosed

        /* Updates the inventory display. */
        public void UpdateInventory()
        {
            panelInventory.Controls.Clear();

            // Get all item categories
            List<string> categories = new List<string>();
            foreach (Item item in Inventory.Contents.Keys)
            {
                string category = item.Category.ToString();

                if (!categories.Contains(category))
                    categories.Add(category);
            }

            // Add all items and categories
            int x = INVENTORY_PADDING_HORIZONTAL; // current coords to place controls
            int y = INVENTORY_PADDING_VERTICAL; // ^
            foreach (string category in categories)
            {
                // Create category label
                Label label = new Label();
                panelInventory.Controls.Add(label);
                label.Text = category;
                label.Location = new Point(x, y);
                y += INVENTORY_PADDING_VERTICAL + label.Size.Height;

                // Create images
                int yToIncrement = 0;
                foreach (Item item in Inventory.Contents.Keys)
                    if (item.Category.ToString() == category)
                    {
                        PictureBox picture = new PictureBox();
                        panelInventory.Controls.Add(picture);

                        picture.Image = item.Sprite;
                        picture.Size = new Size(ITEM_SPRITE_SIZE, ITEM_SPRITE_SIZE);
                        picture.SizeMode = PictureBoxSizeMode.StretchImage;
                        picture.Location = new Point(x, y);

                        ToolTip tooltip = new ToolTip();
                        tooltip.SetToolTip(picture, $"{item.Name} x{Inventory.Contents[item]}");

                        x += picture.Size.Width;
                        yToIncrement = Math.Max(yToIncrement, picture.Size.Height);

                        if (x >= panelInventory.Width)
                        {
                            x = INVENTORY_PADDING_HORIZONTAL;
                            y += yToIncrement + INVENTORY_PADDING_VERTICAL;
                        }
                    }
                x = INVENTORY_PADDING_HORIZONTAL;
                y += yToIncrement + INVENTORY_PADDING_VERTICAL;
            }

        } // end UpdateInventory

    } // end class FormInventory

} // end namespace