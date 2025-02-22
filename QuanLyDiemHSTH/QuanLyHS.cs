using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace QuanLyDiemHSTH
{
    public partial class QuanLyHS : Form
    {
        public QuanLyHS()
        {
            InitializeComponent();
        }

        private void QuanLyHS_Load(object sender, EventArgs e)
        {
            HienThiChucVuLenCombobox();
            List<HocSinh_DTO> lsthocsinh = Hocsinh_BUS.LayDSHocsinh();
            if (lsthocsinh == null)
                MessageBox.Show("lỗi");
            this.dt_danhsachhocsinh.DataSource = lsthocsinh;
            //HienThiDSHocSinhLenDatagrid();

        }
        private void HienThiChucVuLenCombobox()
        {
            List<LopHoc_DTO> lstlop = LopHoc_BUS.Laydanhsachlophoc() ;
            cb_lop.DataSource = lstlop;
            cb_lop.DisplayMember = "TenLop";
            cb_lop.ValueMember = "MaLop";
        }

        private void HienThiDSHocSinhLenDatagrid()
        {
            List<HocSinh_DTO> lsthocsinh = Hocsinh_BUS.LayDSHocsinh();
           
            this.dt_danhsachhocsinh.DataSource = lsthocsinh;
            this.dt_danhsachhocsinh.Columns["MaHS"].HeaderText = "Mã số";
            this.dt_danhsachhocsinh.Columns["HoTen"].HeaderText = "Họ và Tên";
            this.dt_danhsachhocsinh.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            this.dt_danhsachhocsinh.Columns["GioiTinh"].HeaderText = "Giới Tính";
            this.dt_danhsachhocsinh.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            this.dt_danhsachhocsinh.Columns["MaLop"].HeaderText = "Mã Lớp";
            this.dt_danhsachhocsinh.Columns["MaHS"].Width = 60;
            this.dt_danhsachhocsinh.Columns["HoTen"].Width = 120;
            this.dt_danhsachhocsinh.Columns["NgaySinh"].Width = 50;
            this.dt_danhsachhocsinh.Columns["GioiTinh"].Width = 50;
            this.dt_danhsachhocsinh.Columns["DiaChi"].Width = 80;
            this.dt_danhsachhocsinh.Columns["MaLop"].Width = 60;


        }

        private void dt_danhsachhocsinh_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dt_danhsachhocsinh.SelectedRows[0];
            this.tb_hoten.Text = r.Cells["HoTen"].Value.ToString();
            this.tb_mahs.Text = r.Cells["MaHS"].Value.ToString();
            this.dt_ngaysinh.Text = r.Cells["NgaySinh"].Value.ToString();
            if (r.Cells["GioiTinh"].Value.ToString() == "Nam")
            {
                this.rdbt_nam.Checked = true;
            }
            else
            {
                this.rdbt_nu.Checked = true;
            }
            this.tb_diachi.Text = r.Cells["DiaChi"].Value.ToString();
            this.cb_lop.SelectedValue = r.Cells["MaLop"].Value;
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (tb_hoten.Text == "" || tb_diachi.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (tb_mahs.Text.Length > 1)
            {
                MessageBox.Show("Mã Học sinh đã được thiết lập sẵn bạn không cần nhập");
                return;
            }
          
           HocSinh_DTO hs = new HocSinh_DTO();
            
            hs.HoTen = tb_hoten.Text;
            if (this.rdbt_nam.Checked == true)
            {
                hs.GioiTinh = "Nam";
            }
            else
            {
                hs.GioiTinh = "Nữ";
            }
            hs.NgaySinh = DateTime.Parse(dt_ngaysinh.Text);
            hs.DiaChi = this.tb_diachi.Text;
            hs.MaLop = this.cb_lop.SelectedValue.ToString();
            if (Hocsinh_BUS.ThemHocsinh(hs) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }

            HienThiDSHocSinhLenDatagrid();
            MessageBox.Show("Đã thêm học sinh thành công.");
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {

            if (tb_mahs.Text == "" || Hocsinh_BUS.TimHocsinhTheoMa(tb_mahs.Text) == null)
            {
                MessageBox.Show("CHON MA");
                return;
            }
            HocSinh_DTO hs = new HocSinh_DTO();
            hs.MaHS = tb_mahs.Text;
            hs.HoTen = tb_hoten.Text;
            if (this.rdbt_nam.Checked == true)
            {
                hs.GioiTinh = "Nam";
            }
            else
            {
                hs.GioiTinh = "Nữ";
            }
            hs.NgaySinh = DateTime.Parse(dt_ngaysinh.Text);
            hs.DiaChi = this.tb_diachi.Text;
            hs.MaLop = this.cb_lop.SelectedValue.ToString();
            if (Hocsinh_BUS.SuaHocSinh(hs) == true)
            {
                HienThiDSHocSinhLenDatagrid();
                MessageBox.Show("Cập Nhật Thành Công");
            }
            else
            {
                MessageBox.Show("Cập Nhật Thất Bại");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (tb_mahs.Text == "" || Hocsinh_BUS.TimHocsinhTheoMa(tb_mahs.Text) == null)
            {
                MessageBox.Show("CHON MA");
                return;
            }
            HocSinh_DTO hs = new HocSinh_DTO();
            hs.MaHS = tb_mahs.Text;
            hs.HoTen = tb_hoten.Text;
            if (this.rdbt_nam.Checked == true)
            {
                hs.GioiTinh = "Nam";
            }
            else
            {
                hs.GioiTinh = "Nữ";
            }
            hs.NgaySinh = DateTime.Parse(dt_ngaysinh.Text);
            hs.DiaChi = this.tb_diachi.Text;
            hs.MaLop = this.cb_lop.SelectedValue.ToString();
            if (Hocsinh_BUS.Xoa(hs) == true)
            {
                HienThiDSHocSinhLenDatagrid();
                MessageBox.Show("Xóa Học Sinh Thành Công");
            }
            else
            {
                MessageBox.Show("Không Thể Xóa Học Sinh");
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string ten = tb_timkiem.Text;
            List<HocSinh_DTO> lstnv = Hocsinh_BUS.TimHocSinhTheoTen(ten);
            if (lstnv == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dt_danhsachhocsinh.DataSource = lstnv;

        }
    }
}
