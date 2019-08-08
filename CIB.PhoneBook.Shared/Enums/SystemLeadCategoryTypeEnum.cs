using System.ComponentModel;
using System.Runtime.Serialization;
using MotovateOnTheMove.Shared.CodeLibrary.Attributes;

namespace MotovateOnTheMove.Shared.CodeLibrary.Enums
{
    [Help(@"string taskStatus = status.Description();"), DataContract(Name = "SystemLeadCategoryTypeEnum", Namespace = "MotovateOnTheMove.Shared.CodeLibrary.Enums")]
    public enum SystemLeadCategoryTypeEnum
    {
        [Description("Lead created from a new contact"), EnumMember(Value = "ContactCreated")]
        ContactCreated = 0,
        [Description("Lead created from a test drive"), EnumMember(Value = "TestDriveBooked")]
        TestDriveBooked = 1,
        [Description("Lead created from an appraisal"), EnumMember(Value = "VehicleAppraised")]
        VehicleAppraised = 2,
        [Description("Lead created from a quote"), EnumMember(Value = "Quoted")]
        Quoted = 3,
    }
}
