<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true"
    CodeFile="EmployeeDocumentSearch.aspx.cs" Inherits="EmployeeDocumentSearch" %>

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
                        My Documents
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-lg-3 col-md-3">
                            <asp:TextBox runat="server" MaxLength="500" ID="txtSearch" placeholder="Search"></asp:TextBox>
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
                        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" OnRowCommand="gv_RowCommand" DataKeyNames="EmployeeDocumentId"
                            Width="100%">
                            <Columns>
                                <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkEdit" runat="server" SkinID="Edit" CommandName="cmdEdit"
                                            CommandArgument='<%#Eval("EmployeeDocumentId")%>'></asp:LinkButton>
                                        <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                            CommandArgument='<%#Eval("EmployeeDocumentId")%>' OnClientClick="return confirm('Are you sure you want to delete this document?');"></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                <asp:BoundField HeaderText="Document Name" DataField="EmployeeDocument" />
                                <asp:BoundField HeaderText="Document Category" DataField="EmployeeDocumentType" />
                                <asp:TemplateField HeaderText="Share To Employee">
                                    <ItemTemplate>
                                        <a href='<%#"EmployeeDocumentAssign.aspx?DocumentId="+DataBinder.Eval(Container.DataItem,"EmployeeDocumentId") %>' class="btn btn-info btn-sm">Share </a>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Share To Participant">
                                    <ItemTemplate>
                                        <asp:HyperLink ID="hp2" runat="server" NavigateUrl='ParticipantDocShare.aspx'
                                            CssClass="btn btn-info btn-sm">Share</asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="View">
                                    <ItemTemplate>
                                        <asp:HyperLink ID="hpl" runat="server" NavigateUrl='<%#"~/UserDocs/EmployeeDocument/"+ Eval("EmployeeDocumentPath")%>'
                                            Target="_blank" CssClass="btn btn-info btn-sm">View</asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Download">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkDownload" runat="server" Text="Download" CommandName="cmdDownload"
                                            CommandArgument='<%#Eval("EmployeeDocumentPath")%>' />
                                    </ItemTemplate>
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
    </div>
    <!-- Row End -->
    <!-- Row Start -->
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Shared Documents
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <asp:GridView ID="gvShared" runat="server" AutoGenerateColumns="False" OnRowCommand="gvShared_RowCommand"
                            Width="100%" DataKeyNames="EmployeeDocumentId">
                            <Columns>
                                <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                <asp:BoundField HeaderText="Document Name" DataField="DocumentName" />
                                <asp:BoundField HeaderText="Shared By" DataField="AssignedEmployee" />
                                <asp:BoundField HeaderText="Shared On" DataField="CreatedOn" DataFormatString="{0:dd MMM yyyy}" />
                                <asp:TemplateField HeaderText="Share To Employee">
                                    <ItemTemplate>
                                        <a href='<%#"EmployeeDocumentAssign.aspx?DocumentId="+DataBinder.Eval(Container.DataItem,"EmployeeDocumentId") %>' class="btn btn-info btn-sm">Share </a>

                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="View">
                                    <ItemTemplate>
                                        <asp:HyperLink ID="hpl" runat="server" NavigateUrl='<%#"~/UserDocs/EmployeeDocument/"+ Eval("EmployeeDocumentPath")%>'
                                            Target="_blank" CssClass="btn btn-info btn-sm">View</asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Download">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkDownload" runat="server" Text="Download" CommandName="cmdDownload"
                                            CommandArgument='<%#Eval("EmployeeDocumentPath")%>' />
                                    </ItemTemplate>
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
    <!-- Row End -->
</asp:Content>