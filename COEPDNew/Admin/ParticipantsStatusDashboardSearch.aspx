<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ParticipantsStatusDashboardSearch.aspx.cs" Inherits="Admin_ParticipantsStatusDashboardSearch" %>

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
                        Participant Status Dashboard - Total : <asp:Label runat="server" ID="lblParticipantStatusDashboard" ForeColor="OrangeRed" Font-Bold="true"></asp:Label>
                    </div>
                </div>
                <div class="row">&nbsp;</div>

                <!--Nurture Details Start -->

                <div class="widget" id="divNurture" runat="server" >
                    
                    <div class="widget-body">
                        <div class="row">
                            <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            Not Yet Started Participants
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-book"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlNotYetStartedParticipants" runat="server" />
                                        </div>
                                    </div>
                                    <div class="mini-widget-footer center-align-text" style="background-color:lavender;">
                                        <asp:Button runat="server" ID="btnNotYetStartedParticipants" Text="View Details" OnClick="btnNotYetStartedParticipants_Click" />
                                    </div>
                                </div>
                            </div>

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
                                        <asp:Button runat="server" ID="btnPreparation" Text="View Details" OnClick="btnPreparation_Click" />
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
                                    <div class="mini-widget-footer center-align-text" style="background-color:lavender;">
                                        <asp:Button runat="server" ID="btnRevision" Text="View Details" OnClick="btnRevision_Click" />
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
                                    <div class="mini-widget-footer center-align-text" style="background-color:lavender;">
                                        <asp:Button runat="server" ID="btnCapstoneProjects" Text="View Details" OnClick="btnCapstoneProjects_Click" />
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
                                            <asp:Literal ID="ltlLiveProjectsIdentify" runat="server" />
                                        </div>
                                    </div>
                                    <div class="mini-widget-footer center-align-text" style="background-color:lavender;">
                                        <asp:Button runat="server" ID="btnLiveProjectsIdentify" Text="View Details" OnClick="btnLiveProjectsIdentify_Click" />
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
                                    <div class="mini-widget-footer center-align-text" style="background-color:lavender;">
                                        <asp:Button runat="server" ID="btnWaterfallModel" Text="View Details" OnClick="btnWaterfallModel_Click" />
                                    </div>
                                </div>
                            </div>
                            <div class="row">

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
                                    <div class="mini-widget-footer center-align-text" style="background-color:lavender;">
                                        <asp:Button runat="server" ID="btnAgileScrumModel" Text="View Details" OnClick="btnAgileScrumModel_Click" />
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
                                    <div class="mini-widget-footer center-align-text" style="background-color:lavender;">
                                        <asp:Button runat="server" ID="btnBAExposure" Text="View Details" OnClick="btnBAExposure_Click" />
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
                                    <div class="mini-widget-footer center-align-text" style="background-color:lavender;">
                                        <asp:Button runat="server" ID="btnMocks" Text="View Details" OnClick="btnMocks_Click" />
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
                                    <div class="mini-widget-footer center-align-text" style="background-color:lavender;">
                                        <asp:Button runat="server" ID="btnResume" Text="View Details" OnClick="btnResume_Click" />
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
                                            <asp:Literal ID="ltlIIBACertificate" runat="server" />
                                        </div>
                                    </div>
                                    <div class="mini-widget-footer center-align-text " style="background-color:lavender;">
                                        <asp:Button runat="server" ID="btnIIBACertificate" Text="View Details" OnClick="btnIIBACertificate_Click" />
                                    </div>
                                </div>
                            </div>

                                 


                             <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                           participants-Placements
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-file-text"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlParticipantPlacements" runat="server" />
                                        </div>
                                    </div>
                                    <div class="mini-widget-footer center-align-text" style="background-color:lavender;">
                                        <asp:Button runat="server" ID="btnParticipantPlacements" Text="View Details"  OnClick="btnParticipantPlacements_Click"/>
                                    </div>
                                </div>
                            </div>
                             <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                           participants-OfferRelesed
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-file-text"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlOfferRelesed" runat="server" />
                                        </div>
                                    </div>
                                    <div class="mini-widget-footer center-align-text" style="background-color:lavender;">
                                        <asp:Button runat="server" ID="btnOfferRelesed" Text="View Details"  OnClick="btnOfferRelesed_Click"/>
                                    </div>
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
    <!-- Row End -->


      

    

   



    

    

    

    

   

    



</asp:Content>


