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
    public partial class Customer : UserControl
    {
        private bool add = false, update = false;
        private Customer_BLL dgBUS = new Customer_BLL();
        ConnectDB conn = new ConnectDB();
        private void RemoveGridView()
        {
            gridviewKH.Rows.Clear();
            gridviewKH.Refresh();
        }
        private Customer_DTO  LayTTKH()
        {
            Customer_DTO dg = new Customer_DTO();
            dg.TenKhachHang = txtTenKhachHang.Text;
            dg.Tuoi = int.Parse(txtTuoi.Text);
            dg.DiaChi = txtDiaChi.Text;
            dg.Sdt = txtSDT.Text;
            dg.MaGiamGia = txtMaGiamGia.Text;
            dg.Id = lbID.Text;
            return dg;
        }
        private void LoadGridView()
        {
            conn.Connect();


            var reult = conn.database.RunCommand<BsonDocument>(new BsonDocument { { "eval", "getCustomer()" } });

            var array = reult["retval"].AsBsonArray;
            foreach (var document in array)
            {
                DataGridViewRow row = (DataGridViewRow)gridviewKH.Rows[0].Clone();
                // row.Cells[0].Value = b["_id"].AsObjectId;
                row.Cells[0].Value = document["HoTen"].AsString;
                row.Cells[1].Value = (document["tuoi"].AsInt64).ToString();
                row.Cells[2].Value = document["DiaChi"].AsString;
                row.Cells[3].Value = (document["dienThoai"].AsInt64).ToString();
                row.Cells[4].Value = document["maGiamGia"].AsString;
                row.Cells[5].Value = document["_id"].AsObjectId;
                gridviewKH.Rows.Add(row);
            }

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            add = true; update = false;
            txtTenKhachHang.Enabled = true;
            txtMaGiamGia.Enabled = true;
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;
            txtTuoi.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            update = true; add = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            txtTenKhachHang.Enabled = true;
            txtMaGiamGia.Enabled = true;
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;
            txtTuoi.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Customer_DTO tg = LayTTKH();

            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            if (MessageBox.Show("Bạn có muốn xóa Nhân Viên: " + txtTenKhachHang.Text + " không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    RemoveGridView();
                    dgBUS.RemoveCustomer(tg);
                    Customer_Load(sender, e);



                }
                catch (Exception)
                {
                    MessageBox.Show("Mời bạn nhập Chọn Sản phẩm cần xóa!!!!!");
                }
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            LoadGridView();
            gridviewKH_CellClick(null, null);
        }

        private void gridviewKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Thứ tự dòng hiện hành
                int r = gridviewKH.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel
                this.txtTenKhachHang.Text =
                gridviewKH.Rows[r].Cells[0].Value.ToString();
                this.txtTuoi.Text =
                gridviewKH.Rows[r].Cells[1].Value.ToString();
                this.txtDiaChi.Text =
                gridviewKH.Rows[r].Cells[2].Value.ToString();
                this.txtSDT.Text =
                gridviewKH.Rows[r].Cells[3].Value.ToString();
                this.txtMaGiamGia.Text =
                gridviewKH.Rows[r].Cells[4].Value.ToString();
                this.lbID.Text = gridviewKH.Rows[r].Cells[5].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Customer_DTO tg = LayTTKH();

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtTenKhachHang.Enabled = false;
            txtMaGiamGia.Enabled = false;
            txtSDT.Enabled = false;
            txtDiaChi.Enabled = false;
            txtTuoi.Enabled = false;
            if (add)
            {
                RemoveGridView();
                dgBUS.InsertCustomer(tg);
                Customer_Load(sender, e);


            }
            if (update)
            {

                RemoveGridView();
                dgBUS.UpdateCustomer(tg);
                Customer_Load(sender, e);

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            gridviewKH_CellClick(null, null);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtTenKhachHang.Enabled = false;
            txtDiaChi.Enabled = false;
            txtMaGiamGia.Enabled = false;
            txtSDT.Enabled = false;
            txtTuoi.Enabled = false;
        }

        public Customer()
        {
            InitializeComponent();
        }
    }
}
