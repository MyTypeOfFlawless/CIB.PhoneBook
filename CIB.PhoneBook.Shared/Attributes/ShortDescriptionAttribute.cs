using System;

namespace CIB.PhoneBook.Shared.Attributes
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
