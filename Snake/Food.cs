using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    class Food
    {
        Color foodColor = Color.Green;
        Point location;
        Label l;
        public Point Location
        {
            get { return location; }
            set { location = value; }
        }
        public Food(Control c)//生成食物
        {
            l = new Label();
            l.BackColor = foodColor;
            l.Size = new Size(20, 20);
            l.BorderStyle = BorderStyle.FixedSingle;
            Random r=new Random();
            l.Location = new Point(r.Next(2,28)*20, r.Next(2,22)*20);
            c.Controls.Add(l);
            location = l.Location;
        }
        public void updateLocation(Control c)//更新食物位置,吃完可以再生成一个
        {
            c.Controls.Remove(l);
            Random r=new Random();
            l.Location=new Point(r.Next(2,28)*20, r.Next(2,22)*20);
            Location = l.Location;
            c.Controls.Add(l);
        }
    }
}
