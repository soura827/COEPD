<%@ Page Title="" Language="C#" MasterPageFile="Participant.master" AutoEventWireup="true" CodeFile="IdeaPostSearch.aspx.cs" Inherits="IdeaPostSearch" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                      Post Your Feedback
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-lg-3 col-md-3">
                            <asp:TextBox ID="txtSearch" placeholder="Search" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:Button ID="btnSearch" runat="server"  Text="Find" OnClick="btnSearch_Click" />
                        </div>
                         <div class="col-lg-3 col-md-3">
                           &nbsp;
                        </div>
                        <div class="col-lg-3 col-md-3">
                          &nbsp;
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
                        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False"  OnRowCommand="gv_RowCommand"
                             Width="100%" AllowPaging="True" PageSize="10" OnPageIndexChanging="gv_PageIndexChanging" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender" >
                            <Columns>
                                <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkEdit" runat="server" Text="Edit" SkinID="edit" CommandName="cmdEdit"
                                            CommandArgument='<%#Eval("IdeaPostId")%>'></asp:LinkButton>
                                       <%--<asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                            CommandArgument='<%#Eval("IdeaPostId")%>'></asp:LinkButton>--%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                <asp:BoundField HeaderText="Subject" DataField="Subject" />
                                <asp:TemplateField HeaderText="Employee Name" ItemStyle-HorizontalAlign="Center">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblEmployees" runat="server" Text='<%# Bind("Employee") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                 <asp:BoundField HeaderText="Description" DataField="Description" HtmlEncode="false" SortExpression="Description" />
                                <asp:BoundField HeaderText="Posted By" DataField="Participant" /> 
                            </Columns>
                            <EmptyDataTemplate>
                                <center>
                                    No Records Found
                                </center>
                            </EmptyDataTemplate>
                        </asp:GridView>
                             <div>
                              <asp:Label ID="PageNumberFooter" runat="server"></asp:Label>
                          </div>
                            </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>