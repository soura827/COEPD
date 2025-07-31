<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true"
    CodeFile="VendorSearch.aspx.cs" Inherits="VendorSearch" EnableEventValidation="false" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Vendors
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-lg-1 col-md-1">
                            <h4>Category</h4>
                        </div>
                        <div class="col-lg-4 col-md-4">
                            <asp:DropDownList ID="ddlVendorCategory" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlVendorCategory_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:TextBox ID="txtsearch" placeholder="Search" MaxLength="500" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:Button ID="btnSearch" runat="server" Text="Find" OnClick="btnSearch_Click" />
                        </div>
                        <div class="col-lg-1 col-md-1">
                            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" SkinID="addnew" CausesValidation="false" />
                        </div>
                         <div class="row">
                        &nbsp;
                    </div>
                          <div class="row">
                        &nbsp;
                    </div>
                          <div class="col-lg-2 col-md-2">
                                <asp:Button ID="btnDownload" runat="server" Text="Download" OnClick="btnDownload_Click" UseSubmitBehavior="false" />
                        </div>

                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" OnRowCommand="gv_RowCommand"
                            Width="100%" PageSize="500" AllowPaging="true" OnPageIndexChanging="gv_PageIndexChanging">
                            <Columns>
                                
                                <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                 <asp:BoundField HeaderText="Location" DataField="Location" />
                                 <asp:BoundField HeaderText="Category" DataField="VendorCategory" />
                                 <asp:BoundField HeaderText="Vendor" DataField="Vendor" />
                                 <asp:BoundField HeaderText="Vendor Office Address" DataField="LocationOffice" />
                                 <asp:BoundField HeaderText="ContactName" DataField="ContactName"/>
                                 <asp:BoundField HeaderText="Email" DataField="Email"/>
                                  <asp:BoundField HeaderText="Mobile" DataField="Mobile" />
                                  <asp:BoundField HeaderText="Office Phone" DataField="Phone" />
                                  <asp:BoundField HeaderText="Website Name" DataField="Website" />
                                  <asp:BoundField HeaderText="Created By" DataField="Fullname" />
                                  <asp:BoundField HeaderText="Created On" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                            CommandArgument='<%#Eval("VendorId")%>'></asp:LinkButton>
                                        <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                            CommandArgument='<%#Eval("VendorId")%>' OnClientClick="return confirm('Are you sure you want to delete this vendor?');"></asp:LinkButton>
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
        </div>
    </div>
</asp:Content>
