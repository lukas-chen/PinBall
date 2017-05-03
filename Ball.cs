using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinBall
{
    class Ball : RadioButton, IHitter, IMovable
    {
        public IHittable HitOthers()
        {
            foreach (Control c in this.Parent.Controls)
            {
                if (c is IHittable)
                {
                    IHittable obj = (IHittable)c;
                    if (obj.HitBy(this)) return obj;
                }
            }
            return null;
        }

        int dx = 5;
        int dy = -5;

        void IMovable.Move()
        {
            this.Left += dx;
            this.Top += dy;

            if (this.Left <= 0 || this.Right >= this.Parent.ClientRectangle.Width) dx = -dx;
            if (this.Top <= 0 || this.Bottom >= this.Parent.ClientRectangle.Height) dy = -dy;

            IHittable obj = this.HitOthers();
            if (obj != null)
            {
                Control c = (Control)obj;
                if (dy > 0)
                    this.Top = c.Top - this.Height;
                else
                    this.Top = c.Bottom;

                dy = -dy;

                //if (obj is Brick)
                //    Brick b = (Brick)obj;

            }
        }
    }
}
