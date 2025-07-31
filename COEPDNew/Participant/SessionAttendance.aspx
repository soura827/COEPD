<%@ Page Title="" Language="C#" MasterPageFile="~/Participant/Participant.master" AutoEventWireup="true" CodeFile="SessionAttendance.aspx.cs" Inherits="Participant_SessionAttendance" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">



    <!-- Row Start -->
    <asp:ScriptManager ID="scriptmanager" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel" runat="server">
        <ContentTemplate>
            <div class="row">
                <div class="col-lg-12 col-md-12">
                    <div class="widget">
                        <div class="widget-header">
                            <div class="title">
                                Session Attendance
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
                                <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" PageSize="100" HeaderStyle-HorizontalAlign="Center" Width="100%" AllowPaging="true" AllowSorting="true" OnRowCommand="gv_RowCommand" OnPageIndexChanging="gv_PageIndexChanging" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnRowDataBound="gv_RowDataBound">
                                    <Columns>
                                      <%--  <asp:BoundField HeaderText="S.No" DataField="SNo" />--%>
                                        <asp:BoundField HeaderText="S.No" DataField="SessionTypeId"  />
                                        <asp:BoundField HeaderText="Session Name" DataField="SessionName" />

                                        <asp:TemplateField HeaderText=" Conducted Session Count" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                            <ItemTemplate>
                                                <asp:Label ID="lblCount" runat="server"></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>


                                        <asp:BoundField HeaderText="Attendance" DataField="Attendance" />










                                        <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                            <ItemTemplate>
                                                <asp:Button ID="btnView" runat="server" Text="View" CommandName="ViewSession" CommandArgument='<%# Eval("SessionTypeId") %>' OnClick="btnView_Click" />

                                            </ItemTemplate>
                                        </asp:TemplateField>

                                    </Columns>
                                </asp:GridView>
                                <div>
                                    <asp:Label ID="PageNumberFooter" runat="server"></asp:Label>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>






</asp:Content>

