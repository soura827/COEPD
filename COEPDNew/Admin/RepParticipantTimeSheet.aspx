<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="RepParticipantTimeSheet.aspx.cs" Inherits="RepParticipantTimeSheet" %>

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
     background-image:url("../../App_Themes/admin/img/ui-icons_3d80b3_256x240.png")      
            !important;}
    .ui-widget-header .ui-icon {
    /*background-image: url("../App_Themes/admin/img/ui-icons_444444_256x240.png")*/ 
    background-image:url("../../App_Themes/admin/img/ui-icons_3d80b3_256x240.png")  
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
                        Participant Time Sheet Report
                    </div>
                </div>
                <div class="widget-body">
                    <%--<div class="row">
                        <div class="col-md-1">
                            <h5>Batch</h5>
                        </div>
                        <div class="col-md-8">
                            <asp:DropDownList ID="ddlBatch" runat="server" required="required" AutoPostBack="true"
                                OnSelectedIndexChanged="ddlBatch_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                        <div class="col-md-2">
                            <h5>Participant</h5>
                        </div>
                    </div>--%>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="col-md-1">
                            <h5>From</h5>
                        </div>
                        <div class="col-md-2">
                            <asp:TextBox ID="txtFromDate" runat="server" Placeholder="From Date" required=""></asp:TextBox>
                        </div>
                        <div class="col-md-1">
                            <h5>To</h5>
                        </div>
                        <div class="col-md-2">
                            <asp:TextBox ID="txtToDate" runat="server" Placeholder="To Date" required=""></asp:TextBox>
                        </div>
                        <div class="col-md-1">
                            <asp:Button ID="btnSubmit" runat="server" Text="Go" OnClick="btnSubmit_Click" />
                        </div>
                        <div class="col-md-4">
                        </div>
                        <div class="col-md-1">
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="table-responsive">
                        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" Width="100%">
                            <Columns>
                                <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                <asp:BoundField HeaderText="Participant Name" DataField="Participant" ItemStyle-Width="200px" />
                                <asp:BoundField HeaderText="InternBatchDate" DataField="InternBatchDate" DataFormatString="{0:dd MMM yyyy}" />
                                <asp:BoundField HeaderText="Location" DataField="Location" />
                                <asp:BoundField HeaderText="Trainer" DataField="Employee"/>
                                <asp:BoundField HeaderText="Date" DataField="Date" DataFormatString="{0:dd MMM yyyy}" />
                                 <asp:BoundField HeaderText="Login IP" DataField="LoginIPAddress" />
                                  <asp:BoundField HeaderText="Logout IP" DataField="LogoutIPAddress" />
                                <asp:TemplateField HeaderText="Start Time">
                                    <ItemTemplate>
                                        <%# Eval("StartTime", "{0:hh:mm}") %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                               <%-- <asp:TemplateField HeaderText="Posted Time">
                                    <ItemTemplate>
                                        <%# Eval("CreatedOn", "{0:hh:mm}") %>
                                    </ItemTemplate>
                                </asp:TemplateField>--%>
                                <asp:TemplateField HeaderText="End Time">
                                    <ItemTemplate>
                                        <%# Eval("EndTime", "{0:hh:mm}") %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                              <%--  <asp:TemplateField HeaderText="Modified Time">
                                    <ItemTemplate>
                                        <%# Eval("ModifiedOn", "{0:hh:mm}") %>
                                    </ItemTemplate>
                                </asp:TemplateField>--%>
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
    </div>
    <!-- Row End -->
</asp:Content>
