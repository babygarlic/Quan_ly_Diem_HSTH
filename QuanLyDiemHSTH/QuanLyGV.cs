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
    public partial class QuanLyGV : Form
    {
        public QuanLyGV()
        {
            InitializeComponent();
        }

        private void bt_themgv_Click(object sender, EventArgs e)
        {
            if (tb_hoten.Text == "" || tb_diachi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (tb_magv.Text.Length > 1)
            {
                MessageBox.Show("Mã Học sinh đã được thiết lập sẵn bạn không cần nhập");
                return;
            }

            GiaoVien_DTO gv = new GiaoVien_DTO();

            gv.HoTenGV = tb_hoten.Text;
            if (this.radioButtonnam.Checked == true)
            {
                gv.GioiTinh = "Nam";
            }
            else
            {
                gv.GioiTinh = "Nữ";
            }
            gv.NgaySinh = DateTime.Parse(this.dtb_ngaysinh.Text);
            gv.DiaChi = this.tb_diachi.Text;
            gv.ChuVu= this.tbchucvu.Text;
            gv.BoMon=this.tb_bomon.Text;
            if (GiaoVien_BUS.ThemGiaoVien(gv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }

            HienThiDSGiaovienLenDatagrid();
            MessageBox.Show("Đã thêm giáo viên thành công.");
        }
    

        private void bt_suagv_Click(object sender, EventArgs e)
        {
            if (tb_hoten.Text == "" || tb_diachi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            GiaoVien_DTO gv = new GiaoVien_DTO();
            gv.MaGV=tb_magv.Text;
            gv.HoTenGV = tb_hoten.Text;
            if (this.radioButtonnam.Checked == true)
            {
                gv.GioiTinh = "Nam";
            }
            else
            {
                gv.GioiTinh = "Nữ";
            }
            gv.NgaySinh = DateTime.Parse(this.dtb_ngaysinh.Text);
            gv.DiaChi = this.tb_diachi.Text;
            gv.ChuVu = this.tbchucvu.Text;
            gv.BoMon = this.tb_bomon.Text;
            if (GiaoVien_BUS.SuaGiaoVien(gv) == true)
            {
                HienThiDSGiaovienLenDatagrid();
                MessageBox.Show("Cập Nhật Thành Công");
            }
            else
            {
                MessageBox.Show("Cập Nhật Thất Bại");
            }
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tb_hoten.Text == "" || tb_diachi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không

            GiaoVien_DTO gv = new GiaoVien_DTO();
            gv.MaGV=tb_magv.Text;
            gv.HoTenGV = tb_hoten.Text;
            if (this.radioButtonnam.Checked == true)
            {
                gv.GioiTinh = "Nam";
            }
            else
            {
                gv.GioiTinh = "Nữ";
            }
            gv.NgaySinh = DateTime.Parse(this.dtb_ngaysinh.Text);
            gv.DiaChi = this.tb_diachi.Text;
            gv.ChuVu = this.tbchucvu.Text;
            gv.BoMon = this.tb_bomon.Text;
            if (GiaoVien_BUS.Xoa(gv)== true)
            {
                HienThiDSGiaovienLenDatagrid();
                MessageBox.Show("Xóa Giáo Viên Thành Công");
            }
            else
            {
                MessageBox.Show("Không Thể Xóa Giáo Viên");
            }
        }

        private void QuanLyGV_Load(object sender, EventArgs e)
        {
            HienThiDSGiaovienLenDatagrid();
        }
        
        private void HienThiDSGiaovienLenDatagrid()
        {
            List<GiaoVien_DTO> lsthocsinh = GiaoVien_BUS.LayDSGiaoVien();

            this.dt_danhsachgiaovien.DataSource = lsthocsinh;
            this.dt_danhsachgiaovien.Columns["MaGV"].HeaderText = "Mã số";
            this.dt_danhsachgiaovien.Columns["HoTenGV"].HeaderText = "Họ và Tên";
            this.dt_danhsachgiaovien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            this.dt_danhsachgiaovien.Columns["GioiTinh"].HeaderText = "Giới Tính";
            this.dt_danhsachgiaovien.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            this.dt_danhsachgiaovien.Columns["ChuVu"].HeaderText = "Chức Vụ";
            this.dt_danhsachgiaovien.Columns["BoMon"].HeaderText = "Bộ Môn Giảng Dạy";
            


        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = this.dt_danhsachgiaovien.SelectedRows[0];
            this.tb_magv.Text = r.Cells["MaGV"].Value.ToString();
            this.tb_hoten.Text = r.Cells["HoTenGV"].Value.ToString();
            this.dtb_ngaysinh.Text = r.Cells["NgaySinh"].Value.ToString();
            if (r.Cells["GioiTinh"].Value.ToString() == "Nam")
            {
                this.radioButtonnam.Checked = true;
            }
            else
            {
                this.radioButtonnu.Checked = true;
            }
            this.tb_diachi.Text = r.Cells["DiaChi"].Value.ToString();
            this.tbchucvu.Text = r.Cells["ChuVu"].Value.ToString();
            this.tb_bomon.Text = r.Cells["BoMon"].Value.ToString();
        }
    }
}
