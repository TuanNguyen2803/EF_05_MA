using EF_05_MA.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_05_MA.Model
{
    internal class Monan
    {
        [Key]
        public int MonanID { get; set; }
        public int LoaimonanID { get; set; }
        public string Tenmon { get;set; }
        public double Giaban { get; set; }
        public string Gioithieu { get; set; }
        public string Cachlam { get; set; }
        public Loaimonan Loaimonan { get; set; }
        public List<Congthuc>Congthucs { get; set; }
        public void Nhap()
        { 
            Tenmon = Inputhelper.InputStr("Nhap ten mon an", "Ten mon khong hop le", 0, 20);
            Giaban = Inputhelper.InputDouble("Nhap gia ban", "Gia ban khong hop le");
            Gioithieu = Inputhelper.InputStr("Gioi thieu ", "Thong tin khong hop le", 0, 100);
            Cachlam = Inputhelper.InputStr("Cach lam", "Khong hop le", 0, int.MaxValue);
        }

    }
}
