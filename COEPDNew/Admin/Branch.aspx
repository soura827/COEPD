<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="Branch.aspx.cs" Inherits="Branch" %>

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
                                Location Name <asp:Label runat="server" ID="star" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                             <asp:DropDownList ID="ddlLocation" runat="server" required="" AutoPostBack="true">
                             </asp:DropDownList>
                            </div>
                        </div>
                        <div class ="form-group">
                            <label class ="col-sm-2 control-label">
                                Branch Code<asp:Label runat="server" ID="CodeStar" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class ="col-sm-5">
                                <asp:TextBox ID="txtCode" runat="server" MaxLength="50" required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Branch Name <asp:Label runat="server" ID="SubcagegoryStar" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label> 
                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtBranch" runat="server" MaxLength="5000" required="" OnTextChanged="txtBranch_TextChanged" AutoPostBack="true"></asp:TextBox>
                            </div>
                        </div>
                        <div class ="form-group">
                            <label class ="col-sm-2 control-label">
                                Address Line1<asp:Label runat="server" ID="Line1Star" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class ="col-sm-5">
                                <asp:TextBox ID="txtAddress1" runat="server" MaxLength="1000" required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class ="form-group">
                            <label class ="col-sm-2 control-label">
                                Address Line2
                            </label>
                            <div class ="col-sm-5">
                                <asp:TextBox ID="txtAddress2" runat="server" MaxLength="1000"></asp:TextBox>
                            </div>
                        </div>
                        <div class ="form-group">
                            <label class ="col-sm-2 control-label">
                                City Name<asp:Label runat="server" ID="CityStar" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class ="col-sm-5">
                                <asp:TextBox ID="txtCity" runat="server" MaxLength="250" required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class ="form-group">
                            <label class ="col-sm-2 control-label">
                                State Name<asp:Label runat="server" ID="StateStar" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class ="col-sm-5">
                                <asp:TextBox ID="txtStateName" runat="server" MaxLength="250" required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class ="form-group">
                            <label class ="col-sm-2 control-label">
                                Country Name<asp:Label runat="server" ID="CountryStar" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class ="col-sm-5">
                                <asp:TextBox ID="txtCountry" runat="server" MaxLength="250" required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class ="form-group">
                            <label class ="col-sm-2 control-label">
                                Zipcode<asp:Label runat="server" ID="ZipStar" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class ="col-sm-5">
                                <asp:TextBox ID="txtZipcode" runat="server" MaxLength="10" required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class ="form-group">
                            <label class ="col-sm-2 control-label">
                                Mobile Number<asp:Label runat="server" ID="MobileStar" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class ="col-sm-5">
                                <asp:TextBox ID="txtMobile" runat="server" MaxLength="500" required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class ="form-group">
                            <label class ="col-sm-2 control-label">
                                Land Line Number
                            </label>
                            <div class ="col-sm-5">
                                <asp:TextBox ID="txtPhone" runat="server" MaxLength="100"></asp:TextBox>
                            </div>
                        </div>
                        <div class ="form-group">
                            <label class ="col-sm-2 control-label">
                                Email Id<asp:Label runat="server" ID="EmailStar" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class ="col-sm-5">
                                <asp:TextBox ID="txtEmail" runat="server" MaxLength="250" required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class ="form-group">
                            <label class ="col-sm-2 control-label">
                                Langitude
                            </label>
                            <div class ="col-sm-5">
                                <asp:TextBox ID="txtLangitude" runat="server" MaxLength="100"></asp:TextBox>
                            </div>
                        </div>
                        <div class ="form-group">
                            <label class ="col-sm-2 control-label">
                                Latitude
                            </label>
                            <div class ="col-sm-5">
                                <asp:TextBox ID="txtLatitude" runat="server" MaxLength="100"></asp:TextBox>
                            </div>
                        </div>
                         <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:Button ID="btnSubmit" runat="server"  Text="Save" OnClick="btnSubmit_Click" />
                                <asp:Button ID="btnCancel" runat="server" Text="Back to list" UseSubmitBehavior="false" onclick="btnCancel_Click"/>
                            </div>
                        </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    <!-- Row End -->
</asp:Content>