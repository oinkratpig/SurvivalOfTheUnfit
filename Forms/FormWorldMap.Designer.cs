namespace SurvivalOfTheUnfit
{
    partial class FormWorldMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWorldMap));
            tableWorldMap = new TableLayoutPanel();
            panelHeader = new Panel();
            labelBiome = new Label();
            labelArea = new Label();
            buttonSouth = new Button();
            buttonWest = new Button();
            buttonNorth = new Button();
            buttonEast = new Button();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // tableWorldMap
            // 
            tableWorldMap.ColumnCount = 15;
            tableWorldMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableWorldMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableWorldMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableWorldMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableWorldMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableWorldMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableWorldMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableWorldMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableWorldMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableWorldMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableWorldMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableWorldMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableWorldMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableWorldMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableWorldMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableWorldMap.Location = new Point(36, 68);
            tableWorldMap.Name = "tableWorldMap";
            tableWorldMap.RowCount = 15;
            tableWorldMap.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableWorldMap.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableWorldMap.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableWorldMap.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableWorldMap.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableWorldMap.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableWorldMap.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableWorldMap.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableWorldMap.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableWorldMap.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableWorldMap.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableWorldMap.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableWorldMap.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableWorldMap.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableWorldMap.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableWorldMap.Size = new Size(302, 300);
            tableWorldMap.TabIndex = 0;
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(labelBiome);
            panelHeader.Controls.Add(labelArea);
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(389, 33);
            panelHeader.TabIndex = 1;
            // 
            // labelBiome
            // 
            labelBiome.AutoSize = true;
            labelBiome.Location = new Point(274, 9);
            labelBiome.Name = "labelBiome";
            labelBiome.Size = new Size(84, 15);
            labelBiome.TabIndex = 1;
            labelBiome.Text = "Current Biome";
            labelBiome.TextAlign = ContentAlignment.TopRight;
            // 
            // labelArea
            // 
            labelArea.AutoSize = true;
            labelArea.Location = new Point(12, 9);
            labelArea.Name = "labelArea";
            labelArea.Size = new Size(74, 15);
            labelArea.TabIndex = 0;
            labelArea.Text = "Current Area";
            // 
            // buttonSouth
            // 
            buttonSouth.Location = new Point(149, 374);
            buttonSouth.Name = "buttonSouth";
            buttonSouth.Size = new Size(75, 23);
            buttonSouth.TabIndex = 2;
            buttonSouth.Text = "v";
            buttonSouth.UseVisualStyleBackColor = true;
            // 
            // buttonWest
            // 
            buttonWest.Location = new Point(7, 191);
            buttonWest.Name = "buttonWest";
            buttonWest.Size = new Size(23, 75);
            buttonWest.TabIndex = 3;
            buttonWest.Text = "<";
            buttonWest.UseVisualStyleBackColor = true;
            // 
            // buttonNorth
            // 
            buttonNorth.Location = new Point(149, 39);
            buttonNorth.Name = "buttonNorth";
            buttonNorth.Size = new Size(75, 23);
            buttonNorth.TabIndex = 4;
            buttonNorth.Text = "^";
            buttonNorth.UseVisualStyleBackColor = true;
            // 
            // buttonEast
            // 
            buttonEast.Location = new Point(344, 191);
            buttonEast.Name = "buttonEast";
            buttonEast.Size = new Size(23, 75);
            buttonEast.TabIndex = 5;
            buttonEast.Text = ">";
            buttonEast.UseVisualStyleBackColor = true;
            // 
            // FormWorldMap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 408);
            Controls.Add(buttonEast);
            Controls.Add(buttonNorth);
            Controls.Add(buttonWest);
            Controls.Add(buttonSouth);
            Controls.Add(panelHeader);
            Controls.Add(tableWorldMap);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormWorldMap";
            Text = "Survival of the Unfit - World Map";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableWorldMap;
        private Panel panelHeader;
        private Label labelBiome;
        private Label labelArea;
        private Button buttonSouth;
        private Button buttonWest;
        private Button buttonNorth;
        private Button buttonEast;
    }
}