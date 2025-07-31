<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="EmployeeSearch.aspx.cs" Inherits="EmployeeSearch" EnableEventValidation="false"%>

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
                        Employees
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-lg-3 col-md-3">
                            <asp:DropDownList ID="ddlDesignation" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlDesignation_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox runat="server" ID="txtSearch" MaxLength="500" placeholder="Search"></asp:TextBox>
                        </div>
                      
                        <div class="col-lg-2 col-md-2">
                            <asp:Button ID="btnSearch" runat="server" Text="Find" OnClick="btnSearch_Click" />
                        </div>
                         <%-- <div class="col-lg-2 col-md-2">
                            <asp:TextBox runat="server" ID="txtLocation" MaxLength="500" placeholder="Location Search" AutoPostBack="true" OnTextChanged="txtLocation_TextChanged"></asp:TextBox>
                        </div>--%>
                         <div class="col-lg-2 col-md-2">
                                <asp:Button ID="btnDownload" runat="server" Text="Download" OnClick="btnDownload_Click" UseSubmitBehavior="false" />
                            </div>
                        <div class="col-lg-2 col-md-2">
                            <div class="form-group">
                            <label class="col-sm-5 control-label">
                                Active
                            </label>
                            <div class="col-sm-7">
                                <asp:radiobutton runat="server" ID="rbActive" AutoPostBack="true" GroupName = "radio"/>
                            </div>
                        </div>
                        </div>
                        <div class="col-lg-2 col-md-2">
                           <div class="form-group">
                                <label class="col-sm-5 control-label">
                                    Deleted
                                </label>
                                <div class="col-sm-7">
                                    <asp:radiobutton runat="server" ID="rbDeleted" AutoPostBack="true" GroupName = "radio"/>
                                </div>
                            </div>
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
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" OnRowCommand="gv_RowCommand" Width="100%" OnRowDataBound="gv_RowDataBound">
                                <Columns>
                                    <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="100px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                                CommandArgument='<%#Eval("EmployeeId")%>'></asp:LinkButton>
                                            <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                                CommandArgument='<%#Eval("EmployeeId")%>' OnClientClick="return confirm('Are you sure you want to delete this Record?');"></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="EmployeeId" DataField="EmployeeId" ItemStyle-Width="50px" />

                                    <asp:BoundField HeaderText="Code" DataField="Code" />
                                    <asp:BoundField HeaderText="Employee" DataField="Employee" />
                                    <asp:BoundField HeaderText="Designation" DataField="Designation" />
                                     <asp:BoundField HeaderText="Location" DataField="Location" />

                                    <asp:BoundField HeaderText="Mobile" DataField="Mobile" />
                                    <asp:BoundField HeaderText="CUG" DataField="CUGMobile" />
                                    <asp:BoundField HeaderText="PersonalEmail" DataField="Email" />
                                    <asp:BoundField HeaderText="OfficeEmail" DataField="OfficeEmail" />
                                    <asp:BoundField HeaderText="PhonePay Number" DataField="PhonePayNumber" />
                                    <asp:BoundField HeaderText="GooglePay Number" DataField="GooglePayNumber" />
                                    <asp:BoundField HeaderText="Paytm Number" DataField="PaytmNumber" />

                                    <asp:TemplateField HeaderText="Lead Permit">
                                        <ItemTemplate>
                                            <%# (Boolean.Parse(Eval("IsLeadPermit").ToString())) ? "Yes" : "No" %>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Nurture Permit">
                                        <ItemTemplate>
                                            <%# (Boolean.Parse(Eval("NurturePermit").ToString())) ? "Yes" : "No" %>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Resumes">
                                        <ItemTemplate>
                                            <asp:HiddenField ID="hdnResumeFile" runat="server" Value='<%#Eval("ResumePath") %>' />
                                            <asp:HyperLink NavigateUrl='<%#"~/UserDocs/Employee/"+ Eval("ResumePath") %>' runat="server"
                                                ID="hplResume" Target="_blank" CssClass="btn btn-success btn-xs">View</asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="BankPassbook">
                                        <ItemTemplate>
                                            <asp:HiddenField ID="hdnBankPassbook" runat="server" Value='<%#Eval("PassbookFilePath") %>' />
                                            <asp:HyperLink NavigateUrl='<%#"~/UserDocs/Employee/"+ Eval("PassbookFilePath") %>' runat="server"
                                                ID="hplBankPassbook" Target="_blank" CssClass="btn btn-success btn-xs">View</asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="PancardFilePath">
                                        <ItemTemplate>
                                            <asp:HiddenField ID="hdnPancardFilePath" runat="server" Value='<%#Eval("PancardFilePath") %>' />
                                            <asp:HyperLink NavigateUrl='<%#"~/UserDocs/Employee/"+ Eval("PancardFilePath") %>' runat="server"
                                                ID="hplPancardFilePath" Target="_blank" CssClass="btn btn-success btn-xs">View</asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Aadhar Front Side">
                                        <ItemTemplate>
                                            <asp:HiddenField ID="hdnAadharFrontFilePath" runat="server" Value='<%#Eval("AadharFrontFilePath") %>' />
                                            <asp:HyperLink NavigateUrl='<%#"~/UserDocs/Employee/"+ Eval("AadharFrontFilePath") %>' runat="server"
                                                ID="hplAadharFrontFilePath" Target="_blank" CssClass="btn btn-success btn-xs">View</asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Aadhar Back Side">
                                        <ItemTemplate>
                                            <asp:HiddenField ID="hdnAadharBackFilePath" runat="server" Value='<%#Eval("AadharBackFilePath") %>' />
                                            <asp:HyperLink NavigateUrl='<%#"~/UserDocs/Employee/"+ Eval("AadharBackFilePath") %>' runat="server"
                                                ID="hplAadharBackFilePath" Target="_blank" CssClass="btn btn-success btn-xs">View</asp:HyperLink>
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
    <asp:Label ID="lblMessage" runat="server"></asp:Label>
</asp:Content>