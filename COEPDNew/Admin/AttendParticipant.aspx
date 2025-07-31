<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="AttendParticipant.aspx.cs" Inherits="Admin_AttendParticipant" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-lg-12 col-xs-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        <asp:Label ID="lblTitle" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">
                        <div class="form-group" id="ParticipantSerch" runat="server">
                            <label class="col-sm-2 control-label">
                                Reference No (or) Name 
                            </label>
                            <div class="col-sm-4">
                                <asp:TextBox ID="txtSearch" runat="server" required=""></asp:TextBox>
                            </div>
                            <div class="col-sm-2">
                                <asp:Button ID="btnSearch" runat="server" Text="Find" OnClick="btnSearch_Click" UseSubmitBehavior="false" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Participant
                            </label>
                            <div class="col-sm-8">
                                <asp:DropDownList ID="ddlParticipant" runat="server" required="">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Enter Time
                            </label>
                            <div class="col-sm-10">
                                <div class="row">
                                    <div class="col-lg-1 col-md-1">
                                        <asp:TextBox ID="txtsHours" runat="server" type="number" Required="" Placeholder="HH"
                                            Width="70px" min="1" max="12"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-1 col-md-1">
                                        <asp:TextBox ID="txtsmints" runat="server" type="number" Required="" Placeholder="MM"
                                            Width="70px" min="0" max="59" MaxLength="2"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-2 col-md-2">
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Save" />
                                <asp:Button ID="btnCancel" runat="server" Text="Back to list" SkinID="delete" CssClass="btn btn-warning btn-md" UseSubmitBehavior="false"
                                    OnClick="btnCancel_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>