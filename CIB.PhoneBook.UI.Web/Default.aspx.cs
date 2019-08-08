using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using CIB.PhoneBook.DAL.Dtos;
using CIB.PhoneBook.Shared.Extensions;
using CIB.PhoneBook.UI.Web.Extensions;
using CIB.PhoneBook.UI.Web.Utilities;
using CIB.Services.Wcf;
using Telerik.Web.UI;

namespace CIB.PhoneBook.UI.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            RadPersistenceManager1.StorageProvider = new SessionStorageProvider(RadPersistenceManager1.StorageProviderKey);
            GridFilterMenu filterMenu = RadGrid1.FilterMenu;
            int currentItemIndex = 0;
            while (currentItemIndex < filterMenu.Items.Count)
            {
                RadMenuItem item = filterMenu.Items[currentItemIndex];
                if (item.Text.Contains("Empty") || item.Text.Contains("Null"))
                {
                    filterMenu.Items.Remove(item);
                }
                else currentItemIndex++;
            }

            foreach (var control in btnGroup.Controls)
            {
                var button = control as HtmlButton;
                if (button != null)
                {
                    var ajaxSetting = new AjaxSetting(button.ID);
                    var gridItem = new AjaxUpdatedControl(RadGrid1.ID, null);
                    var activeItem = new AjaxUpdatedControl(hfActiveButtonId.ID, null);
                    var searchItem = new AjaxUpdatedControl(hfFilterButton.ID, null);
                    ajaxSetting.UpdatedControls.Add(gridItem);
                    ajaxSetting.UpdatedControls.Add(activeItem);
                    ajaxSetting.UpdatedControls.Add(searchItem);

                    foreach (var innerControl in btnGroup.Controls)
                    {
                        var innerButton = innerControl as HtmlButton;

                        if (innerButton != null)
                        {
                            var buttonItem = new AjaxUpdatedControl(innerButton.ID, null);
                            ajaxSetting.UpdatedControls.Add(buttonItem);
                        }
                    }

                    RadAjaxManager1.AjaxSettings.Add(ajaxSetting);
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                hfActiveButtonId.Value = "ButtonRecent";
                hfFilterButton.Value = "Recent";
                ButtonRecent.Attributes.Add("class", "btn btn-default active");

               Utilities.GridStateManager.LoadState(this, RadGrid1);
            }
        }

        protected void Page_Error(object sender, EventArgs e)
        {
            var ex = Server.GetLastError();
            this.HandleException(ex, false);
        }

        private void ClearFilters()
        {
            foreach (GridColumn column in RadGrid1.MasterTableView.OwnerGrid.Columns)
            {
                column.CurrentFilterFunction = GridKnownFunction.NoFilter;
                column.CurrentFilterValue = string.Empty;
            }
            RadGrid1.MasterTableView.FilterExpression = string.Empty;
        }

        protected void OnServerClick(object sender, EventArgs e)
        {
            System.Web.UI.HtmlControls.HtmlButton button = (System.Web.UI.HtmlControls.HtmlButton)sender;
            var buttonId = button.ID.Remove(0, 6);
            if (hfActiveButtonId.Value == "")
            {
                hfActiveButtonId.Value = button.ID;
            }
            else
            {
                //Response.Write($@"<script>alert('{hfActiveButtonId.Value}');</script>");
                var oldActiveButton = btnGroup.FindControl(hfActiveButtonId.Value) as System.Web.UI.HtmlControls.HtmlButton;
                if (oldActiveButton != null)
                {
                    oldActiveButton.Attributes.Remove("class");
                    oldActiveButton.Attributes.Add("class", "btn btn-default");
                }
                hfActiveButtonId.Value = button.ID;
            }

            //Response.Write($@"<script>alert('{buttonId}');</script>");
            hfFilterButton.Value = buttonId != "All" ? buttonId : "";
            button.Attributes.Add("class", "btn btn-default active");
            tbSearch.Text = "";
            ClearFilters();
            RadGrid1.Rebind();
        }

        protected void lbSearch_OnClick(object sender, EventArgs e)
        {
            var oldActiveButton = btnGroup.FindControl(hfFilterButton.Value) as System.Web.UI.HtmlControls.HtmlButton;
            if (oldActiveButton != null)
            {
                oldActiveButton.Attributes.Remove("class");
                oldActiveButton.Attributes.Add("class", "btn btn-default");
            }
            hfFilterButton.Value = "";
            ClearFilters();
            RadGrid1.Rebind();
        }

        public List<ContactDto> GetAllContacts()
        {
            var results = WcfProxy.PerformRemote<IContactService, List<ContactDto>>(x => x.GetAll());
            if (results == null)
            {
                return new List<ContactDto>();
            }

            var filterToUse = DetermineWhere();
            var filteredResults = filterToUse(results);
            var orderToUse = DetermineOrderBy();
            var orderedResults = orderToUse(filteredResults);

            return orderedResults.ToList();
        }

        private Func<IEnumerable<ContactDto>, IEnumerable<ContactDto>> DetermineWhere()
        {
            if (!string.IsNullOrWhiteSpace(hfFilterButton.Value) && hfFilterButton.Value != "Recent")
            {
                return x => x.Where(p => !string.IsNullOrWhiteSpace(p.LastName) && p.LastName.StartsWith(hfFilterButton.Value));
            }

            if (!string.IsNullOrWhiteSpace(tbSearch.Text))
            {
                return x => x.Where(p => (!string.IsNullOrWhiteSpace(p.FirstName) && p.FirstName.ToLower().Contains(tbSearch.Text.ToLower())) ||
                                         (!string.IsNullOrWhiteSpace(p.LastName) && p.LastName.ToLower().Contains(tbSearch.Text.ToLower())) ||
                                         (!string.IsNullOrWhiteSpace(p.Mobile) && p.Mobile.Contains(tbSearch.Text)) ||
                                         (!string.IsNullOrWhiteSpace(p.WorkTelephone) && p.WorkTelephone.Contains(tbSearch.Text)));
            }
            return x => x;
        }

        private Func<IEnumerable<ContactDto>, IOrderedEnumerable<ContactDto>> DetermineOrderBy()
        {
            if (hfFilterButton.Value == "Recent")
            {
                return x => x.OrderByDescending(y => y.DateModified);
            }

            return x => x.OrderBy(y => y.LastName);
        }

        protected void RadGrid1_OnNeedDataSource(object sender, GridNeedDataSourceEventArgs e)
        {
            Utilities.GridStateManager.SaveState(this, RadGrid1);
            var c1 = GetAllContacts();
            RadGrid1.DataSource = c1;
        }
        
        protected override void RaisePostBackEvent(IPostBackEventHandler source, string eventArgument)
        {
            try
            {
                base.RaisePostBackEvent(source, eventArgument);
            }
            catch
            {
                this.ShowError("Error has occurred.");
            }
            if (eventArgument == "") return;
            if (!int.TryParse(eventArgument, out _)) return;
            var grid = (RadGrid)source;
            if (grid.ID == "RadGrid1")
            {
                GridDataItem item = (GridDataItem)RadGrid1.MasterTableView.Items[eventArgument];
                var contactId = item.GetDataKeyValue("id").ToString();
                if (string.IsNullOrEmpty(contactId)) return;
                var contact = WcfProxy.PerformRemote<IContactService, ContactDto>(x => x.GetById(contactId.ToInt()));
                if (contact != null)
                {
                    personImage.Attributes["src"] = $@"~/images/{contactId.ToInt()}.jpg";
                    lblName.Text = $@"{contact.FirstName} {contact.Mobile}";
                    tbMobile.Text = contact.Mobile;
                    hlMobile.NavigateUrl = $@"tel:{contact.Mobile}";
                    var script =
                        "function g(){openItemWindow(); Sys.Application.remove_load(g);}Sys.Application.add_load(g);";
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "key", script, true);
                }
                
            }
        }

        public WcfProxy WcfProxy { get; set; } = new WcfProxy();


        private void ShowSuccess(string successMessage)
        {
            this.ShowToast(ToastTypeEnum.Success, successMessage, "Success");
        }

        private void ShowError(string errorMessage)
        {
            this.ShowToast(ToastTypeEnum.Error, errorMessage, "An error has occurred");
        }

        

        protected void RadGrid1_OnEditCommand(object sender, GridCommandEventArgs e)
        {
            if (e.Item is GridDataItem)
            {
                GridDataItem item = (GridDataItem)e.Item;
            }
        }

        public static ContactDto CreateOrUpdate(ContactDto item)
        {
            var proxy = new WcfProxy();
            return item.Id == 0
                ? proxy.PerformRemote<IContactService, ContactDto>(x => x.Create(item))
                : proxy.PerformRemote<IContactService, ContactDto>(x => x.Update(item));
        }

    }
}