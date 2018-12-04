using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLYQUANCAFE.DTO;
using QLYQUANCAFE.Connect;
using MongoDB.Bson;
//tham chiếu thư viện này:
using MongoDB.Driver;

namespace QLYQUANCAFE.BLL
{
    class Account_BLL
    {
        ConnectDB conn = new ConnectDB();
        public void InsertAccount(Account_DTO nv)
        {
            conn.Connect();
            string a = "InsertAccount('" + nv.TenNV + "','" + nv.TaiKhoan + "','" + nv.Password + "')";
            conn.KetNoi(a);
        }
        public void RemoveAccount(Account_DTO nv)
        {
            conn.Connect();
            string a = "RemoveAccount('" + nv.Id + "','" + nv.TaiKhoan + "')";
            conn.KetNoi(a);
        }
        public void UpdateUser(Account_DTO nv)
        {
            conn.Connect();
            string a = "UpdateUser('" + nv.Id + "','" + nv.TenNV + "','" + nv.TaiKhoan + "','" + nv.Password + "')";
            conn.KetNoi(a);

        }
   
    }
}
