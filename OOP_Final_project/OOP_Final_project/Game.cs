using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyAstar;

namespace Game
{

    public enum GameStatus      
    { 

        NON_GAME_MODE = 0,  // 非遊戲狀態, 且有地圖
        GAME_MODE = 1,      // 遊戲狀態
        NON_MAP = 2,        // 非遊戲狀態, 尚未有地圖
    }

    public enum Difficulty  // 難度選擇
    { 
        EASY = 0,           // 簡單
        MEDIUM = 1,         // 中等
        HARD = 2,           // 困難
        NON_CHOOSE = 3,     // 尚未選擇
    }

    public enum MAP_MODE    // 表示地圖是從何而來
    { 
        RANDOM = 0,         // 隨機產生
        USER_HAND_MADE = 1, // 玩家手動設定
        LOAD_FILE = 2,      // 上傳地圖檔
    }
    public abstract class GameObject
    {
        //類別成員
        public Graphics g;
        public GameObject()
        {
            
        }
        //類別成員函式
        abstract public void Draw();
        abstract public Point GetPlace();
    }

    public class Flag : GameObject
    {
        // 類別成員
        public int count;
        public int block_size;
        public Point place;
        int[,] map;
        public Point owncar_place;

        // 類別成員函式
        public Flag(int bs, int[,] m, Graphics graphics)
        {
            block_size = bs;
            g = graphics;
            map = m;
            count = 0;
            place = new Point(0, 0);
            owncar_place = new Point(0, 0);
        }
        public override void Draw()
        {
            int x, y;
            SolidBrush brush_FLAg = new SolidBrush(Color.Yellow);
            while (true)
            {
                Random random = new Random();
                int px = random.Next(1, 40);
                int py = random.Next(1, 30);
                px = px * 20 + 10;
                py = py * 20 + 10;
                for (int i = 0; i < 30; ++i)
                {
                    for (int j = 0; j < 40; ++j)
                    {
                        x = j * 20 + 10;
                        y = i * 20 + 10;
                        if (map[i, j] == 0 && px == x && py == y && (px != 510 && py != 510) && (px != 310 && py != 310))
                        {
                            Point p = new Point(px, py);
                            if (IsFlagHereOK(owncar_place, p))
                            {
                                g.FillRectangle(brush_FLAg, px, py, block_size, block_size);
                                place.X = px;
                                place.Y = py;
                                return;
                            }
                        }
                    }
                }
            }
        }
        public override Point GetPlace()
        {
            return new Point(place.X, place.Y);
        }
        public void SetOwnCarPlace(Point point)
        {
            owncar_place = point;
        }
        public bool IsEnd()
        {
            if (count == 3)
            {
                count = 0;
                return true;
            }
            return false;
        }
        public void ResetCount()
        {
            count = 0;
        }
        public bool IsEatFlag(int Inx, int Iny)
        {
            if (Inx == place.X && Iny == place.Y)
            {
                ++count;
                Draw();
                return true;
            }
            return false;
        }
        public bool IsFlagHereOK(Point owncar, Point flagplace)
        {
            Astar astar = new Astar(map, (COST)10, 40, 30);
            List<Node> WayMap = new List<Node>();
            Node Owncar = new Node((owncar.X - 10) / 20, (owncar.Y - 10) / 20);
            Node FlagPlace = new Node((flagplace.X - 10) / 20, (flagplace.Y - 10) / 20);
            astar.Search_4_way(Owncar, FlagPlace);
            WayMap = astar.NodeLine(Owncar, FlagPlace);
            if (WayMap == null) return false;

            return true;
        }
    }

    public class Car : GameObject
    {
        // 類別成員
        String car_name;
        public Point origin;
        public int[,] map;
        public int block_size;
        public int speed;
        // 類別成員函式
        public Car(Point pt, String car, int[,] MAP, int bs, Graphics graphics)
        {
            car_name = car;
            origin = pt;
            map = MAP;
            g = graphics;
            block_size = bs;
            speed = 20;
        }
        public override void Draw()
        {
            SolidBrush brush_car = new SolidBrush(Color.Blue);
            SolidBrush brush_car2 = new SolidBrush(Color.Red);
            if (car_name == "Owncar") g.FillRectangle(brush_car, origin.X, origin.Y, block_size, block_size);
            else if (car_name == "Computer_car") g.FillRectangle(brush_car2, origin.X, origin.Y, block_size, block_size);
        }
        public override Point GetPlace()
        {
            return new Point(origin.X, origin.Y);
        }
        public void Clear(int Inx, int Iny)
        {
            SolidBrush solidBrush_clear = new SolidBrush(Color.Bisque);
            g.FillRectangle(solidBrush_clear, Inx, Iny, block_size, block_size);
        }
        public bool IsObstacle(int Inx, int Iny)
        {
            int x, y;
            if (Inx < 10 || Inx > 790 || Iny < 10 || Iny > 590) return true;
            for (int i = 0; i < 30; ++i)
            {
                for (int j = 0; j < 40; ++j)
                {
                    x = j * block_size + 10;
                    y = i * block_size + 10;
                    if ((map[i, j] == 1 && Inx == x && Iny == y))
                    {
                        return true;
                    }

                }
            }
            return false;
        }
        public void Move(Keys key)
        {
            if (key == Keys.S)
            {
                if (IsObstacle(origin.X, origin.Y + block_size) == true)
                    return;
                Clear(origin.X, origin.Y);
                origin.Y += speed;
                Draw();
            }
            else if (key == Keys.A)
            {
                if (IsObstacle(origin.X - block_size, origin.Y) == true)
                    return;
                Clear(origin.X, origin.Y);
                origin.X -= speed;
                Draw();
            }
            else if (key == Keys.D)
            {
                if (IsObstacle(origin.X + block_size, origin.Y) == true)
                    return;
                Clear(origin.X, origin.Y);
                origin.X += speed;
                Draw();
            }
            else if (key == Keys.W)
            {
                if (IsObstacle(origin.X, origin.Y - block_size) == true)
                    return;
                Clear(origin.X, origin.Y);
                origin.Y -= speed;
                Draw();
            }

        }
        int Memory_x, Memory_y;
        public void Astar_Move(int Owncar_x, int Owncar_y)
        {
            Astar astar = new Astar(map, (COST)10, 40, 30);
            List<Node> WayMap = new List<Node>();
            Node Start = new Node((origin.X - 10) / 20, (origin.Y - 10) / 20);
            Node End = new Node((Owncar_x - 10) / 20, (Owncar_y - 10) / 20);

            astar.Search_4_way(Start, End);
            WayMap = astar.NodeLine(Start, End);
            Point point = new Point();

            for (int i = 0; i < 1; ++i)
            {
                if (WayMap == null || WayMap.First() == null)
                {
                    Random rand = new Random();
                    int bouns = rand.Next(0, 4);
                    switch (bouns)
                    {
                        case 0:
                            point.X = Memory_x + block_size;
                            point.Y = Memory_y;
                            break;
                        case 1:
                            point.X = Memory_x - block_size;
                            point.Y = Memory_y;
                            break;
                        case 2:
                            point.X = Memory_x;
                            point.Y = Memory_y + block_size;
                            break;
                        case 3:
                            point.X = Memory_x;
                            point.Y = Memory_y - block_size;
                            break;
                    }
                }
                else
                {
                    WayMap.Reverse();
                    point.X = (WayMap.First().p.X) * 20 + 10;
                    point.Y = (WayMap.First().p.Y) * 20 + 10;
                    Memory_x = point.X;
                    Memory_y = point.Y;
                    Console.Write(point.X); Console.Write(" / "); Console.WriteLine(point.Y);
                    Task.Delay(3000);
                }
                // //Move
                if ((point.X - origin.X) == block_size && (point.Y == origin.Y))    // go right
                {
                    if (IsObstacle(origin.X + block_size, origin.Y) == true)
                        return;
                    Clear(origin.X, origin.Y);
                    origin.X += speed;
                    Draw();
                    WayMap.RemoveAt(0);
                    WayMap.Reverse();
                }
                else if ((point.X - origin.X) == -block_size && (point.Y == origin.Y))   // go left
                {
                    if (IsObstacle(origin.X - block_size, origin.Y) == true)
                        return;
                    Clear(origin.X, origin.Y);
                    origin.X -= speed;
                    Draw();
                    WayMap.RemoveAt(0);
                    WayMap.Reverse();
                }
                else if ((point.X == origin.X) && (point.Y - origin.Y) == -block_size)   // go dwon
                {
                    if (IsObstacle(origin.X, origin.Y - block_size) == true)
                        return;
                    Clear(origin.X, origin.Y);
                    origin.Y -= speed;
                    Draw();
                    WayMap.RemoveAt(0);
                    WayMap.Reverse();
                }
                else if ((point.X == origin.X) && (point.Y - origin.Y) == block_size)  // go up
                {
                    if (IsObstacle(origin.X, origin.Y + block_size) == true)
                        return;
                    Clear(origin.X, origin.Y);
                    origin.Y += speed;
                    Draw();
                    WayMap.RemoveAt(0);
                    WayMap.Reverse();
                }

                //WayMap.RemoveAt(0);
                //WayMap.Reverse();

            }
        }
    }
    public class Obstacle : GameObject
    {
        // 類別成員
        public int block_size;
        public int[,] map;
        Point place;
        Point owncar;
        public Obstacle(int b, int[,] MAP, Point Owncar, Graphics graphics)
        {
            g = graphics;
            block_size = b;
            map = MAP;
            place = new Point(0, 0);
            owncar = Owncar;
        }
        public override void Draw()
        {
            int x, y;
            SolidBrush brush_obstacle = new SolidBrush(Color.Gray);
            for (int i = 0; i < 30; ++i)
            {
                for (int j = 0; j < 40; ++j)
                {
                    x = j * 20 + 10;
                    y = i * 20 + 10;
                    if ((x == owncar.X - block_size && y == owncar.Y - block_size) || (x == owncar.X - block_size && y == owncar.Y) || (x == owncar.X - block_size && y == owncar.Y + block_size)) continue;
                    if ((x == owncar.X && y == owncar.Y - block_size) || (x == owncar.X && y == owncar.Y) || (x == owncar.X && y == owncar.Y + block_size)) continue;
                    if ((x == owncar.X + block_size && y == owncar.Y - block_size) || (x == owncar.X + block_size && y == owncar.Y) || (x == owncar.X + block_size && y == owncar.Y + block_size)) continue;
                    if (map[i, j] == 1)
                    {
                        g.FillRectangle(brush_obstacle, x, y, block_size, block_size);
                        
                    }
                }
            }
        }
        public override Point GetPlace()
        {
            return place;
        }
    }
    public class Margin : GameObject
    {
        // 劃出地圖邊框
        public Point Left_UP;
        public Point Right_UP;
        public Point Left_Down;
        public Point Right_Down;

        public Margin(Graphics graphics)
        {
            g = graphics;
            Left_UP = new Point(0, 0);
            Right_UP = new Point(820, 0);
            Left_Down = new Point(0, 620);
            Right_Down = new Point(820, 620);
        }
        public override void Draw()
        {
            SolidBrush solidBrush_margin = new SolidBrush(Color.BurlyWood);
            g.FillRectangle(solidBrush_margin, Left_UP.X, Left_UP.Y, 10, Left_Down.Y);
            g.FillRectangle(solidBrush_margin, Right_UP.X - 10, Right_UP.Y, 10, Left_Down.Y);
            g.FillRectangle(solidBrush_margin, Left_UP.X, Left_UP.Y, Right_UP.X, 10);
            g.FillRectangle(solidBrush_margin, Left_Down.X, Left_Down.Y - 10, Right_UP.X, 10);
        }
        public override Point GetPlace()
        {
            return Left_UP;
        }
    }
}
