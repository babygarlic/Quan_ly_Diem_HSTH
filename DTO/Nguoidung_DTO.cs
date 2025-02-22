using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Nguoidung_DTO
    {
        private string tenDangNhap;

        private string matKhau;

        private string quyen;

        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }

        public string MatKhau { get => matKhau; set => matKhau = value; }

        public string Quyen { get => quyen; set => quyen = value; }
    }
}
