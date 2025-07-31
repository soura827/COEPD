<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="InstallmentEdits.aspx.cs" Inherits="Admin_InstallmentEdits" %>


<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        function alertmeSave() {
            Swal.fire(
                'Participant Installment Successfully Added',
                '',
                'success'
            )
        }
        function alertmeUpdate() {
            Swal.fire(
                ' Updated Participant Installment Successfully',
                '',
                'success'
            )
        }

        function alertmeDuplicate() {
            Swal.fire(
                'Participant Installment already exist',
                '',
                'warning'
            )
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <!-- Row Start -->
    <div class="row">
        <div class="col-sm-12 col-xs-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">

                        <asp:Label ID="lblTitle" runat="server" />
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">

                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                select Lead <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:DropDownList ID="ddlParticipant" runat="server" required="">
                                </asp:DropDownList>
                            </div>
                        </div>





                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Service Owner:
                            </label>
                            <div class="col-sm-6">


                                <asp:TextBox ID="txtServiceOwner" Required="" runat="server" />






                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Select Installments<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:DropDownList ID="ddlInstallments" runat="server" required="" OnSelectedIndexChanged="ddlInstallments_SelectedIndexChanged" AutoPostBack="true">
                                    <asp:ListItem Value="0">SELECT</asp:ListItem>
                                    <asp:ListItem Value="InstallMent-1">InstallMent-1</asp:ListItem>
                                    <asp:ListItem Value="InstallMent-2">InstallMent-2</asp:ListItem>
                                    <asp:ListItem Value="InstallMent-3">InstallMent-3</asp:ListItem>
                                    <asp:ListItem Value="InstallMent-4">InstallMent-4</asp:ListItem>
                                    <asp:ListItem Value="InstallMent">InstallMent</asp:ListItem>

                                </asp:DropDownList>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Installment Date <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:TextBox ID="txtInstallDate" Required="" TextMode="Date" runat="server" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Agreed Amount <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:TextBox ID="txtAgree" Required="" runat="server" />
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Paying Amount <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:TextBox ID="txtPayAmt" Required="" runat="server" />
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Due Amount <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:TextBox ID="txtDueAmt" Required="" runat="server" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Select Status<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:DropDownList ID="ddlStatus" runat="server" required="">
                                     <asp:ListItem Value="">SELECT</asp:ListItem>
                                    <asp:ListItem Value="true">Paid</asp:ListItem>
                                    <asp:ListItem Value="false">Not Paid</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-offset-3 col-sm-10">
                                <asp:Button ID="btnSubmit" runat="server" SkinID="btnGreen" Text="Submit" OnClick="btnSubmit_Click" UseSubmitBehavior="false" OnClientClick="this.disable='true'; this.value='Please wait...';" />
                                <asp:Button ID="btnCancel" runat="server" Text="Back To List" UseSubmitBehavior="false" OnClick="btnCancel_Click" />
                                
                            </div>
                        </div>


                    </div>


                </div>
            </div>
        </div>
    </div>
</asp:Content>

