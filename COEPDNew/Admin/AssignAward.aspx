<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="AssignAward.aspx.cs" Inherits="Admin_AssignAward" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script type="text/javascript">
        function alertmeSave() {
            Swal.fire(
                'Award Assign Successfully',
                '',
                'success'
            )
        }
        function alertmeUpdate() {
            Swal.fire(
                'Award Updated Successfully',
                '',
                'success'
            )
        }

        function alertmeDuplicate() {
            Swal.fire(
                'Award already exist',
                '',
                'warning'
            )
        }
    </script>
    <style type="text/css">
        .ui-widget-content .ui-icon {
    /background-image: url("../App_Themes/admin//images/ui-icons_222222_256x240.png")/ 
    /background-image:url("../App_Themes/admin/img/ui-icons_444444_256x240.png")/
     background-image:url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png")      
            !important;}
    .ui-widget-header .ui-icon {
    /background-image: url("../App_Themes/admin/img/ui-icons_444444_256x240.png")/ 
    background-image:url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png")  
        !important;}
    </style>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery.js"></script>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery-ui-v1.10.3.js"></script>
    <script type="text/javascript">
        $(document).ready(function ($) {
            $("[id*=txtDateOfIssued]").datepicker({
                changeMonth: true,
                changeYear: true,
                //showButtonPanel: true,
                //dateFormat: 'MM yy',
                dateFormat: 'dd/mm/yy',
                
            });
        });
        $(document).ready(function ($) {
            $("[id*=txtIssuedFortheMonth]").datepicker({
                changeMonth: true,
                changeYear: true,
                //showButtonPanel: true,
                //dateFormat: 'MM yy',
               dateFormat: 'dd/mm/yy',

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
                        <div class="form-group">
                             <label class="col-sm-2 control-label">
                                Employee : <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:DropDownList ID="ddlEmployee" runat="server" required="" ></asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Award Name : <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:DropDownList ID="ddlAward" runat="server" required="">
                                    
                                </asp:DropDownList>
                            </div>                           
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                 Certificate Id : <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:TextBox ID="txtCertificateId" runat="server" required="" OnTextChanged="txtCertificateId_TextChanged" AutoPostBack="true"></asp:TextBox>
                            </div>  
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Date Of Issued : <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:TextBox ID="txtDateOfIssued" runat="server" Required="" ></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Issued For the Month : <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:TextBox ID="txtIssuedFortheMonth" runat="server" Required="" ></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Assign" />
                                <asp:Button ID="btnCancel" runat="server" SkinID="delete" CssClass="btn btn-warning btn-md" Text="Back to list" OnClick="btnCancel_Click" CausesValidation="false" UseSubmitBehavior="false" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

