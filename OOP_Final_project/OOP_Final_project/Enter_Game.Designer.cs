 using Game;
using System.Drawing;

namespace OOP_Final_project
{
    partial class Enter_Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public Graphics g;
        public const int block_size = 20;
        Game.Margin margin;
        Game.Obstacle obstcale;
        Game.Car Owncar;
        Game.Car Computercar;
        Game.Car Computercar2;
        Game.Flag Flags;
        static public int[,] map;
        static public Difficulty Diff;
        static public GameStatus gamestatus = GameStatus.NON_MAP;
        static public MAP_MODE map_mode = MAP_MODE.RANDOM;
        int count;
        public Point Owncar_place;
        public Point Computer_place;
        public Point Computer2_place;
        public Point OwnCar_Start;
        public Point Computer_Start = new Point(610, 510);
        public Point Computer2_Start = new Point(110, 110);
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enter_Game));
            this.label_score = new System.Windows.Forms.Label();
            this.button_setting = new System.Windows.Forms.Button();
            this.button_start_stop = new System.Windows.Forms.Button();
            this.button_save_map = new System.Windows.Forms.Button();
            this.panel_playground = new System.Windows.Forms.Panel();
            this.timer_Computer = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog_map = new System.Windows.Forms.SaveFileDialog();
            this.timer_computer2 = new System.Windows.Forms.Timer(this.components);
            this.timer_IsBoom = new System.Windows.Forms.Timer(this.components);
            this.label_explain = new System.Windows.Forms.Label();
            this.label_count = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_score.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_score.Location = new System.Drawing.Point(854, 63);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(206, 32);
            this.label_score.TabIndex = 0;
            this.label_score.Text = "剩餘離校手續";
            // 
            // button_setting
            // 
            this.button_setting.BackColor = System.Drawing.Color.Bisque;
            this.button_setting.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.button_setting.FlatAppearance.BorderSize = 3;
            this.button_setting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.button_setting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.button_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_setting.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_setting.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_setting.Location = new System.Drawing.Point(898, 296);
            this.button_setting.Name = "button_setting";
            this.button_setting.Size = new System.Drawing.Size(115, 55);
            this.button_setting.TabIndex = 1;
            this.button_setting.Text = "遊戲設定";
            this.button_setting.UseVisualStyleBackColor = false;
            this.button_setting.Click += new System.EventHandler(this.button_setting_Click);
            // 
            // button_start_stop
            // 
            this.button_start_stop.BackColor = System.Drawing.Color.Bisque;
            this.button_start_stop.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.button_start_stop.FlatAppearance.BorderSize = 3;
            this.button_start_stop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.button_start_stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.button_start_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_start_stop.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_start_stop.Location = new System.Drawing.Point(898, 374);
            this.button_start_stop.Name = "button_start_stop";
            this.button_start_stop.Size = new System.Drawing.Size(115, 55);
            this.button_start_stop.TabIndex = 2;
            this.button_start_stop.Text = "開始遊戲";
            this.button_start_stop.UseVisualStyleBackColor = false;
            this.button_start_stop.Click += new System.EventHandler(this.button_start_stop_Click);
            // 
            // button_save_map
            // 
            this.button_save_map.BackColor = System.Drawing.Color.Bisque;
            this.button_save_map.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.button_save_map.FlatAppearance.BorderSize = 3;
            this.button_save_map.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.button_save_map.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.button_save_map.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save_map.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_save_map.Location = new System.Drawing.Point(898, 457);
            this.button_save_map.Name = "button_save_map";
            this.button_save_map.Size = new System.Drawing.Size(115, 55);
            this.button_save_map.TabIndex = 3;
            this.button_save_map.Text = "保存地圖";
            this.button_save_map.UseVisualStyleBackColor = false;
            this.button_save_map.Click += new System.EventHandler(this.button_save_map_Click);
            // 
            // panel_playground
            // 
            this.panel_playground.BackColor = System.Drawing.Color.Bisque;
            this.panel_playground.Location = new System.Drawing.Point(0, 0);
            this.panel_playground.Name = "panel_playground";
            this.panel_playground.Size = new System.Drawing.Size(820, 620);
            this.panel_playground.TabIndex = 4;
            // 
            // timer_Computer
            // 
            this.timer_Computer.Interval = 300;
            this.timer_Computer.Tick += new System.EventHandler(this.timer_Computer_Tick);
            // 
            // timer_computer2
            // 
            this.timer_computer2.Interval = 150;
            this.timer_computer2.Tick += new System.EventHandler(this.timer_computer2_Tick);
            // 
            // timer_IsBoom
            // 
            this.timer_IsBoom.Interval = 5;
            this.timer_IsBoom.Tick += new System.EventHandler(this.timer_IsBoom_Tick);
            // 
            // label_explain
            // 
            this.label_explain.AutoSize = true;
            this.label_explain.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_explain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_explain.Location = new System.Drawing.Point(875, 30);
            this.label_explain.Name = "label_explain";
            this.label_explain.Size = new System.Drawing.Size(151, 16);
            this.label_explain.TabIndex = 5;
            this.label_explain.Text = "(詳情請看遊戲說明)";
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Font = new System.Drawing.Font("標楷體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_count.ForeColor = System.Drawing.Color.Yellow;
            this.label_count.Location = new System.Drawing.Point(925, 117);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(60, 64);
            this.label_count.TabIndex = 6;
            this.label_count.Text = "3";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("標楷體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_result.ForeColor = System.Drawing.Color.Yellow;
            this.label_result.Location = new System.Drawing.Point(852, 213);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(216, 48);
            this.label_result.TabIndex = 7;
            this.label_result.Text = "高歌離席";
            this.label_result.Visible = false;
            // 
            // Enter_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1098, 621);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.label_explain);
            this.Controls.Add(this.panel_playground);
            this.Controls.Add(this.button_save_map);
            this.Controls.Add(this.button_start_stop);
            this.Controls.Add(this.button_setting);
            this.Controls.Add(this.label_score);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Enter_Game";
            this.Text = "Enter_Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Enter_Game_FormClosed);
            this.Load += new System.EventHandler(this.Enter_Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_Game_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Button button_setting;
        private System.Windows.Forms.Button button_start_stop;
        private System.Windows.Forms.Button button_save_map;
        private System.Windows.Forms.Panel panel_playground;
        private System.Windows.Forms.Timer timer_Computer;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_map;
        private System.Windows.Forms.Timer timer_computer2;
        private System.Windows.Forms.Timer timer_IsBoom;
        private System.Windows.Forms.Label label_explain;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.Label label_result;
    }
}