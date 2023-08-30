using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_05_MA.Service
{
    internal interface IMonan
    {
        void Themmonan(int loaimonanID);
        void Themcaccongthuc(int monanID);
        void Xoaloaimonan(int LoaimonanID);
        void Timkiem(string tenmon, string tennguyenlieu);
    }
}
