using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game;

namespace OOP_Final_project
{
    public partial class Enter_Game : Form
    {
        public Enter_Game()
        {
            InitializeComponent();
        }

        private void button_setting_Click(object sender, EventArgs e)
        {
            label_result.Visible = false;
            if (gamestatus != GameStatus.GAME_MODE)
            {
                Diff = Difficulty.EASY;
                Setting setting = new Setting();
                this.Hide();
                setting.ShowDialog();
                this.Show();
                if (map_mode == MAP_MODE.RANDOM)
                {
                    g.Clear(Color.Bisque);
                    OwnCar_Start = SetOwnCarStartPlace();
                    map = map_generator(OwnCar_Start);
                }

                margin = new Game.Margin(g);
                margin.Draw();
                obstcale = new Game.Obstacle(block_size, map, OwnCar_Start, g);
                obstcale.Draw();
                gamestatus = GameStatus.NON_GAME_MODE;
            }
            else if (gamestatus == GameStatus.GAME_MODE)
            {
                timer_Computer.Enabled = false;
                timer_computer2.Enabled = false;
                timer_IsBoom.Enabled = false;
                g.Clear(Color.Bisque);
                OwnCar_Start = SetOwnCarStartPlace();
                map = map_generator(OwnCar_Start);
                margin = new Game.Margin(g);
                margin.Draw();
                obstcale = new Game.Obstacle(block_size, map, OwnCar_Start, g);
                obstcale.Draw();

                Owncar_place = OwnCar_Start;
                Owncar = new Game.Car(Owncar_place, "Owncar", map, block_size, g);
                Owncar.Draw();
                Computer_place = Computer_Start;
                Computercar = new Game.Car(Computer_place, "Computer_car", map, block_size, g);
                Computercar.Draw();
                Flags = new Flag(block_size, map, g);
                Flags.ResetCount();
                Flags.SetOwnCarPlace(Owncar.GetPlace());
                Flags.Draw();
                
                

                if (Diff == Difficulty.EASY)
                {
                    timer_Computer.Interval = 300;
                }
                else if (Diff == Difficulty.MEDIUM)
                {
                    timer_Computer.Interval = 200;
                }
                else if (Diff == Difficulty.HARD)
                {
                    timer_Computer.Interval = 150;
                    Computer2_place = Computer2_Start;
                    Computercar2 = new Game.Car(Computer2_place, "Computer_car", map, block_size, g);
                    Computercar2.Draw();
                }

                Task.Delay(3000);
                timer_Computer.Enabled = false;
                timer_computer2.Enabled = false;
                timer_IsBoom.Enabled = true;
            }
            
        }
        private Point SetOwnCarStartPlace()
        {
            Random random = new Random();
            int x = random.Next(10, 26);
            int y = random.Next(10, 21);
            OwnCar_Start.X = x * 20 + 10;
            OwnCar_Start.Y = y * 20 + 10;
            return OwnCar_Start;
        }
        private int[,] map_generator(Point OwnCar_Start)
        {
            int x = (OwnCar_Start.X - 10) / 20;
            int y = (OwnCar_Start.Y - 10) / 20;
            map = new int[30, 40];
            Random random = new Random();
            for (int i = 0; i < 30; ++i)
            {
                for (int j = 0; j < 40 ; ++j)
                {
                    int a = random.Next(0, 5);
                    if (a < 4) a = 0;
                    else a = 1;

                    if ((x == j - 1 && y == i - 1) || (x == j && y == i - 1) || (x == j + 1 && y == i - 1)) a = 0;
                    if ((x == j - 1 && y == i) || (x == j && y == i) || (x == j + 1 && y == i)) a = 0;
                    if ((x == j - 1 && y == i + 1) || (x == j && y == i + 1) || (x == j + 1 && y == i + 1)) a = 0;
                    map[i, j] = a;
                    
                    
                }
            }
            return map;
        }
        private void button_start_stop_Click(object sender, EventArgs e)
        {
            label_result.Visible = false;
            if (gamestatus == GameStatus.NON_MAP)
            {
                g.Clear(Color.Bisque);
                margin = new Game.Margin(g);
                margin.Draw();
                OwnCar_Start = SetOwnCarStartPlace();
                map = map_generator(OwnCar_Start);
                obstcale = new Game.Obstacle(block_size, map, OwnCar_Start, g);
                obstcale.Draw();
                gamestatus = GameStatus.NON_GAME_MODE;
            }

            if (gamestatus == GameStatus.NON_GAME_MODE)
            {
                // 更改枚舉
                gamestatus = GameStatus.GAME_MODE;
                button_save_map.Enabled = false;
                button_start_stop.Enabled = false;
                button_setting.Text = "重新刷新地圖";


                Owncar_place = OwnCar_Start;
                Owncar = new Game.Car(Owncar_place, "Owncar", map, block_size, g);
                Owncar.Draw();
                Computer_place = Computer_Start;
                Computercar = new Game.Car(Computer_place, "Computer_car", map, block_size, g);
                Computercar.Draw();
                Flags = new Flag(block_size, map, g);
                Flags.ResetCount();
                Flags.SetOwnCarPlace(Owncar.GetPlace());
                Flags.Draw();

                if (Diff == Difficulty.EASY)
                {
                    timer_Computer.Interval = 300;
                }
                else if (Diff == Difficulty.MEDIUM)
                {
                    timer_Computer.Interval = 200;
                }
                else if (Diff == Difficulty.HARD)
                {
                    timer_Computer.Interval = 150;
                    Computer2_place = Computer2_Start;
                    Computercar2 = new Game.Car(Computer2_place, "Computer_car", map, block_size, g);
                    Computercar2.Draw();
                }

                Task.Delay(3000);
                timer_Computer.Enabled = false;
                timer_computer2.Enabled = false;
                timer_IsBoom.Enabled = true;
                count = 3;
                label_count.Text = count.ToString();
            }

            
        }
        
        private void Enter_Game_KeyDown(object sender, KeyEventArgs e)
        {
            

            if (gamestatus != GameStatus.GAME_MODE) return;
            timer_Computer.Enabled = true;
            timer_computer2.Enabled = true;
            Owncar.Move(e.KeyCode);
            Point Owncar_now_place = Owncar.GetPlace();
            if (Flags.IsEatFlag(Owncar_now_place.X, Owncar_now_place.Y) == true)
            {
                count--;
                label_count.Text = count.ToString();
                if (Flags.IsEnd() == true)
                {
                    count = 0;
                    label_count.Text = count.ToString();
                    label_result.Visible = true;
                    timer_Computer.Enabled = false;
                    timer_computer2.Enabled = false;
                    timer_IsBoom.Enabled = false;
                    timer_Computer.Enabled = false;
                    MessageBox.Show("遊戲結束囉!!\n恭喜獲勝\n請按Reset鍵", "WIN Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label_result.Visible = false;
                    g.Clear(Color.Bisque);
                    margin = new Game.Margin(g);
                    margin.Draw();
                    obstcale = new Game.Obstacle(block_size, map, OwnCar_Start, g);
                    obstcale.Draw();
                    //g.Clear(Color.Bisque);
                    gamestatus = GameStatus.NON_GAME_MODE;
                    button_setting.Text = "遊戲設定";
                    button_save_map.Enabled = true;
                    button_start_stop.Enabled = true;
                    count = 3;
                    label_count.Text = count.ToString();
                    return;
                }
            }
        }

        private void Enter_Game_Load(object sender, EventArgs e)
        {
            g = this.panel_playground.CreateGraphics();
            saveFileDialog_map.Filter = "Plain Text(*.txt)|*.txt|All Files(*.*)|*.*";
            saveFileDialog_map.FileName = "";
            DirectoryInfo ProjectDir = new DirectoryInfo(Application.StartupPath);
            try
            {
                saveFileDialog_map.InitialDirectory = ProjectDir.Parent.Parent.Parent.Parent.FullName;
            }
            catch (Exception)
            {
                return;
            }


            Diff = Difficulty.EASY;
            gamestatus = GameStatus.NON_MAP;
            map_mode = MAP_MODE.RANDOM;
        }

        private void timer_Computer_Tick(object sender, EventArgs e)
        {
            Point Owncar_now_place = Owncar.GetPlace();
            Computercar.Astar_Move(Owncar_now_place.X, Owncar_now_place.Y);
        }

        private void Enter_Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer_Computer.Enabled = false;
            timer_computer2.Enabled = false;
            timer_IsBoom.Enabled = false;
        }

        private void button_save_map_Click(object sender, EventArgs e)
        {
            if (map == null)
            { 
                MessageBox.Show("還沒有地圖喔, 請按下遊戲開始或是匯入地圖", "MAP ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (saveFileDialog_map.ShowDialog() == DialogResult.OK)
            {
                String Filename = saveFileDialog_map.FileName;
                String[] str = Filename.Split('.');
                String FileType = str[str.Count() - 1];
                StreamWriter sw = new StreamWriter(Filename);
                if (FileType == "txt")
                {
                    for (int i = 0; i < 30; ++i)
                    {
                        for (int j = 0; j < 40; ++j)
                        {
                            int num = map[i, j];
                            sw.Write(Convert.ToString(num) + ",");
                        }
                        sw.WriteLine();
                    }
                }
                sw.Close();
            }
        }

        private void timer_computer2_Tick(object sender, EventArgs e)
        {
            if (Diff == Difficulty.HARD)
            {
                Point Owncar_now_place = Owncar.GetPlace();
                Computercar2.Astar_Move(Owncar_now_place.X, Owncar_now_place.Y);
            }
        }

        private void timer_IsBoom_Tick(object sender, EventArgs e)
        {
            Point Owncar_now_place = Owncar.GetPlace();
            if (Diff == Difficulty.EASY || Diff == Difficulty.MEDIUM)
            {
                if (Owncar.GetPlace() == Computercar.GetPlace())
                {
                    timer_Computer.Enabled = false;
                    timer_computer2.Enabled = false;
                    timer_IsBoom.Enabled = false;
                    MessageBox.Show("遊戲結束囉!!\n您輸了呦\n請按Reset鍵", "LOSE GAME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    g.Clear(Color.Bisque);
                    margin = new Game.Margin(g);
                    margin.Draw();
                    obstcale = new Game.Obstacle(block_size, map, OwnCar_Start, g);
                    obstcale.Draw();
                    //g.Clear(Color.Bisque);
                    count = 3;
                    label_count.Text = count.ToString();
                    gamestatus = GameStatus.NON_GAME_MODE;
                    button_setting.Text = "遊戲設定";
                    button_save_map.Enabled = true;
                    button_start_stop.Enabled = true;
                    return;
                }
                else if (Computercar.GetPlace() == Flags.GetPlace())
                {
                    Flags.SetOwnCarPlace(Owncar.GetPlace());
                    Flags.Draw();
                }
               
            }
            else if (Diff == Difficulty.HARD)
            {
                if (Computercar.GetPlace() == Computercar2.GetPlace())
                {
                    timer_computer2.Enabled = false;
                    Task.Delay(timer_computer2.Interval * 2);
                    timer_computer2.Enabled = true;
                }
                if (Owncar.GetPlace() == Computercar.GetPlace() || Owncar.GetPlace() == Computercar2.GetPlace())
                {
                    timer_Computer.Enabled = false;
                    timer_computer2.Enabled = false;
                    timer_IsBoom.Enabled = false;

                    MessageBox.Show("遊戲結束囉!!\n您輸了呦\n請按Reset鍵", "LOSE GAME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    g.Clear(Color.Bisque);
                    margin = new Game.Margin(g);
                    margin.Draw();
                    obstcale = new Game.Obstacle(block_size, map, OwnCar_Start, g);
                    obstcale.Draw();
                    //g.Clear(Color.Bisque);
                    gamestatus = 0;
                    label_count.Text = count.ToString();
                    button_setting.Text = "遊戲設定";
                    button_save_map.Enabled = true;
                    button_start_stop.Enabled = true;
                    count = 3;
                    return;
                }
                else if (Computercar.GetPlace() == Flags.GetPlace() || Computercar2.GetPlace() == Flags.GetPlace())
                {
                    Flags.SetOwnCarPlace(Owncar.GetPlace());
                    Flags.Draw();
                }
                
            }
        }
    }
}
