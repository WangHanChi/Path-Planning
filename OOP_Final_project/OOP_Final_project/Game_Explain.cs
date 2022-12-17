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
    public partial class Game_Explain : Form
    {
        public Game_Explain()
        {
            InitializeComponent();
        }

        private void Game_Explain_Load(object sender, EventArgs e)
        {
            string ss = "歡迎來到 Astar Run                        \n" +
                "\n在這個遊戲中呢, 你是一名即將畢業的研究生, 你的教授想要你發Journal才會放你離開\n" +
                "但是你知道自己以及教授的研究內容沒料, 根本投了Journal也不會被採納發刊\n" +
                "而此時, 你的離校手續只剩下三個程序沒辦完, 辦完就可以直接高歌離席\n" +
                "所以你與教授就展開了一場飛車追逐戰, 你飛車追逐戰中駕駛的是一輛藍色車子\n" +
                "而你的教授駕駛的是紅色車子, 你需要躲避教授的追捕, 並且抵達三個黃色的處室\n" +
                "才可以安穩的畢業, 否則就只能乖乖地寫Journal了, 加油!!!\n" +
                "\n注意!! 你的指導教授非常邪惡, 假如你選的難度是困難的話, 他會派出\n" +
                "他的多年老友一起來追捕你, 塊陶啊!!!!";
            label_detail.Text = ss;
            label_detail.Visible = true;
            pictureBox_graduate.Visible = true;
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                label_detail.Visible = false;
                pictureBox_keypad.Visible = true;
                label_key.Visible = true;
                pictureBox_expalin_icon.Visible = true;
                button_next.Text = "上一頁";
                flag = true;
                pictureBox_graduate.Visible = false;
            }
            else if (flag == true)
            {
                label_detail.Visible = true;
                pictureBox_keypad.Visible = false;
                label_key.Visible = false;
                pictureBox_expalin_icon.Visible = false;
                button_next.Text = "下一頁";
                pictureBox_graduate.Visible = true;
                flag = false;
            }
            
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
