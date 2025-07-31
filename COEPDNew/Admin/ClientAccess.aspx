<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true"
    CodeFile="ClientAccess.aspx.cs" Inherits="ClientAccess" %>
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
                        Assign Clients To Employees
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-lg-1 col-md-1">
                            <h5>
                                Employee</h5>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:DropDownList ID="ddlEmployee" runat="server" AutoPostBack="true"  required=""
                                OnSelectedIndexChanged="ddlEmployee_SelectedIndexChanged"> </asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="col-lg-6 col-md-6">
                            <div class="row col-lg-offset-3">
                                <h4>
                                    Available Clients
                                </h4>
                            </div>
                            <div class="table-responsive">
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" Width="100%" OnRowCommand="gv_RowCommand">
                                <Columns>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Client" DataField="Client" />
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkSend" runat="server" Text="Assign Client" CommandName="cmdAdd"
                                                CssClass="btn btn-primary" CommandArgument='<%#Eval("ClientId")%>'></asp:LinkButton>
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
                            <div class="row col-lg-offset-3">
                                <h4>
                                    Assigned Clients
                                </h4>
                            </div>                            
                            <div class="table-responsive">    
                            <asp:GridView ID="gvAssign" runat="server" AutoGenerateColumns="False" Width="100%"
                                OnRowCommand="gvAssign_RowCommand">
                                <PagerSettings Mode="NumericFirstLast" FirstPageText="First" LastPageText="Last" />
                                <Columns>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Client" DataField="Client" />
                                    <asp:TemplateField HeaderText="Remove " ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkSend" runat="server" Text="Remove Client " CommandName="cmdRemove"
                                                CssClass="btn btn-info" CommandArgument='<%#Eval("ClientAccessId")%>'></asp:LinkButton>
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
</asp:Content>