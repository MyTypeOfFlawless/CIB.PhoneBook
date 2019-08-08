using System;

namespace CIB.PhoneBook.UI.Web.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class HelpAttribute : Attribute
    {
        public readonly string Example;

        public string Topic
        { get; set; }

        public HelpAttribute(string example)
        {
            Example = example;
        }

        //[Author("Jane Programmer", Topic = 2), IsTested()]
    }
}
