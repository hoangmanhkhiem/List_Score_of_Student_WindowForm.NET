namespace ListScoreofStudent
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer thanhPhan = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (thanhPhan != null))
            {
                thanhPhan.Dispose();
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
            this.nhomThongTinMonHoc = new System.Windows.Forms.GroupBox();
            this.chonMonHoc = new System.Windows.Forms.ComboBox();
            this.btnThemMonHoc = new System.Windows.Forms.Button();
            this.nhapDiem = new System.Windows.Forms.TextBox();
            this.nhapSoTinChi = new System.Windows.Forms.TextBox();
            this.lblDiem = new System.Windows.Forms.Label();
            this.lblSoTinChi = new System.Windows.Forms.Label();
            this.lblTenMonHoc = new System.Windows.Forms.Label();
            this.nhomDanhSachMonHoc = new System.Windows.Forms.GroupBox();
            this.danhSachMonHoc = new System.Windows.Forms.TextBox();
            this.lblTongSoTinChi = new System.Windows.Forms.Label();
            this.lblTongSoDiem = new System.Windows.Forms.Label();
            this.lblDiemTrungBinh = new System.Windows.Forms.Label();
            this.hienThiTongSoTinChi = new System.Windows.Forms.TextBox();
            this.hienThiDiemTrungBinh = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTinhToan = new System.Windows.Forms.Button();
            this.hienThiTongSoDiem = new System.Windows.Forms.TextBox();
            this.nhomThongTinMonHoc.SuspendLayout();
            this.nhomDanhSachMonHoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // nhomThongTinMonHoc
            // 
            this.nhomThongTinMonHoc.Controls.Add(this.chonMonHoc);
            this.nhomThongTinMonHoc.Controls.Add(this.btnThemMonHoc);
            this.nhomThongTinMonHoc.Controls.Add(this.nhapDiem);
            this.nhomThongTinMonHoc.Controls.Add(this.nhapSoTinChi);
            this.nhomThongTinMonHoc.Controls.Add(this.lblDiem);
            this.nhomThongTinMonHoc.Controls.Add(this.lblSoTinChi);
            this.nhomThongTinMonHoc.Controls.Add(this.lblTenMonHoc);
            this.nhomThongTinMonHoc.Location = new System.Drawing.Point(35, 31);
            this.nhomThongTinMonHoc.Name = "nhomThongTinMonHoc";
            this.nhomThongTinMonHoc.Size = new System.Drawing.Size(503, 591);
            this.nhomThongTinMonHoc.TabIndex = 0;
            this.nhomThongTinMonHoc.TabStop = false;
            this.nhomThongTinMonHoc.Text = "Thông tin điểm sinh viên";
            // 
            // chonMonHoc
            // 
            this.chonMonHoc.FormattingEnabled = true;
            this.chonMonHoc.Location = new System.Drawing.Point(176, 43);
            this.chonMonHoc.Name = "chonMonHoc";
            this.chonMonHoc.Size = new System.Drawing.Size(297, 30);
            this.chonMonHoc.TabIndex = 5;
            this.chonMonHoc.SelectedIndexChanged += new System.EventHandler(this.handleChonMonHoc);
            // 
            // btnThemMonHoc
            // 
            this.btnThemMonHoc.Location = new System.Drawing.Point(176, 316);
            this.btnThemMonHoc.Name = "btnThemMonHoc";
            this.btnThemMonHoc.Size = new System.Drawing.Size(293, 42);
            this.btnThemMonHoc.TabIndex = 3;
            this.btnThemMonHoc.Text = "Thêm vào DS";
            this.btnThemMonHoc.UseVisualStyleBackColor = true;
            this.btnThemMonHoc.Click += new System.EventHandler(this.btnThemVaoDS_Click);
            // 
            // nhapDiem
            // 
            this.nhapDiem.Location = new System.Drawing.Point(176, 224);
            this.nhapDiem.Name = "nhapDiem";
            this.nhapDiem.Size = new System.Drawing.Size(297, 30);
            this.nhapDiem.TabIndex = 2;
            this.nhapDiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.diem_KeyPress);
            // 
            // nhapSoTinChi
            // 
            this.nhapSoTinChi.Location = new System.Drawing.Point(176, 127);
            this.nhapSoTinChi.Name = "nhapSoTinChi";
            this.nhapSoTinChi.ReadOnly = true;
            this.nhapSoTinChi.Size = new System.Drawing.Size(293, 30);
            this.nhapSoTinChi.TabIndex = 2;
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.Location = new System.Drawing.Point(28, 224);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(53, 22);
            this.lblDiem.TabIndex = 0;
            this.lblDiem.Text = "Điểm";
            // 
            // lblSoTinChi
            // 
            this.lblSoTinChi.AutoSize = true;
            this.lblSoTinChi.Location = new System.Drawing.Point(28, 135);
            this.lblSoTinChi.Name = "lblSoTinChi";
            this.lblSoTinChi.Size = new System.Drawing.Size(85, 22);
            this.lblSoTinChi.TabIndex = 0;
            this.lblSoTinChi.Text = "Số tín chỉ";
            // 
            // lblTenMonHoc
            // 
            this.lblTenMonHoc.AutoSize = true;
            this.lblTenMonHoc.Location = new System.Drawing.Point(28, 43);
            this.lblTenMonHoc.Name = "lblTenMonHoc";
            this.lblTenMonHoc.Size = new System.Drawing.Size(110, 22);
            this.lblTenMonHoc.TabIndex = 0;
            this.lblTenMonHoc.Text = "Tên môn học";
            // 
            // nhomDanhSachMonHoc
            // 
            this.nhomDanhSachMonHoc.Controls.Add(this.danhSachMonHoc);
            this.nhomDanhSachMonHoc.Location = new System.Drawing.Point(544, 31);
            this.nhomDanhSachMonHoc.Name = "nhomDanhSachMonHoc";
            this.nhomDanhSachMonHoc.Size = new System.Drawing.Size(503, 311);
            this.nhomDanhSachMonHoc.TabIndex = 1;
            this.nhomDanhSachMonHoc.TabStop = false;
            this.nhomDanhSachMonHoc.Text = "Danh sách các môn học";
            // 
            // danhSachMonHoc
            // 
            this.danhSachMonHoc.Location = new System.Drawing.Point(18, 25);
            this.danhSachMonHoc.Multiline = true;
            this.danhSachMonHoc.Name = "danhSachMonHoc";
            this.danhSachMonHoc.ReadOnly = true;
            this.danhSachMonHoc.Size = new System.Drawing.Size(469, 267);
            this.danhSachMonHoc.TabIndex = 2;
            // 
            // lblTongSoTinChi
            // 
            this.lblTongSoTinChi.AutoSize = true;
            this.lblTongSoTinChi.Location = new System.Drawing.Point(575, 380);
            this.lblTongSoTinChi.Name = "lblTongSoTinChi";
            this.lblTongSoTinChi.Size = new System.Drawing.Size(126, 22);
            this.lblTongSoTinChi.TabIndex = 2;
            this.lblTongSoTinChi.Text = "Tổng số tín chỉ";
            // 
            // lblTongSoDiem
            // 
            this.lblTongSoDiem.AutoSize = true;
            this.lblTongSoDiem.Location = new System.Drawing.Point(855, 380);
            this.lblTongSoDiem.Name = "lblTongSoDiem";
            this.lblTongSoDiem.Size = new System.Drawing.Size(116, 22);
            this.lblTongSoDiem.TabIndex = 2;
            this.lblTongSoDiem.Text = "Tổng số điểm";
            // 
            // lblDiemTrungBinh
            // 
            this.lblDiemTrungBinh.AutoSize = true;
            this.lblDiemTrungBinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemTrungBinh.Location = new System.Drawing.Point(594, 474);
            this.lblDiemTrungBinh.Name = "lblDiemTrungBinh";
            this.lblDiemTrungBinh.Size = new System.Drawing.Size(144, 23);
            this.lblDiemTrungBinh.TabIndex = 2;
            this.lblDiemTrungBinh.Text = "Điểm trung bình";
            // 
            // hienThiTongSoTinChi
            // 
            this.hienThiTongSoTinChi.Location = new System.Drawing.Point(579, 416);
            this.hienThiTongSoTinChi.Name = "hienThiTongSoTinChi";
            this.hienThiTongSoTinChi.ReadOnly = true;
            this.hienThiTongSoTinChi.Size = new System.Drawing.Size(122, 30);
            this.hienThiTongSoTinChi.TabIndex = 3;
            // 
            // hienThiDiemTrungBinh
            // 
            this.hienThiDiemTrungBinh.Location = new System.Drawing.Point(777, 472);
            this.hienThiDiemTrungBinh.Name = "hienThiDiemTrungBinh";
            this.hienThiDiemTrungBinh.ReadOnly = true;
            this.hienThiDiemTrungBinh.Size = new System.Drawing.Size(210, 30);
            this.hienThiDiemTrungBinh.TabIndex = 4;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(887, 548);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 34);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.exit_Click);
            // 
            // btnTinhToan
            // 
            this.btnTinhToan.Location = new System.Drawing.Point(579, 548);
            this.btnTinhToan.Name = "btnTinhToan";
            this.btnTinhToan.Size = new System.Drawing.Size(198, 34);
            this.btnTinhToan.TabIndex = 5;
            this.btnTinhToan.Text = "Tính toán";
            this.btnTinhToan.UseVisualStyleBackColor = true;
            this.btnTinhToan.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // hienThiTongSoDiem
            // 
            this.hienThiTongSoDiem.Location = new System.Drawing.Point(859, 416);
            this.hienThiTongSoDiem.Name = "hienThiTongSoDiem";
            this.hienThiTongSoDiem.ReadOnly = true;
            this.hienThiTongSoDiem.Size = new System.Drawing.Size(128, 30);
            this.hienThiTongSoDiem.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 640);
            this.Controls.Add(this.btnTinhToan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.hienThiDiemTrungBinh);
            this.Controls.Add(this.hienThiTongSoDiem);
            this.Controls.Add(this.hienThiTongSoTinChi);
            this.Controls.Add(this.lblDiemTrungBinh);
            this.Controls.Add(this.lblTongSoDiem);
            this.Controls.Add(this.lblTongSoTinChi);
            this.Controls.Add(this.nhomDanhSachMonHoc);
            this.Controls.Add(this.nhomThongTinMonHoc);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listenKeyPress);
            this.nhomThongTinMonHoc.ResumeLayout(false);
            this.nhomThongTinMonHoc.PerformLayout();
            this.nhomDanhSachMonHoc.ResumeLayout(false);
            this.nhomDanhSachMonHoc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox nhomThongTinMonHoc;
        private System.Windows.Forms.TextBox nhapSoTinChi;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.Label lblSoTinChi;
        private System.Windows.Forms.Label lblTenMonHoc;
        private System.Windows.Forms.GroupBox nhomDanhSachMonHoc;
        private System.Windows.Forms.Label lblTongSoTinChi;
        private System.Windows.Forms.Label lblTongSoDiem;
        private System.Windows.Forms.Label lblDiemTrungBinh;
        private System.Windows.Forms.TextBox nhapDiem;
        private System.Windows.Forms.Button btnThemMonHoc;
        private System.Windows.Forms.TextBox hienThiTongSoTinChi;
        private System.Windows.Forms.TextBox hienThiDiemTrungBinh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTinhToan;
        private System.Windows.Forms.TextBox hienThiTongSoDiem;
        private System.Windows.Forms.ComboBox chonMonHoc;
        private System.Windows.Forms.TextBox danhSachMonHoc;
    }
}
