<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="SuccessStories.aspx.cs" Inherits="Admin_SuccessStories" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" Runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
                                Success Stories Name
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtSuccessStoriesName"  MaxLength="500" runat="server" Required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Display In HomePage?
                            </label>
                            <div class="col-sm-10">
                                <asp:CheckBox ID="chkFeatured" runat="server" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Upload Success Story
                            </label>
                            <div class="col-sm-10">
                                <asp:Image ID="ImgPhoto" runat="server" Width="150px" />
                                <asp:FileUpload ID="flUpload" runat="server" />
                                <asp:RequiredFieldValidator runat="server" ID="ReqFileUpload" ControlToValidate="flUpload" ErrorMessage="Upload BA Placements" ForeColor="Red" Font-Names="Verdana" Font-Size="10"></asp:RequiredFieldValidator>
                                <asp:HiddenField ID="hdnImagePath" runat="server" />
                                <asp:HiddenField ID="hdnImageThumbPath" runat="server" />
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Save" />
                                <asp:Button ID="btnCancel" runat="server" Text="Back to list" UseSubmitBehavior="false" CausesValidation="false"
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

