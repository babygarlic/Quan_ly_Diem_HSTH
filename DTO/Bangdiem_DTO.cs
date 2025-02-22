using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Bangdiem_DTO
    {
        private string maHS;
        private string hoTen;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string diaChi;
        
        private float diem_Mieng;
        private float diem_KT1t;
        private float diem_ThiHK;
        private float diem_TB;
       
       
        

        public string MaHS
        {
            get { return maHS; }
            set { maHS = value; }
        }
        
        

        public float Diem_Mieng
        {
            get { return diem_Mieng; }
            set { diem_Mieng = value; }
        }
        

        public float Diem_KT1t
        {
            get { return diem_KT1t; }
            set { diem_KT1t = value; }
        }
        

        public float Diem_ThiHK
        {
            get { return diem_ThiHK; }
            set { diem_ThiHK = value; }
        }
       

        public float Diem_TB
        {
            get { return diem_TB; }
            set { diem_TB = value; }
        }

        

        public string HoTen { get => hoTen; set => hoTen = value; }

        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }

        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }

        public string DiaChi { get => diaChi; set => diaChi = value; }


    }
}
