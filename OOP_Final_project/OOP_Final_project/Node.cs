using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAstar
{
    public class Weight
    {
        public  Point p;
        public  int g, h;
        public Weight()
        { 
            p = new Point(0, 0);
            g = 0;
            h = 0;
        }
        public Weight(Point p, int g, int h)
        {
            this.p = p;
            this.g = g;
            this.h = h;
        }
        public Weight(int x, int y, int g, int h)
        {
            p = new Point(x, y);
            this.g = g;
            this.h = h;
        }
        public int Get_H()
        { 
            return h;
        }
        public int Get_H(Weight weight)
        { 
            return weight.Get_H();
        }
        public int Get_G()
        {
            return g;
        }
        public int Get_G(Weight weight)
        {
            return weight.Get_G();
        }
        public Point Get_Point()
        { 
            return p;
        }
        public Point Get_Point(Weight weight)
        {
            return weight.Get_Point();
        }

    }
    public class Node : Weight
    {
        public Node parent;

        public Node()
        { 
            // default constructor
        }

        public Node(int X, int Y)
        {
            this.p.X = X;
            this.p.Y = Y;
            this.g = 0;
            this.h = 0;
            this.parent = null;
        }
        public Node(int X, int Y, int G, int H, Node P)
        {
            this.p.X = X;
            this.p.Y = Y;
            this.g = G;
            this.h = H;
            this.parent = P;
        }
    }
}
