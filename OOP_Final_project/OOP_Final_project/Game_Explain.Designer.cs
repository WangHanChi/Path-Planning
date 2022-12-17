using System.Runtime.CompilerServices;

namespace OOP_Final_project
{
    partial class Game_Explain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public bool flag = false;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_Explain));
            this.label_explain = new System.Windows.Forms.Label();
            this.label_detail = new System.Windows.Forms.Label();
            this.button_next = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.label_key = new System.Windows.Forms.Label();
            this.pictureBox_graduate = new System.Windows.Forms.PictureBox();
            this.pictureBox_expalin_icon = new System.Windows.Forms.PictureBox();
            this.pictureBox_keypad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_graduate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_expalin_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_keypad)).BeginInit();
            this.SuspendLayout();
            // 
            // label_explain
            // 
            this.label_explain.AutoSize = true;
            this.label_explain.Font = new System.Drawing.Font("標楷體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_explain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_explain.Location = new System.Drawing.Point(422, 42);
            this.label_explain.Name = "label_explain";
            this.label_explain.Size = new System.Drawing.Size(212, 48);
            this.label_explain.TabIndex = 0;
            this.label_explain.Text = "遊戲說明";
            // 
            // label_detail
            // 
            this.label_detail.AutoSize = true;
            this.label_detail.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_detail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_detail.Location = new System.Drawing.Point(35, 118);
            this.label_detail.Name = "label_detail";
            this.label_detail.Size = new System.Drawing.Size(58, 24);
            this.label_detail.TabIndex = 2;
            this.label_detail.Text = "內容";
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.Color.Bisque;
            this.button_next.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.button_next.FlatAppearance.BorderSize = 3;
            this.button_next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.button_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.button_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_next.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_next.Location = new System.Drawing.Point(848, 405);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(160, 60);
            this.button_next.TabIndex = 3;
            this.button_next.Text = "下一頁";
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.Bisque;
            this.button_back.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.button_back.FlatAppearance.BorderSize = 4;
            this.button_back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.button_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_back.Location = new System.Drawing.Point(848, 492);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(160, 60);
            this.button_back.TabIndex = 4;
            this.button_back.Text = "返回主畫面";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // label_key
            // 
            this.label_key.AutoSize = true;
            this.label_key.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_key.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_key.Location = new System.Drawing.Point(82, 220);
            this.label_key.Name = "label_key";
            this.label_key.Size = new System.Drawing.Size(206, 32);
            this.label_key.TabIndex = 6;
            this.label_key.Text = "鍵盤控制上下";
            this.label_key.Visible = false;
            // 
            // pictureBox_graduate
            // 
            this.pictureBox_graduate.Image = global::OOP_Final_project.Properties.Resources.graduate;
            this.pictureBox_graduate.Location = new System.Drawing.Point(39, 402);
            this.pictureBox_graduate.Name = "pictureBox_graduate";
            this.pictureBox_graduate.Size = new System.Drawing.Size(314, 150);
            this.pictureBox_graduate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_graduate.TabIndex = 7;
            this.pictureBox_graduate.TabStop = false;
            // 
            // pictureBox_expalin_icon
            // 
            this.pictureBox_expalin_icon.Image = global::OOP_Final_project.Properties.Resources.explain_icon;
            this.pictureBox_expalin_icon.Location = new System.Drawing.Point(377, 156);
            this.pictureBox_expalin_icon.Name = "pictureBox_expalin_icon";
            this.pictureBox_expalin_icon.Size = new System.Drawing.Size(391, 386);
            this.pictureBox_expalin_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_expalin_icon.TabIndex = 5;
            this.pictureBox_expalin_icon.TabStop = false;
            this.pictureBox_expalin_icon.Visible = false;
            // 
            // pictureBox_keypad
            // 
            this.pictureBox_keypad.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_keypad.Image")));
            this.pictureBox_keypad.Location = new System.Drawing.Point(59, 282);
            this.pictureBox_keypad.Name = "pictureBox_keypad";
            this.pictureBox_keypad.Size = new System.Drawing.Size(240, 260);
            this.pictureBox_keypad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_keypad.TabIndex = 1;
            this.pictureBox_keypad.TabStop = false;
            this.pictureBox_keypad.Visible = false;
            // 
            // Game_Explain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1046, 592);
            this.Controls.Add(this.pictureBox_graduate);
            this.Controls.Add(this.label_key);
            this.Controls.Add(this.pictureBox_expalin_icon);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.label_detail);
            this.Controls.Add(this.pictureBox_keypad);
            this.Controls.Add(this.label_explain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game_Explain";
            this.Text = "Game_Explain";
            this.Load += new System.EventHandler(this.Game_Explain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_graduate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_expalin_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_keypad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_explain;
        private System.Windows.Forms.PictureBox pictureBox_keypad;
        private System.Windows.Forms.Label label_detail;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.PictureBox pictureBox_expalin_icon;
        private System.Windows.Forms.Label label_key;
        private System.Windows.Forms.PictureBox pictureBox_graduate;
    }
}