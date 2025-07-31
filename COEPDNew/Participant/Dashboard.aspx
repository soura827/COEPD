<%@ Page Title="" Language="C#" MasterPageFile="Participant.master" AutoEventWireup="true"
    CodeFile="Dashboard.aspx.cs" Inherits="Dashboard" EnableViewState="false" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="canonical" href="https://www.coepd.com/" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Dashboard Wrapper End -->
    <!-- Row Start -->
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <%--<marquee behavior="scroll" direction="left" onmouseover="this.stop();" onmouseout="this.start();"><asp:Literal ID="ltlNews" runat="server"></asp:Literal></marquee>--%>
            <marquee behavior="scroll" direction="left" onmouseover="this.stop();" onmouseout="this.start();"><asp:Label ID="lblNews" Font-Bold="true" ForeColor="Red" Font-Size="Large" runat="server"></asp:Label></marquee>
        </div>
    </div>
    <!-- Row End -->
    <!-- Row Start -->
    <%--<div class="row">
        <div class="col-lg-3 col-md-3 col-sm-6">
            <div class="mini-widget ">
                <div class="mini-widget-heading clearfix">
                    <div class="text-center">
                        Total Exams
                    </div>
                </div>
                <div class="mini-widget-body clearfix">
                    <div class="pull-left">
                        <i class="fa fa-check"></i>
                    </div>
                    <div class="pull-right number">
                        <asp:Literal ID="lblTotal" runat="server"></asp:Literal>
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
                        Completed Exams
                    </div>
                </div>
                <div class="mini-widget-body clearfix">
                    <div class="pull-left">
                        <i class="fa fa-check"></i>
                    </div>
                    <div class="pull-right number">
                        <asp:Literal ID="lblComplete" runat="server" />
                    </div>
                </div>
                <!--                 <div class="mini-widget-footer center-align-text">
                  <span>Better than last week</span>
                </div> -->
            </div>
        </div>
        <div class="col-lg-3 col-md-3 col-sm-6">
            <div class="mini-widget">
                <div class="mini-widget-heading clearfix">
                    <div class="text-center">
                        Activities
                    </div>
                </div>
                <div class="mini-widget-body clearfix">
                    <div class="pull-left">
                        <i class="fa fa-upload"></i>
                    </div>
                    <div class="pull-right number">
                        <asp:Literal ID="lblActivities" runat="server" />
                    </div>
                </div>
                <!--                 <div class="mini-widget-footer center-align-text">
                  <span>Better than last week</span>
                </div> -->
            </div>
        </div>
        <div class="col-lg-3 col-md-3 col-sm-6">
            <div class="mini-widget mini-widget">
                <div class="mini-widget-heading clearfix">
                    <div class="text-center">
                        Documents
                    </div>
                </div>
                <div class="mini-widget-body clearfix">
                    <div class="pull-left">
                        <i class="fa fa-download"></i>
                    </div>
                    <div class="pull-right number">
                        <asp:Literal ID="lblDocuments" runat="server" />
                    </div>
                </div>
                <!--                 <div class="mini-widget-footer center-align-text">
                  <span>Better than last week</span>
                </div> -->
            </div>
        </div>
    </div>--%>
    <%--<div class="row">
        <div class="col-lg-3 col-md-3 col-sm-6">
            <div class="mini-widget">
                <div class="mini-widget-heading clearfix">
                    <div class="text-center">
                        Sample Resumes
                    </div>
                </div>
                <div class="mini-widget-body clearfix">
                    <div class="pull-left">
                        <i class=" fa fa-file-text "></i>
                    </div>
                    <div class="pull-right number">
                        <asp:Literal ID="ltlResumeCount" runat="server" />
                    </div>
                </div>
                <!--                 <div class="mini-widget-footer center-align-text">
                  <span>Better than last week</span>
                </div> -->
            </div>
        </div>
        <div class="col-lg-3 col-md-3 col-sm-6">
            <div class="mini-widget">
                <div class="mini-widget-heading clearfix">
                    <div class="text-center">
                        Sample Questions
                    </div>
                </div>
                <div class="mini-widget-body clearfix">
                    <div class="pull-left">
                        <i class=" fa fa-file-text "></i>
                    </div>
                    <div class="pull-right number">
                        <asp:Literal ID="ltlQuestionsCount" runat="server" />
                    </div>
                </div>
                <!--                 <div class="mini-widget-footer center-align-text">
                  <span>Better than last week</span>
                </div> -->
            </div>
        </div>
    </div>--%>
    <!-- Nurturing Dashboard Start -->
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Nurture Dashboard
                    </div>
                </div>
                <div class="row">&nbsp;</div>

                <!--Nurture Details Start -->

                <div class="widget" id="divNurture" runat="server">

                    <div class="widget-body">

                        <div class="row">
                             <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            Preparation
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-book"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlPreparation" runat="server" />
                                        </div>
                                    </div>
                                    <div class="mini-widget-footer center-align-text" style="background-color:lavender;">
                                        <asp:Button runat="server" ID="btnPreparation" Text="View Details" OnClick="btnPreparation_Click" CausesValidation="false" UseSubmitBehavior="false" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            Revision
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <%--<i class="fa fa-television"></i>--%>
                                            <i class="fa fa-desktop"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlRevision" runat="server" />
                                            <%-- <asp:Chart ID="Chart1" runat="server" BackColor="0, 0, 64" BackGradientStyle="LeftRight"  
        BorderlineWidth="0" Height="360px" Palette="None" PaletteCustomColors="Maroon"  
        Width="380px" BorderlineColor="64, 0, 64">  
        <Titles>  
            <asp:Title ShadowOffset="10" Name="Items" />  
        </Titles>  
        <Legends>  
            <asp:Legend Alignment="Center" Docking="Bottom" IsTextAutoFit="False" Name="Default"  
                LegendStyle="Row" />  
        </Legends>  
        <Series>  
            <asp:Series Name="Default" />  
        </Series>  
        <ChartAreas>  
            <asp:ChartArea Name="ChartArea1" BorderWidth="0" />  
        </ChartAreas>  
    </asp:Chart>  --%>
                                        </div>
                                    </div>
                                    <div class="mini-widget-footer center-align-text" style="background-color: lavender;">
                                        <asp:Button runat="server" ID="btnRevision" Text="View Details" OnClick="btnRevision_Click" CausesValidation="false" UseSubmitBehavior="false" />
                                        <%-- <a href='NurturingRevisionSearch.aspx?<%#Eval("ParticipantId")%>' <span>View Details</span></a>--%>
                                        <%--<a href="NurturingRevisionSearch.aspx"><span>View Details</span></a>--%>
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            Capstone Projects
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-book"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlCapstoneProjects" runat="server" />
                                        </div>
                                    </div>
                                    <div class="mini-widget-footer center-align-text" style="background-color: lavender;">
                                        <asp:Button runat="server" ID="btnProjectIntro" Text="View Details" OnClick="btnProjectIntro_Click" CausesValidation="false" UseSubmitBehavior="false" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            Live Projects Identify
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-cogs"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlProfileBuilding" runat="server" />
                                        </div>
                                    </div>
                                    <div class="mini-widget-footer center-align-text" style="background-color: lavender;">
                                        <asp:Button runat="server" ID="btnProfileBuilding" Text="View Details" OnClick="btnProfileBuilding_Click" CausesValidation="false" UseSubmitBehavior="false" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            Waterfall Model
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-cogs"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlWaterfallModel" runat="server" />
                                        </div>
                                    </div>
                                    <div class="mini-widget-footer center-align-text" style="background-color: lavender;">
                                        <asp:Button runat="server" ID="btnWaterfallModel" Text="View Details" OnClick="btnWaterfallModel_Click" CausesValidation="false" UseSubmitBehavior="false" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            Agile Scrum Model
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-cogs"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlAgileScrumModel" runat="server" />
                                        </div>
                                    </div>
                                    <div class="mini-widget-footer center-align-text" style="background-color: lavender;">
                                        <asp:Button runat="server" ID="btnAgileScrumModel" Text="View Details" OnClick="btnAgileScrumModel_Click" CausesValidation="false" UseSubmitBehavior="false" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            BA Exposure
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-unlock"></i>

                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlBAExposure" runat="server" />
                                        </div>
                                    </div>
                                    <div class="mini-widget-footer center-align-text" style="background-color: lavender;">
                                        <asp:Button runat="server" ID="btnBAExposure" Text="View Details" OnClick="btnBAExposure_Click" CausesValidation="false" UseSubmitBehavior="false" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            Mocks
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-user-circle"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlMocks" runat="server" />
                                        </div>
                                    </div>
                                    <div class="mini-widget-footer center-align-text" style="background-color: lavender;">
                                        <asp:Button runat="server" ID="btnMocks" Text="View Details" OnClick="btnMocks_Click" CausesValidation="false" UseSubmitBehavior="false" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            Resume
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-print"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlResume" runat="server" />
                                        </div>
                                    </div>
                                    <div class="mini-widget-footer center-align-text" style="background-color: lavender;">
                                        <asp:Button runat="server" ID="btnResume" Text="View Details" OnClick="btnResume_Click" CausesValidation="false" UseSubmitBehavior="false" />
                                    </div>
                                </div>
                            </div>


                            <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            IIBA Certificate
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-certificate"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlInterviewReady" runat="server" />
                                        </div>
                                    </div>
                                    <div class="mini-widget-footer center-align-text " style="background-color: lavender;">
                                        <asp:Button runat="server" ID="btnInterviewReady" Text="View Details" OnClick="btnInterviewReady_Click" CausesValidation="false" UseSubmitBehavior="false" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!--Nurture details End -->
                <%-- <div class="row">
                        &nbsp;
                    </div>--%>
            </div>
        </div>
    </div>

    <!-- Nurturing Dashboard End -->



    <!-- Row End -->
</asp:Content>
