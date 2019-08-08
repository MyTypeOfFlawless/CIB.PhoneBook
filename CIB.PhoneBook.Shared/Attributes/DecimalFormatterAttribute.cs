using System;

namespace CIB.PhoneBook.Shared.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]

    public class DecimalFormatterAttribute : Attribute
    {
        public DecimalFormatterAttribute(string formatString)
        {
            Format = formatString;
        }

        public string Format { get; private set; }
    }
}
