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
    public partial class BaoCao : Form
    {
        public BaoCao()
        {
            InitializeComponent();
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {

            HienThihockyCombobox(); 
            HienThilophocCombobox();
            HienThiMonHocCombobox();
            HienThinamhochocCombobox();
            string mamh =this.cb_mon.SelectedValue.ToString();
            string manh =this.cb_namhoc.SelectedValue.ToString();
            string mahk =this.cb_hocky.SelectedValue.ToString();
            string malop =this.cb_lop.SelectedValue.ToString();
            // TODO: This line of code loads data into the 'qLDHSTHDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.FillBy(this.qLDHSTHDataSet.DataTable1,mamh,manh,mahk,malop);

            this.reportViewer1.RefreshReport();
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
        private void HienThiMonHocCombobox()
        {
            List<Monhoc_DTO> lstmonhoc = Monhoc_BUS.LaydanhsachMonHoc();
            cb_mon.DataSource = lstmonhoc;
            cb_mon.DisplayMember = "TenMH";
            cb_mon.ValueMember = "MaMH";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mamh = this.cb_mon.SelectedValue.ToString();
            string manh = this.cb_namhoc.SelectedValue.ToString();
            string mahk = this.cb_hocky.SelectedValue.ToString();
            string malop = this.cb_lop.SelectedValue.ToString();
            // TODO: This line of code loads data into the 'qLDHSTHDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.FillBy(this.qLDHSTHDataSet.DataTable1, mamh, manh, mahk, malop);

            this.reportViewer1.RefreshReport();
        }
    }
}
