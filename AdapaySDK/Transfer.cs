using System;
using System.Collections.Generic;

namespace AdapaySDK
{
    public class Transfer
    {
        /**
         * 创建转账对象
         *
         * @param requestParams  请求参数
         * @param merchantKey merchantKey
         * @return 创建转账对象
         */
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.CREATE_TRANSFER, null);
        }
        /**
         * 创建转账对象
         *
         * @param requestParams  请求参数
         * @param merchantKey merchantKey
         * @return 创建转账对象
         */
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.CREATE_TRANSFER,merchantKey);
        }
        /**
         * 查询账户转账对象列表
         *
         * @param requestParams  请求参数
         * @param merchantKey merchantKey
         * @return 账户转账对象列表
         */
        public static Dictionary<string, object> queryList(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.TRANSFER_LIST, null);
        }
        /**
         * 查询账户转账对象列表
         *
         * @param requestParams  请求参数
         * @param merchantKey merchantKey
         * @return 账户转账对象列表
         */
        public static Dictionary<string, object> queryList(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.TRANSFER_LIST, merchantKey);
        }
    }
}
