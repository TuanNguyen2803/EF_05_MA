using EF_05_MA.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_05_MA.View
{
    internal class MonanView
    {
        MonanService monanService=new MonanService();
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("--------------Chuong trinh quan ly mon an--------------");
            Console.WriteLine("1. Them mon an ");
            Console.WriteLine("2. Them cac cong thuc");
            Console.WriteLine("3. Xoa loai mon an");
            Console.WriteLine("4.Tim kiem");
            Console.WriteLine("5.Thoat");
            Console.WriteLine();
            Console.Write("Chon: ");
            int luaChon = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Action(luaChon);
        }
        private void Action(int luaChon)
        {
            switch (luaChon)
            {
                case 1:
                    Console.WriteLine("Nhap mon an id");
                    int MonanId=int.Parse(Console.ReadLine());
                    monanService.Themmonan(MonanId);
                    break;
                case 2:
                    monanService.Themlistcaccongthuc();
                    break;
                case 3:
                    Console.WriteLine("Nhap loai mon an id");
                    int LoaimonanID= int.Parse(Console.ReadLine());
                    monanService.Xoaloaimonan(LoaimonanID);
                    break;
                case 4:
                    Console.WriteLine("Nhap ten mon");
                    string ten = Console.ReadLine();
                    Console.WriteLine("Nhap nguyen lieu ");
                    string nguyenlieu=Console.ReadLine();
                    monanService.Timkiem(ten, nguyenlieu);
                    break;             
                case 5:
                    Environment.Exit(0);
                    break;
            }
            Console.ReadKey();
            Menu();
        }
    }
}
