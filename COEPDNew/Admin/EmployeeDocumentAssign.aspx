<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="EmployeeDocumentAssign.aspx.cs" Inherits="EmployeeDocumentAssign" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
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
                        <asp:Label ID="lblTitle" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="form-group">
                            <div class="col-sm-4">
                                <h4>Document Name:
                                    <asp:Label ID="lblDocumentName" runat="server"></asp:Label></h4>
                            </div>
                            <div class="col-sm-1">
                                <asp:Button ID="btnshare" runat="server" Text="Share" OnClick="btnshare_Click" />
                            </div>
                            <div class="pull-right">
                                <asp:Button ID="btnCancel" runat="server" Text="Back To Documents" OnClick="btnCancel_Click" />
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="form-group">
                            <div class="col-sm-4">
                                <asp:TextBox ID="txtEmployee" runat="server" Placeholder="Search by Employee Name, Email, Mobile" OnTextChanged="txtEmployee_TextChanged" AutoPostBack="true"></asp:TextBox>
                            </div>


                        </div>
                    </div>

                     <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="col-md-6">
                            <div class="form-group">
                                <div class="table-responsive">
                                <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" DataKeyNames="EmployeeId">
                                    <Columns>
                                        <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                        <asp:BoundField HeaderText="Name" DataField="Employee" />
                                        <asp:TemplateField HeaderText="Select Employees" ItemStyle-HorizontalAlign="Center" >
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chkEmployee" runat="server" />
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
                        <div class="col-lg-6 col-md-6">
                            <asp:GridView ID="gv1" runat="server" OnRowCommand="gv1_RowCommand" AutoGenerateColumns="False"
                                Width="100%" OnRowDataBound="gv1_RowDataBound" DataKeyNames="CreatedBy">
                                <Columns>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Shared To" DataField="Employee" />
                                    <asp:BoundField HeaderText="Document Name" DataField="DocumentName" />
                                    <asp:TemplateField HeaderText="Remove Document" ItemStyle-HorizontalAlign="Center">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkSend" runat="server" Text="<< Remove Document" CommandName="cmdRemove"
                                                CssClass="btn btn-info" CommandArgument='<%#Eval("EmployeeDocumentAssignId")%>'></asp:LinkButton>
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
</asp:Content>