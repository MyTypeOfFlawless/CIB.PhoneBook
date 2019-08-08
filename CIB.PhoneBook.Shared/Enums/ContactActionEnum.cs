using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using MotovateOnTheMove.Shared.CodeLibrary.Attributes;

namespace MotovateOnTheMove.Shared.CodeLibrary.Enums
{
    [Help(@"string contactAction = ContactActionsEnum.Description();"), DataContract(Namespace = "MotovateOnTheMove.Shared.CodeLibrary.Enums", Name = "ContactActionsEnum")]
    public enum ContactActionEnum
    {
        [Description("Contact Created"), EnumMember(Value = "ContactCreated")]
        ContactCreated = 0,
    }
}
