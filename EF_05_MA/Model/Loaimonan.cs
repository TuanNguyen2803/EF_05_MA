using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_05_MA.Model
{
    internal class Loaimonan
    {
        [Key]
        public int LoaimonanID { get;set; }
        public string Tenloai { get;set; }
        public string Mota { get;set; }
        public List<Monan> Monans { get;set; }
    }
}
