using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_COMPISITE
{
    class BatteryBoost : BatteryProxy
    {
        bool dolt = true;
        bool isEmpty = false;
        public BatteryBoost(IBattery master):base(master){

        }
        public override bool discharge()
        {
            if (isEmpty) return false;
            if (dolt)
            {
                isEmpty = base.discharge();
            }
            dolt = !dolt;
            return isEmpty;
        }
        public override bool charge()
        {
            isEmpty = true;
            return base.charge();
        }
    }
}
