<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true"
    CodeFile="MyTaskSearch.aspx.cs" Inherits="MyTaskSearch" %>

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
                        My Tasks
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-lg-3 col-md-3">
                            <asp:TextBox runat="server" MaxLength="500" ID="txtSearch" placeholder="Search"></asp:TextBox>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:Button ID="btnSearch" runat="server" Text="Find" OnClick="btnSearch_Click" />
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <h5>Task Status </h5>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:DropDownList runat="server" ID="ddlStatus" AutoPostBack="true" OnSelectedIndexChanged="ddlStatus_SelectedIndexChanged">
                                <asp:ListItem Value="0">Pending </asp:ListItem>
                                <asp:ListItem Value="1">In Progress </asp:ListItem>
                                <asp:ListItem Value="2">Completed </asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-1 col-md-1">
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="table-responsive">
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" OnRowCommand="gv_RowCommand"
                                Width="100%">
                                <Columns>
                                    <asp:TemplateField HeaderText="Action" ItemStyle-Width="100px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkEdit" CommandArgument='<%#Eval("TaskId") %>' CommandName="cmdEdit"
                                                runat="server" SkinID="edit">Edit</asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <%-- <asp:BoundField HeaderText="Task Details" DataField="Description" HtmlEncode="false" />--%>
                                    <asp:BoundField HeaderText="Assigned Date" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                    <asp:BoundField HeaderText="Assigned By" DataField="AssignedEmployee" />
                                    <asp:BoundField HeaderText="Priority" DataField="Priority" />
                                    <asp:BoundField HeaderText="Task Status" DataField="TaskStatus" />
                                    <asp:BoundField HeaderText="Updated Date" DataField="ModifiedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                    <asp:BoundField HeaderText="Last Edited By" DataField="ModifiedBy" />
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
</asp:Content>
