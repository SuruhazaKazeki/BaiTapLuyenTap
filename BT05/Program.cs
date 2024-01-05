using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT05
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            QuanLyCD quanLyCD = new QuanLyCD();
            int chon = 0;
            do
            {
                Console.WriteLine("=====================Chuong Trinh quan ly CD=====================");
                Console.WriteLine("1. Them CD");
                Console.WriteLine("2. Tinh gia thanh trung binh");
                Console.WriteLine("3. Sap xep  cd giam dan theo gia thanh");
                Console.WriteLine("4. Sap xem CD giam dan theo tua CD");
                Console.WriteLine("5. Xuat toan bo CD");
                Console.WriteLine("0. Thoat!");
                Console.WriteLine("=================================================================");
                Console.Write(" Chon: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        CD cD = new CD();
                        Console.WriteLine("Nhap ma cd: ");
                        cD.Macd = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap tua cd: ");
                        cD.Tuacd = Console.ReadLine();
                        Console.WriteLine("Nhap ten ca si: ");
                        cD.Casi = Console.ReadLine();
                        Console.WriteLine("Nhap so bai hat: ");
                        cD.Sobaihat = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap don gia: ");
                        cD.Dongia = int.Parse(Console.ReadLine());
                        quanLyCD.ThemCD(cD);
                        break;
                    case 2:
                        double kq = quanLyCD.tinhGiaTB();
                        Console.WriteLine(" Gia thanh trung binh : {0:#,##0.00", kq);
                        break;
                    case 3:
                        quanLyCD.SapXepGiamTheoGiaThanh();
                        Console.WriteLine("Da sap xep theo gia thanh giam dan");
                        break;
                    case 4:
                        quanLyCD.SapXepTangTheoTuaCD();
                        Console.WriteLine("Da sap xep theo tua cd tang dan");
                        break;
                    case 5:
                        break;
                    case 0:
                        Console.WriteLine("Ket thuc chuong trinh!");
                        Console.ReadKey();
                        break;
                } 
            } while (chon != 0);
        }
    }
}
