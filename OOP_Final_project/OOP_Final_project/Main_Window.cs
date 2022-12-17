using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OOP_Final_project.Detail_Astar;

namespace OOP_Final_project
{
    public partial class Main_Window : Form
    {
        public Main_Window()
        {
            InitializeComponent();
        }

        private void button_go_game_Click(object sender, EventArgs e)
        {

            Enter_Game enter_Game = new Enter_Game();
            this.Hide();
            enter_Game.ShowDialog();
            this.Show();

        }

        private void button_game_detail_Click(object sender, EventArgs e)
        {
            Game_Explain game_Explain = new Game_Explain();
            this.Hide();
            game_Explain.ShowDialog();
            this.Show();
        }

        private void button_about_astar_Click(object sender, EventArgs e)
        {
            About_Astar about_Astar = new About_Astar();
            this.Hide();
            about_Astar.ShowDialog();
            this.Show();
        }
    }
}
