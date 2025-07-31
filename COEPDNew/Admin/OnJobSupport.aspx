<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="OnJobSupport.aspx.cs" Inherits="Admin_OnJobSupport" %>

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
    <a href="../Participant/ReferFriend.aspx">../Participant/ReferFriend.aspx</a>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery-ui-v1.10.3.js"></script>
    <script type="text/javascript">
        $(document).ready(function ($) {
            $("input[id$=txtTargetDate]").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: 'dd/mm/yy',
                maxDate: "0"
            });
        });
        function alertmeSave() {
            Swal.fire(
                      'On Job Support Inputs Sent Successfully',
                      '',
                      'success'
                    )
        }
        function alertmeUpdate() {
            Swal.fire(
                      'On Job Support Inputs Successfully',
                      '',
                      'success'
                    )
        }

        function alertmeDuplicate() {
            Swal.fire(
                      'On Job Support Inputs already exist',
                      '',
                      'warning'
                    )
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <!-- Row Start -->
    <div class="row">
        <div class="col-sm-8 col-xs-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        <asp:Label ID="lblTitle" runat="server">On Job Support</asp:Label>
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
                                <asp:HiddenField runat="server" ID="hdnParticipantId" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Project<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:TextBox runat="server" ID="txtProject" Required=""></asp:TextBox>
                               <%-- <asp:HiddenField runat="server" ID="hdnRSId" />--%>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Inputs<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtNotes" runat="server" required="" TextMode="MultiLine"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group" id="divAttachments" runat="server">
                            <label class="col-sm-3 control-label">
                                Attachments
                            </label>
                            <div class="col-sm-6">
                                <h5>
                                    <asp:HyperLink ID="hplSentFile" runat="server" CssClass="btn btn-success btn-sm" Target="_blank" Visible="false">View Proof of Google Review</asp:HyperLink>

                                    <%--<asp:HyperLink ID="hplReplyFile" runat="server" CssClass="btn btn-primary btn-sm" Target="_blank" Visible="false">View GoogleReview</asp:HyperLink>--%>

                                    <asp:HyperLink ID="hplReplyFile" runat="server" CssClass="btn btn-success btn-sm" Target="_blank" Visible="false">View Proof of CaseStudy</asp:HyperLink>

                                    <asp:HyperLink ID="hplReplyCaseStudeyFile" runat="server" CssClass="btn btn-primary btn-sm" Target="_blank" Visible="false">View Casestudy Answer</asp:HyperLink>
                                </h5>
                            </div>
                        </div>
                        <div>
                            <div class="form-group" id="divUpload" runat="server">
                                <div class="form-group">
                                      <label class="col-sm-3 control-label">
                                   Upload Inputs<%--<sup class="sup">*</sup>--%>
                                </label>
                                <div class="col-sm-4">
                                    <asp:FileUpload ID="flUploadReplyCaseStudeyFile" runat="server" />
                                   <%-- <asp:RequiredFieldValidator runat="server" ID="ReqFileUpload" ControlToValidate="flUploadReplyCaseStudeyFile" ErrorMessage="Upload Answer" ForeColor="Red" Font-Names="Verdana" Font-Size="10"></asp:RequiredFieldValidator>--%>
                                </div>
                                <div class="col-sm-5">
                                    <small>( Max 10 MB )</small>
                                </div>
                                </div>
                            </div>
                               
                        </div>



                        <div class="form-group">
                            <div class="col-sm-offset-3 col-sm-10">
                                <asp:Button ID="btnSubmit" runat="server" SkinID="btnBack" OnClick="btnSubmit_Click" Text="Send Inputs" />
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

