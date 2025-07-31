<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="BranchEmployeeNews.aspx.cs" Inherits="Admin_BranchEmployeeNews" %>
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
                                Select Location <asp:Label runat="server" ID="LocationStar" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                             <asp:DropDownList ID="ddlLocation" runat="server" required="" AutoPostBack="true" OnSelectedIndexChanged="ddlLocation_SelectedIndexChanged" ></asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Select Branch <asp:Label runat="server" ID="BranchStar" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                                <asp:DropDownList ID="ddlBranch" runat="server" required="" AutoPostBack="true"></asp:DropDownList>
                            </div>
                        </div>
                          <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Enter Branch Employee News <asp:Label runat="server" ID="PageStar" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtNewsDescription" runat="server" MaxLength="10000" required="" AutoPostBack="true" TextMode="MultiLine" Height="200" ></asp:TextBox>
                            </div>
                        </div>
                         <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:Button ID="btnSubmit" runat="server"  Text="Save" OnClick="btnSubmit_Click" />
                                <asp:Button ID="btnCancel" runat="server" Text="Back to list" UseSubmitBehavior="false" OnClick="btnCancel_Click" />
                            </div>
                        </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
