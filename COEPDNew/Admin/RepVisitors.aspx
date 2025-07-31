<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true"
    CodeFile="RepVisitors.aspx.cs" Inherits="Admin_RepVisitors" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript" src="../App_Themes/admin/js/jquery.js"></script>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery-ui-v1.10.3.js"></script>
    <script type="text/javascript">
        $(document).ready(function ($) {

            $("input[id$=txtFromDate]").datepicker({
                value: new Date().toDateString(),
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
                maxDate: 0
            });
        });
    </script>
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
    <div class="col-lg-12 col-md-12">
        <div class="widget">
            <div class="widget-header">
                <div class="title">
                    Participant Visitors Reports
                </div>
            </div>
            <div class="widget-body">
                <div class="row">
                    <div class="col-lg-12 col-md-12">
                        <div class="col-lg-1 col-md-1">
                            <label>
                                BatchType</label>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:DropDownList ID="ddlBatchType" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlBatchType_SelectedIndexChanged"
                                required="">
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-1 col-md-1">
                            <label>
                                Location</label>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:DropDownList ID="ddlLocation" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlLocation_SelectedIndexChanged"
                                required="">
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
                <div class="row">
                    &nbsp;
                </div>
                <div class="row">
                    <div class="col-lg-12 col-md-12">
                        <div class="col-lg-1 col-md-1">
                            <label>
                                Batch
                            </label>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:DropDownList ID="ddlBatch" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlBatch_SelectedIndexChanged"
                                required="">
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-1 col-md-1">
                            <label>
                                Participant</label>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:DropDownList ID="ddlParticipant" runat="server" OnSelectedIndexChanged="ddlParticipant_SelectedIndexChanged"
                                required="">
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
                <div class="row">
                    &nbsp;
                </div>
                <div class="row">
                    <div class="col-lg-12 col-md-12">
                        <div class="col-lg-1 col-md-1">
                            <label>
                                From Date</label>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:TextBox ID="txtFromDate" runat="server" Placeholder="From Date" required=""></asp:TextBox>
                        </div>
                        <div class="col-lg-1 col-md-1">
                            <label>
                                To Date</label>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:TextBox ID="txtToDate" runat="server" Placeholder="To Date" required=""></asp:TextBox>
                        </div>
                        <div class="col-lg-1 col-md-1">
                            &nbsp;
                        </div>
                        <div class="col-lg-1 col-md-1">
                            <asp:Button ID="btnSubmit" runat="server" Text="Find" OnClick="btnSubmit_Click" />
                        </div>
                        <div class="col-lg-3 col-md-3">
                            &nbsp;
                        </div>
                    </div>
                </div>
                <div class="row">
                    &nbsp;
                </div>
                <div class="row">
                    <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" Width="100%" Caption>
                        <Columns>
                            <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                            <asp:BoundField HeaderText="Date" DataField="Date" DataFormatString="{0:dd MMM yyyy}" />
                            <asp:BoundField HeaderText="Participant" DataField="Participant" />
                            <asp:BoundField HeaderText="Meet To" DataField="Employee" />
                            <asp:TemplateField HeaderText="Start Time">
                                <ItemTemplate>
                                    <%# Eval("StartTime", "{0:hh:mm tt}") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="End Time">
                                <ItemTemplate>
                                    <%# Eval("EndTime", "{0:hh:mm tt}") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField HeaderText="Purpose Of Visit" DataField="Comments" />
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
</asp:Content>
