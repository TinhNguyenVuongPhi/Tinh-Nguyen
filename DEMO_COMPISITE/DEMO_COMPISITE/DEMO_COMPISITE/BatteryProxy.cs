using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_COMPISITE
{
    class BatteryProxy : AbstractBattery
    {
        private IBattery master;
        public BatteryProxy(IBattery master)
        {
            this.master = master;
        }
        public override bool charge()
        {
            return master.charge();
        }

        public override bool discharge()
        {
            return master.discharge();
        }

        public override int getCurrentCapacity()
        {
            return master.getCurrentCapacity();
        }

        public override int getFullCapacity()
        {
            return master.getFullCapacity();
        }
        public override string ToString()
        {
            return master.ToString();
        }

    }
}
