using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class GiaoVien_DAO
    {
        static SqlConnection con;
        public static List<GiaoVien_DTO> LayDSGiaoVien()
        {
            string sTruyVan = "select * from giaovien";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<GiaoVien_DTO> lsthocsinh = new List<DTO.GiaoVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                GiaoVien_DTO gv = new GiaoVien_DTO();
                gv.MaGV = dt.Rows[i]["MaGV"].ToString();
                gv.HoTenGV = dt.Rows[i]["HoTenGV"].ToString();
                gv.NgaySinh = DateTime.Parse(dt.Rows[i]["Ngaysinh"].ToString());
                gv.GioiTinh = dt.Rows[i]["Gioitinh"].ToString();
                gv.DiaChi = dt.Rows[i]["Diachi"].ToString();
                gv.ChuVu = dt.Rows[i]["ChucVu"].ToString();
                gv.BoMon = dt.Rows[i]["BoMonGD"].ToString() ;
                lsthocsinh.Add(gv);
            }
            DataProvider.DongKetNoi(con);
            return lsthocsinh;
        }
        public static bool ThemGiaoVien(GiaoVien_DTO gv)
        {
            string sTruyVan = string.Format(@"INSERT INTO GiaoVien (HoTenGV, Ngaysinh, GioiTinh, Diachi, Chucvu, BoMonGD)
                                                VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')", gv.HoTenGV, gv.NgaySinh, gv.GioiTinh, gv.DiaChi, gv.ChuVu,gv.BoMon);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static GiaoVien_DTO TimGiaovienTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from giaovien where magv=N'{0}'",
           ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            GiaoVien_DTO gv = new GiaoVien_DTO();
            gv.MaGV = dt.Rows[0]["MaGV"].ToString();
            gv.HoTenGV = dt.Rows[0]["HoTenGV"].ToString();
            gv.NgaySinh = DateTime.Parse(dt.Rows[0]["Ngaysinh"].ToString());
            gv.GioiTinh = dt.Rows[0]["Gioitinh"].ToString();
            gv.DiaChi = dt.Rows[0]["Diachi"].ToString();
            gv.ChuVu = dt.Rows[0]["ChucVu"].ToString();
            gv.BoMon = dt.Rows[0]["BoMonGD"].ToString();


            DataProvider.DongKetNoi(con);
            return gv;
        }
        public static List<GiaoVien_DTO> TimGiaoVientheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select * from giaovien where tengv like'%{0}%'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<GiaoVien_DTO> lstgiaovien = new List<DTO.GiaoVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                GiaoVien_DTO gv = new GiaoVien_DTO();
                gv.MaGV = dt.Rows[0]["MaGV"].ToString();
                gv.HoTenGV = dt.Rows[0]["HoTenGV"].ToString();
                gv.NgaySinh = DateTime.Parse(dt.Rows[0]["Ngaysinh"].ToString());
                gv.GioiTinh = dt.Rows[0]["Gioitinh"].ToString();
                gv.DiaChi = dt.Rows[0]["Diachi"].ToString();
                gv.ChuVu = dt.Rows[0]["ChucVu"].ToString();
                gv.BoMon = dt.Rows[0]["BoMonGD"].ToString();
                lstgiaovien.Add(gv);
            }
            DataProvider.DongKetNoi(con);
            return lstgiaovien;

        }
        public static bool Suagiaovien(GiaoVien_DTO gv)
        {
            string sTruyVan = string.Format(@"update giaovien set hotengv=N'{0}',ngaysinh=N'{1}',gioitinh=N'{2}',diachi=N'{3}',chucvu=N'{4}',bomongd=N'{5}' where magv=N'{6}'", gv.HoTenGV, gv.NgaySinh, gv.GioiTinh, gv.DiaChi, gv.ChuVu, gv.BoMon,gv.MaGV);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool Xoa(GiaoVien_DTO gv)
        {
            string sTruyVan = string.Format(@"delete from giaovien where magv=N'{0}'",gv.MaGV);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

    }
}

