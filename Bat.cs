using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinBall
{
    class Bat : Button, IHittable, IMovable
    {
        protected override void OnMouseMove(MouseEventArgs mevent)
        {
            base.OnMouseMove(mevent);

            if (mevent.Button == MouseButtons.Left)
            {
                this.Left += mevent.X - this.Width / 2;
                this.Top += mevent.Y - this.Height / 2;
            }
        }


        public bool HitBy(IHitter hitter)
        {
            Control c = (Control)hitter;
            Rectangle r1 = new Rectangle(c.Left, c.Top, c.Width, c.Height);
            Rectangle r2 = new Rectangle(this.Left, this.Top, this.Width, this.Height);
            bool hit = r1.IntersectsWith(r2);
            return hit;
        }

        void IMovable.Move()
        {

        }
    }
}
