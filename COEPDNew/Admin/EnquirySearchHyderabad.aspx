<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="EnquirySearchHyderabad.aspx.cs" Inherits="Admin_EnquirySearchHyderabad" %>

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
                        Enquiry List Hyderabad
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        &nbsp;
                    </div>
                    <div>
                        <asp:Label ID="PageNumberHeader" runat="server"></asp:Label>
                    </div>
                    <div class="row">
                        <div class="table-responsive">


                            <asp:GridView ID="gv" runat="server" OnRowCommand="gv_RowCommand"
                                AutoGenerateColumns="False" Width="100%" AllowPaging="true" AllowSorting="true" PageSize="50" OnPageIndexChanging="gv_PageIndexChanging" OnPreRender="gv_PreRender">
                                <Columns>
                                   <%-- <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                        <ItemTemplate>
                                          
                                            <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                                CommandArgument='<%#Eval("EnquiryId")%>' OnClientClick="return confirm('Are you sure you want to delete this enquiry?');"></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>--%>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Enquiry Date" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                    <asp:BoundField HeaderText="Name" DataField="Name" />
                                    <asp:BoundField HeaderText="Email" DataField="Email1" />
                                    <asp:BoundField HeaderText="Mobile" DataField="Mobile1" />
                                    <asp:BoundField HeaderText="Location" DataField="City" />
                                  <%--  <asp:TemplateField HeaderText="Course">
                                        <ItemTemplate>
                                            <%#(string.IsNullOrEmpty(Eval("Course").ToString())? Eval("CourseName") : Eval("Course") )%>
                                        </ItemTemplate>
                                    </asp:TemplateField>--%>
                                    <asp:BoundField HeaderText="Planning To Attend" DataField="TimeRequired" />
                                </Columns>
                                <PagerStyle HorizontalAlign="Center" VerticalAlign="Bottom" />
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
    <!-- Row End -->
</asp:Content>
