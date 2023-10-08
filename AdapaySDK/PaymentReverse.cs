using System.Collections.Generic;
using System.Text;

namespace AdapaySDK
{
    /// <summary>
    /// 撤销支付
    /// </summary>
    public class PaymentReverse
    {
        #region 创建撤销对象
        /// <summary>
        /// 创建撤销对象
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>创建的撤销对象</returns>
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.REVERSE_PAYMENT_V1, merchantKey);
        }
        /// <summary>
        /// 创建撤销对象
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>创建的撤销对象</returns>
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.REVERSE_PAYMENT_V1, null);
        }
        #endregion

        #region 查询已有的支付撤销对象列表
        /// <summary>
        /// 查询已有的支付撤销对象列表
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>已有的支付撤销对象列表</returns>
        public static Dictionary<string, object> queryList(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.REVERSE_PAYMENT_LIST_V1, merchantKey);
        }
        /// <summary>
        /// 查询已有的支付撤销对象列表
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>已有的支付撤销对象列表</returns>
        public static Dictionary<string, object> queryList(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.REVERSE_PAYMENT_LIST_V1, null);
        }
        #endregion

        #region 查询已有的支付撤销对象
        /// <summary>
        /// 查询已有的支付撤销对象
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>已有的支付撤销对象</returns>
        public static Dictionary<string, object> query(Dictionary<string, object> requestParams, string merchantKey)
        {
            string reverseId = StringUtils.tryGetNotNullValue(requestParams, "reverse_id");
            string uri = new StringBuilder(APIUrlEnum.QUERY_REVERSE_PAYMENT_V1).Append(reverseId).ToString();
            return AdapayRequest.getRequestAdapay(requestParams, uri, merchantKey);
        }
        /// <summary>
        /// 查询已有的支付撤销对象
        /// </summary>
        /// <param name="requestParams"></param>
        /// <returns>已有的支付撤销对象</returns>
        public static Dictionary<string, object> query(Dictionary<string, object> requestParams)
        {
            string reverseId = StringUtils.tryGetNotNullValue(requestParams, "reverse_id");
            string uri = new StringBuilder(APIUrlEnum.QUERY_REVERSE_PAYMENT_V1).Append(reverseId).ToString();
            return AdapayRequest.getRequestAdapay(requestParams, uri, null);
        } 
        #endregion
    }
}
