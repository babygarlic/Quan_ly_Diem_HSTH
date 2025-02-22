using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAO
{
    public class Bangdiem_DAO
    {    static SqlConnection con;
        public static List<Bangdiem_DTO> LayBangDiem()
        {
            string sTruyVan = " SELECT HocSinh.MaHS,HocSinh.HoTen, hocsinh.ngaysinh,hocsinh.gioitinh,hocsinh.diachi,Diem.Diem_Mieng,Diem.Diem_KT1T,Diem_ThiHK,Diem.Diem_TB\r\n FROM HocSinh\r\n INNER JOIN Lop ON HocSinh.Malop = Lop.Malop \r\n INNER JOIN Diem ON HocSinh.MaHS = Diem.MaHS\r\n INNER JOIN Hocky ON Diem.makh = Hocky.mahk\r\n INNER JOIN Namhoc ON Diem.manh = Namhoc.manh;";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Bangdiem_DTO> lstbangdiem = new List<Bangdiem_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Bangdiem_DTO bangdiem = new Bangdiem_DTO();
                bangdiem.MaHS = dt.Rows[i]["mahs"].ToString();
                bangdiem.HoTen = dt.Rows[i]["HoTen"].ToString();
                bangdiem.NgaySinh = DateTime.Parse(dt.Rows[i]["Ngaysinh"].ToString());
                bangdiem.GioiTinh = dt.Rows[i]["Gioitinh"].ToString();
                bangdiem.DiaChi = dt.Rows[i]["Diachi"].ToString();
                float diemMieng, diemKT1t, diemThiHK, diemTB;

                if (float.TryParse(dt.Rows[i]["diem_mieng"].ToString(), out diemMieng))
                {
                    bangdiem.Diem_Mieng = diemMieng;
                }
                else
                {
                    // Xử lý trường hợp không thể chuyển đổi thành số.
                    //  đặt giá trị mặc định hoặc báo lỗi.
                    //  đặt giá trị mặc định là 0.
                    bangdiem.Diem_Mieng = 0;
                }

                if (float.TryParse(dt.Rows[i]["diem_kt1t"].ToString(), out diemKT1t))
                {
                    bangdiem.Diem_KT1t = diemKT1t;
                }
                else
                {
                    bangdiem.Diem_KT1t = 0;
                }

                if (float.TryParse(dt.Rows[i]["diem_thihk"].ToString(), out diemThiHK))
                {
                    bangdiem.Diem_ThiHK = diemThiHK;
                }
                else
                {
                    bangdiem.Diem_ThiHK = 0;
                }

                if (float.TryParse(dt.Rows[i]["Diem_tb"].ToString(), out diemTB))
                {
                    bangdiem.Diem_TB = diemTB;
                }
                else
                {
                    bangdiem.Diem_TB = 0;
                }

                lstbangdiem.Add(bangdiem);
                DataProvider.DongKetNoi(con);
            }

            return lstbangdiem;
        }
    }
}
