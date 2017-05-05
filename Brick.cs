using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinBall
{
    class Brick : Button, IMovable, IHitter, IHittable
    {
        //private BrickStatus _Status = BrickStatus.Normal;
        public BrickStatus Status { get; set; } = BrickStatus.Normal;

        public bool HitBy(IHitter hitter)
        {
            if (this.Status == BrickStatus.Dead) return false;
            Control c = (Control)hitter;
            Rectangle r1 = new Rectangle(c.Left, c.Top, c.Width, c.Height);
            Rectangle r2 = new Rectangle(this.Left, this.Top, this.Width, this.Height);
            bool hit = r1.IntersectsWith(r2);

            if (hit && (hitter is Ball || hitter is Bullet))
            {
                switch (this.Status)
                {
                    case BrickStatus.Normal:
                        this.Status = BrickStatus.Falling;
                        break;
                    case BrickStatus.Falling:
                        this.Status = BrickStatus.Floating;
                        break;
                    case BrickStatus.Floating:
                        this.Status = BrickStatus.Falling;
                        break;
                }
            }

            return hit;
        }

        public IHittable HitOthers()
        {
            foreach (Control c in this.Parent.Controls)
            {
                if (c is IHittable && c != this)
                {
                    IHittable obj = (IHittable)c;
                    if (obj.HitBy(this)) return obj;
                }
            }
            return null;
        }

        void IMovable.Move()
        {
            switch (this.Status)
            {
                case BrickStatus.Normal:
                    break;
                case BrickStatus.Falling:
                    this.Top += 2;
                    if (this.Top >= this.Parent.ClientRectangle.Height)
                    {
                        this.Status = BrickStatus.Dead;
                    }
                    break;
                case BrickStatus.Floating:
                    this.Top -= 2;

                    IHittable obj = this.HitOthers();
                    if (obj != null && (this.Top <= 4 || obj is Brick))
                    {
                        this.Status = BrickStatus.Normal;
                        this.Top += 3;
                    }
                    break;
                case BrickStatus.Dead:
                    break;
                default:
                    break;
            }
        }
    }
}
