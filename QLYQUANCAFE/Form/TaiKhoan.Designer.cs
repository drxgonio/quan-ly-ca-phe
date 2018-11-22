namespace QLYQUANCAFE.Form
{
    partial class TaiKhoan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridviewTK = new System.Windows.Forms.DataGridView();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenNV = new DevExpress.XtraEditors.TextEdit();
            this.txtTK = new DevExpress.XtraEditors.TextEdit();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.lstTK = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoaTaiKhoan = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridviewTK
            // 
            this.gridviewTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewTK.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridviewTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenNV,
            this.TK,
            this.MatKhau,
            this.id});
            this.gridviewTK.Location = new System.Drawing.Point(0, 244);
            this.gridviewTK.Name = "gridviewTK";
            this.gridviewTK.Size = new System.Drawing.Size(756, 237);
            this.gridviewTK.TabIndex = 22;
            this.gridviewTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewTK_CellClick_1);
            // 
            // TenNV
            // 
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.Name = "TenNV";
            // 
            // TK
            // 
            this.TK.HeaderText = "Tài Khoản";
            this.TK.Name = "TK";
            // 
            // MatKhau
            // 
            this.MatKhau.HeaderText = "Mật Khẩu";
            this.MatKhau.Name = "MatKhau";
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(532, 194);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(91, 23);
            this.simpleButton1.TabIndex = 23;
            this.simpleButton1.Text = "Cấp Tài Khoản";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Location = new System.Drawing.Point(450, 32);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(130, 20);
            this.txtTenNV.TabIndex = 24;
            // 
            // txtTK
            // 
            this.txtTK.Enabled = false;
            this.txtTK.Location = new System.Drawing.Point(450, 84);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(130, 20);
            this.txtTK.TabIndex = 25;
            // 
            // txtPass
            // 
            this.txtPass.Enabled = false;
            this.txtPass.Location = new System.Drawing.Point(450, 134);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(130, 20);
            this.txtPass.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tên Nhân Viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tài Khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Mật Khẩu:";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(788, 42);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(35, 13);
            this.lb.TabIndex = 30;
            this.lb.Text = "label4";
            // 
            // lstTK
            // 
            this.lstTK.FormattingEnabled = true;
            this.lstTK.Location = new System.Drawing.Point(27, 44);
            this.lstTK.Name = "lstTK";
            this.lstTK.Size = new System.Drawing.Size(204, 173);
            this.lstTK.TabIndex = 31;
            this.lstTK.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstTK_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Danh sách nhân viên:";
            // 
            // btnXoaTaiKhoan
            // 
            this.btnXoaTaiKhoan.Location = new System.Drawing.Point(776, 257);
            this.btnXoaTaiKhoan.Name = "btnXoaTaiKhoan";
            this.btnXoaTaiKhoan.Size = new System.Drawing.Size(91, 23);
            this.btnXoaTaiKhoan.TabIndex = 33;
            this.btnXoaTaiKhoan.Text = "Xóa Tài Khoản";
            this.btnXoaTaiKhoan.Click += new System.EventHandler(this.btnXoaTaiKhoan_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(773, 310);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(104, 23);
            this.simpleButton2.TabIndex = 34;
            this.simpleButton2.Text = "Thay Đổi Mật Khẩu";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnXoaTaiKhoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstTK);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridviewTK);
            this.Name = "TaiKhoan";
            this.Size = new System.Drawing.Size(880, 500);
            this.Load += new System.EventHandler(this.TaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridviewTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txtTenNV;
        private DevExpress.XtraEditors.TextEdit txtTK;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.ListBox lstTK;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnXoaTaiKhoan;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}
