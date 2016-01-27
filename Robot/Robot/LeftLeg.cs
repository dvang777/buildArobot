using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class LeftLeg : Leg
    {
        bool charge;
        public void chargingUnit()
        {
            if(charge == true){ 
            Console.WriteLine("Fully Charged");
        }
            else
            {
                Console.WriteLine("recharge now");
            }
        }
    }
}
