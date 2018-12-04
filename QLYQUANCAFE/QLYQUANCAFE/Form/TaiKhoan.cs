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
    public partial class TaiKhoan : UserControl
    {
        public int dem = 0;
        private bool add = false, update = false;
        private Account_BLL dgBUS = new Account_BLL();
        ConnectDB conn = new ConnectDB();
    
        public TaiKhoan()
        {
            InitializeComponent();
          
        }
        private void RemoveGridView()
        {
            gridviewTK.Rows.Clear();
            gridviewTK.Refresh();
        }
        //Lấy Thông tin Account
        private Account_DTO LayTTBan()
        {
            Account_DTO dg = new Account_DTO();
            dg.TenNV = txtTenNV.Text;
            dg.TaiKhoan = txtTK.Text;
            dg.Password =txtPass.Text;
            dg.Id = lb.Text;
            return dg;
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            LoadGridView();
            LoadList();
        }
        //Lấy Thông tin Account
        private Account_DTO LayTTAccount()
        {
            Account_DTO dg = new Account_DTO();
            dg.TenNV = txtTenNV.Text;
            dg.TaiKhoan = txtTK.Text;
            dg.Password = txtPass.Text;
            dg.Id = lb.Text;
            return dg;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Account_DTO tg = LayTTAccount();
            txtTK.Enabled = false;
            txtPass.Enabled = false;
            RemoveGridView();
            dgBUS.InsertAccount(tg);
            TaiKhoan_Load(sender, e);
        }
        private void LoadList()
        {
            conn.Connect();

            lstTK.Items.Clear();
            var reult = conn.database.RunCommand<BsonDocument>(new BsonDocument { { "eval", "getEmployees()" } });
            var array = reult["retval"].AsBsonArray;
            foreach (var b in array)
            {
                lstTK.Items.Add(b["TenNV"].AsString);
                
            }
        }

        private void lstTK_MouseClick(object sender, MouseEventArgs e)
        {
            txtTenNV.Text = lstTK.SelectedItem.ToString();
            txtTK.Enabled = true;
            txtPass.Enabled = true;
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            Account_DTO tg = LayTTAccount();
    
            if (MessageBox.Show("Bạn có muốn xóa Tài khoản của: " + txtTenNV.Text + " không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    RemoveGridView();
                    dgBUS.RemoveAccount(tg);
                    TaiKhoan_Load(sender, e);



                }
                catch (Exception)
                {
                    MessageBox.Show("Mời bạn nhập Chọn Sản phẩm cần xóa!!!!!");
                }

            }
        }



        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Account_DTO tg = LayTTAccount();

            if (MessageBox.Show("Bạn có muốn đổi mật khẩu Tài khoản của: " + txtTenNV.Text + " không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    RemoveGridView();
                    dgBUS.UpdateUser(tg);
                    TaiKhoan_Load(sender, e);



                }
                catch (Exception)
                {
                    MessageBox.Show("Mời bạn nhập Chọn Sản phẩm cần xóa!!!!!");
                }
                txtTK.Enabled = false;
                txtPass.Enabled = false;

            }
        }

        private void gridviewTK_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // lb.Text = b["_id"].AsObjectId;
            try
            {
                // Thứ tự dòng hiện hành
                int r = gridviewTK.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel
                this.txtTenNV.Text =
                gridviewTK.Rows[r].Cells[0].Value.ToString();
                this.txtTK.Text =
                gridviewTK.Rows[r].Cells[1].Value.ToString();
                this.txtPass.Text =
                gridviewTK.Rows[r].Cells[2].Value.ToString();
                this.lb.Text = gridviewTK.Rows[r].Cells[3].Value.ToString();
                txtTK.Enabled = true;
                txtPass.Enabled = true;
            }
            catch { }
        }

        private void LoadGridView()
        {
            conn.Connect();

            try
            {
                var reult = conn.database.RunCommand<BsonDocument>(new BsonDocument { { "eval", "getAccount()" } });
                var array = reult["retval"].AsBsonArray;
                foreach (var b in array)
                {
                    DataGridViewRow row = (DataGridViewRow)gridviewTK.Rows[0].Clone();
                    row.Cells[0].Value = b["tenNV"].AsString;
                    row.Cells[1].Value = b["taiKhoan"].AsString;
                    row.Cells[2].Value = b["matKhau"].AsString;
                    row.Cells[3].Value = b["_id"].AsObjectId;
                   
                    gridviewTK.Rows.Add(row);
                }
                //  gridviewTableQL.AllowUserToAddRows = false;
            }
            catch
            {
            }




           
        }
    }
}
