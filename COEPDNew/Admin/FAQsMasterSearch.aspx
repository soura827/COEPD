<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="FAQsMasterSearch.aspx.cs" Inherits="Admin_FAQsMasterSearch" %>

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
                                FAQs
                            </div>
                        </div>

                        <div class="widget-body">
                            <div class="row">
                                <div class="col-lg-2 col-md-2">
                                    <asp:TextBox runat="server" ID="txtCompanyName" MaxLength="500" placeholder="Company Name" OnTextChanged="txtCompanyName_TextChanged" AutoPostBack="true"></asp:TextBox>
                                </div>
                                <div class="col-lg-2 col-md-2">
                                    <asp:TextBox runat="server" ID="txtExperience" placeholder="Experience" OnTextChanged="txtCompanyName_TextChanged" AutoPostBack="true"></asp:TextBox>
                                </div>
                                <div class="col-lg-2 col-md-2">
                                    <asp:TextBox runat="server" ID="txtSkilSet" MaxLength="500" placeholder="Skill Set" OnTextChanged="txtCompanyName_TextChanged" AutoPostBack="true"></asp:TextBox>
                                </div>
                                <div class="col-md-2 col-lg-2">
                                    <asp:DropDownList ID="ddlStatus" runat="server" AutoPostBack="true" OnSelectedIndexChanged="txtCompanyName_TextChanged">
                                        <asp:ListItem Text="Not Revised" Value="False"></asp:ListItem>
                                        <asp:ListItem Text="Revised" Value="True"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                 <div class="col-md-2 col-lg-2">
                                    <asp:DropDownList ID="ddlSource" runat="server" AutoPostBack="true" OnSelectedIndexChanged="txtCompanyName_TextChanged">
                                        <asp:ListItem Text="Employee" Value="False"></asp:ListItem>
                                        <asp:ListItem Text="Participant" Value="True"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="col-lg-2  col-md-2">
                                    <asp:Button ID="btnAddNew" runat="server" SkinID="addnew" AutoPostBack="True" CausesValidation="false" OnClick="btnAddNew_Click" />
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
                                        <asp:BoundField HeaderText="Company Name" DataField="CompanyName" />
                                        <asp:BoundField HeaderText="Experience" DataField="Experience" />
                                        <asp:BoundField HeaderText="Skilll Set" DataField="SkilSet" />
                                        <asp:BoundField HeaderText="Interview Round" DataField="InterviewStatus" />
                                        <asp:TemplateField HeaderText="Status">
                                            <ItemTemplate>
                                                <%# (Boolean.Parse(Eval("IsRevised").ToString()) ? "Revised" : "Not Revised" )%>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField HeaderText="Created By" DataField="FullName" />
                                        <asp:BoundField HeaderText="Created On" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                        <asp:BoundField HeaderText="Revised By" DataField="Employee" />
                                        <asp:BoundField HeaderText=" Revised On" DataField="RevisedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                        <asp:TemplateField HeaderText="Source">
                                            <ItemTemplate>
                                                <%# (Boolean.Parse(Eval("IsSourceParticipant").ToString()) ? "Participant" : "Employee" )%>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="100px">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lnkEdit" runat="server" Text="Edit" CommandName="cmdEdit"
                                                    CommandArgument='<%#Eval("UniqueId")%>'></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                    <EmptyDataTemplate>
                                        <center>
                                            No Records Found
                                        </center>
                                    </EmptyDataTemplate>
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

