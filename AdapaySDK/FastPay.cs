using System.Collections.Generic;

namespace AdapaySDK
{
    public class FastPay
    {
        #region 创建快捷支付绑卡对象
        /// <summary>
        /// 创建快捷支付绑卡对象
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>快捷支付绑卡对象</returns>
        public static Dictionary<string, object> cardBind(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.requestAdapayPageServer(requestParams, APIUrlEnum.FAST_PAY_CARD_BIND, merchantKey);
        }
        /// <summary>
        /// 创建快捷支付绑卡对象
        /// </summary>
        /// <param name="requestParams"></param>
        /// <returns>快捷支付绑卡对象</returns>
        public static Dictionary<string, object> cardBind(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.requestAdapayPageServer(requestParams, APIUrlEnum.FAST_PAY_CARD_BIND, null);
        }
        #endregion

        #region 创建快捷支付绑卡确认
        /// <summary>
        /// 创建快捷支付绑卡确认
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>快捷支付绑卡确认</returns>
        public static Dictionary<string, object> cardBindConfirm(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.requestAdapayPageServer(requestParams, APIUrlEnum.FAST_PAY_CARD_BIND_CONFIRM, merchantKey);
        }
        /// <summary>
        /// 创建快捷支付绑卡确认
        /// </summary>
        /// <param name="requestParams"></param>
        /// <returns>快捷支付绑卡确认</returns>
        public static Dictionary<string, object> cardBindConfirm(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.requestAdapayPageServer(requestParams, APIUrlEnum.FAST_PAY_CARD_BIND_CONFIRM, null);
        }
        #endregion

        #region 查询快捷支付绑卡对象列表
        /// <summary>
        /// 查询快捷支付绑卡对象列表
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>快捷支付绑卡对象列表</returns>
        public static Dictionary<string, object> cardBindList(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.getAdapayPageServer(requestParams, APIUrlEnum.FAST_PAY_CARD_BIND_LIST, merchantKey);
        }
        /// <summary>
        /// 查询快捷支付绑卡对象列表
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>快捷支付绑卡对象列表</returns>
        public static Dictionary<string, object> cardBindList(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.getAdapayPageServer(requestParams, APIUrlEnum.FAST_PAY_CARD_BIND_LIST, null);
        }
        #endregion

        #region 创建快捷支付确认
        /// <summary>
        /// 创建快捷支付确认
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>快捷支付确认</returns>
        public static Dictionary<string, object> confirm(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.FAST_PAY_CONFIRM, merchantKey);
        }
        /// <summary>
        /// 创建快捷支付确认
        /// </summary>
        /// <param name="requestParams"></param>
        /// <returns>快捷支付确认</returns>
        public static Dictionary<string, object> confirm(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.FAST_PAY_CONFIRM, null);
        }
        #endregion

        #region 快捷支付短信重发
        /// <summary>
        /// 快捷支付短信重发
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="merchantKey"></param>
        /// <returns>快捷支付短信重发</returns>
        public static Dictionary<string, object> smsCode(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.FAST_PAY_SMS_CODE, merchantKey);
        }
        /// <summary>
        /// 快捷支付短信重发
        /// </summary>
        /// <param name="requestParams"></param>
        /// <returns>快捷支付短信重发</returns>
        public static Dictionary<string, object> smsCode(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.FAST_PAY_SMS_CODE, null);
        } 
        #endregion
    }
}
