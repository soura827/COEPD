<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="TaskSearch.aspx.cs" Inherits="TaskSearch" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="../Bin/ckeditor/ckeditor.js" type="text/javascript"></script>
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
                        Assign Tasks to Employees
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-lg-1 col-md-1">
                            <h5>Employees</h5>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:DropDownList ID="ddlEmployee" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlEmployee_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-1 col-md-1">
                            <h5>Priority</h5>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:DropDownList ID="ddlPriority" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlPriority_SelectedIndexChanged">
                                <asp:ListItem Text="-- Select Priority --" Value="0"></asp:ListItem>
                                <asp:ListItem Text="High" Value="1"></asp:ListItem>
                                <asp:ListItem Text="Medium" Value="2"></asp:ListItem>
                                <asp:ListItem Text="Low" Value="3"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-1 col-md-1">
                            <h5>Task Status</h5>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:DropDownList ID="ddlTaskStatus" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlTaskStatus_SelectedIndexChanged">
                                <asp:ListItem Text=" -- Select Task Status -- " Value="0"></asp:ListItem>
                                <asp:ListItem Text="Inprogress" Value="1"></asp:ListItem>
                                <asp:ListItem Text="Completed" Value="2"></asp:ListItem>
                            </asp:DropDownList>
                        </div>

                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="col-lg-1 col-md-1">
                            <h5>Status</h5>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:DropDownList ID="ddlStatusCheck" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlStatusCheck_SelectedIndexChanged">
                                <asp:ListItem Text=" -- Select Status -- " Value="0"></asp:ListItem>
                                <asp:ListItem Text="Open" Value="1"></asp:ListItem>
                                <asp:ListItem Text="Closed" Value="2"></asp:ListItem>
                                <asp:ListItem Text="ReOpen" Value="3"></asp:ListItem>
                                <asp:ListItem Text="WIP" Value="4"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:TextBox ID="txtSearch" MaxLength="500" runat="server" placeholder="Search"></asp:TextBox>
                        </div>
                        <div class="col-lg-1 col-md-1">
                            <asp:Button ID="btnSearch" runat="server" Text="Find" OnClick="btnSearch_Click" />
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
                    <div class="row">
                        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" OnRowCommand="gv_RowCommand"
                            DataKeyNames="TaskId" Width="100%" OnRowDataBound="gv_RowDataBound">
                            <Columns>
                                <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                            CommandArgument='<%#Eval("TaskId")%>'></asp:LinkButton>
                                        <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                            Visible="false" CommandArgument='<%#Eval("TaskId")%>'></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                <asp:BoundField HeaderText="Assigned To" DataField="Employee" />
                                <asp:BoundField HeaderText="Assigned Date" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                <asp:BoundField HeaderText="Updated Date" DataField="ModifiedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                <asp:BoundField HeaderText="Last Edited By" DataField="ModifiedBy" />
                                <%-- <asp:BoundField HeaderText="Task Details" DataField="Description" HtmlEncode="false" />--%>

                                <asp:BoundField HeaderText="Task" DataField="Task" HtmlEncode="false" />

                                <asp:TemplateField HeaderText="FileUpload">
                                    <ItemTemplate>
                                        <asp:HiddenField ID="hdnFileUpload" runat="server" Value='<%#Eval("FileUploadPath") %>' />
                                        <asp:HyperLink NavigateUrl='<%#"~/UserDocs/FileUpload/"+ Eval("FileUploadPath") %>' runat="server"
                                            ID="hplflFileUpload" Target="_blank" CssClass="btn btn-success btn-xs">View</asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>






                                <asp:TemplateField HeaderText="Priority">

                                    <ItemTemplate>
                                        <span style="color: <%# Eval("color")%>"><%# Eval("Priority") %></span>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Task Status">
                                    <ItemTemplate>
                                        <span style="color: <%# Eval("color")%>"><%# Eval("TaskStatus") %></span>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Status" ItemStyle-Width="150px">
                                    <ItemTemplate>
                                        <asp:HiddenField ID="hdnStatusId" runat="server" Value='<%#Eval("StatusId") %>' />
                                        <asp:DropDownList ID="ddlStatus" runat="server" ReadOnly="true" AutoPostBack="true" OnSelectedIndexChanged="ddlStatus_SelectedIndexChanged">
                                            <asp:ListItem Text=" -- Select -- " Value="0"></asp:ListItem>
                                            <asp:ListItem Text="Open" Value="1"></asp:ListItem>
                                            <asp:ListItem Text="Closed" Value="2"></asp:ListItem>
                                            <asp:ListItem Text="ReOpen" Value="3"></asp:ListItem>
                                            <asp:ListItem Text="WIP" Value="4"></asp:ListItem>
                                        </asp:DropDownList>
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
