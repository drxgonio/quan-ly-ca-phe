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
    public partial class TableQL : UserControl
    {
        public int dem = 0;
        private bool add = false, update = false;
        private TableQL_BLL dgBUS = new TableQL_BLL();
        ConnectDB conn = new ConnectDB();
        public TableQL()
        {
            InitializeComponent();
        }
        private void RemoveGridView()
        {
            gridviewTableQL.Rows.Clear();
            gridviewTableQL.Refresh();
        }
        //Lấy Thông tin Table
        private TableQL_DTO LayTTBan()
        {
            TableQL_DTO dg = new TableQL_DTO();
            dg.Tenban = txtTenBan.Text;
            dg.Socho = Convert.ToInt32(txtSoCho.Text);
            dg.Check = Convert.ToBoolean(checkBox1.Checked);
            dg.Id = lbTable.Text;
            return dg;
        }
        private void LoadGridView()
        {
            conn.Connect();


            var reult = conn.database.RunCommand<BsonDocument>(new BsonDocument { { "eval", "getTable()" } });

            var array = reult["retval"].AsBsonArray;
            foreach (var b in array)
            {
                DataGridViewRow row = (DataGridViewRow)gridviewTableQL.Rows[0].Clone();
                row.Cells[0].Value = b["TenBan"].AsString;
                row.Cells[1].Value = (b["SoCho"].AsInt64).ToString();
                row.Cells[2].Value = b["TinhTrang"].AsBoolean;
                row.Cells[3].Value = b["_id"].AsObjectId;
                gridviewTableQL.Rows.Add(row);
            }
          //  gridviewTableQL.AllowUserToAddRows = false;
        }

   

        private void TableQL_Load(object sender, EventArgs e)
        {
            LoadGridView();
            gridviewTableQL_CellClick(null, null);
        }

        private void gridviewTableQL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Thứ tự dòng hiện hành
                int r = gridviewTableQL.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel
                this.txtTenBan.Text =
                gridviewTableQL.Rows[r].Cells[0].Value.ToString();
                this.txtSoCho.Text =
                gridviewTableQL.Rows[r].Cells[1].Value.ToString();

                if (gridviewTableQL.Rows[r].Cells[2].Value.ToString() == "True")
                {
                    this.checkBox1.Checked = true;
                }
                else
                    this.checkBox1.Checked = false;
                this.lbTable.Text = gridviewTableQL.Rows[r].Cells[3].Value.ToString();
            }
            catch { }



        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            update = true; add = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            txtTenBan.Enabled = true;
            txtSoCho.Enabled = true;
            checkBox1.Enabled = true;
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            TableQL_DTO tg = LayTTBan();

            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            if (MessageBox.Show("Bạn có muốn xóa Bàn: " + txtTenBan.Text + " không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    RemoveGridView();
                    dgBUS.RemoveProducts(tg);
                    TableQL_Load(sender, e);



                }
                catch (Exception)
                {
                    MessageBox.Show("Mời bạn nhập Chọn Bàn cần xóa!!!!!");
                }

            }
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            gridviewTableQL_CellClick(null, null);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtTenBan.Enabled = false;
            txtSoCho.Enabled = false;
            checkBox1.Enabled = false;
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            TableQL_DTO tg = LayTTBan();

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtTenBan.Enabled = false;
            txtSoCho.Enabled = false;
            checkBox1.Enabled = false;
            if (add)
            {
                RemoveGridView();
                dgBUS.InsertTable(tg);
                TableQL_Load(sender, e);


            }
            if (update)
            {

                RemoveGridView();
                dgBUS.UpdateTable(tg);
                TableQL_Load(sender, e);

            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            add = true; update = false;
            txtTenBan.Enabled = true;
            txtSoCho.Enabled = true;
            checkBox1.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

      
    }
}
