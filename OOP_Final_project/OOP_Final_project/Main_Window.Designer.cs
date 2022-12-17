namespace OOP_Final_project
{
    partial class Main_Window
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Window));
            this.button_game_detail = new System.Windows.Forms.Button();
            this.button_about_astar = new System.Windows.Forms.Button();
            this.button_go_game = new System.Windows.Forms.Button();
            this.pictureBox_Cover = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cover)).BeginInit();
            this.SuspendLayout();
            // 
            // button_game_detail
            // 
            this.button_game_detail.BackColor = System.Drawing.Color.Bisque;
            this.button_game_detail.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.button_game_detail.FlatAppearance.BorderSize = 5;
            this.button_game_detail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.button_game_detail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.button_game_detail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_game_detail.Font = new System.Drawing.Font("標楷體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_game_detail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_game_detail.Location = new System.Drawing.Point(328, 501);
            this.button_game_detail.Name = "button_game_detail";
            this.button_game_detail.Size = new System.Drawing.Size(230, 91);
            this.button_game_detail.TabIndex = 0;
            this.button_game_detail.Text = "應用說明";
            this.button_game_detail.UseVisualStyleBackColor = false;
            this.button_game_detail.Click += new System.EventHandler(this.button_game_detail_Click);
            // 
            // button_about_astar
            // 
            this.button_about_astar.BackColor = System.Drawing.Color.Bisque;
            this.button_about_astar.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.button_about_astar.FlatAppearance.BorderSize = 5;
            this.button_about_astar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.button_about_astar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.button_about_astar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_about_astar.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_about_astar.Location = new System.Drawing.Point(67, 503);
            this.button_about_astar.Name = "button_about_astar";
            this.button_about_astar.Size = new System.Drawing.Size(230, 91);
            this.button_about_astar.TabIndex = 5;
            this.button_about_astar.Text = "關於A star 演算法";
            this.button_about_astar.UseVisualStyleBackColor = false;
            this.button_about_astar.Click += new System.EventHandler(this.button_about_astar_Click);
            // 
            // button_go_game
            // 
            this.button_go_game.BackColor = System.Drawing.Color.Bisque;
            this.button_go_game.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.button_go_game.FlatAppearance.BorderSize = 5;
            this.button_go_game.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.button_go_game.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.button_go_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_go_game.Font = new System.Drawing.Font("標楷體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_go_game.Location = new System.Drawing.Point(587, 501);
            this.button_go_game.Name = "button_go_game";
            this.button_go_game.Size = new System.Drawing.Size(230, 91);
            this.button_go_game.TabIndex = 6;
            this.button_go_game.Text = "進入應用";
            this.button_go_game.UseVisualStyleBackColor = false;
            this.button_go_game.Click += new System.EventHandler(this.button_go_game_Click);
            // 
            // pictureBox_Cover
            // 
            this.pictureBox_Cover.Image = global::OOP_Final_project.Properties.Resources.Alice;
            this.pictureBox_Cover.Location = new System.Drawing.Point(-3, -6);
            this.pictureBox_Cover.Name = "pictureBox_Cover";
            this.pictureBox_Cover.Size = new System.Drawing.Size(854, 627);
            this.pictureBox_Cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Cover.TabIndex = 4;
            this.pictureBox_Cover.TabStop = false;
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(851, 617);
            this.Controls.Add(this.button_go_game);
            this.Controls.Add(this.button_about_astar);
            this.Controls.Add(this.button_game_detail);
            this.Controls.Add(this.pictureBox_Cover);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Window";
            this.Text = "Main_Window";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_game_detail;
        private System.Windows.Forms.PictureBox pictureBox_Cover;
        private System.Windows.Forms.Button button_about_astar;
        private System.Windows.Forms.Button button_go_game;
    }
}

