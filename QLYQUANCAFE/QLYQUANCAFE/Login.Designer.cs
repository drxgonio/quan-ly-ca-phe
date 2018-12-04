namespace QLYQUANCAFE
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.cmbHostName = new System.Windows.Forms.ComboBox();
            this.btnIP = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.PassWord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbdatabase = new System.Windows.Forms.ComboBox();
            this.rBAdmin = new System.Windows.Forms.RadioButton();
            this.rBUser = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cmbHostName
            // 
            this.cmbHostName.FormattingEnabled = true;
            this.cmbHostName.Location = new System.Drawing.Point(149, 25);
            this.cmbHostName.Name = "cmbHostName";
            this.cmbHostName.Size = new System.Drawing.Size(121, 21);
            this.cmbHostName.TabIndex = 15;
            this.cmbHostName.Text = "127.0.0.1";
            // 
            // btnIP
            // 
            this.btnIP.Location = new System.Drawing.Point(19, 25);
            this.btnIP.Name = "btnIP";
            this.btnIP.Size = new System.Drawing.Size(75, 23);
            this.btnIP.TabIndex = 14;
            this.btnIP.Text = "Load IP";
            this.btnIP.Click += new System.EventHandler(this.btnIP_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(23, 204);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(331, 204);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(75, 23);
            this.btnDangNhap.TabIndex = 12;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(218, 128);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(129, 21);
            this.txtPass.TabIndex = 11;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(218, 82);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(129, 21);
            this.txtTaiKhoan.TabIndex = 10;
            // 
            // PassWord
            // 
            this.PassWord.AutoSize = true;
            this.PassWord.BackColor = System.Drawing.Color.Transparent;
            this.PassWord.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWord.ForeColor = System.Drawing.Color.Red;
            this.PassWord.Location = new System.Drawing.Point(66, 131);
            this.PassWord.Name = "PassWord";
            this.PassWord.Size = new System.Drawing.Size(88, 18);
            this.PassWord.TabIndex = 9;
            this.PassWord.Text = "PassWord:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(106, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "User:";
            // 
            // cmbdatabase
            // 
            this.cmbdatabase.Enabled = false;
            this.cmbdatabase.FormattingEnabled = true;
            this.cmbdatabase.Items.AddRange(new object[] {
            "QuanLyQuanCaPhe"});
            this.cmbdatabase.Location = new System.Drawing.Point(311, 27);
            this.cmbdatabase.Name = "cmbdatabase";
            this.cmbdatabase.Size = new System.Drawing.Size(121, 21);
            this.cmbdatabase.TabIndex = 16;
            this.cmbdatabase.Text = "QuanLyQuanCaPhe";
            // 
            // rBAdmin
            // 
            this.rBAdmin.AutoSize = true;
            this.rBAdmin.Location = new System.Drawing.Point(134, 172);
            this.rBAdmin.Name = "rBAdmin";
            this.rBAdmin.Size = new System.Drawing.Size(65, 17);
            this.rBAdmin.TabIndex = 19;
            this.rBAdmin.Text = "Quan Ly";
            this.rBAdmin.UseVisualStyleBackColor = true;
            // 
            // rBUser
            // 
            this.rBUser.AutoSize = true;
            this.rBUser.Checked = true;
            this.rBUser.Location = new System.Drawing.Point(319, 172);
            this.rBUser.Name = "rBUser";
            this.rBUser.Size = new System.Drawing.Size(73, 17);
            this.rBUser.TabIndex = 20;
            this.rBUser.TabStop = true;
            this.rBUser.Text = "Nhan Vien";
            this.rBUser.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(467, 261);
            this.Controls.Add(this.rBUser);
            this.Controls.Add(this.rBAdmin);
            this.Controls.Add(this.cmbdatabase);
            this.Controls.Add(this.cmbHostName);
            this.Controls.Add(this.btnIP);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbHostName;
        private DevExpress.XtraEditors.SimpleButton btnIP;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label PassWord;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.ComboBox cmbdatabase;
        private System.Windows.Forms.RadioButton rBAdmin;
        private System.Windows.Forms.RadioButton rBUser;
    }
}