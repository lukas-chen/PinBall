using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinBall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is IMovable)
                {
                    IMovable obj = (IMovable)c;
                    obj.Move();
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.X:
                    //if(bat1.Left <= this.ClientRectangle)
                    bat1.Left += 10;
                    break;
                case Keys.Z:
                    bat1.Left -= 10;
                    break;
                case Keys.Space:
                    Bullet bullet = new Bullet();
                    bullet.Text = "||";
                    bullet.Top = bat1.Top - bat1.Height;
                    bullet.Left = bat1.Left + bat1.Width / 2 - 5;
                    this.Controls.Add(bullet);
                    break;
            }
        }
    }
}
