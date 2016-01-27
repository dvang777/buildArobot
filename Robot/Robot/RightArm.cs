using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class RightArm : Arm
    {
        bool fire = true;
        public void fireCannon()
        {
            fire = true;
            Console.WriteLine("BooM!!");
        }

    }
}
