<%@ Page Title="" Language="C#" MasterPageFile="~/Participant/Participant.master" AutoEventWireup="true"
    CodeFile="TrainingCalendar.aspx.cs" Inherits="TrainingCalendar" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Trainings Calendar
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="table-responsive">
                        <asp:GridView ID="gv" runat="server" OnPageIndexChanging="gv_PageIndexChanging" AllowPaging="true"
                            CellPadding="10" CellSpacing="10" PageSize="20" AutoGenerateColumns="False" Width="100%"
                            Enabled="false">
                            <PagerSettings Mode="NumericFirstLast" FirstPageText="First" LastPageText="Last" />
                            <Columns>
                                <asp:BoundField HeaderText="Start Date" DataField="StartDate" DataFormatString="{0:dd-MMM-yyyy}" />
                                <asp:BoundField HeaderText="Course" DataField="Course" />
                                <asp:BoundField HeaderText="Type" DataField="BatchType" />
                                <asp:BoundField HeaderText="Location" DataField="Location" />
                                <%--<asp:TemplateField HeaderText="Register Now" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px"
                                HeaderStyle-HorizontalAlign="center">
                                <ItemTemplate>
                                    <a href="http://www.coepd.net/">
                                        <button type="button" class="btn btn-danger">
                                            Register Now</button></a>
                                </ItemTemplate>
                            </asp:TemplateField>--%>
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
</asp:Content>