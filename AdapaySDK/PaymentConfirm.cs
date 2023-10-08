using System.Collections.Generic;
using System.Text;

namespace AdapaySDK
{
    /// <summary>
    /// 支付确认对象
    /// </summary>
    public class PaymentConfirm
    {
        #region 创建支付确认对象
        /// <summary>
        /// 创建支付确认对象
        /// </summary>
        /// <param name="requestParams">创建支付确认对象参数</param>
        /// <param name="merchantKey"></param>
        /// <returns>创建的支付确认对象</returns>
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.CONFIRM_PAYMENT_V1, merchantKey);
        }
        /// <summary>
        /// 创建支付确认对象
        /// </summary>
        /// <param name="requestParams">创建支付确认对象参数</param>
        /// <returns>创建的支付确认对象</returns>
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.CONFIRM_PAYMENT_V1, null);
        }
        #endregion

        #region 查询已有的支付确认对象列表
        /// <summary>
        /// 查询已有的支付确认对象列表
        /// </summary>
        /// <param name="requestParams">要查询的支付撤销对象参数</param>
        /// <param name="merchantKey"></param>
        /// <returns>查询的支付撤销对象</returns>
        public static Dictionary<string, object> queryList(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.CONFIRM_PAYMENT_LIST_V1, merchantKey);
        }
        /// <summary>
        /// 查询已有的支付确认对象列表
        /// </summary>
        /// <param name="requestParams">要查询的支付撤销对象参数</param>
        /// <returns>查询的支付撤销对象</returns>
        public static Dictionary<string, object> queryList(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.CONFIRM_PAYMENT_LIST_V1, null);
        }
        #endregion

        #region 查询已有的支付确认对象
        /// <summary>
        /// 查询已有的支付确认对象
        /// </summary>
        /// <param name="requestParams">要查询的支付确认对象参数</param>
        /// <param name="merchantKey"></param>
        /// <returns>查询的支付撤销对象</returns>
        public static Dictionary<string, object> query(Dictionary<string, object> requestParams, string merchantKey)
        {
            string paymentConfirmId = StringUtils.tryGetNotNullValue(requestParams, "payment_confirm_id");
            string uri = new StringBuilder(APIUrlEnum.QUERY_CONFIRM_PAYMENT_V1).Append(paymentConfirmId).ToString();
            return AdapayRequest.getRequestAdapay(requestParams, uri, merchantKey);
        }
        /// <summary>
        /// 查询已有的支付确认对象
        /// </summary>
        /// <param name="requestParams">要查询的支付确认对象参数</param>
        /// <param name="merchantKey"></param>
        /// <returns>查询的支付撤销对象</returns>
        public static Dictionary<string, object> query(Dictionary<string, object> requestParams)
        {
            string paymentConfirmId = StringUtils.tryGetNotNullValue(requestParams, "payment_confirm_id");
            string uri = new StringBuilder(APIUrlEnum.QUERY_CONFIRM_PAYMENT_V1).Append(paymentConfirmId).ToString();
            return AdapayRequest.getRequestAdapay(requestParams, uri, null);
        } 
        #endregion
    }
}
