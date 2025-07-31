<%@ Page Title="" Language="C#" MasterPageFile="~/Participant/Participant.master" AutoEventWireup="true" CodeFile="FAQsMaster.aspx.cs" Inherits="Participant_FAQsMaster" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <script type="text/javascript">
        function alertmeSave() {
            Swal.fire(
                'FAQs Added Successfully',
                '',
                'success'
            )
        }
        function alertmeUpdate() {
            Swal.fire(
                'FAQs Updated Successfully',
                '',
                'success'
            )
        }

        function alertmeDuplicate() {
            Swal.fire(
                'FAQs already exist',
                '',
                'warning'
            )
        }
     </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="row">
        <div class="col-sm-12 col-xs-12">
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
                                Company Name<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:TextBox runat="server" ID="txtCompany" Required=""></asp:TextBox>
                                <asp:HiddenField runat="server" ID="hdnFAQsId" Value="0" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Experience<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:TextBox runat="server" ID="txtExperience" Required=""></asp:TextBox>
                            </div>
                        </div>
                         <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Interview Round<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                               <asp:DropDownList runat="server" ID="ddlInterviewStatus" Required=""></asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                SkilSet<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:TextBox runat="server" ID="txtSkilSet" Required=""></asp:TextBox>
                            </div>
                        </div>
                       
                         <div class="form-group">
                            <label class="col-sm-2 control-label">
                                NoOfQuestions<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:TextBox ID="txtNoOfQuestions" runat="server" required="" TextMode="Number"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                FAQs<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-10">
                                <CKEditor:CKEditorControl runat="server" ID="txtFAQNote" Required="">
                                </CKEditor:CKEditorControl>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:Button ID="btnSubmit" runat="server" SkinID="btnBack" OnClick="btnSubmit_Click" Text="Save FAQs" />
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

