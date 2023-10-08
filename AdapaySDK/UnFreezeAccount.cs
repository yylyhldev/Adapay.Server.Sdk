using System.Collections.Generic;

namespace AdapaySDK
{
    /// <summary>
    /// 账户解冻对象
    /// </summary>
    public class UnFreezeAccount
    {
        #region 创建账户解冻对象
        /// <summary>
        /// 创建账户解冻对象
        /// </summary>
        /// <param name="requestParams"></param>
        /// <returns>创建的账户解冻对象</returns>
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.UN_FREEZE_ACCOUNT_CREATE, null);
        }
        /// <summary>
        /// 创建账户解冻对象
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>创建的账户解冻对象</returns>
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.UN_FREEZE_ACCOUNT_CREATE, merchantKey);
        }
        #endregion

        #region 查询账户解冻对象列表
        /// <summary>
        /// 查询账户解冻对象列表
        /// </summary>
        /// <param name="requestParams"></param>
        /// <returns>账户解冻对象列表</returns>
        public static Dictionary<string, object> queryList(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.UN_FREEZE_ACCOUNT_LIST, null);
        }
        /// <summary>
        /// 查询账户解冻对象列表
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>账户解冻对象列表</returns>
        public static Dictionary<string, object> queryList(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.UN_FREEZE_ACCOUNT_LIST, merchantKey);
        } 
        #endregion
    }
}
