using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class GiaoVien_BUS
    {
        public static List<GiaoVien_DTO> LayDSGiaoVien()
        {
            return GiaoVien_DAO.LayDSGiaoVien();
        }
        public static bool ThemGiaoVien(GiaoVien_DTO gv)
        {
            return GiaoVien_DAO.ThemGiaoVien(gv);
        }
        public static GiaoVien_DTO TimGiaoVienTheoMa(string ma)
        {
            return GiaoVien_DAO.TimGiaovienTheoMa(ma);
        }
        public static List<GiaoVien_DTO> TimNhanVienTheoTen(string ten)
        {
            return GiaoVien_DAO.TimGiaoVientheoTen(ten);
        }
        public static bool SuaGiaoVien(GiaoVien_DTO gv)
        {
            return GiaoVien_DAO.Suagiaovien(gv);
        }
        public static bool Xoa(GiaoVien_DTO hs)
        {
            return GiaoVien_DAO.Xoa(hs);
        }
    }
}
