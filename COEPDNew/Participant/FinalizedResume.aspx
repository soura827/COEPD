<%@ Page Title="" Language="C#" MasterPageFile="~/Participant/Participant.master" AutoEventWireup="true" CodeFile="FinalizedResume.aspx.cs" Inherits="Participant_FinalizedResume" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
          <!-- Row Start -->
    <div class="row">
        <div class="col-sm-8 col-xs-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Finalized Resume
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Finalized Resume
                            </label>
                            <div class="col-sm-9">
                                <h5>:
                                    <asp:HyperLink ID="hplReplyFile" runat="server" CssClass="btn btn-primary btn-sm" Visible="false" Target="_blank">Download</asp:HyperLink>
                                    <asp:Label runat="server" ID="lblErrorMessage" Text="Your Resume not yet Finalized." Visible="false" Font-Bold="true" ForeColor="Red"></asp:Label>
                                </h5>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-offset-3 col-sm-9">
                                <asp:Button ID="btnCancel" runat="server" Text="Back to Dashboard" UseSubmitBehavior="false" CssClass="btn btn-warning btn-md"
                                    SkinID="delete" OnClick="btnCancel_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

<%--        <div class="col-sm-6 col-xs-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Previous Placements Team Inputs
                    </div>
                </div>
                <div class="widget-body" style="height: 550px; overflow-y: scroll">
                    <div class="viewport">
                        <div class="overview">
                            <ul class="chats">
                                <asp:Repeater ID="rp" runat="server" OnItemDataBound="rp_OnItemDataBound">
                                    <ItemTemplate>
                                        <asp:HiddenField ID="hdnRoleId" runat="server" Value='<%# Eval("RoleId")%>' />
                                        <asp:Panel ID="pnlIn" runat="server" Visible="false">
                                            <li class="in">
                                                <img class="avatar" alt="" src="../img/profile.png" />
                                                <div class="message">
                                                    <span class="arrow"></span><a href="#" class="name">
                                                        <%# Eval("Participant")%>
                                                    </a><span class="date-time">at
                                                        <%# Eval("CreatedOn", "{0:MMM dd, yyyy hh:mm tt}")%>
                                                    </span><span class="body">
                                                        <%# Eval("Chat") %></span>
                                                </div>
                                            </li>
                                        </asp:Panel>
                                        <asp:Panel ID="PnlOut" runat="server" Visible="false">
                                            <li class="out">
                                                <img class="avatar" alt="" src="../img/profile.png">
                                                <div class="message">
                                                    <span class="arrow"></span><a href="#" class="name">
                                                        <%# Eval("Employee")%>
                                                    </a><span class="date-time">at
                                                        <%# Eval("CreatedOn", "{0:MMM dd, yyyy hh:mm tt}")%>
                                                    </span><span class="body">
                                                        <%# Eval("Chat") %>
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
        </div>--%>


    </div>
    <!-- Row End -->
</asp:Content>

