using System;
using System.Collections.Generic;
using System.Text;

using System.Collections;

namespace AdapaySDK
{
    public class Refund
    {
        /**
         * create refund for multi merchant
         */
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams, string merchantKey)
        {

            string id = StringUtils.tryGetNotNullValue(requestParams, "id");
            string uri = new StringBuilder(APIUrlEnum.REFUND_V1).Append(id).Append("/refunds").ToString();
            return AdapayRequest.requestAdapay(requestParams, uri, merchantKey);
        }

        /**
         * create refund for multi merchant
         */
        public static Dictionary<string, object> create(Dictionary<string, object> requestParams)
        {
            string id = StringUtils.tryGetNotNullValue(requestParams, "id");

            string uri = new StringBuilder(APIUrlEnum.REFUND_V1).Append(id).Append("/refunds").ToString();


            return AdapayRequest.requestAdapay(requestParams, uri, null);
        }

        /**
         * query refund for multi merchant
         */
        public static Dictionary<string, object> query(Dictionary<string, object> requestParams, string merchantKey)
        {


            return AdapayRequest.getRequestAdapay(requestParams,APIUrlEnum.QUERY_REFUND_V1,merchantKey);
        }

        /**
        * query refund 
        */
        public static Dictionary<string, object> query(Dictionary<string, object> requestParams )
        {


            return AdapayRequest.getRequestAdapay(requestParams, APIUrlEnum.QUERY_REFUND_V1, null);
        }


    }
}
