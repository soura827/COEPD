<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="SessionJobMarket.aspx.cs" Inherits="Admin_SessionJobMarket" %>

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
                /* maxDate: "1",*/
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
            background-image: url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png") !important;
        }

        .ui-widget-header .ui-icon {
            background-image: url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png") !important;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Row Start -->

    <contenttemplate>
        <div class="row">
            <div class="col-lg-12 col-md-12">
                <div class="widget">
                    <div class="widget-header">
                        <div class="title">
                            Job Market Induction
                        </div>
                    </div>

                    <div class="widget-body">


                        <div class="row">


                            
                            <div class="col-md-2">
                                <asp:TextBox ID="txtTrainer" runat="server" Placeholder="Search by Trainer" AutoPostBack="true" OnTextChanged="txtTrainer_TextChanged"></asp:TextBox>
                            </div>


                            <div class="col-md-2">
                                <asp:TextBox ID="txtFromDate" runat="server" Placeholder="From Date" AutoPostBack="true" OnTextChanged="txtFromDate_TextChanged"></asp:TextBox>
                            </div>


                            <div class="col-md-2">
                                <asp:TextBox ID="txtToDate" runat="server" Placeholder="To Date" AutoPostBack="true" OnTextChanged="txtToDate_TextChanged"></asp:TextBox>
                            </div>

                            <div class="col-md-3 col-lg-3">
                                <asp:DropDownList ID="ddlSession" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlSession_SelectedIndexChanged" Visible="false">
                                </asp:DropDownList>
                            </div>
                        </div>

                        <div class="row">
                            &nbsp;
                        </div>

                        <div class="row">
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" PageSize="100" HeaderStyle-HorizontalAlign="Center" Width="100%" AllowPaging="true"  AllowSorting="true" OnRowCommand="gv_RowCommand" OnPageIndexChanging="gv_PageIndexChanging" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!">
                                <Columns>
                                    <asp:BoundField HeaderText="S.No" DataField="SNo" />
                                    <asp:BoundField HeaderText="Session Name" DataField="TotalSession" />
                                    <asp:BoundField HeaderText="Date" DataField="Date" DataFormatString="{0: dd MMM yyyy }" />
                                    <asp:BoundField HeaderText="Start Time" DataField="StartTime" />
                                    <asp:BoundField HeaderText="End Time" DataField="EndTime" />
                                    <asp:BoundField HeaderText="Zoom Meeting Id" DataField="ZoomMeetingId" />
                                    <asp:BoundField HeaderText="Password" DataField="Password" />
                                    <asp:BoundField HeaderText="Session Trainer" DataField="Employee" />

                                    <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                                CommandArgument='<%#Eval("SessionId")%>'></asp:LinkButton>
                                            <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                                CommandArgument='<%#Eval("SessionId")%>' OnClientClick="return confirm('Are you sure you want to delete this ActivityCategory?');"></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </contenttemplate>
</asp:Content>

