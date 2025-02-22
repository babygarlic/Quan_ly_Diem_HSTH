using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class LopHoc_BUS
    {
        public static List<LopHoc_DTO> Laydanhsachlophoc()
        {
            return LopHoc_DAO.LaydanhsachLopHoc();
        }
        public static bool Themlop(LopHoc_DTO lop)
        {
            return LopHoc_DAO.Themlop(lop);
        }
        public static bool Sualop(LopHoc_DTO lop)
        {
            return LopHoc_DAO.Sualop(lop);
        }
        public static bool Xoa(LopHoc_DTO lop)
        {
            return LopHoc_DAO.Xoa(lop);
        }
    }
}
