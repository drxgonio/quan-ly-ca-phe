using System;

using System.Windows.Forms;
using QLYQUANCAFE.DTO;
using QLYQUANCAFE.BLL;
using QLYQUANCAFE.Connect;
using MongoDB.Bson;
//tham chiếu thư viện này:

namespace QLYQUANCAFE.Form
{
    public partial class Product : UserControl
    {
        public int dem = 0;
        private bool add = false, update = false;
        private Products_BLL dgBUS = new Products_BLL();
        ConnectDB conn = new ConnectDB();
        public Product()
        {
            InitializeComponent();
        }
      

        private void LoadGridView()
        {
            conn.Connect();
          

           var reult = conn.database.RunCommand<BsonDocument>(new BsonDocument { { "eval", "getProducts()" } });

           var array = reult["retval"].AsBsonArray;
            foreach (var b in array)
            {
                DataGridViewRow row = (DataGridViewRow)gridviewSanPham.Rows[0].Clone();
                row.Cells[0].Value = b["TenHang"].AsString;
                row.Cells[1].Value = (b["Gia"].AsDouble).ToString() ;
                row.Cells[2].Value =b["DanhMuc"].AsString;
                row.Cells[3].Value = b["_id"].AsObjectId;
                gridviewSanPham.Rows.Add(row);             
            }
          
        }
        //Lấy Thông tin Products
        private Products_DTO LayTTSP()
        {
            Products_DTO dg = new Products_DTO();
            dg.TenSanPham = txtTenSanPham.Text;       
            dg.Gia = Convert.ToInt64(txtGia.Text);
            dg.DanhMuc = cmbDanhMuc.Text;
            dg.Id = lbID.Text;
            return dg;
        }
        private void RemoveGridView()
        {
            gridviewSanPham.Rows.Clear();
            gridviewSanPham.Refresh();
        }
        private void Product_Load(object sender, EventArgs e)
        {
            LoadGridView();
            gridviewSanPham_CellClick(null, null);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Products_DTO tg = LayTTSP();
           
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtTenSanPham.Enabled = false;
            txtGia.Enabled = false;
            cmbDanhMuc.Enabled = false;
            if (add)
            {
                RemoveGridView();
                dgBUS.InsertProducts(tg);
                Product_Load(sender, e);
           

            }
            if (update)
            {
                
                RemoveGridView();
                dgBUS.UpdateProducts(tg);
                Product_Load(sender, e);

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            add = true; update = false;
            txtTenSanPham.Enabled = true;
            txtGia.Enabled = true;
            cmbDanhMuc.Enabled = true;
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
            txtTenSanPham.Enabled = true;
            txtGia.Enabled = true;
            cmbDanhMuc.Enabled = true;


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Products_DTO tg = LayTTSP();
           
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            if (MessageBox.Show("Bạn có muốn xóa Sản Phẩm: " + txtTenSanPham.Text + " không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    RemoveGridView();
                    dgBUS.RemoveProducts(tg);
                    Product_Load(sender, e);



                }
                catch (Exception)
                {
                    MessageBox.Show("Mời bạn nhập Chọn Sản phẩm cần xóa!!!!!");
                }
                
            }
          

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            gridviewSanPham_CellClick(null, null);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtTenSanPham.Enabled = false;
            txtGia.Enabled = false;
            cmbDanhMuc.Enabled = false;
        }




        #region
        private void gridviewSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Thứ tự dòng hiện hành
                int r = gridviewSanPham.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel
                this.txtTenSanPham.Text =
                gridviewSanPham.Rows[r].Cells[0].Value.ToString();
                this.txtGia.Text =
                gridviewSanPham.Rows[r].Cells[1].Value.ToString();
                this.cmbDanhMuc.Text =
                gridviewSanPham.Rows[r].Cells[2].Value.ToString();
                this.lbID.Text = gridviewSanPham.Rows[r].Cells[3].Value.ToString();
            }
            catch { }
        }
        #endregion
    }
}
