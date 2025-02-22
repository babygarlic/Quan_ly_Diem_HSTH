using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Diem_BUS
    {

        public static bool ThemDiem(Diem_DTO diem)
        {
            return Diem_DAO.ThemDiem(diem);
        }
        public static Diem_DTO LayDiem(string mahs, string mamh, string mahk, string manh)
        {
            return Diem_DAO.LayDiem(mahs, mamh, mahk, manh);    
        }
        public static bool xoadiem(Diem_DTO diem)
        {
            return Diem_DAO.xoadiem(diem);
        }
        public static bool suadiem(Diem_DTO diem)
        {
            return Diem_DAO.suadiem(diem);
        }
    }
}
