using System.Collections.Generic;
using AdapayCore;

namespace AdapaySDK
{
    public class AdapayTools
    {
        #region 获取银联云闪付用户标识
        /// <summary>
        /// 获取银联云闪付用户标识
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>银联云闪付用户标识</returns>
        public static Dictionary<string, object> unionUserId(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.UNION_USER_ID_V1, merchantKey);
        }

        /// <summary>
        /// 获取银联云闪付用户标识
        /// </summary>
        /// <param name="requestParams"></param>
        /// <returns>银联云闪付用户标识</returns>
        public static Dictionary<string, object> unionUserId(Dictionary<string, object> requestParams)
        {

            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.UNION_USER_ID_V1, null);
        }
        #endregion

        #region download  bill file 
        /// <summary>
        /// download  bill file 
        /// </summary>
        /// <param name="requestParams"></param>
        /// <returns>bill file</returns>
        public static Dictionary<string, object> downloadBill(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.BILL_DOWNLOAD_V1, null);
        }

        /// <summary>
        /// download  bill file 
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>bill file</returns>
        public static Dictionary<string, object> downloadBill(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.BILL_DOWNLOAD_V1, merchantKey);
        }
        #endregion

        #region 校验返回签名
        /// <summary>
        /// 校验返回签名
        /// </summary>
        /// <param name="signature">签名</param>
        /// <param name="content">报文内容</param>
        /// <returns>校验结果</returns>
        public static bool verifySign(string signature, string content)
        {
            return NetUtils.verfySign(signature, content);
        } 
        #endregion
    }
}
