<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="InventorySearch.aspx.cs" Inherits="Admin_InventorySearch" %>

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
                        Inventory
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">

                        <div class="col-lg-2 col-md-2">
                            <asp:DropDownList ID="ddlInventoryClassification" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlInventoryClassification_SelectedIndexChanged" Width="110%">
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:DropDownList ID="ddlInventoryType" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlInventoryType_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>

                        <div class="col-lg-3 col-md-3">
                            <asp:DropDownList ID="ddlInventoryStatus" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlInventoryStatus_SelectedIndexChanged" Width="80%">
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox runat="server" ID="txtSearch" placeholder="Search"></asp:TextBox>
                        </div>
                        <div class="col-lg-1 col-md-1">
                            <asp:Button ID="Button1" runat="server" Text="Find" OnClick="btnSearch_Click" />
                        </div>
                        <div class="col-lg-1 col-md-1">
                            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" SkinID="addnew" CausesValidation="false" />
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="table-responsive">
                            <asp:GridView ID="gv" runat="server" OnRowCommand="gv_RowCommand" OnPageIndexChanging="gv_PageIndexChanging"
                                AllowPaging="true" PageSize="20" AutoGenerateColumns="False" Width="100%">
                                <PagerSettings Mode="NumericFirstLast" FirstPageText="First" LastPageText="Last" />
                                <Columns>
                                    <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                                CommandArgument='<%#Eval("InventoryId")%>'></asp:LinkButton>
                                            <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                                CommandArgument='<%#Eval("InventoryId")%>' OnClientClick="return confirm('Are you sure you want to delete this inventory?');"></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Location" DataField="Location" />
                                    <asp:BoundField HeaderText="Location Office" DataField="LocationOffice" />
                                    <asp:BoundField HeaderText="InventoryName" DataField="InventoryName" />
                                    <asp:BoundField HeaderText="InventoryType" DataField="InventoryType" />
                                    <asp:BoundField HeaderText="Classification" DataField="InventoryClassification" />
                                    <asp:BoundField HeaderText="Purchase Date" DataField="PurchaseDate" DataFormatString="{0:dd MMM yyyy}" />
                                    <asp:BoundField HeaderText="Vendor" DataField="Vendor" />
                                    <asp:BoundField HeaderText="No.Of Items" DataField="NoOfItems" />
                                    <asp:BoundField HeaderText="Exp Date" DataField="ExpirationDate" DataFormatString="{0:dd MMM yyyy}" />
                                    <asp:TemplateField HeaderText="Order Alert">
                                        <ItemTemplate>
                                            <span><%# Eval("OrderAlert") %></span>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="Cost" DataField="PurchaseCost" />
                                    <asp:BoundField HeaderText="CreatedBy" DataField="Fullname" />
                                </Columns>
                                <PagerStyle HorizontalAlign="Center" VerticalAlign="Bottom" />
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
</asp:Content>