using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CuaHangSach.Models;
namespace CuaHangSach.Models
{
    public class Giohang
    {
        dbQLBanSachDataContext data = new dbQLBanSachDataContext();
        public int iMasacch { get; set; }
        public string sTensach { get; set; }
        public string sAnhbia { get; set; }
        public double dDongia { get; set; }
        public int iSoLuong { get; set; }
        public double Thanhtien { get { return iSoLuong * dDongia; } }

        public Giohang(int Masach)
        {
            iMasacch = Masach;
            SACH sach = data.SACHes.Single(n => n.Masach == iMasacch);
            sTensach = sach.Tensach;
            sAnhbia = sach.Anhbia;
            dDongia = double.Parse(sach.Giaban.ToString());
            iSoLuong = 1;
        }
    }
}