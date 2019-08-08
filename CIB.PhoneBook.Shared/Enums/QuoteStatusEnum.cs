using System.ComponentModel;
using System.Runtime.Serialization;
using MotovateOnTheMove.Shared.CodeLibrary.Attributes;

namespace MotovateOnTheMove.Shared.CodeLibrary.Enums
{
    [Help(@"string quoteStatus = QuoteStatus.Description();"), DataContract(Namespace = "MotovateOnTheMove.Shared.CodeLibrary.Enums", Name = "QuoteStatusEnum")]
    public enum QuoteStatusEnum
    {
        [Description("DRAFT"), EnumMember(Value = "Draft")]
        Draft = 0,
        [Description("QUOTE SAVED"), EnumMember(Value = "QuoteSaved")]
        QuoteSaved = 1,
        [Description("QUOTE PRINTED"), EnumMember(Value = "QuotePrinted")]
        QuotePrinted = 2,
        [Description("FIN MANAGER APPROVAL"), EnumMember(Value = "FAndIApprovalRequired")]
        FAndIApprovalRequired = 3,
        [Description("APPLIED FOR FINANCE"), EnumMember(Value = "AppliedForFinance")]
        AppliedForFinance = 4,
        [Description("OTP PRINTED"), EnumMember(Value = "OtpPrinted")]
        OtpPrinted = 5,
        [Description("OTP SIGNED"), EnumMember(Value = "OtpSigned")]
        OtpSigned = 6,
        [Description("INVOICED"), EnumMember(Value = "Invoiced")]
        Invoiced = 7,
        [Description("DELIVERED"), EnumMember(Value = "VehicleDelivered")]
        VehicleDelivered = 8,
        [Description("ACTUALLY DELIVERED"), EnumMember(Value = "ActuallyDelivered")]
        ActuallyDelivered = 9,
        [Description("CANCELLED"), EnumMember(Value = "DealCancelled")]
        DealCancelled = 10,
        [Description("OTP ACCEPTED"), EnumMember(Value = "OtpAccepted")]
        OtpAccepted = 11,
        [Description("SENT FOR INVOICING"), EnumMember(Value = "SentForInvoicing")]
        SentForInvoicing = 12,
        [Description("SEND FOR INVOICING REJECTED"), EnumMember(Value = "SendForInvoicingRejected")]
        SendForInvoicingRejected = 13,
        [Description("SEND FOR INVOICING APPROVED"), EnumMember(Value = "SendForInvoicingApproved")]
        SendForInvoicingApproved = 14
    }
}
