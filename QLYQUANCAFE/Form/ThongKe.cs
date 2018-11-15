using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLYQUANCAFE.DTO;
using QLYQUANCAFE.BLL;
using QLYQUANCAFE.Connect;
using MongoDB.Bson;
//tham chiếu thư viện này:
using MongoDB.Driver;

namespace QLYQUANCAFE.Form
{
    public partial class ThongKe : UserControl
    {
        ConnectDB conn = new ConnectDB();
        public ThongKe()
        {
            InitializeComponent();
        }
        private void LoadGridView()
        {
            conn.Connect();


            var reult = conn.database.RunCommand<BsonDocument>(new BsonDocument { { "eval", "thongKeHoaDon('"+ txtNgay.Text+"')" } });

            var array = reult["retval"].AsBsonArray;
            foreach (var document in array)
            {
                DataGridViewRow row = (DataGridViewRow)gridviewNV.Rows[0].Clone();
                // row.Cells[0].Value = b["_id"].AsObjectId;
                row.Cells[0].Value = document["tenBan"].AsString;
                row.Cells[1].Value = (document["soHoaDon"].AsInt64).ToString() ;
                row.Cells[2].Value = document["khachHang"].AsString;
                row.Cells[3].Value = document["phucVu"].AsString;
                row.Cells[4].Value = (document["tenSanPham"].AsBsonArray).ToString();
                row.Cells[5].Value = (document["gia"].AsDouble).ToString();
                row.Cells[6].Value = document["_id"].AsObjectId;
                gridviewNV.Rows.Add(row);
            }

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            LoadGridView();
        }
    }
}
