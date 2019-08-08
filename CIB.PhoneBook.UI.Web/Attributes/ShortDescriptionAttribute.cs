using System;

namespace CIB.PhoneBook.UI.Web.Attributes
{
    public class ShortDescriptionAttribute : Attribute
    {
        public string ShortDescription;

        [Help(@"For use in the DocumentType enum")]
        public ShortDescriptionAttribute(string shortDescription)
        {
            ShortDescription = shortDescription;
        }
    }
}
