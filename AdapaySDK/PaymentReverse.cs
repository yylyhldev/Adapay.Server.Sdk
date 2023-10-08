using System;
using System.Collections.Generic;
using System.Text;

namespace AdapaySDK
{
    public class PaymentReverse
    {



        /**
         * 创建撤销对象
         *
         * @param requestParams      创建支付撤销对象参数
         * @param merchantKey merchantKey
         * @return 查询的支付对象
         */
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.REVERSE_PAYMENT_V1, merchantKey);
        }

        /**
         * 创建撤销对象
         *
         * @param requestParams      创建支付撤销对象参数
         * @return 查询的支付对象
         */
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.REVERSE_PAYMENT_V1, null);
        }


        /**
         * 查询已有的支付撤销对象列表
         *
         * @param requestParams      要查询的支付撤销对象参数
         * @param merchantKey merchantKey
         * @return 查询的支付撤销对象
         */
        public static Dictionary<string, object> queryList(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.REVERSE_PAYMENT_LIST_V1, merchantKey);
        }

        /**
         * 查询已有的支付撤销对象列表
         *
         * @param requestParams      要查询的支付撤销对象参数
         * @return 查询的支付撤销对象
         */
        public static Dictionary<string, object> queryList(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.REVERSE_PAYMENT_LIST_V1, null);
        }


        /**
         * 查询已有的支付撤销对象
         *
         * @param requestParams      要查询的支付撤销对象参数
         * @param merchantKey merchantKey
         * @return 查询的支付撤销对象
         */
        public static Dictionary<string, object> query(Dictionary<string, object> requestParams, string merchantKey)
        {
            string reverseId = StringUtils.tryGetNotNullValue(requestParams, "reverse_id");

            string uri = new StringBuilder(APIUrlEnum.QUERY_REVERSE_PAYMENT_V1).Append(reverseId).ToString();
            return AdapayRequest.getRequestAdapay(requestParams, uri, merchantKey);
        }

        /**
         * 查询已有的支付撤销对象
         *
         * @param requestParams      要查询的支付撤销对象参数
         * @param merchantKey merchantKey
         * @return 查询的支付撤销对象
         */
        public static Dictionary<string, object> query(Dictionary<string, object> requestParams)
        {
            string reverseId = StringUtils.tryGetNotNullValue(requestParams, "reverse_id");
            string uri = new StringBuilder(APIUrlEnum.QUERY_REVERSE_PAYMENT_V1).Append(reverseId).ToString();
            return AdapayRequest.getRequestAdapay(requestParams, uri, null);
        }


    }
}
