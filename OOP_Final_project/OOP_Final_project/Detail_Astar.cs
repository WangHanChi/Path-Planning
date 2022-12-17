using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyAstar;


namespace OOP_Final_project
{
    public partial class Detail_Astar : Form
    {
        public enum Status
        { 
            Before_Start = 0,
            Set_Start_Point = 1,
            Set_End_Point = 2,
            Set_Obstacle = 3,
            Set_Run = 4,
        }
        public enum Algorithm
        { 
            Astar = 0,
            Digkstra = 1,
            Both = 2,
        }
        public Detail_Astar()
        {
            InitializeComponent();
        }

        public class MyButton : Button
        {
            int x, y;
            public int X
            {
                set { x = value; }
                get { return x; }
            }
            public int Y
            {
                set { y = value; }
                get { return y; }
            }
        }
        private void SetInitValue()
        {
            for (int i = 0; i < 30; ++i)
            {
                for (int j = 0; j < 30; ++j)
                {
                    map[i, j] = 0;
                }
            }
        }

        private void Detail_Astar_Load(object sender, EventArgs e)
        {
            label_Astar_performance.Text = "";
            label_dijkstra_performance.Text = "";
            SetInitValue();
            Work_Status(status);
            //button_set.Text = "按下按鈕開始設定";
            for (int i = 0; i < 30; ++i)
            {
                for (int j = 0; j < 30; ++j)
                {
                    myButton[i, j] = new MyButton();
                    myButton[i, j].X = i;
                    myButton[i, j].Y = j;
                    myButton[i, j].Size = new Size(20, 20);
                    myButton[i, j].Location = new Point(i * 20, j * 20);
                    this.Controls.Add(myButton[i, j]);
                    myButton[i, j].MouseDown += MyButton_MouseDown;
                }
            }
        }

        private void MyButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is MyButton clicked_button)
            {
                int x = clicked_button.X;
                int y = clicked_button.Y;
                switch (status)
                {
                    case Status.Set_Start_Point:
                        myButton[x, y].BackColor = Color.Blue;
                        Start.p.X = x;
                        Start.p.Y = y;
                        status = Status.Set_End_Point;
                        Work_Status(status);
                        break;
                    case Status.Set_End_Point:
                        if (x == Start.p.X && y == Start.p.Y)
                        { 
                            MessageBox.Show("不可以把起點終點設在同個位置喔!!", "Oh, no, there is a Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        myButton[x, y].BackColor = Color.Red;
                        End.p.X = x;
                        End.p.Y = y;
                        status = Status.Set_Obstacle;
                        Work_Status(status);
                        break;
                    case Status.Set_Obstacle:
                        if ((x == Start.p.X && y == Start.p.Y) ||(x == End.p.X && y == End.p.Y))
                        {
                            MessageBox.Show("不可以把障礙設在起點/終點喔!!", "Oh, no, there is a Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        myButton[x, y].BackColor = Color.Black;
                        map[y, x] = 1;
                        Work_Status(status);
                        break;
                    default:
                        break;
                }
            }  
        }

        private void button_set_Click(object sender, EventArgs e)
        {
            switch (status)
            {   
                case Status.Before_Start:
                    comboBox_algorithm.Text = Convert.ToString(algorithm);
                    status = Status.Set_Start_Point;
                    Work_Status(status);
                    break;
                case Status.Set_Start_Point:
                    status = Status.Set_End_Point;
                    Work_Status(status);
                    break;
                case Status.Set_End_Point:
                    status = Status.Set_Obstacle;
                    Work_Status(status);
                    break;
                case Status.Set_Obstacle:
                    status = Status.Set_Run;
                    Work_Status(status);
                    switch (algorithm)
                    {
                        case Algorithm.Astar:
                            RunAstar();
                            break;
                        case Algorithm.Digkstra:
                            RunDijkstra();
                            break;
                        case Algorithm.Both:
                            RunAstar();
                            RunDijkstra();
                            break;
                        default:
                            break;
                    }
                    break;
                case Status.Set_Run:
                    status = Status.Before_Start;
                    Work_Status(status);
                    Clear();
                    break;
                default:
                    break;
            }
        }
        public void RunAstar()
        {
            Astar astar = new Astar(map, (COST)10, 30, 30);
            List<Node> WayMap = new List<Node>();
            astar.Search_4_way(Start, End);
            WayMap = astar.NodeLine(Start, End);
            Console.Write("Astar's time : ");
            Console.WriteLine(astar.time);
            if (WayMap == null)
            {
                MessageBox.Show("路被封死了, " + (algorithm) + "演算法找不到路徑喔!!", "Oh, no, there is a Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            WayMap.Reverse();
            astar.time = Math.Round(astar.time, 4);
            label_Astar_performance.Text = "Astar演算法花的時間 : " + Convert.ToString(astar.time) + "us";
            foreach (Node node in WayMap)
            {
                myButton[node.p.X, node.p.Y].BackColor = Color.Yellow;
                Refresh();
            }
            myButton[End.p.X, End.p.Y].BackColor = Color.Red;
        }
        public void RunDijkstra()
        {
            Dijkstra dijkstra = new Dijkstra(map, (COST)10, 30, 30);
            List<Node> WayMap = new List<Node>();
            dijkstra.Search_4_way(Start, End);
            WayMap = dijkstra.NodeLine(Start, End);
            //Console.Write("Dijkstra's time : ");
            //Console.WriteLine(dijkstra.time);
            if (WayMap == null)
            {
                MessageBox.Show("路被封死了, " + (algorithm) + "演算法找不到路徑喔!!", "Oh, no, there is a Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            WayMap.Reverse();
            dijkstra.time = Math.Round(dijkstra.time, 4);
            label_dijkstra_performance.Text = "Dijkstra 演算法花的時間" + Convert.ToString(dijkstra.time) + "us";
            foreach (Node node in WayMap)
            {
                myButton[node.p.X, node.p.Y].BackColor = Color.Green;
                Refresh();
            }
            myButton[End.p.X, End.p.Y].BackColor = Color.Red;
        }

        private void comboBox_algorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBox_algorithm.SelectedItem == "Astar") algorithm = Algorithm.Astar;
            else if ((string)comboBox_algorithm.SelectedItem == "Dijkstra") algorithm = Algorithm.Digkstra;
            else if ((string)comboBox_algorithm.SelectedItem == "Both") algorithm = Algorithm.Both;
            else algorithm = Algorithm.Astar;
            //Console.WriteLine(algorithm);
        }
        public void Work_Status(Status status)
        {
            switch (status)
            {   
                case Status.Before_Start:
                    label_Astar_performance.Text = "";
                    label_dijkstra_performance.Text = "";
                    label_now_status.Text = "請按下開始鍵";
                    button_set.Text = "開始";
                    button_random.Visible = false;
                    label_Astar_performance.Visible = false;
                    label_dijkstra_performance.Visible=false;
                    comboBox_algorithm.Enabled = true;
                    break;
                case Status.Set_Start_Point:
                    label_now_status.Text = "請隨意設定一個起點";
                    button_set.Text = "下一步";
                    button_set.Enabled = false;
                    comboBox_algorithm.Enabled = false;
                    break;
                case Status.Set_End_Point:
                    label_now_status.Text = "請隨意設定一個終點";
                    button_set.Text = "下一步";
                    break;
                case Status.Set_Obstacle:
                    label_now_status.Text = "請隨意設定障礙或是按下隨機生成";
                    button_set.Text = "查看執行結果";
                    button_set.Enabled = true;
                    if(flag != 1)
                        button_random.Enabled = false;
                    else button_random.Enabled = true;
                    button_random.Visible = true;

                    //button_random.Enabled = true;
                    break;
                case Status.Set_Run:
                    label_now_status.Text = "正在跑" + algorithm + "所找到的路徑";
                    if (algorithm == Algorithm.Astar)
                        label_Astar_performance.Visible = true;
                    else if (algorithm == Algorithm.Digkstra)
                        label_dijkstra_performance.Visible = true;
                    else if (algorithm == Algorithm.Both)
                    { 
                        label_Astar_performance.Visible = true;
                        label_dijkstra_performance.Visible = true;
                    }
                    button_set.Text = "重置";
                    button_random.Visible = false;
                    flag = 1;
                    break;
                default:
                    break;
            }
        }

        private void button_random_Click(object sender, EventArgs e)
        {
            flag = 0;
            Random random = new Random();
            for (int i = 0; i < 30; ++i)
            {
                for (int j = 0; j < 30; ++j)
                {
                    int a = random.Next(0, 3);
                    if (a < 2) a = 0;
                    else a = 1;

                    if ((Start.p.X == i - 1 && Start.p.Y == j - 1) || (Start.p.X == i && Start.p.Y == j - 1) || (Start.p.X == i + 1 && Start.p.Y == j - 1)) a = 0;
                    if ((Start.p.X == i - 1 && Start.p.Y == j) || (Start.p.X == i && Start.p.Y == j) || (Start.p.X == i + 1 && Start.p.Y == j)) a = 0;
                    if ((Start.p.X == i - 1 && Start.p.Y == j + 1) || (Start.p.X == i && Start.p.Y == j + 1) || (Start.p.X == i + 1 && Start.p.Y == j + 1)) a = 0;
                    if ((End.p.X == i - 1 && End.p.Y == j - 1) || (End.p.X == i && End.p.Y == j - 1) || (End.p.X == i + 1 && End.p.Y == j - 1)) a = 0;
                    if ((End.p.X == i - 1 && End.p.Y == j) || (End.p.X == i && End.p.Y == j) || (End.p.X == i + 1 && End.p.Y == j)) a = 0;
                    if ((End.p.X == i - 1 && End.p.Y == j + 1) || (End.p.X == i && End.p.Y == j + 1) || (End.p.X == i + 1 && End.p.Y == j + 1)) a = 0;
                    map[j, i] = a;
                    if (a == 1) myButton[i, j].BackColor = Color.Black;
                }
            }
            button_random.Enabled = false;
            //button_random.Visible = false;
        }
        public void Clear()
        {
            for (int i = 0; i < 30; ++i)
            {
                for (int j = 0; j < 30; ++j)
                {
                    map[j, i] = 0;
                    myButton[i, j].BackColor = Color.Transparent;
                }
            }
        }
    }
}
