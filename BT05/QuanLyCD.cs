using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT05
{
    class QuanLyCD
    {
        private CD[] ds;
        private int n;
        public QuanLyCD()
        {
            ds = new CD[100];
        }
        public QuanLyCD(int sophantu)
        {
            ds = new CD[sophantu];
            n = 0;
        }
        public void ThemCD(CD cd)
        {
            if (n >= ds.Length)
            {
                Console.WriteLine("Danh sach da day");
            }
            else
            {
                if (!kiemTraTrungCD(cd.Macd))
                    ds[n++] = cd;
                else
                {
                    Console.WriteLine("Trung ma CD");
                }
            }

        }
        private bool kiemTraTrungCD(int MaCD)
        {
            for (int i=0;i<n;i++)
            {
                if (ds[i].Macd==MaCD)
                {
                    return true;
                }
            }
            return false;
        }
        public double tinhGiaTB()
        {
            int tongGia = 0;
                for( int i = 0; i < n; i++)
            {
                tongGia += ds[i].Dongia;
            }
            return (double)tongGia / n;
        }
        public void Xuat()
        {
            Console.WriteLine("{0,10} {1,30} {2,30} {3,10}{4,15}", "MaCD", "TuaCD", "Ca si", "So bai hat", "Gia thanh");
            for(int i = 0; i<n;i++)
            {
                Console.WriteLine(ds[i].ToString());
            }
        }
        public void SapXepGiamTheoGiaThanh()
        {
            CD tam;
            for (int i = 0; i<n -1;i++)
            {
                for (int j = i +1; j<n; j++)
                {
                    if(ds[i].Dongia < ds[j].Dongia)
                    {
                        tam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tam;
                    }
                }
            }
        }
        public void SapXepTangTheoTuaCD()
        {
            CD tam;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (ds[i].Tuacd.CompareTo( ds[j].Tuacd)>0)
                    {
                        tam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tam;
                    }
                }
            }
        }
    }
}
