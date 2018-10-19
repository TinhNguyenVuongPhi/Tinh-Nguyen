using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_COMPISITE
{
    interface IChargeStrategy
    {
        bool charge(List<IBattery> elems);
        bool discharge(List<IBattery> elems);

    }
}
