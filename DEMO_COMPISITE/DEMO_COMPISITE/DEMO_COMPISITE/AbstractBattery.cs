using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_COMPISITE
{
    abstract class AbstractBattery:IBattery
    {
        //tác vụ tham kho công suất max của battery
        public abstract int getFullCapacity();
        //tác vụ tham kho công suất hiện hành của battery
        public abstract int getCurrentCapacity();
        //tác vụ thi 1u khi battery
        public abstract bool discharge();
        //tác vụ np 1u vào battery
        public abstract bool charge();
        //tác vụ thêm battery b vào battery hiện hành
        public virtual void gm_add(IBattery b) { }
        //tác vụ bớt battery b ra khi battery hiện hành
        public virtual void gm_remove(IBattery b) { }
    }
}
