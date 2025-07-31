<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="IdeaPostedAll.aspx.cs" Inherits="Admin_IdeaPostedAll" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        table caption {
            background-color: #5D7B9D;
            color: white;
            font-size: 16px;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Employee Ideas and Participants Feedback
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">

                        <div class="col-lg-3 col-md-3">
                            <asp:TextBox ID="txtSearch" placeholder="Search" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:Button ID="btnSearch" runat="server" Text="Find" OnClick="btnSearch_Click" />
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <%-- <asp:DropDownList ID="ddlEmployee" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlEmployee_SelectedIndexChanged">
                               
                            </asp:DropDownList>--%>
                            <asp:Button ID="btnEmployeeIdea" runat="server" Text="Employee Ideas" OnClick="btnEmployee_Click" />
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:Button ID="btnParticipantIdea" runat="server" Text="Participants Feedback" OnClick="btnParticipant_Click" />
                        </div>
                        <div class="col-lg-1 col-md-1">
                            &nbsp;
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="table-responsive">
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" OnRowCommand="gv_RowCommand" OnPageIndexChanging="gv_PageIndexChanging" PageSize="2" AllowPaging="true" OnRowDataBound="gv_RowDataBound" ShowHeaderWhenEmpty="true" OnPreRender="gv_PreRender" Width="100%" Caption="">
                                <Columns>
                                    <%-- <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                            CommandArgument='<%#Eval("IdeaPostId")%>'></asp:LinkButton>
                                       <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                            CommandArgument='<%#Eval("IdeaPostId")%>'></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>--%>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Posted Employee" DataField="Employee" />
                                    <asp:BoundField HeaderText="Posted On" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                    <asp:BoundField HeaderText="Subject" DataField="Subject" />
                                    <asp:BoundField HeaderText="Description" DataField="Description" HtmlEncode="false" />
                                </Columns>
                                <EmptyDataTemplate>
                                    <center>
                                        No Records Found
                                    </center>
                                </EmptyDataTemplate>
                            </asp:GridView>
                        </div>
                        <div class="table-responsive">
                            <asp:GridView ID="gv1" runat="server" AutoGenerateColumns="False" OnRowCommand="gv_RowCommand"
                                Width="100%" Caption="">
                                <Columns>
                                    <%--<asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                            CommandArgument='<%#Eval("IdeaPostId")%>'></asp:LinkButton>
                                       <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                      visble="false"      CommandArgument='<%#Eval("IdeaPostId")%>'></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>--%>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Posted Participant" DataField="Participant" />
                                    <asp:BoundField HeaderText="Branch Name" DataField="Branch" />
                                    <asp:BoundField HeaderText="Posted On" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                    <asp:BoundField HeaderText="Subject" DataField="Subject" />
                                    <asp:BoundField HeaderText="Description" DataField="Description" HtmlEncode="false" />
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
</asp:Content>
