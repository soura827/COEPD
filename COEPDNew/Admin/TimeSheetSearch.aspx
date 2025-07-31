<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="TimeSheetSearch.aspx.cs" Inherits="TimeSheetSearch" %>

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
                            <asp:TextBox runat="server" ID="txtSearch" MaxLength="500" placeholder="Search"></asp:TextBox>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:Button ID="btnSearch" runat="server" Text="Find" OnClick="btnSearch_Click" />
                        </div>

                        <div class="col-lg-offset-3 col-lg-3 col-md-offset-3 col-md-3 div-right">
                            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" SkinID="addnew" CausesValidation="false" />
                            <asp:Button ID="btnSendReport" runat="server" Text="Send Report"  OnClick="btnSendReport_Click" OnClientClick="return confirm('Are you sure want to send report ?');"/>
                        </div>
                        
                                             
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="table-responsive">
                        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" OnRowCommand="gv_RowCommand"
                            OnRowDataBound="gv_RowDataBound" Width="100%">
                            <Columns>
                                <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50px">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                            CommandArgument='<%#Eval("TimeSheetId")%>'></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                <asp:BoundField HeaderText="Date" DataField="Date" DataFormatString="{0:dd MMM yyyy}" ItemStyle-Width="100px"  />
                                <asp:TemplateField HeaderText="Start Time" ItemStyle-Width="100px">
                                    <ItemTemplate>
                                        <%# Eval("StartTime", "{0:hh:mm}") %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="End Time" ItemStyle-Width="100px">
                                    <ItemTemplate>
                                        <%# Eval("EndTime", "{0:hh:mm}") %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="Client" DataField="Client" />
                                <asp:BoundField HeaderText="Project" DataField="Project" />
                                <asp:BoundField HeaderText="Details" DataField="Note" />
                            </Columns>
                            <EmptyDataTemplate>
                                <center>
                                    No Records Found
                                </center>
                            </EmptyDataTemplate>
                        </asp:GridView>
                              <asp:GridView ID="gvReport" runat="server" AutoGenerateColumns="False"  Width="100%">
                            <Columns>                              
                                <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                <asp:BoundField HeaderText="Date" DataField="Date" DataFormatString="{0:dd MMM yyyy}" ItemStyle-Width="100px" Visible="false" />
                                <asp:TemplateField HeaderText="Start Time" ItemStyle-Width="100px">
                                    <ItemTemplate>
                                        <%# Eval("StartTime", "{0:hh:mm}") %>
                                    </ItemTemplate>
                                </asp:TemplateField>                             
                                <asp:TemplateField HeaderText="PostedTime">
                                    <ItemTemplate>
                                        <%# Eval("CreatedOn", "{0:hh:mm}") %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                               <asp:TemplateField HeaderText="End Time" ItemStyle-Width="100px">
                                    <ItemTemplate>
                                        <%# Eval("EndTime", "{0:hh:mm}") %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="ModifiedTime">
                                    <ItemTemplate>
                                        <%# Eval("ModifiedOn", "{0:hh:mm}") %>
                                    </ItemTemplate>
                                </asp:TemplateField>                               
                                <asp:BoundField HeaderText="Client" DataField="Client" />
                                <asp:BoundField HeaderText="Project" DataField="Project" />
                                <asp:BoundField HeaderText="Details" DataField="Note" />
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
</asp:Content>
