using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Final_project
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }
        private void radioButtom_map_gen_Checked_Changed(object sender, EventArgs e)
        {
            if (radioButton_map_gen_random.Checked)
            {
                Enter_Game.map_mode = Game.MAP_MODE.RANDOM;
            }
            
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            openFileDialog_map.FileName = "";
            DirectoryInfo ProjectDir = new DirectoryInfo(Application.StartupPath);
            openFileDialog_map.Filter = "Plain Text(*.txt)|*.txt|All Files(*.*)|*.*";
            try
            {
                openFileDialog_map.InitialDirectory = ProjectDir.Parent.Parent.Parent.Parent.FullName;

            }
            catch (Exception)
            {
                return;
            }
            
        }

        private void radioButtom_difficulty_Checked_Changed(object sender, EventArgs e)
        {
            if (radioButton_easy.Checked)
            {
                Enter_Game.Diff = Game.Difficulty.EASY;
            }
            else if (radioButton_medium.Checked)
            {
                Enter_Game.Diff = Game.Difficulty.MEDIUM;
            }
            else if (radioButton_hard.Checked)
            {
                Enter_Game.Diff = Game.Difficulty.HARD;
            }
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_load_map_file_Click(object sender, EventArgs e)
        {
            int[,] tmp_map = new int[30, 40];
            if (openFileDialog_map.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog_map.FileName);
                string CurLine;
                for (int i = 0; i < 30; ++i)
                {
                    CurLine = sr.ReadLine();
                    string[] ss = CurLine.Split(',');
                    for (int j = 0; j < 40; ++j)
                    {
                        int check = Convert.ToInt32(ss[j]);
                        if (check != 0 && check != 1)
                        {
                            MessageBox.Show("地圖檔案讀取失敗!!\n將隨機產生地圖", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tmp_map = null;
                            Enter_Game.map = tmp_map;
                            return;
                        }

                        tmp_map[i, j] = check;
                        Console.Write(check);
                        Console.Write(",");
                    }
                    Console.WriteLine();
                }
                Enter_Game.map = tmp_map;
                sr.Close();
                label_show_map_name.Visible = true;
                textBox_map_name.Visible = true;
                textBox_map_name.Text = openFileDialog_map.FileName;
                Enter_Game.map_mode = Game.MAP_MODE.LOAD_FILE;
            }
        }
    }
}
