namespace QLYQUANCAFE.Form
{
    partial class ThongKe
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
            this.gridviewNV = new System.Windows.Forms.DataGridView();
            this.btnChon = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.tenBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewNV)).BeginInit();
            this.SuspendLayout();
            // 
            // gridviewNV
            // 
            this.gridviewNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewNV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridviewNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenBan,
            this.soHoaDon,
            this.khachHang,
            this.phucVu,
            this.tenSanPham,
            this.gia,
            this.id});
            this.gridviewNV.Location = new System.Drawing.Point(3, 130);
            this.gridviewNV.Name = "gridviewNV";
            this.gridviewNV.Size = new System.Drawing.Size(874, 358);
            this.gridviewNV.TabIndex = 22;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(144, 64);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 23);
            this.btnChon.TabIndex = 23;
            this.btnChon.Text = "Chọn";
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Chọn ngày:";
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(119, 20);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(137, 20);
            this.txtNgay.TabIndex = 25;
            // 
            // tenBan
            // 
            this.tenBan.HeaderText = "Tên Bàn";
            this.tenBan.Name = "tenBan";
            // 
            // soHoaDon
            // 
            this.soHoaDon.HeaderText = "Số Hóa Đơn";
            this.soHoaDon.Name = "soHoaDon";
            // 
            // khachHang
            // 
            this.khachHang.HeaderText = "Khách Hàng";
            this.khachHang.Name = "khachHang";
            // 
            // phucVu
            // 
            this.phucVu.HeaderText = "Phục Vụ";
            this.phucVu.Name = "phucVu";
            // 
            // tenSanPham
            // 
            this.tenSanPham.HeaderText = "Tên Sản Phẩm";
            this.tenSanPham.Name = "tenSanPham";
            // 
            // gia
            // 
            this.gia.HeaderText = "Giá";
            this.gia.Name = "gia";
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtNgay);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.gridviewNV);
            this.Name = "ThongKe";
            this.Size = new System.Drawing.Size(880, 500);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridviewNV;
        private DevExpress.XtraEditors.SimpleButton btnChon;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn soHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn khachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn phucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}
