<%@ Page Title="" Language="C#" MasterPageFile="~/SubscriptionExpiredParticipant/SubscriptionExpiredParticipant.master" AutoEventWireup="true" CodeFile="Certificate.aspx.cs" Inherits="SubscriptionExpiredParticipant_Certificate" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
      <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <!-- Dashboard Wrapper End -->
    <!-- Row Start -->
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Certificate
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="widget-body">
                            <div class="row">
                                <div class="col-lg-8 col-md-8">
                                    <div class="form-horizontal no-margin">
                                        <div class="form-group">
                                            <div class="col-sm-12" id="divCertify" runat="server">
                                                <img src="../img/certificate.jpg" class="ui-icon-image" height="200px" width="300px" alt="certificate" /><br />
                                                <br />
                                                <div class="col-lg-offset-2">
                                                    <asp:Button ID="btnSubmit" runat="server" Text="DownLoad" OnClick="btnSubmit_Click"
                                                        UseSubmitBehavior="false" />
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-lg-4 col-md-4">
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

