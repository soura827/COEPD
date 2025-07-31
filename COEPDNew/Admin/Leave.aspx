<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="Leave.aspx.cs" Inherits="Leave" %>

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
                                Leave Type
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlLeavetype" runat="server" Required=""></asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                From Date
                            </label>
                            <div class="col-sm-1">
                                <asp:DropDownList ID="ddlFromDay" runat="server" required="">
                                </asp:DropDownList>
                            </div>
                            <div class="col-sm-1">
                                <asp:DropDownList ID="ddlFromMonth" runat="server" required="">
                                </asp:DropDownList>
                            </div>
                            <div class="col-sm-2">
                                <asp:DropDownList ID="ddlFromYear" runat="server" required="">
                                </asp:DropDownList>
                            </div>

                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                To Date
                            </label>
                            <div class="col-sm-1">
                                <asp:DropDownList ID="ddlToday" runat="server" required="">
                                </asp:DropDownList>
                            </div>
                            <div class="col-sm-1">
                                <asp:DropDownList ID="ddlToMonth" runat="server" required="">
                                </asp:DropDownList>
                            </div>
                            <div class="col-sm-2">
                                <asp:DropDownList ID="ddlToYear" runat="server" required="">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Repoted To
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlRepotedEmployee" runat="server" Required=""></asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Reason For Leave
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtDescription" runat="server" MaxLength="5000" Height="120" TextMode="MultiLine"
                                    Required=""></asp:TextBox>
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
