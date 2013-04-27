using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Monopoly
{
    class Player
    {
        private string name;
        private int place;
        private int state;
        private int money;
        private Point position;
        public PictureBox figure;

        public Player() // 預設建構子
        {
            place = 0;
            state = 0;
            money = 1000;
            name = "";
        }

        public Player(string n,string path, Size s, Point p)
        {
            figure = new PictureBox();
            figure.Load(path);
            figure.Size = s;
            figure.Location = p;
            name = n;
        }

        public string Name
        {
            //相當於string getName();
            get
            {
                return name;
            }

            //相當於void setName(string);
            set
            {
                name = value;
            }
        }

        public int Place
        {
            get { return place; }
            set { place = value; }
        }

        public int State
        {
            get { return state; }
            set { state = value; }
        }

        public int Money
        {
            get { return money; }
            set { money = value; }
        }

        public Point Position
        {
            get { return position; }
            set { position = value; }
        }

        public void move(Point from, Point to, int step)
        {
            int dirX = to.X - from.X;
            int dirY = to.Y - from.Y;

            figure.Location = new Point(Position.X + (dirX / step), Position.Y + (dirY / step));
        }

    }
}
