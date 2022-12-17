using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MyAstar
{
    public enum COST : int
    { 
        FOUR_FORWARD_MOVE = 10,
        EIGTH_FORWARD_MOVE = 14
    };
    public class Astar
    {
        // class member
        public List<Node> OpenList = new List<Node> ();
        public List<Node> CloseList = new List<Node> ();
        public int[, ] bitmap;
        public COST cost;
        public int length;
        public int height;
        public double time;
        // member function
        
        public Astar(int[,] BITMAP, COST cc, int len, int hei)        // constructor
        {
            this.bitmap = BITMAP;
            this.cost = cc;
            this.height = hei;
            this.length = len;
            time = 0;
        }

        public Astar()      // default constructor
        {
            
        }
        public bool IsObstcale(Node n)
        {
            if (bitmap[n.p.X, n.p.Y] == 1)
                return true;
            return false;
        }
        public int Return_G(Node n)
        {
            if (n.parent == null) return 0;
            if (n.p.X == n.parent.p.X || n.p.Y == n.parent.p.Y)
                return n.parent.g + Convert.ToInt32(cost);

            return - 1;
        }

        public int Return_H(Node n, Node end)
        {
            return Math.Abs((end.p.X - n.p.X) * Convert.ToInt32(cost)) + Math.Abs((end.p.Y - n.p.Y) * Convert.ToInt32(cost));
        }

        public void Search_4_way(Node now, Node end  )
        {
            int Center_X = now.p.X;
            int Center_Y = now.p.Y;
            // left
            Base_Search_Loop(Center_X - 1, Center_Y, now, end);
            Base_Search_Loop(Center_X + 1, Center_Y, now, end);
            Base_Search_Loop(Center_X, Center_Y - 1, now, end);
            Base_Search_Loop(Center_X, Center_Y + 1, now, end);
        }

        public void Base_Search_Loop(int cx, int cy, Node now, Node end)
        {
            Node tmp = new Node(cx, cy);
            if (cx >= 0 && cx < length && cy >= 0 && cy < height && !(cx == now.p.X && cy == now.p.Y))
            {
                if (bitmap[cy, cx] != 1 && !IsInCloseList(tmp))
                {
                    if (IsInOpenlist(tmp))
                    {
                        Node node = GetNodeFormOpenList(cx, cy);
                        int NEW_G = 0;
                        if (cx == node.p.X || cy == node.p.Y)
                            NEW_G = now.g + 10;

                        if (NEW_G < node.g)
                        {
                            OpenList.Remove(node);
                            node.parent = now;
                            node.g = NEW_G;
                            OpenList.Add(node);
                        }
                    }
                    else
                    {
                        Node node = new Node();
                        node.p.X = cx;
                        node.p.Y = cy;
                        node.parent = now;
                        node.g = Return_G(node);
                        node.h = Return_H(node, end);
                        OpenList.Add(node);
                    }
                }
            }
        }
        public Node SearchGameMode(Node now, Node end)
        {
            List<int> tmp = new List<int>();
            // left
            Node Lnode = new Node(now.p.X - 1, now.p.Y);
            int LF = Return_H(Lnode, end);
            tmp.Add(LF);
            Node Rnode = new Node(now.p.X + 1, now.p.Y);
            int RF = Return_H(Rnode, end);
            tmp.Add(RF);
            Node Unode = new Node(now.p.X, now.p.Y - 1);
            int UF = Return_H(Unode, end);
            tmp.Add(UF);
            Node Dnode = new Node(now.p.X, now.p.Y + 1);
            int DF = Return_H(Dnode, end);
            tmp.Add(DF);
            tmp.Sort();
            if (tmp.First() == LF) return Lnode;
            else if (tmp.First() == RF) return Rnode;
            else if (tmp.First() == UF) return Unode;
            else return Dnode;

        }

        public bool IsInOpenlist(Node n)
        {
            foreach (Node node in OpenList)
            {
                if (node.p.X == n.p.X && node.p.Y == n.p.Y)
                    return true;
            }
            return false;
        }
        public Node GetNodeFormOpenList(int x, int y)
        {
            foreach (Node node in OpenList)
            {
                if (node.p.X == x && node.p.Y == y)
                    return node;
            }
            Console.WriteLine("can't find the node in openlist!!!");
            return null;
        }
        public bool IsInCloseList(Node n)
        {
            foreach (Node node in CloseList)
            {
                if (node.p.X == n.p.X && node.p.Y == n.p.Y)
                    return true;
            }
            return false;
        }
        public Node GetNodeFormCloseList(int x, int y)
        {
            foreach (Node node in CloseList)
            {
                if (node.p.X == x && node.p.Y == y)
                    return node;
            }
            Console.WriteLine("can't find the node in closelist!!!");
            return null;
        }
        public Node ReturnMinF()
        {
            Node node = null;
            foreach (Node tmp in OpenList)
            { 
                if(node == null || (node.g + node.h) > (tmp.g + tmp.h))
                    node = tmp;
            }
            return node;
        }
        
        virtual public List<Node> NodeLine(Node start, Node end)
        { 
            Stopwatch sw = Stopwatch.StartNew();
            sw.Reset();
            sw.Start();
            List<Node> map = new List<Node> ();
            OpenList.Add(start);
            while (!(IsInOpenlist(end)) || OpenList.Count == 0)
            { 
                Node node = ReturnMinF();
                if(node == null) return null;
                OpenList.Remove(node);
                CloseList.Add(node);
                Search_4_way(node, end);
            }

            Node tmp = GetNodeFormOpenList(end.p.X, end.p.Y);
            while (tmp.parent != null)
            { 
                map.Add(tmp);
                tmp = tmp.parent;
            }
            sw.Stop();
            time = sw.ElapsedTicks * 1000000F  / Stopwatch.Frequency;
            // map.Reverse();
            return map;
        }
        

    }
    // Dijkstra algorithm
    public class Dijkstra : Astar
    {
        public Dijkstra(int[,] BITMAP, COST cc, int len, int hei)        // constructor
        {
            
            this.bitmap = BITMAP;
            this.cost = cc;
            this.length = len;
            this.height = hei;
            time = 0;
        }

        public Dijkstra()      // default constructor
        {
            
        }
        public Node ReturnMinG()
        {
            Node node = null;
            foreach (Node tmp in OpenList)
            {
                if (node == null || (node.g) > tmp.g)
                    node = tmp;
            }
            return node;
        }
        public override List<Node> NodeLine(Node start, Node end) 
        {
            Stopwatch sw = new Stopwatch();
            sw.Reset();
            sw.Start();
            List<Node> map = new List<Node>();
            OpenList.Add(start);
            while (!(IsInOpenlist(end)) || OpenList.Count == 0)
            {
                Node node = ReturnMinG();
                if (node == null) return null;
                OpenList.Remove(node);
                CloseList.Add(node);
                Search_4_way(node, end);
            }

            Node tmp = GetNodeFormOpenList(end.p.X, end.p.Y);
            while (tmp.parent != null)
            {
                map.Add(tmp);
                tmp = tmp.parent;
            }
            sw.Stop();
            time = sw.ElapsedTicks * 1000000F / Stopwatch.Frequency;
            // map.Reverse();
            return map;
        }
    }
}
