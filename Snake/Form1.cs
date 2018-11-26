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
        Direction dir;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           s=new Snake(panel1);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s.Move(dir);
            if (s.SnakeDie() == true)
            {
                timer1.Enabled = false;
                MessageBox.Show("你输了");
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
            }
        }

    }
}
