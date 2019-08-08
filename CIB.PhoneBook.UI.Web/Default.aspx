<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CIB.PhoneBook.UI.Web.Default" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">

        function r(f) { /in/.test(document.readyState) ? setTimeout('r(' + f + ')', 9) : f() }

        r(function () {
            //alert('DOM Ready!');
            document.getElementById("aSelectACustomer").className = "active";
            document.getElementById("liContacts").className = "expanded";
        });

        

    </script>

    <telerik:radcodeblock id="RadCodeBlock1" runat="server">
        <script type="text/javascript">
            var radGrid1 = null;
            function pageLoad() {
                radGrid1 = $find("<%= RadGrid1.ClientID %>");
            }
        </script>
    </telerik:radcodeblock>
</asp:Content>
<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="breadCrumbPlaceHolder">
    <li><a href="Dashboard.aspx">home</a></li>
    <li>Contacts</li>
    <li class="active">My Phonebook</li>
</asp:Content>
<asp:Content ID="Content4" runat="server" ContentPlaceHolderID="ContentPlaceHolder2">
    <div class="row">
        <div class="col-lg-12">
            <h3 class="text-standard"><i class="fa fa-fw fa-arrow-circle-right text-gray-light"></i>&nbsp;
                <asp:Label runat="server" ID="lblAddEdit"></asp:Label>
                My <strong>Phonebook</strong>  <small>List of all my contacts..</small>
            </h3>
        </div>
    </div>
    <div class="row">
        <div class="box">
            <div class="box-head box-head-lg">
                <div class="tools stick-top-right" style="margin-top: -80px; padding-right: 10px">
                    <div class="btn-group">
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <telerik:RadAjaxManagerProxy id="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RadGrid1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="lbSearch">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                </UpdatedControls>
            </telerik:AjaxSetting>            
        </AjaxSettings>
    </telerik:RadAjaxManagerProxy>

    <div class="row" style="background-color: white; padding-top: 10px;">
        <div class="col-lg-12">
            <asp:HiddenField runat="server" ID="hfActiveButtonId" />
            <asp:HiddenField runat="server" ID="hfFilterButton" />
            <div class="form-group">
                <div class="col-sm-10">
                    <div class="btn-toolbar" role="toolbar">
                        <div class="btn-group-sm" runat="server" id="btnGroup">
                            <button type="button" class="btn btn-default" id="ButtonA" runat="server" onserverclick="OnServerClick">A</button>
                            <button type="button" class="btn btn-default" id="ButtonB" runat="server" onserverclick="OnServerClick">B</button>
                            <button type="button" class="btn btn-default" id="ButtonC" runat="server" onserverclick="OnServerClick">C</button>
                            <button type="button" class="btn btn-default" id="ButtonD" runat="server" onserverclick="OnServerClick">D</button>
                            <button type="button" class="btn btn-default" id="ButtonE" runat="server" onserverclick="OnServerClick">E</button>
                            <button type="button" class="btn btn-default" id="ButtonF" runat="server" onserverclick="OnServerClick">F</button>
                            <button type="button" class="btn btn-default" id="ButtonG" runat="server" onserverclick="OnServerClick">G</button>
                            <button type="button" class="btn btn-default" id="ButtonH" runat="server" onserverclick="OnServerClick">H</button>
                            <button type="button" class="btn btn-default" id="ButtonI" runat="server" onserverclick="OnServerClick">I</button>
                            <button type="button" class="btn btn-default" id="ButtonJ" runat="server" onserverclick="OnServerClick">J</button>
                            <button type="button" class="btn btn-default" id="ButtonK" runat="server" onserverclick="OnServerClick">K</button>
                            <button type="button" class="btn btn-default" id="ButtonL" runat="server" onserverclick="OnServerClick">L</button>
                            <button type="button" class="btn btn-default" id="ButtonM" runat="server" onserverclick="OnServerClick">M</button>
                            <button type="button" class="btn btn-default" id="ButtonN" runat="server" onserverclick="OnServerClick">N</button>
                            <button type="button" class="btn btn-default" id="ButtonO" runat="server" onserverclick="OnServerClick">O</button>
                            <button type="button" class="btn btn-default" id="ButtonP" runat="server" onserverclick="OnServerClick">P</button>
                            <button type="button" class="btn btn-default" id="ButtonQ" runat="server" onserverclick="OnServerClick">Q</button>
                            <button type="button" class="btn btn-default" id="ButtonR" runat="server" onserverclick="OnServerClick">R</button>
                            <button type="button" class="btn btn-default" id="ButtonS" runat="server" onserverclick="OnServerClick">S</button>
                            <button type="button" class="btn btn-default" id="ButtonT" runat="server" onserverclick="OnServerClick">T</button>
                            <button type="button" class="btn btn-default" id="ButtonU" runat="server" onserverclick="OnServerClick">U</button>
                            <button type="button" class="btn btn-default" id="ButtonV" runat="server" onserverclick="OnServerClick">V</button>
                            <button type="button" class="btn btn-default" id="ButtonW" runat="server" onserverclick="OnServerClick">W</button>
                            <button type="button" class="btn btn-default" id="ButtonX" runat="server" onserverclick="OnServerClick">X</button>
                            <button type="button" class="btn btn-default" id="ButtonY" runat="server" onserverclick="OnServerClick">Y</button>
                            <button type="button" class="btn btn-default" id="ButtonZ" runat="server" onserverclick="OnServerClick">Z</button>
                            <button type="button" class="btn btn-default" id="ButtonAll" runat="server" onserverclick="OnServerClick">All</button>
                            <button type="button" class="btn btn-default" id="ButtonRecent" runat="server" onserverclick="OnServerClick">Recent</button>
                        </div>
                    </div>
                </div>
                <div class="col-sm-2">
                    <div class="input-group custom-search-form">
                        <asp:TextBox type="text" class="form-control" ID="tbSearch" placeholder="Search..." runat="server" onkeypress="return doSearch(event)" />
                        <span class="input-group-btn">
                            <asp:LinkButton class="btn btn-default" type="button" runat="server" ID="lbSearch" OnClick="lbSearch_OnClick" data-toggle="tooltip" data-placement="top" title="Search by any field">
                                <i class="fa fa-search"></i>
                            </asp:LinkButton>
                        </span>
                    </div>
                    <!-- /input-group -->
                </div>
            </div>
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
    <div style="clear: both; height: 15px; background-color: white" class="row"></div>
    <div class="row" style="background-color: white; padding-bottom: 10px;">
        <div class="col-lg-12">

            <telerik:radpersistencemanager id="RadPersistenceManager1" runat="server" storageproviderkey="OverviewDemoStorage">
                <PersistenceSettings>
                    <telerik:PersistenceSetting ControlID="RadGrid1" />
                </PersistenceSettings>
            </telerik:radpersistencemanager>

            <telerik:radcodeblock id="RadCodeBlock2" runat="server">
                <script type="text/javascript">
                    function OnRowDblClick(sender, args) {
                        var index = args._itemIndexHierarchical;
                        __doPostBack("<%= RadGrid1.UniqueID %>", index);
                    }

                    function doSearch(e) {
                        if (e.keyCode === 13) {
                            var btn = document.getElementById('<%= lbSearch.ClientID%>');
                            btn.click();
                            return false;
                        }
                    }

                    function openItemWindow() {
                        var radwindow = $find('<%=RadWindow1.ClientID %>');
                        radwindow.show();
                    }

                </script>
            </telerik:radcodeblock>

            <telerik:radgrid rendermode="Auto" id="RadGrid1" runat="server"
                allowpaging="True" allowsorting="True" onneeddatasource="RadGrid1_OnNeedDataSource"
                allowfilteringbycolumn="True" cellspacing="0" gridlines="None"
                autogenerateeditcolumn="false"
                skin="Bootstrap" showgrouppanel="true" OnEditCommand="RadGrid1_OnEditCommand" 
                >
                <GroupingSettings CaseSensitive="false" ShowUnGroupButton="true" />
                <ExportSettings ExportOnlyData="true" IgnorePaging="true">
                    <Word Format="Html" />
                    <Excel Format="Biff" />
                </ExportSettings>
                <MasterTableView 
                    AutoGenerateColumns="false" 
                    TableLayout="auto" 
                    DataKeyNames="id"
                    AllowFilteringByColumn="true" 
                    CommandItemDisplay="Top">
                    <CommandItemSettings 
                        ShowExportToCsvButton="true" 
                        ShowExportToExcelButton="true" 
                        ShowExportToPdfButton="true" 
                        ShowExportToWordButton="true" 
                        ShowAddNewRecordButton="true"
                        AddNewRecordText="Create a contact"/>
                    <Columns>
                        <telerik:GridEditCommandColumn HeaderText="Edit">
                            <HeaderStyle Width="50px" HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" Width="50px"></ItemStyle>
                        </telerik:GridEditCommandColumn>

                        <telerik:GridBoundColumn DataField="FirstName" HeaderText="FirstName" UniqueName="FirstName" AutoPostBackOnFilter="true" CurrentFilterFunction="Contains">
                            <HeaderStyle Width="150px"></HeaderStyle>
                            <ItemStyle Width="150px"></ItemStyle>
                        </telerik:GridBoundColumn>

                        
                        <telerik:GridBoundColumn DataField="LastName" HeaderText="LastName" UniqueName="LastName" AutoPostBackOnFilter="true" CurrentFilterFunction="Contains">
                            <HeaderStyle Width="150px"></HeaderStyle>
                            <ItemStyle Width="150px"></ItemStyle>
                        </telerik:GridBoundColumn>
                        
                        <telerik:GridBoundColumn DataField="Mobile" HeaderText="Mobile" UniqueName="Mobile" AutoPostBackOnFilter="true" CurrentFilterFunction="Contains" >
                            <HeaderStyle width="90px"></HeaderStyle>
                            <ItemStyle Width="90px"></ItemStyle>
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="WorkTelephone" HeaderText="Work Telephone" UniqueName="WorkTelephone" AutoPostBackOnFilter="true" CurrentFilterFunction="Contains">
                            <HeaderStyle width="150px"></HeaderStyle>
                            <ItemStyle Width="150px"></ItemStyle>
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="DateCreated" UniqueName="DateCreated" HeaderText="Date Created"  DataFormatString="{0:yyyy/MM/dd}">
                            <HeaderStyle width="100px"></HeaderStyle>
                            <ItemStyle Width="100px"></ItemStyle>
                        </telerik:GridBoundColumn>
                        
                       <telerik:GridBoundColumn DataField="DateModified" HeaderText="Date Modified" UniqueName="DateModified" DataFormatString="{0:yyyy/MM/dd}">
                            <HeaderStyle width="100px"></HeaderStyle>
                            <ItemStyle Width="100px"></ItemStyle>
                        </telerik:GridBoundColumn>
                    </Columns>
                    <PagerStyle PageSizes="5,10,15,20" PagerTextFormat="{4}<strong>{5}</strong> contacts matching your search criteria"
                        PageSizeLabelText="Contacts per page:" />
                </MasterTableView>
                <ClientSettings 
                    EnableRowHoverStyle="true"  
                    EnablePostBackOnRowClick="false" 
                    AllowColumnsReorder="true" 
                    AllowColumnHide="true" 
                    AllowDragToGroup="true">
                    <Selecting AllowRowSelect="true" EnableDragToSelectRows="false" />
                    <Scrolling AllowScroll="true" UseStaticHeaders="true" ScrollHeight="" />
                    <ClientEvents OnRowDblClick="OnRowDblClick" />
                    <Resizing AllowColumnResize="True"/>
                </ClientSettings>
            </telerik:radgrid>
        </div>
    </div>
    <!-- /.row -->

    <div style="clear: both; height: 30px" id="bottomRowSpacer"></div>

    <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
        <Windows>
            <%-- Contact popup --%>
            <telerik:RadWindow ID="RadWindow1" runat="server"
                Title="Open Contact"
                Width="400" Height="400"
                VisibleOnPageLoad="False" Modal="True"
                EnableShadow="true"
                Skin="Bootstrap" RenderMode="Lightweight"
                IconUrl="images/popupIcon.png">
                <ContentTemplate>
                    <div class="modal-body">
                        <center>
                            <table class="modalTable">
                                <tr>
                                    <td colspan="2"><asp:Image runat="server" ID="personImage" Width="50" Height="50"/></td>
                                </tr>
                                <tr>
                                    <td>Name:</td>
                                    <td><asp:Label runat="server" ID="lblName"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td>Mobile:</td>
                                    <td><div class="input-group">
                                        <asp:HyperLink runat="server" ID="hlMobile" CssClass="input-group-addon" Text="<span class='glyphicon glyphicon-phone-alt' aria-hidden='true'>"></asp:HyperLink>
                                        <telerik:RadMaskedTextBox CssClass="form-control" ID="tbMobile" ReadOnly="True" runat="server" RenderMode="Lightweight" Mask="(###)###-####" type="number" data-error="At least one contact number is required"></telerik:RadMaskedTextBox>
                                    </div></td>
                                </tr>
                            </table>
                        </center>
                    </div>
                    <div class="modal-footer">
                    </div>
                </ContentTemplate>
            </telerik:RadWindow>
            <%-- END: Contactpopup --%>
        </Windows>
    </telerik:RadWindowManager>
</asp:Content>
