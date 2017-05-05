using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinBall
{
    class Bullet : Label, IMovable, IHitter
    {
        public Bullet()
        {
            this.Text = "|";
            this.ForeColor = Color.Red;
            this.Font = new Font("Arial", 18);
            this.Width = 3;
            this.BackColor = Color.Red;
        }

        public BulletState State { get; set; } = BulletState.Shot;

        public IHittable HitOthers()
        {
            foreach (Control c in this.Parent.Controls)
            {
                if (c is Brick)
                {
                    IHittable obj = (IHittable)c;
                    if (obj.HitBy(this)) return obj;
                }
            }
            return null;
        }

        void IMovable.Move()
        {
            
            switch (this.State)
            {
                case BulletState.Shot:
                    this.Top -= 5;
                    IHittable obj = this.HitOthers();
                    if (obj != null)
                    {
                        Brick b = (Brick)obj;
                        b.Status = BrickStatus.Dead;
                        b.Top = this.Parent.ClientRectangle.Height + 1000;
                        this.State = BulletState.Dead;
                    }
                    break;
                case BulletState.Dead:
                    this.Top = this.Parent.ClientRectangle.Height + 1000;
                    break;
            }

            
            
        }
    }
}
