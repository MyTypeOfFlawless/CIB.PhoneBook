using System;

namespace CIB.PhoneBook.UI.Web.Attributes
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
