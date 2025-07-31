<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true" CodeFile="BestPractices.aspx.cs" Inherits="BestPractices" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
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
                            Stream
                            </label>
                            <div class="col-md-3">
                                 <asp:TextBox ID="txtStream"   MaxLength="500" runat="server" ></asp:TextBox>       
                                </div>
                        </div>                                                                                                                          
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                            Practices
                            </label>
                            <div class="col-sm-10">
                                <CKEditor:CKEditorControl runat="server" ID="txtPractices">
                                </CKEditor:CKEditorControl>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:Button ID="btnSubmit" runat="server"  Text="Save" OnClick="btnSubmit_Click" />
                                <asp:Button ID="btnCancel" runat="server" Text="Back to list" AutoPostBack="true" OnClick="btnCancel_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Row End -->
</asp:Content>