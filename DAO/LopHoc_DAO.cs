using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class LopHoc_DAO
    {
        static SqlConnection con;

        public static List<LopHoc_DTO> LaydanhsachLopHoc()

        {
            string sTruyVan = "select * from Lop";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan,con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<LopHoc_DTO> lstlophoc = new List<LopHoc_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LopHoc_DTO lh = new LopHoc_DTO();
                lh.TenLop = dt.Rows[i]["TenLop"].ToString();
                lh.MaLop = dt.Rows[i]["MaLop"].ToString();
                lh.SiSo= int.Parse((dt.Rows[i]["Siso"]).ToString()); 
                lh.TenGVCN = dt.Rows[i]["TenGVCN"].ToString();
                lh.MaGVCN= dt.Rows[i]["MaGVCN"].ToString();

                lstlophoc.Add(lh);
            }
            DataProvider.DongKetNoi(con);

            return lstlophoc;
        }
        public static bool Themlop(LopHoc_DTO lop)
        {
            string sTruyVan = string.Format(@"INSERT INTO lop (tenlop,siso,magvcn,tengvcn)
                                                VALUES (N'{0}',N'{1}',N'{2}',N'{3}')", lop.TenLop, lop.SiSo, lop.MaGVCN, lop.TenGVCN);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        
        public static List<LopHoc_DTO> TimHocsinhTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select * from hocsinh where hoten like'%{0}%'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<LopHoc_DTO> lstlophoc = new List<LopHoc_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LopHoc_DTO lh = new LopHoc_DTO();
                lh.TenLop = dt.Rows[i]["TenLop"].ToString();
                lh.MaLop = dt.Rows[i]["MaLop"].ToString();
                lh.SiSo = int.Parse((dt.Rows[i]["Siso"]).ToString());
                lh.TenGVCN = dt.Rows[i]["TenGVCN"].ToString();
                lh.MaGVCN = dt.Rows[i]["MaGVCN"].ToString();

                lstlophoc.Add(lh);
            }
            DataProvider.DongKetNoi(con);

            return lstlophoc;
        }
        public static bool Sualop(LopHoc_DTO lop)
        {
            string sTruyVan = string.Format(@"update lop set tenlop=N'{0}',siso='{1}',magvcn=N'{2}',tengvcn=N'{3}' where Malop=N'{4}'", lop.TenLop, lop.SiSo, lop.MaGVCN, lop.TenGVCN,  lop.MaLop);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool Xoa(LopHoc_DTO lop)
        {
            string sTruyVan = string.Format(@"delete from lop where malop=N'{0}'", lop.MaLop);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

    }
}
