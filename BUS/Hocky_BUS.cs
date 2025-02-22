using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Hocky_BUS
    {
        public static List<Hocky_DTO> layhocky()
        {
            return Hocky_DAO.layhocky();
        }
    }
}
