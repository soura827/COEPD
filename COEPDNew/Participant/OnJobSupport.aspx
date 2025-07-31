<%@ Page Title="" Language="C#" MasterPageFile="~/Participant/Participant.master" AutoEventWireup="true" CodeFile="OnJobSupport.aspx.cs" Inherits="Participant_OnJobSupport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        function alertmeSave() {
            Swal.fire(
                'On Job Support Request Sent Successfully',
                '',
                'success'
            )
        }
        function alertmeUpdate() {
            Swal.fire(
                'On Job Support Request Sent Successfully',
                '',
                'success'
            )
        }

        function alertmeDuplicate() {
            Swal.fire(
                'On Job Support Request already exist',
                '',
                'warning'
            )
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

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
                                <asp:HiddenField runat="server" ID="HiddenField1" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Project<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:TextBox runat="server" ID="txtProject" Required=""></asp:TextBox>
                                <asp:HiddenField runat="server" ID="hdnRSId" />
                            </div>
                        </div>
                        

                        <div class="form-group" id="divAttachments" runat="server">
                            <label class="col-sm-3 control-label">
                                Attachments
                            </label>
                            <div class="col-sm-6">
                                <h5>
                                    <asp:HyperLink ID="hplSentFile" runat="server" CssClass="btn btn-success btn-sm" Target="_blank" Visible="false">View Google Review</asp:HyperLink>

                                    <%--<asp:HyperLink ID="hplReplyFile" runat="server" CssClass="btn btn-primary btn-sm" Target="_blank" Visible="false">View GoogleReview</asp:HyperLink>--%>

                                    <asp:HyperLink ID="hplReplyFile" runat="server" CssClass="btn btn-warning btn-sm" Target="_blank" Visible="false">View CaseStudy</asp:HyperLink>

                                    <asp:HyperLink ID="hplReplyInputs" runat="server" CssClass="btn btn-success btn-sm" Target="_blank" Visible="false">View Inputs</asp:HyperLink>
                                </h5>
                            </div>
                        </div>
                            <div class="form-group" id="divUpload" runat="server">
                                <div class="form-group">
                                      <label class="col-sm-3 control-label">
                                    Upload Google Review<sup class="sup">*</sup>
                                </label>
                                <div class="col-sm-4">
                                    <asp:FileUpload ID="flUploadGoogleReview" runat="server" />
                                    <asp:RequiredFieldValidator runat="server" ID="ReqFileUpload" ControlToValidate="flUploadGoogleReview" ErrorMessage="Upload Google Review" ForeColor="Red" Font-Names="Verdana" Font-Size="10"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-sm-5">
                                    <small>( Max 10 MB )</small>
                                </div>
                                </div>
                              
                                <div class="form-group">
                                     <label class="col-sm-3 control-label">
                                   Upload Case Study<sup class="sup">*</sup>
                                </label>
                                <div class="col-sm-4">
                                    <asp:FileUpload ID="flUploadCaseStudy" runat="server" />
                                    <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" ControlToValidate="flUploadCaseStudy" ErrorMessage="Upload Case Study" ForeColor="Red" Font-Names="Verdana" Font-Size="10"></asp:RequiredFieldValidator>
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
                        <div class="form-group">
                            <div class="col-sm-offset-3 col-sm-10">
                                <asp:Button ID="btnSubmit" runat="server" SkinID="btnBack" OnClick="btnSubmit_Click" Text="Request Mentor Time" />
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

