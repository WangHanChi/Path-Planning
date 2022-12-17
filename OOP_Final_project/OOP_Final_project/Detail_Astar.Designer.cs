using MyAstar;

namespace OOP_Final_project
{
    partial class Detail_Astar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        MyButton[,] myButton = new MyButton[30, 30];
        int[,] map = new int[30, 30];
        Node Start = new Node();
        Node End = new Node();
        Status status = Status.Before_Start;
        Algorithm algorithm = Algorithm.Astar;
        public int flag = 1;
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
            this.button_set = new System.Windows.Forms.Button();
            this.comboBox_algorithm = new System.Windows.Forms.ComboBox();
            this.label_now_status = new System.Windows.Forms.Label();
            this.label_Astar_performance = new System.Windows.Forms.Label();
            this.label_dijkstra_performance = new System.Windows.Forms.Label();
            this.button_random = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_set
            // 
            this.button_set.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_set.Location = new System.Drawing.Point(619, 195);
            this.button_set.Name = "button_set";
            this.button_set.Size = new System.Drawing.Size(138, 65);
            this.button_set.TabIndex = 0;
            this.button_set.Text = "設定";
            this.button_set.UseVisualStyleBackColor = true;
            this.button_set.Click += new System.EventHandler(this.button_set_Click);
            // 
            // comboBox_algorithm
            // 
            this.comboBox_algorithm.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_algorithm.FormattingEnabled = true;
            this.comboBox_algorithm.Items.AddRange(new object[] {
            "Astar",
            "Dijkstra",
            "Both"});
            this.comboBox_algorithm.Location = new System.Drawing.Point(619, 319);
            this.comboBox_algorithm.Name = "comboBox_algorithm";
            this.comboBox_algorithm.Size = new System.Drawing.Size(121, 27);
            this.comboBox_algorithm.TabIndex = 1;
            this.comboBox_algorithm.Text = "Astar";
            this.comboBox_algorithm.SelectedIndexChanged += new System.EventHandler(this.comboBox_algorithm_SelectedIndexChanged);
            // 
            // label_now_status
            // 
            this.label_now_status.AutoSize = true;
            this.label_now_status.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_now_status.Location = new System.Drawing.Point(615, 82);
            this.label_now_status.Name = "label_now_status";
            this.label_now_status.Size = new System.Drawing.Size(53, 19);
            this.label_now_status.TabIndex = 2;
            this.label_now_status.Text = "tex1";
            // 
            // label_Astar_performance
            // 
            this.label_Astar_performance.AutoSize = true;
            this.label_Astar_performance.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Astar_performance.Location = new System.Drawing.Point(615, 426);
            this.label_Astar_performance.Name = "label_Astar_performance";
            this.label_Astar_performance.Size = new System.Drawing.Size(82, 21);
            this.label_Astar_performance.TabIndex = 3;
            this.label_Astar_performance.Text = "label1";
            // 
            // label_dijkstra_performance
            // 
            this.label_dijkstra_performance.AutoSize = true;
            this.label_dijkstra_performance.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_dijkstra_performance.Location = new System.Drawing.Point(615, 494);
            this.label_dijkstra_performance.Name = "label_dijkstra_performance";
            this.label_dijkstra_performance.Size = new System.Drawing.Size(82, 21);
            this.label_dijkstra_performance.TabIndex = 4;
            this.label_dijkstra_performance.Text = "label2";
            // 
            // button_random
            // 
            this.button_random.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_random.Location = new System.Drawing.Point(784, 195);
            this.button_random.Name = "button_random";
            this.button_random.Size = new System.Drawing.Size(138, 65);
            this.button_random.TabIndex = 5;
            this.button_random.Text = "隨機產生";
            this.button_random.UseVisualStyleBackColor = true;
            this.button_random.Click += new System.EventHandler(this.button_random_Click);
            // 
            // Detail_Astar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 618);
            this.Controls.Add(this.button_random);
            this.Controls.Add(this.label_dijkstra_performance);
            this.Controls.Add(this.label_Astar_performance);
            this.Controls.Add(this.label_now_status);
            this.Controls.Add(this.comboBox_algorithm);
            this.Controls.Add(this.button_set);
            this.Name = "Detail_Astar";
            this.Text = "Detail_Astar";
            this.Load += new System.EventHandler(this.Detail_Astar_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MyButton_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_set;
        private System.Windows.Forms.ComboBox comboBox_algorithm;
        private System.Windows.Forms.Label label_now_status;
        private System.Windows.Forms.Label label_Astar_performance;
        private System.Windows.Forms.Label label_dijkstra_performance;
        private System.Windows.Forms.Button button_random;
    }
}