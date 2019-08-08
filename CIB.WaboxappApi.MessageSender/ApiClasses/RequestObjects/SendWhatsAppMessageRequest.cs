using System.Runtime.Serialization;
using CIB.PhoneBook.Shared.BaseClasses;
using CIB.WaboxappApi.MessageSender.ApiClasses.ResponseObjects;

namespace CIB.WaboxappApi.MessageSender.ApiClasses.RequestObjects
{
    [DataContract(Namespace = "CIB.WaboxappApi.MessageSender.ApiClasses.RequestObjects", Name = "SendWhatsAppMessageRequest")]
    [KnownType(typeof(SendWhatsAppMessageRequest))]
    [KnownType(typeof(RequestBase))]
    public class SendWhatsAppMessageRequest : RequestBase
    {
        public SendWhatsAppMessageRequest()
        {
            RequestBase = this.GetBase();
        }

        [DataMember]
        public RequestBase RequestBase { get; set; }
        [DataMember]
        public string WhatsAppUid { get; set; }

        [DataMember]
        public string WhatsAppApiToken { get; set; }

        [DataMember]
        public string CustomUniqueId { get; set; }

        [DataMember]
        public int IdContact { get; set; }

        [DataMember]
        public WhatsAppWebsiteSentMessage Message { get; set; }
    }
}
