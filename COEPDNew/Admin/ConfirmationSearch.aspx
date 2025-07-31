<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ConfirmationSearch.aspx.cs" Inherits="Admin_ConfirmationSearch" EnableEventValidation="false"%>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Row Start -->
    <asp:ScriptManager ID="scriptmanager" runat="server"></asp:ScriptManager>
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                       Confirmation of Payment
                    </div>
                </div>
                <asp:UpdatePanel ID="UpdatePanel" runat="server">
                    <ContentTemplate>
                        <div class="widget-body">
                            <div class="row">
                                <div class="col-lg-3 col-md-3">
                                    <asp:TextBox runat="server" ID="txtActivityCategory" MaxLength="500" placeholder="Search By Participant" OnTextChanged="txtActivityCategory_TextChanged" AutoPostBack="true"></asp:TextBox>
                                </div>
                                <div class="col-lg-3 col-md-3">
                                    <asp:TextBox runat="server" ID="txtFullname" MaxLength="500" placeholder="Search By Location" OnTextChanged="txtActivityCategory_TextChanged" AutoPostBack="true"></asp:TextBox>
                                </div>
                                <div class="col-lg-3 col-md-3">
                                    <asp:TextBox runat="server" ID="textModified" MaxLength="500" placeholder="Search By Service Owner" OnTextChanged="txtActivityCategory_TextChanged" AutoPostBack="true"></asp:TextBox>
                                </div>
                                <div class="col-lg-2 col-md-2">
                                <asp:Button ID="btnDownload" runat="server" Text="Download" OnClick="btnDownload_Click"  UseSubmitBehavior="false" />
                        </div>

                            </div>
                            <div class="row">
                                &nbsp;
                            </div>
                            <div class="row">
                                <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" PageSize="20" Width="100%" AllowPaging="true" AllowSorting="true" OnPageIndexChanging="gv_PageIndexChanging" OnRowCommand="gv_RowCommand" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender">
                                    <Columns>

                                        <asp:BoundField HeaderText="S.No" DataField="SNo" />
                                        <asp:BoundField HeaderText="Participant Name" DataField="LeadName" />
                                        <asp:BoundField HeaderText="Batch Date" DataField="StartDate" DataFormatString="{0: dd MMM yyyy}" />
                                        <asp:BoundField HeaderText="Location" DataField="Location" />
                                        <asp:BoundField HeaderText="Amount" DataField="PayingAmount" />
                                        <asp:BoundField HeaderText="Reference Number" DataField="ReferenceNumber" />
                                        <asp:BoundField HeaderText="Payment Mode" DataField="PaymentType" />
                                        <asp:BoundField HeaderText="Paid On" DataField="PayingDate" DataFormatString="{0: dd MMM yyyy }" />
                                        <asp:BoundField HeaderText="Service Owner" DataField="CreatedByName" />
                                        <asp:BoundField HeaderText="Created On" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy}" />
                                        <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lnkEdit" runat="server" SkinID="Orange" Text="View" CommandName="cmdEdit"
                                                    CommandArgument='<%#Eval("ReceiptId")%>'></asp:LinkButton>
                                                <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" Visible="false" CommandName="cmdDelete"
                                                    CommandArgument='<%#Eval("ReceiptId")%>' OnClientClick="return confirm('Are you sure you want to delete this Confirmation?');"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
    </div>
</asp:Content>

