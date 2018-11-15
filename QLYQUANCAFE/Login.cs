using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.Net.Sockets;
using DevExpress.XtraEditors;
using QLYQUANCAFE.Connect;
using MongoDB.Bson;
//tham chiếu thư viện này:
using MongoDB.Driver;

namespace QLYQUANCAFE
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        ConnectDB conn = new ConnectDB();
        public int flag = 1;
        public Login()
        {
            InitializeComponent();
        }
        string ipAddress = "";
        
        private void loadip()
        {

            string ipBase = "";

            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipBase = ip.ToString();
                    ipAddress = ipBase;
                }
            }

            String[] ipPart = ipBase.Split('.');
            ipBase = ipPart[0] + "." + ipPart[1] + "." + ipPart[2] + ".";

            for (int i = 0; i < 255; i++)
            {
                string ip = ipBase + i.ToString();

                Ping p = new Ping();
                p.PingCompleted += new PingCompletedEventHandler(p_PingCompleted);
                p.SendAsync(ip, 100, ip);
            }
            cmbHostName.Text = ipAddress;
            MessageBox.Show("Đã quét xong IP");
        }

        private void p_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            PingReply pr = e.Reply;
            if (e.Reply.Address.ToString() != "0.0.0.0" && e.Reply.Address.ToString() != ipAddress)
            {
                cmbHostName.Items.Add(e.Reply.Address.ToString());
            }
        }
        private void btnIP_Click(object sender, EventArgs e)
        {
            loadip();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            conn.ConectIP(txtTaiKhoan.Text,txtPass.Text,cmbHostName.Text,cmbdatabase.Text);
            conn.Connect();
            if(conn.isCorrect==true)
            {
                if(cmbdatabase.Text== "QuanLyQuanCaPhe")
                  flag = 2;
                else
                    flag = 0;
                MessageBox.Show("ok");
                
                this.Dispose();
               
            }
            else
            {
                flag = 1;
                MessageBox.Show(" ko ok");
            }


        }
    }
}