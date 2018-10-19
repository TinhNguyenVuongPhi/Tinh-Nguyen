﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_COMPISITE
{
    class StratMinMax: IChargeStrategy
    {
        public bool charge(List<IBattery> elems)
        {
            int cellmin = 0;
            int capamin = Int32.MaxValue;
            for (int c = 0; c < elems.Count; c++)
            {
                int capaCur = elems[c].getCurrentCapacity();
                if (capaCur < capamin)
                {
                    cellmin = c;
                    capamin = capaCur;
                }
            }
            return elems[cellmin].charge();
        }

        public bool discharge(List<IBattery> elems)
        {
            int cellmax = 0;
            int capamax = Int32.MinValue;
            for (int c = 0; c < elems.Count(); c++)
            {
                int capaCur = elems[c].getCurrentCapacity();
                if (capaCur > capamax)
                {
                    cellmax = c;
                    capamax = capaCur;
                }
            }
            return elems[cellmax].discharge();
        }
    }
}
