<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true"
    CodeFile="Register.aspx.cs" Inherits="Register" %>

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
                                Participant Search
                            </label>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtsearch"   MaxLength="500" placeholder="Search" runat="server" ></asp:TextBox>
                            </div>
                            <div>
                                <asp:Button ID="btnsearch" runat="server" Text="Find" OnClick="btnsearch_Click" UseSubmitBehavior="false" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Participant
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlParticipant" runat="server" Required>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Employee
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlEmployee" runat="server" Required>
                                </asp:DropDownList>
                            </div>
                        </div>
                        
                        <div class="form-group">
                            <label class="col-sm-2 control-label ">
                                Start Time
                            </label>
                            <div class="col-sm-10">
                                <div class="row">
                                    <div class="col-lg-1 col-md-1">
                                        <asp:TextBox ID="txtsHours" runat="server" type="number" MaxLength="2" min="00" max="12" Required Placeholder="HH"
                                            Width="70px"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-1 col-md-1">
                                        <asp:TextBox ID="txtsmints" runat="server" type="number" MaxLength="2" min="00" max="59" Required Placeholder="MM"
                                            Width="70px"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-2 col-md-2">
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2  control-label">
                                End Time
                            </label>
                            <div class="col-sm-10">
                                <div class="row">
                                    <div class="col-lg-1 col-md-1">
                                        <asp:TextBox ID="txtEHours" runat="server" type="number" min="00" max="12" MaxLength="2"  Placeholder="HH" Width="70px"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-1 col-md-1">
                                        <asp:TextBox ID="txtEmints" runat="server" type="number" min="00" max="60"  MaxLength="2"  Placeholder="MM" Width="70px"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-2 col-md-2">
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Purpose of Visit
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtComments" MaxLength="3000" runat="server" TextMode="MultiLine"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Notes
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtRemarks" MaxLength="5000" runat="server" TextMode="MultiLine"></asp:TextBox>
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
