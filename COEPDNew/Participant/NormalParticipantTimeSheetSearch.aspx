<%@ Page Title="" Language="C#" MasterPageFile="Participant.master" AutoEventWireup="true"
  CodeFile="NormalParticipantTimeSheetSearch.aspx.cs" Inherits="NormalParticipantTimeSheetSearch" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Row Start -->
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Time Sheet
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-lg-3 col-md-3">
                            <asp:TextBox runat="server" ID="txtSearch" placeholder="Search"></asp:TextBox>
                        </div>
                        <div class="col-lg-3 col-md-3">
<%--                            <asp:Button ID="btnSearch" runat="server" Text="Find" OnClick="btnSearch_Click1"  />--%>
                            <asp:Button ID="btnSearch" runat="server" Text="Find" OnClick="btnSearch_Click"  />
                        </div>
                        <div class="col-lg-5 col-md-5">
                            &nbsp;
                        </div>
                        <div class="col-lg-1 col-md-1">
                            <asp:Button ID="btnAdd" runat="server" SkinID="addnew" OnClick="btnAdd_Click"  />
                              <%-- <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" SkinID="addnew" CausesValidation="false" />--%>
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="table-responsive">
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" Width="100%" OnRowCommand="gv_RowCommand" OnRowDataBound="gv_RowDataBound" >
                                <Columns>
                                    <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="100px">
                                       <ItemTemplate>
                                        <asp:LinkButton ID="lnkEdit" runat="server" Text="Edit" SkinID="edit" CommandName="cmdEdit"
                                            CommandArgument='<%#Eval("TimeSheetId")%>'></asp:LinkButton>
                                        <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                            CommandArgument='<%#Eval("TimeSheetId")%>' OnClientClick="return confirm('Are you sure you want to delete this Record?');"></asp:LinkButton>
                                    </ItemTemplate>
<ItemStyle HorizontalAlign="Center" Width="100px"></ItemStyle>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" />
                                    <asp:TemplateField HeaderText="Date">
                                        <ItemTemplate>
                                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("Date","{0:dd, MMM yyyy}") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Start Time">
                                        <ItemTemplate>
                                        <%# Eval("StartTime", "{0:hh:mm}") %> <%# Eval("StartTimeAmPm") %>
                                    </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="EndTime">
                                         <ItemTemplate>
                                        <%# Eval("EndTime", "{0:hh:mm}") %> <%# Eval("EndTimeAmPm") %>
                                    </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="Note" DataField="Note" />
                                </Columns>
                                <EmptyDataTemplate>
                                    <center>
                                        No Records Found
                                    </center>
                                </EmptyDataTemplate>
                            </asp:GridView>
<%--                          <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" 
                            Width="100%">
                            <Columns>
                                <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="100px">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkEdit" runat="server" Text="Edit" SkinID="edit" CommandName="cmdEdit"
                                            CommandArgument='<%#Eval("TimeSheetId")%>'></asp:LinkButton>
                                        <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                            CommandArgument='<%#Eval("TimeSheetId")%>' OnClientClick="return confirm('Are you sure you want to delete this Record?');"></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                <asp:BoundField HeaderText="Date" DataField="Date" DataFormatString="{0:dd MMM yyyy}" />
                                <asp:TemplateField HeaderText="Start Time">
                                    <ItemTemplate>
                                        <%# Eval("StartTime", "{0:hh:mm}") %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="End Time">
                                    <ItemTemplate>
                                        <%# Eval("EndTime", "{0:hh:mm}") %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="Description" DataField="Note" />
                            </Columns>
                            <EmptyDataTemplate>
                                <center>
                                    No Records Found
                                </center>
                            </EmptyDataTemplate>
                        </asp:GridView>--%>
                            </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Row End -->
</asp:Content>