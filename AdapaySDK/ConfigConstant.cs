namespace AdapaySDK
{
    class ConfigConstant
    {
        /// <summary>
        /// 接口基础地址
        /// </summary>
        public const string BASE_URL = "https://api.adapay.tech";

        /// <summary>
        /// 分页接口地址
        /// </summary>
        public const string PAGE_SERVER_BASE_URL = "https://page.adapay.tech";

        /// <summary>
        /// 商户公钥
        /// </summary>
        public const string RSA_PUB_KEY = "MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCwN6xgd6Ad8v2hIIsQVnbt8a3JituR8o4Tc3B5WlcFR55bz4OMqrG/356Ur3cPbc2Fe8ArNd/0gZbC9q56Eb16JTkVNA/fye4SXznWxdyBPR7+guuJZHc/VW2fKH2lfZ2P3Tt0QkKZZoawYOGSMdIvO+WqK44updyax0ikK6JlNQIDAQAB";
        
    }

    class APIUrlEnum
    {
        #region 跳转支付（jumppay）
        /// <summary>
        /// 托管 微信 小程序预下单接口
        /// </summary>
        public const string WXPAY_CREATEORDER_JUMPPAYMENT_V1 = "/v1/wxpay/createOrder";

        /// <summary>
        /// 托管 支付宝 小程序预下单接口
        /// </summary>
        public const string PREPAY_PREORDER_JUMPPAYMENT_V1 = "/v1/prePay/preOrder";

        /// <summary>
        /// 动态二维码预下单接口
        /// </summary>
        public const string QRPREPAY_QRPREORDER_JUMPPAYMENT_V1 = "/v1/qrPrePay/qrPreOrder";
        #endregion

        #region 支付对象（Payment）
        /// <summary>
        /// 支付
        /// </summary>
        public const string PAYMENT_V1 = "/v1/payments";

        /// <summary>
        /// 支付查询
        /// </summary>
        public const string QUERY_PAYMENT_V1 = "/v1/payments/";

        /// <summary>
        /// 支付对象列表查询
        /// </summary>
        public const string LIST_PAYMENT_V1 = "/v1/payments/list";

        /// <summary>
        /// 关单
        /// </summary>
        public const string CLOSE_PAYMENT_V1 = "/v1/payments/";

        /// <summary>
        /// 快捷支付支付确认
        /// </summary>
        public const string FAST_PAY_CONFIRM = "/v1/fast_pay/confirm";

        /// <summary>
        /// 快捷支付短信重发
        /// </summary>
        public const string FAST_PAY_SMS_CODE = "/v1/fast_pay/sms_code";

        #endregion

        #region 退款对象（Refund）
        /// <summary>
        /// 退款
        /// </summary>
        public const string REFUND_V1 = "/v1/payments/";

        /// <summary>
        /// 退款查询
        /// </summary>
        public const string QUERY_REFUND_V1 = "/v1/payments/refunds";
        #endregion

        #region 支付确认对象（PaymentConfirm）
        /// <summary>
        /// 支付确认
        /// </summary>
        public const string CONFIRM_PAYMENT_V1 = "/v1/payments/confirm";

        /// <summary>
        /// 支付确认查询
        /// </summary>
        public const string QUERY_CONFIRM_PAYMENT_V1 = "/v1/payments/confirm/";

        /// <summary>
        /// 支付确认列表查询
        /// </summary>
        public const string CONFIRM_PAYMENT_LIST_V1 = "/v1/payments/confirm/list";
        #endregion

        #region 支付撤销对象（PaymentConfirm）
        /// <summary>
        /// 支付撤销
        /// </summary>
        public const string REVERSE_PAYMENT_V1 = "/v1/payments/reverse";

        /// <summary>
        /// 查询支付撤销
        /// </summary>
        public const string QUERY_REVERSE_PAYMENT_V1 = "/v1/payments/reverse/";

        /// <summary>
        /// 支付撤销列表查询
        /// </summary>
        public const string REVERSE_PAYMENT_LIST_V1 = "/v1/payments/reverse/list";
        #endregion

        #region 个人用户（Member）
        /// <summary>
        /// 创建用户
        /// </summary>
        public const string MEMBER_V1 = "/v1/members";

        /// <summary>
        /// 查询用户对象
        /// </summary>
        public const string QUERY_MEMBER_V1 = "/v1/members/";

        /// <summary>
        /// 查询用户列表
        /// </summary>
        public const string QUERY_MEMBER_LIST_V1 = "/v1/members/list";

        /// <summary>
        /// 更新用户
        /// </summary>
        public const string UPDATE_MEMBER_V1 = "/v1/members/update";
        #endregion

        #region 企业用户（CorpMember）
        /// <summary>
        /// 创建企业用户对象
        /// </summary>
        public const string CORP_MEMBER_V1 = "/v1/corp_members";

        /// <summary>
        /// 查询企业用户对象
        /// </summary>
        public const string QUERY_CORP_MEMBER_V1 = "/v1/corp_members/";
        #endregion

        #region 结算账户（SettleAccount）
        /// <summary>
        /// 创建结算账户
        /// </summary>
        public const string SETTLE_ACCOUNT_V1 = "/v1/settle_accounts";

        /// <summary>
        /// 查询结算账户
        /// </summary>
        public const string QUERY_SETTLE_ACCOUNT_V1 = "/v1/settle_accounts/";

        /// <summary>
        /// 删除结算账户
        /// </summary>
        public const string DELETE_SETTLE_ACCOUNT_V1 = "/v1/settle_accounts/delete";

        /// <summary>
        /// 修改结算账户
        /// </summary>
        public const string MODIFY_SETTLE_ACCOUNT_V1 = "/v1/settle_accounts/modify";

        /// <summary>
        /// 查询结算明细列表
        /// </summary>
        public const string QUERY_SETTLE_DETAILS_V1 = "/v1/settle_accounts/settle_details";
        #endregion

        #region 支付转账对象
        /// <summary>
        /// 创建转账对象
        /// </summary>
        public const string CREATE_TRANSFER = "/v1/settle_accounts/transfer";

        /// <summary>
        /// 查询转账对象列表
        /// </summary>
        public const string TRANSFER_LIST = "/v1/settle_accounts/transfer/list";
        #endregion

        #region 账户冻结对象
        /// <summary>
        /// 创建账户冻结对象
        /// </summary>
        public const string FREEZE_ACCOUNT_CREATE = "/v1/settle_accounts/freeze";

        /// <summary>
        /// 查询账户冻结对象列表
        /// </summary>
        public const string FREEZE_ACCOUNT_LIST = "/v1/settle_accounts/freeze/list";
        #endregion

        #region 账户解冻对象
        /// <summary>
        /// 创建账户解冻对象
        /// </summary>
        public const string UN_FREEZE_ACCOUNT_CREATE = "/v1/settle_accounts/un_freeze";

        /// <summary>
        /// 查询账户解冻对象列表
        /// </summary>
        public const string UN_FREEZE_ACCOUNT_LIST = "/v1/settle_accounts/unfreeze/list";
        #endregion

        #region 银行卡对象
        /// <summary>
        /// 快捷支付绑卡创建
        /// </summary>
        public const string FAST_PAY_CARD_BIND = "/v1/fast_card/apply";

        /// <summary>
        /// 快捷支付绑卡确认
        /// </summary>
        public const string FAST_PAY_CARD_BIND_CONFIRM = "/v1/fast_card/confirm";

        /// <summary>
        /// 快捷支付绑卡列表查询
        /// </summary>
        public const string FAST_PAY_CARD_BIND_LIST = "/v1/fast_card/list";
        #endregion

        #region 钱包
        /// <summary>
        /// 帐户取现创建
        /// </summary>
        public const string DRAW_CASH = "/v1/cashs";

        /// <summary>
        /// 查询取现状态
        /// </summary>
        public const string QUERY_CASHS_STAT_V1 = "/v1/cashs/stat";

        /// <summary>
        /// 查询帐户余额
        /// </summary>
        public const string QUERY_BALANCE = "/v1/settle_accounts/balance";

        /// <summary>
        /// 钱包用户登录
        /// </summary>
        public const string WALLET_LOGIN = "/v1/walletLogin";

        /// <summary>
        /// 钱包账户支付
        /// </summary>
        public const string CREATE_ACCOUNT_PAYMENT = "/v1/account/payment";

        /// <summary>
        /// 创建收银台对象
        /// </summary>
        public const string CREATE_CHECK_OUT = "/v1/checkout";

        /// <summary>
        /// 查询收银台对象列表
        /// </summary>
        public const string LIST_CHECK_OUT = "/v1/checkout/list";

        /// <summary>
        /// DOWNLOAD BILL
        /// </summary>
        public const string BILL_DOWNLOAD_V1 = "/v1/bill/download";


        /// <summary>
        /// 获取银联云闪付用户标识
        /// </summary>
        public const string UNION_USER_ID_V1 = "/v1/union/user_identity";

        /// <summary>
        /// 创建服务商分账对象
        /// </summary>
        public const string COMMISSIONS_SETTLE = "/v1/settle_accounts/commissions";

        /// <summary>
        /// 服务商分账对象列表
        /// </summary>
        public const string LIST_COMMISSIONS_SETTLE = "/v1/settle_accounts/commissions/list"; 
        #endregion
    }
}
