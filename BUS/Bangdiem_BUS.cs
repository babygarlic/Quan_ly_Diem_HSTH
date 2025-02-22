using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class Bangdiem_BUS
    {
        public static List<Bangdiem_DTO> Laybangdiem()
        {
            return Bangdiem_DAO.LayBangDiem();
        }
    }
}
