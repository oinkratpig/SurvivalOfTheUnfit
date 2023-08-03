namespace SurvivalOfTheUnfit
{
    partial class FormInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventory));
            panelInventory = new Panel();
            SuspendLayout();
            // 
            // panelInventory
            // 
            panelInventory.ForeColor = SystemColors.Control;
            panelInventory.Location = new Point(12, 12);
            panelInventory.Name = "panelInventory";
            panelInventory.Size = new Size(400, 217);
            panelInventory.TabIndex = 0;
            // 
            // FormInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 241);
            Controls.Add(panelInventory);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormInventory";
            Text = "Survival of the Unfit - Inventory";
            FormClosed += FormInventory_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInventory;
    }
}