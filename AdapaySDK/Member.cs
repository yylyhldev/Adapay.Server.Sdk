using System.Collections.Generic;
using System.Text;

namespace AdapaySDK
{
    /// <summary>
    /// 用户对象
    /// </summary>
    public class Member
    {
        #region 创建用户对象
        /// <summary>
        /// 创建用户对象
        /// </summary>
        /// <param name="requestParams">创建用户对象的请求参数，参见 AdaPay api</param>
        /// <param name="merchantKey"></param>
        /// <returns>用户对象</returns>
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.MEMBER_V1, merchantKey);
        }
        /// <summary>
        /// 创建用户对象
        /// </summary>
        /// <param name="requestParams">创建用户对象的请求参数，参见 AdaPay api</param>
        /// <returns>用户对象</returns>
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.MEMBER_V1, null);
        }
        #endregion

        #region 查询用户
        /// <summary>
        /// 查询用户对象
        /// </summary>
        /// <param name="requestParams">查询用户对象的请求参数，参见 AdaPay api</param>
        /// <param name="merchantKey"></param>
        /// <returns>用户对象</returns>
        public static Dictionary<string, object> query(Dictionary<string, object> requestParams, string merchantKey)
        {
            string memberId = StringUtils.tryGetNotNullValue(requestParams, "member_id");
            string uri = new StringBuilder(APIUrlEnum.QUERY_MEMBER_V1).Append(memberId).ToString();
            return AdapayRequest.getRequestAdapay(requestParams, uri, merchantKey);
        }
        /// <summary>
        /// 查询用户对象
        /// </summary>
        /// <param name="requestParams">查询用户对象的请求参数，参见 AdaPay api</param>
        /// <returns>用户对象</returns>
        public static Dictionary<string, object> query(Dictionary<string, object> requestParams)
        {
            string memberId = StringUtils.tryGetNotNullValue(requestParams, "member_id");
            string uri = new StringBuilder(APIUrlEnum.QUERY_MEMBER_V1).Append(memberId).ToString();
            return AdapayRequest.getRequestAdapay(requestParams, uri, null);
        }
        #endregion

        #region 查询用户列表
        /// <summary>
        /// 查询用户列表
        /// </summary>
        /// <param name="requestParams">查询用户列表的请求参数 AdaPay api</param>
        /// <param name="merchantKey"></param>
        /// <returns>查询的用户列表</returns>
        public static Dictionary<string, object> queryList(Dictionary<string, object> requestParams, string merchantKey)
        {

            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.QUERY_MEMBER_LIST_V1, merchantKey);
        }
        /// <summary>
        /// 查询用户列表
        /// </summary>
        /// <param name="requestParams">查询用户列表的请求参数 AdaPay api</param>
        /// <returns>查询的用户列表</returns>
        public static Dictionary<string, object> queryList(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.QUERY_MEMBER_LIST_V1, null);
        }
        #endregion

        #region 更新用户对象
        /// <summary>
        /// 更新用户对象
        /// </summary>
        /// <param name="requestParams">更新用户对象的请求参数 AdaPay api</param>
        /// <param name="merchantKey"></param>
        /// <returns>更新后的用户对象</returns>
        public static Dictionary<string, object> update(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.UPDATE_MEMBER_V1, merchantKey);
        }
        /// <summary>
        /// 更新用户对象
        /// </summary>
        /// <param name="requestParams">更新用户对象的请求参数 AdaPay api</param>
        /// <returns>更新后的用户对象</returns>
        public static Dictionary<string, object> update(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.UPDATE_MEMBER_V1, null);
        } 
        #endregion
    }

}
