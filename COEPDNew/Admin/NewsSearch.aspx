<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="NewsSearch.aspx.cs" Inherits="NewsSearch" %>

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
                        Training News List
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-lg-2 col-md-2">
                            <h4>Website Page</h4>
                        </div>
                        <div class="col-lg-9 col-md-9">
                            <asp:DropDownList ID="ddlNews" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlNews_SelectedIndexChanged">
                                <%--<asp:ListItem Text="-- Select Page --" Value=""></asp:ListItem>--%>
                                <asp:ListItem Text="Business Analyst Training in Hyderabad" Value="1"></asp:ListItem>
                                <asp:ListItem Text="Business Analyst Training in Chennai" Value="2"></asp:ListItem>
                                <asp:ListItem Text="Business Analyst Training in Pune" Value="3"></asp:ListItem>
                                <asp:ListItem Text="Business Analyst Training in Mumbai" Value="4"></asp:ListItem>
                                <asp:ListItem Text="Business Analyst Training in Visakhapatnam" Value="5"></asp:ListItem>
                                <asp:ListItem Text="Business Analyst Training in Banglore" Value="6"></asp:ListItem>
                                <asp:ListItem Text="Business Analyst Training in Delhi" Value="7"></asp:ListItem>
                                <asp:ListItem Text="Business Analyst Training in Solapur" Value="8"></asp:ListItem>
                                <asp:ListItem Text="Business Analyst Training in Dallas" Value="9"></asp:ListItem>
                                <asp:ListItem Text="Business Analyst Online Trainng" Value="10"></asp:ListItem>
                                <asp:ListItem Text="Business Intelligence Tools" Value="11"></asp:ListItem>
                                <asp:ListItem Text="Business Analyst Training Internships" Value="12"></asp:ListItem>
                                <asp:ListItem Text="Internet of Things" Value="13"></asp:ListItem>
                                <asp:ListItem Text="Dot Net" Value="14"></asp:ListItem>
                                <asp:ListItem Text="Digital Marketing" Value="15"></asp:ListItem>
                                <asp:ListItem Text="Testing" Value="16"></asp:ListItem>
                                <asp:ListItem Text="Web Designing" Value="17"></asp:ListItem>
                                <asp:ListItem Text="Data Science" Value="18"></asp:ListItem>
                                <asp:ListItem Text="VMware vSphere" Value="19"></asp:ListItem>
                                <asp:ListItem Text="Webdeign internship" Value="20"></asp:ListItem>
                                <asp:ListItem Text="Dotnet internship" Value="21"></asp:ListItem>
                                <asp:ListItem Text="Datascience internship" Value="22"></asp:ListItem>
                                <asp:ListItem Text="Digital marketing internship" Value="23"></asp:ListItem>
                                <asp:ListItem Text="Scrum Training" Value="27"></asp:ListItem>
                                <asp:ListItem Text="IIBA CPOA Certification Training" Value="24"></asp:ListItem>
                                <asp:ListItem Text="Business Analyst Corporate Training" Value="25"></asp:ListItem>
                                <asp:ListItem Text="Knowledge Partner" Value="26"></asp:ListItem>
                                <%-- <asp:ListItem Text="BA internship" Value="24"></asp:ListItem>--%>
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-1 col-md-1 pull-right">
                            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" SkinID="addnew" CausesValidation="false" />
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="table-responsive">
                            <asp:GridView ID="gv" runat="server" OnRowCommand="gv_RowCommand" OnPageIndexChanging="gv_PageIndexChanging"
                                AllowPaging="true" PageSize="20" AutoGenerateColumns="False" Width="100%">
                                <PagerSettings Mode="NumericFirstLast" FirstPageText="First" LastPageText="Last" />
                                <Columns>
                                    <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                                CommandArgument='<%#Eval("NewsId")%>'></asp:LinkButton>
                                            <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                                CommandArgument='<%#Eval("NewsId")%>' OnClientClick="return confirm('Are you sure you want to delete this training news?');"></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="News" DataField="NewsDescription" />
                                </Columns>
                                <PagerStyle HorizontalAlign="Center" VerticalAlign="Bottom" />
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
