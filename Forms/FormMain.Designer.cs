namespace SurvivalOfTheUnfit
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStripMain = new MenuStrip();
            menuItemOptions = new ToolStripMenuItem();
            menuItemOptionsDarkMode = new ToolStripMenuItem();
            menuItemCharacter = new ToolStripMenuItem();
            treeViewActions = new TreeView();
            pictureBoxScene = new PictureBox();
            textBoxInput = new TextBox();
            buttonAct = new Button();
            textBoxMain = new TextBox();
            panelTextBoxInput = new Panel();
            menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxScene).BeginInit();
            panelTextBoxInput.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.Items.AddRange(new ToolStripItem[] { menuItemOptions, menuItemCharacter });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(640, 24);
            menuStripMain.TabIndex = 0;
            menuStripMain.Text = "menuStripMain";
            // 
            // menuItemOptions
            // 
            menuItemOptions.DisplayStyle = ToolStripItemDisplayStyle.Text;
            menuItemOptions.DropDownItems.AddRange(new ToolStripItem[] { menuItemOptionsDarkMode });
            menuItemOptions.Name = "menuItemOptions";
            menuItemOptions.Size = new Size(59, 20);
            menuItemOptions.Text = "options";
            // 
            // menuItemOptionsDarkMode
            // 
            menuItemOptionsDarkMode.Name = "menuItemOptionsDarkMode";
            menuItemOptionsDarkMode.Size = new Size(131, 22);
            menuItemOptionsDarkMode.Text = "dark mode";
            menuItemOptionsDarkMode.Click += menuItemOptionsDarkMode_Click;
            // 
            // menuItemCharacter
            // 
            menuItemCharacter.DisplayStyle = ToolStripItemDisplayStyle.Text;
            menuItemCharacter.Name = "menuItemCharacter";
            menuItemCharacter.Size = new Size(68, 20);
            menuItemCharacter.Text = "character";
            // 
            // treeViewActions
            // 
            treeViewActions.BorderStyle = BorderStyle.None;
            treeViewActions.Location = new Point(12, 32);
            treeViewActions.Name = "treeViewActions";
            treeViewActions.Size = new Size(138, 332);
            treeViewActions.TabIndex = 1;
            // 
            // pictureBoxScene
            // 
            pictureBoxScene.BackColor = Color.Gainsboro;
            pictureBoxScene.Location = new Point(156, 32);
            pictureBoxScene.Name = "pictureBoxScene";
            pictureBoxScene.Size = new Size(472, 207);
            pictureBoxScene.TabIndex = 2;
            pictureBoxScene.TabStop = false;
            // 
            // textBoxInput
            // 
            textBoxInput.BorderStyle = BorderStyle.None;
            textBoxInput.Location = new Point(8, 4);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.PlaceholderText = "type actions here...";
            textBoxInput.Size = new Size(372, 16);
            textBoxInput.TabIndex = 3;
            textBoxInput.Enter += textBoxInput_Enter;
            textBoxInput.Leave += textBoxInput_Leave;
            // 
            // buttonAct
            // 
            buttonAct.FlatAppearance.BorderSize = 0;
            buttonAct.FlatStyle = FlatStyle.Flat;
            buttonAct.Location = new Point(156, 341);
            buttonAct.Name = "buttonAct";
            buttonAct.Size = new Size(75, 23);
            buttonAct.TabIndex = 4;
            buttonAct.Text = "act";
            buttonAct.UseVisualStyleBackColor = true;
            buttonAct.Click += buttonAct_Click;
            // 
            // textBoxMain
            // 
            textBoxMain.BorderStyle = BorderStyle.None;
            textBoxMain.Location = new Point(156, 245);
            textBoxMain.Multiline = true;
            textBoxMain.Name = "textBoxMain";
            textBoxMain.ReadOnly = true;
            textBoxMain.Size = new Size(472, 90);
            textBoxMain.TabIndex = 5;
            // 
            // panelTextBoxInput
            // 
            panelTextBoxInput.Controls.Add(textBoxInput);
            panelTextBoxInput.Location = new Point(237, 341);
            panelTextBoxInput.Name = "panelTextBoxInput";
            panelTextBoxInput.Size = new Size(391, 23);
            panelTextBoxInput.TabIndex = 6;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(640, 376);
            Controls.Add(panelTextBoxInput);
            Controls.Add(textBoxMain);
            Controls.Add(buttonAct);
            Controls.Add(pictureBoxScene);
            Controls.Add(treeViewActions);
            Controls.Add(menuStripMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStripMain;
            Name = "FormMain";
            Text = "Survival of the Unfit";
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxScene).EndInit();
            panelTextBoxInput.ResumeLayout(false);
            panelTextBoxInput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMain;
        private ToolStripMenuItem menuItemOptions;
        private ToolStripMenuItem menuItemCharacter;
        private TreeView treeViewActions;
        private PictureBox pictureBoxScene;
        private TextBox textBoxInput;
        private Button buttonAct;
        private TextBox textBoxMain;
        private ToolStripMenuItem menuItemOptionsDarkMode;
        private Panel panelTextBoxInput;
    }
}