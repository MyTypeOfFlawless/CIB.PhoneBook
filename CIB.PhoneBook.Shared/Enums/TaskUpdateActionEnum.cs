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
    [Help(@"string taskStatus = status.Description();"), DataContract(Name = "TaskUpdateActionEnum",Namespace = "MotovateOnTheMove.Shared.CodeLibrary.Enums")]
    public enum TaskUpdateActionEnum
    {
        [Description("Client was called"), EnumMember(Value = "CallClient")]
        CallClient = 0,
        [Description("Client was emailed"), EnumMember(Value = "EmailClient")]
        EmailClient = 1,
        [Description("A meeting was rescheduled"), EnumMember(Value = "Reschedule")]
        Reschedule = 2,
        [Description("The client was called previously"), EnumMember(Value = "Phoned")]
        Phoned = 3,
        [Description("Client was emailed previously"), EnumMember(Value = "Emailed")]
        Emailed = 4,
        [Description("Other"), EnumMember(Value = "Other")]
        Other = 5
    }
}
