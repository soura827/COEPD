<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="Participant.aspx.cs" Inherits="Participant" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
        <style type="text/css">
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
    <!-- Row Start -->
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
                                Status
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlStatus" runat="server" AutoPostBack="true">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Batch
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlBatch" runat="server" Required="" AutoPostBack="true" OnSelectedIndexChanged="ddlBatch_SelectedIndexChanged">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Lead Source
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlLeadSource" runat="server" Required="" AutoPostBack="true" OnSelectedIndexChanged="ddlBatch_SelectedIndexChanged">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Reference No
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtReferenceNo" Type="number" runat="server" AutoPostBack="true" Required OnTextChanged="txtReferenceNo_TextChanged"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group" id="divReferNo" runat="server" visible="false">
                            <label class="col-sm-9 control-label">
                            </label>
                            <div class="col-sm-3">
                                <asp:Label ID="lblRefeno" Font-Bold="true" runat="server" Visible="false"></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Participant
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtParticipant" MaxLength="500" runat="server" Required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Location Name
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlLocation" runat="server" Required="" AutoPostBack="true" OnSelectedIndexChanged="ddlLocation_SelectedIndexChanged">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Branch Name
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlBranch" runat="server" Required="" AutoPostBack="true">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Domain
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlJobDomain" runat="server">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Mobile
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtMobile" Type="number" MaxLength="50" runat="server" Required="" AutoPostBack="true" OnTextChanged="txtMobile_TextChanged"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group" id="divMobile" runat="server" visible="false">
                            <label class="col-sm-9 control-label">
                            </label>
                            <div class="col-sm-3">
                                <asp:Label ID="lblmobile" runat="server" Font-Bold="true" Visible="false"></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Email
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtEmail" Type="Email" MaxLength="100" runat="server" AutoPostBack="true" Required="" OnTextChanged="txtEmail_TextChanged"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group" id="divEmail" runat="server" visible="false">
                            <label class="col-sm-9 control-label">
                            </label>
                            <div class="col-sm-3">
                                <asp:Label ID="lblEmail" runat="server" Font-Bold="true" Visible="false"></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Experience
                            </label>
                            <div class="col-sm-1">
                                <asp:TextBox ID="txtYears" type="number" min="0" max="50" MaxLength="2" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-sm-1">
                                <h5>Years</h5>
                            </div>
                            <div class="col-sm-1">
                                <asp:TextBox ID="txtMonths" Type="number" min="0" max="12" MaxLength="2" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-sm-1">
                                <h5>Months</h5>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Fee
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtFee" runat="server" type="Number" MaxLength="20" Required></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Internship
                            </label>
                            <div class="col-sm-10">
                                <asp:CheckBox ID="ChkIntern" runat="server" AutoPostBack="true" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Is Exam Permit
                            </label>
                            <div class="col-sm-1">
                                <asp:CheckBox ID="chkIsExamPermit" runat="server" />
                            </div>
                        </div>
                        <div class="form-group" id="divinternBatch" runat="server">
                            <label class="col-sm-2 control-label">
                                Intern Batch
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlInternbatch" runat="server" required="">
                                </asp:DropDownList>
                            </div>
                        </div>
                         <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Subscription Expired On
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtSubscriptionExpiredOn" runat="server" Required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Upload Certificate
                            </label>
                            <div class="col-sm-10">
                                <asp:FileUpload ID="fl" runat="server" />
                                <asp:RegularExpressionValidator ID="reg1" runat="server" ErrorMessage="Please Uplaod PDf Files "
                                    ControlToValidate="fl" ValidationExpression="^(([a-zA-Z]:)|(\\{2}\w+)\$?)(\\(\w[\w].*))(.pdf|.PDF)$"
                                    ForeColor="Red"></asp:RegularExpressionValidator>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Comments
                            </label>
                            <div class="col-sm-10">
                                <CKEditor:CKEditorControl ID="txtDescription" runat="server" Height="100" Toolbar="Basic">
                                </CKEditor:CKEditorControl>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:Label ID="lblmsg" runat="server"></asp:Label>
                                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Save" />
                                <asp:Button ID="btnAssignDefaultFeatures" runat="server" SkinID="btnBack" OnClick="btnAssignDefaultFeatures_Click" Visible="false" Text="Assign Default Features" />
                                <asp:Button ID="btnAssignFeatures" runat="server" OnClick="btnAssignFeatures_Click" Visible="false" Text="Assign Features" />
                                <asp:Button ID="btnCancel" runat="server" SkinID="btnBack" Text="Back to list" UseSubmitBehavior="false"
                                    OnClick="btnCancel_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        </div>
        <!-- Row End -->
    <script type="text/javascript" src="../App_Themes/admin/js/jquery.js"></script>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery-ui-v1.10.3.js"></script>

    <script type="text/javascript">
        $(document).ready(function ($) {

            $("input[id$=txtSubscriptionExpiredOn]").datepicker({
                value: new Date().toDateString(),
                changeMonth: true,
                changeYear: true,
                changeprevious: true,
                dateFormat: 'dd/mm/yy',
                //maxDate: "0",
                //minDate: "0",
            });
        });
    </script>
</asp:Content>
