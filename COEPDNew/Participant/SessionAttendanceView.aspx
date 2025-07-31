<%@ Page Title="" Language="C#" MasterPageFile="~/Participant/Participant.master" AutoEventWireup="true" CodeFile="SessionAttendanceView.aspx.cs" Inherits="Participant_SessionAttendanceView" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<script runat="server">

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
</script>

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
                                Session Attendance view 
                            </div>
                        </div>

                        <div class="widget-body">
                           

                         <asp:Button ID="btnCancel" runat="server" Text="Back to Page" UseSubmitBehavior="false" OnClick="btnCancel_Click1" />


                            <div class="row">
                                &nbsp;
                            </div>
                            <div>
                                <asp:Label ID="PageNumberHeader" runat="server"></asp:Label>
                            </div>
                            <div class="row">
                                <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" PageSize="100" HeaderStyle-HorizontalAlign="Center" Width="100%" AllowPaging="true" AllowSorting="true" OnRowCommand="gv_RowCommand" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" >
                                    <Columns>
                                        <asp:BoundField HeaderText="S.No" DataField="SNo" />
                                        <asp:BoundField HeaderText="ZoomMeetingId" DataField="ZoomMeetingId" />
                                        <asp:BoundField HeaderText="Password" DataField="Password" />
                                        <asp:BoundField HeaderText="StartTime" DataField="StartTime" />
                                        <asp:BoundField HeaderText="Date" DataField="CreatedOn" />
                                    </Columns>
                                </asp:GridView>
                           </div>                     
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>







</asp:Content>

