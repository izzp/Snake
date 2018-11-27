using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        Snake s;
        Food f;
        Direction dir;
        int fraction=0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           s=new Snake(panel1);
           f = new Food(panel1);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            s.Move(dir);
            if (s.SnakeDie() == true)
            {
                timer1.Enabled = false;
                MessageBox.Show("你输了，你的得分为"+fraction+"分");
            }
            if(s.Location==f.Location)
            {
                f.updateLocation(panel1);
                s.SnakeLong(panel1);
                fraction++;//分数加1
                labelFraction.Text = ("分数：" + fraction);//更新分数
            }
            
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.A:
                case Keys.Left: dir = Direction.Left; break;
                case Keys.W:
                case Keys.Up:dir=Direction.Up; break;
                case Keys.S:
                case Keys.Down:dir=Direction.Down; break;
                case Keys.D:
                case Keys.Right:dir=Direction.Right; break;
                case Keys.Space:
                    {
                        if(timer1.Enabled==true)
                        {
                            timer1.Enabled = false;
                            this.Text = ("贪吃蛇------游戏已暂停");
                        }
                        else
                        {
                            timer1.Enabled = true;
                            this.Text = ("贪吃蛇");
                        }
                    }
                    break;
            }
        }

        private void 开始游戏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("雨心Dream");
        }
    }
}
