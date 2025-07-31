<%@ Page Title="" Language="C#" MasterPageFile="~/Participant/Participant.master" AutoEventWireup="true" CodeFile="RequestFAQs.aspx.cs" Inherits="Participant_RequestFAQs" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
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
            $("input[id$=txtInterviewDate]").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: 'dd/mm/yy',
                minDate: "0"
            });
        });
        function alertmeSave() {
            Swal.fire(
                      'Request FAQs Sent Successfully',
                      '',
                      'success'
                    )
        }
        function alertmeUpdate() {
            Swal.fire(
                      'Request FAQs Updated Successfully',
                      '',
                      'success'
                    )
        }

        function alertmeDuplicate() {
            Swal.fire(
                      'Request FAQs already exist',
                      '',
                      'warning'
                    )
        }
        function alertmeFileUpload() {
            Swal.fire(
                'Upload Proof Of InterView Mandatory',
                '',
                'warning'
            )
        }
    </script>
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
                        <asp:Label ID="lblTitle" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">
                        <div class="form-group" id="divParticipant" runat="server">
                            <label class="col-sm-3 control-label">
                                Participant Name 
                            </label>
                            <div class="col-sm-6">
                                :<asp:Label runat="server" ID="lblParticipant">
                                    
                                </asp:Label>
                                <asp:HiddenField runat="server" ID="hdnRSId" />
                                <asp:HiddenField runat="server" ID="hdnISId" />
                            </div>
                        </div>
                        <div id="divCompany" runat="server">
                             <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Company Name
                            </label>
                            <div class="col-sm-6">
                                 <%--<asp:TextBox runat="server" ID="txtCompanyName" Required=""></asp:TextBox>--%>
                                :<asp:Label runat="server" ID="lblCompanyName" />
                            </div>
                        </div>
                        </div>
                       
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                               Interview Date On<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtInterviewDate" runat="server" required="" AutoPostBack="true" OnTextChanged="txtInterviewDate_TextChanged"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group" id="divAttachments" runat="server">
                            <label class="col-sm-3 control-label">
                                Attachments
                            </label>
                            <div class="col-sm-9">
                                <h5>
                                    <asp:HyperLink ID="hplSentFile" runat="server" CssClass="btn btn-success btn-sm" Target="_blank" Visible="false">View Proof of Interview</asp:HyperLink>
                                    <asp:HyperLink ID="hplReplyFile" runat="server" CssClass="btn btn-primary btn-sm" Target="_blank" Visible="false">View FAQs</asp:HyperLink>
                                </h5>
                            </div>
                        </div>
                        <div>
                            <div class="form-group" id="divUpload" runat="server">
                                <label class="col-sm-3 control-label">
                                    Upload Proof Of Interview<sup class="sup">*</sup>
                                </label>
                                <div class="col-sm-4">
                                    <asp:FileUpload ID="flUpload" runat="server" />
                                    <asp:RequiredFieldValidator runat="server" ID="ReqFileUpload" ControlToValidate="flUpload" ErrorMessage="Upload Proof Of InterView" ForeColor="Red" Font-Names="Verdana" Font-Size="10"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-sm-5">
                                    <small>( Max 10 MB )</small>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                              Special Notes<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtNotes" runat="server" required="" TextMode="MultiLine"></asp:TextBox>
                            </div>
                        </div>
                         <div class="form-group" id="divCKEditor" runat="server">
                            <label class="col-sm-2 control-label">
                                FAQs<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-10">
                                <CKEditor:CKEditorControl runat="server" ID="txtNote" Required="">
                                </CKEditor:CKEditorControl>
                            </div>
                        </div>

                        <div class="form-group">
                            <div class="col-sm-offset-3 col-sm-9">
                                <asp:Button ID="btnSubmit" runat="server" SkinID="btnBack" OnClick="btnSubmit_Click" Text="Request FAQs" />
                                <asp:Button ID="btnCancel" runat="server" Text="Back to list" UseSubmitBehavior="false"
                                    OnClick="btnCancel_Click" CausesValidation="false" />
                            </div>
                        </div>

                    </div>
                </div>
            </div>

        </div>
    </div>

</asp:Content>
