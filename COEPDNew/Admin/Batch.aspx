<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="Batch.aspx.cs" Inherits="Batch" %>

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
                                <asp:DropDownList ID="ddlStatus" runat="server" required="">
                                    <asp:ListItem Text="-- Select --" Value=""></asp:ListItem>
                                    <asp:ListItem Text="New" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="Running" Value="2"></asp:ListItem>
                                    <asp:ListItem Text="Completed" Value="3"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Batch Date
                            </label>
                            <div class="col-sm-10">
                                <div class="row">
                                    <div class="col-lg-1 col-md-1">
                                        <asp:TextBox ID="txtDay" min="1" Max="31" runat="server" type="number" Required="" Width="60px"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-1 col-md-1">
                                        <asp:TextBox ID="txtMonth" min="1" Max="12" runat="server" type="number" Required="" Width="60px"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-2 col-md-2">
                                        <asp:TextBox ID="txtYear" runat="server" type="number" Required=""></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Course
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlCourse" runat="server" Required="">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Batch Type
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlBatchType" runat="server" Required="">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Location
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlLocation" runat="server" Required="">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Trainer
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlEmployee"  runat="server" Required="">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                              Batch Timings
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlBatchTime" runat="server" Required="">
                                </asp:DropDownList>
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