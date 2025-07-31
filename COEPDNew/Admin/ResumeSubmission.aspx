<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ResumeSubmission.aspx.cs" Inherits="Admin_ResumeSubmission" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
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
    <script type="text/javascript" src="../App_Themes/admin/js/jquery.js"></script>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery-ui-v1.10.3.js"></script>
    <script type="text/javascript">
        $(document).ready(function ($) {
            $("[id*=txtAppliedOn]").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: 'dd/mm/yy',
                maxDate: "0",
            });
        });
        $(document).ready(function ($) {
            $("[id*=txtDateofJoining]").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: 'dd/mm/yy',
            });
        });
        function alertmeSave() {
            Swal.fire(
                'Details successfully Added',
                '',
                'success'
            )
        }
        function alertmeUpdate() {
            Swal.fire(
                'Details successfully updated',
                '',
                'success'
            )
        }

        function alertmeDuplicate() {
            Swal.fire(
                'Details already exist',
                '',
                'warning'
            )
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Row Start -->
    <div class="row">
        <div class="col-sm-8 col-xs-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        <asp:Label ID="lblTitle" runat="server" />
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">
                        <div class="form-group" id="divParticipant" runat="server">
                            <label class="col-sm-2 control-label">
                                Participant <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:TextBox ID="txtSearch" runat="server" required="required" AutoPostBack="true" OnTextChanged="txtSearch_TextChanged"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Select Participant<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:DropDownList ID="ddlParticipant" runat="server" required="" OnSelectedIndexChanged="ddlParticipant_SelectedIndexChanged">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Company Name <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:TextBox ID="txtCompanyName" Required="" runat="server" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                JobDescription <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-8">
                                <%-- <asp:TextBox ID="txtJobDescription" runat="server" Required="" />--%>
                                <CKEditor:CKEditorControl runat="server" ID="txtJobDescription">
                                </CKEditor:CKEditorControl>

                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Location <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:TextBox ID="txtLocation" runat="server" Required="" />

                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Experience <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:TextBox ID="txtExperience" runat="server" Required="" />

                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Domain <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:TextBox ID="txtDomain" runat="server" Required="" />

                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Applied Through <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:DropDownList ID="ddlAppliedThrough" runat="server" required="">
                                    <asp:ListItem Text="--Select Applied Through--" Value=""></asp:ListItem>
                                    <asp:ListItem Text="Through Job Portal(Naukari, Monster etc.,)" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="Reference" Value="2"></asp:ListItem>
                                    <asp:ListItem Text="COEPD Portal" Value="3"></asp:ListItem>
                                    <asp:ListItem Text="COEPD Job-Market" Value="4"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Applied On <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:TextBox ID="txtAppliedOn" runat="server" Required="" />

                            </div>
                        </div>
                        <div id="divOnJobSupport" runat="server" visible="false">
                            <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    Designation <sup class="sup">*</sup>
                                </label>
                                <div class="col-sm-6">
                                    <asp:TextBox ID="txtDesignation" runat="server" Required="" />
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    Package Offered<sup class="sup">*</sup>
                                    <h6>(per anum)</h6>
                                </label>
                                <div class="col-sm-6">
                                    <asp:TextBox ID="txtPackageOffered" runat="server" Required="" />
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    Date of Joining <sup class="sup">*</sup>
                                </label>
                                <div class="col-sm-6">
                                    <asp:TextBox ID="txtDateofJoining" runat="server" placeholder="dd/MM/YYYY" Required="" />
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Interview Status<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:DropDownList runat="server" ID="ddlInterviewStatus" Required="" OnSelectedIndexChanged="ddlInterviewStatus_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                            </div>
                        </div>





                        <div class="form-group"  id="divSelected" runat="server" visible="false">
                            <label class="col-sm-2 control-label">
                               Participant Selected/Rejected
                            </label>
                            <div class="col-sm-6">
                                <asp:DropDownList ID="ddlSelectorRejected" runat="server" OnSelectedIndexChanged="ddlSelectorRejected_SelectedIndexChanged" AutoPostBack="false">
                                    <asp:ListItem Text="--Selected/Rejected --" Value=""></asp:ListItem>
                                    <asp:ListItem Text="Selected"  Value="Selected"></asp:ListItem>
                                    <asp:ListItem Text="Rejected"  Value="Rejected" ></asp:ListItem>
                                 <%--   <asp:ListItem Text="COEPD Placement Wing" Value="4"></asp:ListItem>--%>
                                </asp:DropDownList>
                            </div>
                        </div>

                        <div class="form-group" id="divRemarks" runat="server" >
                            <label class="col-sm-2 control-label">
                                Remarks
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtRemarks" runat="server" TextMode="MultiLine"></asp:TextBox>
                            </div>
                        </div>








                        <div class="form-group">
                            <div class="col-sm-offset-3 col-sm-10">
                                <asp:Button ID="btnSubmit" runat="server" SkinID="btnGreen" Text="Submit" OnClick="btnSubmit_Click" />
                                <asp:Button ID="btnCancel" runat="server" Text="Back To List" UseSubmitBehavior="false" OnClick="btnCancel_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

