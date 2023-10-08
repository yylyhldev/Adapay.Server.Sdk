using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapaySDK
{
    /**
     * 账户对象
     */
    public class Account
    {
        /**
         * 账户对象支付
         *
         * @param requestParams  请求参数
         * @param merchantKey merchantKey
         * @return 查询的支付撤销对象
         */
        public static Dictionary<string, Object> payment(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.requestAdapayPageServer(requestParams, APIUrlEnum.CREATE_ACCOUNT_PAYMENT, null);
        }

        /**
         *  
         * @param requestParams 请求参数
         * @param merchantKey merchantKey
         */
        public static Dictionary<string, Object> payment(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.requestAdapayPageServer(requestParams, APIUrlEnum.CREATE_ACCOUNT_PAYMENT, merchantKey);
        }
    }
}
