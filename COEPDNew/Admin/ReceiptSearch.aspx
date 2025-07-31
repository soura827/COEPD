<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="ReceiptSearch.aspx.cs" Inherits="ReceiptSearch" %>

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
                        Receipts
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-lg-2 col-md-2">
                            <asp:DropDownList ID="ddlCourse" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCourse_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:DropDownList ID="ddlBatchType" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlBatchType_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:DropDownList ID="ddlLocation" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlLocation_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-2 col-md-2">
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox runat="server" ID="txtSearch"  MaxLength="500" placeholder="Search"></asp:TextBox>
                        </div>
                        <div class="col-lg-1 col-md-1">
                            <asp:Button ID="btnSearch" runat="server" Text="Find" OnClick="btnSearch_Click" />
                        </div>
                        <div class="col-lg-1 col-md-1">
                            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" SkinID="addnew" CausesValidation="false" />
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                     <div>
                        <asp:Label ID="PageNumberHeader" runat="server"></asp:Label>

                    </div>
                    <div class="row">
                        <div class="table-responsive">
                            <div class="table-responsive">
                        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" HeaderStyle-HorizontalAlign="Center" AllowPaging="true" AllowSorting="true"  OnRowCommand="gv_RowCommand" PageSize="100"
                            Width="100%" OnPageIndexChanging ="gv_PageIndexChanging" OnPreRender="gv_PreRender">
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
                                <asp:BoundField HeaderText="Tax" DataField="Tax" />
                                <asp:BoundField HeaderText="Amount" DataField="Amount" DataFormatString="{0:N2}"/>
                                <asp:BoundField HeaderText="Total" DataField="Total" DataFormatString="{0:N2}"
                                    ItemStyle-HorizontalAlign="Right" />
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
        </div>
    </div>
    <!-- Row End -->
</asp:Content>
