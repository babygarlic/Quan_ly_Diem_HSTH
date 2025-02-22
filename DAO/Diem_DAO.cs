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
    public  class Diem_DAO
    {
        static SqlConnection con;

        public static Diem_DTO LayDiem( string mahs , string mamh, string mahk,string manh)
        {
            string sTruyVan = string.Format("select * from diem where diem.MaMH=N'{0}' and diem.manh =N'{1}'and diem.MaHS=N'{2}' and Diem.makh=N'{3}'", mamh, manh, mahs, mahk);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            Diem_DTO diem = new Diem_DTO();
            if (dt.Rows.Count > 0)
            {
                diem.MaHS = dt.Rows[0]["mahs"].ToString();
                diem.MH = dt.Rows[0]["mamh"].ToString();
                float diemMieng, diemKT1t, diemThiHK, diemTB;
                if (float.TryParse(dt.Rows[0]["diem_mieng"].ToString(), out diemMieng))
                {
                    diem.Diem_Mieng = diemMieng;
                }
                else
                {
                    // Xử lý trường hợp không thể chuyển đổi thành số.
                    //  đặt giá trị mặc định hoặc báo lỗi.
                    //  đặt giá trị mặc định là 0.
                    diem.Diem_Mieng = 0;
                }

                if (float.TryParse(dt.Rows[0]["diem_kt1t"].ToString(), out diemKT1t))
                {
                    diem.Diem_KT1t = diemKT1t;
                }
                else
                {
                    diem.Diem_KT1t = 0;
                }

                if (float.TryParse(dt.Rows[0]["diem_thihk"].ToString(), out diemThiHK))
                {
                    diem.Diem_ThiHK = diemThiHK;
                }
                else
                {
                    diem.Diem_ThiHK = 0;
                }

                if (float.TryParse(dt.Rows[0]["Diem_tb"].ToString(), out diemTB))
                {
                    diem.Diem_TB = diemTB;
                }
                else
                {
                    diem.Diem_TB = 0;
                }
                
              
            } 
            DataProvider.DongKetNoi(con);
            return diem;
        }
        public static bool ThemDiem(Diem_DTO diem)
        {
            
            string sTruyVan = string.Format(@"INSERT INTO diem (mahs,mamh,diem_mieng,diem_kt1t,diem_thihk,makh,manh)
                                                VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}')",diem.MaHS, diem.MH, diem.Diem_Mieng,diem.Diem_KT1t,diem.Diem_ThiHK,diem.Hoc_Ky,diem.NamHoc);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
             return kq;
        
        }
        public static bool suadiem(Diem_DTO diem)
        {
            string sTruyVan=string.Format(@"update diem set diem_mieng=N'{0}',diem_kt1t=N'{1}',diem_thihk=N'{2}'where mahs=N'{3}'and MaMH=N'{4}'", diem.Diem_Mieng,diem.Diem_KT1t, diem.Diem_ThiHK, diem.MaHS,diem.MH);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool xoadiem(Diem_DTO diem)
        {
            string sTruyVan = string.Format(@"delete from diem where mahs=N'{0}'", diem.MaHS);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
        DataProvider.DongKetNoi(con);
            return kq;
        }

}
}
