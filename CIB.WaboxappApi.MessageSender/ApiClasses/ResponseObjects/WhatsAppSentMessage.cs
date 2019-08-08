using System;
using System.Runtime.Serialization;

namespace CIB.WaboxappApi.MessageSender.ApiClasses.ResponseObjects
{
    [DataContract(Namespace = "MotovateOntheMove.WaboxappApi.MessageSender.ApiClasses.ResponseObjects", Name = "WhatsAppWebsiteSentMessage")]
    [KnownType(typeof(WhatsAppWebsiteSentMessage))]
    public class WhatsAppWebsiteSentMessage
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION 
        ////ECC/ END CUSTOM CODE SECTION 
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int IdContact { get; set; }
        [DataMember]
        public string CustomUid { get; set; }
        [DataMember]
        public bool IsSuccess { get; set; }
        [DataMember]
        public string MessageType { get; set; }
        [DataMember]
        public string Token { get; set; }
        [DataMember]
        public string SenderMobile { get; set; }
        [DataMember]
        public string ReceiverMobile { get; set; }
        [DataMember]
        public Nullable<int> IdSentChat { get; set; }
        [DataMember]
        public Nullable<int> IdSentImage { get; set; }
        [DataMember]
        public Nullable<int> IdSentLink { get; set; }
        [DataMember]
        public Nullable<int> IdSentMedia { get; set; }
        [DataMember]
        public Nullable<bool> Success { get; set; }
        [DataMember]
        public int WhatsAppWebsiteSentChatId { get; set; }
        [DataMember]
        public string WhatsAppWebsiteSentChatText { get; set; }
        [DataMember]
        public int WhatsAppWebsiteSentImageId { get; set; }
        [DataMember]
        public string WhatsAppWebsiteSentImageUrl { get; set; }
        [DataMember]
        public string WhatsAppWebsiteSentImageCaption { get; set; }
        [DataMember]
        public string WhatsAppWebsiteSentImageDescription { get; set; }
        [DataMember]
        public int WhatsAppWebsiteSentLinkId { get; set; }
        [DataMember]
        public string WhatsAppWebsiteSentLinkUrl { get; set; }
        [DataMember]
        public string WhatsAppWebsiteSentLinkCaption { get; set; }
        [DataMember]
        public string WhatsAppWebsiteSentLinkDescription { get; set; }
        [DataMember]
        public string WhatsAppWebsiteSentLinkThumbnailUrl { get; set; }
        [DataMember]
        public int WhatsAppWebsiteSentMediaId { get; set; }
        [DataMember]
        public string WhatsAppWebsiteSentMediaUrl { get; set; }
        [DataMember]
        public string WhatsAppWebsiteSentMediaCaption { get; set; }
        [DataMember]
        public string WhatsAppWebsiteSentMediaDescription { get; set; }
        [DataMember]
        public string WhatsAppWebsiteSentMediaThumbnailUrl { get; set; }
    }
}
