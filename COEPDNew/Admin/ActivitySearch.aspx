<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ActivitySearch.aspx.cs" Inherits="Admin_ActivitySearch" EnableEventValidation="false"%>

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
    <asp:ScriptManager ID="scriptmanager" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel" runat="server">
        <ContentTemplate>
            <div class="row">
                <div class="col-lg-12 col-md-12">
                    <div class="widget">
                        <div class="widget-header">
                            <div class="title">
                                Activity
                            </div>
                        </div>

                        <div class="widget-body">
                            <div class="row">
                                <div class="col-lg-2 col-md-2">
                                    <asp:TextBox runat="server" ID="txtActivityCategory" MaxLength="500" placeholder="Activity Category" OnTextChanged="txtActivityCategory_TextChanged" AutoPostBack="true"></asp:TextBox>
                                </div>
                                <div class="col-lg-2 col-md-2">
                                    <asp:TextBox runat="server" ID="txtActivitySubCategory" MaxLength="500" placeholder="Activity Subcategory" OnTextChanged="txtActivityCategory_TextChanged" AutoPostBack="true"></asp:TextBox>
                                </div>
                                <div class="col-lg-2 col-md-2">
                                    <asp:TextBox runat="server" ID="txtActivity" MaxLength="500" placeholder="Search By Activity" OnTextChanged="txtActivityCategory_TextChanged" AutoPostBack="true"></asp:TextBox>
                                </div>
                                <div class="col-lg-2 col-md-2">
                                    <asp:TextBox runat="server" ID="txtFullname" MaxLength="500" placeholder="Search By Created By" OnTextChanged="txtActivityCategory_TextChanged" AutoPostBack="true"></asp:TextBox>
                                </div>
                                <div class="col-lg-2 col-md-2">
                                    <asp:TextBox runat="server" ID="txtModified" MaxLength="500" placeholder="Search By ModifiedBy" OnTextChanged="txtActivityCategory_TextChanged" AutoPostBack="true"></asp:TextBox>
                                </div>
                                <div class="col-lg-2  col-md-2">
                                    <asp:Button ID="Button1" runat="server" SkinID="addnew" AutoPostBack="True" CausesValidation="false" OnClick="btnAdd_Click" />
                                </div>
                                <div class="col-lg-2 col-md-2">
                                    <asp:Button ID="btnDownload" runat="server" Text="Download" OnClick="btnDownload_Click" UseSubmitBehavior="false" />
                                </div>
                            </div>
                            <div class="row">
                                &nbsp;
                            </div>
                            <div>
                                <asp:Label ID="PageNumberHeader" runat="server"></asp:Label>
                            </div>
                            <div class="row">
                                <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" PageSize="20" HeaderStyle-HorizontalAlign="Center" Width="100%" AllowPaging="true" AllowSorting="true" OnRowCommand="gv_RowCommand" OnPageIndexChanging="gv_PageIndexChanging" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender">
                                    <Columns>
                                        <asp:BoundField HeaderText="S.No" DataField="SNo" />
                                        <asp:BoundField HeaderText="Activity Category" DataField="ActivityCategory" />
                                        <asp:BoundField HeaderText="Activity Subcategory" DataField="ActivitySubCategory" />
                                        <asp:BoundField HeaderText="Activity" DataField="Activity" />
                                        <%--<asp:BoundField HeaderText="ActivityModeofSelection" DataField="ActivityModeofSelection" />--%>
                                        <%-- <asp:BoundField HeaderText="Description" DataField="Description" />--%>
                                        <asp:BoundField HeaderText="Created By" DataField="Fullname" />
                                        <asp:BoundField HeaderText="Created On" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                        <asp:BoundField HeaderText="Modified By" DataField="Employee" />
                                        <asp:BoundField HeaderText="Modified On" DataField="ModifiedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                        <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                                    CommandArgument='<%#Eval("ActivityId")%>'></asp:LinkButton>
                                                <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                                    CommandArgument='<%#Eval("ActivityId")%>' OnClientClick="return confirm('Are you sure you want to delete this ActivityCategory?');"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                                <div>
                                    <asp:Label ID="PageNumberFooter" runat="server"></asp:Label>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
