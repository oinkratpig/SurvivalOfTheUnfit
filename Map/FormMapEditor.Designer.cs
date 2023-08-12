namespace SurvivalOfTheUnfit
{
    partial class FormMapEditor
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
            buttonNewEmptyMap = new Button();
            textBoxSelectedTileX = new TextBox();
            labelSelectedTile = new Label();
            labelSelectedTileX = new Label();
            labelSelectedTileY = new Label();
            textBoxSelectedTileY = new TextBox();
            labelBiomeType = new Label();
            textBoxBiomeName = new TextBox();
            labelDivider = new Label();
            buttonGenerateMap = new Button();
            textBoxColor = new TextBox();
            labelColor = new Label();
            pictureBoxMap = new PictureBox();
            pictureBoxX = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxX).BeginInit();
            SuspendLayout();
            // 
            // buttonNewEmptyMap
            // 
            buttonNewEmptyMap.Location = new Point(12, 12);
            buttonNewEmptyMap.Name = "buttonNewEmptyMap";
            buttonNewEmptyMap.Size = new Size(200, 23);
            buttonNewEmptyMap.TabIndex = 0;
            buttonNewEmptyMap.Text = "generate new empty map";
            buttonNewEmptyMap.UseVisualStyleBackColor = true;
            buttonNewEmptyMap.Click += buttonNewEmptyMap_Click;
            // 
            // textBoxSelectedTileX
            // 
            textBoxSelectedTileX.Location = new Point(360, 13);
            textBoxSelectedTileX.Name = "textBoxSelectedTileX";
            textBoxSelectedTileX.Size = new Size(19, 23);
            textBoxSelectedTileX.TabIndex = 2;
            textBoxSelectedTileX.TextChanged += textBoxSelectedTileX_TextChanged;
            // 
            // labelSelectedTile
            // 
            labelSelectedTile.AutoSize = true;
            labelSelectedTile.Location = new Point(222, 16);
            labelSelectedTile.Name = "labelSelectedTile";
            labelSelectedTile.Size = new Size(115, 15);
            labelSelectedTile.TabIndex = 3;
            labelSelectedTile.Text = "selected tile position";
            // 
            // labelSelectedTileX
            // 
            labelSelectedTileX.AutoSize = true;
            labelSelectedTileX.Location = new Point(344, 16);
            labelSelectedTileX.Name = "labelSelectedTileX";
            labelSelectedTileX.Size = new Size(16, 15);
            labelSelectedTileX.TabIndex = 4;
            labelSelectedTileX.Text = "x:";
            // 
            // labelSelectedTileY
            // 
            labelSelectedTileY.AutoSize = true;
            labelSelectedTileY.Location = new Point(380, 16);
            labelSelectedTileY.Name = "labelSelectedTileY";
            labelSelectedTileY.Size = new Size(16, 15);
            labelSelectedTileY.TabIndex = 6;
            labelSelectedTileY.Text = "y:";
            // 
            // textBoxSelectedTileY
            // 
            textBoxSelectedTileY.Location = new Point(396, 13);
            textBoxSelectedTileY.Name = "textBoxSelectedTileY";
            textBoxSelectedTileY.Size = new Size(19, 23);
            textBoxSelectedTileY.TabIndex = 5;
            textBoxSelectedTileY.TextChanged += textBoxSelectedTileY_TextChanged;
            // 
            // labelBiomeType
            // 
            labelBiomeType.AutoSize = true;
            labelBiomeType.Location = new Point(222, 45);
            labelBiomeType.Name = "labelBiomeType";
            labelBiomeType.Size = new Size(41, 15);
            labelBiomeType.TabIndex = 7;
            labelBiomeType.Text = "biome";
            // 
            // textBoxBiomeName
            // 
            textBoxBiomeName.Enabled = false;
            textBoxBiomeName.Location = new Point(269, 42);
            textBoxBiomeName.Name = "textBoxBiomeName";
            textBoxBiomeName.Size = new Size(146, 23);
            textBoxBiomeName.TabIndex = 8;
            // 
            // labelDivider
            // 
            labelDivider.BorderStyle = BorderStyle.Fixed3D;
            labelDivider.Location = new Point(225, 107);
            labelDivider.Name = "labelDivider";
            labelDivider.Size = new Size(189, 2);
            labelDivider.TabIndex = 9;
            // 
            // buttonGenerateMap
            // 
            buttonGenerateMap.Location = new Point(12, 41);
            buttonGenerateMap.Name = "buttonGenerateMap";
            buttonGenerateMap.Size = new Size(200, 23);
            buttonGenerateMap.TabIndex = 16;
            buttonGenerateMap.Text = "generate from pixel map";
            buttonGenerateMap.UseVisualStyleBackColor = true;
            buttonGenerateMap.Click += buttonGenerateMap_Click;
            // 
            // textBoxColor
            // 
            textBoxColor.Enabled = false;
            textBoxColor.Location = new Point(269, 71);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(146, 23);
            textBoxColor.TabIndex = 17;
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Location = new Point(223, 74);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(34, 15);
            labelColor.TabIndex = 18;
            labelColor.Text = "color";
            // 
            // pictureBoxMap
            // 
            pictureBoxMap.BackColor = Color.Transparent;
            pictureBoxMap.Image = Properties.Resources.sprWorldMap;
            pictureBoxMap.Location = new Point(12, 74);
            pictureBoxMap.Name = "pictureBoxMap";
            pictureBoxMap.Size = new Size(200, 200);
            pictureBoxMap.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxMap.TabIndex = 15;
            pictureBoxMap.TabStop = false;
            // 
            // pictureBoxX
            // 
            pictureBoxX.BackColor = Color.Transparent;
            pictureBoxX.BackgroundImageLayout = ImageLayout.None;
            pictureBoxX.Image = Properties.Resources.sprWorldMapX;
            pictureBoxX.Location = new Point(99, 154);
            pictureBoxX.Name = "pictureBoxX";
            pictureBoxX.Size = new Size(21, 27);
            pictureBoxX.TabIndex = 19;
            pictureBoxX.TabStop = false;
            // 
            // FormMapEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 508);
            Controls.Add(pictureBoxX);
            Controls.Add(labelColor);
            Controls.Add(textBoxColor);
            Controls.Add(buttonGenerateMap);
            Controls.Add(labelDivider);
            Controls.Add(textBoxBiomeName);
            Controls.Add(labelBiomeType);
            Controls.Add(labelSelectedTileY);
            Controls.Add(textBoxSelectedTileY);
            Controls.Add(labelSelectedTileX);
            Controls.Add(labelSelectedTile);
            Controls.Add(textBoxSelectedTileX);
            Controls.Add(buttonNewEmptyMap);
            Controls.Add(pictureBoxMap);
            Name = "FormMapEditor";
            Text = "FormMapEditor";
            ((System.ComponentModel.ISupportInitialize)pictureBoxMap).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxX).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonNewEmptyMap;
        private TextBox textBoxSelectedTileX;
        private Label labelSelectedTile;
        private Label labelSelectedTileX;
        private Label labelSelectedTileY;
        private TextBox textBoxSelectedTileY;
        private Label labelBiomeType;
        private TextBox textBoxBiomeName;
        private Label labelDivider;
        private Button buttonGenerateMap;
        private TextBox textBoxColor;
        private Label labelColor;
        private PictureBox pictureBoxMap;
        private PictureBox pictureBoxX;
    }
}