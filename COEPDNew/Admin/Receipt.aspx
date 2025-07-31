<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="Receipt.aspx.cs" Inherits="Receipt" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script language="javascript" type="text/javascript">
        function checkpay() {

            var ddlPaymenttype = document.getElementById('<%=ddlPaymenttype.ClientID%>');
            var typeid = ddlPaymenttype.options[ddlPaymenttype.selectedIndex].value;

            if (typeid == 2) {
                document.getElementById('divCheque').style.display = "";
            }
            else {
                document.getElementById('divCheque').style.display = "none";
            }
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
                            </label>
                            <div class="col-sm-10">
                                <div class="row">
                                    <div class="col-sm-2">
                                        <asp:TextBox ID="txtDay" runat="server" MaxLength="2" Type="Number" required></asp:TextBox>
                                    </div>
                                    <div class="col-sm-2">
                                        <asp:TextBox ID="txtMonth" runat="server" MaxLength="2" Type="Number" required></asp:TextBox>
                                    </div>
                                    <div class="col-sm-2">
                                        <asp:TextBox ID="txtYear" runat="server" MaxLength="4" Type="Number" required></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Receipt Type
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlReceiptType" runat="server"  required>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Location
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlLocation" runat="server" OnSelectedIndexChanged="ddlLocation_SelectedIndexChanged"
                                    AutoPostBack="true" required>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Batch
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlBatch" runat="server" OnSelectedIndexChanged="ddlBatch_SelectedIndexChanged"
                                    AutoPostBack="true" required>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Participant
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlParticipant" runat="server" required>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Company
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlCompany" runat="server" required>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Payment Type
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlPaymenttype" runat="server" required>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div id="divCheque" style="display: none">
                            <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    Cheque Date
                                </label>
                                <div class="col-sm-10">
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
                                </label>
                                <div class="col-sm-10">
                                    <asp:TextBox ID="txtChequeNo"  MaxLength="50" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    Name On Account
                                </label>
                                <div class="col-sm-10">
                                    <asp:TextBox ID="txtNameOnAccount" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    Account Number
                                </label>
                                <div class="col-sm-10">
                                    <asp:TextBox ID="txtAccountNo"  MaxLength="50"   runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    Bank Name
                                </label>
                                <div class="col-sm-10">
                                    <asp:TextBox ID="txtBankName"  MaxLength="500" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    Bank Branch
                                </label>
                                <div class="col-sm-10">
                                    <asp:TextBox ID="txtBranch"  MaxLength="500" runat="server"></asp:TextBox></div>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Amount
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtAmount" runat="server" MaxLength="10" Required="" type="number"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Tax
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtTax" runat="server" MaxLength="10" Required=""  type="number" step="any" ></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Notes
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtNotes" runat="server"  MaxLength="3000" TextMode="MultiLine"></asp:TextBox>
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
