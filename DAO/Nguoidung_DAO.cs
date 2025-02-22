using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public  class Nguoidung_DAO
    {
        static SqlConnection con;
        public static Nguoidung_DTO Laynguoidung(string ten, string matkhau)
        {
            string sTruyVan = string.Format(@"select * from nguoidung where tennguoidung=N'{0}' and matkhau='{1}'", ten,matkhau);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            Nguoidung_DTO nd = new Nguoidung_DTO();
            nd.TenDangNhap = dt.Rows[0]["tennguoidung"].ToString();
            nd.MatKhau = dt.Rows[0]["matkhau"].ToString();
            nd.Quyen = dt.Rows[0]["quyen"].ToString();
            DataProvider.DongKetNoi(con);
            return nd;
        }
    }
}
