<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="InternParticipant.aspx.cs" Inherits="Admin_InternParticipant" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
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
                                <asp:DropDownList ID="ddlStatus" runat="server" Required="">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Batch
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlBatch" runat="server" Required="">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Reference No
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtReferenceNo" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Participant
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtParticipant" runat="server" Required=""></asp:TextBox>
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
                                <asp:TextBox ID="txtMobile" runat="server" Required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Email
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtEmail" runat="server" Required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Experience
                            </label>
                            <div class="col-sm-1">
                                <asp:TextBox ID="txtYears" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-sm-1">
                                Years
                            </div>
                            <div class="col-sm-1">
                                <asp:TextBox ID="txtMonths" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-sm-1">
                                Months
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Fee
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtFee" runat="server" type="Number" Required=""></asp:TextBox>
                            </div>
                        </div>
                    <%--  <div class="form-group">
                            <label class="col-sm-2 control-label">
                               Internship
                            </label>
                            <div class="col-sm-10">
                                <asp:CheckBox ID="ChkIntern" disable="true" runat="server" />
                            </div>
                        </div>--%>
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
                                <asp:Button ID="btnCancel" runat="server" Text="Back to list" UseSubmitBehavior="false"
                                    OnClick="btnCancel_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Row End -->
</asp:Content>