using System;
using System.Collections.Generic;
using System.Text;

namespace AdapaySDK
{
    public class CorpMember
    {
        /**
         * 创建企业用户对象
         *
         * @param params 创建企业用户对象的请求参数，参见 AdaPay api
         * @param params 创建企业用户对象的附件文件参数，参见 AdaPay api
         * @param merchantKey merchantKey
         * @return 创建用户对象
         * @ 异常
         */
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams, string filePath, string merchantKey)
        {

            return AdapayRequest.requestAdapay(requestParams, filePath, "attach_file", APIUrlEnum.CORP_MEMBER_V1, merchantKey);
        }

        /**
         * 查询企业用户对象
         *
         * @param params 查询企业用户对象的请求参数，参见 AdaPay api
         * @return 查询的企业用户对象
         * @ 异常
         */
        public static Dictionary<string, object> query(Dictionary<string, object> requestParams, string merchantKey)
        {
            string memberId = StringUtils.tryGetNotNullValue(requestParams, "member_id");
            string uri = new StringBuilder(APIUrlEnum.QUERY_CORP_MEMBER_V1).Append(memberId).ToString();

            return AdapayRequest.getRequestAdapay(requestParams, uri, merchantKey);
        }

        /**
         * 创建企业用户对象
         *
         * @param params 创建企业用户对象的请求参数，参见 AdaPay api
         * @param params 创建企业用户对象的附件文件参数，参见 AdaPay api
         * @param merchantKey merchantKey
         * @return 创建用户对象
         * @ 异常
         */
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams, string filePath)
        {

            return AdapayRequest.requestAdapay(requestParams, filePath, "attach_file", APIUrlEnum.CORP_MEMBER_V1, null);
        }

        /**
         * 查询企业用户对象
         *
         * @param params 查询企业用户对象的请求参数，参见 AdaPay api
         * @return 查询的企业用户对象
         * @ 异常
         */
        public static Dictionary<string, object> query(Dictionary<string, object> requestParams)
        {
            string memberId = StringUtils.tryGetNotNullValue(requestParams, "member_id");

            string uri = new StringBuilder(APIUrlEnum.QUERY_CORP_MEMBER_V1).Append(memberId).ToString();
            return AdapayRequest.getRequestAdapay(requestParams, uri, null);
        }
    }
}
