 <%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" 
     CodeFile="CUGSimAssignSearch.aspx.cs" Inherits="Admin_CUGSimAssignSearch" EnableEventValidation="false" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" Runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <asp:ScriptManager ID="scriptmanager" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel" runat="server">
        <ContentTemplate>
            <div class="row">
                <div class="col-lg-12 col-md-12">
                    <div class="widget">
                        <div class="widget-header">
                            <div class="title">
                                Assign CUG Sim To Employee
                            </div>
                        </div>
                        <div class="widget-body">
                            <div class="row">
                                <div class="col-lg-2 col-md-2">
                                    <asp:TextBox runat="server" ID="txtEmployeeName" placeholder="Search By Employee Name" OnTextChanged="txtEmployeeName_TextChanged" AutoPostBack="true" ></asp:TextBox>
                                </div>
                                <div class="col-lg-2 col-md-2">
                                    <asp:TextBox runat="server" ID="txtMobile" placeholder="Search By Mobile Number" OnTextChanged="txtEmployeeName_TextChanged" AutoPostBack="true" ></asp:TextBox>
                                </div>
                                 <div class="col-lg-2 col-md-2">
                                    <asp:TextBox runat="server" ID="txtSimUsedFor" placeholder="Search By Process and Location" OnTextChanged="txtSimUsedFor_TextChanged" AutoPostBack="true" ></asp:TextBox>
                                </div>
                                <div class="col-md-2 col-lg-2">
                                   <asp:DropDownList ID="ddlStatus" runat="server" AutoPostBack="true" OnSelectedIndexChanged="txtEmployeeName_TextChanged">
                                       <asp:ListItem Text="Sim Assigned" Value="False"></asp:ListItem>
                                        <asp:ListItem Text="Sim Un Assigned" Value="True"></asp:ListItem>
                                        
                                    </asp:DropDownList>
                                </div>

                                <div class="col-lg-2 col-md-2">
                                    <asp:TextBox runat="server" ID="txtCode" placeholder=" Employee Code" OnTextChanged="txtCode_TextChanged" AutoPostBack="true"></asp:TextBox>
                                </div>

                                &nbsp;
                                 <div class="col-lg-2 col-md-2">
                                <asp:Button ID="btnDownload" runat="server" Text="Download" OnClick="btnDownload_Click" UseSubmitBehavior="false" />
                                 </div>




                                <div class="col-lg-2 col-md-2">
                                    
                                </div>
                                <div class="col-lg-2 col-md-2">
                                   
                                </div>
                                 <div class="col-lg-2 col-md-2">
                                   
                                </div>
                                 
                                 <div class="col-lg-2 col-md-2">
                                    
                               <br />&nbsp;
                                   
                                </div>
                                
                               
                                <div class="col-lg-2 col-md-2">
                                    <asp:Button ID="btnAssign" runat="server"  SkinID="btnGreen" OnClick="btnAssign_Click" Text="Assign" />
                                </div>
                                
                            </div>
                            <div class="row">
                                 &nbsp;
                            </div>
                            <div>
                                <asp:Label ID="PageNumberHeader" runat="server"></asp:Label>
                            </div>
                            <div class="row">
                                 <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" PageSize="200" HeaderStyle-HorizontalAlign="Center" Width="100%" AllowPaging="true" AllowSorting="true" OnRowCommand="gv_RowCommand" OnPageIndexChanging="gv_PageIndexChanging" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender">
                                     <Columns>
                                         <asp:BoundField HeaderText="S.No" DataField="SNo" />
                                         <asp:BoundField HeaderText="Employee" DataField="Employee" />
                                         <asp:BoundField HeaderText="Aadhar Number" DataField="AadharNumber"/>
                                         <asp:BoundField HeaderText="Mobile" DataField="Mobile" />
                                         <asp:BoundField HeaderText="Tarif Plan" DataField="TarifPlan" />
                                         <asp:BoundField HeaderText="Sim Used For" DataField="SimUsedFor" />
                                         <asp:BoundField HeaderText="Sim Assigned Date" DataField="SimAssignedDate" />
                                         <asp:BoundField HeaderText="Sim UnAssigned Date" DataField="SimUnAssignedDate" />
                                         <asp:BoundField HeaderText="Remarks" DataField="Remarks"/>
                                         <asp:BoundField HeaderText="Created On" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                         <asp:BoundField HeaderText="Created By" DataField="Fullname" />
                                         <asp:BoundField HeaderText="Modified On" DataField="ModifiedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                          <asp:BoundField HeaderText="Modified By" DataField="ModifiedByName" />
                                         <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                             <ItemTemplate>
                                                 <%--<asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                                CommandArgument='<%#Eval("CUGSimAssignId")%>'></asp:LinkButton>
                                                 <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                                CommandArgument='<%#Eval("CUGSimAssignId")%>' OnClientClick="return confirm('Are you sure you want to delete this Number?');"></asp:LinkButton>--%>

                                                  <asp:LinkButton ID="lnkUnAssign" runat="server" Text="Un Assign" CommandName="cmdUnAssign"  SkinID="Orange"
                                                CommandArgument='<%#Eval("CUGSimAssignId")%>' Visible='<%#(Convert.ToBoolean(Eval("IsSimUnAssigned").ToString())? false:true) %>' OnClientClick="return confirm('Are you sure you want to UnAssign this Number?');"></asp:LinkButton>
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

