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
            menuItemCharacter = new ToolStripMenuItem();
            treeViewActions = new TreeView();
            pictureBoxScene = new PictureBox();
            textBoxInput = new TextBox();
            buttonAct = new Button();
            textBoxMain = new TextBox();
            menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxScene).BeginInit();
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
            menuItemOptions.Name = "menuItemOptions";
            menuItemOptions.Size = new Size(61, 20);
            menuItemOptions.Text = "Options";
            // 
            // menuItemCharacter
            // 
            menuItemCharacter.DisplayStyle = ToolStripItemDisplayStyle.Text;
            menuItemCharacter.Name = "menuItemCharacter";
            menuItemCharacter.Size = new Size(70, 20);
            menuItemCharacter.Text = "Character";
            // 
            // treeViewActions
            // 
            treeViewActions.Location = new Point(12, 27);
            treeViewActions.Name = "treeViewActions";
            treeViewActions.Size = new Size(138, 337);
            treeViewActions.TabIndex = 1;
            // 
            // pictureBoxScene
            // 
            pictureBoxScene.BackColor = Color.Gainsboro;
            pictureBoxScene.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxScene.Location = new Point(156, 27);
            pictureBoxScene.Name = "pictureBoxScene";
            pictureBoxScene.Size = new Size(472, 212);
            pictureBoxScene.TabIndex = 2;
            pictureBoxScene.TabStop = false;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(237, 340);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.PlaceholderText = "Type actions here...";
            textBoxInput.Size = new Size(391, 23);
            textBoxInput.TabIndex = 3;
            textBoxInput.Enter += textBoxInput_Enter;
            textBoxInput.Leave += textBoxInput_Leave;
            // 
            // buttonAct
            // 
            buttonAct.Location = new Point(156, 340);
            buttonAct.Name = "buttonAct";
            buttonAct.Size = new Size(75, 23);
            buttonAct.TabIndex = 4;
            buttonAct.Text = "Act";
            buttonAct.UseVisualStyleBackColor = true;
            buttonAct.Click += buttonAct_Click;
            // 
            // textBoxMain
            // 
            textBoxMain.Location = new Point(156, 245);
            textBoxMain.Multiline = true;
            textBoxMain.Name = "textBoxMain";
            textBoxMain.ReadOnly = true;
            textBoxMain.ScrollBars = ScrollBars.Vertical;
            textBoxMain.Size = new Size(472, 89);
            textBoxMain.TabIndex = 5;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 376);
            Controls.Add(textBoxMain);
            Controls.Add(buttonAct);
            Controls.Add(textBoxInput);
            Controls.Add(pictureBoxScene);
            Controls.Add(treeViewActions);
            Controls.Add(menuStripMain);
            MainMenuStrip = menuStripMain;
            Name = "FormMain";
            Text = "FormMain";
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxScene).EndInit();
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
    }
}