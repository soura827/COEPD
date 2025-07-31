<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ParticipantsStatusIIBACertificateDashboard.aspx.cs" Inherits="Admin_ParticipantsStatusIIBACertificateDashboard" %>

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
                        IIBA Certificate - Total :  <asp:Label runat="server" ID="lblIIBACertificate" ForeColor="OrangeRed" Font-Bold="true"></asp:Label>
                    </div>
                </div>
                <div class="row">&nbsp;</div>
                <!--Placement Details Start -->
                <div class="widget" id="div9" runat="server" >
                    <div class="widget-body">
                        <div class="row">


                             <div class="col-lg-2 col-md-3 col-sm-6">
                                <div class="mini-widget  mini-widget">
                                    <div class="mini-widget-heading clearfix">
                                        <div class="text-center">
                                            40 PD Hours Certificate Interview with IIBA Member
                                        </div>
                                    </div>
                                    <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-file-text"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltl40PDHoursCertificate" runat="server" />
                                        </div>
                                    </div>
                                    <div class="mini-widget-footer center-align-text" style="background-color:lavender;">
                                        <asp:Button runat="server" ID="btn40PDHoursCertificate" Text="View Details"  OnClick ="btn40PDHoursCertificate_Click"/>
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

