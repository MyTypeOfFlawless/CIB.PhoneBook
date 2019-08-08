using System.ComponentModel;
using System.Runtime.Serialization;
using CIB.PhoneBook.Shared.Attributes;

namespace CIB.PhoneBook.Shared.Enums
{
    [Help(@"string verbDescription = HttpVerbEnum.Description();"), DataContract(Namespace = "CIB.PhoneBook.Shared.Enums", Name = "HttpVerbEnum")]
    public enum HttpVerbEnum
    {
        [Description("GET"), EnumMember(Value = "GET")]
        GET = 0,
        [Description("POST"), EnumMember(Value = "POST")]
        POST = 1,
        [Description("PUT"), EnumMember(Value = "PUT")]
        PUT = 2,
        [Description("DELETE"), EnumMember(Value = "DELETE")]
        DELETE = 3

    }
}
