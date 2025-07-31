<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="HrRequestFAQsSearch.aspx.cs" Inherits="Admin_HrRequestFAQsSearch" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
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
                        Request FAQs From HR
                    </div>
                </div>
                <div class="widget-body">

                    <div class="row">



                        <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtCompanyName" MaxLength="250" placeholder="Search By Company Name" AutoPostBack="true" OnTextChanged="txtCompanyName_TextChanged"></asp:TextBox>
                        </div>

                        <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtLocation" MaxLength="250" placeholder="Search By location" AutoPostBack="true" OnTextChanged="txtLocation_TextChanged"></asp:TextBox>
                        </div>
                        <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtDomain" MaxLength="250" placeholder="Search By Domain" AutoPostBack="true" OnTextChanged="txtDomain_TextChanged"></asp:TextBox>
                        </div>
                        <div class="col-md-2 col-lg-2">
                            <asp:DropDownList ID="ddlIsSent" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlIsSent_SelectedIndexChanged">
                                <asp:ListItem Text="Pending" Value="False"></asp:ListItem>
                                <asp:ListItem Text="Sent" Value="True"></asp:ListItem>
                            </asp:DropDownList>
                        </div>

                    </div>

                    <div>
                        <asp:Label ID="PageNumberHeader" runat="server"></asp:Label>
                    </div>
                    <div class="row">
                        <div class="table-responsive">


                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" Width="100%" PageSize="50" HeaderStyle-HorizontalAlign="Center" AllowPaging="true" AllowSorting="true" OnRowCommand="gv_RowCommand" OnPageIndexChanging="gv_PageIndexChanging" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender">



                                <Columns>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Company Name" DataField="CompanyName" />
                                    <asp:BoundField HeaderText="Loaction" DataField="Location" />
                                    <asp:BoundField HeaderText="Experience" DataField="Experience" />
                                    <asp:BoundField HeaderText="Domain" DataField="Domain" />
                                    <asp:BoundField HeaderText="Requested By" DataField="Fullname" />
                                    <asp:BoundField HeaderText="Requested On" DataField="CreatedOn"  />
                                    <asp:BoundField HeaderText="Sent By" DataField="ModifiedByName" />
                                    <asp:BoundField HeaderText="Sent On" DataField="ModifiedOn"  />

                                    <asp:TemplateField HeaderText="Status">
                                        <ItemTemplate>
                                            <%# (Boolean.Parse(Eval("IsSent").ToString()) ? "Sent" : "Pending" )%>
                                        </ItemTemplate>
                                    </asp:TemplateField>



                                    <asp:TemplateField HeaderText="Add FAQs" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">

                                        <ItemTemplate>

                                            <asp:LinkButton ID="lnkEdit" runat="server" SkinID="Green" Text="Add FAQs" CommandName="cmdAssign"
                                                CommandArgument='<%#Eval("HrRequestFAQsId")%>' Visible='<%#(Boolean.Parse(Eval("IsSent").ToString()) ? false:true) %>'></asp:LinkButton>

                                           <%-- <asp:LinkButton ID="lnkAssign" runat="server" Text="View" Visible='<%#(Boolean.Parse(Eval("IsApproved").ToString()) ? true:false) %>' CommandName="cmdView"
                                                CommandArgument='<%#Eval("HrRequestFAQsId")%>'></asp:LinkButton>--%>

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
                        <div>
                            <asp:Label ID="PageNumberFooter" runat="server"></asp:Label>
                        </div>



                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

