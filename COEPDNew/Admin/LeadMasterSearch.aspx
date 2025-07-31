<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="LeadMasterSearch.aspx.cs" Inherits="Admin_LeadMasterSearch" %>

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
                        Lead Master
                    </div>
                </div>
                <asp:UpdatePanel ID="UpdatePanel" runat="server">
                    <ContentTemplate>
                        <div class="widget-body">
                            <div class="row">


                                <div class="col-lg-4 col-md-4">
                                    <asp:TextBox runat="server" ID="txtNameMobileEmail" MaxLength="500" placeholder="Search By LeadName, Mobile & Email" OnTextChanged="txtActivityCategory_TextChanged" AutoPostBack="true"></asp:TextBox>
                                </div>






                                <div class="col-lg-3 col-md-3">
                                    <asp:DropDownList ID="ddlLocation" runat="server" OnSelectedIndexChanged="ddlLocation_SelectedIndexChanged"
                                        AutoPostBack="true">
                                    </asp:DropDownList>
                                </div>



                                <div class="col-lg-3 col-md-3">
                                    <asp:DropDownList ID="ddlLeadSourcePageName" runat="server" OnSelectedIndexChanged="ddlLocation_SelectedIndexChanged"
                                        AutoPostBack="true">
                                    </asp:DropDownList>
                                </div>
                                     <div class="col-lg-2  col-md-2">
                                    <asp:Button ID="btnAdd" runat="server" SkinID="addnew" AutoPostBack="True"   CausesValidation="false" OnClick="btnAdd_Click" />
                                </div>




                            </div>
                            <div class="row">
                                &nbsp;
                            </div>
                       
                            <div>
                                <asp:Label ID="PageNumberHeader" runat="server"></asp:Label>
                            </div>
                            <div class="row">
                                <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" PageSize="20" Width="100%" AllowPaging="true" AllowSorting="true" OnPageIndexChanging="gv_PageIndexChanging" OnRowCommand="gv_RowCommand" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender">
                                    <Columns>

                                        <asp:BoundField HeaderText="S.No" DataField="SNo" />
                                        <asp:BoundField HeaderText="LeadName" DataField="LeadName" />

                                        <asp:BoundField HeaderText="Mobile" DataField="Mobile" />
                                        <asp:BoundField HeaderText="Email" DataField="Email" />
                                        <asp:BoundField HeaderText="Location" DataField="Location" />
                                        <asp:BoundField HeaderText="LeadSourcePageName" DataField="LeadSourcePageName" />
                                        <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lnkEdit" runat="server" Visible="false"  SkinID="edit" CommandName="cmdEdit"
                                                    CommandArgument='<%#Eval("LeadMasterId")%>'></asp:LinkButton>
                                                <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                                    CommandArgument='<%#Eval("LeadMasterId")%>' OnClientClick="return confirm('Are you sure you want to delete this LeadMaster?');"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
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
</asp:Content>

