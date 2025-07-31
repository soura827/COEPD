<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Employee.ascx.cs" Inherits="Controls_Employee" %>
<div id='cssmenu'>
    <ul>
        <li class=''><a href='#'><i class="fa fa-clipboard"></i>Dashboard</a> </li>
        <li class=''><a href="#"><i class="fa fa-tachometer"></i>Lead </a>
            <ul>
                <li><a href="LeadSearch.aspx">New Leads</a> </li>
                <li><a href="FollowUpSearch.aspx">Follow Ups</a> </li>
                <li><a href="GuestRegisterSearch.aspx">Visitor Track</a> </li>
                <li><a href="RegisterSearch.aspx">Participant Visits</a> </li>
                <%--       <asp:Label ID="ltmenu" runat="server"></asp:Label>--%>
            </ul>
        </li>
        <li class=''><a href='#'><i class="fa fa-tasks"></i>Task</a>
            <ul>
                <li><a href="MyTaskSearch.aspx">My Tasks</a> </li>
                <li><a href="TaskSearch.aspx">Assigned Tasks</a> </li>
                <li><a href="TimeSheetSearch.aspx">TimeSheet</a> </li>
            </ul>
        </li>
        <li class=''><a href='#'><i class="fa fa-file-text"></i>My Docs</a>
            <ul>
                <li><a href="EmployeeDocumentSearch.aspx">Documents</a> </li>
                <li><a href="EmployeeSharedDocument.aspx">Shared Documents</a> </li>
                <li><a href="ParticipantDocumentSearch.aspx">Participant Documents</a></li>
            </ul>
        </li>
        <li class='' id="mnuTraning" runat="server"><a href="#"><i class="fa fa-users"></i>Training</a>
            <ul>
                <li><a href="ParticipantNurtureSearch.aspx">Nurturing Requests</a></li>
                <li><a href="ParticipantResumeSearch.aspx">Review Resumes</a> </li>
            </ul>
        </li>
        <li class=''><a href='#'><i class="fa fa-building"></i>Office</a>
            <ul>
                <li><a href="CompanyPolicies.aspx">Policies</a> </li>
                <li><a href="HolidayList.aspx">Holiday List</a> </li>
                <li><a href="ContactsList.aspx">Contacts List</a> </li>
            </ul>
        </li>
    </ul>
</div>
