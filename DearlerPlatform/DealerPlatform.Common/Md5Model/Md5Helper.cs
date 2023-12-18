using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DealerPlatform.Common.Md5Model
{
    public static class Md5Helper
    {
        public static string ToMd5(this string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(str + "@LvMaxZz1"));
            var md5Str = BitConverter.ToString(bytes).Replace("-", "");
            return md5Str;
        }
    }
}
