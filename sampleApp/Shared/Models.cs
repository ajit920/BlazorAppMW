using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace sampleApp.Shared
{


    public class BillingAccountRequest
    {
        public object billingAccountCustomData { get; set; }
        public bool includePaymentHistory { get; set; }
        public bool includeFundingAccounts { get; set; }
        public bool includeScheduledPayments { get; set; }
        public bool includeRecurringRegistrations { get; set; }
        public bool includeAutoPayRegistrations { get; set; }
    }

    public class AutoPayRegistration
    {
        public string billingAccount { get; set; }
        public string billingSubAccount { get; set; }
        public string status { get; set; }
        public string referenceId { get; set; }
        public string referenceCode { get; set; }
        public string emailAddress { get; set; }
        public DateTime addDate { get; set; }
        public DateTime lastUpdatedDate { get; set; }
        public FundingAccount fundingAccount { get; set; }
        public List<PaymentCustomList> paymentCustomList { get; set; }
        public bool doNotPayOverMaxAmount { get; set; }
        public string autoPaymentDatePreference { get; set; }
    }

    public class BalancePresentment
    {
        public DateTime dueDate { get; set; }
        public double currentDue { get; set; }
        public double balanceDue { get; set; }
        public double pastDue { get; set; }
    }

    public class BillingAccountAcceptanceResponse
    {
        public bool tooManyPayments { get; set; }
        public bool tooManyAttempts { get; set; }
        public bool hasBlockingSourceDetails { get; set; }
        public bool isAccountAcceptable { get; set; }
        public List<object> blockingSourceDetails { get; set; }
        public BlockingResult blockingResult { get; set; }
    }

    public class BillingAccountDetail
    {
        public BillingAccountLookupResponse billingAccountLookupResponse { get; set; }
        public BillingAccountAcceptanceResponse billingAccountAcceptanceResponse { get; set; }
    }

    public class BillingAccountLookupResponse
    {
        public string billingAccount { get; set; }
        public PresentmentData presentmentData { get; set; }
        public bool isAccountFound { get; set; }
        public List<BillingSubAccountDetail> billingSubAccountDetails { get; set; }
    }

    public class BillingAccountPresentmentDetail
    {
    }

    public class BillingSubAccountDetail
    {
        public string billingSubAccount { get; set; }
        public string accountType { get; set; }
        public string accountDescription { get; set; }
        public PresentmentData presentmentData { get; set; }
    }

    public class BlockingResult
    {
        public bool isCheckPermitted { get; set; }
        public bool isCreditPermitted { get; set; }
        public bool isDebitPermitted { get; set; }
    }

    public class CustomPresentment
    {
        public string customDataName { get; set; }
        public string customDataValue { get; set; }
    }

    public class FundingAccount
    {
        public string fundingAccountToken { get; set; }
        public string fundingAccountLastFourDigit { get; set; }
        public string fundingMethod { get; set; }
        public string fundingCategory { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string bankName { get; set; }
        public string bankAccountType { get; set; }
        public string fundingAccountType { get; set; }
    }

    public class PaymentCustomList
    {
        public string customDataName { get; set; }
        public string customDataValue { get; set; }
    }

    public class PaymentHistory
    {
        public string billingAccount { get; set; }
        public string billingSubAccount { get; set; }
        public string fundingMethod { get; set; }
        public string fundingCategory { get; set; }
        public double paymentAmount { get; set; }
        public double feeAmount { get; set; }
        public DateTime paymentDate { get; set; }
        public string fundingAccountLastFourDigit { get; set; }
        public string confirmationCode { get; set; }
        public string paymentStatus { get; set; }
        public double depositAmount { get; set; }
        public string uiChannel { get; set; }
        public List<object> paymentCustomList { get; set; }
    }

    public class PresentmentData
    {
        public BalancePresentment balancePresentment { get; set; }
        public BillingAccountPresentmentDetail billingAccountPresentmentDetail { get; set; }
        public List<CustomPresentment> customPresentment { get; set; }
    }

    public class BillingAccountResponse
    {
        public Result result { get; set; }
        public BillingAccountDetail billingAccountDetail { get; set; }
        public List<PaymentHistory> paymentHistory { get; set; }
        public List<WalletFundingAccount> walletFundingAccounts { get; set; }
        public List<AutoPayRegistration> autoPayRegistrations { get; set; }
    }

    public class WalletFundingAccount
    {
        public string nickName { get; set; }
        public int displayOrder { get; set; }
        public string status { get; set; }
        public bool defaultFundingSourceFlag { get; set; }
        public string fundingAccountType { get; set; }
        public string fundingAccountToken { get; set; }
        public string fundingAccountLastFourDigit { get; set; }
        public string fundingMethod { get; set; }
        public string fundingCategory { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string bankName { get; set; }
        public string bankAccountType { get; set; }
    }
    public class FundingAccountAchRequest
    {
        public CheckDetail checkDetail { get; set; }
    }
    public class CheckDetail
    {
        public string routingNumber { get; set; }
        public string checkAccountNumber { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string checkAccountType { get; set; }
        public string fundingAccountType { get; set; }
    }
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class CheckValidationDetail
    {
        public string routingNumberState { get; set; }
        public string checkAccountValidationState { get; set; }
        public string fundingAccountType { get; set; }
        public bool isBlocked { get; set; }
        public bool isAccountValid { get; set; }
    }




    public class FundingAccountAchResponse
    {
        public Result result { get; set; }
        public FundingAccountValidationResult fundingAccountValidationResult { get; set; }
    }

    public class FundingAccountCardRequest
    {
        public CardDetail cardDetail { get; set; }
    }

    public class CardDetail
    {
        public string cardNumber { get; set; }
        public string expirationDate { get; set; }
        public string securityCode { get; set; }
        public string zipCode { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string nameOnCard { get; set; }
    }
    public class CardValidationDetail
    {
        public FundingMethodDetail fundingMethodDetail { get; set; }
        public string expirationDateState { get; set; }
        public string securityCodeValidationState { get; set; }
        public string zipCodeValidationState { get; set; }
        public bool isBlocked { get; set; }
        public bool isAccountValid { get; set; }
    }



    public class FundingAccountValidationResult
    {
        public string summaryValidationState { get; set; }
        public CardValidationDetail cardValidationDetail { get; set; }
        public FundingAccount fundingAccount { get; set; }
    }

    public class FundingMethodDetail
    {
        public string fundingCategory { get; set; }
        public string fundingMethod { get; set; }
        public string fundingCardType { get; set; }
    }


    public class FundingAccountCardResponse
    {
        public Result result { get; set; }
        public FundingAccountValidationResult fundingAccountValidationResult { get; set; }
    }


    public class PaymentRequest
    {
        public double paymentAmount { get; set; }
        public object paymentCustomList { get; set; }
        public bool addToWallet { get; set; }
        public string fundingAccountToken { get; set; }
        public int zipCode { get; set; }
        public object securityCode { get; set; }
        public string emailAddress { get; set; }
        public string transactionNote { get; set; }
        public bool allowDuplicatePayment { get; set; }
        public string paymentType { get; set; }
    }

    public class PaymentResponse
    {
        public Result result { get; set; }
        public string confirmationCode { get; set; }
        public string paymentAuthorizationStatus { get; set; }
        public string fundingMethod { get; set; }
        public DateTime paymentDateTimeStamp { get; set; }
        public string paymentAmountValidationState { get; set; }
        public DateTime reportDate { get; set; }
        public string paymentEventID { get; set; }
    }

    public class SessionTokenRequest
    {
        public string AgentId { get; set; }
        public string UserId { get; set; }
        public string BillingAccount { get; set; }

        [JsonProperty("billingSubAccount")]

        public string BillingSubAccount { get; set; }

        [JsonProperty("uiChannel")]
        public string UiChannel { get; set; }
        public string LobId { get; set; }
    }



    public class SessionTokenResponse
    {
        [JsonProperty("result")]
        public Result Result { get; set; }

        [JsonProperty("sessionToken")]
        public string SessionToken { get; set; }
    }

    public class Result
    {
        [JsonProperty("statusCode")]
        public string StatusCode { get; set; }

        [JsonProperty("statusMessages")]
        public List<StatusMessage> StatusMessages { get; set; }
    }

    public class StatusMessage
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}

