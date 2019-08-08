using System.Runtime.Serialization;
using CIB.PhoneBook.Shared.BaseClasses;

namespace CIB.WaboxappApi.MessageSender.ApiClasses.ResponseObjects
{
    [DataContract(Namespace = "CIB.WaboxappApi.MessageSender.ApiClasses.ResponseObjects", Name = "SendWhatsAppMessageResponse")]
    [KnownType(typeof(SendWhatsAppMessageResponse))]
    [KnownType(typeof(IResponseBase))]
    public class SendWhatsAppMessageResponse : ResponseBase, IResponseBase
    {
        [DataMember]
        public WhatsAppWebsiteSentMessage WhatsAppWebsiteSentMessage { get; set; }
    }
}
