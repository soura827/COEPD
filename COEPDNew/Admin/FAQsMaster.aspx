<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="FAQsMaster.aspx.cs" Inherits="Admin_FAQsMaster" %>

<%--<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>--%>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        function alertmeSave() {
            Swal.fire(
                'KPI Added Successfully',
                '',
                'success'
            )
        }
        function alertmeUpdate() {
            Swal.fire(
                'KPI Updated Successfully',
                '',
                'success'
            )
        }

        function alertmeDuplicate() {
            Swal.fire(
                'KPI already exist',
                '',
                'warning'
            )
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
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
                                <asp:HiddenField runat="server" ID="hdnHrRequestFAQsId" Value="0" />
                                <asp:HiddenField runat="server" ID="hdnRSId" Value="0" />
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
                                SkilSet<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:TextBox runat="server" ID="txtSkilSet" Required=""></asp:TextBox>
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
                            <label class="col-sm-2 control-label">
                                <asp:Label ID="lblIsRevised" runat="server" Text="Is Revised & Approved" Visible="false"></asp:Label>
                            </label>
                            <div class="col-sm-3">
                                <asp:CheckBox ID="chkIsReviesed" runat="server" required="" Visible="false" />
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


