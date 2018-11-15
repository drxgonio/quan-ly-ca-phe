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
using DevExpress.XtraReports.UI;

namespace QLYQUANCAFE.Form
{
    public partial class Main : UserControl
    {
        private Products_BLL dgBUS = new Products_BLL();
        private OrderDrink_BLL dgOrder = new OrderDrink_BLL();
        ConnectDB conn = new ConnectDB();
        List<string> listOrder = new List<string>();
        private int count = 1;
        string magiamgia = "";
        double sum;

        public Main()
        {
            InitializeComponent();
        }
       
        
        private OrderDrink_DTO LayTTHD()
        {

            for (int i = 0; i < gridView.Rows.Count - 1; i++)
            {
                listOrder.Add("'"+gridView.Rows[i].Cells[0].Value.ToString()+"'");
            }
            BsonArray array = new BsonArray();
            foreach(var b in listOrder)
            {
                array.Add(b);
            }

            OrderDrink_DTO dg = new OrderDrink_DTO();
            dg.TenBan = lbTenBan.Text;
            dg.SoHoaDon = int.Parse(txtSoHoaDon.Text);
            dg.KhachHang = txtKhachHang.Text;
            dg.NguoiThuNgan = txtPhucVu.Text;
            dg.SanPham = array;
            dg.TongTien = double.Parse(txtTongTien.Text);
            dg.Thoigian = txtThoiGian.Text;
         
            return dg;
        }
        private DataRport LayTT()
        {

            for (int i = 0; i < gridView.Rows.Count - 1; i++)
            {
                listOrder.Add("'" + gridView.Rows[i].Cells[0].Value.ToString() + "'");
            }
            BsonArray array = new BsonArray();
            foreach (var b in listOrder)
            {
                array.Add(b);
            }

            DataRport dg = new DataRport();
            dg.TenBan = lbTenBan.Text;
            dg.SoHoaDon = int.Parse(txtSoHoaDon.Text);
            dg.KhachHang = txtKhachHang.Text;
            dg.NguoiThuNgan = txtPhucVu.Text;
            dg.SanPham = array;
            dg.TongTien = double.Parse(txtTongTien.Text);
            dg.Thoigian = txtThoiGian.Text;

            return dg;
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
                    row.Cells[1].Value = (b["Gia"].AsDouble).ToString();
                    gridviewSanPham.Rows.Add(row);
                }
                gridviewSanPham.AllowUserToAddRows = false;
            

        }
        private void getNuocUong()
        {
            conn.Connect();
            flowLayoutPanel1.Controls.Clear();
            var reult = conn.database.RunCommand<BsonDocument>(new BsonDocument { { "eval", "getNuocUong()" } });

            var array = reult["retval"].AsBsonArray;
            Bunifu.Framework.UI.BunifuThinButton2 [] buttonArray = new Bunifu.Framework.UI.BunifuThinButton2[100];
           
            int i = 0;
            foreach (var b in array)
            {
                buttonArray[i] = new Bunifu.Framework.UI.BunifuThinButton2();
                buttonArray[i].Size = new Size(80, 60);
                buttonArray[i].ButtonText= b["TenHang"].AsString;
                buttonArray[i].MouseDown += Main_MouseDown;
                buttonArray[i].Font=new Font("Franklin Gothic", 12f);
                buttonArray[i].ActiveFillColor = Color.Yellow;
                buttonArray[i].IdleFillColor = Color.LightSteelBlue;
                this.flowLayoutPanel1.Controls.Add(buttonArray[i]);
                i++;

            }
          
        }
        //Hàm bắt sự kiện khi click vào chọn các sảng phẩm
        #region
        private void Main_MouseDown(object sender, EventArgs e)
        {
            if (txtKhachHang.Text != ""&&lbTenBan.Text!="")
            {

                Bunifu.Framework.UI.BunifuThinButton2 c = (Bunifu.Framework.UI.BunifuThinButton2)(sender);
                var reult = conn.database.RunCommand<BsonDocument>(new BsonDocument { { "eval", "getProductsName('" + c.ButtonText + "')" } });
                BsonDocument array = reult;
                BsonDocument arr1 = array["retval"].AsBsonDocument;
                DataGridViewRow row = (DataGridViewRow)gridView.Rows[0].Clone();
                row.Cells[0].Value = arr1["TenHang"].AsString;
                row.Cells[1].Value = (arr1["Gia"].AsDouble).ToString();

                gridView.Rows.Add(row);
                sum = 0;
                for (int i = 0; i < gridView.Rows.Count - 1; i++)
                {
                    sum += Convert.ToInt32(gridView.Rows[i].Cells[1].Value.ToString());
                }
                sum = (float)sum * (100 - int.Parse(txtBonus.Text)) / 100;
                txtTongTien.Text = sum.ToString();

            }
            else
            {
                if(txtKhachHang.Text == "")
                     MessageBox.Show("Vui lòng nhập tên khách hàng.");
                if (lbTenBan.Text == "")
                    MessageBox.Show("Vui lòng nhập tên Bàn.");
            }
           
        }
        private void Main_MouseDown1(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuThinButton2 c = (Bunifu.Framework.UI.BunifuThinButton2)(sender);
            if(c.ActiveFillColor==Color.Red)
            {
                MessageBox.Show("Bạn này đã được đặt. Vui lòng đặt bàn khác...", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            lbTenBan.Text = c.ButtonText;
            DateTime today = DateTime.Now;

            txtThoiGian.Text = today.Day.ToString() + "/" + today.Month.ToString() + "/" + today.Year.ToString();
        }
        #endregion
        #region
        private void getSanPhamKhac()
        {
            conn.Connect();

            flowLayoutPanel1.Controls.Clear();
            var reult = conn.database.RunCommand<BsonDocument>(new BsonDocument { { "eval", "getSanPhamKhac()" } });

            var array = reult["retval"].AsBsonArray;
            Bunifu.Framework.UI.BunifuThinButton2[] buttonArray = new Bunifu.Framework.UI.BunifuThinButton2[100];

            int i = 0;
            foreach (var b in array)
            {
                buttonArray[i] = new Bunifu.Framework.UI.BunifuThinButton2();
                buttonArray[i].Size = new Size(80, 60);
                buttonArray[i].ButtonText = b["TenHang"].AsString;
                buttonArray[i].MouseDown += Main_MouseDown;
                buttonArray[i].Font = new Font("Franklin Gothic", 12f);
                buttonArray[i].ActiveFillColor = Color.Yellow;
                buttonArray[i].IdleFillColor = Color.LightSteelBlue;
                this.flowLayoutPanel1.Controls.Add(buttonArray[i]);
                i++;

            }

        }
        private void getTable()
        {
            conn.Connect();

            flowLayoutPanel1.Controls.Clear();
            var reult = conn.database.RunCommand<BsonDocument>(new BsonDocument { { "eval", "getTable()" } });

            var array = reult["retval"].AsBsonArray;
            Bunifu.Framework.UI.BunifuThinButton2[] buttonArray = new Bunifu.Framework.UI.BunifuThinButton2[100];

            int i = 0;
            foreach (var b in array)
            {
                buttonArray[i] = new Bunifu.Framework.UI.BunifuThinButton2();
                buttonArray[i].Size = new Size(80, 60);
                buttonArray[i].ButtonText = b["TenBan"].AsString ;
                buttonArray[i].MouseDown += Main_MouseDown1;
                buttonArray[i].Font = new Font("Franklin Gothic", 12f);
                if (b["TinhTrang"].AsBoolean == true)
                {
                    buttonArray[i].ActiveFillColor = Color.Yellow;
                    buttonArray[i].IdleFillColor = Color.LightSteelBlue;
                }
                else
                {
                    buttonArray[i].ActiveFillColor = Color.Red;
                    buttonArray[i].IdleFillColor = Color.Red;
                }
                this.flowLayoutPanel1.Controls.Add(buttonArray[i]);
                i++;

            }
         

        }

        #endregion

        private void Main_Load(object sender, EventArgs e)
        {
           
            LoadGridView();
        }




        #region
        private void btnNuoc_Click(object sender, EventArgs e)
        {
            getNuocUong();
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            getSanPhamKhac();
        }

   

        private void btnTraMon_Click(object sender, EventArgs e)
        {
            if (this.gridView.Rows.Count > 0)
            {
                try
                {
                    int row = gridView.CurrentCell.RowIndex;
                    gridView.Rows.RemoveAt(row);
                }
                catch
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm.");
                }
            
            }
             sum = 0;
           
            for (int i = 0; i < gridView.Rows.Count - 1; i++)
            {
                sum += Convert.ToInt32(gridView.Rows[i].Cells[1].Value.ToString());
            }
            sum = (float)sum * (100 - int.Parse(txtBonus.Text)) / 100;
            txtTongTien.Text = sum .ToString();


        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            getNuocUong();
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            getSanPhamKhac();
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            getTable();
        }
        #endregion

        private void btnTT_Click(object sender, EventArgs e)
        {
            if (lbTenBan.Text==""||txtKhachHang.Text == "" || txtBonus.Text == "" || txtPhucVu.Text == "" || txtSoHoaDon.Text == "" || txtThoiGian.Text == "" || txtTongTien.Text == "")
            {
                MessageBox.Show("Vui lòng chọn bàn!!!");
            }
            else {

                DataRport dg = LayTT();
              
                DataTable dt = new DataTable();
                OrderDrink_DTO tg = LayTTHD();
                dgOrder.InsertEmployees(tg);
                count++;
                txtSoHoaDon.Text = count.ToString();
                #region
                //Adding columns to datatable
                dt.Columns.Add("tenBan", typeof(string));
                dt.Columns.Add("thoiGian", typeof(string));
                dt.Columns.Add("soHoaDon", typeof(string));
                dt.Columns.Add("KhachHang", typeof(string));
                dt.Columns.Add("tongTien", typeof(string));
                dt.Columns.Add("nguoiThuNgan", typeof(string));
                dt.Columns.Add("SanPham", typeof(string));


                DataRow row;
                row = dt.NewRow();
                row["tenBan"] = dg.TenBan;
                row["thoiGian"] = dg.Thoigian;
                row["soHoaDon"] = dg.SoHoaDon;
                row["KhachHang"] = dg.KhachHang;
                row["tongTien"] = dg.TongTien.ToString();
                row["nguoiThuNgan"] = dg.NguoiThuNgan;

                for (int i = 0; i < gridView.Rows.Count - 1; i++)
                {

                    //row[i.ToString()] = gridView.Rows[i].Cells[0].Value.ToString();
                    row["SanPham"] += gridView.Rows[i].Cells[0].Value.ToString() + ",";


                }
                dt.Rows.Add(row);

                #endregion


                ReportBaoCao report = new ReportBaoCao();

                report.DataSource = dt;
                report.ShowPreviewDialog();
                txtKhachHang.ResetText();
                txtBonus.Text="0";
                txtThoiGian.ResetText();
                txtTongTien.ResetText();
                lbTenBan.ResetText();
                gridView.Rows.Clear();

            }



        }

        //Hàm xét mã giảm giá theo tên khách hàng
        #region
        private void getCustomer()
        {
            try
            {
                conn.Connect();


                var reult = conn.database.RunCommand<BsonDocument>(new BsonDocument { { "eval", "getOrderM('" + txtKhachHang.Text + "')" } });


                BsonDocument array = reult;
                BsonDocument arr1 = array["retval"].AsBsonDocument;

                magiamgia = arr1["maGiamGia"].AsString;
            }
            catch
            {
                magiamgia = "0";
            }


        }
        TypeAssistant assistant;
        void assistant_Idled(object sender, EventArgs e)
        {
            this.Invoke(
            new MethodInvoker(() =>
            {
                getCustomer();
               txtBonus.Text = magiamgia;
            }));
        }
        private void txtKhachHang_TextChanged(object sender, EventArgs e)
        {

            int delay = 200;
            assistant = new TypeAssistant(delay);
            assistant.Idled += assistant_Idled;
            assistant.TextChanged();
        }
        #endregion
    }
}
