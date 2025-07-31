<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="TrainerProfileSearch.aspx.cs" Inherits="Admin_TrainerProfileSearch" %>

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
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Trainer Profile
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                       <div class="col-lg-3 col-md-3">
                            <asp:TextBox runat="server" ID="txtSearch" MaxLength="500" placeholder="Search"></asp:TextBox>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:Button ID="btnSearch" runat="server" Text="Find" OnClick="btnSearch_Click" />
                        </div>
                        <div class="col-lg-5 col-md-5">
                            &nbsp;
                        </div>
                        <div class="col-lg-1 col-md-1">
                            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" SkinID="addnew" CausesValidation="false" />
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="table-responsive">
                        <asp:GridView ID="gv" runat="server" OnRowCommand="gv_RowCommand" OnPageIndexChanging="gv_PageIndexChanging" AllowPaging="true" PageSize="20"
                             AutoGenerateColumns="False" Width="100%">                          
                            <Columns>
                                <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                            CommandArgument='<%#Eval("TrainerProfileId")%>'></asp:LinkButton>
                                        <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                            CommandArgument='<%#Eval("TrainerProfileId")%>' OnClientClick="return confirm('Are you sure you want to delete this Trainer Profile?');"></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                <asp:BoundField HeaderText="Trainer Name" DataField="Name" />
                                <asp:BoundField HeaderText="Description" DataField="Description" HtmlEncode="false" />
                                <asp:TemplateField HeaderText="Logo">
                                    <ItemTemplate>
                                        <a href='../UserDocs/TrainerProfile/<%#Eval("Profile")%>' target="_blank">
                                            <img src='../UserDocs/TrainerProfile/<%#Eval("Profile")%>' alt='Gallery' width="50px" height="50px" />
                                        </a>
                                    </ItemTemplate>

                                    <ItemStyle HorizontalAlign="Left" VerticalAlign="top" Width="50px" />
                                    <HeaderStyle HorizontalAlign="Left" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Display in HomePage" ItemStyle-Width="150px">
                                    <ItemTemplate>
                                        <%# (Boolean.Parse(Eval("IsFeatured").ToString())) ? "Yes" : "No" %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <PagerStyle HorizontalAlign="Center" VerticalAlign="Bottom" />
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
</asp:Content>

