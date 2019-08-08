using System;
using System.Web;
using Telerik.Web.UI.PersistenceFramework;

namespace CIB.PhoneBook.UI.Web.Utilities
{
    public class SessionStorageProvider : IStateStorageProvider
    {
        private System.Web.SessionState.HttpSessionState session = HttpContext.Current.Session;
        string storageKey;

        public SessionStorageProvider(string key)
        {
            storageKey = key;
        }

        public void SaveStateToStorage(string key, string serializedState)
        {
            session[storageKey] = serializedState;
        }

        public string LoadStateFromStorage(string key)
        {
            if (session[key] == null)
            {
                return String.Empty;
            }
            return session[key].ToString();
        }
    }
}