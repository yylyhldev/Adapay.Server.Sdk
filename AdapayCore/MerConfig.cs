using System;

namespace AdapayCore
{
    /// <summary>
    /// 商户配置 [2022-01-10 v1.4.1：https://docs.adapay.tech/sdk/csharpsdkaccess.html]
    /// </summary>
    public class MerConfig
    {
        /// <summary>
        /// 商户配置。
        /// </summary>
        public MerConfig() { }

        /// <summary>
        /// 商户rsa 私钥
        /// </summary>
        public string privateKey;

        /// <summary>
        /// apiKey
        /// </summary>
        public string apiKey;

        /// <summary>
        /// apiMockKey
        /// </summary>
        public string apiMockKey;
    }
}
