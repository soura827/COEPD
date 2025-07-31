<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ParticipantFeePayReceipt.aspx.cs" Inherits="Admin_ParticipantFeePayReceipt" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
     <style type="text/css">
        .ui-widget-content .ui-icon {
            /*background-image: url("../App_Themes/admin//images/ui-icons_222222_256x240.png")*/
            /*background-image:url("../App_Themes/admin/img/ui-icons_444444_256x240.png")*/
            background-image: url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png") !important;
        }

        .ui-widget-header .ui-icon {
            /*background-image: url("../App_Themes/admin/img/ui-icons_444444_256x240.png")*/
            background-image: url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png") !important;
        }
    </style>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery.js"></script>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery-ui-v1.10.3.js"></script>
    <script type="text/javascript">

        function alertmeSave() {
            Swal.fire(
                'Participant Fee Paying Receipt Successfully Added',
                '',
                'success'
            )
        }
        function alertmeUpdate() {
            Swal.fire(
                'Participant Fee Paying Successfully Updated',
                '',
                'success'
            )
        }

        function alertmeDuplicate() {
            Swal.fire(
                'Participant Fee Paying Already Exist',
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
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        <asp:Literal ID="lblTitle" runat="server" />
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">

                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Receipt Date
                                 <asp:Label runat="server" ID="Label8" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-10">
                                <div class="row">
                                    <div class="col-sm-2">
                                        <asp:TextBox ID="txtDay" runat="server" MaxLength="2" Type="Number" required=""></asp:TextBox>
                                    </div>
                                    <div class="col-sm-2">
                                        <asp:TextBox ID="txtMonth" runat="server" MaxLength="2" Type="Number" required=""></asp:TextBox>
                                    </div>
                                    <div class="col-sm-2">
                                        <asp:TextBox ID="txtYear" runat="server" MaxLength="4" Type="Number" required=""></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Receipt Type
                                 <asp:Label runat="server" ID="Label1" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                                <asp:DropDownList ID="ddlReceiptType" runat="server" required="">
                                </asp:DropDownList>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Location
                                 <asp:Label runat="server" ID="Label2" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                                <asp:DropDownList ID="ddlLocation" runat="server" OnSelectedIndexChanged="ddlLocation_SelectedIndexChanged"
                                    AutoPostBack="true" required="">
                                </asp:DropDownList>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Batch
                                 <asp:Label runat="server" ID="Label3" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                                <asp:DropDownList ID="ddlBatch" runat="server" OnSelectedIndexChanged="ddlBatch_SelectedIndexChanged"
                                    AutoPostBack="true" required="">
                                </asp:DropDownList>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Participant
                                 <asp:Label runat="server" ID="Label4" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                                <asp:DropDownList ID="ddlParticipant" AutoPostBack="true" runat="server" required="" OnSelectedIndexChanged="ddlParticipant_SelectedIndexChanged">
                                </asp:DropDownList>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Services
                                 <asp:Label runat="server" ID="Label12" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                                <asp:DropDownList ID="ddlServices" runat="server"
                                    required="">
                                </asp:DropDownList>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Company
                                 <asp:Label runat="server" ID="Label5" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                                <asp:DropDownList ID="ddlCompany" runat="server" required="">
                                </asp:DropDownList>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Payment Type
                             <asp:Label runat="server" ID="Label14" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                                <asp:DropDownList ID="ddlPaymenttype" runat="server" required="" OnSelectedIndexChanged="ddlPaymenttype_SelectedIndexChanged" AutoPostBack="true">
                                </asp:DropDownList>
                            </div>
                        </div>


                        <div id="divCheque" runat="server" visible="false">
                            <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    Cheque Date
                                </label>
                                <div class="col-sm-6">
                                    <div class="row">
                                        <div class="col-sm-2">
                                            <asp:TextBox ID="txtCDay" runat="server" MaxLength="2" Type="Number"></asp:TextBox>
                                        </div>
                                        <div class="col-sm-2">
                                            <asp:TextBox ID="txtCMonth" runat="server" MaxLength="2" Type="Number"></asp:TextBox>
                                        </div>
                                        <div class="col-sm-2">
                                            <asp:TextBox ID="txtCYear" runat="server" MaxLength="4" Type="Number"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    Cheque No
                                    <asp:Label runat="server" ID="Label15" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                                </label>
                                <div class="col-sm-5">
                                    <asp:TextBox ID="txtChequeNo" MaxLength="50" runat="server" required=""></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    Name On Account
                                    <asp:Label runat="server" ID="Label16" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                                </label>
                                <div class="col-sm-5">
                                    <asp:TextBox ID="txtNameOnAccount" runat="server" required=""></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    Account Number
                                    <asp:Label runat="server" ID="Label17" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                                </label>
                                <div class="col-sm-5">
                                    <asp:TextBox ID="txtAccountNo" MaxLength="50" runat="server" required=""></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    Bank Name
                                    <asp:Label runat="server" ID="Label18" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                                </label>
                                <div class="col-sm-5">
                                    <asp:TextBox ID="txtBankName" MaxLength="500" runat="server" required=""></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    Bank Branch
                                    <asp:Label runat="server" ID="Label19" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                                </label>
                                <div class="col-sm-5">
                                    <asp:TextBox ID="txtBranch" MaxLength="500" runat="server" reqiired=""></asp:TextBox>
                                </div>
                            </div>
                        </div>










                        <div id="divReferenceNumber" runat="server" visible="false">
                            <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    ReferenceNumber
                                 <asp:Label runat="server" ID="Label20" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                                </label>
                                <div class="col-sm-5">
                                    <asp:TextBox ID="txtReferenceNumber" runat="server" MaxLength="10" required=""></asp:TextBox>
                                </div>
                            </div>
                        </div>


                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Agreed Fee
                                 <asp:Label runat="server" ID="Label13" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtAgreedFee" runat="server" MaxLength="10" type="number" required=""></asp:TextBox>
                            </div>
                        </div>











                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Paying Amount
                                 <asp:Label runat="server" ID="Label7" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtPayingAmount" runat="server" MaxLength="10" Required="" type="number"></asp:TextBox>
                            </div>
                        </div>








                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Previous Fee
                                 <asp:Label runat="server" ID="Label6" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtPreviousFee" runat="server" MaxLength="10" Enabled="false" type="number" required=""></asp:TextBox>
                            </div>
                        </div>


                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                With GST or WithOut GST
                                 <asp:Label runat="server" ID="Label9" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                                <asp:DropDownList ID="ddlGSTtype" runat="server" AutoPostBack="true" required="" OnSelectedIndexChanged="ddlGSTtype_SelectedIndexChanged">
                                    <asp:ListItem Value="Select GST or Non GST">Select GST or Non GST</asp:ListItem>
                                    <asp:ListItem Value="GST">GST</asp:ListItem>
                                    <asp:ListItem Value="Non GST">Non GST</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>

                        <div id="divFees" runat="server" visible="false">
                            <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    Fees (with out GST)
                                    <asp:Label runat="server" ID="Label10" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                                </label>
                                <div class="col-sm-5">
                                    <asp:TextBox ID="txtWithOutGSTfees" runat="server" MaxLength="10" Required="" Enabled="false"></asp:TextBox>
                                </div>
                            </div>
                        </div>


                        <div id="divTax" runat="server" visible="false">
                            <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    GST Tax
                                     <asp:Label runat="server" ID="Label11" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                                </label>
                                <div class="col-sm-5">
                                    <asp:TextBox ID="txtGSTtax" runat="server" MaxLength="10" Required="" Enabled="false"></asp:TextBox>
                                </div>
                            </div>
                        </div>






                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                PreviousAmount + PayingAmount
                                 <asp:Label runat="server" ID="Label22" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtPreviousAmountPayingAmount" runat="server" MaxLength="10" type="number" required="" Enabled="false"></asp:TextBox>
                            </div>
                        </div>









                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Pending Fee
                                 <asp:Label runat="server" ID="Label21" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtPendingFee" runat="server" MaxLength="10" type="number" required="" Enabled="false"></asp:TextBox>
                            </div>
                        </div>















                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Notes
                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtNotes" runat="server" MaxLength="3000" TextMode="MultiLine"></asp:TextBox>
                            </div>
                        </div>





                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Save" />
                                <asp:Button ID="btnCancel" runat="server" Text="Back to list" UseSubmitBehavior="false"
                                    OnClick="btnCancel_Click" CausesValidation="false" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Row End -->











</asp:Content>

