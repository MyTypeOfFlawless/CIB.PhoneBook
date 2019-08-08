using System.Web;
using System.Web.UI;
using Telerik.Web.UI;

namespace CIB.PhoneBook.UI.Web.Utilities
{
    public static class GridStateManager
    {

        private const string PageSizeKey = @"GridPageSize";

        public static void SaveState(Page page, RadGrid grid)
        {
            if (grid == null) return;

            if (HttpContext.Current.Session != null)
            {
                var key = $@"{PageSizeKey}";
                var pageSize = grid.PageSize;
                HttpContext.Current.Session[key] = pageSize;
            }
        }

        public static void LoadState(Page page, RadGrid grid)
        {
            if (grid == null) return;

            if (HttpContext.Current.Session != null)
            {
                var key = $@"{PageSizeKey}";
                var oPageSize = HttpContext.Current.Session[key];
                if (oPageSize != null)
                {
                    grid.PageSize = (int)oPageSize;
                }
            }
        }


    }
}