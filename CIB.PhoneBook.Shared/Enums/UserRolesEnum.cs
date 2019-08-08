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
    [Help(@"string contactAction = ContactActionsEnum.Description();"), DataContract(Namespace = "MotovateOnTheMove.Shared.CodeLibrary.Enums", Name = "UserRolesEnum")]
    public enum UserRolesEnum
    {
        [Description("Finance person at the dealership"), EnumMember(Value = "FinancePerson"), ShortDescription("FNIMEM")]
        FinancePerson = 0,
        [Description("Sales Executive"), EnumMember(Value = "SalesExecutive"), ShortDescription("SALEXE")]
        SalesExecutive = 1,
        [Description("Dealer Principle"), EnumMember(Value = "DealerPrinciple"), ShortDescription("DEAPRI")]
        DealerPrinciple = 2,
        [Description("Sales Manager"), EnumMember(Value = "SalesManager"), ShortDescription("SALMAN")]
        SalesManager = 3,
    }
}
