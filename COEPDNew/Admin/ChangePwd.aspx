<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="ChangePwd.aspx.cs" Inherits="ChangePwd" %>
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
                        ReSet Password
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">
                         <div class="form-group" id="divEmployee" runat="server">
                            <label class="col-sm-2 control-label">
                                Employee <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtSearch" runat="server" AutoPostBack="true" OnTextChanged="txtSearch_TextChanged"></asp:TextBox>

                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                select Employee<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlLeadOwner" runat="server" AutoPostBack="true" OnTextChanged="ddlLeadOwner_TextChanged">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Current Password
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtOldPassword" runat="server" TextMode="Password" Required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                New Password
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtNewPassword" runat="server" TextMode="Password" Required=""></asp:TextBox>
                                <asp:RegularExpressionValidator Display="Dynamic" ControlToValidate="txtNewPassword"
                                    ID="RegularExpressionValidator1" ValidationExpression="^[\s\S]{0,8}$" runat="server"
                                    ErrorMessage="Maximum 8 characters allowed."></asp:RegularExpressionValidator>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Confirm Password
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtConfirm" runat="server" TextMode="Password" Required=""></asp:TextBox>
                                <asp:RegularExpressionValidator Display="Dynamic" ControlToValidate="txtConfirm"
                                    ID="RegularExpressionValidator2" ValidationExpression="^[\s\S]{0,8}$" runat="server"
                                    ErrorMessage="Maximum 8 characters allowed."></asp:RegularExpressionValidator>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Reason For Reset Is:
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtDescription" runat="server" MaxLength="5000" Height="120" TextMode="MultiLine"
                                    Required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Save" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Row End -->
</asp:Content>