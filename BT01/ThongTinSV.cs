using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT01
{
    class ThongTinSV
    {
        private string MSSV, HoTenSV;
        private float LT, TH;
        
        public ThongTinSV(string MSSV,string HoTenSV, float LT,float TH)
        {
            this.MSSV = MSSV;
            this.HoTenSV = HoTenSV;
            this.LT = LT;
            this.TH = TH;
        }
        public string MaSoSV()
        {
            Console.Write(" Ma sinh vien: ");
            MSSV = Console.ReadLine();
            return MSSV;
        }
        public string HoTen()
        {
            Console.Write(" Ho Ten: ");
            HoTenSV = Console.ReadLine();
            return HoTenSV;
        }
    }
}
