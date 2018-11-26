﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;

namespace Snake
{
    enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
    class Snake
    {
        int length=5;//蛇长
        Color snakeColor=Color.Red;//蛇身颜色
        ArrayList snake = new ArrayList();
        public Snake(Control c)
        {
            for(int i=0;i<length;i++)
            {
                Label l=new Label();
                l.BackColor=snakeColor;
                l.Size=new Size(20,20);
                l.BorderStyle = BorderStyle.FixedSingle;
                l.Location = new Point(300 + i * 20, 240);
                snake.Add(l);
                c.Controls.Add(l);
            }
        }
        public void Move(Direction d) //蛇移动
        {
            for (int i = length - 1; i > 0;i-- )
            {
                ((Label)snake[i]).Location = ((Label)snake[i - 1]).Location;
            }
                switch (d)
                {
                    case Direction.Up:
                        { 
                            ((Label)snake[0]).Top -= 20;
                        }
                        break;
                    case Direction.Down:
                        {
                            ((Label)snake[0]).Top += 20;
                        }
                        break;
                    case Direction.Left:
                        {
                            ((Label)snake[0]).Left -= 20;
                        }
                        break;
                    case Direction.Right:
                        {
                            ((Label)snake[0]).Left += 20;
                        }
                        break;
                }
        }
        public bool SnakeDie()//判断蛇是否撞墙
        {
            if (((Label)snake[0]).Top <= 0 || ((Label)snake[0]).Top >= 460 || ((Label)snake[0]).Left <= 0 || ((Label)snake[0]).Left >= 580)
            {
                return true;
            }
            return false;
        }
    }
}
