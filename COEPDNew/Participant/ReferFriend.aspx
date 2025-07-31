<%@ Page Title="" Language="C#" MasterPageFile="~/Participant/Participant.master" AutoEventWireup="true" CodeFile="ReferFriend.aspx.cs" Inherits="Participant_ReferFriend" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        function alertmeSave() {
            Swal.fire(
                'Friend Refered Successfully',
                '',
                'success'
            )
        }
        function alertmeUpdate() {
            Swal.fire(
                ' Updated Friend Refered Successfully',
                '',
                'success'
            )
        }

        function alertmeDuplicate() {
            Swal.fire(
                'Friend Refered already exist',
                '',
                'warning'
            )
        }

        function message() {
            Swal.fire(
                'Referral Bonus will be paid after clearing entire fee by the referral',
                '',
                'warning'
            )
        }




    </script>
    <style type="text/css">
        .newStyle1 {
            font-size: xx-large;
        }

        .newStyle2 {
            font-size: xx-small;
        }

        .newStyle3 {
            font-size: xx-large;
        }
    </style>













</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">







    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        <asp:Label ID="lblTitle" runat="server">Refer Friend</asp:Label>
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">











                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Participant Name
                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtParticipantName" runat="server" Enabled="false"></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Participant Location
                                
                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtParticipantLocation" runat="server" Enabled="false"></asp:TextBox>
                            </div>
                            <asp:TextBox ID="txtLocationId" runat="server" Visible="false"></asp:TextBox>
                        </div>









                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Referral Name
                                <asp:Label runat="server" ID="Label2" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtReferralName" runat="server" required=""></asp:TextBox>
                            </div>
                        </div>












                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Referral Contact
                                <asp:Label runat="server" ID="Label6" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtReferralContact" runat="server" required=""></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Referral Email
                                <asp:Label runat="server" ID="Label7" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtReferralEmail" runat="server" TextMode="Email" required=""></asp:TextBox>
                            </div>
                        </div>








                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Referral location preference
                                <asp:Label runat="server" ID="Label8" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">


                                <asp:DropDownList ID="ddlReferralLocationPreference" runat="server" required=""></asp:DropDownList>


                            </div>
                        </div>











                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Domain
                                <asp:Label runat="server" ID="Label9" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtDomain" runat="server" required=""></asp:TextBox>
                            </div>
                        </div>















                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Planning To Join The Course
                                <asp:Label runat="server" ID="Label10" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                                <asp:DropDownList ID="ddlPlanningToJoinTheCourse" runat="server" required="">
                                    <asp:ListItem Text="Select when Referal will join" Value=""></asp:ListItem>
                                    <asp:ListItem Value="immediately">immediately</asp:ListItem>
                                    <asp:ListItem Value="with in 10 days">with in 10 days</asp:ListItem>
                                    <asp:ListItem Value="with in a month">with in a month</asp:ListItem>
                                    <asp:ListItem Value="Later">Later</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>














                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                referral available time schedule
                                <asp:Label runat="server" ID="Label11" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtReferralAvailableTimeSchedule" runat="server" TextMode="Date" required=""></asp:TextBox>
                            </div>
                        </div>










                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Do You Want Referral Bonus 
                                <asp:Label runat="server" ID="Label13" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                                <asp:DropDownList ID="ddlReferralBonusInterest" runat="server" OnSelectedIndexChanged="ddlReferralBonusInterest_SelectedIndexChanged" AutoPostBack="true">
                                    <asp:ListItem Text="Do You Want Referral Bonus" Value=""></asp:ListItem>
                                    <asp:ListItem Value="true">Yes</asp:ListItem>
                                    <asp:ListItem Value="false">No</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>





















                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                <asp:Label runat="server" ID="lblPaymentType" Text="Payment Type" Visible="false"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                                <asp:DropDownList ID="ddlPaymentType" runat="server" Visible="false" OnSelectedIndexChanged="ddlPaymentType_SelectedIndexChanged" AutoPostBack="true">
                                    <asp:ListItem Text="Select payment Type" Value=""></asp:ListItem>
                                    <asp:ListItem Value="1">Gpay</asp:ListItem>
                                    <asp:ListItem Value="2">Paytm</asp:ListItem>
                                    <asp:ListItem Value="3">PhonePay</asp:ListItem>
                                    <asp:ListItem Value="4">AmazonPay</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>














                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                <asp:Label runat="server" ID="lblGooglepay" Text="Google Pay" Visible="false"></asp:Label>
                                <asp:Label runat="server" ID="lblPhonePay" Text="Phone Pay" Visible="false"></asp:Label>
                                <asp:Label runat="server" ID="lblAmazonpay" Visible="false" Text="Amazon Pay"></asp:Label>
                                <asp:Label runat="server" ID="lblPaytm" Visible="false" Text="Paytm"></asp:Label>

                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtGooglePay" runat="server" required="" placeholder="Example :Gapy@1234567890" Visible="false"></asp:TextBox>
                                <asp:TextBox ID="txtPhonePay" runat="server" required="" Visible="false" placeholder="Example :PhonePay@1234567890"></asp:TextBox>
                                <asp:TextBox ID="txtAmazonPay" runat="server" required="" Visible="false" placeholder="Example :Amazon@1234567890"></asp:TextBox>
                                <asp:TextBox ID="txtPaytm" runat="server" required="" Visible="false" placeholder="Example :Paytm@1234567890"></asp:TextBox>
                            </div>
                        </div>



                        <div class="form-group">
                            <div class="col-sm-offset-3 col-sm-10">
                                <asp:Button ID="btnSubmit" runat="server" Text="Save" OnClick="btnSubmit_Click" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                                <asp:Button ID="btnCancel" runat="server" Text="Back to list" UseSubmitBehavior="false" OnClick="btnCancel_Click" />
                            </div>
                        </div>


                    </div>
                </div>
            </div>
        </div>
    </div>
























</asp:Content>

