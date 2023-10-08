using System.Collections.Generic;
using System.Text;

namespace AdapaySDK
{
    /// <summary>
    /// 退款
    /// </summary>
    public class Refund
    {
        #region 创建退款
        /// <summary>
        /// 创建退款
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>退款结果</returns>
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams, string merchantKey)
        {
            string id = StringUtils.tryGetNotNullValue(requestParams, "id");
            string uri = new StringBuilder(APIUrlEnum.REFUND_V1).Append(id).Append("/refunds").ToString();
            return AdapayRequest.requestAdapay(requestParams, uri, merchantKey);
        }
        /// <summary>
        /// 创建退款
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>退款结果</returns>
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams)
        {
            string id = StringUtils.tryGetNotNullValue(requestParams, "id");
            string uri = new StringBuilder(APIUrlEnum.REFUND_V1).Append(id).Append("/refunds").ToString();
            return AdapayRequest.requestAdapay(requestParams, uri, null);
        }
        #endregion

        #region 查询退款
        /// <summary>
        /// 查询退款
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>退款结果</returns>
        public static Dictionary<string, object> query(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.QUERY_REFUND_V1, merchantKey);
        }
        /// <summary>
        /// 查询退款
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>退款结果</returns>
        public static Dictionary<string, object> query(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.QUERY_REFUND_V1, null);
        } 
        #endregion
    }
}
