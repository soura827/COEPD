<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="SupportSearchAll.aspx.cs" Inherits="Admin_SupportSearchAll" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="../Bin/ckeditor/ckeditor.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                       Support Tickets
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                       
                       
                        <div class="col-lg-3 col-md-3">
                            <asp:DropDownList ID="ddlPriority" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlPriority_SelectedIndexChanged">
                                <asp:ListItem Text="-- Select Priority --" Value="0"></asp:ListItem>
                                <asp:ListItem Text="High" Value="1"></asp:ListItem>
                                <asp:ListItem Text="Medium" Value="2"></asp:ListItem>
                                <asp:ListItem Text="Low" Value="3"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:TextBox ID="txtSearch"   MaxLength="500" placeholder="Search" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:Button ID="btnSearch" runat="server"   Text="Find" OnClick="btnSearch_Click" />
                        </div>
                         <div class="col-lg-3 col-md-3">
                           &nbsp;
                        </div>
                        <div class="col-lg-1 col-md-1">
                           &nbsp;
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" OnRowCommand="gv_RowCommand" DataKeyNames="SupportId" 
                            OnRowDataBound="gv_RowDataBound" Width="100%" >
                            <Columns>
                                <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                <HeaderTemplate><center>  Action </center> </HeaderTemplate>
                                     <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                            CommandArgument='<%#Eval("SupportId")%>' Visible="true"></asp:LinkButton>
                                       <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                            CommandArgument='<%#Eval("SupportId")%>' Visible="true" OnClientClick="return confirm('Are sure you want to delete Ticket? ')"></asp:LinkButton>
                                    </ItemTemplate>
                                      <ItemStyle HorizontalAlign="Center" Width="150px"></ItemStyle>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="SNo">
                                  <HeaderTemplate><center>  SNo </center> </HeaderTemplate>
                                     <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("SNo") %>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle Width="50px" />
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Subject">
                                <HeaderTemplate><center>  Subject </center> </HeaderTemplate>
                                     <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <ItemTemplate>
                                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("Subject") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Posted By">
                               <HeaderTemplate><center>  Posted By </center> </HeaderTemplate>
                                     <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <ItemTemplate>
                                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("Employee") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Ticket Open Date">
                                <HeaderTemplate><center>  Ticket Open Date </center> </HeaderTemplate>
                                     <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <ItemTemplate>
                                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("CreatedOn", "{0:dd MMM yyyy hh:mm tt}") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Ticket Update Date">
                             <HeaderTemplate><center> Ticket Update Date </center> </HeaderTemplate>
                                     <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <ItemTemplate>
                                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("ModifiedOn", "{0:dd MMM yyyy hh:mm tt}") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Ticket ModifiedBy">
                               <HeaderTemplate><center> Ticket ModifiedBy </center> </HeaderTemplate>
                                     <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <ItemTemplate>
                                        <asp:Label ID="Label6" runat="server" Text='<%# Bind("ModifiedBy") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                               <asp:TemplateField HeaderText="Priority">
                                <HeaderTemplate><center> Priority </center> </HeaderTemplate>
                                     <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <ItemTemplate>
                                       <span style="color:<%# Eval("color")%>" > <%# Eval("Priority") %></span>
                                    </ItemTemplate>
                                </asp:TemplateField>
                               
                                <asp:TemplateField HeaderText="Status" ItemStyle-Width="150px">
                                <HeaderTemplate><center> Status </center> </HeaderTemplate>
                                     <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <ItemTemplate>
                                        <asp:HiddenField ID="hdnStatusId" runat="server" Value='<%#Eval("StatusId") %>' />
                                        <asp:DropDownList ID="ddlStatus" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlStatus_SelectedIndexChanged">
                                            <asp:ListItem Text=" -- Select -- " Value="0"></asp:ListItem>
                                            <asp:ListItem Text="InProgress" Value="1"></asp:ListItem>
                                            <asp:ListItem Text="Closed" Value="2"></asp:ListItem>
                                        </asp:DropDownList>
                                        <%--<div style="text-align:center">
                                         <asp:Button ID="btn" runat="server" OnClick="btn_Click" Text="Delete" OnClientClick="return confirm('Are sure you want to delete Ticket? ')" />
                                         </div>--%>
                                   </ItemTemplate>

<ItemStyle Width="150px"></ItemStyle>
                                </asp:TemplateField>
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
</asp:Content>

