using System.Collections.Generic;
using System.Text;

namespace AdapaySDK
{
    /// <summary>
    /// 结算账户对象
    /// </summary>
    public class SettleAccount
    {
        #region 创建结算账户对象
        /// <summary>
        /// 创建结算账户对象
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>创建结算账户对象</returns>
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.SETTLE_ACCOUNT_V1, merchantKey);
        }
        /// <summary>
        /// 创建结算账户对象
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>创建结算账户对象</returns>
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.SETTLE_ACCOUNT_V1, null);
        }
        #endregion

        #region 查询结算账户对象
        /// <summary>
        /// 查询结算账户对象
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>查询的结算账户对象</returns>
        public static Dictionary<string, object> query(Dictionary<string, object> requestParams, string merchantKey)
        {
            string settleAccountId = StringUtils.tryGetNotNullValue(requestParams, "settle_account_id");
            string uri = new StringBuilder(APIUrlEnum.QUERY_SETTLE_ACCOUNT_V1).Append(settleAccountId).ToString();
            return AdapayRequest.getRequestAdapay(requestParams, uri, merchantKey);
        }
        /// <summary>
        /// 查询结算账户对象
        /// </summary>
        /// <param name="requestParams"></param>
        /// <returns>查询的结算账户对象</returns>
        public static Dictionary<string, object> query(Dictionary<string, object> requestParams)
        {
            string settleAccountId = StringUtils.tryGetNotNullValue(requestParams, "settle_account_id");
            string uri = new StringBuilder(APIUrlEnum.QUERY_SETTLE_ACCOUNT_V1).Append(settleAccountId).ToString();
            return AdapayRequest.getRequestAdapay(requestParams, uri, null);
        }
        #endregion

        #region 删除结算账户对象
        /// <summary>
        /// 删除结算账户对象
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>删除的结算账户对象</returns>
        public static Dictionary<string, object> delete(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.DELETE_SETTLE_ACCOUNT_V1, merchantKey);
        }
        /// <summary>
        /// 删除结算账户对象
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>删除的结算账户对象</returns>
        public static Dictionary<string, object> delete(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.DELETE_SETTLE_ACCOUNT_V1, null);
        }
        #endregion

        #region 查询结算明细列表
        /// <summary>
        /// 查询结算明细列表
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>结算明细列表</returns>
        public static Dictionary<string, object> details(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.QUERY_SETTLE_DETAILS_V1, merchantKey);
        }
        /// <summary>
        /// 查询结算明细列表
        /// </summary>
        /// <param name="requestParams"></param>
        /// <returns>结算明细列表</returns>
        public static Dictionary<string, object> details(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.QUERY_SETTLE_DETAILS_V1, null);
        }
        #endregion

        #region 修改结算账户配置
        /// <summary>
        /// 修改结算账户配置
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>修改的结算账户对象</returns>
        public static Dictionary<string, object> update(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.MODIFY_SETTLE_ACCOUNT_V1, merchantKey);
        }
        /// <summary>
        /// 修改结算账户配置
        /// </summary>
        /// <param name="requestParams"></param>
        /// <returns>修改的结算账户对象</returns>
        public static Dictionary<string, object> update(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.MODIFY_SETTLE_ACCOUNT_V1, null);
        } 
        #endregion
    }
}
