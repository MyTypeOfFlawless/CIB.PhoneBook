using System.ComponentModel;
using System.Runtime.Serialization;

namespace MotovateOnTheMove.Shared.CodeLibrary.Enums
{
    [DataContract(Namespace = "MotovateOnTheMove.Shared.CodeLibrary.Enums", Name = "ValidationErrorEnum")]
    public enum ValidationErrorEnum
    {
        [Description("Format is not valid"), EnumMember(Value = "InvalidFormat")]
        InvalidFormat = 0,
        [Description("Field is mandatory"), EnumMember(Value = "MandatoryField")]
        MandatoryField =1
    }
}
