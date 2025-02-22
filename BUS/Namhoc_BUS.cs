using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class Namhoc_BUS
    {
        public static List<Namhoc_DTO> laynamhoc()
        {
            return Namhoc_DAO.laynamhoc();
        }
    }
}
