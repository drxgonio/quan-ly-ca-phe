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
    public partial class NhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        private bool add = false, update = false;
        private Employees_BLL dgBUS = new Employees_BLL();
        ConnectDB conn = new ConnectDB();
        public NhanVien()
        {
            InitializeComponent();
        }
        private Employees_DTO LayTTNV()
        {
            Employees_DTO dg = new Employees_DTO();
            dg.TenNV = txtTenNV.Text;
            dg.NgaySinh = txtNgaySinh.Text;
            dg.DiaChi = txtDiaChi.Text;
            dg.Sdt = txtSDT.Text;
            dg.MatKhau = txtMatKhau.Text;
            dg.Id = lbID.Text;
            return dg;
        }

        private void LoadGridView()
        {
            conn.Connect();


            var reult = conn.database.RunCommand<BsonDocument>(new BsonDocument { { "eval", "getEmployees()" } });
           

            var array = reult["retval"].AsBsonArray;
            foreach (var document in array)
            {
                DataGridViewRow row = (DataGridViewRow)gridviewNV.Rows[0].Clone();
                // row.Cells[0].Value = b["_id"].AsObjectId;
                row.Cells[0].Value = document["TenNV"].AsString;
                row.Cells[1].Value = (document["NgaySinh"].AsDateTime).ToString();
                row.Cells[2].Value = document["DiaChi"].AsString;
                row.Cells[3].Value = (document["DienThoai"].AsInt64).ToString();
                row.Cells[4].Value = document["MatKhau"].AsString;
                row.Cells[5].Value = document["_id"].AsObjectId;
                gridviewNV.Rows.Add(row);
            }
           
        }


        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadGridView();
            gridviewNV_CellClick(null, null);
        }


    
        private void RemoveGridView()
        {
            gridviewNV.Rows.Clear();
            gridviewNV.Refresh();
        }


  


        private void gridviewNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Thứ tự dòng hiện hành
                int r = gridviewNV.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel
                this.txtTenNV.Text =
                gridviewNV.Rows[r].Cells[0].Value.ToString();
                this.txtNgaySinh.Text =
                gridviewNV.Rows[r].Cells[1].Value.ToString();
                this.txtDiaChi.Text =
                gridviewNV.Rows[r].Cells[2].Value.ToString();
                this.txtSDT.Text =
                gridviewNV.Rows[r].Cells[3].Value.ToString();
                this.txtMatKhau.Text =
                gridviewNV.Rows[r].Cells[4].Value.ToString();
                this.lbID.Text = gridviewNV.Rows[r].Cells[5].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            add = true; update = false;
            txtTenNV.Enabled = true;
            txtNgaySinh.Enabled = true;
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;
            txtMatKhau.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            update = true; add = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            txtTenNV.Enabled = true;
            txtNgaySinh.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
            txtMatKhau.Enabled = true;
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            gridviewNV_CellClick(null, null);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtTenNV.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;
            txtMatKhau.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Employees_DTO tg = LayTTNV();

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtTenNV.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;
            txtMatKhau.Enabled = false;
            if (add)
            {
                RemoveGridView();
                dgBUS.InsertEmployees(tg);
                NhanVien_Load(sender, e);


            }
            if (update)
            {

                RemoveGridView();
                dgBUS.UpdateEmployees(tg);
                NhanVien_Load(sender, e);

            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            Employees_DTO tg = LayTTNV();

            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            if (MessageBox.Show("Bạn có muốn xóa Nhân Viên: " + txtTenNV.Text + " không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    RemoveGridView();
                    dgBUS.RemoveEmployees(tg);
                    NhanVien_Load(sender, e);



                }
                catch (Exception)
                {
                    MessageBox.Show("Mời bạn nhập Chọn Sản phẩm cần xóa!!!!!");
                }
            }
        }

       

    
    }
}
