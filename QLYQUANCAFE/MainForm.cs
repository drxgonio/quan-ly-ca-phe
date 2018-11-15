using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

using MongoDB.Bson;
//tham chiếu thư viện này:
using MongoDB.Driver;
using QLYQUANCAFE.Form;

namespace QLYQUANCAFE
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Login lg = new Login();
        NhanVien nv = new NhanVien();
        Main mn = new Main();
        Product pd = new Product();
        TableQL tb = new TableQL();
        Customer cu = new Customer();
        ThongKe tk = new ThongKe();
        int f1 = 1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.panelMain.Controls.Remove(lg);
            this.panelMain.Controls.Remove(nv);
            this.panelMain.Controls.Remove(tb);
            this.panelMain.Controls.Remove(pd);
            this.panelMain.Controls.Remove(cu);
            this.panelMain.Controls.Remove(tk);
            this.panelMain.Controls.Remove(panelTest);
            this.panelMain.Controls.Add(mn);
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.panelMain.Controls.Remove(mn);
            this.panelMain.Controls.Remove(lg);
            this.panelMain.Controls.Remove(tb);
            this.panelMain.Controls.Remove(pd);
            this.panelMain.Controls.Remove(cu);
            this.panelMain.Controls.Remove(tk);
            this.panelMain.Controls.Remove(panelTest);
            this.panelMain.Controls.Add(nv);
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.panelMain.Controls.Remove(mn);
            this.panelMain.Controls.Remove(lg);
            this.panelMain.Controls.Remove(nv);
            this.panelMain.Controls.Remove(tb);
            this.panelMain.Controls.Remove(cu);
            this.panelMain.Controls.Remove(tk);
            this.panelMain.Controls.Remove(panelTest);
            this.panelMain.Controls.Add(pd);
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.panelMain.Controls.Remove(mn);
            this.panelMain.Controls.Remove(lg);
            this.panelMain.Controls.Remove(nv);
            this.panelMain.Controls.Remove(pd);
            this.panelMain.Controls.Remove(cu);
            this.panelMain.Controls.Remove(tk);
            this.panelMain.Controls.Remove(panelTest);
            this.panelMain.Controls.Add(tb);
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.panelMain.Controls.Remove(mn);
            this.panelMain.Controls.Remove(lg);
            this.panelMain.Controls.Remove(nv);
            this.panelMain.Controls.Remove(tb);
            this.panelMain.Controls.Remove(pd);
            this.panelMain.Controls.Remove(tk);
            this.panelMain.Controls.Remove(panelTest);
            this.panelMain.Controls.Add(cu);
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.panelMain.Controls.Remove(mn);
            this.panelMain.Controls.Remove(lg);
            this.panelMain.Controls.Remove(nv);
            this.panelMain.Controls.Remove(tb);
            this.panelMain.Controls.Remove(pd);
            this.panelMain.Controls.Remove(cu);
            this.panelMain.Controls.Remove(panelTest);
    
            this.panelMain.Controls.Add(tk);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            lg = new Login();
            lg.ShowDialog();         
            f1 = lg.flag;
            if (f1 != 1)
            {
                btnDangXuat.Enabled = true;
                barButtonItem8.Enabled = false;//Nút đăng nhập
                if (f1 == 2)//Tài khoản User
                    barButtonItem1.Enabled = true;

                if (f1 == 0)//Tài khoản Admin
                {
                    barButtonItem1.Enabled = true;
                    rb1.Enabled = true;
                    rb2.Enabled = true;
                    rb3.Enabled = true;
                }
            }
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            barButtonItem8.Enabled = true;//Nút đăng nhập
            btnDangXuat.Enabled = false;
            barButtonItem1.Enabled = false;
            rb1.Enabled = false;
            rb2.Enabled = false;
            rb3.Enabled = false;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(panelTest);
        }
    }
}