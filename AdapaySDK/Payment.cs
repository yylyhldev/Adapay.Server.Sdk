using System;
using System.Collections.Generic;
using System.Text;

namespace AdapaySDK
{

    public class Payment
    {
        /**
        * 创建一个支付交易
        *
        * @param requestParams      创建支付的请求参数，参见 AdaPay api
        * @param merchantKey merchantKey
        * @return 创建的支付对象
        */
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams, string merchantKey)
        {
            object currency = null;
            requestParams.TryGetValue("currency", out currency);

            if (currency == null) {
                requestParams.Add("currency", "cny");
            }

            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.PAYMENT_V1, merchantKey);
        }

        /**
         * create Payment
         */
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


        /**
         * 关闭一个支付
         *
         * @param requestParams   要关闭的支付id
         * @param merchantKey merchantKey
         * @return 关闭的支付对象
         */
        public static Dictionary<string, object> close(Dictionary<string, object> requestParams, string merchantKey)
        {
            string paymentId = StringUtils.tryGetNotNullValue(requestParams, "payment_id");
            
            string uri = new StringBuilder(APIUrlEnum.CLOSE_PAYMENT_V1).Append(paymentId).Append("/close").ToString();

            //requestParams.Remove("payment_id");
            return AdapayRequest.requestAdapay(requestParams, uri, merchantKey);
        }

        /**
         * 关闭一个支付
         *
         * @param requestParams          要关闭的支付id
         * @param merchantKey merchantKey
         * @return 关闭的支付对象
         */
        public static Dictionary<string, object> close(Dictionary<string, object> requestParams)
        {
            string paymentId = StringUtils.tryGetNotNullValue(requestParams, "payment_id");

            string uri = new StringBuilder(APIUrlEnum.CLOSE_PAYMENT_V1).Append(paymentId).Append("/close").ToString();

            //requestParams.Remove("payment_id");
            return AdapayRequest.requestAdapay(requestParams, uri, null);
        }


        /**
         * 查询已有的支付信息
         * @param requestParams          要查询的支付参数
         * @param merchantKey merchantKey
         * @return 查询的支付对象
         */
        public static Dictionary<string, object> query(Dictionary<string, object> requestParams, string merchantKey)
        {
            string paymentId = StringUtils.tryGetNotNullValue(requestParams, "payment_id");

            string uri = new StringBuilder(APIUrlEnum.QUERY_PAYMENT_V1).Append(paymentId).ToString();

            //requestParams.Remove("payment_id");

            return AdapayRequest.getRequestAdapay(requestParams, uri, merchantKey);
        }

        /**
         * 查询已有的支付信息
         *
         * @param requestParams          要查询的支付id
         * @return 查询的支付对象
         */
        public static Dictionary<string, object> query(Dictionary<string, object> requestParams)
        {
            string paymentId = StringUtils.tryGetNotNullValue(requestParams, "payment_id");

            string uri = new StringBuilder(APIUrlEnum.QUERY_PAYMENT_V1).Append(paymentId).ToString();

            //requestParams.Remove("payment_id");

            return AdapayRequest.getRequestAdapay(requestParams, uri, null);
        }


        /**
         * 查询已有的支付信息列表
         * @param requestParams
         * @param merchantKey merchantKey
         * @return 查询的支付对象列表
         */
        public static Dictionary<string, object> queryList(Dictionary<string, object> requestParams, string merchantKey)
        {

            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.LIST_PAYMENT_V1, merchantKey);
        }

        /**
         * 查询已有的支付信息列表
         *
         * @param requestParams 
         * @return 查询的支付对象列表
         */
        public static Dictionary<string, object> queryList(Dictionary<string, object> requestParams)
        {

            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.LIST_PAYMENT_V1, null);
        }


        

    }
}
