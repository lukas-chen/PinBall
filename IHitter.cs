using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinBall
{
    interface IHitter
    {
        /// <summary>
        /// 找畫面上欠扁的，被扁的就傳回來，找不到就null
        /// </summary>
        /// <returns></returns>
        IHittable HitOthers();
    }
}
