using System.Collections.Generic;

namespace AdapaySDK
{
    /// <summary>
    /// 收银台对象
    /// </summary>
    public class Checkout
    {
        #region 创建收银台对象
        /// <summary>
        /// 创建收银台对象
        /// </summary>
        /// <param name="requestParams">创建收银台对象 AdaPay api</param>
        /// <param name="merchantKey"></param>
        /// <returns>收银台对象</returns>
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.requestAdapayPageServer(requestParams, APIUrlEnum.CREATE_CHECK_OUT, merchantKey);
        }
        /// <summary>
        /// 创建收银台对象
        /// </summary>
        /// <param name="requestParams">创建收银台对象 AdaPay api</param>
        /// <param name="merchantKey"></param>
        /// <returns>收银台对象</returns>
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.requestAdapayPageServer(requestParams, APIUrlEnum.CREATE_CHECK_OUT, null);
        }
        #endregion

        #region 查询收银台对象列表
        /// <summary>
        /// 查询收银台对象列表
        /// </summary>
        /// <param name="requestParams">查询收银台对象列表 AdaPay api</param>
        /// <param name="merchantKey"></param>
        /// <returns>收银台对象</returns>
        public static Dictionary<string, object> queryList(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.requestAdapayPageServer(requestParams, APIUrlEnum.LIST_CHECK_OUT, merchantKey);
        }
        /// <summary>
        /// 查询收银台对象列表
        /// </summary>
        /// <param name="requestParams">查询收银台对象列表 AdaPay api</param>
        /// <returns>收银台对象</returns>
        public static Dictionary<string, object> queryList(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.requestAdapayPageServer(requestParams, APIUrlEnum.LIST_CHECK_OUT, null);
        } 
        #endregion
    }
}
