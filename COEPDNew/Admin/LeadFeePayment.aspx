<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="LeadFeePayment.aspx.cs" Inherits="Admin_LeadFeePayment" %>


<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script language="javascript" type="text/javascript">



        function alertmeSave() {
            Swal.fire(
                'Participant Fee Details Successfully Added',
                '',
                'success'
            )
        }
        function alertmeUpdate() {
            Swal.fire(
                ' Updated Participant Fee Details Successfully',
                '',
                'success'
            )
        }

        function alertmeDuplicate() {
            Swal.fire(
                'Participant Fee Details already exist',
                '',
                'warning'
            )
        }










        function checkpay() {

            var ddlPaymenttype = document.getElementById('<%=ddlPaymentGateway.ClientID%>');
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
        <div class="col-sm-12 col-xs-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        <asp:Label ID="lblTitle" Text="Participant Fee Payment" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">



                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Lead <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-4">
                                <asp:DropDownList ID="ddlParticipant" runat="server" required="">
                                </asp:DropDownList>
                            </div>
                        </div>



                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Location <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-4">
                                <asp:DropDownList ID="ddlLocation" runat="server" required="">
                                </asp:DropDownList>
                            </div>
                        </div>







                      



                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                AgreedAmount
                            </label>
                            <div class="col-sm-4">
                                :
                                <asp:Label runat="server" ID="lblAgreedAmount" Font-Bold="true" Font-Size="Small"></asp:Label>
                            </div>
                        </div>





                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                 Services Taken <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-4">
                                <asp:DropDownList ID="ddlServices" runat="server" required="">
                                </asp:DropDownList>
                            </div>
                        </div>





                      








                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Service Owner
                            </label>
                            <div class="col-sm-4">
                                :
                                <asp:Label runat="server" ID="lblServiceOwner" Font-Bold="true" Font-Size="Small"></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Mobile Number
                            </label>
                            <div class="col-sm-4">
                                :
                                <asp:Label runat="server" ID="lblMobile" Font-Bold="true" Font-Size="Small"></asp:Label>
                            </div>
                        </div>
                       
                              
                        <div class="form-group">
                            <div class="col-lg-2">
                            </div>
                            
                            <div class="col-lg-5 col-sm-5 col-md-5 " style="overflow-y: scroll; max-height: 200px;">
                                <div class="table-responsive">
                                    <div class="col-lg-3 col-md-3">
                                </div>
                                    <asp:GridView ID="gv1" runat="server" AutoGenerateColumns="False" Width="50%" PageSize="10" HeaderStyle-HorizontalAlign="Center" AllowPaging="true" AllowSorting="true" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!">
                                        <Columns>
                                            <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                            <asp:BoundField HeaderText="Lead" DataField="Lead" />
                                            <asp:BoundField HeaderText="Installment Date" DataField="InstallmentDate" />
                                            <asp:BoundField HeaderText="Amount " DataField="Amount" />
                                            <asp:BoundField HeaderText="Due Amount" DataField="Due" />
                                            <asp:BoundField HeaderText="InstallMents" DataField="Installments" />




                                            <asp:TemplateField HeaderText="InstallmentStatus">
                                                <ItemTemplate>
                                                    <%# (Boolean.Parse(Eval("IsInstallmentStatus").ToString()) ? "Paid" : "NotPaid" )%>
                                                </ItemTemplate>
                                            </asp:TemplateField>





                                        </Columns>
                                        <EmptyDataTemplate>
                                            <center>
                                                No Records Found
                                            </center>
                                        </EmptyDataTemplate>
                                    </asp:GridView>
                                   
                                </div>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                GST Type
                                 <asp:Label runat="server" ID="Label1" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-3">
                                <asp:DropDownList ID="ddlGSTTypeCompany" runat="server" required="" OnTextChanged="ddlGSTTypeCompany_TextChanged" AutoPostBack="true">
                                    <asp:ListItem Text="Select GST Type" Value="0"></asp:ListItem>
                                    <asp:ListItem Text="B to B" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="B to C" Value="2"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>


                        <div id="divCompanyGst" runat="server" visible="false">
                            <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    Company Name
                                 <asp:Label runat="server" ID="Label5" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                                </label>
                                <div class="col-sm-3">
                                    <asp:TextBox ID="txtComapanyName" runat="server" MaxLength="3000" placeholder="Company Name"></asp:TextBox>
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    Company GST Number
                                </label>
                                <div class="col-sm-3">
                                    <asp:TextBox ID="txtCompanyGSTnumber" runat="server" MaxLength="3000" placeholder="Company GST Number"></asp:TextBox>
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    Address
                                </label>
                                <div class="col-sm-3">
                                    <asp:TextBox ID="txtAddress" runat="server" MaxLength="3000" TextMode="MultiLine" placeholder="Address"></asp:TextBox>
                                </div>
                            </div>


                        </div>

                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Paying Date
                                 <asp:Label runat="server" ID="Label13" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtPayingDate" runat="server" MaxLength="10" TextMode="Date" required=""></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Amount Paying 
                                 <asp:Label runat="server" ID="Label7" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtPayingAmount" runat="server" MaxLength="10" Required="" type="number" placeholder="Amount Paying" OnTextChanged="txtPayingAmount_TextChanged" AutoPostBack="true"></asp:TextBox>
                            </div>
                        </div>




                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Fee Amount
                                 <asp:Label runat="server" ID="Label2" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtFeeAmount" runat="server" MaxLength="10" Required="" type="number" placeholder="Fee Amount"></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                GST
                                 <asp:Label runat="server" ID="Label3" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtGST" runat="server" MaxLength="10" Required="" type="number" placeholder="GST"></asp:TextBox>
                            </div>
                        </div>


                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Pending Amount
                                 <asp:Label runat="server" ID="Label6" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtPendingAmount" runat="server" MaxLength="10" TextMode="Number" required="" placeholder="Pending Amount"></asp:TextBox>
                            </div>
                        </div>




                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Input Company
                                 <asp:Label runat="server" ID="Label21" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-3">
                                <asp:DropDownList ID="ddlInputCompany" runat="server"></asp:DropDownList>
                            </div>
                        </div>






                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Payment Gateway
                                 <asp:Label runat="server" ID="Label4" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-3">
                                <asp:DropDownList ID="ddlPaymentGateway" runat="server" OnTextChanged="ddlPaymentGateway_TextChanged" AutoPostBack="true"></asp:DropDownList>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Reference Number
                            </label>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtReferenceNumber" runat="server" MaxLength="3000" placeholder="Reference Number"></asp:TextBox>
                            </div>
                        </div>


                        <div id="divReferenceNumber" runat="server" visible="false">
                            <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    Account Name
                                </label>
                                <div class="col-sm-3">
                                    <asp:TextBox ID="txtAccountName" runat="server" MaxLength="3000" placeholder="Account Name"></asp:TextBox>
                                </div>
                            </div>


                            <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    Account Number
                                </label>
                                <div class="col-sm-3">
                                    <asp:TextBox ID="txtAccountNumber" runat="server" MaxLength="3000" placeholder="Account Number"></asp:TextBox>
                                </div>
                            </div>


                            <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    Bank Name
                                </label>
                                <div class="col-sm-3">
                                    <asp:TextBox ID="txtBankName" runat="server" MaxLength="3000" placeholder="Bank Name"></asp:TextBox>
                                </div>
                            </div>


                            <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    Bank Branch
                                </label>
                                <div class="col-sm-3">
                                    <asp:TextBox ID="txtBankBranch" runat="server" MaxLength="3000" placeholder="Bank Branch"></asp:TextBox>
                                </div>
                            </div>


                        </div>








                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Save" UseSubmitBehavior="false" OnClientClick="this.disabled='true'; this.value='Please wait...';" />
                                <asp:Button ID="btnCancel" runat="server" Text="Back to list" UseSubmitBehavior="false"
                                    OnClick="btnCancel_Click" CausesValidation="false" />
                            </div>
                        </div>













































                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
