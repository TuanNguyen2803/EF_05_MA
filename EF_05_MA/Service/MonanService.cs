using EF_05_MA.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EF_05_MA.Service
{
    internal class MonanService : IMonan
    {
        private readonly AppDbContext dbContext;
        public MonanService()
        {
            dbContext = new AppDbContext();
        }
        public void Themlistcaccongthuc()
        {
            Console.WriteLine("Nhap so luong cong thuc");
            int soluong=int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mon an Id");
            int MonanID=int.Parse(Console.ReadLine());
            for(int i = 0;i< soluong; i++)
            {
                Themcaccongthuc(MonanID);
            }
        }
        public void Themcaccongthuc(int monanID)
        {
            var check= dbContext.Monan.FirstOrDefault(x=>x.MonanID==monanID);
            if(check==null)
            {
                Console.WriteLine("Mon an chua ton tai");
            }
            else
            {
                Congthuc congthuc = new Congthuc();
                congthuc.MonanID = monanID;
                congthuc.Nhap();
                var checknl=dbContext.Nguyenlieu.FirstOrDefault(x=>x.NguyenlieuID==congthuc.NguyenlieuID);
                if(checknl==null)
                {
                    Console.WriteLine("Nguyen lieu chua ton tai");
                }
                else
                {
                    congthuc.NguyenlieuID=checknl.NguyenlieuID;
                    dbContext.Congthucs.Add(congthuc);
                    dbContext.SaveChanges();
                    Console.WriteLine("Them thanh cong");
                }
            }
        }

        public void Themmonan(int loaimonanID)
        {
            var checkl = dbContext.Loaimonan.FirstOrDefault(x => x.LoaimonanID == loaimonanID);
            if (checkl != null)
            {
                
               Monan monan=new Monan();
                monan.LoaimonanID = loaimonanID;
                monan.Nhap();
             
                dbContext.Monan.Add(monan);
                dbContext.SaveChanges();
                Console.WriteLine("Them thanh cong");
            }
            else
            {
                Console.WriteLine("Them that bai");
            }
        }

        public void Timkiem(string tenmon,string tennguyenlieu)
        {
            var check = dbContext.Monan.Include(x => x.Congthucs).ThenInclude(y => y.Nguyenlieu).ToList()
                 .Where(x => x.Tenmon.ToLower().Contains(tenmon.ToLower()) &&
                 x.Congthucs.Any(y => y.Nguyenlieu.Tennguyenlieu.ToLower().Contains(tennguyenlieu.ToLower()))).ToList();
            if (check==null)
            {
                Console.WriteLine("Khong tim thay mon an nao");
            }
            else
            {
                Console.WriteLine($"Cac mon an co ten {tenmon} va co nguyen lieu {tennguyenlieu} :");
                foreach(var i in check)
                {
                    Console.WriteLine($"Mon {i.Tenmon}");
                }
            }
        }

        public void Xoaloaimonan(int LoaimonanID)
        {
            var checkl = dbContext.Loaimonan.FirstOrDefault(x => x.LoaimonanID == LoaimonanID);
            if (checkl != null)
            {
               dbContext.Loaimonan.Remove(checkl);
                dbContext.SaveChanges();
                Console.WriteLine("Xoa thanh cong");
            }
            else
            {
                Console.WriteLine("Xoa that bai");
            }
        }
    }
}
