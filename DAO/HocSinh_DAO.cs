using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAO
{
    public class HocSinh_DAO
    {
         static SqlConnection con ;
        public static List<HocSinh_DTO> LayDSHocsinh()
        {
            string sTruyVan = "select * from HocSinh";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HocSinh_DTO> lsthocsinh = new List<DTO.HocSinh_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HocSinh_DTO hs = new HocSinh_DTO();
                hs.MaHS = dt.Rows[i]["MaHS"].ToString();
                hs.HoTen = dt.Rows[i]["HoTen"].ToString();
                hs.NgaySinh = DateTime.Parse(dt.Rows[i]["Ngaysinh"].ToString()); 
                hs.GioiTinh = dt.Rows[i]["Gioitinh"].ToString();
                hs.DiaChi = dt.Rows[i]["Diachi"].ToString();
                hs.MaLop = dt.Rows[i]["Malop"].ToString();
                lsthocsinh.Add(hs);
            }
            DataProvider.DongKetNoi(con);
            return lsthocsinh;
        }
        public static List<HocSinh_DTO> LayDSHocsinhtheolop(string lop)
        {
            string sTruyVan = string.Format("select * from HocSinh  where malop=N'{0}'",lop);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HocSinh_DTO> lsthocsinh = new List<DTO.HocSinh_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HocSinh_DTO hs = new HocSinh_DTO();
                hs.MaHS = dt.Rows[i]["MaHS"].ToString();
                hs.HoTen = dt.Rows[i]["HoTen"].ToString();
                hs.NgaySinh = DateTime.Parse(dt.Rows[i]["Ngaysinh"].ToString());
                hs.GioiTinh = dt.Rows[i]["Gioitinh"].ToString();
                hs.DiaChi = dt.Rows[i]["Diachi"].ToString();
                hs.MaLop = dt.Rows[i]["Malop"].ToString();
                lsthocsinh.Add(hs);
            }
            DataProvider.DongKetNoi(con);
            return lsthocsinh;
        }
        public static bool ThemHocsinh(HocSinh_DTO hs)
        {
            string sTruyVan = string.Format(@"INSERT INTO HocSinh ( HoTen, Ngaysinh, Gioitinh, Diachi, Malop)
                                                VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')",hs.HoTen,hs.NgaySinh,hs.GioiTinh,hs.DiaChi,hs.MaLop);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static HocSinh_DTO TimHocsinhTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from hocsinh where mahs=N'{0}'",
           ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            HocSinh_DTO hs = new HocSinh_DTO();
            hs.MaHS = dt.Rows[0]["MaHS"].ToString();
            hs.HoTen = dt.Rows[0]["HoTen"].ToString();
            hs.NgaySinh = DateTime.Parse(dt.Rows[0]["Ngaysinh"].ToString());
            hs.GioiTinh = dt.Rows[0]["Gioitinh"].ToString();
            hs.DiaChi = dt.Rows[0]["Diachi"].ToString();
            hs.MaLop = dt.Rows[0]["Malop"].ToString();

            DataProvider.DongKetNoi(con);
            return hs;
        }
        public static List<HocSinh_DTO> TimHocsinhTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select * from hocsinh where hoten like'%{0}%'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<HocSinh_DTO> lsthocsinh = new List<DTO.HocSinh_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HocSinh_DTO hs = new HocSinh_DTO();
                hs.MaHS = dt.Rows[i]["MaHS"].ToString();
                hs.HoTen = dt.Rows[i]["HoTen"].ToString();
                hs.NgaySinh = DateTime.Parse(dt.Rows[i]["Ngaysinh"].ToString());
                hs.GioiTinh = dt.Rows[i]["Gioitinh"].ToString();
                hs.DiaChi = dt.Rows[i]["Diachi"].ToString();
                hs.MaLop = dt.Rows[i]["Malop"].ToString();
                lsthocsinh.Add(hs);
            }
            DataProvider.DongKetNoi(con);
            return lsthocsinh;

        }
        public static bool SuaHocSinh(HocSinh_DTO hs)
        {
            string sTruyVan = string.Format(@"update hocsinh set hoten=N'{0}',ngaysinh=N'{1}',gioitinh=N'{2}',diachi=N'{3}',malop=N'{4}' where mahs=N'{5}'", hs.HoTen, hs.NgaySinh, hs.GioiTinh, hs.DiaChi, hs.MaLop, hs.MaHS);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool Xoa(HocSinh_DTO nv)
        {
            string sTruyVan = string.Format(@"delete from hocsinh where mahs=N'{0}'", nv.MaHS);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

    }
}
