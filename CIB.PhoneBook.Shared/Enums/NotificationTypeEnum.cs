using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MotovateOnTheMove.Shared.CodeLibrary.Enums
{
    [DataContract(Namespace = "MotovateOnTheMove.Shared.CodeLibrary.Enums", Name = "NotificationTypeEnum")]
    public enum NotificationTypeEnum
    {
        [Description("New Lead Created"), EnumMember(Value = "NewLeadCreated")]
        NewLeadCreated = 0,
        [Description("Electronic Document Status Changed"), EnumMember(Value = "ElectronicDocumentStatusChanged")]
        ElectronicDocumentStatusChanged = 1,
    }
}
