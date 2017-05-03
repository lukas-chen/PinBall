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
            Control c = (Control)hitter;
            Rectangle r1 = new Rectangle(c.Left, c.Top, c.Width, c.Height);
            Rectangle r2 = new Rectangle(this.Left, this.Top, this.Width, this.Height);
            bool hit = r1.IntersectsWith(r2);
            return hit;
        }

        public IHittable HitOthers()
        {
            return null;
        }

        void IMovable.Move()
        {
        }
    }
}
