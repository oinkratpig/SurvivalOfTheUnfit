using SurvivalOfTheUnfit.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SurvivalOfTheUnfit
{
    public partial class FormMain : Form
    {
        public static System.Windows.Forms.TreeView TreeViewActions
        {
            get { return _formMainInstance.treeViewActions; }
        }

        private GameEvents gameEvents;

        private const int TEXT_LINE_MAX = 7;
        private static List<string> _text = new List<string>();

        private static FormMain _formMainInstance;
        private static FormInventory _formInventoryInstance;
        private static FormWorldMap _formWorldMapInstance;

        /* On startup. */
        public FormMain()
        {
            InitializeComponent();
            _formMainInstance = this;
            this.Select();

            // Theme
            menuItemOptionsDarkMode.CheckState = CheckState.Checked;
            ColorTheme.CurrentTheme = new ColorThemeDark();
            ColorTheme.ThemeUpdated += OnThemeUpdated;
            ColorTheme.UpdateFormThemes();

            // Events
            gameEvents = new GameEvents();

            // Create world
            World.SetCurrentWorld(World.CreateFromBitmap(Resources.sprPixelWorldMap));

            // Instantiate all classes to instantiate on load
            InstantiateOnStart.InstantiateAll();

            // Actions
            gameEvents.UpdateActions();

        } // end constructor

        /* Whenever the color theme is changed. */
        public void OnThemeUpdated(object sender, EventArgs e)
        {
            ColorTheme.ApplyFormTheme(this, ColorTheme.CurrentTheme);

        } // end OnThemeUpdated

        /* Appends text to the end of the main text box. */
        public static void AddText(string text)
        {
            _text.Add(text);

            while (_text.Count > TEXT_LINE_MAX)
                _text.RemoveAt(0);

            if (_text[0] == "") _text.RemoveAt(0);

        } // end AddText

        /* Appends text to the end of the main text box with or without a newline before it. */
        public static void AddText(string text, bool addNewlineBefore)
        {
            if (addNewlineBefore) AddText("");

            AddText(text);

        } // end AddText

        /* Clears all text within the main text box.*/
        public static void ClearText()
        {
            _text.Clear();
            _formMainInstance.textBoxMain.Text = "";

        } // end ClearText

        /* Updates the text box to show all appended text. */
        public static void UpdateText()
        {
            if (_formMainInstance == null) return;

            _formMainInstance.textBoxMain.Text = "";

            string text;
            for (int i = 0; i < _text.Count; i++)
            {
                text = _text[i] + ((i < _text.Count - 1) ? "\r\n" : "");
                _formMainInstance.textBoxMain.AppendText(text);
            }

        } // end UpdateText

        /* When player is using input text box. */
        private void textBoxInput_Enter(object sender, EventArgs e)
        {
            AcceptButton = buttonAct;

        } // end textBoxInput_Enter

        /* When player is no longer using input text box. */
        private void textBoxInput_Leave(object sender, EventArgs e)
        {
            AcceptButton = null;

        } // end textBoxInput_Leave

        /* Called when the Act button is clicked. */
        private void buttonAct_Click(object sender, EventArgs e)
        {
            ClearText();

            AddText(DateTime.Now.ToString());
            AddText("");

            // Remove newline if at start of text box
            List<string> actionArgs = _formMainInstance.textBoxInput.Text.Split(" ").ToList<string>();
            actionArgs.RemoveAt(0);

            // Perform action that was typed
            if (gameEvents.PerformAction(_formMainInstance.textBoxInput.Text, actionArgs.ToArray()))
            {
                // Update all actions
                gameEvents.UpdateActions();
                if (_formInventoryInstance.Exists())
                    _formInventoryInstance.UpdateInventory();

                // Play sound
                Sound.Play(Sounds.Select);
            }

            // No valid action
            else
                AddText("nothing happened.");

            // Clear input text and update main text box
            textBoxInput.Text = "";
            UpdateText();

        } // end buttonAct_Click

        /* Toggle dark mode. */
        private void menuItemOptionsDarkMode_Click(object sender, EventArgs e)
        {
            if (menuItemOptionsDarkMode.CheckState == CheckState.Checked)
            {
                menuItemOptionsDarkMode.CheckState = CheckState.Unchecked;
                ColorTheme.CurrentTheme = new ColorThemeLight();
            }
            else
            {
                menuItemOptionsDarkMode.CheckState = CheckState.Checked;
                ColorTheme.CurrentTheme = new ColorThemeDark();
            }

            ColorTheme.UpdateFormThemes();

        } // end menuItemOptionsDarkMode_Click

        /* Open inventory window */
        private void menuItemCharacterInventory_Click(object sender, EventArgs e)
        {
            if (!_formInventoryInstance.Exists()) _formInventoryInstance = new FormInventory();
            _formInventoryInstance.Show();

        } // end menuItemCharacterInventory_Click

        /* Open world map */
        private void menuItemWorldMap_Click(object sender, EventArgs e)
        {
            if (!_formWorldMapInstance.Exists()) _formWorldMapInstance = new FormWorldMap();
            _formWorldMapInstance.Show();

        } // end menuItemWorldMap_Click

        /* Open map editor */
        private void menuItemDebugMapEditor_Click(object sender, EventArgs e)
        {
            FormMapEditor mapEditor = new FormMapEditor();
            mapEditor.Show();

        } // end menuItemDebugMapEditor_Click

    } // end class FormMain

} // end namespace
