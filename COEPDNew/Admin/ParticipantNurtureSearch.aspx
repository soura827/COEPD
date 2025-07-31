<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="ParticipantNurtureSearch.aspx.cs" Inherits="ParticipantNurtureSearch" %>

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
                        Nurturing Requests
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-lg-3 col-md-3">
                            <asp:TextBox runat="server" ID="txtSearch"   MaxLength="500" placeholder="Search"></asp:TextBox>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:Button ID="btnSearch" runat="server" Text="Find" OnClick="btnSearch_Click" />
                        </div>
                        <div class="col-lg-6 col-md-6">
                            &nbsp;
                        </div>

                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="table-responsive">
                        <asp:GridView ID="gv" runat="server" OnRowCommand="gv_RowCommand" OnPageIndexChanging="gv_PageIndexChanging"
                            AllowPaging="true" PageSize="20" AutoGenerateColumns="False" Width="100%" OnRowDataBound="gv_RowDataBound">
                            <PagerSettings Mode="NumericFirstLast" FirstPageText="First" LastPageText="Last" />
                            <Columns>
                                <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50px">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                            CommandArgument='<%#Eval("ParticipantNurtureId")%>'></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="SNo" DataField="SNo"  />
                                <asp:BoundField HeaderText="Participant" DataField="Participant" ItemStyle-Width="140px" />
                                <asp:BoundField HeaderText="Request Details" DataField="ParticipantNurture"  />
                                <asp:BoundField HeaderText="Date" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}"
                                    ItemStyle-Width="120px" />
                                <asp:TemplateField HeaderText="Assign" ItemStyle-Width="200px">
                                    <ItemTemplate>
                                         <asp:HiddenField ID="hdnEmpId" runat="server" Value='<%#Eval("EmployeeId") %>' />
                                        <asp:DropDownList ID="ddlEmployee" runat="server"  ></asp:DropDownList>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Update">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkUpdate" runat="server" Text="Assign" CommandName="cmdUpdate"
                                             CommandArgument='<%#Eval("ParticipantNurtureId") %>' ></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
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
