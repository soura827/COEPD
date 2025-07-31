<%@ Page Title="" Language="C#" MasterPageFile="Participant.master" AutoEventWireup="true"
    CodeFile="MyProfile.aspx.cs" Inherits="MyProfile" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Row Start -->
    <div class="box-theme">
        <div class="box-title">
            <div class="box-head">
                My Profile
            </div>
            <div class="box-button">
                <asp:Button ID="btnAdd" runat="server" Text="Change Password" Width="150px" CssClass="btn btn-primary"
                    CausesValidation="false" OnClick="btnChangePwd_Click" />
            </div>
        </div>
        <div>
            <div class="panel-body">
                <div>
                    <label for="Username" class="col-md-2">
                        Name
                    </label>
                    <div class="col-md-9">
                        <asp:Label ID="lblParticipant" runat="server"></asp:Label>
                    </div>
                </div>
                <div>
                    <label for="Password" class="col-md-2">
                        Mobile
                    </label>
                    <div class="col-md-9">
                        <asp:Label ID="lblMobile" runat="server"></asp:Label>
                    </div>
                </div>
                <div>
                    <label for="Password" class="col-md-2">
                        E-mail
                    </label>
                    <div class="col-md-9">
                        <asp:Label ID="lblEmail" runat="server"></asp:Label>
                    </div>
                </div>
                <div>
                    <label for="Password" class="col-md-2">
                        Location
                    </label>
                    <div class="col-md-9">
                        <asp:Label ID="lblLocation" runat="server"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Row End -->
</asp:Content>
