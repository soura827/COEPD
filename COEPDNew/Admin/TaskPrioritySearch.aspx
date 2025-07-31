<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="TaskPrioritySearch.aspx.cs" Inherits="Admin_TaskPrioritySearch" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" Runat="Server">
      <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!-- Row Start -->
    <asp:ScriptManager ID="scriptmanager" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel" runat="server">
    <ContentTemplate>
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                          Tasks Priority
                    </div>
                </div>
                
                <div class="widget-body">
                    <div class="row">
                         <div class="col-lg-2 col-md-2">
                            <asp:TextBox runat="server" ID="txtEmployee" MaxLength="500" placeholder="Search By Employee" OnTextChanged="txtEmployee_TextChanged" AutoPostBack="true" ></asp:TextBox>
                        </div>
                         <div class="col-lg-2 col-md-2">
                            <asp:TextBox runat="server" ID="txtNurturingProcessStage" MaxLength="500" placeholder="Nurturing Process Stage" OnTextChanged="txtNurturingProcessStage_TextChanged" AutoPostBack="true" ></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox runat="server" ID="txtNurturingProcessStageTask" MaxLength="500" placeholder="Nurturing Process Stage Task" OnTextChanged="txtNurturingProcessStageTask_TextChanged" AutoPostBack="true" ></asp:TextBox>
                        </div>
                       
                        
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div>
                        <asp:Label ID="PageNumberHeader" runat="server"></asp:Label>
                    </div>
                      <div class="row"> 
                          <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" PageSize="50" HeaderStyle-HorizontalAlign="Center" Width="100%" AllowPaging="true" AllowSorting="true" OnRowCommand="gv_RowCommand" OnPageIndexChanging="gv_PageIndexChanging" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender">
                              <Columns>                                  
                                  <asp:BoundField HeaderText="S.No" DataField="SNo" />
                                  <asp:BoundField HeaderText="Employee" DataField="Employee" />
                                  <asp:BoundField HeaderText="Nurturing Process Stage" DataField="NurturingProcessStageName" />
                                  <asp:BoundField HeaderText="Nurturing Process Stage Task" DataField="NurturingProcessStageTaskName" />
                                <asp:BoundField HeaderText="Task Priority" DataField="TaskPriority" />
                                   <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                            CommandArgument='<%#Eval("NurturingProcessStageTaskAccessId")%>'></asp:LinkButton>
                                        <%--<asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                            CommandArgument='<%#Eval("ActivityId")%>' OnClientClick="return confirm('Are you sure you want to delete this Activity?');"></asp:LinkButton>--%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                              </Columns>
                          </asp:GridView>
                          <div>
                              <asp:Label ID="PageNumberFooter" runat="server"></asp:Label>
                          </div>
                      </div>
                    </div> 

                    <div class="row">
                      <div class="col-sm-offset-5 col-sm-10">
                           <asp:Button runat="server" ID="btnBack" Text="Back To Assign Tasks" OnClick="btnBack_Click" />
                      </div> 
                        </div>
                <br /> 
                </div>
            </div>
        </div>
     </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

