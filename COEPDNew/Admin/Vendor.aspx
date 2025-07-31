<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="Vendor.aspx.cs" Inherits="Vendor" %>


<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" Runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
                                Category
                            </label>
                            <div class="col-sm-10">
                                 <asp:DropDownList ID="ddlVendorCategory" runat="server" Required="">
                                </asp:DropDownList>
                            </div>
                        </div>
                          <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Location
                            </label>
                            <div class="col-sm-10">
                                 <asp:DropDownList ID="ddlLocation" AutoPostBack="true" runat="server" Required="">
                                </asp:DropDownList>
                            </div>
                        </div>
                         <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Vendor Office Address
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtofficeaddress"  runat="server" ></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Vendor
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtVendor" runat="server"   Required=""></asp:TextBox>
                            </div>
                        </div>
                         <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Contact Name
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtContactName"   runat="server" ></asp:TextBox>
                            </div>
                        </div>
                         <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Email
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtEmail" type="email"  runat="server" ></asp:TextBox>
                            </div>
                        </div>
                         <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Mobile
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtMobile" type="number"   placeholder="Please enter a ten digit phone number" runat="server" Required=""></asp:TextBox>
                            </div>
                        </div>
                         <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Phone
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtPhone" type="number" runat="server" ></asp:TextBox>
                            </div>
                        </div>
                         <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Website
                            </label>
                            <div class="col-sm-10"> 
                                <asp:TextBox ID="txtWebsite"  placeholder="www.xyz.com" runat="server" ></asp:TextBox>
                            </div>
                        </div>
                  <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Notes
                            </label>
                            <div class="col-sm-10">
                                <CKEditor:CKEditorControl ID="txtNotes" runat="server" Height="200" Toolbar="Basic">
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

