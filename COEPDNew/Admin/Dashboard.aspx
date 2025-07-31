<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="Dashboard.aspx.cs" Inherits="Dashboard" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .ui-widget-content .ui-icon {
            /*background-image: url("../App_Themes/admin//images/ui-icons_222222_256x240.png")*/
            /*background-image:url("../App_Themes/admin/img/ui-icons_444444_256x240.png")*/
            background-image: url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png") !important;
        }

        .ui-widget-header .ui-icon {
            /*background-image: url("../App_Themes/admin/img/ui-icons_444444_256x240.png")*/
            background-image: url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png") !important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Row Start -->
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <marquee behavior="scroll" direction="left" onmouseover="this.stop();" onmouseout="this.start();">
                <asp:Literal ID="ltlNews" runat="server"></asp:Literal></marquee>
        </div>
    </div>
    <!-- Row End -->
    <div class="row">

        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Dashboard
                    </div>
                </div>



                <div class="widget-header">
                    <div class="title">
                        Employee Details
                    </div>

                </div>
                <div class="widget-body">
                    <div>

                        <asp:Button ID="BtnProcessTeam" runat="server" Text="Process Team" UseSubmitBehavior="false" Visible="false"
                            OnClick="Button1_Click" />

                        <asp:Button ID="BtnHRTeam" runat="server" Text="HR Team" UseSubmitBehavior="false" Visible="false"
                            OnClick="Button2_Click" />

                        <asp:Button ID="BtnNurturingTeam" runat="server" Text="Nurturing  Team" UseSubmitBehavior="false" Visible="false"
                            OnClick="Button3_Click" />

                        <asp:Button ID="BtnAdministratio" runat="server" Text="Administration" UseSubmitBehavior="false" Visible="false"
                            OnClick="Button4_Click" />

                        <asp:Button ID="BtnMarketingTeam" runat="server" Text="Marketing Team" UseSubmitBehavior="false" Visible="false"
                            OnClick="Button5_Click1" />

                        <asp:Button ID="BtnDevelopmentTeam" runat="server" Text="Development Team" UseSubmitBehavior="false" Visible="false"
                            OnClick="Button6_Click" />

                        <asp:Button ID="BtnMentoringTeam" runat="server" Text="Mentoring Team" UseSubmitBehavior="false" Visible="false"
                            OnClick="Button7_Click" />
                    </div>
                </div>
            </div>






            <div class="col-lg-14 col-md-14">
                <div class="widget">
                    <div class="widget-header">
                        <div class="title">
                            Employee Login Date and Login Time
                        </div>
                    </div>

                    <div class="widget-body">



                        <div class="row">
                            <asp:GridView ID="Griddata" runat="server" AutoGenerateColumns="false" HeaderStyle-HorizontalAlign="Center" Width="100%" AllowSorting="true" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" Caption="">
                                <Columns>

                                    <%--<asp:BoundField HeaderText="S.No" DataField="SNo" />--%>
                                    <asp:BoundField HeaderText="Login Date" DataField="Date" DataFormatString="{0:dd MMM yyyy}" ItemStyle-Width="10px" />



                                    <%--<asp:BoundField HeaderText="Employee ID" DataField="Code" />--%>
                                    <%--<asp:BoundField HeaderText="Name" DataField="Employee" ItemStyle-Width="105px"/>--%>
                                    <%--<asp:BoundField HeaderText="Designation" DataField="Designation" />
                                <asp:BoundField HeaderText="Branch" DataField="Branch" />
                                <asp:BoundField HeaderText="Login IP" DataField="LoginIPAddress" />
                                <asp:BoundField HeaderText="Logout IP" DataField="LogoutIPAddress" />--%>






                                    <asp:TemplateField HeaderText="Login Time" ItemStyle-Width="10px">
                                        <ItemTemplate>
                                            <%# Eval("StartTime", "{0:hh:mm tt}") %>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <%--<asp:TemplateField HeaderText="End Time" ItemStyle-Width="100px">
                                    <ItemTemplate>
                                        <%# Eval("EndTime", "{0:hh:mm tt}") %>
                                    </ItemTemplate>
                                </asp:TemplateField>--%>
                                    <%--<asp:BoundField HeaderText="Duration (HH:MM:SS)" DataField="Duration" />--%>
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                </div>



                 <div class="widget">
                    <div class="widget-header">
                        <div class="title">
                            Employee Award and Rewards
                        </div>
                    </div>
                    <div class="widget-body">
                        <div class="row">
                            <asp:GridView ID="GridViewAward" runat="server" AutoGenerateColumns="false" HeaderStyle-HorizontalAlign="Center" Width="100%" AllowSorting="true" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" Caption="">
                                <Columns>
                                    <asp:BoundField HeaderText="Award Name" DataField="AwardName" />
                                    <asp:BoundField HeaderText=" CertificateId" DataField="CertificateId" />
                                     <asp:BoundField HeaderText="Date Of issued" DataField="DateOfIssued" DataFormatString="{0: dd MMM yyyy}" />                                
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                </div>



            </div>









            <div class="row">&nbsp;</div>

            <!--Nurture Details Start -->

            <%--<div class="widget" id="divNurture" runat="server" >
                    <div class="widget-header">
                        <div class="title">
                            Nurture Pendings
                        </div>
                    </div>
                    <div class="widget-body">
                        <div class="row">
                            <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            Nurture Blog
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-rss"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlBlog" runat="server" />
                                        </div>
                                    </div>
                                    <div class="mini-widget-footer center-align-text" style="background-color:lavender;">
                                        <a href="NurtureBlogSearch.aspx"><span>View Details</span></a>
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            Nurture Documents
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-book"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlDocument" runat="server" />
                                        </div>
                                    </div>
                                    <div class="mini-widget-footer center-align-text" style="background-color:lavender;">
                                        <a href="NurtureDocumentationSearch.aspx"><span>View Details</span></a>
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            Nurture Exams
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-television"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlExam" runat="server" />
                                        </div>
                                    </div>
                                    <div class="mini-widget-footer center-align-text" style="background-color:lavender;">
                                        <a href="NurtureExamSearch.aspx"><span>View Details</span></a>
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            Nurture Tools
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-wrench"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlTools" runat="server" />
                                        </div>
                                    </div>
                                    <div class="mini-widget-footer center-align-text" style="background-color:lavender;">
                                        <a href="NurtureToolSearch.aspx"><span>View Details</span></a>
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            Nurture Projects
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-print"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlProjects" runat="server" />
                                        </div>
                                    </div>
                                    <div class="mini-widget-footer center-align-text" style="background-color:lavender;">
                                        <a href="NurtureProjectSearch.aspx"><span>View Details</span></a>
                                    </div>
                                </div>
                            </div>


                            <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            Nurture UML
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-file-code-o"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlUml" runat="server" />
                                        </div>
                                    </div>
                                    <div class="mini-widget-footer center-align-text" style="background-color:lavender;">
                                        <a href="NurtureUMLSearch.aspx"><span>View Details</span></a>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            Mock Interviews
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-quote-right"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlInterviews" runat="server" />
                                        </div>
                                    </div>
                                    <div class="mini-widget-footer center-align-text " style="background-color:lavender;">
                                        <a href="NurtureMockInterviewSearch.aspx" ><span >View Details</span></a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>--%>
            <!--Nurture details End -->







            <div class="widget" id="divPlacement" visible="false"  runat="server">
                <div class="widget-header">
                    <div class="title">
                        Placement Requests
                    </div>
                </div>
                <div class="widget-body" visible="false" >
                    <div class="row">
                        <div class="col-lg-3 col-md-3 col-sm-6">
                            <div class="mini-widget  mini-widget">
                                <div class="mini-widget-heading clearfix">
                                    <div class="text-center">
                                        Resumes To be processed
                                    </div>
                                </div>
                                <div class="mini-widget-body clearfix">
                                    <div class="pull-left">
                                        <i class="fa fa-spinner"></i>
                                    </div>
                                    <div class="pull-right number">
                                        <asp:Literal ID="lblProcess" runat="server" />
                                    </div>
                                </div>
                                <!--                 <div class="mini-widget-footer center-align-text">
                  <span>Better than last week</span>
                </div> -->
                            </div>
                        </div>
                        <div class="col-lg-3 col-md-3 col-sm-6">
                            <div class="mini-widget  mini-widget">
                                <div class="mini-widget-heading clearfix">
                                    <div class="text-center">
                                        Approved Resumes
                                    </div>
                                </div>
                                <div class="mini-widget-body clearfix">
                                    <div class="pull-left">
                                        <i class="fa fa-check-square"></i>
                                    </div>
                                    <div class="pull-right number">
                                        <asp:Literal ID="lblApprove" runat="server" />
                                    </div>
                                </div>
                                <!--                 <div class="mini-widget-footer center-align-text">
                  <span>Better than last week</span>
                </div> -->
                            </div>
                        </div>
                        <div class="col-lg-3 col-md-3 col-sm-6">
                            <div class="mini-widget  mini-widget">
                                <div class="mini-widget-heading clearfix">
                                    <div class="text-center">
                                        Sample Resume Request
                                    </div>
                                </div>
                                <div class="mini-widget-body clearfix">
                                    <div class="pull-left">
                                        <i class="fa fa-file-text"></i>
                                    </div>
                                    <div class="pull-right number">
                                        <asp:Literal ID="lblResumeReq" runat="server" />
                                    </div>
                                </div>
                                <!--                 <div class="mini-widget-footer center-align-text">
                  <span>Better than last week</span>
                </div> -->
                            </div>
                        </div>
                        <div class="col-lg-3 col-md-3 col-sm-6">
                            <div class="mini-widget  mini-widget">
                                <div class="mini-widget-heading clearfix">
                                    <div class="text-center">
                                        Sample Question Requests
                                    </div>
                                </div>
                                <div class="mini-widget-body clearfix">
                                    <div class="pull-left">
                                        <i class="fa fa-question"></i>
                                    </div>
                                    <div class="pull-right number">
                                        <asp:Literal ID="lblQustnReq" runat="server" />
                                    </div>
                                </div>
                                <!--                 <div class="mini-widget-footer center-align-text">
                  <span>Better than last week</span>
                </div> -->
                            </div>
                        </div>
                    </div>

                    <div class="row" id="divHr" runat="server">
                        <div class="widget-body">
                            <div class="row" id="div2" runat="server">
                                <div class="col-lg-3 col-md-3 col-sm-6">
                                    <div class="mini-widget  mini-widget">
                                        <div class="mini-widget-heading clearfix">
                                            <div class="text-center">
                                                Resumes To be processed
                                            </div>
                                        </div>
                                        <div class="mini-widget-body clearfix">
                                            <div class="pull-left">
                                                <i class="fa fa-spinner"></i>
                                            </div>
                                            <div class="pull-right number">
                                                <asp:Literal ID="litApproved" runat="server" />
                                            </div>
                                        </div>
                                        <!--                 <div class="mini-widget-footer center-align-text">
                  <span>Better than last week</span>
                </div> -->
                                    </div>
                                </div>
                                <div class="col-lg-3 col-md-3 col-sm-6">
                                    <div class="mini-widget  mini-widget">
                                        <div class="mini-widget-heading clearfix">
                                            <div class="text-center">
                                                Sample Interview Questions
                                            </div>
                                        </div>
                                        <div class="mini-widget-body clearfix">
                                            <div class="pull-left">
                                                <i class="fa fa-check-square"></i>
                                            </div>
                                            <div class="pull-right number">
                                                <asp:Literal ID="litSampleQustns" runat="server" />
                                            </div>
                                        </div>
                                        <!--                 <div class="mini-widget-footer center-align-text">
                  <span>Better than last week</span>
                </div> -->
                                    </div>
                                </div>
                                <div class="col-lg-3 col-md-3 col-sm-6">
                                    <div class="mini-widget  mini-widget">
                                        <div class="mini-widget-heading clearfix">
                                            <div class="text-center">
                                                Shortlisted Resumes
                                            </div>
                                        </div>
                                        <div class="mini-widget-body clearfix">
                                            <div class="pull-left">
                                                <i class="fa fa-file-text"></i>
                                            </div>
                                            <div class="pull-right number">
                                                <asp:Literal ID="litShortlisted" runat="server" />
                                            </div>
                                        </div>
                                        <!--                 <div class="mini-widget-footer center-align-text">
                  <span>Better than last week</span>
                </div> -->
                                    </div>
                                </div>

                            </div>

                        </div>
                    </div>
                </div>
            </div>















            <div class="row">
                &nbsp;
            </div>
            <div class="widget" id="followup" runat="server" visible ="false">
                <div class="widget-header">
                    <div class="title">
                        FollowUp Reminders
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="col-lg-2 col-md-2">
                            <asp:DropDownList ID="ddlLocation" runat="server">
                            </asp:DropDownList>
                        </div>








                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox ID="txtSearchByEmployee" runat="server"></asp:TextBox>
                        </div>


                        <div class="col-lg-1 col-md-1">
                            <asp:Button ID="btnSearch" runat="server" Text="Find" OnClick="btnSearch_Click" />
                        </div>
                        <div class="col-lg-9 col-md-9">
                            &nbsp;
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="table-responsive">
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" OnRowCommand="gv_RowCommand"
                                Width="100%" OnRowDataBound="gv_RowDataBound">
                                <Columns>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Location" DataField="Location" />
                                    <asp:BoundField HeaderText="Aspirant Name" DataField="Lead" />
                                    <asp:BoundField HeaderText="Mobile" DataField="PrimaryMobile" />
                                    <asp:BoundField HeaderText="Email" DataField="PrimaryEmail" />
                                    <asp:BoundField HeaderText="FollowUp Date" DataField="FollowUpDate" DataFormatString="{0:dd MMM yyyy}" />
                                    <asp:BoundField HeaderText="From" DataField="FromTime" DataFormatString="{0:HH:MM}" />
                                    <asp:BoundField HeaderText="To" DataField="ToTime" DataFormatString="{0:HH:MM}" />
                                    <asp:TemplateField HeaderText="Review" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center"
                                        ItemStyle-Width="50px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkEdit" runat="server" Text="Review" CommandName="cmdEdit" CommandArgument='<%#Eval("LeadId")%>'></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                </Columns>
                                <EmptyDataTemplate>
                                    <center>
                                        No Records Found
                                    </center>
                                </EmptyDataTemplate>
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
            <div class="widget" runat="server" visible="false"  id="divRetakeExams">
                <div class="widget-header">
                    <div class="title">
                        Retake Exam Requests
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="table-responsive">
                            <asp:GridView ID="gvRetakeExam" runat="server" AutoGenerateColumns="False" OnRowCommand="gvRetakeExam_RowCommand"
                                Width="100%" DataKeyNames="ReTakeExamId">
                                <Columns>
                                    <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkEdit" runat="server" Text="Accept" CommandName="cmdAccept"
                                                CommandArgument='<%#Eval("ExamId")%>'></asp:LinkButton>
                                            <asp:LinkButton ID="lnkDelete" runat="server" Text="Reject" CommandName="cmdReject"
                                                CommandArgument='<%#Eval("RetakeExamId")%>'></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Participant" DataField="Participant" />
                                    <asp:BoundField HeaderText="Batch Date" DataField="BatchDate" DataFormatString="{0: dd MMM yyyy}" />
                                    <asp:BoundField HeaderText="Participant Comments" DataField="Description" />
                                    <asp:BoundField HeaderText="Topic" DataField="Topic" />
                                    <asp:BoundField HeaderText="Marks %" DataField="MarksPercentage" />
                                    <asp:BoundField HeaderText="Trainer" DataField="Employee" />
                                    <asp:BoundField HeaderText="Location" DataField="Location" />
                                    <asp:BoundField HeaderText="Requested On" DataField="CreatedOn" DataFormatString="{0:dd MMM yyyy hh:mm tt}" />
                                </Columns>
                                <EmptyDataTemplate>
                                    <center>
                                        No Records Found
                                    </center>
                                </EmptyDataTemplate>
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
            <div class="widget" id="Div1" visible="false" runat="server">
                <div class="widget-header">
                    <div class="title">
                        Roles & Responsibilities
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row container">
                        <asp:Literal ID="lilcontent" runat="server"></asp:Literal>
                    </div>
                </div>
            </div>
        </div>
    </div>


    <div class="row">
        <div class="form-group">
            <div class="col-lg-3 col-md-3">
                <asp:TextBox runat="server" ID="txtEmployeeDetails" MaxLength="100" placeholder="By Employee ID/Name/Designation" OnTextChanged="txtEmployeeDetails_TextChanged" Visible="false" AutoPostBack="true"></asp:TextBox>
            </div>
            <div class="col-lg-3 col-md-3">
                <asp:TextBox runat="server" ID="txtBranch" MaxLength="100" placeholder="Search By Branch" OnTextChanged="txtBranch_TextChanged" Visible="false" AutoPostBack="true"></asp:TextBox>
            </div>
            <div class="col-lg-2 col-md-2">
                <asp:TextBox ID="txtFromDate" runat="server" CssClass="form-control" Placeholder="From Date" OnTextChanged="txtFromDate_TextChanged" Visible="false" AutoPostBack="true"></asp:TextBox>
            </div>
            <div class="col-lg-2 col-md-2">
                <asp:TextBox ID="txtToDate" runat="server" CssClass="form-control" Placeholder="To Date" OnTextChanged="txtToDate_TextChanged" Visible="false" AutoPostBack="true"></asp:TextBox>
            </div>
            <div class="col-lg-2 col-md-2">
                <asp:Button ID="btnDownload" runat="server" Text="Download" OnClick="btnDownload_Click" Visible="false" UseSubmitBehavior="false" />
            </div>
        </div>
        <br />
        <br />
    </div>




    <!-- Row End -->
    <script type="text/javascript" src="../App_Themes/admin/js/jquery.js"></script>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery-ui-v1.10.3.js"></script>
    <script type="text/javascript">
        $(document).ready(function ($) {
            $("input[id$=txtFromDate]").datepicker({
                value: new Date().toDateString(),
                dateFormat: 'dd/mm/yy',
                changeMonth: true,
                changeYear: true,
                changeprevious: true,
                maxDate: "0",
            });
            $("input[id$=txtToDate]").datepicker({
                dateFormat: 'dd/mm/yy',
                changeMonth: true,
                changeYear: true,
                maxDate: 0
            });
        });
    </script>
    <style type="text/css">
        #mask {
            position: fixed;
            left: 0px;
            top: 0px;
            z-index: 4;
            opacity: 0.4;
            -ms-filter: "progid:DXImageTransform.Microsoft.Alpha(Opacity=40)"; /* first!*/
            filter: alpha(opacity=40); /* second!*/
            background-color: gray;
            display: none;
            width: 100%;
            height: 100%;
        }
    </style>
    <script type="text/javascript" language="javascript">
        function ShowPopup() {
            $('#mask').show();
            $('#<%=pnlpopup.ClientID %>').show();
        }
        function HidePopup() {
            $('#mask').hide();
            $('#<%=pnlpopup.ClientID %>').hide();
        }
    </script>
    <div id="mask">
    </div>
    <asp:Panel ID="pnlpopup" runat="server" BackColor="White" Height="200px"
        Width="300px" Style="z-index: 111; background-color: White; position: absolute; left: 35%; top: 12%; border: outset 2px gray; padding: 5px; display: none">
        <table style="width: 100%; height: 100%;">
            <tr style="background-color: #0924BC">
                <td colspan="2" style="color: White; font-weight: bold; font-size: 1.2em; padding: 3px"
                    align="center">Enter comments
                </td>
                <asp:HiddenField runat="server" ID="hdnRetakeExamId" />
            </tr>
            <tr>
                <td colspan="2">
                    <asp:TextBox ID="txtComments" runat="server" placeholder="Enter comments" TextMode="MultiLine" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnUpdate" runat="server" Text="Reject" OnClick="btnUpdate_Click" />
                </td>
                <td>
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" UseSubmitBehavior="false" />
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
