using System;
using System.Collections.Generic;

namespace AdapaySDK
{
    public class Drawcash
    {

        /**
         * 创建取现对象
         *
         * @param params 创建取现对象的请求参数，参见 AdaPay api
         * @return 取现对象
         */
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.DRAW_CASH, null);
        }

        /**
         * 创建取现对象
         *
         * @param params 创建取现对象的请求参数，参见 AdaPay api
         * @return 取现对象
         */
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.DRAW_CASH, merchantKey);
        }

        /**
         * 查询取现状态
         *
         * @param params 查询取现状态，参见 AdaPay api
         * @return 取现状态
         */
        public static Dictionary<string, object> query(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.QUERY_CASHS_STAT_V1, null);
        }

        /**
         * 查询取现状态
         *
         * @param params 查询取现状态，参见 AdaPay api
         * @return 取现状态
         */
        public static Dictionary<string, object> query(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.QUERY_CASHS_STAT_V1, merchantKey);
        }
    }
}
