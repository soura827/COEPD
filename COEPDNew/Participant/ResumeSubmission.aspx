<%@ Page Title="" Language="C#" MasterPageFile="~/Participant/Participant.master" AutoEventWireup="true" CodeFile="ResumeSubmission.aspx.cs" Inherits="Participant_ResumeSubmission" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <%--<script src="https://cdn.ckeditor.com/ckeditor5/35.3.2/classic/ckeditor.js"></script>
     <script>
         ClassicEditor
             .create(document.querySelector('#txtJobDescription'))
             .then(editor => {
                 console.log(editor);
             })
             .catch(error => {
                 console.error(error);
             });
     </script>--%>
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
    </script>
    <%--    <script type="text/javascript">
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
    </script>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
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
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Company Name <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtCompanyName" Required="" runat="server" />
                            </div>
                        </div>
                        <%--  <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Job Description <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtJobDescription" runat="server" Required="" />

                            </div>
                        </div>--%>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Location <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtLocation" runat="server" Required="" />

                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Experience <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtExperience" runat="server" Required="" />

                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Domain <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtDomain" runat="server" Required="" />

                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Applied Through <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-5">
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
                            <label class="col-sm-3 control-label">
                                Applied On <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtAppliedOn" runat="server" Required="" />

                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Job Description
                            </label>
                            <div class="col-sm-10">
                                <CKEditor:CKEditorControl runat="server" ID="txtJobDescription">
                                </CKEditor:CKEditorControl>
                                <%--<CKEditor:CKEditorControl runat="server" ID="txtFAQNote" Required="">
                                </CKEditor:CKEditorControl>--%>
                            </div>
                        </div>

                        <div id="divOnJobSupport" runat="server" visible="false">
                            <div class="form-group">
                                <label class="col-sm-3 control-label">
                                    Designation <sup class="sup">*</sup>
                                </label>
                                <div class="col-sm-5">
                                    <asp:TextBox ID="txtDesignation" runat="server" Required="" />
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-3 control-label">
                                    Package Offered<sup class="sup">*</sup>
                                    <h6>(per anum)</h6>
                                </label>
                                <div class="col-sm-5">
                                    <asp:TextBox ID="txtPackageOffered" runat="server" Required="" />
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-3 control-label">
                                    Date of Joining <sup class="sup">*</sup>
                                </label>
                                <div class="col-sm-5">
                                    <asp:TextBox ID="txtDateofJoining" runat="server" Required="" />
                                </div>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Interview Status<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-5">
                                <asp:DropDownList runat="server" ID="ddlInterviewStatus" AutoPostBack="true" OnSelectedIndexChanged="ddlInterviewStatus_SelectedIndexChanged" Required=""></asp:DropDownList>
                            </div>
                        </div>




                        <div class="form-group" id="divSelected" runat="server" visible="false">
                            <label class="col-sm-2 control-label">
                                Participant Selected/Rejected
                            </label>
                            <div class="col-sm-6">
                                <asp:DropDownList ID="ddlSelectorRejected" runat="server" OnSelectedIndexChanged="ddlSelectorRejected_SelectedIndexChanged" AutoPostBack="false">
                                    <asp:ListItem Text="--Selected/Rejected --" Value=""></asp:ListItem>
                                    <asp:ListItem Text="Selected" Value="Selected"></asp:ListItem>
                                    <asp:ListItem Text="Rejected" Value="Rejected"></asp:ListItem>

                                </asp:DropDownList>
                            </div>
                        </div>

                            <div class="form-group" id="divRemarks" runat="server" visible="false">
                                <label class="col-sm-3 control-label">
                                    Remarks <sup class="sup">*</sup>
                                </label>
                                <div class="col-sm-5">
                                    <asp:TextBox ID="Remarks" runat="server" TextMode ="MultiLine"   />
                                </div>
                            </div>





                        <div class="form-group">
                            <div class="col-sm-offset-3 col-sm-10">
                                <asp:Button ID="btnSubmit" runat="server" SkinID="btnGreen" Text="Submit" OnClick="btnSubmit_Click1" />
                                <asp:Button ID="btnCancel" runat="server" Text="Back To List" UseSubmitBehavior="false" OnClick="btnCancel_Click" />
                            </div>

                        </div>
                        <div id="divFeedback" runat="server" visible="false">
                            <div class="form-group">
                                <label class="col-sm-6 control-label">
                                    <%--Would you like to share your feedback on COEPD? --%>
                                    Please share your Happiness and help others :)
                                </label>
                                <div class="col-sm-6">
                                    <asp:HyperLink ID="hpl" runat="server" Text="Click Here" Target="_blank" CssClass="btn btn-success btn-sm"></asp:HyperLink>
                                    <%--<asp:Button ID="btnClickHere" runat="server" Text="Click Here" OnClick="btnClickHere_Click" />--%>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>

