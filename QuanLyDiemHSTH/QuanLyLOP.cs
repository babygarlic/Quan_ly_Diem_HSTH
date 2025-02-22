using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemHSTH
{
    public partial class QuanLyLOP : Form
    {
        public QuanLyLOP()
        {
            InitializeComponent();
        }

        private void btn_themlop_Click(object sender, EventArgs e)
        {
            if (this.tb_lop.Text == "" || this.tb_soluong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (txt_malop.Text.Length > 1)
            {
                MessageBox.Show("Mã Học sinh đã được thiết lập sẵn bạn không cần nhập");
                return;
            }

            LopHoc_DTO lop = new LopHoc_DTO();

            lop.TenLop = tb_lop.Text;
            lop.SiSo= int.Parse(tb_soluong.Text);
            lop.MaGVCN = this.cb_gvcn.SelectedValue.ToString();
            lop.TenGVCN = this.cb_gvcn.Text;
            if (LopHoc_BUS.Themlop(lop) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }

            hienthidanhsachlophoc();
            MessageBox.Show("Đã thêm  thành công.");
        }

        private void btnxoalop_Click(object sender, EventArgs e)
        {
            LopHoc_DTO lop = new LopHoc_DTO();
            lop.MaLop = this.txt_malop.Text;
            lop.TenLop = tb_lop.Text;
            lop.SiSo = int.Parse(tb_soluong.Text);
            lop.MaGVCN = this.cb_gvcn.SelectedValue.ToString();
            lop.TenGVCN = this.cb_gvcn.Text;
            if (LopHoc_BUS.Xoa(lop) == false)
            {
                MessageBox.Show("Không xóa được.");
                return;
            }

            hienthidanhsachlophoc();
            MessageBox.Show("Đã Xóa  thành công.");
        }

        private void btn_sualop_Click(object sender, EventArgs e)
        {
            LopHoc_DTO lop = new LopHoc_DTO();
            lop.MaLop= txt_malop.Text;
            lop.TenLop = tb_lop.Text;
            lop.SiSo = int.Parse(tb_soluong.Text);
            lop.MaGVCN = this.cb_gvcn.SelectedValue.ToString();
            lop.TenGVCN = this.cb_gvcn.Text;
            if (LopHoc_BUS.Sualop(lop) == false)
            {
                MessageBox.Show("Không cập nhật được.");
                return;
            }

            hienthidanhsachlophoc();
            MessageBox.Show("Đã cập nhật thành công.");
        }

        private void QuanLyLOP_Load(object sender, EventArgs e)
        {
            hienthidanhsachlophoc();
            hienthigiaovienlencb();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = datalophoc.SelectedRows[0];
            this.tb_lop.Text = r.Cells["TenLop"].Value.ToString();
            this.txt_malop.Text = r.Cells["MaLop"].Value.ToString();
            this.tb_soluong.Text = r.Cells["SiSo"].Value.ToString();
            this.cb_gvcn.SelectedValue = r.Cells["MaGVCN"].Value;
        }
        public  void hienthidanhsachlophoc()
        { 
            List<LopHoc_DTO> lstlophoc = LopHoc_BUS.Laydanhsachlophoc();
            this.datalophoc.DataSource = lstlophoc;
            
            this.datalophoc.Columns["TenLop"].HeaderText = "Tên Lớp";
            this.datalophoc.Columns["MaLop"].HeaderText = "Mã Lớp";
            this.datalophoc.Columns["SiSo"].HeaderText = "Số lượng học sinh";
            this.datalophoc.Columns["MaGVCN"].HeaderText = "Mã Giáo Viên";
            this.datalophoc.Columns["TenGVCN"].HeaderText = "Tên Giáo Viên chủ nhiệm";
        }
        public void hienthigiaovienlencb()
        {
            List<GiaoVien_DTO> lstgv = GiaoVien_BUS.LayDSGiaoVien();
            this.cb_gvcn.DataSource= lstgv;
            this.cb_gvcn.DisplayMember = "HoTenGV";
            this.cb_gvcn.ValueMember = "MaGV";
        }
    }
}
