using System.Collections.Generic;
using System.Text;

namespace AdapaySDK
{
    public class CorpMember
    {
        #region 创建企业用户对象
        /// <summary>
        /// 创建企业用户对象
        /// </summary>
        /// <param name="requestParams">创建企业用户对象的请求参数，参见 AdaPay api</param>
        /// <param name="requestParams">创建企业用户对象的附件文件参数，参见 AdaPay api</param>
        /// <param name="merchantKey"></param>
        /// <returns>企业用户对象</returns>
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams, string filePath, string merchantKey)
        {

            return AdapayRequest.requestAdapay(requestParams, filePath, "attach_file", APIUrlEnum.CORP_MEMBER_V1, merchantKey);
        }
        /// <summary>
        /// 创建企业用户对象
        /// </summary>
        /// <param name="requestParams">创建企业用户对象的请求参数，参见 AdaPay api</param>
        /// <param name="requestParams">创建企业用户对象的附件文件参数，参见 AdaPay api</param>
        /// <returns>企业用户对象</returns>
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams, string filePath)
        {

            return AdapayRequest.requestAdapay(requestParams, filePath, "attach_file", APIUrlEnum.CORP_MEMBER_V1, null);
        }

        #endregion
        
        #region 查询企业用户对象
        /// <summary>
        /// 查询企业用户对象
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>查询的企业用户对象</returns>
        public static Dictionary<string, object> query(Dictionary<string, object> requestParams, string merchantKey)
        {
            string memberId = StringUtils.tryGetNotNullValue(requestParams, "member_id");
            string uri = new StringBuilder(APIUrlEnum.QUERY_CORP_MEMBER_V1).Append(memberId).ToString();
            return AdapayRequest.getRequestAdapay(requestParams, uri, merchantKey);
        }
        /// <summary>
        /// 查询企业用户对象
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>查询的企业用户对象</returns>
        public static Dictionary<string, object> query(Dictionary<string, object> requestParams)
        {
            string memberId = StringUtils.tryGetNotNullValue(requestParams, "member_id");
            string uri = new StringBuilder(APIUrlEnum.QUERY_CORP_MEMBER_V1).Append(memberId).ToString();
            return AdapayRequest.getRequestAdapay(requestParams, uri, null);
        } 
        #endregion
    }
}
