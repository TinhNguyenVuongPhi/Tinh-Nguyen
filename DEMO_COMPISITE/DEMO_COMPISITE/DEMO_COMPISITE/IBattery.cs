using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_COMPISITE
{
    interface IBattery
    {
        //1. Nhóm các tác vụ chức nng của ối tợng (tích hợp hay thành phần)
        //tác vụ tham kho công suất max của battery
        int getFullCapacity();
        //tác vụ tham kho công suất hiện hành của battery
        int getCurrentCapacity();
        //tác vụ thi 1u (n vị iện nng) khi battery
        bool discharge();
        //tác vụ np 1u vào battery
        bool charge();
        //2. Nhóm các tác vụ qun lý các thành phần con của ối tợng tích hợp
        //tác vụ thêm thành phần b vào battery hiện hành
        void gm_add(IBattery b);
        //tác vụ bớt thành phần b ra kh
    }
}
