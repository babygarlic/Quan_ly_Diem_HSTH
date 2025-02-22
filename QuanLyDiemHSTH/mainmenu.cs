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
    public partial class mainmenu : Form
    {
        public mainmenu()
        {
            InitializeComponent();
            
        }
        bool menuExpand = true;
        private void menuTrasiton_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                this.sidebar.Width -= 10;
                if (this.sidebar.Width <= 62)
                {
                    menuExpand = false;
                    menuTrasiton.Stop();
                   
                }
            }
            else
            {
                btn_setting.Text = "Setting";
                sidebar.Width += 10;
                if (this.sidebar.Width >= 210)
                {
                    menuExpand = true;
                    menuTrasiton.Stop();
                    
                }
            }

            
        }

        private void btn_Tranlate_Click(object sender, EventArgs e)
        {
            menuTrasiton.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu1transition.Start();    
        }
        bool menu1expan= false;
        private void menu1tránition_Tick(object sender, EventArgs e)
        {
            if (menu1expan==false)
            {
                this.container.Height += 10;
                    if (this.container.Height >= 285)
                    {
                        menu1expan = true;
                        menu1transition.Stop();
                    }
            }
            else
            {
                this.container.Height -= 10;
                if (this.container.Height <= 64)
                {
                    menu1expan = false;
                    menu1transition.Stop();
                }
            }
        }
        private Form currentFormChild;

        private void openChildForm(Form childForm)
        {
            if (currentFormChild != null)
                currentFormChild.Close();

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pn_noidung.Controls.Add(childForm);
            pn_noidung.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_monhoc_Click(object sender, EventArgs e)
        {
            openChildForm(new QuanlyMonHoc());
        }

        private void btn_quanlidiem_Click(object sender, EventArgs e)
        {
            openChildForm(new QuanLyDiem());
        }

        private void btn_qlhs_Click(object sender, EventArgs e)
        {
            openChildForm(new QuanLyHS());
        }

       
        private void btn_giaovien_Click(object sender, EventArgs e)
        {
            openChildForm(new QuanLyGV());
        }

        private void btn_lophoc_Click(object sender, EventArgs e)
        {
            openChildForm(new QuanLyLOP());
        }
        private void pn_noidung_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainmenu_Load(object sender, EventArgs e)
        {
            HienThiMenu();
            openChildForm(new home());
        }
        public bool bDangNhap;
        // true: đăng nhập thành công, false: chưa đăng nhập
        DangNhap fDN;
        public Nguoidung_DTO NguoiDung;
        public void HienThiMenu()
        {   this.btndangnhap.Visible = true;
            this.btndangxuat.Visible = false;
            this.btndangnhap.Enabled= !bDangNhap;
            this.btn_menu.Enabled = bDangNhap;
            this.btn_giaovien.Enabled = bDangNhap;
            this.btn_lophoc.Enabled = bDangNhap;
            this.btn_monhoc.Enabled = bDangNhap;
            this.btn_quanlidiem.Enabled = bDangNhap;
            this.btn_qlhs.Enabled = bDangNhap;
            this.btn_giaovien.Enabled=bDangNhap;
            this.btn_report.Enabled = bDangNhap;
            this.btn_setting.Enabled = bDangNhap;
            
      
            if (bDangNhap == true)
            {
                this.lbnd.Text = "Người dùng: " + NguoiDung.TenDangNhap;
                this.lbthoigiandn.Text= "Thời điểm đăng nhập: " + DateTime.Now;
                // Hiển thị menu theo quyền, ví dụ: 
                //  1. quantri: sử dụng tất cả menu 
                //  2. nhanvien: không sử dụng các menu: Danh mục, Nghiệp vụ
                int iQuyen;
                if (NguoiDung == null)
                {
                    iQuyen = 0;
                }
                else
                {
                    iQuyen = int.Parse(NguoiDung.Quyen.ToString());
                }
                switch (iQuyen)
                {
                    case 1:
                        this.btn_menu.Enabled = true;
                        this.btn_giaovien.Enabled = true;
                        this.btn_lophoc.Enabled = true;
                        this.btn_monhoc.Enabled = true;
                        this.btn_quanlidiem.Enabled = true;
                        this.btn_qlhs.Enabled = true;
                        this.btn_giaovien.Enabled = true;
                        this.btn_report.Enabled = true;
                        this.btn_setting.Enabled = true;
                        this.btndangnhap.Visible = false;
                        this.btndangxuat.Visible = true;


                        break;

                    case 2:
                        this.btn_menu.Enabled = true;
                        this.btn_quanlidiem.Enabled = true;
                        this.btn_report.Enabled = true;
                        this.btn_setting.Enabled = true;
                        this.btn_giaovien.Enabled = false;
                        this.btn_lophoc.Enabled = false;
                        this.btn_monhoc.Enabled = false;
                        this.btn_qlhs.Enabled = false;
                        this.btn_giaovien.Enabled = false;
                        this.btndangnhap.Visible = false;
                        this.btndangxuat.Visible = true;
                        break;

                    default:
                        break;
                }
            }
            else
            {
                this.lbnd.Text = "Chưa đăng nhập";
                this.lbthoigiandn.Text = "";
            }
        }
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            
                fDN = new DangNhap();
                if (fDN.ShowDialog() == DialogResult.OK)
                {
                    string sTen = fDN.tb_tendangnhap.Text;
                    string sMatKhau = fDN.tb_matkhau.Text;
                    NguoiDung = new Nguoidung_DTO();
                    NguoiDung = Nguoidung_BUS.LayNguoiDung(sTen, sMatKhau);
                    if (NguoiDung != null)
                    {
                        bDangNhap = true;
                        this.btndangnhap.Visible = false;
                        this.btndangxuat.Visible = true;
                                MessageBox.Show("Đăng Nhập Thành Công");
                     }
                    else
                        {
                            bDangNhap = false;
                            MessageBox.Show("Thông tin đăng Nhập sai vui lòng Nhập Lại");
                            fDN.ShowDialog();
                            fDN.tb_matkhau.Clear();
                            fDN.tb_matkhau.Focus();

                    }
                 }
               
                HienThiMenu();


            
       
             
        }
        private void i_htdangxuat_Click(object sender, EventArgs e)
        {
            // Đóng tất cả form đang mở
            

        }

        private void Home_Click(object sender, EventArgs e)
        {
            openChildForm(new home());
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {

        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Help.chm");
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            openChildForm(new BaoCao());
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (!f.IsDisposed)
                    f.Close();
            }
            // Đăng xuất và thiết lập lại menu
            bDangNhap = false;
            this.btndangnhap.Visible=true;
            openChildForm(new home());
            HienThiMenu();
            MessageBox.Show("Đăng Xuất Thành Công");

        }

        private void reporthocsinh_Click(object sender, EventArgs e)
        {
           
        }
    }
}
