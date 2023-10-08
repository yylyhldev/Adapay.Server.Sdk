using System.Collections.Generic;

namespace AdapaySDK
{
    /// <summary>
    /// 账户冻结对象
    /// </summary>
    public class FreezeAccount
    {
        #region 创建账户冻结对象
        /// <summary>
        /// 创建账户冻结对象
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>账户冻结对象</returns>
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.FREEZE_ACCOUNT_CREATE, null);
        }
        /// <summary>
        /// 创建账户冻结对象
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>账户冻结对象</returns>
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.FREEZE_ACCOUNT_CREATE, merchantKey);
        }
        #endregion

        #region 查询账户冻结对象列表
        /// <summary>
        /// 查询账户冻结对象列表
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>账户冻结对象列表</returns>
        public static Dictionary<string, object> queryList(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.FREEZE_ACCOUNT_LIST, null);
        }
        /// <summary>
        /// 查询账户冻结对象列表
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>账户冻结对象列表</returns>
        public static Dictionary<string, object> queryList(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.FREEZE_ACCOUNT_LIST, merchantKey);
        } 
        #endregion
    }
}
