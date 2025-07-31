<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="ParticipantNurture.aspx.cs" Inherits="ParticipantNurture" %>

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
                    <div class="row">
                        <div class="col-lg-8 col-md-8">
                            <div class="form-horizontal no-margin">
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Participant :
                                    </label>
                                    <div class="col-sm-10">
                                        <h5>
                                            <asp:Label ID="lblParticipant" runat="server"></asp:Label></h5>
                                        <asp:HiddenField ID="hdnPartcipantId" runat="server" />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Location :
                                    </label>
                                    <div class="col-sm-10">
                                        <h5>
                                            <asp:Label ID="lblLocation" runat="server"></asp:Label></h5>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Batch Type :
                                    </label>
                                    <div class="col-sm-10">
                                        <h5>
                                            <asp:Label ID="lblBatchType" runat="server"></asp:Label></h5>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Trainer :
                                    </label>
                                    <div class="col-sm-10">
                                        <h5>
                                            <asp:Label ID="lblTrainer" runat="server"></asp:Label></h5>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Batch Date :
                                    </label>
                                    <div class="col-sm-10">
                                        <h5>
                                            <asp:Label ID="lblDate" runat="server" Text='<%# Eval("StartDate", "{d MMM yyyy }") %>'></asp:Label>
                                        </h5>
                                    </div>
                                </div>

                                <div class="widget">
                                    <div class="widget-header">
                                        <div class="title">
                                            Nurturing Details
                                        </div>
                                    </div>
                                    <div class="widget-body" style="height: 500px; overflow-y: scroll">
                                        <div class="viewport">
                                            <div class="overview">
                                                <ul class="chats">
                                                    <asp:Repeater ID="rp" runat="server" OnItemDataBound="rp_OnItemDataBound">
                                                        <ItemTemplate>
                                                            <asp:HiddenField ID="hdnUserId" runat="server" Value='<%# Eval("CreatedBy")%>' />
                                                            <asp:Panel ID="pnlIn" runat="server" Visible="false">
                                                                <li class="in">
                                                                    <img class="avatar" alt="" src="../img/profile.png" />
                                                                    <div class="message">
                                                                        <span class="arrow"></span><a href="#" class="name">
                                                                            <%# Eval("Username")%>
                                                                        </a><span class="date-time">at
                                                        <%# Eval("CreatedOn", "{0:MMM dd, yyyy HH:mm}")%>
                                                                        </span><span class="body">
                                                                            <%# Eval("ParticipantNurture") %></span>
                                                                    </div>
                                                                </li>
                                                            </asp:Panel>
                                                            <asp:Panel ID="PnlOut" runat="server" Visible="false">
                                                                <li class="out">
                                                                    <img class="avatar" alt="" src="../img/profile.png">
                                                                    <div class="message">
                                                                        <span class="arrow"></span><a href="#" class="name">
                                                                            <%# Eval("Username")%>
                                                                        </a><span class="date-time">at
                                                        <%# Eval("CreatedOn", "{0:MMM dd, yyyy HH:mm}")%>
                                                                        </span><span class="body">
                                                                            <%# Eval("ParticipantNurture") %>
                                                                        </span>
                                                                    </div>
                                                                </li>
                                                            </asp:Panel>
                                                        </ItemTemplate>
                                                    </asp:Repeater>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-4 col-md-4">
                            <div class="form-group">
                                <label class="control-label">
                                    Nurturing Details
                                </label>
                                <asp:TextBox ID="txtNotes" runat="server" required TextMode="MultiLine" Height="300px">
                                </asp:TextBox>
                            </div>
                            <div class="form-group">
                                <div class="col-sm-offset-3 col-sm-9">
                                    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Save" />
                                    <asp:Button ID="btnCancel" runat="server" Text="Back to list" UseSubmitBehavior="false"
                                        OnClick="btnCancel_Click" CausesValidation="false" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Row End -->
</asp:Content>
