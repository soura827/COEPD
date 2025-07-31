<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="CUGSim.aspx.cs" Inherits="Admin_CUGSim" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
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
            $("[id*=txtActivationDate]").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: 'dd/mm/yy',
                maxDate: "0",
                yearRange: '-20:+0',
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
                                Sim Number <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:TextBox ID="txtSimNumber" runat="server" required="required"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Mobile <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:TextBox ID="txtMobile" runat="server" pattern="[6789][0-9]{9}" title="Enter valid 10 digit mobile Number" required="required"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                              IsActivated   
                            </label>
                            <div class="col-sm-6">
                                <asp:CheckBox ID="chkIsActivated" runat="server" AutoPostBack="true" OnCheckedChanged="chkIsActivated_CheckedChanged" />
                            </div> 
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                <asp:Label runat="server" ID="lblActivationDate" Visible="false" Text="Activation Date"></asp:Label>
                            </label>
                            <div class="col-sm-6">
                                <asp:TextBox ID="txtActivationDate" runat="server" Visible="false" Required="" ></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Tariff Plan <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:TextBox ID="txtTarifPlan" runat="server" required="required"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Save" />
                                <asp:Button ID="btnCancel" runat="server" SkinID="delete" CssClass="btn btn-warning btn-md" Text="Back to list" UseSubmitBehavior="false" CausesValidation="false"
                                    OnClick="btnCancel_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
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
                //maxDate: "0",
            });

            $("input[id$=txtToDate]").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: 'dd/mm/yy',
                //maxDate: "0"
            });
        });
    </script>
</asp:Content>