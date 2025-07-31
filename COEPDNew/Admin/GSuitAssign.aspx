<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="GSuitAssign.aspx.cs" Inherits="Admin_GSuitAssign" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script type="text/javascript">
        function alertmeSave() {
            Swal.fire(
                'Email Assign Successfully',
                '',
                'success'
            )
        }
        function alertmeUpdate() {
            Swal.fire(
                'Email Updated Successfully',
                '',
                'success'
            )
        }

        function alertmeDuplicate() {
            Swal.fire(
                'Email already exist',
                '',
                'warning'
            )
        }
    </script>
    <style type="text/css">
        .ui-widget-content .ui-icon {
            /background-image: url("../App_Themes/admin//images/ui-icons_222222_256x240.png")/ /background-image:url("../App_Themes/admin/img/ui-icons_444444_256x240.png")/ background-image:url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png") !important;
        }

        .ui-widget-header .ui-icon {
            /background-image: url("../App_Themes/admin/img/ui-icons_444444_256x240.png")/ background-image:url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png") !important;
        }
    </style>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery.js"></script>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery-ui-v1.10.3.js"></script>
    <script type="text/javascript">
        $(document).ready(function ($) {
            $("[id*=txtSimAssignedDate]").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: 'dd/mm/yy',
                maxDate: "0",
                yearRange: '-100:+0',
            });
        });
    </script>
    <script type="text/javascript">
        $(document).ready(function ($) {
            $("[id*=txtSimUnAssignedDate]").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: 'dd/mm/yy',
                maxDate: "0",
                yearRange: '-100:+0',
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" Runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        <asp:Label ID="lblTitle" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">
                        <div class="row">
                            <div class="col-lg-3 col-md-3">
                                <asp:TextBox ID="txtEmail" runat="server" AutoPostBack="True" Placeholder="Search by Email" OnTextChanged="txtEmail_TextChanged"></asp:TextBox>
                            </div>
                            <div class="col-lg-1 col-md-1">
                                <h5>Email</h5>
                            </div>
                            <div class="col-lg-2 col-md-2">
                                <asp:DropDownList ID="ddlEmail" runat="server" Required="">
                                </asp:DropDownList>
                            </div>

                            <div class="col-lg-3 col-md-3">
                                <asp:TextBox ID="txtEmployee" runat="server" AutoPostBack="True" Placeholder="Search by Employee Name" OnTextChanged="txtEmployee_TextChanged"></asp:TextBox>
                            </div>
                            <div class="col-lg-1 col-md-1">
                                <h5>Employee</h5>
                            </div>
                            <div class="col-lg-2 col-md-2">
                                <asp:DropDownList ID="ddlEmployee" runat="server" OnSelectedIndexChanged="ddlEmployee_SelectedIndexChanged" AutoPostBack="true" Required="">
                                </asp:DropDownList>
                            </div>

                            <div class="row">
                                &nbsp;
                            </div>
                            <div class="row">
                                &nbsp;
                            </div>

                            <div class="col-lg-12 col-md-12">
                                <div class="col-lg-6 col-md-6">
                                    <div class="form-group">
                                        <label class="col-sm-3 control-label">
                                            Purpose :<sup class="sup">*</sup>
                                        </label>
                                        <div class="col-sm-7">
                                            <asp:TextBox ID="txtPurpose" runat="server" required=""></asp:TextBox>
                                        </div>
                                    </div>
                                    
                                    <div class="form-group">
                                        <label class="col-sm-3 control-label">
                                            Remarks :
                                        </label>
                                        <div class="col-sm-7">
                                            <asp:TextBox ID="txtRemarks" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="col-sm-offset-3 col-sm-7">
                                            <asp:Button ID="btnAssign" runat="server" Visible="false" OnClick="btnAssign_Click" Text="Assign" />
                                            <asp:Button ID="btnUnAssign" runat="server" Visible="false" SkinID="btnWarning" OnClick="btnUnAssign_Click" Text="UnAssign" />
                                            <asp:Button ID="btnCancel" runat="server" SkinID="btnBack" CssClass="btn btn-warning btn-md" Text="Back to list" UseSubmitBehavior="false" CausesValidation="false"
                                                OnClick="btnCancel_Click" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-lg-6 col-md-6">
                                    <div class="row col-lg-offset-3">
                                        <h4>
                                            Assigned Email
                                        </h4>
                                    </div>
                                    <div id="dvGrid" style="height:300px; overflow:auto;width:400px">
                                        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!">
                                            <Columns>
                                                <asp:BoundField HeaderText="S.No" DataField="SNo" />
                                                <asp:BoundField HeaderText="Employee Name" DataField="Employee" />
                                                <asp:BoundField HeaderText="Email" DataField="GSuitEmail" />
                                                <asp:BoundField HeaderText="Purpose" DataField="Purpose" />
                                            </Columns>
                                        </asp:GridView>
                                       
                                    </div>
                                </div>
                            </div>
                        </div>
                </div>
            </div>
        </div>
    </div>
    </div>
</asp:Content>

