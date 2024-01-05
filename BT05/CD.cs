using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT05
{
    class CD
    {
        private int MaCD, SoBaiHat, DonGia;
        private string TuaCD, CaSi;
        public CD()
        {

        }
        public CD(int MaCD, int SoBaiHat, int DonGia, string TuaCD, string CaSi)
        {
            this.MaCD = MaCD;
            this.TuaCD = TuaCD;
            this.CaSi = CaSi;
            this.SoBaiHat = SoBaiHat;
            this.DonGia = DonGia;
        }
        public int Macd
        {
            set { this.MaCD = value; }
            get { return MaCD; }
        }
        public string Tuacd
        {
            set { this.TuaCD = value; }
            get { return TuaCD; }
        }
        public string Casi
        {
            set { this.CaSi = value; }
            get { return CaSi; }
        }
        public int Sobaihat
        {
            set { this.SoBaiHat = value; }
            get { return SoBaiHat; }
        }
        public int Dongia
        {
            set { this.DonGia = value; }
            get { return DonGia; }
        }
        public string ToString()
        {
            return string.Format("{0,10} {1,30} {2,30} {3,10}{4,15:#,##0}", MaCD, TuaCD, CaSi, SoBaiHat, DonGia);
        }
    }
}
