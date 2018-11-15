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
    class Products_BLL
    {
        ConnectDB conn = new ConnectDB();
      
        public void InsertProducts(Products_DTO pr)
        {
            conn.Connect();
            string a = "InsertProducts('"+pr.TenSanPham+"'," + pr.Gia+",'"+pr.DanhMuc+ "')";
            conn.KetNoi(a);
        }
        public void RemoveProducts(Products_DTO pr)
        {
            conn.Connect();
            string a = "RemoveProducts('"+pr.Id+"')";
            conn.KetNoi(a);
        }
        public void UpdateProducts(Products_DTO pr)
        {
            conn.Connect();
            string a = "UpdateProducts('"+pr.Id+"','"+pr.TenSanPham+"',"+pr.Gia+",'"+pr.DanhMuc+"')";
            conn.KetNoi(a);

        }
    }
}
