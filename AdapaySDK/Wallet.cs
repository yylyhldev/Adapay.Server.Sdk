using System.Collections.Generic;

namespace AdapaySDK
{
    public class Wallet
    {
        /**
         * 获取登录信息
         *
         * @param requestParams 登录请求参数，参见 AdaPay api
         * @param merchantKey merchantKey
         * @return 跳转页面信息
         */
        public static Dictionary<string, object> login(Dictionary<string, object> requestParams, string merchantKey)
        {

            return AdapayRequest.requestAdapayPageServer(requestParams, APIUrlEnum.WALLET_LOGIN, merchantKey);
        }

        /**
        * 获取登录信息
        *
        * @param requestParams 登录请求参数，参见 AdaPay api
        * @param merchantKey merchantKey
        * @return 跳转页面信息
        */
        public static Dictionary<string, object> login(Dictionary<string, object> requestParams)
        {

            return AdapayRequest.requestAdapayPageServer(requestParams, APIUrlEnum.WALLET_LOGIN, null);
        }
        /**
         * 查询帐户余额
         *
         * @param params 查询帐户余额的请求参数，参见 AdaPay api
         * @return 帐户余额
         */
        public static Dictionary<string, object> balance(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.QUERY_BALANCE, null);
        }

        /**
         * 查询帐户余额
         *
         * @param params 查询帐户余额的请求参数，参见 AdaPay api
         * @return 帐户余额
         */
        public static Dictionary<string, object> balance(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.QUERY_BALANCE, merchantKey);
        }

        
    }
}
