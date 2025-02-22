using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemHSTH
{
    public partial class QuanlyMonHoc : Form
    {
        public QuanlyMonHoc()
        {
            InitializeComponent();
        }

        private void QuanlyMonHoc_Load(object sender, EventArgs e)
        {
            hienthimonhoc();
        }
        private void hienthimonhoc()
        {
            List<Monhoc_DTO> lstmh= Monhoc_BUS.LaydanhsachMonHoc();
            this.datamonhoc.DataSource = lstmh;
            this.datamonhoc.Columns["MaMH"].HeaderText = "Mã Môn Học";
            this.datamonhoc.Columns["TenMH"].HeaderText = "Tên Môn Học";
        }

        private void datamonhoc_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = datamonhoc.SelectedRows[0];
            this.tbmamh.Text = r.Cells["MaMH"].Value.ToString();
            this.tb_tenmon.Text = r.Cells["TenMH"].Value.ToString();
           
        }

        private void btb_them_Click(object sender, EventArgs e)
        {
            if (this.tb_tenmon == null)
            {
                MessageBox.Show("vui lòng nhập tên môn học!");
                return;
            }
            Monhoc_DTO monhoc = new Monhoc_DTO();
            monhoc.MaMH = this.tbmamh.Text;
            monhoc.TenMH= this.tb_tenmon.Text;
            if (Monhoc_BUS.ThemMonhoc(monhoc) == false)
            {
                MessageBox.Show("Cập nhật thất bại.");
                return;
            }

            hienthimonhoc();
            MessageBox.Show("Đã cập nhật thành công.");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            Monhoc_DTO monhoc = new Monhoc_DTO();
            monhoc.MaMH = this.tbmamh.Text;
            monhoc.TenMH = this.tb_tenmon.Text;
            if (Monhoc_BUS.Xoa(monhoc) == false)
            {
                MessageBox.Show("Cập nhật thất bại.");
                return;
            }

            hienthimonhoc();
            MessageBox.Show("Đã cập nhật thành công.");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            Monhoc_DTO monhoc = new Monhoc_DTO();
            monhoc.MaMH = this.tbmamh.Text;
            monhoc.TenMH = this.tb_tenmon.Text;
            if (Monhoc_BUS.Sua(monhoc) == false)
            {
                MessageBox.Show("Cập nhật thất bại.");
                return;
            }

            hienthimonhoc();
            MessageBox.Show("Đã cập nhật thành công.");
        }
    }
}
