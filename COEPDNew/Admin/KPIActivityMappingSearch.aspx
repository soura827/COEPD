<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="KPIActivityMappingSearch.aspx.cs" Inherits="Admin_KPIActivityMappingSearch" %>

<%@ Register Src="~/Controls/ErrorMessage.ascx" TagPrefix="uc1" TagName="ErrorMessage" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagPrefix="uc2" TagName="FormMessage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" Runat="Server">
    <uc1:ErrorMessage runat="server" ID="ErrorMessage" Visible="false" />
    <uc2:FormMessage runat="server" ID="FormMessage" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <!-- Row Start -->
    <asp:ScriptManager ID="scriptmanager" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="updatepanel" runat="server">
        <ContentTemplate>
                <div class="Row">
                    <div class="col-lg-12 col-md-12">
                        <div class="widget">
                            <div class="widget-header">
                                <div class="title">
                                    KPI Activity Mapping
                                </div>
                            </div>
                            <div class="widget-body">
                                <div class="Row">
                                    <div class="col-lg-2 col-md-2">
                                        <asp:TextBox runat="server" ID="txtKPIName" MaxLength="100" Placeholder="KPI Name" OnTextChanged="txtKPIName_TextChanged" AutoPostBack="True"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-2 col-md-2">
                                        <asp:TextBox runat="server" ID="txtActivity" MaxLength="25" Placeholder="Activity" OnTextChanged="txtActivity_TextChanged" AutoPostBack="true"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-2 col-md-2">
                                        <asp:TextBox runat="server" ID="txtCreatedName" Placeholder="Created By" AutoPostBack="true" OnTextChanged="txtCreatedName_TextChanged"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-2 col-md-2">
                                        <asp:TextBox runat="server" ID="txtModifiedName" Placeholder="Modified By" AutoPostBack="true" OnTextChanged="txtModifiedName_TextChanged"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-2 col-md-2">
                                        <asp:Button ID="btnAdd" runat="server" SkinID="addnew" AutoPostBack="true" CausesValidation="false" OnClick="btnAdd_Click" />
                                    </div>
                                </div>
                                <div>
                                    &nbsp;
                                </div>
                                <div>
                                    &nbsp;
                                </div>
                                <div>
                                    <asp:Label ID="PageNumberHeader" runat="server"></asp:Label>
                                </div>
                                <div class="Row">
                                    <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" PageSize="20" HeaderStyle-HorizontalAlign="Center" Width="100%" AllowPaging="true" OnRowCommand="gv_RowCommand" AllowSorting="true" OnPageIndexChanging="gv_PageIndexChanging" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender">
                                        <Columns>
                                            <asp:BoundField HeaderText="S NO" DataField="SNO" />
                                            <asp:BoundField HeaderText="KPI Name" DataField="KPIName" />
                                            <asp:BoundField HeaderText="Activity Name" DataField="Activity" />
                                            <asp:BoundField HeaderText="Value Alloted" DataField="ValueAlloted" />
                                            <asp:BoundField HeaderText="Created By" DataField="CreatedName" />
                                            <asp:BoundField HeaderText="Created On" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                            <asp:BoundField HeaderText="Modified By" DataField="ModifiedName" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                            <asp:BoundField HeaderText="Modified On" DataField="ModifiedOn" />
                                            <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px" >
                                                <ItemTemplate>
                                        <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                            CommandArgument='<%#Eval("KPIActivityMappingId")%>'></asp:LinkButton>
                                      <%--<asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                            CommandArgument='<%#Eval("KPIActivityMappingId")%>' OnClientClick="return confirm('Are you sure you want to delete this KPI activity mapping?');"></asp:LinkButton>--%>
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
    <!-- Row End -->
</asp:Content>

