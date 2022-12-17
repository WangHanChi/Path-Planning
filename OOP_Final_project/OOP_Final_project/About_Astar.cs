using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Final_project
{
    public partial class About_Astar : Form
    {
        public About_Astar()
        {
            InitializeComponent();
        }

        private void About_Astar_Load(object sender, EventArgs e)
        {
            string ss = "A* 搜尋演算法（A* search algorithm）是一種在圖形平面上\n有多個節點的路徑，" +
                "求出最低通過成本的演算法。\n常用於遊戲中的NPC的移動計算，或網路遊戲的BOT的移動計算上。" +
                "\n\n該演算法綜合了最佳優先搜尋和Dijkstra演算法的優點\n 在進行啟發式搜尋提高演算法效率的同時\n" +
                "可以保證找到一條最佳路徑。";
            label_Astar.Text = ss;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_watch_astar_Click(object sender, EventArgs e)
        {
            Show_Astar show_Astar = new Show_Astar();
            this.Hide();
            show_Astar.ShowDialog();
            this.Show();
        }

        private void button_view_detail_Click(object sender, EventArgs e)
        {
            Detail_Astar detail_Astar = new Detail_Astar();
            this.Hide();
            detail_Astar.ShowDialog();
            this.Show();
        }
    }
}
