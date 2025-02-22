using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml;

namespace DAO
{
    public class Namhoc_DAO
    {
        static SqlConnection con;
        public static  List<Namhoc_DTO> laynamhoc()
        {
            
                string sTruyVan = "select * from namhoc";
                con = DataProvider.MoKetNoi();
                DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
                
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                List<Namhoc_DTO> lstnamhoc = new List<DTO.Namhoc_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Namhoc_DTO namhoc = new Namhoc_DTO();
                    namhoc.ManamHoc = dt.Rows[i]["manh"].ToString();
                    namhoc.NamHoc = dt.Rows[i]["tennh"].ToString();
                    lstnamhoc.Add(namhoc);

                }
                return lstnamhoc;

            
        }
    }
}
