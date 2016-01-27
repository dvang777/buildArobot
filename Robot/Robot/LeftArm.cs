using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class LeftArm : Arm
    {
        bool fireGun;
        public void gatlingGun()
        {
            if (fireGun == true)
            {
                Console.WriteLine("Tat Tat Tat Tat");
            }
        }
    }
}
