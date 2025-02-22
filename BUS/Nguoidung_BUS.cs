using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Nguoidung_BUS
    {
        public static Nguoidung_DTO LayNguoiDung(string ten, string matkhau)
        {
            MD5 md5Hash = MD5.Create();
            string matkhauMH = Nguoidung_BUS.GetMd5Hash(md5Hash, matkhau);
            return Nguoidung_DAO.Laynguoidung(ten, matkhauMH);
        }



        // Hàm mã hóa         
        // Tham khảo tại https://msdn.microsoft.com/enus/library/system.security.cryptography.md5.aspx
        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();

        }
    }
}
