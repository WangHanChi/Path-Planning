namespace OOP_Final_project
{
    partial class Show_Astar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show_Astar));
            this.pictureBox_astar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_astar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_astar
            // 
            this.pictureBox_astar.Image = global::OOP_Final_project.Properties.Resources.Astar;
            this.pictureBox_astar.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_astar.Name = "pictureBox_astar";
            this.pictureBox_astar.Size = new System.Drawing.Size(492, 325);
            this.pictureBox_astar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_astar.TabIndex = 0;
            this.pictureBox_astar.TabStop = false;
            // 
            // Show_Astar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(490, 323);
            this.Controls.Add(this.pictureBox_astar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Show_Astar";
            this.Text = "Show_Astar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_astar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_astar;
    }
}