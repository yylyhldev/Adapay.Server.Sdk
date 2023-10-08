using System;
using System.Collections.Generic;
using System.Text;

namespace AdapaySDK
{
    public class SettleAccount
    {

        /**
         * 创建结算账户对象
         *
         * @param params 创建结算账户对象的请求参数，参见 AdaPay api
         * @param merchantKey merchantKey
         * @return 创建结算账户对象
         * @ 异常
         */
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams, string merchantKey)
        {

            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.SETTLE_ACCOUNT_V1, merchantKey);
        }

        /**
         * 查询结算账户对象
         *
         * @param params 查询结算账户对象的请求参数，参见 AdaPay api
         * @param merchantKey merchantKey
         * @return 查询的结算账户对象
         * @ 异常
         */
        public static Dictionary<string, object> query(Dictionary<string, object> requestParams, string merchantKey)
        {
            string settleAccountId = StringUtils.tryGetNotNullValue(requestParams, "settle_account_id");

            string uri = new StringBuilder(APIUrlEnum.QUERY_SETTLE_ACCOUNT_V1).Append(settleAccountId).ToString();

            return AdapayRequest.getRequestAdapay(requestParams, uri, merchantKey);
        }

        /**
         * 删除结算账户对象
         *
         * @param params 删除结算账户对象的请求参数，参见 AdaPay api
         * @param merchantKey merchantKey
         * @return 删除的结算账户对象
         * @ 异常
         */
        public static Dictionary<string, object> delete(Dictionary<string, object> requestParams, string merchantKey)
        {

            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.DELETE_SETTLE_ACCOUNT_V1, merchantKey);
        }

        /**
         * 查询结算明细列表
         *
         * @param params 查询结算明细列表的请求参数，参见 AdaPay api
         * @param merchantKey merchantKey
         * @return 查询的结算账户对象
         * @ 异常
         */
        public static Dictionary<string, object> details(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.QUERY_SETTLE_DETAILS_V1, merchantKey);
        }

        /**
         * 创建结算账户对象
         *
         * @param params 创建结算账户对象的请求参数，参见 AdaPay api
         * @return 创建结算账户对象
         * @ 异常
         */
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.SETTLE_ACCOUNT_V1, null);
        }

        /**
         * 查询结算账户对象
         *
         * @param params 查询结算账户对象的请求参数，参见 AdaPay api
         * @return 查询的结算账户对象
         * @ 异常
         */
        public static Dictionary<string, object> query(Dictionary<string, object> requestParams)
        {
            string settleAccountId = StringUtils.tryGetNotNullValue(requestParams, "settle_account_id");

            string uri = new StringBuilder(APIUrlEnum.QUERY_SETTLE_ACCOUNT_V1).Append(settleAccountId).ToString();

            return AdapayRequest.getRequestAdapay(requestParams, uri, null);
        }

        /**
         * 删除结算账户对象
         *
         * @param params 删除结算账户对象的请求参数，参见 AdaPay api
         * @return 删除的结算账户对象
         * @ 异常
         */
        public static Dictionary<string, object> delete(Dictionary<string, object> requestParams)
        {

            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.DELETE_SETTLE_ACCOUNT_V1, null);
        }

        /**
         * 查询结算明细列表
         *
         * @param params 查询结算明细列表的请求参数，参见 AdaPay api
         * @return 查询的结算账户对象
         * @ 异常
         */
        public static Dictionary<string, object> details(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.QUERY_SETTLE_DETAILS_V1, null);
        }

        /**
         * 修改结算账户配置
         *
         * @param params 修改结算账户配置的请求参数，参见 AdaPay api
         * @return 修改的结算账户对象
         * @ 异常
         */
        public static Dictionary<string, object> update(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.MODIFY_SETTLE_ACCOUNT_V1, null);
        }

        /**
         * 修改结算账户配置
         *
         * @param params 修改结算账户配置的请求参数，参见 AdaPay api
         * @return 修改的结算账户对象
         * @ 异常
         */
        public static Dictionary<string, object> update(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.MODIFY_SETTLE_ACCOUNT_V1, merchantKey);
        }
    }
}
