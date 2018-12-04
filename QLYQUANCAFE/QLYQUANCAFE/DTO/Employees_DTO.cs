using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYQUANCAFE.DTO
{
    class Employees_DTO
    {
        private object id;
        private string tenNV;
        private string ngaySinh;
        private string diaChi;
        private string sdt;
        private string matKhau;

        public string TenNV { get => tenNV; set => tenNV = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public object Id { get => id; set => id = value; }
    }
}
