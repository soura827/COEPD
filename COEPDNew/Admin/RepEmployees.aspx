<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true"
    CodeFile="RepEmployees.aspx.cs" Inherits="Admin_RepEmployees" %>

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
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="box-theme">
        <!-- Row Start -->
        <div class="row">
            <div class="col-lg-12 col-md-12">
                <div class="widget">
                    <div class="widget-header">
                        <div class="title">
                            Employees Reports
                        </div>
                    </div>
                    <div class="widget-body">
                        <div class="row">
                            <div class="col-lg-1 col-md-1">
                                <h5>Designation</h5>
                            </div>
                            <div class="col-lg-3 col-md-3">
                                <asp:DropDownList ID="ddlDesignation" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlDesignation_SelectedIndexChanged"
                                    CssClass="form-control">
                                </asp:DropDownList>
                            </div>
                            <div class="col-lg-1 col-md-1">
                                <h5>Department</h5>
                            </div>
                            <div class="col-lg-2 col-md-2">
                                <asp:DropDownList ID="ddlDepartment" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlDepartment_SelectedIndexChanged"
                                    CssClass="form-control">
                                </asp:DropDownList>
                            </div>
                            <div class="col-lg-1 col-md-1">
                                <h5>Branch
                                </h5>
                            </div>
                            <div class="col-lg-2 col-md-2">
                                <asp:DropDownList ID="ddlBranch" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlBranch_SelectedIndexChanged"
                                    CssClass="form-control">
                                </asp:DropDownList>
                            </div>
                            <div class="col-lg-1 col-md-1">
                                &nbsp;
                            </div>
                            <div class="col-lg-1 col-md-1">
                                <asp:Button ID="btnDownload" runat="server" Text="Download" OnClick="btnDownload_Click" />
                            </div>
                        </div>
                        <div class="row">
                            &nbsp;
                        </div>
                        <div class="row">
                            <div class="table-responsive">
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" Width="100%" CssClass="caption">
                                <Columns>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Code" DataField="Code" />
                                    <asp:BoundField HeaderText="Employee" DataField="Employee" />
                                    <asp:BoundField HeaderText="Designation" DataField="Designation" />
                                    <asp:BoundField HeaderText="Mobile" DataField="Mobile" />
                                    <asp:BoundField HeaderText="CUG" DataField="CUGMobile" />
                                    <asp:BoundField HeaderText="OfficeEmail" DataField="OfficeEmail" />
                                    <asp:BoundField HeaderText="Personal Email" DataField="Email" />
                                    <asp:BoundField HeaderText="Department" DataField="Department" />
                                </Columns>
                                <PagerStyle HorizontalAlign="Center" VerticalAlign="Bottom" />
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
    </div>
    <!-- Row End -->
</asp:Content>
