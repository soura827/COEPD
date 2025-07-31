<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true"
    CodeFile="JobRequirementSearch.aspx.cs" Inherits="JobRequirementSearch" %>

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
                        Job Requirement
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-lg-1 col-md-1 pull-right">
                            <%-- <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" CausesValidation="false" Text="Add New"/>--%>
                        </div>
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="table-responsive">
                            <asp:GridView ID="gv" runat="server" OnRowDataBound="gv_RowDataBound" AutoGenerateColumns="False" OnRowCommand="gv_RowCommand"
                                Width="100%">
                                <Columns>
                                    <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="700px" HeaderStyle-Width="500px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                                CommandArgument='<%#Eval("JobRequirementId")%>'></asp:LinkButton>
                                            <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                                CommandArgument='<%#Eval("JobRequirementId")%>' OnClientClick="return confirm('Are you sure you want to delete this Job requirement?');"></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Posted Date" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                    <asp:BoundField HeaderText="Expiry Date" DataField="ExpiryDate" DataFormatString="{0:dd MMM yyyy}" />
                                    <asp:BoundField HeaderText="Company Name" DataField="CompanyName" />
                                    <asp:BoundField HeaderText="Email Id" DataField="EmailId" />
                                    <asp:BoundField HeaderText="Job Role" DataField="JobRole" />
                                    <asp:BoundField HeaderText="Contact Number" DataField="Mobile" />
                                    <asp:BoundField HeaderText="Job Description" DataField="JobDescription" HtmlEncode="false" />

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

