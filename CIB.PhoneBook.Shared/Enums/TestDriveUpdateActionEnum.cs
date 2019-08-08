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
    [Help(@"string testDriveStatus = status.Description();"), DataContract(Name = "TestDriveUpdateActionEnum", Namespace = "MotovateOnTheMove.Shared.CodeLibrary.Enums")]
    public enum TestDriveUpdateActionEnum
    {
        [Description("Test Drive was approved"), EnumMember(Value = "Approved")]
        Approved = 0,
        [Description("Test Drive was cancelled"), EnumMember(Value = "Cancelled")]
        Cancelled = 1,
        [Description("Test Drive was rejected"), EnumMember(Value = "Rejected")]
        Rejected = 2,
        [Description("Test Drive was rescheduled"), EnumMember(Value = "Rescheduled")]
        Rescheduled = 3,
        [Description("Test Drive was completed"), EnumMember(Value = "Completed")]
        Completed = 4,
        [Description("Custom action was implemented on this Test Drive"), EnumMember(Value = "Other")]
        Other = 5
    }
}
