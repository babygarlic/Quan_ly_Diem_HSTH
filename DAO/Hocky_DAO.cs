using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class Hocky_DAO
    {
        static SqlConnection con;
        public static  List<Hocky_DTO> layhocky()
        {
            
                string sTruyVan = "select * from hocky";
                con = DataProvider.MoKetNoi();
                DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                List<Hocky_DTO> lsthocky = new List<DTO.Hocky_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Hocky_DTO hocky = new Hocky_DTO();
                    hocky.Hoc_Ky = dt.Rows[i]["tenhk"].ToString();
                    hocky.Mahocky = dt.Rows[i]["mahk"].ToString();
                    lsthocky.Add(hocky);
                   
                }
                return lsthocky;

            
        } 
    }
}
