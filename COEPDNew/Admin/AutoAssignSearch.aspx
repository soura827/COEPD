<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="AutoAssignSearch.aspx.cs" Inherits="Admin_AutoAssignSearch" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
    <uc1:formmessage id="FormMessage" runat="server" visible="false" />
    <uc2:errormessage id="ErrorMessage" runat="server" visible="false" />
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
                        Nurturing Tasks
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-lg-4 col-md-5">
                            <asp:DropDownList ID="ddlNurturingProcessStage" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlNurturingProcessStage_SelectedIndexChanged">
                                <asp:ListItem Text="--Select Stage--" Value=""></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-4 col-md-5">
                            <asp:DropDownList ID="ddlNurturingProcessStageTask" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlNurturingProcessStageTask_SelectedIndexChanged">
                                <asp:ListItem Text="--Select Stage Task--" Value=""></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-3 col-md-5">
                            &nbsp;
                        </div>
                        <div class="col-lg-1 col-md-2">
                            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" SkinID="addnew" CausesValidation="false" />
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
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" OnRowCommand="gv_RowCommand" OnRowDataBound="gv_RowDataBound" OnPreRender="gv_PreRender" Width="100%">
                                <Columns>
                                    
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="StageName" DataField="NurturingProcessStageName" />
                                    <asp:BoundField HeaderText="StageTaskName" DataField="NurturingProcessStageTaskName" />
                                    <asp:TemplateField HeaderText="Question Paper">
                                        <ItemTemplate>
                                            <asp:HiddenField ID="hdnSendFile" runat="server" Value='<%#Eval("SenderImagePath") %>' />
                                            <asp:HyperLink NavigateUrl='<%#"~/UserDocs/NurturingProcess/"+ Eval("SenderImagePath") %>' runat="server"
                                                ID="hplSendFile" Target="_blank" CssClass="btn btn-success btn-xs">View</asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="TargetDateInterval" DataField="TargetDateInterval" />
                                    <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                                CommandArgument='<%#Eval("NurturingAutoAssignId")%>'></asp:LinkButton>
                                          <%--  <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                                CommandArgument='<%#Eval("NurturingAutoAssignId")%>' OnClientClick="return confirm('Are you sure you want to delete this Task?');"></asp:LinkButton>--%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <%--<asp:BoundField HeaderText="Task" DataField="Notes" />--%>
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
    <!-- Row End -->
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<%--</asp:Content>--%>

