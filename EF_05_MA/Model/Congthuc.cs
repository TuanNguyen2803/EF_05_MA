using EF_05_MA.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_05_MA.Model
{
    internal class Congthuc
    {
        public int CongthucID { get; set; }
        public int NguyenlieuID { get;set; }
        public int MonanID { get; set; }
        public int Soluong { get; set; }
        public string Donvitinh { get; set; }
        public Monan Monan { get; set; }
        public Nguyenlieu Nguyenlieu { get; set; }
        public void Nhap()
        {
            NguyenlieuID = Inputhelper.InputInt("Nhap nguyen lieu id ", "Khong hop le")
;            //Soluong = Inputhelper.InputInt("So luong", "Khong hop le");
            Donvitinh = Inputhelper.InputStr("Don vi tinh:", "Khong hop le", 0, 10);
        }
    }
}
