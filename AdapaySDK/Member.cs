using System;
using System.Collections.Generic;
using System.Text;

namespace AdapaySDK
{
    public class Member
    {
        /**
         * 创建用户对象
         *
         * @param requestParams 创建用户对象的请求参数，参见 AdaPay api
         * @param merchantKey merchantKey
         * @return 创建用户对象
         * @ 异常
         */
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams, string merchantKey)
        {

            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.MEMBER_V1, merchantKey);
        }

        /**
         * 查询用户对象
         *
         * @param requestParams 查询用户对象的请求参数，参见 AdaPay api
         * @param merchantKey merchantKey
         * @return 查询的用户对象
         * @ 异常
         */
        public static Dictionary<string, object> query(Dictionary<string, object> requestParams, string merchantKey)
        {

            string memberId = StringUtils.tryGetNotNullValue(requestParams,"member_id");
            string uri = new StringBuilder(APIUrlEnum.QUERY_MEMBER_V1).Append(memberId).ToString();
            return AdapayRequest.getRequestAdapay(requestParams, uri, merchantKey);
        }

        /**
         * 查询用户列表
         *
         * @param requestParams 查询用户列表的请求参数，参见 AdaPay api
         * @param merchantKey merchantKey
         * @return 查询的用户列表
         * @ 异常
         */
        public static Dictionary<string, object> queryList(Dictionary<string, object> requestParams, string merchantKey)
        {

            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.QUERY_MEMBER_LIST_V1, merchantKey);
        }

        /**
         * 更新用户对象
         *
         * @param requestParams 更新用户对象的请求参数，参见 AdaPay api
         * @param merchantKey merchantKey
         * @return 更新后的用户对象
         * @ 异常
         */
        public static Dictionary<string, object> update(Dictionary<string, object> requestParams, string merchantKey)
        {

            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.UPDATE_MEMBER_V1, merchantKey);
        }


        /**
         * 创建用户对象
         *
         * @param requestParams 创建用户对象的请求参数，参见 AdaPay api
         * @return 创建用户对象
         * @ 异常
         */
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams)
        {

            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.MEMBER_V1, null);
        }

        /**
         * 查询用户对象
         *
         * @param requestParams 查询用户对象的请求参数，参见 AdaPay api
         * @return 查询的用户对象
         * @ 异常
         */
        public static Dictionary<string, object> query(Dictionary<string, object> requestParams)
        {
            string memberId = StringUtils.tryGetNotNullValue(requestParams, "member_id");
            string uri = new StringBuilder(APIUrlEnum.QUERY_MEMBER_V1).Append(memberId).ToString();
            return AdapayRequest.getRequestAdapay(requestParams, uri, null);
        }

        /**
         * 查询用户列表
         *
         * @param requestParams 查询用户列表的请求参数，参见 AdaPay api
         * @return 查询的用户列表
         * @ 异常
         */
        public static Dictionary<string, object> queryList(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.QUERY_MEMBER_LIST_V1, null);
        }

        /**
         * 更新用户对象
         *
         * @param requestParams 更新用户对象的请求参数，参见 AdaPay api
         * @return 更新后的用户对象
         * @ 异常
         */
        public static Dictionary<string, object> update(Dictionary<string, object> requestParams)
        {

            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.UPDATE_MEMBER_V1, null);
        }

    }

}
