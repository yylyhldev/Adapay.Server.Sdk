using System;
using System.Collections.Generic;
using AdapayCore;

namespace AdapaySDK
{
    /// <summary>
    /// [2022-01-10 v1.4.1：https://docs.adapay.tech/sdk/csharpsdkaccess.html]
    /// </summary>
    public class Adapay
    {
        /// <summary>
        /// sdk版本
        /// </summary>
        private const string sdk_version = "C#v1.4.1";

        public static string deviceId { get; set; } = "";

        public static Dictionary<string, MerConfig> merchantConfigs;

        /// <summary>
        /// isMock 模式，默认为生产模式 true，false可以使用 mock模式
        /// </summary>
        public static bool isMock { get; set; } = false;

        private static bool _debug = false;
        /// <summary>
        /// isMock 模式，默认为生产模式 true，false可以使用 mock模式
        /// </summary>
        public static bool debug
        {
            set
            {
                _debug = value;
                CoreUtils.debug = value;
            }
            get
            {
                if (!_debug)
                {
                    return false;
                }
                return _debug;
            }
        }


        /// <summary>
        /// 初始化商户配置
        /// </summary>
        /// <param name="config"></param>
        /// <exception cref="Exception"></exception>
        public static void initWithMerConfig(MerConfig config)
        {
            initAdapayCore();
            if (null != config)
            {
                merchantConfigs = new Dictionary<string, MerConfig>
                {
                    { "default", config }
                };
            }
            else
            {
                throw new Exception("configs cannot be null");
            }
        }

        /// <summary>
        /// 初始化多商户配置
        /// </summary>
        /// <param name="configs"></param>
        /// <exception cref="Exception"></exception>
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

        private static void initAdapayCore()
        {
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

    class AdapayRequest
    {

        /// <summary>
        /// 获取商户配置
        /// </summary>
        /// <param name="merchantKey"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// 发起请求[post]
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="uri"></param>
        /// <param name="merchantKey"></param>
        /// <returns></returns>
        public static Dictionary<string, object> requestAdapay(Dictionary<string, object> requestParams, string uri, string merchantKey)
        {
            MerConfig config = fetchConfig(merchantKey);
            string apikey = config.apiKey;
            if (Adapay.isMock)
            {
                apikey = config.apiMockKey;
            }
            return NetUtils.requestAdapay(requestParams, null, null, uri, NetUtils.POST, apikey, config.privateKey);
        }

        /// <summary>
        /// 发起请求[get]
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="uri"></param>
        /// <param name="merchantKey"></param>
        /// <returns></returns>
        public static Dictionary<string, object> getRequestAdapay(Dictionary<string, object> requestParams, string uri, string merchantKey)
        {

            MerConfig config = fetchConfig(merchantKey);
            string apikey = config.apiKey;
            if (Adapay.isMock)
            {
                apikey = config.apiMockKey;
            }
            return NetUtils.requestAdapay(requestParams, null, null, uri, NetUtils.GET, apikey, config.privateKey);

        }

        /// <summary>
        /// 发起请求[post]
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="filePath"></param>
        /// <param name="fileParam"></param>
        /// <param name="uri"></param>
        /// <param name="merchantKey"></param>
        /// <returns></returns>
        public static Dictionary<string, object> requestAdapay(Dictionary<string, object> requestParams, string filePath, string fileParam, string uri, string merchantKey)
        {

            MerConfig config = fetchConfig(merchantKey);
            string apikey = config.apiKey;
            if (Adapay.isMock)
            {
                apikey = config.apiMockKey;
            }

            return NetUtils.requestAdapay(requestParams, filePath, fileParam, uri, NetUtils.POST, apikey, config.privateKey);

        }

        /// <summary>
        /// 发起请求[post]
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="uri"></param>
        /// <param name="merchantKey"></param>
        /// <returns></returns>
        public static Dictionary<string, object> requestAdapayPageServer(Dictionary<string, object> requestParams, string uri, string merchantKey)
        {
            MerConfig config = fetchConfig(merchantKey);
            string apikey = config.apiKey;
            if (Adapay.isMock)
            {
                apikey = config.apiMockKey;
            }

            return NetUtils.requestAdapayWithURL(requestParams, null, null, ConfigConstant.PAGE_SERVER_BASE_URL + uri, NetUtils.POST, apikey, config.privateKey);
        }

        /// <summary>
        /// 发起请求[get]
        /// </summary>
        /// <param name="requestParams"></param>
        /// <param name="uri"></param>
        /// <param name="merchantKey"></param>
        /// <returns></returns>
        public static Dictionary<string, object> getAdapayPageServer(Dictionary<string, object> requestParams, string uri, string merchantKey)
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


