<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="RepJobs.aspx.cs" Inherits="RepJobs" EnableEventValidation="false" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        table caption {
            background-color: #5D7B9D;
            color: White;
            font-size: 16pt;
            text-align: center;
        }

        .ui-widget-content .ui-icon {
            /*background-image: url("../App_Themes/admin//images/ui-icons_222222_256x240.png")*/
            /*background-image:url("../App_Themes/admin/img/ui-icons_444444_256x240.png")*/
            background-image: url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png") !important;
        }

        .ui-widget-header .ui-icon {
            /*background-image: url("../App_Themes/admin/img/ui-icons_444444_256x240.png")*/
            background-image: url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png") !important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <%--<div class="box-theme">--%>
    <!-- Row Start -->
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Jobs
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <%--<div class="col-lg-1 col-md-1">
                                <label>
                                    Category</label>
                            </div>--%>
                        <%-- <div class="col-lg-2 col-md-2">
                            <asp:DropDownList ID="ddlCategory" runat="server" CssClass="form-control">
                            </asp:DropDownList>
                        </div>--%>
                        <div class="col-lg-3 col-md-3">
                            <asp:TextBox runat="server" ID="txtbusiness" placeholder="Business Analyst" Text="Business Analyst"></asp:TextBox>
                        </div>
                        <%-- <div class="col-lg-1 col-md-1">
                                <label>
                                    Domain</label>
                            </div>--%>
                        <div class="col-lg-2 col-md-2">
                            <asp:DropDownList ID="ddlJobDomain" runat="server" CssClass="form-control">
                            </asp:DropDownList>
                        </div>
                        <%-- <div class="col-lg-1 col-md-1">
                                <label>
                                    Search</label>
                            </div>--%>
                        <div class="col-lg-3 col-md-3">
                            <asp:TextBox runat="server" ID="txtSearch" placeholder="Search By Company or Location"></asp:TextBox>
                        </div>

                        <%--<div class="col-lg-1 col-md-1">
                                <label>
                                    From Date</label>
                            </div>--%>

                        <div class="col-lg-3 col-md-3">
                            <asp:TextBox runat="server" ID="txtexp" placeholder="Search By Experience" AutoPostBack ="true" OnTextChanged="txtexp_TextChanged"></asp:TextBox>
                        </div>
                        <div class="row">
                            <br />
                        </div>
                        <div class="row">
                            <br />
                        </div>


                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox ID="txtFromDate" runat="server" Placeholder="Select From Date" required=""></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Date format should be DD/MM/YYYY" ControlToValidate="txtFromDate" ValidationExpression="^(0[1-9]|[12][0-9]|3[01])[-/.](0[1-9]|1[012])[-/.](19|20)\d\d$" ForeColor="Red"></asp:RegularExpressionValidator>
                        </div>

                        <%-- <div class="col-lg-1 col-md-1">
                                <label>
                                    To Date</label>
                            </div>--%>
                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox ID="txtToDate" runat="server" Placeholder="Select To Date" required=""></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Date format should be DD/MM/YYYY" ControlToValidate="txtToDate" ValidationExpression="^(0[1-9]|[12][0-9]|3[01])[-/.](0[1-9]|1[012])[-/.](19|20)\d\d$" ForeColor="Red"></asp:RegularExpressionValidator>
                        </div>
                        <div class="col-lg-5 col-md-5">
                            &nbsp;
                        </div>
                        <div class="col-lg-1 col-md-1">
                            <asp:Button ID="btnSubmit" runat="server" Text="Find" OnClick="btnSubmit_Click" />
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <%--<asp:Button ID="btnDownload" runat="server" Text="Download" OnClick="btnDownload_Click"
                                UseSubmitBehavior="false" />--%>
                            <asp:Button ID="btnDownload" runat="server" Text="Download" OnClick="btnDownload_Click" />
                        </div>
                    </div>
                    <div class="row">
                        <br />
                    </div>
                    <div class="row">
                        <div class="table-responsive">
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" Width="100%">
                                <Columns>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Date" DataField="JobDate" ItemStyle-Width="100px" DataFormatString="{0:dd-MM-yyy}" />
                                    <asp:BoundField HeaderText="Job" DataField="JobTitle" ItemStyle-Width="100px" />
                                    <asp:BoundField HeaderText="Company" DataField="Company" ItemStyle-Width="150px" />
                                    <asp:BoundField HeaderText="Location" DataField="Location" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Exp" DataField="Experience" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Domain" DataField="JobDomain" ItemStyle-Width="100px" />
                                    <%--<asp:BoundField HeaderText="Email" DataField="Email" ItemStyle-Width="150px" />
                                        <asp:BoundField HeaderText="Phone" DataField="Phone" ItemStyle-Width="100px" />--%>
                                    <asp:BoundField HeaderText="Created By" DataField="FullName" />
                                    <asp:BoundField HeaderText="Created On" DataField="CreatedOn" DataFormatString="{0:dd MMM yyyy hh:mm tt}" />
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
    </div>
    <%--</div>--%>
    <!-- Row End -->
    <script type="text/javascript" src="../App_Themes/admin/js/jquery.js"></script>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery-ui-v1.10.3.js"></script>
    <script type="text/javascript">

        $(document).ready(function ($) {

            $("[id*=txtFromDate]").datepicker({
                dateFormat: 'dd/mm/yy',
                changeMonth: true,
                changeYear: true,
                changeprevious: true,
                maxDate: "0",
            });

            $("[id*=txtToDate]").datepicker({
                dateFormat: 'dd/mm/yy',
                changeMonth: true,
                changeYear: true,
                maxDate: 0
            });
        });
    </script>
</asp:Content>
