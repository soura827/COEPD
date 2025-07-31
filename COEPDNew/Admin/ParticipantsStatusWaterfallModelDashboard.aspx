<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ParticipantsStatusWaterfallModelDashboard.aspx.cs" Inherits="Admin_ParticipantsStatusWaterfallModelDashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <!-- Row Start -->
        <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Waterfall Model - Total : <asp:Label runat="server" ID="lblWaterfallModel" ForeColor="OrangeRed" Font-Bold="true" ></asp:Label>
                    </div>
                </div>
                <div class="row">&nbsp;</div>
                <!--Placement Details Start -->
                <div class="widget" id="div4" runat="server" >
                    <div class="widget-body">
                        <div class="row">


                             <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            Waterfall Project Scope PPT
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-file-text"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlWaterfallProjectScopePPT" runat="server" />
                                        </div>
                                    </div>
                                    <div class="mini-widget-footer center-align-text" style="background-color:lavender;">
                                        <asp:Button runat="server" ID="btnWaterfallProjectScopePPT" Text="View Details" OnClick="btnWaterfallProjectScopePPT_Click" />
                                    </div>
                                </div>
                            </div>


                            <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            Waterfall Project BA Implementation - Business Case, Diagrams, BRD, FS, Page Designs, RTM, Strategy,
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-desktop"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlWaterfallProjectBAImplementation" runat="server" />
                                        </div>
                                    </div>
                                    <div class="mini-widget-footer center-align-text" style="background-color:lavender;">
                                        <asp:Button runat="server" ID="btnWaterfallProjectBAImplementation" Text="View Details" OnClick="btnWaterfallProjectBAImplementation_Click" />
                                    </div>
                                </div>
                             </div>


                        </div>
                        <div class="row">
                                <div class="col-sm-offset-5 col-sm-10">
                                    <asp:Button runat="server" ID="btnBack" Text="Back To Dashboard" OnClick="btnBack_Click" SkinID="btnGreen" />
                                </div>
                            </div>
                    </div>
                </div>

            </div>
        </div>
    </div>                    
    <!-- Row End -->
</asp:Content>

