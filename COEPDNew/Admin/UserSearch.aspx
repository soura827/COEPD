<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="UserSearch.aspx.cs" Inherits="UserSearch" %>

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
                        Users
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-lg-3 col-md-3">
                            <asp:TextBox runat="server" ID="txtSearch"  MaxLength="500" placeholder="Search"></asp:TextBox>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:Button ID="btnSearch" runat="server" Text="Find" OnClick="btnSearch_Click" />
                        </div>
                        <div class="col-lg-6 col-md-6">
                         <div class="col-lg-3 col-md-3">
                          <div class="form-group">
                            <label class="col-sm-5 control-label">
                                Active
                            </label>
                            <div class="col-sm-7">
                                <asp:radiobutton runat="server" ID="rbActive" AutoPostBack="true" GroupName = "radio"/>
                            </div>
                        </div>
                        </div>
                        <div class="col-lg-3 col-md-3">
                           <div class="form-group">
                                <label class="col-sm-5 control-label">
                                    Deleted
                                </label>
                                <div class="col-sm-7">
                                    <asp:radiobutton runat="server" ID="rbDeleted" AutoPostBack="true" GroupName = "radio"/>
                                </div>
                            </div>
                        </div>
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <asp:GridView ID="gv" runat="server" OnRowCommand="gv_RowCommand" AutoGenerateColumns="False"
                            Width="100%">
                            <PagerSettings Mode="NumericFirstLast" FirstPageText="First" LastPageText="Last" />
                            <Columns>
                                <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                <asp:BoundField HeaderText="Full Name" DataField="Fullname" />
                                <asp:BoundField HeaderText="Username" DataField="Username" />
                               <%-- <asp:BoundField HeaderText="Password" DataField="Pwd" />--%>
                                <asp:TemplateField HeaderText="Send Pwd" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50px">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkSend" runat="server" Text="Send Pwd" CommandName="cmdSend"
                                            CssClass="btn btn-primary" CommandArgument='<%#Eval("UserId")%>'></asp:LinkButton>
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
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Row End -->
</asp:Content>
