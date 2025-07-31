<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="LocationSearch.aspx.cs" Inherits="LocationSearch" %>

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
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Locations
                    </div>
                </div>
                <asp:UpdatePanel ID="UpdatePanel" runat="server">
                    <ContentTemplate>
                        <div class="widget-body">
                            <div class="row">
                                <div class="col-lg-3 col-md-3">
                                    <asp:TextBox runat="server" ID="txtLocation" MaxLength="500" placeholder="Search By Location" OnTextChanged="txtLocation_TextChanged" AutoPostBack="true"></asp:TextBox>
                                </div>
                                <div class="col-lg-3 col-md-3">
                                    <asp:TextBox runat="server" ID="txtFullname" MaxLength="500" placeholder="Search By Created By" OnTextChanged="txtFullname_TextChanged" AutoPostBack="true"></asp:TextBox>
                                </div>
                                <div class="col-lg-3 col-md-3">
                                    <asp:TextBox runat="server" ID="textModified" MaxLength="500" placeholder="Search By Modified By" OnTextChanged="textModified_TextChanged" AutoPostBack="true"></asp:TextBox>
                                </div>
                                <div class="col-lg-3  col-md-3">
                                    <asp:Button ID="btnAdd" runat="server" SkinID="addnew" AutoPostBack="True" CausesValidation="false" OnClick="btnAdd_Click" />
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
                                <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" PageSize="20" Width="100%" AllowPaging="true" AllowSorting="true" OnPageIndexChanging="gv_PageIndexChanging" OnRowCommand="gv_RowCommand" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender">
                                    <Columns>

                                        <asp:BoundField HeaderText="S.No" DataField="SNo" />
                                        <asp:BoundField HeaderText="LocationId" DataField="LocationId" />

                                        <asp:BoundField HeaderText="Location Name" DataField="Location" />
                                        <asp:BoundField HeaderText="Google Review Link" DataField="GoogleReviewLink" />
                                        <asp:BoundField HeaderText="Created By" DataField="Fullname" />
                                        <asp:BoundField HeaderText="Created On" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                        <asp:BoundField HeaderText="Modified By" DataField="Employee" />
                                        <asp:BoundField HeaderText="Modified On" DataField="ModifiedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                        <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                                    CommandArgument='<%#Eval("LocationId")%>'></asp:LinkButton>
                                                <%--<asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                            CommandArgument='<%#Eval("LocationId")%>' OnClientClick="return confirm('Are you sure you want to delete this Location?');"></asp:LinkButton>--%>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                                    </div>
                                <div>
                                    <asp:Label ID="PageNumberFooter" runat="server"></asp:Label>
                                </div>
                            </div>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
    </div>
    <!-- Row End -->
</asp:Content>
