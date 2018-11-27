namespace Snake
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.开始游戏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.游戏设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelFraction = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(16, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 599);
            this.panel1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始游戏ToolStripMenuItem,
            this.游戏设置ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 开始游戏ToolStripMenuItem
            // 
            this.开始游戏ToolStripMenuItem.Name = "开始游戏ToolStripMenuItem";
            this.开始游戏ToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.开始游戏ToolStripMenuItem.Text = "开始游戏（空格）";
            this.开始游戏ToolStripMenuItem.Click += new System.EventHandler(this.开始游戏ToolStripMenuItem_Click);
            // 
            // 游戏设置ToolStripMenuItem
            // 
            this.游戏设置ToolStripMenuItem.Name = "游戏设置ToolStripMenuItem";
            this.游戏设置ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.游戏设置ToolStripMenuItem.Text = "游戏设置";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // labelFraction
            // 
            this.labelFraction.AutoSize = true;
            this.labelFraction.Location = new System.Drawing.Point(838, 310);
            this.labelFraction.Name = "labelFraction";
            this.labelFraction.Size = new System.Drawing.Size(60, 15);
            this.labelFraction.TabIndex = 3;
            this.labelFraction.Text = "分数：0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(822, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 196);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Linen;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "上：W键 上键";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Linen;
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "下：S键 下键";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Linen;
            this.label4.Location = new System.Drawing.Point(6, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "左：A键 左键";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Linen;
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "右：D键 右键";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Linen;
            this.label7.Location = new System.Drawing.Point(6, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "继续：空格";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Linen;
            this.label6.Location = new System.Drawing.Point(6, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "暂停：空格";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(976, 646);
            this.Controls.Add(this.labelFraction);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = " 贪吃蛇";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 开始游戏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 游戏设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Label labelFraction;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

