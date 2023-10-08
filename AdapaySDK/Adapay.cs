using System;

using System.Collections.Generic;
using AdapayCore;


namespace AdapaySDK
{
    public class Adapay
    {
        private const string sdk_version = "C#v1.4.1";

        public static string deviceId="";

        public static Dictionary<string, MerConfig> merchantConfigs;

        public static bool isMock = false;

         private static bool _debug = false;
        public static bool debug {
            set {
                _debug = value;
                CoreUtils.debug = value;
            }

            get {
                if (!_debug) {
                    return false;
                }
                return _debug;
            }
        }

       

        public static void initWithMerConfig(MerConfig config) {
            initAdapayCore();
            if (null != config)
            {
                merchantConfigs = new Dictionary<string, MerConfig>();
                merchantConfigs.Add("default", config);
            }
            else {
                throw new Exception("configs cannot be null");
            }
        }

        public static void initWithMerConfigs(Dictionary<string, MerConfig> configs)
        {
            initAdapayCore();
            if (null != configs)
            {
                merchantConfigs = configs;
            }
            else
            {
                throw new Exception("configs cannot be null");
            }
            
        }


        private static void initAdapayCore (){

            CoreUtils.BASE_URL = ConfigConstant.BASE_URL;
            CoreUtils.RSA_PUB_KEY = ConfigConstant.RSA_PUB_KEY;
            CoreUtils.sdk_version = sdk_version;

            /** 
            MQTT_Config.MQTT_ACCESS_KEY = MQTT_Constant.MQTT_ACCESS_KEY;
            MQTT_Config.MQTT_CLIENT_ID_PREFIX = MQTT_Constant.MQTT_CLIENT_ID_PREFIX;
            MQTT_Config.MQTT_END_POINT = MQTT_Constant.MQTT_END_POINT;
            MQTT_Config.MQTT_INSTANCE_ID = MQTT_Constant.MQTT_INSTANCE_ID;
            MQTT_Config.MQTT_TOPIC_PREFIX = MQTT_Constant.MQTT_TOPIC_PREFIX;
            **/

        }
    }

    class AdapayRequest {

        public static MerConfig fetchConfig(string merchantKey)
        {

            if (null == merchantKey)
            {

                merchantKey = "default";
            }

            if (null == Adapay.merchantConfigs)
            {
                throw new Exception("Please config merchant config info at first");
            }

            MerConfig config = null;
            Adapay.merchantConfigs.TryGetValue(merchantKey, out config);
            if (null == config)
            {
                throw new Exception("configInfo for merchantkey-" + merchantKey + "is not configed");
            }
            return config;


        }
        

        public static Dictionary<string, Object> requestAdapay(Dictionary<string, object> requestParams, string uri, string merchantKey) {

            MerConfig config = fetchConfig(merchantKey);
            string apikey = config.apiKey;
            if (Adapay.isMock)
            {
                apikey = config.apiMockKey;
            }
            return NetUtils.requestAdapay(requestParams, null, null, uri, NetUtils.POST, apikey, config.privateKey);

        }

        public static Dictionary<string, Object> getRequestAdapay(Dictionary<string, object> requestParams, string uri, string merchantKey)
        {

            MerConfig config = fetchConfig(merchantKey);
            string apikey = config.apiKey;
            if (Adapay.isMock)
            {
                apikey = config.apiMockKey;
            }
            return NetUtils.requestAdapay(requestParams, null, null, uri, NetUtils.GET, apikey, config.privateKey);

        }


        public static Dictionary<string, Object> requestAdapay(Dictionary<string, object> requestParams, string filePath, string fileParam, string uri, string merchantKey)
        {

            MerConfig config = fetchConfig(merchantKey);
            string apikey = config.apiKey;
            if (Adapay.isMock)
            {
                apikey = config.apiMockKey;
            }

            return NetUtils.requestAdapay(requestParams, filePath, fileParam, uri, NetUtils.POST,  apikey, config.privateKey);

        }

        public static Dictionary<string, Object> requestAdapayPageServer(Dictionary<string, object> requestParams, string uri, string merchantKey)
        {
            MerConfig config = fetchConfig(merchantKey);
            string apikey = config.apiKey;
            if (Adapay.isMock)
            {
                apikey = config.apiMockKey;
            }

            return NetUtils.requestAdapayWithURL(requestParams, null, null, ConfigConstant.PAGE_SERVER_BASE_URL + uri, NetUtils.POST, apikey, config.privateKey);
        }
        public static Dictionary<string, Object> getAdapayPageServer(Dictionary<string, object> requestParams, string uri, string merchantKey)
        {
            MerConfig config = fetchConfig(merchantKey);
            string apikey = config.apiKey;
            if (Adapay.isMock)
            {
                apikey = config.apiMockKey;
            }

            return NetUtils.requestAdapayWithURL(requestParams, null, null, ConfigConstant.PAGE_SERVER_BASE_URL + uri, NetUtils.GET, apikey, config.privateKey);
        }
    }
}


