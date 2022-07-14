using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x0 , y0;
        int drawtype, drawwidth, drawstyle;
        Color pencolor_L , pencolor_R;
        Bitmap bg;

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Width = Int32.Parse(WidthdomainUpDown.Text);
            pictureBox1.Height = Int32.Parse(HeightdomainUpDown.Text);
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
        }

        private void blackMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                uppictureBox.BackColor = Color.Black;
            else if(e.Button == MouseButtons.Right)
                downpictureBox.BackColor = Color.Black;
        }

        private void grayMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                uppictureBox.BackColor = Color.Gray;
            else if (e.Button == MouseButtons.Right)
                downpictureBox.BackColor = Color.Gray;
        }

        private void whiteMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                uppictureBox.BackColor = Color.White;
            else if (e.Button == MouseButtons.Right)
                downpictureBox.BackColor= Color.White;
        }

        private void redMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                uppictureBox.BackColor = Color.Red;
            else if (e.Button == MouseButtons.Right)
                downpictureBox.BackColor=(Color)Color.Red;
        }

        private void greenMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                uppictureBox.BackColor = Color.Green;
            else if (e.Button == MouseButtons.Right)
                downpictureBox.BackColor =(Color)Color.Green;

        }

        private void blueMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                uppictureBox.BackColor = Color.Blue;
            else if (e.Button == MouseButtons.Right)
                downpictureBox.BackColor=((Color)Color.Blue);
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible= false;
            button11.Visible = false;
            button10.Visible = false;
            button6.Visible= false;
            drawtype = 1;
            button2.FlatAppearance.BorderSize = 1;
            button3.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.BorderSize = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            button11.Visible = false;
            button10.Visible = false;
            button6.Visible = false;
            drawtype = 2;
            button2.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.BorderSize = 1;
            button4.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.BorderSize = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            button11.Visible = true;
            button10.Visible = true;
            button6.Visible = true;
            drawtype = 3;
            button2.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.BorderSize = 1;
            button5.FlatAppearance.BorderSize = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            button11.Visible = true;
            button10.Visible = true;
            button6.Visible = true;
            drawtype = 4;
            button2.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.BorderSize = 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            drawwidth = 1;
            button9.FlatAppearance.BorderSize = 1;
            button8.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.BorderSize = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            drawwidth = 5;
            button9.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.BorderSize = 1;
            button7.FlatAppearance.BorderSize = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            drawwidth = 10;
            button9.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.BorderSize = 1;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            drawstyle = 1;
            button11.FlatAppearance.BorderSize = 1;
            button10.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.BorderSize = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            drawstyle = 2;
            button11.FlatAppearance.BorderSize = 0;
            button10.FlatAppearance.BorderSize = 1;
            button6.FlatAppearance.BorderSize = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            drawstyle = 3;
            button11.FlatAppearance.BorderSize = 0;
            button10.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.BorderSize = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            button11.Visible = false;
            button10.Visible = false;
            button6.Visible = false;
            pictureBox1.Image = new Bitmap(640, 480);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White); 
            drawtype = 1;
            drawwidth = 1;
            drawstyle = 1;

            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 2;
            button9.FlatStyle = FlatStyle.Flat;
            button9.FlatAppearance.BorderSize = 2;
            button11.FlatStyle = FlatStyle.Flat;
            button11.FlatAppearance.BorderSize = 2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //pencolor_L = uppictureBox.BackColor;
            //pencolor_R = downpictureBox.BackColor;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pencolor_L = uppictureBox.BackColor;
            pencolor_R = downpictureBox.BackColor;
            x0 = e.X;
            y0 = e.Y;
            if (drawtype == 1)
            {

            }
            else if (drawtype == 2)
            {
                bg = new Bitmap(pictureBox1.Image);
            }
            else if (drawtype == 3)
            {
                bg = new Bitmap(pictureBox1.Image);
            }
            else if (drawtype == 4)
            {
                bg = new Bitmap(pictureBox1.Image);
            }

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pencolor_L = uppictureBox.BackColor;
            pencolor_R = downpictureBox.BackColor;
            if (drawtype == 1)
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                if (e.Button == MouseButtons.Left)
                {
                    Pen p = new Pen(pencolor_L, drawwidth);
                    g.DrawLine(p, x0, y0, e.X, e.Y);
                    x0 = e.X;
                    y0 = e.Y;
                    pictureBox1.Refresh();
                }
                else if (e.Button == MouseButtons.Right)
                {
                    Pen p = new Pen(pencolor_R, drawwidth);
                    g.DrawLine(p, x0, y0, e.X, e.Y);
                    x0 = e.X;
                    y0 = e.Y;
                    pictureBox1.Refresh();
                }
            }
            else if(drawtype == 2)
            {
                if (e.Button == MouseButtons.Left)
                {
                    Bitmap bf = new Bitmap(bg);
                    Graphics gg = Graphics.FromImage(bf);
                    Pen pp = new Pen(pencolor_L, drawwidth);
                    gg.DrawLine(pp, x0, y0, e.X, e.Y);
                    pictureBox1.Image = bf;
                }
                else if (e.Button == MouseButtons.Right)
                {
                    Bitmap bf = new Bitmap(bg);
                    Graphics gg = Graphics.FromImage(bf);
                    Pen pp = new Pen(pencolor_R, drawwidth);
                    gg.DrawLine(pp, x0, y0, e.X, e.Y);
                    pictureBox1.Image = bf;
                }
            }
            else if (drawtype == 3)
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                if (e.Button == MouseButtons.Left)
                {
                    Bitmap bf = new Bitmap(bg);
                    Graphics gg = Graphics.FromImage(bf);
                    Pen pp = new Pen(pencolor_L, drawwidth);
                    Brush b = new SolidBrush(pencolor_L);
                    Brush b1 = new SolidBrush(pencolor_R);
                    if (drawstyle == 1)
                    {
                        gg.DrawEllipse(pp, x0, y0, e.X - x0, e.Y - y0);
                    }
                    else if(drawstyle == 2)
                    {
                        gg.FillEllipse(b, x0, y0, e.X - x0, e.Y - y0);
                    }
                    else if (drawstyle == 3)
                    {
                        gg.FillEllipse(b1, x0, y0, e.X - x0, e.Y - y0);
                        gg.DrawEllipse(pp, x0, y0, e.X - x0, e.Y - y0);
                    }
                    pictureBox1.Image = bf;
                }
                else if (e.Button == MouseButtons.Right)
                {
                    Bitmap bf = new Bitmap(bg);
                    Graphics gg = Graphics.FromImage(bf);
                    Pen pp = new Pen(pencolor_R, drawwidth);
                    Brush b = new SolidBrush(pencolor_R);
                    Brush b1 = new SolidBrush(pencolor_L);
                    if (drawstyle == 1)
                    {
                        gg.DrawEllipse(pp, x0, y0, e.X - x0, e.Y - y0);
                    }
                    else if (drawstyle == 2)
                    {
                        gg.FillEllipse(b, x0, y0, e.X - x0, e.Y - y0);
                    }
                    else if (drawstyle == 3)
                    {
                        gg.FillEllipse(b1, x0, y0, e.X - x0, e.Y - y0);
                        gg.DrawEllipse(pp, x0, y0, e.X - x0, e.Y - y0);
                    }
                    pictureBox1.Image = bf;
                }
            }
            else if (drawtype == 4)
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                if (e.Button == MouseButtons.Left)
                {
                    Bitmap bf = new Bitmap(bg);
                    Graphics gg = Graphics.FromImage(bf);
                    Pen pp = new Pen(pencolor_L, drawwidth);
                    Brush b = new SolidBrush(pencolor_L);
                    Brush b1 = new SolidBrush(pencolor_R);
                    if (drawstyle == 1)
                    {
                        gg.DrawRectangle(pp, x0, y0, e.X - x0, e.Y - y0);
                    }
                    else if (drawstyle == 2)
                    {
                        gg.FillRectangle(b, x0, y0, e.X - x0, e.Y - y0);
                    }
                    else if (drawstyle == 3)
                    {
                        gg.FillRectangle(b1, x0, y0, e.X - x0, e.Y - y0);
                        gg.DrawRectangle(pp, x0, y0, e.X - x0, e.Y - y0);
                    }
                    pictureBox1.Image = bf;
                }
                else if (e.Button == MouseButtons.Right)
                {
                    Bitmap bf = new Bitmap(bg);
                    Graphics gg = Graphics.FromImage(bf);
                    Pen pp = new Pen(pencolor_R, drawwidth);
                    Brush b = new SolidBrush(pencolor_R);
                    Brush b1 = new SolidBrush(pencolor_L);
                    if (drawstyle == 1)
                    {
                        gg.DrawRectangle(pp, x0, y0, e.X - x0, e.Y - y0);
                    }
                    else if (drawstyle == 2)
                    {
                        gg.FillRectangle(b, x0, y0, e.X - x0, e.Y - y0);
                    }
                    else if (drawstyle == 3)
                    {
                        gg.FillRectangle(b1, x0, y0, e.X - x0, e.Y - y0);
                        gg.DrawRectangle(pp, x0, y0, e.X - x0, e.Y - y0);
                    }
                    pictureBox1.Image = bf;
                }
            }
        }
    }
}
