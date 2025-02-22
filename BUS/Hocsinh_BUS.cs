using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class Hocsinh_BUS
    {
        public static List<HocSinh_DTO> LayDSHocsinh()
        {
            return HocSinh_DAO.LayDSHocsinh();
        }
        public static bool ThemHocsinh(HocSinh_DTO hs)
        {
            return HocSinh_DAO.ThemHocsinh(hs);
        }
        public static HocSinh_DTO TimHocsinhTheoMa(string ma)
        {
            return HocSinh_DAO.TimHocsinhTheoMa(ma);
        }
        public static List<HocSinh_DTO> TimHocSinhTheoTen(string ten)
        {
            return HocSinh_DAO.TimHocsinhTheoTen(ten);
        }
        public static bool SuaHocSinh(HocSinh_DTO hs)
        {
            return HocSinh_DAO.SuaHocSinh(hs);
        }
        public static bool Xoa(HocSinh_DTO hs)
        {
            return HocSinh_DAO.Xoa(hs);
        }
        public static List<HocSinh_DTO> LayDSHocsinhtheolop(string lop)
        {
            return HocSinh_DAO.LayDSHocsinhtheolop(lop);
        }
      
    }
}
