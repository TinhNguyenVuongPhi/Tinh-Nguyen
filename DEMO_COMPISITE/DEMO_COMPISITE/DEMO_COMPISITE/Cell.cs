using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_COMPISITE
{
    class Cell:AbstractBattery
    {
        private int capacity;
        private int fullCapacity;
        //tác vụ khởi to battery
        public Cell(int capamax)
        {
            fullCapacity = capamax;
            capacity = capamax;
        }
        //tác vụ np 1u vào battery
        public override bool charge()
        {
            //version cha xử lý np quá công suất
            capacity++;
            return true;
        }
        //tác vụ thi 1u khi battery
        public override bool discharge()
        {
            //version cha xử lý cn công suất
            capacity--;
            return true;
        }
        //tác vụ tham kho công suất hiện hành của battery
        public override int getCurrentCapacity()
        {
            return capacity;
        }
        //tác vụ tham kho công suất max của battery
        public override int getFullCapacity()
        {
            return fullCapacity;
        }
        //tác vụ gii mã trng thái battery thành chuỗi vn bn
        public override String ToString() { return capacity.ToString(); }
    }
}
