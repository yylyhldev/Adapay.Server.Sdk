using System.Collections.Generic;

namespace AdapaySDK
{
    /// <summary>
    /// 账户对象
    /// </summary>
    public class Account
    {
        /// <summary>
        /// 账户对象支付
        /// </summary>
        /// <param name="requestParams">请求参数</param>
        /// <returns>查询的支付撤销对象</returns>
        public static Dictionary<string, object> payment(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.requestAdapayPageServer(requestParams, APIUrlEnum.CREATE_ACCOUNT_PAYMENT, null);
        }

        /// <summary>
        /// 账户对象支付
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>查询的支付撤销对象</returns>
        public static Dictionary<string, object> payment(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.requestAdapayPageServer(requestParams, APIUrlEnum.CREATE_ACCOUNT_PAYMENT, merchantKey);
        }
    }
}
