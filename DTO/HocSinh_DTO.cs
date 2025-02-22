using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocSinh_DTO
    {
        private string maHS;
        private string hoTen;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string diaChi;
        private string maLop;

        public string MaHS { get => maHS; set => maHS = value; }

        public string HoTen { get => hoTen; set => hoTen = value; }

        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }

        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }

        public string DiaChi { get => diaChi; set => diaChi = value; }

        public string MaLop { get => maLop; set => maLop = value; }
    }
}
