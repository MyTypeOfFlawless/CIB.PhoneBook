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
    [Help(@"string quoteStatus = QuoteStatus.Description();"), 
        DataContract(Namespace = "MotovateOnTheMove.Shared.CodeLibrary.Enums", Name = "QuoteActionsEnum")]
    public enum QuoteActionsEnum
    {
        [Description("Send to FandI"), EnumMember(Value = "SendToFinance")]
        SendToFinance = 0,
        [Description("Physically deliver vehicle to customer"), EnumMember(Value = "DeliverVehicle")]
        DeliverVehicle = 1,
    }
}
