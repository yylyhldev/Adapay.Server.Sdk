﻿using System.Collections.Generic;
using System.Text;

namespace AdapaySDK
{
    /// <summary>
    /// 支付对象
    /// </summary>
    public class Payment
    {
        #region 发起支付-跳转支付
        /// <summary>
        /// 发起支付-跳转支付
        /// </summary>
        /// <param name="requestParams">创建支付的请求参数</param>
        /// <param name="merchantKey"></param>
        /// <returns>创建的支付对象</returns>
        public static Dictionary<string, object> createJump(Dictionary<string, object> requestParams, string merchantKey)
        {
            requestParams.TryGetValue("currency", out var currency);
            if (currency == null)
            {
                requestParams.Add("currency", "cny");
            }
            requestParams.TryGetValue("adapay_func_code", out var adapay_func_code);
            string code = adapay_func_code + string.Empty;
            var url = code == "wxpay.createOrder" ? APIUrlEnum.WXPAY_CREATEORDER_JUMPPAYMENT_V1 : code == "prePay.preOrder" ? APIUrlEnum.PREPAY_PREORDER_JUMPPAYMENT_V1 : APIUrlEnum.QRPREPAY_QRPREORDER_JUMPPAYMENT_V1;
            return AdapayRequest.requestAdapayPageServer(requestParams, url, merchantKey);
        }
        /// <summary>
        /// 发起支付
        /// </summary>
        /// <param name="requestParams">创建支付的请求参数，参见 AdaPay api</param>
        /// <returns>创建的支付对象</returns>
        public static Dictionary<string, object> createJump(Dictionary<string, object> requestParams)
        {
            object currency = null;
            requestParams.TryGetValue("currency", out currency);
            if (currency == null)
            {
                requestParams.Add("currency", "cny");
            }
            requestParams.TryGetValue("adapay_func_code", out var adapay_func_code);
            string code = adapay_func_code + string.Empty;
            var url = code == "wxpay.createOrder" ? APIUrlEnum.WXPAY_CREATEORDER_JUMPPAYMENT_V1 : code == "prePay.preOrder" ? APIUrlEnum.PREPAY_PREORDER_JUMPPAYMENT_V1 : APIUrlEnum.QRPREPAY_QRPREORDER_JUMPPAYMENT_V1;
            return AdapayRequest.requestAdapayPageServer(requestParams, url, null);
        }
        #endregion

        #region 发起支付
        /// <summary>
        /// 发起支付
        /// </summary>
        /// <param name="requestParams">创建支付的请求参数</param>
        /// <param name="merchantKey"></param>
        /// <returns>创建的支付对象</returns>
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams, string merchantKey)
        {
            object currency = null;
            requestParams.TryGetValue("currency", out currency);
            if (currency == null)
            {
                requestParams.Add("currency", "cny");
            }
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.PAYMENT_V1, merchantKey);
        }
        /// <summary>
        /// 发起支付
        /// </summary>
        /// <param name="requestParams">创建支付的请求参数，参见 AdaPay api</param>
        /// <returns>创建的支付对象</returns>
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams)
        {
            object currency = null;
            requestParams.TryGetValue("currency", out currency);
            if (currency == null)
            {
                requestParams.Add("currency", "cny");
            }
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.PAYMENT_V1, null);
        }
        #endregion

        #region 关闭支付
        /// <summary>
        /// 关闭支付
        /// </summary>
        /// <param name="requestParams">要关闭的支付id</param>
        /// <param name="merchantKey"></param>
        /// <returns>关闭的支付对象</returns>
        public static Dictionary<string, object> close(Dictionary<string, object> requestParams, string merchantKey)
        {
            string paymentId = StringUtils.tryGetNotNullValue(requestParams, "payment_id");
            string uri = new StringBuilder(APIUrlEnum.CLOSE_PAYMENT_V1).Append(paymentId).Append("/close").ToString();
            //requestParams.Remove("payment_id");
            return AdapayRequest.requestAdapay(requestParams, uri, merchantKey);
        }
        /// <summary>
        /// 关闭支付
        /// </summary>
        /// <param name="requestParams">要关闭的支付id</param>
        /// <returns>关闭的支付对象</returns>
        public static Dictionary<string, object> close(Dictionary<string, object> requestParams)
        {
            string paymentId = StringUtils.tryGetNotNullValue(requestParams, "payment_id");
            string uri = new StringBuilder(APIUrlEnum.CLOSE_PAYMENT_V1).Append(paymentId).Append("/close").ToString();
            //requestParams.Remove("payment_id");
            return AdapayRequest.requestAdapay(requestParams, uri, null);
        }
        #endregion

        #region 查询已有的支付信息
        /// <summary>
        /// 查询已有的支付信息
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>查询的支付对象</returns>
        public static Dictionary<string, object> query(Dictionary<string, object> requestParams, string merchantKey)
        {
            string paymentId = StringUtils.tryGetNotNullValue(requestParams, "payment_id");
            string uri = new StringBuilder(APIUrlEnum.QUERY_PAYMENT_V1).Append(paymentId).ToString();
            //requestParams.Remove("payment_id");
            return AdapayRequest.getRequestAdapay(requestParams, uri, merchantKey);
        }
        /// <summary>
        /// 查询已有的支付信息
        /// </summary>
        /// <param name="requestParams"></param>
        /// <returns>查询的支付对象</returns>
        public static Dictionary<string, object> query(Dictionary<string, object> requestParams)
        {
            string paymentId = StringUtils.tryGetNotNullValue(requestParams, "payment_id");
            string uri = new StringBuilder(APIUrlEnum.QUERY_PAYMENT_V1).Append(paymentId).ToString();
            //requestParams.Remove("payment_id");
            return AdapayRequest.getRequestAdapay(requestParams, uri, null);
        }
        #endregion

        #region 查询已有的支付信息列表
        /// <summary>
        /// 查询已有的支付信息列表
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>查询的支付对象列表</returns>
        public static Dictionary<string, object> queryList(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.LIST_PAYMENT_V1, merchantKey);
        }
        /// <summary>
        /// 查询已有的支付信息列表
        /// </summary>
        /// <param name="requestParams"></param>
        /// <returns>查询的支付对象列表</returns>
        public static Dictionary<string, object> queryList(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.LIST_PAYMENT_V1, null);
        } 
        #endregion
    }
}
