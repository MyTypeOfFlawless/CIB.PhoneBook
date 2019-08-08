using System;

namespace CIB.PhoneBook.Shared.Attributes
{
    public class XslNameAttribute : Attribute
    {
        public string XslName;
        public XslNameAttribute(string xslName)
        {
            XslName = xslName;
        }
    }
}
