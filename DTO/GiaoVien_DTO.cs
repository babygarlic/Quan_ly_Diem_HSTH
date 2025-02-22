using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiaoVien_DTO
    {
        private string maGV;

        private string hoTenGV;

        private DateTime ngaySinh;

        private string gioiTinh;

        private string diaChi;

        private string chuVu;

        private string boMon;


        public string MaGV { get => maGV; set => maGV = value; }

        public string HoTenGV { get => hoTenGV; set => hoTenGV = value; }

        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }

        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }

        public string DiaChi { get => diaChi; set => diaChi = value; }

        public string ChuVu { get => chuVu; set => chuVu = value; }

        public string BoMon { get => boMon; set => boMon = value; }
    }
}
