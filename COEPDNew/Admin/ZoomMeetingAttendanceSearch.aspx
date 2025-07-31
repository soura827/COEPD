<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ZoomMeetingAttendanceSearch.aspx.cs" Inherits="Admin_ZoomMeetingAttendanceSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Zoom Meeting
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtUserName" MaxLength="500" placeholder="employee" AutoPostBack="true" OnTextChanged="txtUserName_TextChanged"></asp:TextBox>
                        </div>
                    </div>
                </div>

                <div>
                    <asp:Label ID="PageNumberHeader" runat="server"></asp:Label>

                </div>
                <div class="row">
                    <div class="table-responsive">
                        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" Width="100%" PageSize="500" HeaderStyle-HorizontalAlign="Center" AllowPaging="true" AllowSorting="true" OnRowCommand="gv_RowCommand" OnPageIndexChanging="gv_PageIndexChanging" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender">
                            <Columns>
                                <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                <asp:BoundField HeaderText="Username" DataField="Username" />
                                <asp:BoundField HeaderText="ZoomMeetingId" DataField="ZoomMeetingId" />
                                <%--                                      <asp:BoundField HeaderText="IsZoomMeetingAttended" DataField="IsZoomMeetingAttended" />--%>
                                <asp:BoundField HeaderText="ZoomMeetingAttendedOn" DataField="ZoomMeetingAttendedOn" DataFormatString="{0: dd MMM yyyy}" />
                                <asp:BoundField HeaderText="ZoomMeetingEndedOn" DataField="ZoomMeetingEndedOn" DataFormatString="{0: hh:mm tt}" />
                                <%-- <asp:BoundField HeaderText="IsZoomMeetingEnded" DataField="IsZoomMeetingEnded" />--%>

                                <asp:BoundField HeaderText="CreatedBy" DataField="FeedBack" />
                                <asp:BoundField HeaderText="FeedbackAddedOn" DataField="FeedbackAddedOn" DataFormatString="{0: hh:mm tt}" />
                                <%-- <asp:BoundField HeaderText="IsFeedbackAdded" DataField="IsFeedbackAdded" />--%>
                            </Columns>
                            <EmptyDataTemplate>
                                <center>
                                    No Records Found
                                </center>
                            </EmptyDataTemplate>
                        </asp:GridView>
                        <div>
                            <asp:Label ID="PageNumberFooter" runat="server"></asp:Label>
                        </div>


                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-offset-2 col-sm-6">
                        <asp:Button ID="btnCancel" runat="server" Text="Back to list" SkinID="delete" CssClass="btn btn-warning btn-md" UseSubmitBehavior="false"
                            OnClick="btnCancel_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

