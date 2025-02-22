using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LopHoc_DTO
    {
        private string maLop;
        private string tenLop;
        private int siSo;
        private string tenGVCN;
        private string maGVCN;

        public string MaLop { get => maLop; set => maLop = value; }

        public string TenLop { get => tenLop; set => tenLop = value; }

        public int SiSo { get => siSo; set => siSo = value; }

        public string TenGVCN { get => tenGVCN; set => tenGVCN = value; }

        public string MaGVCN { get => maGVCN; set => maGVCN = value; }
    }
}
