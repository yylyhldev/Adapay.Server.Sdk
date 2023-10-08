namespace AdapaySDK
{
    class ConfigConstant
    {
        public const string BASE_URL = "https://api.adapay.tech";

        public const string PAGE_SERVER_BASE_URL = "https://page.adapay.tech";

        public const string RSA_PUB_KEY = "MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCwN6xgd6Ad8v2hIIsQVnbt8a3JituR8o4Tc3B5WlcFR55bz4OMqrG/356Ur3cPbc2Fe8ArNd/0gZbC9q56Eb16JTkVNA/fye4SXznWxdyBPR7+guuJZHc/VW2fKH2lfZ2P3Tt0QkKZZoawYOGSMdIvO+WqK44updyax0ikK6JlNQIDAQAB";
        
    }

    class APIUrlEnum
    {

        // 支付对象（Payment）
        /**
         * 支付
         */
        public const string PAYMENT_V1 = "/v1/payments";
        /**
         * 支付查询
         */
        public const string QUERY_PAYMENT_V1 = "/v1/payments/";
        /**
         * 支付对象列表查询
         */
        public const string LIST_PAYMENT_V1 = "/v1/payments/list";
        /**
         * 关单
         */
        public const string CLOSE_PAYMENT_V1 = "/v1/payments/";
        /**
         * 快捷支付支付确认
         */
        public const string FAST_PAY_CONFIRM = "/v1/fast_pay/confirm";

        /**
         * 快捷支付短信重发 
         */
        public const string FAST_PAY_SMS_CODE = "/v1/fast_pay/sms_code";

        // 退款对象（Refund）
        /**
         * 退款
         */
        public const string REFUND_V1 = "/v1/payments/";
        /**
         * 退款查询
         */
        public const string QUERY_REFUND_V1 = "/v1/payments/refunds";

        // 支付确认对象（PaymentConfirm）
        
        /**
         * 支付确认
         */
        public const string CONFIRM_PAYMENT_V1 = "/v1/payments/confirm";

        /**
         * 支付确认查询
         */
        public const string QUERY_CONFIRM_PAYMENT_V1 = "/v1/payments/confirm/";

        /**
         * 支付确认列表查询
         */
        public const string CONFIRM_PAYMENT_LIST_V1 = "/v1/payments/confirm/list";

        // 支付撤销对象（PaymentConfirm）
        /**
         * 支付撤销
         */
        public const string REVERSE_PAYMENT_V1 = "/v1/payments/reverse";

        /**
         * 查询支付撤销
         */
        public const string QUERY_REVERSE_PAYMENT_V1 = "/v1/payments/reverse/";

        /**
         * 支付撤销列表查询
         */
        public const string REVERSE_PAYMENT_LIST_V1 = "/v1/payments/reverse/list";


        // 个人用户（Member）
        /**
         * 创建用户
         */
        public const string MEMBER_V1 = "/v1/members";

        /**
         * 查询用户对象
         */
        public const string QUERY_MEMBER_V1 = "/v1/members/";

        /**
         * 查询用户列表
         */
        public const string QUERY_MEMBER_LIST_V1 = "/v1/members/list";
        /**
         * 更新用户
         */
        public const string UPDATE_MEMBER_V1 = "/v1/members/update";

        // 企业用户（CorpMember）
        /**
         * 创建企业用户对象
         */
        public const string CORP_MEMBER_V1 = "/v1/corp_members";

        /**
         * 查询企业用户对象
         */
        public const string QUERY_CORP_MEMBER_V1 = "/v1/corp_members/";


        // 结算账户（SettleAccount）
        /**
         * 创建结算账户
         */
        public const string SETTLE_ACCOUNT_V1 = "/v1/settle_accounts";

        /**
         * 查询结算账户
         */
        public const string QUERY_SETTLE_ACCOUNT_V1 = "/v1/settle_accounts/";
        /**
         * 删除结算账户
         */
        public const string DELETE_SETTLE_ACCOUNT_V1 = "/v1/settle_accounts/delete";

        /**
         * 修改结算账户
         */
        public const string MODIFY_SETTLE_ACCOUNT_V1 = "/v1/settle_accounts/modify";
        
        /**
         * 查询结算明细列表
         */
        public const string QUERY_SETTLE_DETAILS_V1 = "/v1/settle_accounts/settle_details";

        // 支付转账对象
        
        /**
         * 创建转账对象
         */
        public const string  CREATE_TRANSFER= "/v1/settle_accounts/transfer";

        /**
         * 查询转账对象列表
         */
        public const string TRANSFER_LIST = "/v1/settle_accounts/transfer/list";

        // 账户冻结对象
        /**
         * 创建账户冻结对象
         */
        public const string FREEZE_ACCOUNT_CREATE = "/v1/settle_accounts/freeze";

        /**
         * 查询账户冻结对象列表
         */
        public const string FREEZE_ACCOUNT_LIST = "/v1/settle_accounts/freeze/list";


        // 账户解冻对象
        /**
         * 创建账户解冻对象
         */
        public const string UN_FREEZE_ACCOUNT_CREATE = "/v1/settle_accounts/un_freeze";

        /**
         * 查询账户解冻对象列表
         */
        public const string UN_FREEZE_ACCOUNT_LIST = "/v1/settle_accounts/unfreeze/list";

        // 银行卡对象
        /**
         * 快捷支付绑卡创建 
         */
        public const string FAST_PAY_CARD_BIND = "/v1/fast_card/apply";

        /**
         * 快捷支付绑卡确认
         */
        public const string FAST_PAY_CARD_BIND_CONFIRM = "/v1/fast_card/confirm";

        /**
         * 快捷支付绑卡列表查询
         */
        public const string FAST_PAY_CARD_BIND_LIST = "/v1/fast_card/list";

        // 钱包
        /**
         * 帐户取现创建 
         */
        public const string DRAW_CASH = "/v1/cashs";

        /**
         * 查询取现状态
         */
        public const string QUERY_CASHS_STAT_V1 = "/v1/cashs/stat";

        /**
         * 查询帐户余额 
         */
        public const string QUERY_BALANCE = "/v1/settle_accounts/balance";

        /**
         * 钱包用户登录 
         */
        public const string WALLET_LOGIN = "/v1/walletLogin";
        
        /**
         * 钱包账户支付 
         */
        public const string CREATE_ACCOUNT_PAYMENT = "/v1/account/payment";

        

        /**
         * 创建收银台对象
         */
        public const string CREATE_CHECK_OUT = "/v1/checkout";

        /**
         * 查询收银台对象列表
         */
        public const string LIST_CHECK_OUT = "/v1/checkout/list";


        






        /**
         * DOWNLOAD BILL
         */
        public const string BILL_DOWNLOAD_V1 = "/v1/bill/download";


        /**
         * 获取银联云闪付用户标识 
         */
        public const string UNION_USER_ID_V1 = "/v1/union/user_identity";



        

        /**
         * 创建服务商分账对象 
         */
        public const string COMMISSIONS_SETTLE = "/v1/settle_accounts/commissions";

        /**
         * 服务商分账对象列表
         */
        public const string LIST_COMMISSIONS_SETTLE = "/v1/settle_accounts/commissions/list";




    }
}
