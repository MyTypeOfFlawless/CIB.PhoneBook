using System;
using CIB.PhoneBook.Shared.BaseClasses;
using CIB.PhoneBook.Shared.Enums;
using CIB.WaboxappApi.MessageSender.ApiClasses.Models;
using CIB.WaboxappApi.MessageSender.ApiClasses.RequestObjects;
using CIB.WaboxappApi.MessageSender.ApiClasses.ResponseObjects;
using RestSharp;

namespace CIB.WaboxappApi.MessageSender
{
    public class WhatsAppMessageSender : ApiBase
    {
        //todo: put these in the web.config
        private const string WhatsAppChatUrl = "https://www.waboxapp.com/api/send/chat";
        private const string WhatsAppImageUrl = "https://www.waboxapp.com/api/send/image";
        private const string WhatsAppLinkUrl = "https://www.waboxapp.com/api/send/link";
        private const string WhatsAppMediaUrl = "https://www.waboxapp.com/api/send/media";

        

        public SendWhatsAppMessageResponse SendMessage(SendWhatsAppMessageRequest request)
        {
            var response = new SendWhatsAppMessageResponse {IsSuccess = false};

            string sendResponse = "";
            try
            {
                var type = request.Message.MessageType.ToString();
                if (type == "image")
                {
                    sendResponse = DoWebRequest(WhatsAppImageUrl, "POST", Newtonsoft.Json.JsonConvert.SerializeObject(
                        new image
                        {
                            custom_uid = request.CustomUniqueId,
                            to = request.Message.ReceiverMobile,
                            token = request.WhatsAppApiToken,
                            uid = request.WhatsAppUid,
                            url = request.Message.WhatsAppWebsiteSentImageUrl,
                            description = request.Message.WhatsAppWebsiteSentImageDescription,
                            caption = request.Message.WhatsAppWebsiteSentImageCaption
                        }));
                }
                else if (type == "media")
                {
                    sendResponse = DoWebRequest(WhatsAppMediaUrl, "POST", Newtonsoft.Json.JsonConvert.SerializeObject(
                        new media
                        {
                            custom_uid = request.CustomUniqueId,
                            to = request.Message.ReceiverMobile,
                            token = request.WhatsAppApiToken,
                            uid = request.WhatsAppUid,
                            caption = request.Message.WhatsAppWebsiteSentMediaCaption,
                            description = request.Message.WhatsAppWebsiteSentMediaDescription,
                            url = request.Message.WhatsAppWebsiteSentMediaUrl,
                            url_thumb = request.Message.WhatsAppWebsiteSentMediaThumbnailUrl,
                        }));
                }
                else if (type == "link")
                {
                    sendResponse = DoWebRequest(WhatsAppLinkUrl, "POST", Newtonsoft.Json.JsonConvert.SerializeObject(
                        new link
                        {
                            custom_uid = request.CustomUniqueId,
                            to = request.Message.ReceiverMobile,
                            token = request.WhatsAppApiToken,
                            uid = request.WhatsAppUid,
                            url = request.Message.WhatsAppWebsiteSentLinkUrl,
                            description = request.Message.WhatsAppWebsiteSentLinkDescription,
                            caption = request.Message.WhatsAppWebsiteSentLinkCaption,
                            url_thumb = request.Message.WhatsAppWebsiteSentLinkThumbnailUrl
                        }));
                }
                else if (type == "chat")
                {
                    sendResponse = DoWebRequest(WhatsAppChatUrl, "POST", Newtonsoft.Json.JsonConvert.SerializeObject(
                        new chat
                        {
                            custom_uid = request.CustomUniqueId,
                            text = request.Message.WhatsAppWebsiteSentChatText,
                            to = request.Message.ReceiverMobile,
                            token = request.WhatsAppApiToken,
                            uid = request.WhatsAppUid,
                        }));
                }

                var chatResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<response>(sendResponse);

                if (chatResponse == null)
                {
                    response.IsSuccess = false;
                    response.LocalErrorCode = (int)ErrorsEnum.WhatsAppBlocked;
                    //response.FriendlyErrorMessage = ErrorsEnum.WhatsAppBlocked.FriendlyErrorMessage();
                    return response;
                }

                if (string.IsNullOrWhiteSpace(chatResponse.success))
                {
                    response.IsSuccess = false;
                    response.LocalErrorCode = (int)ErrorsEnum.WhatsAppReturnedCustomError;
                    response.FriendlyErrorMessage = chatResponse.error;
                    return response;
                }

                if (chatResponse.success == "true")
                {
                    response.IsSuccess = true;
                    response.WhatsAppWebsiteSentMessage = request.Message;
                    return response;
                }

                if(chatResponse.code?.Contains("403") != null)
                {
                    response.IsSuccess = false;
                    response.LocalErrorCode = (int)ErrorsEnum.WhatsAppAuthenticationFailed;
                    //response.FriendlyErrorMessage = ErrorsEnum.WhatsAppAuthenticationFailed.FriendlyErrorMessage();
                    return response;
                }

                if (chatResponse.code?.Contains("400") != null)
                {
                    response.IsSuccess = false;
                    response.LocalErrorCode = (int)ErrorsEnum.WhatsAppParametersValidationFailed;
                    //response.FriendlyErrorMessage = ErrorsEnum.WhatsAppParametersValidationFailed.FriendlyErrorMessage();
                    return response;
                }

                return response;
            }
            catch (Exception ex)
            {
                //new ErrorHandler(ApiBase.ApiLogPath).HandleError(ex, request.RequestBase);
                response.IsSuccess = false;
                response.LocalErrorCode = (int)ErrorsEnum.ExceptionEncountered;
                //response.FriendlyErrorMessage = ErrorsEnum.ExceptionEncountered.FriendlyErrorMessage();
                return response;
            }
        }

        

        private string DoWebRequest(string url, string method, string POSTdata)
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", POSTdata, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public WhatsAppMessageSender(string virtualDirectory) : base(virtualDirectory)
        {
        }
    }
}
