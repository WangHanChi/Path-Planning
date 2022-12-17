namespace OOP_Final_project
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.label_Setting = new System.Windows.Forms.Label();
            this.openFileDialog_map = new System.Windows.Forms.OpenFileDialog();
            this.radioButton_map_gen_random = new System.Windows.Forms.RadioButton();
            this.groupBox_map_setting = new System.Windows.Forms.GroupBox();
            this.label_show_map_name = new System.Windows.Forms.Label();
            this.textBox_map_name = new System.Windows.Forms.TextBox();
            this.groupBox_difficulty = new System.Windows.Forms.GroupBox();
            this.radioButton_hard = new System.Windows.Forms.RadioButton();
            this.radioButton_medium = new System.Windows.Forms.RadioButton();
            this.radioButton_easy = new System.Windows.Forms.RadioButton();
            this.button_return = new System.Windows.Forms.Button();
            this.button_load_map_file = new System.Windows.Forms.Button();
            this.groupBox_map_setting.SuspendLayout();
            this.groupBox_difficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Setting
            // 
            this.label_Setting.AutoSize = true;
            this.label_Setting.Font = new System.Drawing.Font("標楷體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Setting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Setting.Location = new System.Drawing.Point(300, 24);
            this.label_Setting.Name = "label_Setting";
            this.label_Setting.Size = new System.Drawing.Size(173, 37);
            this.label_Setting.TabIndex = 0;
            this.label_Setting.Text = "遊戲設定";
            // 
            // radioButton_map_gen_random
            // 
            this.radioButton_map_gen_random.AutoSize = true;
            this.radioButton_map_gen_random.Checked = true;
            this.radioButton_map_gen_random.Location = new System.Drawing.Point(30, 69);
            this.radioButton_map_gen_random.Name = "radioButton_map_gen_random";
            this.radioButton_map_gen_random.Size = new System.Drawing.Size(178, 28);
            this.radioButton_map_gen_random.TabIndex = 0;
            this.radioButton_map_gen_random.TabStop = true;
            this.radioButton_map_gen_random.Text = "使用隨機產生";
            this.radioButton_map_gen_random.UseVisualStyleBackColor = true;
            this.radioButton_map_gen_random.CheckedChanged += new System.EventHandler(this.radioButtom_map_gen_Checked_Changed);
            // 
            // groupBox_map_setting
            // 
            this.groupBox_map_setting.Controls.Add(this.radioButton_map_gen_random);
            this.groupBox_map_setting.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox_map_setting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_map_setting.Location = new System.Drawing.Point(63, 86);
            this.groupBox_map_setting.Name = "groupBox_map_setting";
            this.groupBox_map_setting.Size = new System.Drawing.Size(272, 138);
            this.groupBox_map_setting.TabIndex = 1;
            this.groupBox_map_setting.TabStop = false;
            this.groupBox_map_setting.Text = "地圖設定";
            // 
            // label_show_map_name
            // 
            this.label_show_map_name.AutoSize = true;
            this.label_show_map_name.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_show_map_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_show_map_name.Location = new System.Drawing.Point(62, 358);
            this.label_show_map_name.Name = "label_show_map_name";
            this.label_show_map_name.Size = new System.Drawing.Size(137, 21);
            this.label_show_map_name.TabIndex = 2;
            this.label_show_map_name.Text = "匯入的地圖:";
            this.label_show_map_name.Visible = false;
            // 
            // textBox_map_name
            // 
            this.textBox_map_name.BackColor = System.Drawing.Color.Bisque;
            this.textBox_map_name.Enabled = false;
            this.textBox_map_name.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_map_name.Location = new System.Drawing.Point(66, 394);
            this.textBox_map_name.Name = "textBox_map_name";
            this.textBox_map_name.Size = new System.Drawing.Size(639, 33);
            this.textBox_map_name.TabIndex = 3;
            this.textBox_map_name.Visible = false;
            // 
            // groupBox_difficulty
            // 
            this.groupBox_difficulty.Controls.Add(this.radioButton_hard);
            this.groupBox_difficulty.Controls.Add(this.radioButton_medium);
            this.groupBox_difficulty.Controls.Add(this.radioButton_easy);
            this.groupBox_difficulty.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox_difficulty.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_difficulty.Location = new System.Drawing.Point(414, 86);
            this.groupBox_difficulty.Name = "groupBox_difficulty";
            this.groupBox_difficulty.Size = new System.Drawing.Size(272, 224);
            this.groupBox_difficulty.TabIndex = 3;
            this.groupBox_difficulty.TabStop = false;
            this.groupBox_difficulty.Text = "難度設定";
            // 
            // radioButton_hard
            // 
            this.radioButton_hard.AutoSize = true;
            this.radioButton_hard.Location = new System.Drawing.Point(32, 149);
            this.radioButton_hard.Name = "radioButton_hard";
            this.radioButton_hard.Size = new System.Drawing.Size(78, 28);
            this.radioButton_hard.TabIndex = 2;
            this.radioButton_hard.Text = "困難";
            this.radioButton_hard.UseVisualStyleBackColor = true;
            this.radioButton_hard.CheckedChanged += new System.EventHandler(this.radioButtom_difficulty_Checked_Changed);
            // 
            // radioButton_medium
            // 
            this.radioButton_medium.AutoSize = true;
            this.radioButton_medium.Location = new System.Drawing.Point(32, 93);
            this.radioButton_medium.Name = "radioButton_medium";
            this.radioButton_medium.Size = new System.Drawing.Size(78, 28);
            this.radioButton_medium.TabIndex = 1;
            this.radioButton_medium.Text = "中等";
            this.radioButton_medium.UseVisualStyleBackColor = true;
            this.radioButton_medium.CheckedChanged += new System.EventHandler(this.radioButtom_difficulty_Checked_Changed);
            // 
            // radioButton_easy
            // 
            this.radioButton_easy.AutoSize = true;
            this.radioButton_easy.Checked = true;
            this.radioButton_easy.Location = new System.Drawing.Point(32, 36);
            this.radioButton_easy.Name = "radioButton_easy";
            this.radioButton_easy.Size = new System.Drawing.Size(78, 28);
            this.radioButton_easy.TabIndex = 0;
            this.radioButton_easy.TabStop = true;
            this.radioButton_easy.Text = "簡單";
            this.radioButton_easy.UseVisualStyleBackColor = true;
            this.radioButton_easy.CheckedChanged += new System.EventHandler(this.radioButtom_difficulty_Checked_Changed);
            // 
            // button_return
            // 
            this.button_return.BackColor = System.Drawing.Color.Bisque;
            this.button_return.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.button_return.FlatAppearance.BorderSize = 4;
            this.button_return.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.button_return.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.button_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_return.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_return.Location = new System.Drawing.Point(414, 316);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(272, 49);
            this.button_return.TabIndex = 4;
            this.button_return.Text = "設定完成, 返回!";
            this.button_return.UseVisualStyleBackColor = false;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // button_load_map_file
            // 
            this.button_load_map_file.BackColor = System.Drawing.Color.Bisque;
            this.button_load_map_file.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.button_load_map_file.FlatAppearance.BorderSize = 5;
            this.button_load_map_file.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.button_load_map_file.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.button_load_map_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_load_map_file.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_load_map_file.Location = new System.Drawing.Point(63, 248);
            this.button_load_map_file.Name = "button_load_map_file";
            this.button_load_map_file.Size = new System.Drawing.Size(272, 71);
            this.button_load_map_file.TabIndex = 5;
            this.button_load_map_file.Text = "開啟地圖檔";
            this.button_load_map_file.UseVisualStyleBackColor = false;
            this.button_load_map_file.Click += new System.EventHandler(this.button_load_map_file_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_load_map_file);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.groupBox_difficulty);
            this.Controls.Add(this.textBox_map_name);
            this.Controls.Add(this.label_show_map_name);
            this.Controls.Add(this.groupBox_map_setting);
            this.Controls.Add(this.label_Setting);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Setting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.groupBox_map_setting.ResumeLayout(false);
            this.groupBox_map_setting.PerformLayout();
            this.groupBox_difficulty.ResumeLayout(false);
            this.groupBox_difficulty.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Setting;
        private System.Windows.Forms.OpenFileDialog openFileDialog_map;
        private System.Windows.Forms.RadioButton radioButton_map_gen_random;
        private System.Windows.Forms.GroupBox groupBox_map_setting;
        private System.Windows.Forms.Label label_show_map_name;
        private System.Windows.Forms.TextBox textBox_map_name;
        private System.Windows.Forms.GroupBox groupBox_difficulty;
        private System.Windows.Forms.RadioButton radioButton_hard;
        private System.Windows.Forms.RadioButton radioButton_medium;
        private System.Windows.Forms.RadioButton radioButton_easy;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.Button button_load_map_file;
    }
}