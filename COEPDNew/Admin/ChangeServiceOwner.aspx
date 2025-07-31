<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ChangeServiceOwner.aspx.cs" Inherits="Admin_ChangeServiceOwner" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <script type="text/javascript" src="../App_Themes/admin/js/jquery.js"></script>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery-ui-v1.10.3.js"></script>
    <script type="text/javascript">
        function alertmePrevSelect() {
            Swal.fire(
                'Please select PreviousEmployee',
                '',
                'warning'
            )
        }
        function alertmeAssignSelect() {
            Swal.fire(
                'Please selectAssigningEmployee',
                '',
                'warning'
            )
        }
    </script>

    <style type="text/css">
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
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Lead Service Owner Change 
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox ID="txtPreviousEmployee" runat="server" CssClass="form-control" Placeholder="Search Employee" OnTextChanged="txtPreviousEmployee_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox ID="txtAssiningEmployee" runat="server" CssClass="form-control" Placeholder="Search Employee" AutoPostBack="true" OnTextChanged="txtAssiningEmployee_TextChanged"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox ID="txtLeadSearch" runat="server" CssClass="form-control" Placeholder="Search Lead" AutoPostBack="true" OnTextChanged="txtLeadSearch_TextChanged"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:Button ID="btnSubmit" runat="server" Text="changes Update" OnClick="btnSubmit_Click" OnClientClick="return confirm('are you sure ?');" />
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="col-lg-2 col-md-2">
                            <asp:DropDownList ID="ddlPreviousEmployee" runat="server" OnSelectedIndexChanged="ddlPreviousEmployee_SelectedIndexChanged" AutoPostBack="true">
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:DropDownList ID="ddlAssigning" runat="server">
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="table-responsive">
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" Width="100%" Caption="">
                                <Columns>

                                    <asp:TemplateField>
                                        <HeaderTemplate>
                                            <asp:CheckBox ID="chkselectedall" runat="server" AutoPostBack="true" OnCheckedChanged="chkselectedall_CheckedChanged" />
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkselect" runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="LeadId" DataField="leadId" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Location" DataField="Location" />
                                    <asp:BoundField HeaderText="Course" DataField="Course" />
                                    <asp:BoundField HeaderText="BatchType" DataField="BatchType" />
                                    <asp:BoundField HeaderText="Lead Name" DataField="Lead" />
                                    <asp:BoundField HeaderText="PrimaryMobile" DataField="PrimaryMobile" />
                                    <asp:BoundField HeaderText="Lead Service Owner" DataField="Username" />
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
</asp:Content>

