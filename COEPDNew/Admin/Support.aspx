<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="Support.aspx.cs" Inherits="Admin_Support" %>



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
                               Support Type
                            </label>
                            <div class="col-sm-10">
                               <asp:DropDownList ID="ddlSupportType" runat="server" Required>
                                    
                                </asp:DropDownList>
                            </div>
                        </div>
                         <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Priority
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlPriority" runat="server" Required>
                                    <asp:ListItem Text="-- Select Priority --" Value=""></asp:ListItem>
                                    <asp:ListItem Text="High" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="Medium" Value="2"></asp:ListItem>
                                    <asp:ListItem Text="Low" Value="3"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                         <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Subject
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtSubject"   MaxLength="500" runat="server" Required=""></asp:TextBox>
                            </div>
                        </div>
                        
                        
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Description
                            </label>
                            <div class="col-sm-10">
                                <CKEditor:CKEditorControl ID="txtDescription" MaxLength="5000" runat="server" Height="200" Toolbar="Basic">
                                </CKEditor:CKEditorControl>
                            </div>
                        </div>

                        
                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Save" />
                                <asp:Button ID="btnCancel" runat="server" Text="Back to List" UseSubmitBehavior="false"
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

