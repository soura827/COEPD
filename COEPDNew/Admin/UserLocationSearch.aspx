<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="UserLocationSearch.aspx.cs" Inherits="UserLocationSearch" %>

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
                        Locations
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-lg-5 col-md-5">
                        </div>
                        <div class="col-lg-4 col-md-4">
                            <asp:TextBox runat="server" ID="txtEmployee" AutoPostBack="true" placeholder="Search By Employee Name, Mobile, Email" OnTextChanged="txtEmployee_TextChanged"></asp:TextBox>
                        </div>
                        <div class="col-lg-1 col-md-1">
                            Location
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:DropDownList ID="ddlLocation" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlLocation_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-5 col-md-5">
                            <h4 class="text-center">
                                Available Locations</h4>
                        </div>
                        <div class="col-lg-5 col-md-5">
                            <h4 class="text-center">
                                Assigned Locations</h4>
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="col-lg-6 col-md-6">
                            <div class="table-responsive">
                            <asp:GridView ID="gvUser" runat="server" OnRowCommand="gvUser_RowCommand" AutoGenerateColumns="False">
                                <Columns>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Name" DataField="Username" />
                                    <asp:TemplateField HeaderText="Add to Location" ItemStyle-HorizontalAlign="Center"
                                        ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkSend" runat="server" Text="Add to Location >>" CommandName="cmdAdd"
                                                CssClass="btn btn-primary" CommandArgument='<%#Eval("UserId")%>'></asp:LinkButton>
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
                        <div class="col-lg-6 col-md-6">
                            <div class="table-responsive">
                            <asp:GridView ID="gv" runat="server" OnRowCommand="gv_RowCommand" AutoGenerateColumns="False"
                                Width="100%">
                                <PagerSettings Mode="NumericFirstLast" FirstPageText="First" LastPageText="Last" />
                                <Columns>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Name" DataField="Username" />
                                    <asp:BoundField HeaderText="Location" DataField="Location" />
                                    <asp:TemplateField HeaderText="Remove from Location " ItemStyle-HorizontalAlign="Center"
                                        ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkSend" runat="server" Text="<< Remove from Location" CommandName="cmdRemove"
                                                CssClass="btn btn-info" CommandArgument='<%#Eval("UserLocationId")%>'></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
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
    </div>
    <!-- Row End -->
</asp:Content>
