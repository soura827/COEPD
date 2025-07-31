<%@ Page Title="" Language="C#" MasterPageFile="~/Participant/Participant.master" AutoEventWireup="true" CodeFile="SubmittedResumes.aspx.cs" Inherits="Participant_SubmittedResumes" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Your Resume Sent to Below IT Companies
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
                        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" PageSize="10" HeaderStyle-HorizontalAlign="Center" Width="100%" AllowPaging="true" AllowSorting="true" OnRowCommand="gv_RowCommand" OnPageIndexChanging="gv_PageIndexChanging" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender">
                            <Columns>

                                <asp:BoundField HeaderText="S.No" DataField="SNo" />
                                <asp:BoundField HeaderText="Completed On" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                <asp:BoundField HeaderText="Location-Experience-Domain" DataField="Description" />
                                <asp:BoundField HeaderText="Job Description" DataField="ActivityInteractionInputs" />
                                <asp:BoundField HeaderText="IT Company" DataField="InvolvedVendros" />
                                <%--<asp:BoundField HeaderText="Target Date" DataField="DateToWorkOn" DataFormatString="{0:dd MMM yyyy}" />--%>
                                <asp:BoundField HeaderText="Status" DataField="Status" />
                                <%--<asp:BoundField HeaderText="Involved Employees" DataField="InvolvedEmployees" />
                                <asp:BoundField HeaderText="Involved Participants" DataField="InvolvedParticipants" />
                                <asp:BoundField HeaderText="Inputs By" DataField="Fullname" />
                                <asp:BoundField HeaderText="SStart Time" DataField="SystemStartTime" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                <asp:BoundField HeaderText="SDur.(Min.)" DataField="SystemMinutes" />
                                <asp:BoundField HeaderText="EStart Time" DataField="EnteredStartTime" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                <asp:BoundField HeaderText="EDur.(Min.)" DataField="EnteredMinutes" />--%>
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
</asp:Content>

