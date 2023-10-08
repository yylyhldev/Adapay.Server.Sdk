using System.Collections.Generic;

namespace AdapaySDK
{
    public class Drawcash
    {
        #region 创建取现对象
        /// <summary>
        /// 创建取现对象
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>取现对象</returns>
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.DRAW_CASH, null);
        }
        /// <summary>
        /// 创建取现对象
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>取现对象</returns>
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.DRAW_CASH, merchantKey);
        }
        #endregion

        #region 创建取现对象
        /// <summary>
        /// 查询取现状态
        /// </summary>
        /// <param name="requestParams"></param>
        /// <returns>取现状态</returns>
        public static Dictionary<string, object> query(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.QUERY_CASHS_STAT_V1, null);
        }
        /// <summary>
        /// 查询取现状态
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>取现状态</returns>
        public static Dictionary<string, object> query(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.QUERY_CASHS_STAT_V1, merchantKey);
        } 
        #endregion
    }
}
