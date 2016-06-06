using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace FengNiao.GameToolsCommon
{
    public class MD5
    {
        public static string GetMD5String(string str)
        {
            System.Security.Cryptography.MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(System.Text.Encoding.Default.GetBytes(str));
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }
    }
}
