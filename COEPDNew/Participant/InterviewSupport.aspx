<%@ Page Title="" Language="C#" MasterPageFile="~/Participant/Participant.master" AutoEventWireup="true" CodeFile="InterviewSupport.aspx.cs" Inherits="Participant_InterviewSupport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
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
            $("input[id$=txtTargetDate]").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: 'dd/mm/yy',
                minDate: "0"
            });
        });
        function alertmeSave() {
            Swal.fire(
                      'Interview Support Request Sent Successfully',
                      '',
                      'success'
                    )
        }
        function alertmeUpdate() {
            Swal.fire(
                      'Interview Support Request Updated Successfully',
                      '',
                      'success'
                    )
        }

        function alertmeDuplicate() {
            Swal.fire(
                      'Interview Support Request already exist',
                      '',
                      'warning'
                    )
        }
        function alertmeFileUpload() {
            Swal.fire(
                'Upload casestudy Mandatory',
                '',
                'warning'
            )
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
                                <asp:Label runat="server" ID="lblParticipant">

                                </asp:Label>
                                <asp:HiddenField runat="server" ID="hdnRSId" />
                                <asp:HiddenField runat="server" ID="hdnISId" />
                            </div>
                        </div>
                       <%-- <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Company Name<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                 <asp:TextBox runat="server" ID="txtCompanyName" Required=""></asp:TextBox>
                            </div>
                        </div>--%>
                         <div class="form-group">
                            <label class="col-sm-3 control-label">
                               Interview Date<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtTargetDate" runat="server" required="" AutoPostBack="true" OnTextChanged="txtTargetDate_TextChanged"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group" id="divAttachments" runat="server">
                            <label class="col-sm-3 control-label">
                                Attachments
                            </label>
                            <div class="col-sm-9">
                                <h5>
                                    <asp:HyperLink ID="hplSentFile" runat="server" CssClass="btn btn-success btn-sm" Target="_blank" Visible="false">View Casestudy</asp:HyperLink>
                                    <asp:HyperLink ID="hplReplyFile" runat="server" CssClass="btn btn-primary btn-sm" Target="_blank" Visible="false">View Inputs</asp:HyperLink>
                                </h5>
                            </div>
                        </div>
                        <div>
                            <div class="form-group" id="divUpload" runat="server">
                                <label class="col-sm-3 control-label">
                                    Upload Casestudy<sup class="sup">*</sup>
                                </label>
                                <div class="col-sm-4">
                                    <asp:FileUpload ID="flUpload" runat="server" />
                                    <%--<asp:RequiredFieldValidator runat="server" ID="ReqFileUpload" ControlToValidate="flUpload" ErrorMessage="Upload Casestudy" ForeColor="Red" Font-Names="Verdana" Font-Size="10" ValidationGroup="ReqFileGroup"></asp:RequiredFieldValidator>--%>
                                    <asp:RequiredFieldValidator runat="server" ID="ReqFileUpload" ControlToValidate="flUpload" ErrorMessage="Upload casestudy" ForeColor="Red" Font-Names="Verdana" Font-Size="10" ValidationGroup="ReqFileGroup"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-sm-5">
                                    <small>( Max 10 MB )</small>
                                </div>
                            </div>
                        </div>
                         <div class="form-group">
                                    <div class="col-sm-12">
                                        <h4>
                                            <asp:Label ID="lblWarning" runat="server" Text=" Warning :  Please Upload only the CaseStudy document else  this Feature will be Disabled permanently." ForeColor="red" Font-Bold="true"></asp:Label>
                                        </h4>
                                    </div>
                                </div>
                       
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                               Special Inputs<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtNotes" runat="server" required="" TextMode="MultiLine"></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group">
                            <div class="col-sm-offset-3 col-sm-9">
                                <asp:Button ID="btnSubmit" runat="server" SkinID="btnBack" OnClick="btnSubmit_Click" ValidationGroup="ReqFileGroup" Text="Request Interview Support" CausesValidation="true" UseSubmitBehavior="true" />
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

