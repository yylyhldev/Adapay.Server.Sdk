namespace AdapayCore
{
    /// <summary>
    /// 商户配置
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
