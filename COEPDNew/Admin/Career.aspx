<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true"
    CodeFile="Career.aspx.cs" Inherits="Career" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
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
                                Email Id
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtEmail" runat="server" Required=""></asp:TextBox>
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
                                Job Date
                            </label>
                            <div class="col-sm-1">
                                <asp:TextBox ID="txtDay" runat="server" type="number" min="1" max="31" Required="" placeholder="DD"></asp:TextBox>
                            </div>
                            <div class="col-sm-1">
                                <asp:TextBox ID="txtMonth" runat="server" type="number" min="1" max="12" Required="" placeholder="MM"></asp:TextBox>
                            </div>
                            <div class="col-sm-2">
                                <asp:TextBox ID="txtYear" runat="server" type="number" MaxLength="4" Required="" placeholder="YYYY"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Job Title
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Key Skills
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtSkills" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Years Of Experience
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtYearofExp" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Job Description
                            </label>
                            <div class="col-sm-10">
                                <CKEditor:CKEditorControl ID="txtDescription" runat="server" Height="200" Toolbar="Basic">
                                </CKEditor:CKEditorControl>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                IsActive
                            </label>
                            <div class="col-sm-10">
                                <asp:CheckBox ID="chkActive" runat="server" />
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Save" />
                                <asp:Button ID="btnCancel" runat="server" Text="Back to list" UseSubmitBehavior="false"
                                    OnClick="btnCancel_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Row End -->
</asp:Content>