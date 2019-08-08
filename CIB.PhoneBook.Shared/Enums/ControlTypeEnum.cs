using System.Runtime.Serialization;

namespace MotovateOnTheMove.Shared.CodeLibrary.Enums
{
    [DataContract(Namespace = "MotovateOnTheMove.Shared.CodeLibrary.Enums", Name = "ControlTypeEnum")]
    public enum ControlTypeEnum
    {
        [EnumMember(Value = "TextBox")]
        TextBox = 1,
        [EnumMember(Value = "DropDownList")]
        DropDownList = 2,
    }
}
