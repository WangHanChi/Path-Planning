using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyAstar;


namespace OOP_Final_project
{
    public partial class Form1 : Form
    {
        enum mycc
        {
            wall,
            start,
            des
        }

        mycc mychoose = mycc.wall;

        int[,] R = new int[10, 10] {
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 0, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 0, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 0, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 0, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 0, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 0, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }

            };

        mybutton[,] mybut = new mybutton[20, 20];

        int[,] myR = new int[20, 20];


        Node pa = new Node();
        Node pb = new Node();

        void init()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    myR[i, j] = 1;
                    mybut[i, j].BackColor = Color.Transparent;
                }
            }
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Astar ax = new Astar(R, (COST)10);

            //定义起始位置
            Node pa = new Node();
            pa.x = 1;
            pa.y = 1;

            //定义目的地
            Node pb = new Node();
            pb.x = 8;
            pb.y = 8;

            List<Node> myp = new List<Node>();
            myp = ax.NodeLine(pa, pb);
            foreach (Node p in myp)
            {
                //   textBox1.AppendText(p.ToString() + " ");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    mybut[i, j] = new mybutton();
                    mybut[i, j].X = i;
                    mybut[i, j].Y = j;
                    mybut[i, j].Size = new Size(20, 20);
                    mybut[i, j].Location = new Point(i * 20, j * 20);
                    this.Controls.Add(mybut[i, j]);
                    mybut[i, j].MouseDown += Form1_MouseDown;
                }
            }

        }

        void Form1_MouseDown(object sender, MouseEventArgs e)
        {

            mybutton myb = (mybutton)sender;
            int x = myb.X;
            int y = myb.Y;
            if (mychoose == mycc.wall)
            {
                mybut[x, y].BackColor = Color.Black;
                myR[y, x] = 0;
            }

            if (mychoose == mycc.start)
            {
                mybut[x, y].BackColor = Color.Green;
                //  myR[x, y] = 1;
                pa.x = x;
                pa.y = y;
            }

            if (mychoose == mycc.des)
            {
                mybut[x, y].BackColor = Color.Red;
                //  myR[x, y] = 1;
                pb.x = x;
                pb.y = y;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            init();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mychoose = mycc.wall;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mychoose = mycc.start;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mychoose = mycc.des;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Astar ax = new Astar(myR, (COST)10);
            List<Node> myp = new List<Node>();

            myp = ax.NodeLine(pa, pb);
            
            foreach (Node p in myp)
            {
                mybut[p.x, p.y].BackColor = Color.Yellow;
                Refresh();
            }
            //int i = 0;
            //MyPoint pt = new MyPoint();
            //pt.x = myp[i].x;
            //pt.y = myp[i].y;

            //mybut[pt.x, pt.y].BackColor = Color.Yellow;
            mybut[pb.x, pb.y].BackColor = Color.Red;
            //i++;
        }
    }


    public class mybutton : Button
    {
        int x;
        int y;
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
}
