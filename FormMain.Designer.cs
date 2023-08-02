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
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            buttonAct = new Button();
            textBox2 = new TextBox();
            menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            treeViewActions.Size = new Size(135, 337);
            treeViewActions.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gainsboro;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(153, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(475, 212);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(234, 340);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Type actions here...";
            textBox1.Size = new Size(394, 23);
            textBox1.TabIndex = 3;
            // 
            // buttonAct
            // 
            buttonAct.Location = new Point(153, 340);
            buttonAct.Name = "buttonAct";
            buttonAct.Size = new Size(75, 23);
            buttonAct.TabIndex = 4;
            buttonAct.Text = "Act";
            buttonAct.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(153, 245);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(475, 89);
            textBox2.TabIndex = 5;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 376);
            Controls.Add(textBox2);
            Controls.Add(buttonAct);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(treeViewActions);
            Controls.Add(menuStripMain);
            MainMenuStrip = menuStripMain;
            Name = "FormMain";
            Text = "FormMain";
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMain;
        private ToolStripMenuItem menuItemOptions;
        private ToolStripMenuItem menuItemCharacter;
        private TreeView treeViewActions;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button buttonAct;
        private TextBox textBox2;
    }
}