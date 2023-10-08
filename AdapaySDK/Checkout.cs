using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapaySDK
{
    public class Checkout
    {

        /**
        * 创建收银台对象
        *
        * @param requestParams 创建收银台对象 AdaPay api
        * @return 收银台对象
        */
        public static Dictionary<string, Object> create(Dictionary<string, object> requestParams)
        {

            return AdapayRequest.requestAdapayPageServer(requestParams, APIUrlEnum.CREATE_CHECK_OUT, null);
        }

        /**
        * 创建收银台对象
        *
        * @param requestParams 创建收银台对象 AdaPay api
        * @param merchantKey merchantKey
        * @return 收银台对象
        */
        public static Dictionary<string, Object> create(Dictionary<string, object> requestParams, string merchantKey)
        {

            return AdapayRequest.requestAdapayPageServer(requestParams, APIUrlEnum.CREATE_CHECK_OUT, merchantKey);
        }

        /**
        * 查询收银台对象列表
        *
        * @param requestParams 查询收银台对象列表 AdaPay api
        * @param merchantKey merchantKey
        * @return 收银台对象
        */
        public static Dictionary<string, Object> queryList(Dictionary<string, object> requestParams, string merchantKey)
        {

            return AdapayRequest.requestAdapayPageServer(requestParams, APIUrlEnum.LIST_CHECK_OUT, merchantKey);
        }


        /**
        * 查询收银台对象列表
        *
        * @param requestParams 查询收银台对象列表 AdaPay api
        * @return 收银台对象
        */
        public static Dictionary<string, Object> queryList(Dictionary<string, object> requestParams)
        {

            return AdapayRequest.requestAdapayPageServer(requestParams, APIUrlEnum.LIST_CHECK_OUT, null);
        }
    }
}
