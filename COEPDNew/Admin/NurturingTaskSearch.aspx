<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="NurturingTaskSearch.aspx.cs" Inherits="Admin_NurturingTaskSearch" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
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
                        <div class="col-lg-3 col-md-3">
                            <asp:DropDownList ID="ddlNurturingProcessStage" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlNurturingProcessStage_SelectedIndexChanged">
                                <asp:ListItem Text="--Select Stage--" Value=""></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:DropDownList ID="ddlNurturingProcessStageTask" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlNurturingProcessStageTask_SelectedIndexChanged">
                                <asp:ListItem Text="--Select Stage Task--" Value=""></asp:ListItem>
                            </asp:DropDownList>
                        </div>

                        <div class="col-lg-2 col-md-2">
                             <asp:TextBox runat="server" ID="txtCreatedByName" Placeholder="Search by Created By" OnTextChanged="txtCreatedByName_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2">
                           <asp:TextBox runat="server" ID="txtModifiedByName" Placeholder="Search by Modified By" OnTextChanged="txtModifiedByName_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>

                        <div class="col-lg-1 col-md-1">
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
                                    <asp:BoundField HeaderText="Stage Name" DataField="NurturingProcessStageName" />
                                    <asp:BoundField HeaderText="Stage Task Name" DataField="NurturingProcessStageTaskName" />
                                    <asp:TemplateField HeaderText="Question Paper">
                                        <ItemTemplate>
                                            <asp:HiddenField ID="hdnSendFile" runat="server" Value='<%#Eval("SenderImagePath") %>' />
                                            <asp:HyperLink NavigateUrl='<%#"~/UserDocs/NurturingTask/"+ Eval("SenderImagePath") %>' runat="server"
                                                ID="hplSendFile" Target="_blank" CssClass="btn btn-success btn-xs">View</asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="Target Date Interval" DataField="TargetDateInterval" />
                                    <asp:BoundField HeaderText="CreatedBy" DataField="Fullname" />
                                    <asp:BoundField HeaderText="CreatedOn" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy}" />
                                    <asp:BoundField HeaderText="ModifiedBy" DataField="Modifiedname" />
                                    <asp:BoundField HeaderText="ModifiedOn" DataField="ModifiedOn" DataFormatString="{0: dd MMM yyyy}" />
                                    <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                                CommandArgument='<%#Eval("NurturingTaskId")%>'></asp:LinkButton>
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

