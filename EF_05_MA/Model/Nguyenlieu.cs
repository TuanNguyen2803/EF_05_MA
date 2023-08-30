using EF_05_MA.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_05_MA.Model
{
    internal class Nguyenlieu
    {
        public int NguyenlieuID { get; set; }
        public string Tennguyenlieu { get; set; }
        public string GhiChu { get; set; }
        public List<Congthuc> Congthucs { get; set; }
        public void Nhap()
        {
            Tennguyenlieu = Inputhelper.InputStr("Ten nguyen lieu:", "khong hop le", 0, 20);
            GhiChu=Inputhelper.InputStr("Ghi chu:","Khong hop le",0,int.MaxValue);
        }
    }
}
