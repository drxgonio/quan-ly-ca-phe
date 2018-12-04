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
 
    class Customer_BLL
    {
        ConnectDB conn = new ConnectDB();
        public void InsertCustomer(Customer_DTO nv)
        {
            conn.Connect();
            string a = "InsertCustomer('" + nv.TenKhachHang + "',"+ nv.Tuoi + ", '" + nv.Sdt + "','" + nv.DiaChi + "','" + nv.MaGiamGia + "')";
            conn.KetNoi(a);
        }
        public void RemoveCustomer(Customer_DTO pr)
        {
            conn.Connect();
            string a = "RemoveCustomer('" + pr.Id+ "')";
            conn.KetNoi(a);
        }
        public void UpdateCustomer(Customer_DTO nv)
        {
            conn.Connect();
            string a = "UpdateCustomer('" + nv.Id + "','" + nv.TenKhachHang + "','" + nv.Tuoi + "','" + nv.Sdt + "','" + nv.DiaChi + "','" + nv.MaGiamGia + "')";
            conn.KetNoi(a);

        }
    }
}
