<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="NurturingProcessStageTaskSearch.aspx.cs" Inherits="Admin_NurturingProcessStageTaskSearch" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagPrefix="uc1" TagName="FormMessage" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagPrefix="uc2" TagName="ErrorMessage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" Runat="Server">
    <uc1:FormMessage runat="server" ID="FormMessage" Visible="false" />
    <uc2:ErrorMessage runat="server" ID="ErrorMessage" Visible="false" />
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
                                    Nurturing Process Stage Tasks
                                </div>
                            </div>
                            <div class="widget-body">
                                <div class="Row">
                                    <div class="col-lg-2 col-md-2">
                                        <asp:TextBox runat="server" ID="txtNurturingProcessStageName" MaxLength="250" Placeholder="Nurturing Process Stage Name" OnTextChanged="txtNurturingProcessStageName_TextChanged" AutoPostBack="True"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-2 col-md-2">
                                        <asp:TextBox runat="server" ID="txtNurturingProcessStageTaskName" MaxLength="250" Placeholder="NurturingProcessStage Name" OnTextChanged="txtNurturingProcessStageTaskName_TextChanged" AutoPostBack="True"></asp:TextBox>
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
                                            <asp:BoundField HeaderText="Nurturing Process Stage Name" DataField="NurturingProcessStageName" />
                                            <asp:BoundField HeaderText="Nurturing Process Stage Task Name" DataField="NurturingProcessStageTaskName" />
                                            <asp:BoundField HeaderText="Weightage" DataField="Weightage" />
                                            <asp:BoundField HeaderText="Time Frame" DataField="TimeFrame" />
                                            <asp:BoundField HeaderText="Created By" DataField="CreatedName" />
                                            <asp:BoundField HeaderText="Created On" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                            <asp:BoundField HeaderText="Modified By" DataField="ModifiedName" />
                                            <asp:BoundField HeaderText="Modified On" DataField="ModifiedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                            <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px" >
                                                <ItemTemplate>
                                        <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                            CommandArgument='<%#Eval("NurturingProcessStageTaskId")%>'></asp:LinkButton>
                                      <%--<asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                            CommandArgument='<%#Eval("NurturingProcessStageTaskId")%>' OnClientClick="return confirm('Are you sure you want to delete this Nurturing Process Stage Task?');"></asp:LinkButton>--%>
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

