using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ListscoreofStudent;



namespace ListScoreofStudent
{
    public partial class Form1 : Form
    {
        private List<Subject> lstMonHoc;
        private List<Subject> lstData;
        //
        public Form1()
        {
            InitializeComponent();
            this.lstData = new List<Subject>();
            this.lstMonHoc = new List<Subject>
            {
                new Subject{
                    TenMonHoc = "CTDLGT",
                    SoTinChi = 2
                },
                new Subject{
                    TenMonHoc = "Giai tich2",
                    SoTinChi = 3
                },
                new Subject{
                    TenMonHoc = "Tieng Anh B2.2",
                    SoTinChi = 6
                },
                new Subject{
                    TenMonHoc = "LTTQ",
                    SoTinChi = 3
                },
                new Subject{
                    TenMonHoc = "Vat ly F1",
                    SoTinChi = 3
                }

            };
            chonMonHoc.DataSource = this.lstMonHoc;
            chonMonHoc.DisplayMember = "TenMonHoc";
            chonMonHoc.ValueMember = "SoTinChi";
            this.KeyPreview = true;
            danhSachMonHoc.ScrollBars = ScrollBars.Vertical;
        }

        private void listenKeyPress(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.H)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            if (e.Alt && e.KeyCode == Keys.D)
            {
                Subject selectedMonHoc = (Subject)chonMonHoc.SelectedItem;
                if (selectedMonHoc == null || nhapDiem.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập điểm cho môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                double diem = double.Parse(nhapDiem.Text);
                if (diem < 0 || diem > 10)
                {
                    MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                selectedMonHoc.Diem = diem;
                this.lstData.Add(new Subject
                {
                    TenMonHoc = selectedMonHoc.TenMonHoc,
                    SoTinChi = selectedMonHoc.SoTinChi,
                    Diem = selectedMonHoc.Diem
                });
                this.HandleShowData();
            }
            if (e.Alt && e.KeyCode == Keys.T)
            {
                if (this.lstData.Count == 0)
                {
                    MessageBox.Show("Vui lòng nhập môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int tongSoTinChi = 0;
                double tongDiem = 0;
                double diemTB = 0;

                foreach (Subject monHoc in this.lstData)
                {
                    tongSoTinChi += monHoc.SoTinChi;
                    tongDiem += monHoc.Diem;
                }

                diemTB = tongDiem / this.lstData.Count;

                hienThiTongSoTinChi.Text = tongSoTinChi.ToString();
                hienThiTongSoDiem.Text = tongDiem.ToString();
                hienThiDiemTrungBinh.Text = diemTB.ToString();
            }
        }
        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void handleChonMonHoc(object sender, EventArgs e)
        {
            Subject selectedMonHoc = (Subject)chonMonHoc.SelectedItem;
            if (selectedMonHoc == null) {
                return;
            }
            nhapSoTinChi.Text = selectedMonHoc.SoTinChi.ToString();
        }
        private void diem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) &&
                (e.KeyChar != '.' || ((TextBox)sender).Text.Contains("."))) // Cho phép duy nhất 1 dấu .
            {
                e.Handled = true; // Ngăn không cho ký tự không hợp lệ được nhập vào
            }
        }

        private void btnThemVaoDS_Click(object sender, EventArgs e)
        {
            Subject selectedMonHoc = (Subject)chonMonHoc.SelectedItem;
            if (selectedMonHoc == null || nhapDiem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập điểm cho môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double diem = double.Parse(nhapDiem.Text);
            if (diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            selectedMonHoc.Diem = diem;
            this.lstData.Add(new Subject
            {
                TenMonHoc = selectedMonHoc.TenMonHoc,
                SoTinChi = selectedMonHoc.SoTinChi,
                Diem = selectedMonHoc.Diem
            });
            this.HandleShowData();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (this.lstData.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int tongSoTinChi = 0;
            double tongDiem = 0;
            double diemTB = 0;

            foreach (Subject monHoc in this.lstData)
            {
                tongSoTinChi += monHoc.SoTinChi;
                tongDiem += monHoc.Diem;
            }

            diemTB = tongDiem / this.lstData.Count;

            hienThiTongSoTinChi.Text = tongSoTinChi.ToString();
            hienThiTongSoDiem.Text = tongDiem.ToString();
            hienThiDiemTrungBinh.Text = diemTB.ToString();
        }
        private void HandleShowData()
        {
            string data = "";
            foreach (Subject monHoc in this.lstData)
            {
                data += monHoc.TenMonHoc + " " + monHoc.SoTinChi + " - " + monHoc.Diem + Environment.NewLine;
            }
            danhSachMonHoc.Text = data;
        }
    }
}
