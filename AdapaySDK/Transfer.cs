using System.Collections.Generic;

namespace AdapaySDK
{
    /// <summary>
    /// 转账对象
    /// </summary>
    public class Transfer
    {
        #region 创建转账对象
        /// <summary>
        /// 创建转账对象
        /// </summary>
        /// <param name="requestParams"></param>
        /// <returns>创建的转账对象</returns>
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.CREATE_TRANSFER, null);
        }
        /// <summary>
        /// 创建转账对象
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>创建的转账对象</returns>
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.CREATE_TRANSFER, merchantKey);
        }
        #endregion

        #region 查询账户转账对象列表
        /// <summary>
        /// 查询账户转账对象列表
        /// </summary>
        /// <param name="requestParams"></param>
        /// <returns>账户转账对象列表</returns>
        public static Dictionary<string, object> queryList(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.TRANSFER_LIST, null);
        }
        /// <summary>
        /// 查询账户转账对象列表
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>账户转账对象列表</returns>
        public static Dictionary<string, object> queryList(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.TRANSFER_LIST, merchantKey);
        } 
        #endregion
    }
}
