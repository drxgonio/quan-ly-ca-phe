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
    class Employees_BLL
    {
        ConnectDB conn = new ConnectDB();
    
        public void InsertEmployees(Employees_DTO nv)
        {
            conn.Connect();
            string a = "InsertEmployees('"+nv.TenNV+"','"+nv.NgaySinh+"',' "+nv.DiaChi+"','"+nv.Sdt+"','"+ nv.MatKhau+"')";
            conn.KetNoi(a);
        }
        public void RemoveEmployees(Employees_DTO pr)
        {
            conn.Connect();
            string a = "RemoveEmployees('"+pr.Id+"')";
            conn.KetNoi(a);
        }
        public void UpdateEmployees(Employees_DTO nv)
        {
            conn.Connect();
            string a = "UpdateEmployees('" +nv.Id+"','"+nv.TenNV+"','"+nv.NgaySinh+"','"+nv.DiaChi+"','"+nv.Sdt+"','"+nv.MatKhau+"')";
            conn.KetNoi(a);

        }
    }
}
