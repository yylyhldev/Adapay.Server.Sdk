using System;
using Newtonsoft.Json;
using System.Net;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace AdapayCore
{
    /// <summary>
    /// [2022-01-10 v1.4.1：https://docs.adapay.tech/sdk/csharpsdkaccess.html]
    /// </summary>
    public class NetUtils
    {
        public const string POST = "post";
        public const string GET = "get";

        public static Dictionary<string, object> requestAdapayWithURL(Dictionary<string, object> postParams, string filePath, string fileParam, string url, string method, string apiKey, string privateKey)
        {
            if (null == apiKey)
            {
                throw new Exception("apikey 不能为空");
            }

            if (null == privateKey)
            {
                throw new Exception("privateKey 不能为空");
            }

            string requireUrl = url;

            HttpWebRequest request = null;
            if (method.Equals(GET))
            {
                request = CreateGetRequest(postParams, requireUrl, apiKey, privateKey);
            }
            else if (null != filePath)
            {
                request = CreateUploadRequest(postParams, filePath, fileParam, requireUrl, apiKey, privateKey);
            }
            else
            {
                request = CreatePostRequest(postParams, requireUrl, apiKey, privateKey);
            }

            Dictionary<string, object> responseJson = null;
            string responseText = null;
            string responseSign = null;
            try
            {
                HttpWebResponse httpResponse = (HttpWebResponse)request.GetResponse();
                using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    responseText = streamReader.ReadToEnd();
                    Dictionary<string, object> response = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseText);
                    string data = (string)response["data"];
                    CoreUtils.Log("response data....." + data);
                    responseSign = (string)response["signature"];

                    if (!verfySign(responseSign, data))
                    {
                        throw new Exception("public key veryfy singnature failed");
                    }

                    responseJson = JsonConvert.DeserializeObject<Dictionary<string, Object>>(data);
                    CoreUtils.Log("response:" + responseText);

                }
            }
            catch (WebException e)
            {
                if (e.Response != null)
                {
                    using (var errorResponse = (HttpWebResponse)e.Response)
                    {
                        using (var reader = new StreamReader(errorResponse.GetResponseStream()))
                        {
                            responseText = reader.ReadToEnd();
                            Dictionary<string, object> response = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseText);
                            string data = (string)response["data"];
                            responseSign = (string)response["signature"];

                            if (!verfySign(responseSign, data))
                            {
                                throw new Exception("public key veryfy singnature failed");
                            }

                            responseJson = JsonConvert.DeserializeObject<Dictionary<string, object>>(data);
                            CoreUtils.Log("error response:" + responseText);
                        }
                    }
                }
            }

            return responseJson;
        }

        public static Dictionary<string, object> requestAdapay(Dictionary<string, object> postParams, string filePath, string fileParam, string uri, string method, string apiKey, string privateKey)
        {
            return requestAdapayWithURL(postParams, filePath, fileParam, CoreUtils.BASE_URL + uri, method, apiKey, privateKey);

        }

        public static Dictionary<string, object> requestAdapay(Dictionary<string, object> postParams, string uri, string method, string apiKey, string privateKey)
        {
            return requestAdapayWithURL(postParams, null, null, CoreUtils.BASE_URL + uri, method, apiKey, privateKey);

        }

        //设置get请求参数
        // get post 以及post 上传文件的接口，url地址以及签名方式有差别
        private static HttpWebRequest CreateGetRequest(Dictionary<string, object> postParams, string requireUrl, string apiKey, string privateKey)
        {
            string json_params = CoreUtils.getOrignalString(postParams);
            string json_string = requireUrl + json_params;

            //参数中会有中文,签名前需url encode
            json_string = Uri.UnescapeDataString(json_string);

            string signStr = signature(privateKey, json_string);

            requireUrl = requireUrl + "?" + json_params;
            CoreUtils.Log("requireUrl:" + requireUrl);

            HttpWebRequest request = _ = (HttpWebRequest)WebRequest.Create(requireUrl);

            WebHeaderCollection header = request.Headers;

            header.Set("Signature", signStr);
            header.Set("Authorization", apiKey);
            header.Set("SDK_version", CoreUtils.sdk_version);
            CoreUtils.Log("apikey..." + apiKey);
            CoreUtils.Log("SDK_version..." + CoreUtils.sdk_version);


            request.Method = "get";
            request.ContentType = "text/html;charset=UTF-8";

            return request;
        }

        //设置不带文件的post请求参数
        private static HttpWebRequest CreatePostRequest(Dictionary<string, object> postParams, string requireUrl, string apiKey, string privateKey)
        {
            string json_params = JsonConvert.SerializeObject(postParams, Formatting.None);

            string json_string = requireUrl + json_params;
            //参数中会有中文,签名前需url encode
            json_string = Uri.UnescapeDataString(json_string);

            string signStr = signature(privateKey, json_string);

            HttpWebRequest request = _ = (HttpWebRequest)WebRequest.Create(requireUrl);

            WebHeaderCollection header = request.Headers;

            header.Set("Signature", signStr);
            header.Set("Authorization", apiKey);
            header.Set("SDK_version", CoreUtils.sdk_version);
            CoreUtils.Log("apikey..." + apiKey);
            CoreUtils.Log("SDK_version..." + CoreUtils.sdk_version);

            request.Method = "post";
            request.ContentType = "application/json";
            byte[] byteData = Encoding.UTF8.GetBytes(json_params);
            int length = byteData.Length;
            request.ContentLength = length;
            Stream writer = request.GetRequestStream();
            writer.Write(byteData, 0, length);
            writer.Close();

            return request;
        }

        //设置文件上传request
        private static HttpWebRequest CreateUploadRequest(Dictionary<string, object> postParams, string filePath, string fileParam, string requireUrl, string apiKey, string privateKey)
        {

            HttpWebRequest request = request = (HttpWebRequest)WebRequest.Create(requireUrl);

            string json_params = CoreUtils.getOrignalString(postParams);
            string json_string = requireUrl + json_params;
            //参数中会有中文,签名前需url encode
            json_string = Uri.UnescapeDataString(json_string);
            string signStr = signature(privateKey, json_string);

            WebHeaderCollection header = request.Headers;
            header.Set("Signature", signStr);
            header.Set("Authorization", apiKey);
            header.Set("SDK_version", CoreUtils.sdk_version);
            CoreUtils.Log("apikey..." + apiKey);
            CoreUtils.Log("SDK_version..." + CoreUtils.sdk_version);



            request.Method = "post";
            //文件信息
            byte[] UpdateFile = CoreUtils.File2Bytes(filePath);//转换为二进制
            if (UpdateFile.Length == 0)
            {
                throw new Exception("file content cannot be null");
            }

            string Boundary = "--WebKitFormBoundary39B5a5e2FWoGbphs";
            //构造POST请求体
            StringBuilder PostContent = new StringBuilder("");
            //组成普通参数信息
            foreach (KeyValuePair<string, object> item in postParams)
            {
                PostContent.Append("--" + Boundary + "\r\n")
                        .Append("Content-Disposition: form-data; name=\"" + item.Key + "\"" + "\r\n\r\n" + (string)item.Value + "\r\n");
            }

            byte[] PostContentByte = Encoding.UTF8.GetBytes(PostContent.ToString());

            //文件信息

            StringBuilder FileContent = new StringBuilder();
            FileContent.Append("--" + Boundary + "\r\n")
                    .Append("Content-Disposition:form-data; name=\"" + fileParam + "\";filename=\"" + Path.GetFileName(filePath) + "\"" + "\r\n\r\n");

            byte[] FileContentByte = Encoding.UTF8.GetBytes(FileContent.ToString());

            request.ContentType = "multipart/form-data;boundary=" + Boundary;

            byte[] ContentEnd = Encoding.UTF8.GetBytes("\r\n--" + Boundary + "--\r\n");//请求体末尾，后面会用到

            //定义请求流
            Stream myRequestStream = request.GetRequestStream();
            myRequestStream.Write(PostContentByte, 0, PostContentByte.Length);//写入参数
            myRequestStream.Write(FileContentByte, 0, FileContentByte.Length);//写入文件信息
            myRequestStream.Write(UpdateFile, 0, UpdateFile.Length);//文件写入请求流中
            myRequestStream.Write(ContentEnd, 0, ContentEnd.Length);//写入结尾   

            myRequestStream.Close();

            return request;

        }

        private static string bytesToHexStr(byte[] byteArray)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in byteArray)
            {
                sb.Append(b.ToString("X2"));
            }
            return sb.ToString();
        }

        private static string signature(string signaturePrivateKey, string signatureData)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            var privateJavaKey = signaturePrivateKey;
            var privateCSharpKey = RSAPrivateKeyJava2DotNet(privateJavaKey);
            rsa.FromXmlString(privateCSharpKey);

            byte[] signatureBytes = rsa.SignData(Encoding.UTF8.GetBytes(signatureData), "SHA1");
            return Convert.ToBase64String(signatureBytes);

        }

        private static string RSAPrivateKeyJava2DotNet(string privateKey)
        {
            byte[] keyInfoByte = Convert.FromBase64String(privateKey);
            RsaPrivateCrtKeyParameters privateKeyParam = (RsaPrivateCrtKeyParameters)PrivateKeyFactory.CreateKey(keyInfoByte);
            return string.Format("<RSAKeyValue><Modulus>{0}</Modulus><Exponent>{1}</Exponent><P>{2}</P><Q>{3}</Q><DP>{4}</DP><DQ>{5}</DQ><InverseQ>{6}</InverseQ><D>{7}</D></RSAKeyValue>",
            Convert.ToBase64String(privateKeyParam.Modulus.ToByteArrayUnsigned()),
            Convert.ToBase64String(privateKeyParam.PublicExponent.ToByteArrayUnsigned()),
            Convert.ToBase64String(privateKeyParam.P.ToByteArrayUnsigned()),
            Convert.ToBase64String(privateKeyParam.Q.ToByteArrayUnsigned()),
            Convert.ToBase64String(privateKeyParam.DP.ToByteArrayUnsigned()),
            Convert.ToBase64String(privateKeyParam.DQ.ToByteArrayUnsigned()),
            Convert.ToBase64String(privateKeyParam.QInv.ToByteArrayUnsigned()),
            Convert.ToBase64String(privateKeyParam.Exponent.ToByteArrayUnsigned()));
        }

        public static bool verfySign(string signature, string content, string hashAlgorithm = "SHA1", string encoding = "UTF-8")
        {

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            //导入公钥，准备验证签名
            rsa.FromPublicKeyJavaString(CoreUtils.RSA_PUB_KEY);
            //返回数据验证结果
            byte[] Data = Encoding.GetEncoding(encoding).GetBytes(content);
            byte[] rgbSignature = Convert.FromBase64String(signature);

            return rsa.VerifyData(Data, hashAlgorithm, rgbSignature);

        }

        private string decrypt(string key, string str)
        {
            if (string.IsNullOrEmpty(str)) return null;
            byte[] toEncryptArray = HexStringToByteArray(str);

            RijndaelManaged rm = new RijndaelManaged
            {
                Key = HexStringToByteArray(key),
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };

            ICryptoTransform cTransform = rm.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Encoding.UTF8.GetString(resultArray);
        }

        private static byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
            {
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            }
            return buffer;
        }


    }

    public static class RSAExtensions
    {
        public static void FromPublicKeyJavaString(this RSA rsa, string publicJavaKey)
        {
            RsaKeyParameters publicKeyParam = (RsaKeyParameters)PublicKeyFactory.CreateKey(Convert.FromBase64String(publicJavaKey));
            string xmlpublicKey = string.Format("<RSAKeyValue><Modulus>{0}</Modulus><Exponent>{1}</Exponent></RSAKeyValue>",
              Convert.ToBase64String(publicKeyParam.Modulus.ToByteArrayUnsigned()),
              Convert.ToBase64String(publicKeyParam.Exponent.ToByteArrayUnsigned()));

            rsa.FromXmlString(xmlpublicKey);
        }
    }
}

