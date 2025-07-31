<%@ Page Title="" Language="C#" MasterPageFile="~/Participant/Participant.master" AutoEventWireup="true" CodeFile="PlacementDashboard.aspx.cs" Inherits="Participant_PlacementDashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <!-- Row Start -->
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        BA Job market  Dashboard of <asp:Label ID="lblName" runat="server"></asp:Label>
                    </div>
                </div>
                <%--<div class="row">&nbsp;</div>--%>
                <!--Placement Details Start -->
               <%-- <div class="form-group">
                <label class="col-sm-2 control-label">
                    Special Notes:
                </label>
                <asp:Label ID="lblSpecialNote" runat="server" class="col-sm-2 control-label">
                     
                </asp:Label>
                    </div>--%>
                <div class="widget" id="divStudentDashboard" runat="server">
                    <div class="widget-body">
                        <div class="row">


                            <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            Total Jobs Applied
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-file-text"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlTotalJobsApplied" runat="server" />
                                        </div>
                                    </div>
                                   <%-- <div class="mini-widget-footer center-align-text" style="background-color: lavender;">
                                        <asp:Button runat="server" ID="btnTotalJobsApplied" Text="View Details" OnClick="btnTotalJobsApplied_Click" />
                                    </div>--%>
                                </div>
                            </div>

                             <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            Job Applied
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-file-text"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlJobApplied" runat="server" />
                                        </div>
                                    </div>
                                  <%--  <div class="mini-widget-footer center-align-text" style="background-color: lavender;">
                                        <asp:Button runat="server" ID="btnjobApplied" Text="View Details" OnClick="btnjobApplied_Click" />
                                    </div>--%>
                                </div>
                            </div>

                            <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            Interview Round 1
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-desktop"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlInterviewRound1" runat="server" />
                                        </div>
                                    </div>
                                   <%-- <div class="mini-widget-footer center-align-text" style="background-color: lavender;">
                                        <asp:Button runat="server" ID="btnInterviewRound1" Text="View Details" OnClick="btnInterviewRound1_Click" />
                                    </div>--%>
                                </div>
                            </div>


                            <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            Interview Round 2
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-desktop"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlInterviewRound2" runat="server" />
                                        </div>
                                    </div>
                                   <%-- <div class="mini-widget-footer center-align-text" style="background-color: lavender;">
                                        <asp:Button runat="server" ID="btnInterviewRound2" Text="View Details" OnClick="btnInterviewRound2_Click" />
                                    </div>--%>
                                </div>
                            </div>


                            <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            Interview Round 3
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-desktop"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlInterviewRound3" runat="server" />
                                        </div>
                                    </div>
                                   <%-- <div class="mini-widget-footer center-align-text" style="background-color: lavender;">
                                        <asp:Button runat="server" ID="btnInterviewRound3" Text="View Details" OnClick="btnInterviewRound3_Click" />
                                    </div>--%>
                                </div>
                            </div>

                            <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            Offers Released
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-file-text"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlOffersReleased" runat="server" />
                                        </div>
                                    </div>
                                 <%--   <div class="mini-widget-footer center-align-text" style="background-color: lavender;">
                                        <asp:Button runat="server" ID="btnOffersReleased" Text="View Details" OnClick="btnOffersReleased_Click" />
                                    </div>--%>
                                </div>
                            </div>

                            <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            Offer Accepted
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-file-text"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlOffersAccepted" runat="server" />
                                        </div>
                                    </div>
                                  <%--  <div class="mini-widget-footer center-align-text" style="background-color: lavender;">
                                        <asp:Button runat="server" ID="btnOffersAccepted" Text="View Details" OnClick="btnOffersAccepted_Click" />
                                    </div>--%>
                                </div>
                            </div>


                            <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            Jobs Posted From Moved To BA Job market 
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-desktop"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlJobsPosted" runat="server" />
                                        </div>
                                    </div>
                                   <%-- <div class="mini-widget-footer center-align-text" style="background-color: lavender;">
                                        <asp:Button runat="server" ID="btnJobsPosted" Text="View Details" OnClick="btnJobsPosted_Click" />
                                    </div>--%>
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

