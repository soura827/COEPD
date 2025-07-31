<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="Job.aspx.cs" Inherits="Job" %>

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
                                Job Category
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlJobCategory" runat="server" Required="">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Job Domain
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlJobDomain" runat="server">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Job Title
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtJobTitle" MaxLength="500" runat="server" Required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Job Date
                            </label>
                            <div class="col-sm-10">
                                <div class="col-lg-1 col-md-1">
                                    <asp:TextBox ID="txtDay" runat="server" type="number" MaxLength="2" Required="" Width="70px"></asp:TextBox>
                                </div>
                                <div class="col-lg-1 col-md-1">
                                    <asp:TextBox ID="txtMonth" runat="server" type="number" MaxLength="2" Required="" Width="70px"></asp:TextBox>
                                </div>
                                <div class="col-lg-2 col-md-2">
                                    <asp:TextBox ID="txtYear" runat="server" type="number" MaxLength="4" Required=""></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Location
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtLocation" MaxLength="500" runat="server" Required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Company
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtCompany" MaxLength="500" runat="server" Required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Phone
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtPhone" runat="server" MaxLength="20" type="number"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Email
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtEmail" runat="server" MaxLength="100" Type="Email"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Years of Experience
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtExperience" runat="server" MaxLength="500" Required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Weblink
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtWeblink" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Full Description
                            </label>
                            <div class="col-sm-10">
                                <CKEditor:CKEditorControl ID="txtFullDescription" runat="server" Height="200" Toolbar="Basic" Required="">
                                </CKEditor:CKEditorControl>
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