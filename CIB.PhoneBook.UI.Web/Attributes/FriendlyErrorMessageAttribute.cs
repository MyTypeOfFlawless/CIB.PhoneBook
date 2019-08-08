using System;

namespace CIB.PhoneBook.UI.Web.Attributes
{
    public class FriendlyErrorMessageAttribute : Attribute
    {
        public string FriendlyErrorMessage;

        [Help(@"For use in the Error properties for Response types.  This is the error message to be displayed to the end user.")]
        public FriendlyErrorMessageAttribute(string friendlyErrorMessage)
        {
            FriendlyErrorMessage = friendlyErrorMessage;
        }
    }
}
