using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_COMPISITE
{
    class StratRoundRobin : IChargeStrategy
    {
        int aCharge = -1;
        int aDeCharge = -1;
        public bool charge(List<IBattery> elems)
        {
            aCharge = (aCharge + 1) % elems.Count;
            return elems[aCharge].charge();
        }
        public bool discharge(List<IBattery> elems)
        {
            aDeCharge = (aDeCharge + 1) % elems.Count;
            return elems[aDeCharge].discharge();
        }
    }
}
