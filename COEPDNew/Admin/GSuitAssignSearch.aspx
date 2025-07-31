<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="GSuitAssignSearch.aspx.cs" Inherits="Admin_GSuitAssignSearch" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" Runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="scriptmanager" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel" runat="server">
        <ContentTemplate>
            <div class="row">
                <div class="col-lg-12 col-md-12">
                    <div class="widget">
                        <div class="widget-header">
                            <div class="title">
                                Assign Email To Employee
                            </div>
                        </div>
                        <div class="widget-body">
                            <div class="row">
                                <div class="col-lg-2 col-md-2">
                                    <asp:TextBox runat="server" ID="txtEmployeeName" placeholder="Search By Employee Name" OnTextChanged="txtEmployeeName_TextChanged" AutoPostBack="true" ></asp:TextBox>
                                </div>
                                <div class="col-lg-2 col-md-2">
                                    <asp:TextBox runat="server" ID="txtEmail" placeholder="Search By Email" OnTextChanged="txtEmployeeName_TextChanged" AutoPostBack="true" ></asp:TextBox>
                                </div>
                                <div class="col-md-2 col-lg-2">
                                   <asp:DropDownList ID="ddlStatus" runat="server" AutoPostBack="true" OnSelectedIndexChanged="txtEmployeeName_TextChanged">
                                       <asp:ListItem Text="Email Assigned" Value="False"></asp:ListItem>
                                        <asp:ListItem Text="Email Un Assigned" Value="True"></asp:ListItem>
                                        
                                    </asp:DropDownList>
                                </div>
                                <div class="col-lg-2 col-md-2">
                                    
                                </div>
                                <div class="col-lg-2 col-md-2">
                                   
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
                                 <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" PageSize="20" HeaderStyle-HorizontalAlign="Center" Width="100%" AllowPaging="true" AllowSorting="true" OnRowCommand="gv_RowCommand" OnPageIndexChanging="gv_PageIndexChanging" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender">
                                     <Columns>
                                         <asp:BoundField HeaderText="S.No" DataField="SNo" />
                                         <asp:BoundField HeaderText="Employee" DataField="Employee" />
                                         <asp:BoundField HeaderText="Email Id" DataField="GsuitEmail"/>
                                         <asp:BoundField HeaderText="Purpose" DataField="Purpose" />                                                                
                                         <asp:BoundField HeaderText="Email Assigned Date" DataField="EmailAssignedDate" />
                                         <asp:BoundField HeaderText="Email UnAssigned Date" DataField="EmailUnAssignedDate" />   
                                         <asp:BoundField HeaderText="Remarks" DataField="Remarks" />
                                         <asp:BoundField HeaderText="Created On" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                         <asp:BoundField HeaderText="Created By" DataField="Fullname" />
                                         <asp:BoundField HeaderText="Modified On" DataField="ModifiedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                          <asp:BoundField HeaderText="Modified By" DataField="ModifiedByName" />
                                         <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                             <ItemTemplate>                                                
                                                  <asp:LinkButton ID="lnkUnAssign" runat="server" Text="Un Assign" CommandName="cmdUnAssign" 
                                                CommandArgument='<%#Eval("GSuitEmailAssignId")%>' Visible='<%#(Convert.ToBoolean(Eval("IsEmailUnAssigned").ToString())? false:true) %>' OnClientClick="return confirm('Are you sure you want to UnAssign this Email?');"></asp:LinkButton>
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

