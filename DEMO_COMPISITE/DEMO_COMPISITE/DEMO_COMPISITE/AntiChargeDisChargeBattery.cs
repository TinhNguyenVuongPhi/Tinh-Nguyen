using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_COMPISITE
{
    class AntiChargeDisChargeBattery: BatteryProxy
    {
        public AntiChargeDisChargeBattery(IBattery master) : base(master)
        {
        }
        public override bool charge()
        {
            if (getCurrentCapacity() < getFullCapacity())
            {
                return base.charge();
            }
            else return false;
        }
        public override bool discharge()
        {
            if (getCurrentCapacity() > 0)
                return base.discharge();
            else
                return false;
        }

    }
}
