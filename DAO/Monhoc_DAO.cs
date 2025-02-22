using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Monhoc_DAO
    {
        static SqlConnection con;

        public static List<Monhoc_DTO> LaydanhsachMonHoc()

        {
            string sTruyVan = "select * from monhoc";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Monhoc_DTO> lstmonhoc = new List<Monhoc_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Monhoc_DTO mh = new Monhoc_DTO();

                mh.MaMH = dt.Rows[i]["mamh"].ToString();
                mh.TenMH = dt.Rows[i]["tenmh"].ToString();

                lstmonhoc.Add(mh);
            }
            DataProvider.DongKetNoi(con);

            return lstmonhoc;
        }

        public static bool ThemMonhoc(Monhoc_DTO mh)
        {
            string sTruyVan = string.Format(@"INSERT INTO monhoc (tenmh)
                                                VALUES (N'{0}')", mh.TenMH);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static Monhoc_DTO TimmonhocTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from monhoc where mamh=N'{0}'",
           ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            Monhoc_DTO mh = new Monhoc_DTO();
            mh.MaMH = dt.Rows[0]["mamh"].ToString();
            mh.TenMH = dt.Rows[0]["tenmh"].ToString();
            DataProvider.DongKetNoi(con);
            return mh;
        }
        public static List<Monhoc_DTO> TimGiaoVientheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select * from monhoc where tenmh like'%{0}%'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<Monhoc_DTO> lstmh = new List<DTO.Monhoc_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Monhoc_DTO mh = new Monhoc_DTO();
                mh.MaMH = dt.Rows[0]["mamh"].ToString();
                mh.TenMH = dt.Rows[0]["tenmh"].ToString();
                DataProvider.DongKetNoi(con);
                lstmh.Add(mh);
            }
            DataProvider.DongKetNoi(con);
             return lstmh;

        }
        public static bool SuaMon (Monhoc_DTO mh)
        {
            string sTruyVan = string.Format(@"update monhoc set tenmh=N'{0}' where mamh=N'{1}'", mh.TenMH, mh.MaMH);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool Xoa(Monhoc_DTO mh)
        {
            string sTruyVan = string.Format(@"delete from monhoc where mamh=N'{0}'", mh.MaMH);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

    }
}

   

