using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_COMPISITE
{
    class Battery : AbstractBattery
    {
        private List<IBattery> elems = new List<IBattery>();
        private IChargeStrategy myStrat;
        public Battery(int nCells, int capCells, bool bycycles)
        {
            for (int i = 0; i < nCells; i++)
            {
                elems.Add(new Cell(capCells));
            }
            if (bycycles)
                myStrat = new StratRoundRobin();
            else
                myStrat = new StratMinMax();
        }
        public override void gm_add(IBattery b)
        {
            elems.Add(b);
        }
        public override void gm_remove(IBattery b)
        {
            elems.Remove(b);
        }
        public override bool charge()
        {
            return myStrat.charge(elems);
        }
        public override bool discharge()
        {
            return myStrat.discharge(elems);
        }
        public override int getCurrentCapacity()
        {
            int sum = 0;
            foreach (IBattery c in elems)
            {
                sum += c.getCurrentCapacity();
            }
            return sum;
        }
        public override int getFullCapacity()
        {
            int sum = 0;
            foreach (IBattery c in elems)
            {
                sum += c.getFullCapacity();
            }
            return sum;
        }
        public override String ToString()
        {
            String buf = "[";
            foreach (IBattery c in elems)
            {
                buf += c + ", ";
            }
            return buf.Substring(0, buf.Length - 2) + "]";
        }

    }
}
