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
    class OrderDrink_BLL
    {
        ConnectDB conn = new ConnectDB();
        //Thêm Giáo Viên vào CSDL
        public void InsertEmployees(OrderDrink_DTO nv)
        {
            conn.Connect();
            string a = "InsertOrder('" + nv.TenBan + "','" + nv.SoHoaDon + "',' " + nv.KhachHang + "','" + nv.NguoiThuNgan + "'," + nv.SanPham + "," + nv.TongTien+ ",'" + nv.Thoigian + "')";
            conn.KetNoi(a);
        }
    }
}
