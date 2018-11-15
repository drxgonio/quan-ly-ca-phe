using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYQUANCAFE.DTO
{
    class Customer_DTO
    {
        private string tenKhachHang;
        private int tuoi;
        private string diaChi;
        private string maGiamGia;
        private string sdt;
        private object id;
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }

        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public string MaGiamGia { get => maGiamGia; set => maGiamGia = value; }
  
        public object Id { get => id; set => id = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
