using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Monhoc_BUS
    {
        public static List<Monhoc_DTO> LaydanhsachMonHoc()
        {
            return Monhoc_DAO.LaydanhsachMonHoc();
        }
        public static bool ThemMonhoc(Monhoc_DTO mh)
        {
            return Monhoc_DAO.ThemMonhoc(mh);
        }
        public static bool Xoa(Monhoc_DTO mh)
        {
            return Monhoc_DAO.Xoa(mh);
        }
        public static bool Sua(Monhoc_DTO mh)
        {
            return Monhoc_DAO.SuaMon(mh);
        }
    }
}
