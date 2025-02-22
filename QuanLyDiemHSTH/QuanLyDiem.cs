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
using DTO;
using BUS;

namespace QuanLyDiemHSTH
{
    public partial class QuanLyDiem : Form
    {
        public QuanLyDiem()
        {
            InitializeComponent();
        }
        private void HienThiDSHocSinhLenDatagrid()
        { string lop =this.cb_lop.SelectedValue.ToString();
            List<HocSinh_DTO> lsthocsinh =  Hocsinh_BUS.LayDSHocsinhtheolop(lop);

            this.dt_danhsachhocsinh.DataSource = lsthocsinh;
            this.dt_danhsachhocsinh.Columns["MaHS"].HeaderText = "Mã số";
            this.dt_danhsachhocsinh.Columns["HoTen"].HeaderText = "Họ và Tên";
            this.dt_danhsachhocsinh.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            this.dt_danhsachhocsinh.Columns["GioiTinh"].HeaderText = "Giới Tính";
            this.dt_danhsachhocsinh.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            

        }
        private void button3_Click(object sender, EventArgs e)
        {
         
            this.dt_danhsachhocsinh.Refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tb_hoten.Text == "" || tb_diachi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
          

            Diem_DTO diem = new Diem_DTO();
            
            diem.MaHS = this.tb_mahs.Text;
            
            diem.MH=cb_mon.SelectedValue.ToString();
            ;
            diem.Diem_KT1t = float.Parse(this.tb45.Text);
            diem.Diem_ThiHK = float.Parse(this.tb_thi.Text);
            diem.Diem_TB = float.Parse(this.tb_tb.Text);
            diem.NamHoc= this.cb_namhoc.SelectedValue.ToString();
            if (float.TryParse(tb_tx.Text, out float diemMieng))
            {
                diem.Diem_Mieng = diemMieng;
            }
            else
            {
                
                diem.Diem_Mieng = 0;
            }
            if (float.TryParse(tb45.Text, out float diem45p))
            {
                diem.Diem_KT1t = diem45p;
            }
            else
            {
               
                diem.Diem_KT1t = 0;
            }
            if (float.TryParse(tb_thi.Text, out float diemthi))
            {
                diem.Diem_ThiHK = diemthi;
            }
            else
            {
            
                diem.Diem_ThiHK = 0;
            }
           
            diem.Hoc_Ky= this.cb_hocky.SelectedValue.ToString();
            if (Diem_BUS.ThemDiem(diem) == false)
            {
                MessageBox.Show("Không thêm được các cột điểm phải lớn hơn 0 và nhỏ hơn hoặc bằng 10.");
                return;
            }

            MessageBox.Show("Đã thêm  thành công.");
            HienThiDSHocSinhLenDatagrid();
            hienthidiem();
        }

        private void btn_xoadiem_Click(object sender, EventArgs e)
        {
            

            Diem_DTO diem = new Diem_DTO();

            diem.MaHS = this.tb_mahs.Text;

            diem.MH = cb_mon.SelectedValue.ToString();
            ;
            diem.Diem_KT1t = float.Parse(this.tb45.Text);
            diem.Diem_ThiHK = float.Parse(this.tb_thi.Text);
            diem.Diem_TB = float.Parse(this.tb_tb.Text);
            diem.NamHoc = this.cb_namhoc.SelectedValue.ToString();
            if (float.TryParse(tb_tx.Text, out float diemMieng))
            {
                diem.Diem_Mieng = diemMieng;
            }
            else
            {

                diem.Diem_Mieng = 0;
            }
            if (float.TryParse(tb45.Text, out float diem45p))
            {
                diem.Diem_KT1t = diem45p;
            }
            else
            {

                diem.Diem_KT1t = 0;
            }
            if (float.TryParse(tb_thi.Text, out float diemthi))
            {
                diem.Diem_ThiHK = diemthi;
            }
            else
            {

                diem.Diem_ThiHK = 0;
            }

            diem.Hoc_Ky = this.cb_hocky.SelectedValue.ToString();
            if (Diem_BUS.xoadiem(diem) == false)
            {
                MessageBox.Show("Không xóa được.");
                return;
            }

            HienThiDSHocSinhLenDatagrid();
            MessageBox.Show("Đã xóa điểm thành công.");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            Diem_DTO diem = new Diem_DTO();

            diem.MaHS = this.tb_mahs.Text;

            diem.MH = cb_mon.SelectedValue.ToString();
            ;
            diem.Diem_KT1t = float.Parse(this.tb45.Text);
            diem.Diem_ThiHK = float.Parse(this.tb_thi.Text);
            diem.Diem_TB = float.Parse(this.tb_tb.Text);
            diem.NamHoc = this.cb_namhoc.SelectedValue.ToString();
            if (float.TryParse(tb_tx.Text, out float diemMieng))
            {
                diem.Diem_Mieng = diemMieng;
            }
            else
            {

                diem.Diem_Mieng = 0;
            }
            if (float.TryParse(tb45.Text, out float diem45p))
            {
                diem.Diem_KT1t = diem45p;
            }
            else
            {

                diem.Diem_KT1t = 0;
            }
            if (float.TryParse(tb_thi.Text, out float diemthi))
            {
                diem.Diem_ThiHK = diemthi;
            }
            else
            {

                diem.Diem_ThiHK = 0;
            }

            diem.Hoc_Ky = this.cb_hocky.SelectedValue.ToString();
            if (Diem_BUS.suadiem(diem) == false)
            {
                MessageBox.Show("Cập nhật thất bại.");
                return;
            }

            HienThiDSHocSinhLenDatagrid();
            MessageBox.Show("Đã cập nhật điểm thành công.");
        }

        private void QuanLyDiem_Load(object sender, EventArgs e)
        {
           
        
            HienThilophocCombobox();
            HienThihockyCombobox();
            HienThinamhochocCombobox();
            HienThiMonHocCombobox();
            HienThiDSHocSinhLenDatagrid();

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
         
        }
        private void HienThilophocCombobox()
        {
            List<LopHoc_DTO> lstlop = LopHoc_BUS.Laydanhsachlophoc();
            cb_lop.DataSource = lstlop;
            cb_lop.DisplayMember = "TenLop";
            cb_lop.ValueMember = "MaLop";
        }
        private void HienThihockyCombobox()
        {
            List<Namhoc_DTO> lsthocky = Namhoc_BUS.laynamhoc();
            cb_namhoc.DataSource = lsthocky;
            cb_namhoc.DisplayMember = "NamHoc";
            cb_namhoc.ValueMember = "ManamHoc";
        }
        private void HienThinamhochocCombobox()
        {
            List<Hocky_DTO> lsthocky = Hocky_BUS.layhocky();
            cb_hocky.DataSource = lsthocky;
            cb_hocky.DisplayMember = "Hoc_Ky";
            cb_hocky.ValueMember = "Mahocky";
        }
        private  void HienThiMonHocCombobox()
        {
            List<Monhoc_DTO> lstmonhoc = Monhoc_BUS.LaydanhsachMonHoc();
            cb_mon.DataSource = lstmonhoc ;
            cb_mon.DisplayMember = "TenMH";
            cb_mon.ValueMember = "MaMH";
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
            hienthidiem();
        }
        private void hienthidiem()
        {
            string mahs = this.tb_mahs.Text;
            string mamh = this.cb_mon.SelectedValue.ToString();
            string mahk = this.cb_hocky.SelectedValue.ToString();
            string manh = this.cb_namhoc.SelectedValue.ToString();
            Diem_DTO diem = Diem_BUS.LayDiem(mahs,mamh,mahk,manh);
            this.tb_tx.Text = diem.Diem_Mieng.ToString();
            this.tb45.Text = diem.Diem_KT1t.ToString();
            this.tb_thi.Text = diem.Diem_ThiHK.ToString();
            this.tb_tb.Text = diem.Diem_TB.ToString();
           // MessageBox.Show(manh + mamh + mahs + mahk);
        }
        
          
        
        private void button3_Click_1(object sender, EventArgs e)
        {
            HienThiDSHocSinhLenDatagrid();
            hienthidiem();
          
        }
    }
}
