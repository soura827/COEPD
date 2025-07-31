<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="PlacementDashboard.aspx.cs" Inherits="Admin_PlacementDashboard" %>

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
                        Today Status
                    </div>
                </div>
                <div class="row">&nbsp;</div>
                <!--Placement Details Start -->
                <div class="widget" id="divTodayStatus" runat="server" >
                    <div class="widget-body">
                        <div class="row">


                             <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            Resumes Finalized
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-file-text"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlResumesFinalized" runat="server" />
                                        </div>
                                    </div>
                                    <div class="mini-widget-footer center-align-text" style="background-color:lavender;">
                                        <asp:Button runat="server" ID="btnResumesFinalized" Text="View Details" OnClick="btnResumesFinalized_Click" />
                                    </div>
                                </div>
                            </div>


                            <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            Move to BA Job market 
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-desktop"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlMovetoPlacementWing" runat="server" />
                                        </div>
                                    </div>
                                    <div class="mini-widget-footer center-align-text" style="background-color:lavender;">
                                        <asp:Button runat="server" ID="btnMovetoPlacementWing" Text="View Details" OnClick="btnMovetoPlacementWing_Click" />
                                    </div>
                                </div>
                             </div>


                            <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            Jobs Posted
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
                                    <div class="mini-widget-footer center-align-text" style="background-color:lavender;">
                                        <asp:Button runat="server" ID="btnJobsPosted" Text="View Details" OnClick="btnJobsPosted_Click" />
                                    </div>
                                </div>
                            </div>


                            <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            New FAQ's Added
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-cogs"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlNewFAQsAdded" runat="server" />
                                        </div>
                                    </div>
                                    <div class="mini-widget-footer center-align-text" style="background-color:lavender;">
                                        <asp:Button runat="server" ID="btnNewFAQsAdded" Text="View Details" OnClick="btnNewFAQsAdded_Click" />
                                    </div>
                                </div>
                            </div>


                            <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            Jobs Applied
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-desktop"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlJobsApplied" runat="server" />
                                        </div>
                                    </div>
                                    <div class="mini-widget-footer center-align-text" style="background-color:lavender;">
                                        <asp:Button runat="server" ID="btnJobsApplied" Text="View Details" OnClick="btnJobsApplied_Click" />
                                    </div>
                                </div>
                             </div>

                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>                    
    <!-- Row End -->

    <!-- Row Start -->
        <div class="row">
            <div class="col-lg-12 col-md-12">
                <div class="widget">
                    <div class="widget-header">
                       <div class="title">
                           Pending Actions from BA Job market  Teams
                       </div>
                    </div>
                    <div class="row">&nbsp;</div>
                    <div class="widget" id="divPendingActions" runat="server" > 
                       <div class="widget-body">
                           <div class="row">

                               <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            Service Requests
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-cogs"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlServiceRequests" runat="server" />
                                        </div>
                                    </div>
                                    <div class="mini-widget-footer center-align-text" style="background-color:lavender;">
                                        <asp:Button runat="server" ID="btnServiceRequests" Text="View Details" OnClick="btnServiceRequests_Click" />
                                    </div>
                                </div>
                              </div>

                                 <div class="col-lg-2 col-md-3 col-sm-6">
                                     <div class="mini-widget  mini-widget">
                                        <div class="mini-widget-heading clearfix">
                                            <div class="text-center">
                                                 Escalations
                                            </div>
                                        </div>
                                     <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-cogs"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlEscalations" runat="server" />
                                        </div>
                                     </div>
                                    <div class="mini-widget-footer center-align-text " style="background-color:lavender;">
                                        <asp:Button runat="server" ID="btnEscalations" Text="View Details" OnClick="btnEscalations_Click" />
                                    </div>
                                  </div>
                              </div>

                               <div class="col-lg-2 col-md-3 col-sm-6">
                                     <div class="mini-widget  mini-widget">
                                        <div class="mini-widget-heading clearfix">
                                            <div class="text-center">
                                                 Data Sheets
                                            </div>
                                        </div>
                                     <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-file-text"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlDataSheets" runat="server" />
                                        </div>
                                     </div>
                                    <div class="mini-widget-footer center-align-text " style="background-color:lavender;">
                                        <asp:Button runat="server" ID="btnDataSheet" Text="View Details" OnClick="btnDataSheet_Click" />
                                    </div>
                                  </div>
                              </div>

                               <div class="col-lg-2 col-md-3 col-sm-6">
                                     <div class="mini-widget  mini-widget">
                                        <div class="mini-widget-heading clearfix">
                                            <div class="text-center">
                                                 Assign Profile Owner
                                            </div>
                                        </div>
                                     <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-user-circle"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlAssignProfileOwner" runat="server" />
                                        </div>
                                     </div>
                                    <div class="mini-widget-footer center-align-text " style="background-color:lavender;">
                                        <asp:Button runat="server" ID="btnAssignProfileOwner" Text="View Details" OnClick="btnAssignProfileOwner_Click" />
                                    </div>
                                  </div>
                              </div>

                               <div class="col-lg-2 col-md-3 col-sm-6">
                                     <div class="mini-widget  mini-widget">
                                        <div class="mini-widget-heading clearfix">
                                            <div class="text-center">
                                                 Conduct HR Mocks
                                            </div>
                                        </div>
                                     <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-desktop"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlConductHRMocks" runat="server" />
                                        </div>
                                     </div>
                                    <div class="mini-widget-footer center-align-text " style="background-color:lavender;">
                                        <asp:Button runat="server" ID="btnConductHRMocks" Text="View Details" OnClick="btnConductHRMocks_Click" />
                                    </div>
                                  </div>
                              </div>

                               <div class="col-lg-2 col-md-3 col-sm-6">
                                     <div class="mini-widget  mini-widget">
                                        <div class="mini-widget-heading clearfix">
                                            <div class="text-center">
                                                 Request FAQs
                                            </div>
                                        </div>
                                     <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-cogs"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlRequestFAQs" runat="server" />
                                        </div>
                                     </div>
                                    <div class="mini-widget-footer center-align-text " style="background-color:lavender;">
                                        <asp:Button runat="server" ID="btnRequestFAQs" Text="View Details" OnClick="btnRequestFAQs_Click" />
                                    </div>
                                  </div>
                              </div>

                               <div class="col-lg-2 col-md-3 col-sm-6">
                                     <div class="mini-widget  mini-widget">
                                        <div class="mini-widget-heading clearfix">
                                            <div class="text-center">
                                                 Revise FAQs
                                            </div>
                                        </div>
                                     <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-cogs"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlReviseFAQs" runat="server" />
                                        </div>
                                     </div>
                                    <div class="mini-widget-footer center-align-text " style="background-color:lavender;">
                                        <asp:Button runat="server" ID="btnReviseFAQs" Text="View Details" OnClick="btnReviseFAQs_Click" />
                                    </div>
                                  </div>
                              </div>

                               <div class="col-lg-2 col-md-3 col-sm-6">
                                     <div class="mini-widget  mini-widget">
                                        <div class="mini-widget-heading clearfix">
                                            <div class="text-center">
                                                 Interview Support
                                            </div>
                                        </div>
                                     <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-user-circle"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlInterviewSupport" runat="server" />
                                        </div>
                                     </div>
                                    <div class="mini-widget-footer center-align-text " style="background-color:lavender;">
                                        <asp:Button runat="server" ID="btnInterviewSupport" Text="View Details" OnClick="btnInterviewSupport_Click" />
                                    </div>
                                  </div>
                              </div>
                           </div>
                        </div>
                    </div>
                </div>
           </div>
      </div>
    <!-- Row Start -->
        <div class="row">
            <div class="col-lg-12 col-md-12">
                <div class="widget">
                    <div class="widget-header">
                       <div class="title">
                           Total BA Job market  Dashboard
                       </div>
                    </div>
                        <div class="row">&nbsp;</div>
                    <div class="widget" id="div1" runat="server" > 
                       <div class="widget-body">
                           <div class="row">

                               <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            Total Placements
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-file-text"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlPlacementCount" runat="server" />
                                        </div>
                                    </div>
                                    <div class="mini-widget-footer center-align-text" style="background-color:lavender;">
                                    </div>
                                </div>
                            </div>

                               <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            Total Profile Owner Resumes
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-file-text"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlProfileOwnerResumes" runat="server" />
                                        </div>
                                    </div>
                                    <div class="mini-widget-footer center-align-text" style="background-color:lavender;">
                                        <asp:Button runat="server" ID="btnProfileOwnerResumes" Text="View Details" OnClick="btnProfileOwnerResumes_Click" />
                                    </div>
                                </div>
                            </div>


                           </div>
                        </div>
                     </div>
                    </div>
                 </div>
             </div>
</asp:Content>

