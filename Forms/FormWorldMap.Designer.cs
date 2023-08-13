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
            panelHeader = new Panel();
            labelBiome = new Label();
            buttonSouth = new Button();
            buttonWest = new Button();
            buttonNorth = new Button();
            buttonEast = new Button();
            pictureBoxMap = new PictureBox();
            pictureBoxPositionMarker = new PictureBox();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPositionMarker).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(labelBiome);
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(389, 33);
            panelHeader.TabIndex = 1;
            // 
            // labelBiome
            // 
            labelBiome.AutoSize = true;
            labelBiome.Location = new Point(12, 9);
            labelBiome.Name = "labelBiome";
            labelBiome.Size = new Size(84, 15);
            labelBiome.TabIndex = 1;
            labelBiome.Text = "Current Biome";
            labelBiome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonSouth
            // 
            buttonSouth.FlatAppearance.BorderSize = 0;
            buttonSouth.FlatStyle = FlatStyle.Flat;
            buttonSouth.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSouth.Location = new Point(145, 374);
            buttonSouth.Name = "buttonSouth";
            buttonSouth.Size = new Size(75, 23);
            buttonSouth.TabIndex = 2;
            buttonSouth.Text = "v";
            buttonSouth.UseVisualStyleBackColor = true;
            // 
            // buttonWest
            // 
            buttonWest.FlatAppearance.BorderSize = 0;
            buttonWest.FlatStyle = FlatStyle.Flat;
            buttonWest.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonWest.Location = new Point(7, 191);
            buttonWest.Name = "buttonWest";
            buttonWest.Size = new Size(23, 75);
            buttonWest.TabIndex = 3;
            buttonWest.Text = "<";
            buttonWest.UseVisualStyleBackColor = true;
            // 
            // buttonNorth
            // 
            buttonNorth.FlatAppearance.BorderSize = 0;
            buttonNorth.FlatStyle = FlatStyle.Flat;
            buttonNorth.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNorth.Location = new Point(145, 39);
            buttonNorth.Name = "buttonNorth";
            buttonNorth.Size = new Size(75, 23);
            buttonNorth.TabIndex = 4;
            buttonNorth.Text = "^";
            buttonNorth.UseVisualStyleBackColor = true;
            // 
            // buttonEast
            // 
            buttonEast.FlatAppearance.BorderSize = 0;
            buttonEast.FlatStyle = FlatStyle.Flat;
            buttonEast.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEast.Location = new Point(344, 191);
            buttonEast.Name = "buttonEast";
            buttonEast.Size = new Size(23, 75);
            buttonEast.TabIndex = 5;
            buttonEast.Text = ">";
            buttonEast.UseVisualStyleBackColor = true;
            // 
            // pictureBoxMap
            // 
            pictureBoxMap.BackgroundImage = Properties.Resources.sprWorldMapLarge;
            pictureBoxMap.BackgroundImageLayout = ImageLayout.Center;
            pictureBoxMap.Location = new Point(36, 68);
            pictureBoxMap.Name = "pictureBoxMap";
            pictureBoxMap.Size = new Size(300, 300);
            pictureBoxMap.TabIndex = 6;
            pictureBoxMap.TabStop = false;
            // 
            // pictureBoxPositionMarker
            // 
            pictureBoxPositionMarker.BackColor = Color.Transparent;
            pictureBoxPositionMarker.BackgroundImage = Properties.Resources.sprMapPositionMarker;
            pictureBoxPositionMarker.BackgroundImageLayout = ImageLayout.Center;
            pictureBoxPositionMarker.Location = new Point(169, 198);
            pictureBoxPositionMarker.Name = "pictureBoxPositionMarker";
            pictureBoxPositionMarker.Size = new Size(34, 33);
            pictureBoxPositionMarker.TabIndex = 7;
            pictureBoxPositionMarker.TabStop = false;
            // 
            // FormWorldMap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 408);
            Controls.Add(pictureBoxPositionMarker);
            Controls.Add(buttonEast);
            Controls.Add(buttonNorth);
            Controls.Add(buttonWest);
            Controls.Add(buttonSouth);
            Controls.Add(panelHeader);
            Controls.Add(pictureBoxMap);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormWorldMap";
            Text = "Survival of the Unfit - World Map";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMap).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPositionMarker).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelHeader;
        private Label labelBiome;
        private Button buttonSouth;
        private Button buttonWest;
        private Button buttonNorth;
        private Button buttonEast;
        private PictureBox pictureBoxMap;
        private PictureBox pictureBoxPositionMarker;
    }
}