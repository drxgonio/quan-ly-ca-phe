using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYQUANCAFE.DTO
{
    class Products_DTO
    {
        private object id;
        private string tenSanPham;
        private double gia;
        private string danhMuc;

        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public double Gia { get => gia; set => gia = value; }
        public string DanhMuc { get => danhMuc; set => danhMuc = value; }
        public object Id { get => id; set => id = value; }
    }
}
