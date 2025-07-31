<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="SendToPlacement.aspx.cs" Inherits="Admin_SendToPlacement" %>

<%@ Register Src="~/Controls/ErrorMessage.ascx" TagPrefix="uc1" TagName="ErrorMessage" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagPrefix="uc2" TagName="FormMessage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        function alertmeUpdate() {
            Swal.fire(
                'Aded To BA Job market  Wing Successfully',
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
                                <h5>:
                                    <asp:Label ID="lblParticipant" runat="server"></asp:Label></h5>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Subscription
                            </label>
                            <div class="col-sm-6">
                                <h5>:
                                    <asp:Label ID="lblSubscriptionExpiry" runat="server" Font-Bold="true" ForeColor="Red"></asp:Label></h5>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">
                                Nurturing Process Duration
                            </label>
                            <div class="col-sm-6">
                                <h5>:
                                    <asp:Label ID="lblNurturingProcessDuration" runat="server" Font-Bold="true"></asp:Label></h5>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-5 control-label">
                                Is BA Job market  Permit?
                            </label>
                            <div class="col-sm-2">
                                <asp:CheckBox ID="chkIsPlacementPermit" runat="server" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-5 control-label">
                                Communication Skills(rate from 1-10)<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:DropDownList ID="ddlCommunicationRating" runat="server" Required="">
                                    <asp:ListItem Text="-- select 1-10 --" Value=""></asp:ListItem>
                                    <asp:ListItem Text="0" Value="0"></asp:ListItem>
                                    <asp:ListItem Text="1" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="2" Value="2"></asp:ListItem>
                                    <asp:ListItem Text="3" Value="3"></asp:ListItem>
                                    <asp:ListItem Text="4" Value="4"></asp:ListItem>
                                    <asp:ListItem Text="5" Value="5"></asp:ListItem>
                                    <asp:ListItem Text="6" Value="6"></asp:ListItem>
                                    <asp:ListItem Text="7" Value="7"></asp:ListItem>
                                    <asp:ListItem Text="8" Value="8"></asp:ListItem>
                                    <asp:ListItem Text="9" Value="9"></asp:ListItem>
                                    <asp:ListItem Text="10" Value="10"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                BA Skills <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-8">
                                <asp:TextBox ID="txtBASkills" runat="server" placeholder="Please name them and rate them" Required=""></asp:TextBox>
                            </div>
                        </div>


                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Total Experience In Years  <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-2">
                                <asp:DropDownList ID="ddlExperienceInYears" runat="server" required="" AutoPostBack="true" OnSelectedIndexChanged="ddlExperienceInYears_SelectedIndexChanged">
                                    <asp:ListItem Text="-- select Total Experience --" Value=""></asp:ListItem>
                                    <asp:ListItem Text="0" Value="0"></asp:ListItem>
                                    <asp:ListItem Text="1" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="2" Value="2"></asp:ListItem>
                                    <asp:ListItem Text="3" Value="3"></asp:ListItem>
                                    <asp:ListItem Text="4" Value="4"></asp:ListItem>
                                    <asp:ListItem Text="5" Value="5"></asp:ListItem>
                                    <asp:ListItem Text="6" Value="6"></asp:ListItem>
                                    <asp:ListItem Text="7" Value="7"></asp:ListItem>
                                    <asp:ListItem Text="8" Value="8"></asp:ListItem>
                                    <asp:ListItem Text="9" Value="9"></asp:ListItem>
                                    <asp:ListItem Text="10" Value="10"></asp:ListItem>
                                    <asp:ListItem Text="11" Value="11"></asp:ListItem>
                                    <asp:ListItem Text="12" Value="12"></asp:ListItem>
                                    <asp:ListItem Text="13" Value="13"></asp:ListItem>
                                    <asp:ListItem Text="14" Value="14"></asp:ListItem>
                                    <asp:ListItem Text="15" Value="15"></asp:ListItem>
                                    <asp:ListItem Text="16" Value="16"></asp:ListItem>
                                    <asp:ListItem Text="17" Value="17"></asp:ListItem>
                                    <asp:ListItem Text="18" Value="18"></asp:ListItem>
                                    <asp:ListItem Text="19" Value="19"></asp:ListItem>
                                    <asp:ListItem Text="20" Value="20"></asp:ListItem>
                                    <asp:ListItem Text="21" Value="21"></asp:ListItem>
                                    <asp:ListItem Text="22" Value="22"></asp:ListItem>
                                    <asp:ListItem Text="23" Value="23"></asp:ListItem>
                                    <asp:ListItem Text="24" Value="24"></asp:ListItem>
                                    <asp:ListItem Text="25" Value="25"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-sm-2">
                                <label class="control-label">
                                    Months
                                </label>
                            </div>
                            <div class="col-sm-2">
                                <asp:DropDownList ID="ddlExperienceInMonths" runat="server" AutoPostBack="true" required="">
                                    <asp:ListItem Text="-- select Total Experience --" Value=""></asp:ListItem>
                                    <asp:ListItem Text="0" Value="0"></asp:ListItem>
                                    <asp:ListItem Text="1" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="2" Value="2"></asp:ListItem>
                                    <asp:ListItem Text="3" Value="3"></asp:ListItem>
                                    <asp:ListItem Text="4" Value="4"></asp:ListItem>
                                    <asp:ListItem Text="5" Value="5"></asp:ListItem>
                                    <asp:ListItem Text="6" Value="6"></asp:ListItem>
                                    <asp:ListItem Text="7" Value="7"></asp:ListItem>
                                    <asp:ListItem Text="8" Value="8"></asp:ListItem>
                                    <asp:ListItem Text="9" Value="9"></asp:ListItem>
                                    <asp:ListItem Text="10" Value="10"></asp:ListItem>
                                    <asp:ListItem Text="11" Value="11"></asp:ListItem>
                                </asp:DropDownList>
                            </div>

                        </div>







                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Relevant Experience In Years  <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-2">
                                <asp:DropDownList ID="ddlRelevantExperience" runat="server" required="" OnSelectedIndexChanged="ddlRelevantExperience_SelectedIndexChanged" AutoPostBack="true">
                                    <asp:ListItem Text="-- select Relevant Experience --" Value=""></asp:ListItem>
                                    <asp:ListItem Text="0" Value="0"></asp:ListItem>
                                    <asp:ListItem Text="1" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="2" Value="2"></asp:ListItem>
                                    <asp:ListItem Text="3" Value="3"></asp:ListItem>
                                    <asp:ListItem Text="4" Value="4"></asp:ListItem>
                                    <asp:ListItem Text="5" Value="5"></asp:ListItem>
                                    <asp:ListItem Text="6" Value="6"></asp:ListItem>
                                    <asp:ListItem Text="7" Value="7"></asp:ListItem>
                                    <asp:ListItem Text="8" Value="8"></asp:ListItem>
                                    <asp:ListItem Text="9" Value="9"></asp:ListItem>
                                    <asp:ListItem Text="10" Value="10"></asp:ListItem>
                                    <asp:ListItem Text="11" Value="11"></asp:ListItem>
                                    <asp:ListItem Text="12" Value="12"></asp:ListItem>
                                    <asp:ListItem Text="13" Value="13"></asp:ListItem>
                                    <asp:ListItem Text="14" Value="14"></asp:ListItem>
                                    <asp:ListItem Text="15" Value="15"></asp:ListItem>
                                    <asp:ListItem Text="16" Value="16"></asp:ListItem>
                                    <asp:ListItem Text="17" Value="17"></asp:ListItem>
                                    <asp:ListItem Text="18" Value="18"></asp:ListItem>
                                    <asp:ListItem Text="19" Value="19"></asp:ListItem>
                                    <asp:ListItem Text="20" Value="20"></asp:ListItem>
                                    <asp:ListItem Text="21" Value="21"></asp:ListItem>
                                    <asp:ListItem Text="22" Value="22"></asp:ListItem>
                                    <asp:ListItem Text="23" Value="23"></asp:ListItem>
                                    <asp:ListItem Text="24" Value="24"></asp:ListItem>
                                    <asp:ListItem Text="25" Value="25"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-sm-2">
                                <label class="control-label">
                                    Months
                                </label>
                            </div>
                            <div class="col-sm-2">
                                <asp:DropDownList ID="ddlRelevantExperienceMonths" runat="server" AutoPostBack="true" required="" >
                                    <asp:ListItem Text="-- select Total Experience --" Value=""></asp:ListItem>
                                    <asp:ListItem Text="0" Value="0"></asp:ListItem>
                                    <asp:ListItem Text="1" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="2" Value="2"></asp:ListItem>
                                    <asp:ListItem Text="3" Value="3"></asp:ListItem>
                                    <asp:ListItem Text="4" Value="4"></asp:ListItem>
                                    <asp:ListItem Text="5" Value="5"></asp:ListItem>
                                    <asp:ListItem Text="6" Value="6"></asp:ListItem>
                                    <asp:ListItem Text="7" Value="7"></asp:ListItem>
                                    <asp:ListItem Text="8" Value="8"></asp:ListItem>
                                    <asp:ListItem Text="9" Value="9"></asp:ListItem>
                                    <asp:ListItem Text="10" Value="10"></asp:ListItem>
                                    <asp:ListItem Text="11" Value="11"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>





                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Current CTC<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-8">
                                <asp:TextBox ID="txtCurrentCTC" runat="server" min="0" TextMode="Number" placeholder="Enter Current Salary" required="" OnTextChanged="txtCurrentCTC_TextChanged" AutoPostBack="true"> </asp:TextBox>

                            </div>
                        </div>



                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Expected CTC<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-8">
                                <asp:TextBox ID="txtExpectedCTC" runat="server" min="0" placeholder="Enter Expected Salary" Text="" required=""
                                    Enabled="false"></asp:TextBox>

                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Special Notes<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-8">
                                <asp:TextBox ID="txtSpecialNotes" runat="server" MaxLength="5000" Height="100" TextMode="MultiLine" Required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:Button ID="btnPlacementPermit" runat="server" Text="Send to Placement Wing & Assign Default Features" OnClick="btnPlacementPermit_Click" />
                                <asp:Button ID="btnCancel" runat="server" Text="Back To List" SkinID="btnBack" UseSubmitBehavior="false" CausesValidation="false" OnClick="btnCancel_Click" />
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

