<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="CoepdEmployeeTreeSearch.aspx.cs" Inherits="Admin_CoepdEmployeeTreeSearch" EnableEventValidation="false" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">




    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Coepd Employee Tree
                    </div>
                </div>

                <div class="widget-body">

                    <div class="row">
                        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" HeaderStyle-HorizontalAlign="Center" Width="100%" AllowSorting="true" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!">
                            <Columns>
                                <asp:BoundField HeaderText="S.No" DataField="SNo" />
                                <asp:BoundField HeaderText="Vertical Head Name" DataField="Employee" />
                                <asp:BoundField HeaderText="office Email  " DataField="OfficeEmail" />
                                <asp:BoundField HeaderText="office Mobile Number" DataField="CUGMobile" />

                            </Columns>
                        </asp:GridView>
                    </div>

                    <div class="row">
                        &nbsp;
                    </div>

                    <div class="row">
                        <div class="col-lg-2 col-md-2">
                            <asp:DropDownList ID="ddlVerticialHead" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlVerticialHead_SelectedIndexChanged"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" HeaderStyle-HorizontalAlign="Center" Width="100%" AllowSorting="true" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!">
                            <Columns>
                                <asp:BoundField HeaderText="S.No" DataField="SNo" />
                                <asp:BoundField HeaderText="Reporting Manager" DataField="Employee" />
                                <asp:BoundField HeaderText="office Email  " DataField="OfficeEmail" />
                                <asp:BoundField HeaderText="office Mobile Number" DataField="CUGMobile" />

                            </Columns>
                        </asp:GridView>
                    </div>


                    <div class="row">
                        &nbsp;
                    </div>

                    <div class="row">
                        <div class="col-lg-2 col-md-2">
                            <asp:DropDownList ID="ddlReportingManager" runat="server" OnSelectedIndexChanged="ddlReportingManager_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="false" HeaderStyle-HorizontalAlign="Center" Width="100%" AllowSorting="true" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!">
                            <Columns>
                                <asp:BoundField HeaderText="S.No" DataField="SNo" />
                                <asp:BoundField HeaderText="Employee" DataField="Employee" />
                                <asp:BoundField HeaderText="office Email  " DataField="OfficeEmail" />
                                <asp:BoundField HeaderText="office Mobile Number" DataField="CUGMobile" />

                            </Columns>
                        </asp:GridView>
                    </div>

                </div>
            </div>
        </div>
    </div>


</asp:Content>

