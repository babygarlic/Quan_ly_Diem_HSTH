using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Diem_DTO
    {
        private string maHS;

        public string MaHS
        {
            get { return maHS; }
            set { maHS = value; }
        }
        private string maMH;
        
        public string MH
        {
            get { return maMH; }
            set { maMH = value; }
        }
        private float diem_Mieng;

        public float Diem_Mieng
        {
            get { return diem_Mieng; }
            set { diem_Mieng = value;}
        }
        private float diem_KT1t ;

        public float Diem_KT1t
        {
            get { return diem_KT1t; }
            set {  diem_KT1t= value ; }
        }
        private float diem_ThiHK;

        public float Diem_ThiHK
        {
            get { return diem_ThiHK; }
            set {  diem_ThiHK= value ; }
        }
        private float diem_TB;

        public float Diem_TB
        {
            get { return diem_TB; }
            set { diem_TB = value; }
        }

        private string hoc_Ky;

        public string Hoc_Ky
        {
            get { return hoc_Ky; }
            set { hoc_Ky = value; }
        }

        private string namHoc;

        public string NamHoc { 
             get { return namHoc; }
             set { namHoc = value; }

        }



    }
}
