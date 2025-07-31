<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="RepTimeSheet.aspx.cs" Inherits="RepTimeSheet" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <script type="text/javascript" src="../App_Themes/admin/js/jquery.js"></script>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery-ui-v1.10.3.js"></script>

    <script type="text/javascript">
        $(document).ready(function ($) {

            $("input[id$=txtFromDate]").datepicker({
                value: new Date().toDateString(),
                dateFormat: 'dd/mm/yy',
                changeMonth: true,
                changeYear: true,
                changeprevious: true,
                maxDate: "0",
            });

            $("input[id$=txtToDate]").datepicker({
                dateFormat: 'dd/mm/yy',
                changeMonth: true,
                changeYear: true,
                maxDate: 0
            });
        });
    </script>

    <style type="text/css">
        table caption {
            background-color: #5D7B9D;
            color: White;
            font-size: 16px;
            text-align: center;
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
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Row Start -->
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Time Sheet Report
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-lg-1 col-md-1">
                            <label>Employee</label>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:DropDownList ID="ddlEmployee" runat="server" required="required" AutoPostBack="true"
                                 OnSelectedIndexChanged="ddlEmployee_SelectedIndexChanged"> </asp:DropDownList>
                        </div>
                    </div>
                     <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                          <div class="col-lg-1 col-md-1">
                            <label>Client</label>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:DropDownList ID="ddlclient" runat="server" required="required" AutoPostBack="true" OnSelectedIndexChanged="ddlclient_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                      
                        <div class="col-lg-1 col-md-1">
                            <label>Project</label>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:DropDownList ID="ddlProject" runat="server" required="required" OnSelectedIndexChanged="ddlProject_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                       
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        
                        <div class="col-lg-1 col-md-1">
                            <label>From Date</label>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox ID="txtFromDate" runat="server" Placeholder="From Date" required=""></asp:TextBox>
                        </div>
                       
                        <div class="col-lg-1 col-md-1">
                            <label>To Date </label>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox ID="txtToDate" runat="server" Placeholder="To Date" required="">  </asp:TextBox>
                        </div>
                        
                        <div class="col-lg-1 col-md-1">
                            <asp:Button ID="btnSubmit" runat="server" Text="Find" OnClick="btnSubmit_Click" />
                        </div>
                        <div class="col-lg-4 col-md-4">
                            &nbsp;
                        </div>
                        <div class="col-lg-1 col-md-1">
                           <%-- <asp:Button ID="btnDownload" runat="server" OnClick="btnDownload_Click" Text="Download"
                                CausesValidation="false" UseSubmitBehavior="false" />--%>
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False"
                            Width="100%">
                            <Columns>
                                <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                <asp:BoundField HeaderText="Name" DataField="Employee" ItemStyle-Width="200px" />
                                <asp:BoundField HeaderText="Date" DataField="Date" DataFormatString="{0:dd MMM yyyy}" />
                                <asp:BoundField HeaderText="Client" DataField="Client" />
                                <asp:BoundField HeaderText="Project" DataField="Project" />
                                <asp:TemplateField HeaderText="StartTime">
                                    <ItemTemplate>
                                        <%# Eval("StartTime", "{0:hh:mm tt}") %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="PostedTime">
                                    <ItemTemplate>
                                        <%# Eval("CreatedOn", "{0:hh:mm tt}") %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="EndTime">
                                    <ItemTemplate>
                                        <%# Eval("EndTime", "{0:hh:mm tt}") %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="ModifiedTime">
                                    <ItemTemplate>
                                        <%# Eval("ModifiedOn", "{0:hh:mm tt}") %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="Description" DataField="Note" />
                            </Columns>
                            <EmptyDataTemplate>
                                <center>
                                    No Records Found
                                </center>
                            </EmptyDataTemplate>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Row End -->
</asp:Content>
