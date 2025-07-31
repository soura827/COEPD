<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ParticipantDiscountSearch.aspx.cs" Inherits="Admin_ParticipantDiscountSearch"EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Row Start -->
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Participant Discount Details
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">




                        <div class="col-lg-1 col-md-1">
                            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" SkinID="addnew" CausesValidation="false" />
                        </div>

                        <div class="col-sm-offset-1 col-sm-1">
                            <asp:Button ID="btnback" runat="server" Text="Back to FeePayment" OnClick="btnback_Click" />

                        </div>


                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div>
                        <asp:Label ID="PageNumberHeader" runat="server"></asp:Label>

                    </div>

                    <div class="row">
                        <div class="table-responsive">
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" Width="100%" PageSize="100" HeaderStyle-HorizontalAlign="Center" AllowPaging="true" AllowSorting="true" OnRowCommand="gv_RowCommand" OnPageIndexChanging="gv_PageIndexChanging" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender">
                                <Columns>

                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Lead " DataField="Lead" ItemStyle-Width="150px" />
                                    <asp:BoundField HeaderText="Services" DataField="ServiceName" />
                                    <asp:BoundField HeaderText="Discount Amount" DataField="DiscountAmt" />
                                    <asp:BoundField HeaderText="Created On" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy}" />
                                    <asp:BoundField HeaderText="ServiceOwnerName" DataField="Fullname" />

                                </Columns>
                                <EmptyDataTemplate>
                                    <center>
                                        No Records Found
                                    </center>
                                </EmptyDataTemplate>
                            </asp:GridView>
                            <div>
                                <asp:Label ID="PageNumberFooter" runat="server"></asp:Label>
                            </div>
                        </div>
                    </div>

                </div>
        </div>
    </div>
</asp:Content>

