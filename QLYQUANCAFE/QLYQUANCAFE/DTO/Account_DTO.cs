using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYQUANCAFE.DTO
{
    class Account_DTO
    {
        private string tenNV;
        private string taiKhoan;
        private string password;
        private object id;

        public string Password { get => password; set => password = value; }
        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public object Id { get => id; set => id = value; }
    }
}
