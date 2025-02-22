using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Hocky_DTO
    {
        private string hoc_Ky;
        private string mahocky;

        public string Hoc_Ky
        {
            get { return hoc_Ky; }
            set { hoc_Ky = value; }
        }

        public string Mahocky { get => mahocky; set => mahocky = value; }
    }
}
