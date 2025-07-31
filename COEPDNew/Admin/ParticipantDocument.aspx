<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true"
    CodeFile="ParticipantDocument.aspx.cs" Inherits="ParticipantDocument" %>

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
                                Document Category
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlDocCategory" runat="server" required="">
                                    <%--<asp:ListItem Text="--- Select Document ---" Value=""></asp:ListItem>--%>
                                    <asp:ListItem Text="Document" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="Special Document" Value="2"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Document
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtDocument" MaxLength="500" runat="server" Required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                File Upload
                            </label>
                            <div class="col-sm-10">
                                <asp:FileUpload ID="flUpload" runat="server" />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-2">
                                <asp:HiddenField ID="hdnDocPath" runat="server" />
                            </div>
                            <div class="col-md-8">
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
    <div class="box-theme">
        <div class="box-title">
            <div class="box-head">
            </div>
        </div>
        <div class="form-group">
            <div class="form-horizontal no-margin">
            </div>
        </div>
    </div>
</asp:Content>

