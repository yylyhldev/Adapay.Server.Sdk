using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace AdapayCore
{
    public class CoreUtils
    {
        public static bool debug { get; set; } = false;
        /// <summary>
        /// sdk版本
        /// </summary>
        public static string sdk_version { get; set; } = "C#v1.2.0";
        /// <summary>
        /// 接口域名
        /// </summary>
        public static string BASE_URL { get; set; } = "https://api.adapay.tech";
        /// <summary>
        /// 商户公钥
        /// </summary>
        public static string RSA_PUB_KEY { get; set; } = "MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCwN6xgd6Ad8v2hIIsQVnbt8a3JituR8o4Tc3B5WlcFR55bz4OMqrG/356Ur3cPbc2Fe8ArNd/0gZbC9q56Eb16JTkVNA/fye4SXznWxdyBPR7+guuJZHc/VW2fKH2lfZ2P3Tt0QkKZZoawYOGSMdIvO+WqK44updyax0ikK6JlNQIDAQAB";

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
        /// <summary>
        /// 字典转key=value
        /// </summary>
        /// <param name="dict"></param>
        /// <returns></returns>
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
            if (orinalStr.Equals("")) return "";
            orinalStr.Remove(orinalStr.Length - 1, 1);
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
