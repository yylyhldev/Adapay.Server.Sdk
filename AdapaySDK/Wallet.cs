using System.Collections.Generic;

namespace AdapaySDK
{
    public class Wallet
    {
        #region 获取登录信息
        /// <summary>
        /// 获取登录信息
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>跳转页面信息</returns>
        public static Dictionary<string, object> login(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.requestAdapayPageServer(requestParams, APIUrlEnum.WALLET_LOGIN, merchantKey);
        }
        /// <summary>
        /// 获取登录信息
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>跳转页面信息</returns>
        public static Dictionary<string, object> login(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.requestAdapayPageServer(requestParams, APIUrlEnum.WALLET_LOGIN, null);
        }
        #endregion

        #region 查询帐户余额
        /// <summary>
        /// 查询帐户余额
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>帐户余额</returns>
        public static Dictionary<string, object> balance(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.QUERY_BALANCE, null);
        }
        /// <summary>
        /// 查询帐户余额
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>帐户余额</returns>
        public static Dictionary<string, object> balance(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.QUERY_BALANCE, merchantKey);
        } 
        #endregion
    }
}
