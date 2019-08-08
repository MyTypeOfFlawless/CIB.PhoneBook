namespace CIB.PhoneBook.Shared.Utilities
{
    /*public class LoggingUtility
    {
        public string LogFilePath { get; set; }

        public LoggingUtility(string logFilePath)
        {
            LogFilePath = logFilePath;
        }

        public void LogException(WebException exc, string source, string method)
        {
            using (StreamWriter sb = File.AppendText(LogFilePath + "ErrorLog.txt"))
            {
                sb.WriteLine();
                sb.WriteLine($"********** {DateTime.Now} **********");
                sb.WriteLine("Exception Encountered");
                sb.WriteLine("HttpRequest.Url: ");
                sb.WriteLine(exc.RequestUrl);
                sb.WriteLine("ToUrl: ");
                sb.WriteLine(exc.Host);
                sb.WriteLine("Logged in User name: ");
                sb.WriteLine(exc.Username);
                sb.WriteLine("Dealer name: ");
                sb.WriteLine(exc.DealerName);
                sb.WriteLine("Exception Type: ");
                sb.WriteLine(exc.ExceptionType);
                sb.WriteLine("Exception: " + exc.ExceptionMessage);
                sb.WriteLine("Source: " + source);
                sb.WriteLine("Method: " + method);
                sb.WriteLine("Stack Trace: ");
                sb.WriteLine(exc.StackTrace);
                sb.WriteLine();
                sb.WriteLine("Inner Exception Type: ");
                sb.WriteLine(exc.InnerExceptionType);
                sb.WriteLine("Inner Exception: ");
                sb.WriteLine(exc.InnerExceptionMessage);
                sb.WriteLine("Inner Source: ");
                sb.WriteLine(exc.InnerExceptionSource);
                sb.WriteLine("Inner Stack Trace: ");
                sb.WriteLine(exc.InnerExceptionStackTrace);
            }
        }


        public void LogMessage(string subject, string body, string source = "", string method = "")
        {
            using (StreamWriter sb = File.AppendText(LogFilePath + "RxTx.txt"))
            {
                sb.WriteLine();
                sb.WriteLine($"********** {DateTime.Now} **********");
                sb.WriteLine(subject);
                //sb.WriteLine("From.Url: ");
                //sb.WriteLine(SentFromUrl);
                sb.WriteLine("Request.Url: ");
                //sb.WriteLine(request.Host);
                sb.WriteLine("Logged in User name: ");
                //sb.WriteLine(request.LocalUsername);
                //sb.WriteLine("Dealer name: ");
                //sb.WriteLine(request.LocalDealerName);
                sb.WriteLine("Source: " + source);
                sb.WriteLine("Method: " + method);
                sb.WriteLine("Message: ");
                sb.WriteLine(body);
            }
        }

    }*/
}
