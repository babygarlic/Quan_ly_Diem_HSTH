using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Namhoc_DTO
    {
        private string namHoc;
        private string manamhoc;

        public string NamHoc
        {
            get { return namHoc; }
            set { namHoc = value; }

        }

        public string ManamHoc { get => manamhoc; set => manamhoc = value; }
    }
}
