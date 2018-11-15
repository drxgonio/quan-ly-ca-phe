using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using DevExpress.XtraEditors;
using QLYQUANCAFE.DTO;
using QLYQUANCAFE.Form;
namespace QLYQUANCAFE.BLL
{
    class DataRport : DevExpress.Xpo.XPLiteObject
    {
        private string tenBan;
        private int soHoaDon;
        private string khachHang;
        private string nguoiThuNgan;
        private BsonArray sanPham;
        private double tongTien;
        private string thoigian;

       
        public string TenBan { get => tenBan; set => tenBan = value; }
        public int SoHoaDon { get => soHoaDon; set => soHoaDon = value; }
        public string KhachHang { get => khachHang; set => khachHang = value; }
        public string NguoiThuNgan { get => nguoiThuNgan; set => nguoiThuNgan = value; }

        public double TongTien { get => tongTien; set => tongTien = value; }
        public BsonArray SanPham { get => sanPham; set => sanPham = value; }
        public string Thoigian { get => thoigian; set => thoigian = value; }
       
    }
}
