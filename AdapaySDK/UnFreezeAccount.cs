using System.Collections.Generic;

namespace AdapaySDK
{
    public class UnFreezeAccount
    {
        /**
         * 创建账户解冻对象
         *
         * @param requestParams  请求参数
         * @param merchantKey merchantKey
         * @return 创建账户解冻对象
         */
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.UN_FREEZE_ACCOUNT_CREATE, null);
        }

        /**
         * 创建账户解冻对象
         *
         * @param requestParams  请求参数
         * @param merchantKey merchantKey
         * @return 创建账户解冻对象
         */
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.UN_FREEZE_ACCOUNT_CREATE, merchantKey);
        }

        /**
         * 查询账户解冻对象列表
         *
         * @param requestParams  请求参数
         * @param merchantKey merchantKey
         * @return 查询账户解冻对象列表
         */
        public static Dictionary<string, object> queryList(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.UN_FREEZE_ACCOUNT_LIST, null);
        }

        /**
         * 查询账户解冻对象列表
         *
         * @param requestParams  请求参数
         * @param merchantKey merchantKey
         * @return 查询账户解冻对象列表
         */
        public static Dictionary<string, object> queryList(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.UN_FREEZE_ACCOUNT_LIST, APIUrlEnum.UN_FREEZE_ACCOUNT_CREATE);
        }

    }
}
