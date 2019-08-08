using System;
using System.Web;
using CIB.PhoneBook.Shared.BaseClasses;
using Elmah;


namespace CIB.PhoneBook.Shared.Utilities
{
    public class ElmahLogger
    {
        public void LogException(Exception ex, RequestBase requestBase)
        {
            try
            {
                var context = HttpContext.Current;
                if (context == null)
                    return;
                var signal = ErrorSignal.FromContext(context);
                if (signal == null)
                    return;
                signal.Raise(ex);
            }
            catch (Exception)
            {
                //new ErrorHandler(ApiLogPath).HandleError(ex, requestBase);
            }
        }

        
        
    }
}
