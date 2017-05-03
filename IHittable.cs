using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinBall
{
    interface IHittable
    {
        bool HitBy(IHitter hitter);
    }
}
