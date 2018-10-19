using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_COMPISITE
{
    class Program
    {
        static void Main(string[] args)
        {
            //thử to 1 Cell có 2u
            IBattery b1 = new Cell(2);
            //hiển thị trình trng pin hiện hành
            Console.WriteLine("DL max của b1 = " + b1.getFullCapacity()
            + ", DL hiện hành = " + b1.ToString());
            //thử np thêm 1u và hiển thị kết qu ể kiểm tra
            b1.charge();
            Console.WriteLine("Dung lợng của b1 sau khi np thêm 1u = "
            + b1.ToString());
            //thử x 4u và hiển thị kết qu ể kiểm tra
            b1.discharge(); b1.discharge(); b1.discharge(); b1.discharge();
            Console.WriteLine("Dung lợng của b1 sau khi x 4u = " + b1.ToString());
            //thử to pin tích hợp
            b1 = new Cell(10);
            IBattery b2 = new Battery(3, 5, false); //dùng chiến lợc np/x MinMax
            IBattery b3 = new Battery(2, 10, false); //dùng chiến lợc np/x MinMax
            b3.gm_add(b1); b3.gm_add(b2);
            Console.WriteLine("Trng thái của b3 = " + b3.ToString());
            //thử x 2u và hiển thị kết qu ể kiểm tra
            b3.discharge(); b3.discharge();
            Console.WriteLine("b3 sau khi x 2u = " + b3.ToString());
            //thử np 2u và hiển thị kết qu ể kiểm tra
            b3.charge(); b3.charge();
            Console.WriteLine("b3 sau khi np 2u = " + b3.ToString());
            Console.Read();

        }
    }
}
