<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" Theme="admin" CodeFile="EmployeeLogInLogOutReport.aspx.cs" Inherits="Admin_EmployeeLogInLogOutReport" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        table caption{
            background-color : #2D2341;
            color : white;
            font-size : 16pt;
            text-align : center;
        }
         .ui-widget-content .ui-icon {
    /*background-image: url("../App_Themes/admin//images/ui-icons_222222_256x240.png")*/ 
    /*background-image:url("../App_Themes/admin/img/ui-icons_444444_256x240.png")*/
     background-image:url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png")      
            !important;}
    .ui-widget-header .ui-icon {
    /*background-image: url("../App_Themes/admin/img/ui-icons_444444_256x240.png")*/ 
    background-image:url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png")  
        !important;}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" Runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!-- Row Start -->
  <%--<asp:ScriptManager ID="scriptmanager" runat="server"></asp:ScriptManager>--%>
    <%--<asp:UpdatePanel ID="UpdatePanel" runat="server">--%>
  <%--  <ContentTemplate>--%>
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                          Employees Login and Logout Report
                    </div>
                </div>
                
                <div class="widget-body">
                    <div class="row">
                        <div class="form-group">
                         <div class="col-lg-3 col-md-3">
                            <asp:TextBox runat="server" ID="txtEmployeeDetails" MaxLength="100" placeholder="By Employee ID/Name/Designation" OnTextChanged="txtEmployeeDetails_TextChanged" AutoPostBack="true" ></asp:TextBox>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:TextBox runat="server" ID="txtBranch" MaxLength="100" placeholder="Search By Branch" OnTextChanged="txtBranch_TextChanged" AutoPostBack="true" ></asp:TextBox>
                        </div>
                          <div class="col-lg-2 col-md-2">
                             <asp:TextBox ID="txtFromDate" runat="server" CssClass="form-control" Placeholder="From Date" OnTextChanged="txtFromDate_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                            <div class="col-lg-2 col-md-2">
                            <asp:TextBox ID="txtToDate" runat="server" CssClass="form-control" Placeholder="To Date" OnTextChanged="txtToDate_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                            <div class="col-lg-2 col-md-2">
                                <asp:Button ID="btnDownload" runat="server" Text="Download" OnClick="btnDownload_Click" UseSubmitBehavior="false" />
                            </div>
                            </div>
                        <br />
                        <br />
                        </div>
                    <div class="row">
                        &nbsp;
                    </div>
                      <div class="row"> 
                          <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" HeaderStyle-HorizontalAlign="Center" Width="100%" AllowSorting="true" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" Caption="">
                              <Columns>
                                  
                                  <asp:BoundField HeaderText="S.No" DataField="SNo" />
                                  <asp:BoundField HeaderText="Date" DataField="Date" DataFormatString="{0:dd MMM yyyy}" />
                                  <asp:BoundField HeaderText="Employee ID" DataField="Code" />
                                  <asp:BoundField HeaderText="Name" DataField="Employee" />
                                  <asp:BoundField HeaderText="Designation" DataField="Designation" />
                                  <asp:BoundField HeaderText="Branch" DataField="Branch" />
                                  <asp:BoundField HeaderText="Login IP" DataField="LoginIPAddress" />
                                  <asp:BoundField HeaderText="Logout IP" DataField="LogoutIPAddress" />
                                  <asp:TemplateField HeaderText="Start Time" ItemStyle-Width="100px">
                                    <ItemTemplate>
                                        <%# Eval("StartTime", "{0:hh:mm tt}") %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="End Time" ItemStyle-Width="100px">
                                    <ItemTemplate>
                                        <%# Eval("EndTime", "{0:hh:mm tt}") %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                  <asp:BoundField HeaderText="Duration (HH:MM:SS)" DataField="Duration" />
                              </Columns>
                          </asp:GridView>
                      </div>
                    </div>
                </div>
            </div>
        </div>
<%--     </ContentTemplate>
    </asp:UpdatePanel>--%>
    <!-- Row End -->
    <script type="text/javascript" src="../App_Themes/admin/js/jquery.js"></script>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery-ui-v1.10.3.js"></script>

    <script type="text/javascript">
        $(document).ready(function ($) {

            $("input[id$=txtFromDate]").datepicker({
                value: new Date().toDateString(-15),
                changeMonth: true,
                changeYear: true,
                changeprevious: true,
                dateFormat: 'dd/mm/yy',
                maxDate: "0",
            });

            $("input[id$=txtToDate]").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: 'dd/mm/yy',
                maxDate: "0"
            });
        });
    </script>
</asp:Content>

