using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace AdapayCore
{
    /// <summary>
    /// [2022-01-10 v1.4.1：https://docs.adapay.tech/sdk/csharpsdkaccess.html]
    /// </summary>
    public class CoreUtils
    {
        public static bool debug = false;
        public static string sdk_version = "C#v1.4.1";
        public static string BASE_URL = "https://api.adapay.tech";
        public static string RSA_PUB_KEY = "MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCwN6xgd6Ad8v2hIIsQVnbt8a3JituR8o4Tc3B5WlcFR55bz4OMqrG/356Ur3cPbc2Fe8ArNd/0gZbC9q56Eb16JTkVNA/fye4SXznWxdyBPR7+guuJZHc/VW2fKH2lfZ2P3Tt0QkKZZoawYOGSMdIvO+WqK44updyax0ikK6JlNQIDAQAB";

        public static string GetMD5Hash(string str)
        {
            //就是比string往后一直加要好的优化容器
            StringBuilder sb = new StringBuilder();
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                //将输入字符串转换为字节数组并计算哈希。
                byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(str));

                int length = data.Length;
                for (int i = 0; i < length; i++)
                    sb.Append(data[i].ToString("X2"));

            }
            return sb.ToString();
        }

        public static byte[] File2Bytes(string FilePath)
        {
            if (!System.IO.File.Exists(FilePath))
            {
                return new byte[0];
            }

            FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            byte[] buff = new byte[fs.Length];

            fs.Read(buff, 0, Convert.ToInt32(fs.Length));
            fs.Close();

            return buff;
        }

        public static string getOrignalString(Dictionary<string, object> dict)
        {

            Dictionary<string, object> params_SortedByKey = dict.OrderBy(p => p.Key).ToDictionary(p => p.Key, o => o.Value);
            StringBuilder orinalStr = new StringBuilder("");

            foreach (KeyValuePair<string, object> item in params_SortedByKey)
            {

                orinalStr.Append(item.Key)
                    .Append("=")
                    .Append(item.Value)
                    .Append("&");

            }
            if (orinalStr.Equals(""))
            {
                return "";
            }
            else
            {
                orinalStr.Remove(orinalStr.Length - 1, 1);
            }
            return orinalStr.ToString();
        }
        public static void Log(string message)
        {
            if (debug)
            {
                Console.WriteLine(message);
            }
        }
    }
}
