using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapayCore;

namespace AdapaySDK
{
    public class AdapayTools
    {
        /**
         * 获取银联云闪付用户标识 
         */
        public static Dictionary<string, Object> unionUserId(Dictionary<string, Object> requestParams, string
            merchantKey)
        {

            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.UNION_USER_ID_V1, merchantKey);
        }

        /**
         * 获取银联云闪付用户标识 
         */
        public static Dictionary<string, Object> unionUserId(Dictionary<string, Object> requestParams)
        {

            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.UNION_USER_ID_V1, null);
        }

        /**
         * download  bill file 
         */
        public static Dictionary<string, Object> downloadBill(Dictionary<string, object> requestParams)
        {

            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.BILL_DOWNLOAD_V1, null);

        }

        /**
         * download  bill file 
         */
        public static Dictionary<string, Object> downloadBill(Dictionary<string, object> requestParams, string merchantKey)
        {

            return AdapayRequest.requestAdapay(requestParams, APIUrlEnum.BILL_DOWNLOAD_V1, merchantKey);

        }

        /**
         * 校验返回签名
         * 
         * @param signature 签名
         * @param content 报文内容
         * @return 校验结果 
         */
        public static bool verifySign(string signature, string content)
        {

            return NetUtils.verfySign(signature, content);

        }
    }
}
