<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="CandidateTranscript.aspx.cs" Inherits="Admin_CandidateTranscript" %>

<%@ Register Src="~/Controls/ErrorMessage.ascx" TagPrefix="uc1" TagName="ErrorMessage" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagPrefix="uc2" TagName="FormMessage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        function alertmeUpdate() {
            Swal.fire(
                'Aded To Placement Wing Successfully',
                '',
                'success'
            )
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
    <uc1:ErrorMessage runat="server" ID="ErrorMessage" Visible="false" />
    <uc2:FormMessage runat="server" ID="FormMessage" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <!-- Row Start -->
    <div class="Row">
        <div class="col-lg-6 col-md-6">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        <asp:Label runat="server" ID="lblTitle"></asp:Label>
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Participant Name
                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtSearch" runat="server" required="required" AutoPostBack="true" OnTextChanged="txtSearch_TextChanged"></asp:TextBox>

                            </div>
                        </div>


                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Participant Name
                            </label>
                            <div class="col-sm-5">


                                <asp:DropDownList ID="ddlParticipant" runat="server" OnSelectedIndexChanged="ddlParticipant_SelectedIndexChanged"  AutoPostBack="true"></asp:DropDownList>

                            </div>
                        </div>














                    </div>
                </div>
            </div>
        </div>

        <div class="col-lg-6 col-md-6">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Previous Service Requests & Resolutions
                    </div>
                </div>
                <div class="widget-body" style="height: 300px; overflow-y: scroll">
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
        </div>

        <div class="col-lg-6 col-md-6">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Previous Escalations & Resolutions
                    </div>
                </div>
                <div class="widget-body" style="height: 300px; overflow-y: scroll">
                    <div class="viewport">
                        <div class="overview">
                            <ul class="chats">
                                <asp:Repeater ID="rpEscalations" runat="server" OnItemDataBound="rpEscalations_ItemDataBound">
                                    <ItemTemplate>
                                        <asp:HiddenField ID="hdnRoleIdEscalation" runat="server" Value='<%# Eval("RoleId")%>' />
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
        </div>

        <div class="col-lg-6 col-md-6">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Previous Nurturing Team Inputs
                    </div>
                </div>
                <div class="widget-body" style="height: 300px; overflow-y: scroll">
                    <div class="viewport">
                        <div class="overview">
                            <ul class="chats">
                                <asp:Repeater ID="rpNurturingTeamInputs" runat="server" OnItemDataBound="rpNurturingTeamInputs_ItemDataBound">
                                    <ItemTemplate>
                                        <asp:HiddenField ID="hdnNurturingTeamInputsRoleId" runat="server" Value='<%# Eval("RoleId")%>' />
                                        <asp:Panel ID="pnlIn" runat="server" Visible="false">
                                            <li class="in">
                                                <img class="avatar" alt="" src="../img/profile.png" />
                                                <span class="name">Task Name:
                                                        <%# Eval("NurturingProcessStageTaskName") %>
                                                </span>
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
                                                <span class="name">Task Name:
                                                        <%# Eval("NurturingProcessStageTaskName") %>
                                                </span>
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
        </div>

    </div>
    <!-- Row End -->






</asp:Content>

