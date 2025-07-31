<%@ Page Title="" Language="C#" MasterPageFile="~/Participant/Participant.master" AutoEventWireup="true" CodeFile="SessionJobMarket.aspx.cs" Inherits="Participant_SessionJobMarket" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript" src="../App_Themes/admin/js/jquery.js"></script>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery-ui-v1.10.3.js"></script>
    <script type="text/javascript">
        $(document).ready(function ($) {
            $("input[id$=txtFromDate]").datepicker({
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
                /*maxDate: 0*/
            });
        });
        function alertmeDuplicate() {
            Swal.fire(
                'Session  Request already exist',
                '',
                'warning'
            )
        }
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
            background-image: url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png") !important;
        }

        .ui-widget-header .ui-icon {
            /*background-image: url("../App_Themes/admin/img/ui-icons_444444_256x240.png")*/
            background-image: url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png") !important;
        }
    </style>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
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
                        Session Job Market 
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">



                        <%--<div class="col-md-2">
                            <asp:TextBox ID="txtTrainer" runat="server" Placeholder="Search by Trainer" AutoPostBack="true" OnTextChanged="txtTrainer_TextChanged"></asp:TextBox>
                        </div>


                        <div class="col-md-2">
                            <asp:TextBox ID="txtFromDate" runat="server" Placeholder="From Date" AutoPostBack="true" OnTextChanged="txtFromDate_TextChanged"></asp:TextBox>
                        </div>


                        <div class="col-md-2">
                            <asp:TextBox ID="txtToDate" runat="server" Placeholder="To Date" AutoPostBack="true" OnTextChanged="txtToDate_TextChanged"></asp:TextBox>
                        </div>--%>

                        <div class="col-md-3 col-lg-3">
                            <asp:DropDownList ID="ddlSession" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlSession_SelectedIndexChanged" Visible="false">
                            </asp:DropDownList>
                        </div>
                    </div>

                    <div class="row">
                        &nbsp;
                    </div>


                    <div class="row">
                        <asp:GridView ID="gv" DataKeyNames="SessionId" runat="server" AutoGenerateColumns="false" PageSize="100" HeaderStyle-HorizontalAlign="Center" Width="100%" AllowPaging="true" AllowSorting="true" OnRowCommand="gv_RowCommand" OnPageIndexChanging="gv_PageIndexChanging" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnRowDataBound="gv_RowDataBound">
                            <Columns>
                                <asp:BoundField HeaderText="S.No" DataField="SNo" />
                                <asp:BoundField HeaderText="Session Name" DataField="TotalSession" />
                                <asp:BoundField HeaderText="Date" DataField="Date" DataFormatString="{0: dd MMM yyyy}" />
                                <asp:BoundField HeaderText="Start Time" DataField="StartTime" />
                                <asp:BoundField HeaderText="End Time" DataField="EndTime" />
                                <asp:BoundField HeaderText="Created By" DataField="Fullname" />



                                <asp:TemplateField HeaderText="Zoom Meeting ID">
                                    <ItemTemplate>
                                        <asp:Label ID="lblZoomMeetingID" runat="server" Text='<%# Eval("ZoomMeetingId") %>' Visible="false"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Password">
                                    <ItemTemplate>
                                        <asp:Label ID="lblPassword" runat="server" Text='<%# Eval("Password") %>' Visible="false"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Status" ItemStyle-Width="150px">
                                    <HeaderTemplate>
                                        <center>Status</center>
                                    </HeaderTemplate>
                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <ItemTemplate>
                                        <asp:HiddenField ID="hdnStatusId" runat="server" Value='<%#Eval("AttendId") %>' />
                                        <asp:Label ID="lbl" runat="server" />
                                        <asp:DropDownList ID="ddlAction" runat="server" OnSelectedIndexChanged="ddlAction_SelectedIndexChanged" ReadOnly="True" CommandName="ShowDetails" AutoPostBack="true">
                                            <asp:ListItem Text="Attend" Value="0"></asp:ListItem>
                                            <asp:ListItem Text="Yes" Value="1"></asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:Literal ID="ltrlMessage" runat="server"></asp:Literal>
                                        <asp:HiddenField ID="hfResponse" runat="server" ClientIDMode="Static" />
                                    </ItemTemplate>
                                    <ItemStyle Width="150px"></ItemStyle>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

