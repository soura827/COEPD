<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ParticipantFeePayReceiptSearch.aspx.cs" Inherits="Admin_ParticipantFeePayReceiptSearch" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
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
                        Participant FeePay Receipt
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">





    


                        <div class="col-lg-1 col-md-1">
                            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" SkinID="addnew" CausesValidation="false" />
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="table-responsive">
                            <div class="table-responsive">
                                <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" OnRowCommand="gv_RowCommand" PageSize="100"
                                    Width="100%">
                                    <Columns>
                                        <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                            <ItemTemplate>

                                                <asp:LinkButton ID="lnkEdit" runat="server" SkinID="view" Text="View" CommandName="cmdEdit"
                                                    CommandArgument='<%#Eval("ReceiptId")%>'></asp:LinkButton>

                                                <asp:LinkButton ID="lnkReceipt" runat="server" SkinID="Green" Text="Receipt" CommandName="cmdReceipt"
                                                    CommandArgument='<%#Eval("ReceiptId")%>'></asp:LinkButton>


                                                <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                                    Visible="false" CommandArgument='<%#Eval("ReceiptId")%>' OnClientClick="return confirm('Are you sure you want to delete this Record?');"></asp:LinkButton>


                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField HeaderText="SNo" DataField="SNo" />
                                        <asp:BoundField HeaderText="Participant" DataField="Participant" />
                                        <asp:BoundField HeaderText="ReceiptDate" DataField="ReceiptDate" DataFormatString="{0:dd MMM yyyy}" />
                                        <asp:BoundField HeaderText="Payment Type" DataField="PaymentType" />
                                        <asp:BoundField HeaderText="GSTtax" DataField="GSTtax" />

                                        
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
                </div>
            </div>
        </div>
    </div>
    <!-- Row End -->
</asp:Content>

