using System;
using System.Collections.Generic;

namespace AdapaySDK
{
    public class FastPay
    {
        /**
         * 创建快捷支付绑卡对象
         *
         * @param requestParams  请求参数
         * @param merchantKey merchantKey
         * @return 快捷支付绑卡
         */
        public static Dictionary<string, object> cardBind(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.requestAdapayPageServer(requestParams, APIUrlEnum.FAST_PAY_CARD_BIND, null);
        }

        /**
         * 创建快捷支付绑卡确认
         *
         * @param requestParams  请求参数
         * @param merchantKey merchantKey
         * @return 快捷支付绑卡确认
         */
        public static Dictionary<string, object> cardBindConfirm(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.requestAdapayPageServer(requestParams, APIUrlEnum.FAST_PAY_CARD_BIND_CONFIRM, null);
        }

        /**
         * 查询快捷支付绑卡对象列表
         *
         * @param requestParams  请求参数
         * @param merchantKey merchantKey
         * @return 快捷支付绑卡
         */
        public static Dictionary<string, object> cardBindList(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.getAdapayPageServer(requestParams, APIUrlEnum.FAST_PAY_CARD_BIND_LIST, null);
        }

        /**
         * 创建快捷支付确认
         *
         * @param requestParams  请求参数
         * @param merchantKey merchantKey
         * @return 快捷支付确认
         */
        public static Dictionary<string, object> confirm(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.FAST_PAY_CONFIRM, null);
        }

        /**
         * 快捷支付短信重发
         *
         * @param requestParams  请求参数
         * @param merchantKey merchantKey
         * @return 快捷支付短信重发
         */
        public static Dictionary<string, object> smsCode(Dictionary<string, object> requestParams)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.FAST_PAY_SMS_CODE, null);
        }


        /**
         * 创建快捷支付绑卡对象
         *
         * @param requestParams  请求参数
         * @param merchantKey merchantKey
         * @return 快捷支付绑卡
         */
        public static Dictionary<string, object> cardBind(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.requestAdapayPageServer(requestParams, APIUrlEnum.FAST_PAY_CARD_BIND, merchantKey);
        }

        /**
         * 创建快捷支付绑卡确认
         *
         * @param requestParams  请求参数
         * @param merchantKey merchantKey
         * @return 快捷支付绑卡确认
         */
        public static Dictionary<string, object> cardBindConfirm(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.requestAdapayPageServer(requestParams, APIUrlEnum.FAST_PAY_CARD_BIND_CONFIRM, merchantKey);
        }

        /**
         * 查询快捷支付绑卡对象列表
         *
         * @param requestParams  请求参数
         * @param merchantKey merchantKey
         * @return 快捷支付绑卡
         */
        public static Dictionary<string, object> cardBindList(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.getAdapayPageServer(requestParams, APIUrlEnum.FAST_PAY_CARD_BIND_LIST, merchantKey);
        }

        /**
         * 创建快捷支付确认
         *
         * @param requestParams  请求参数
         * @param merchantKey merchantKey
         * @return 快捷支付确认
         */
        public static Dictionary<string, object> confirm(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.FAST_PAY_CONFIRM, merchantKey);
        }

        /**
         * 快捷支付短信重发
         *
         * @param requestParams  请求参数
         * @param merchantKey merchantKey
         * @return 快捷支付短信重发
         */
        public static Dictionary<string, object> smsCode(Dictionary<string, object> requestParams, string merchantKey)
        {
            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.FAST_PAY_SMS_CODE, merchantKey);
        }

    }
}
