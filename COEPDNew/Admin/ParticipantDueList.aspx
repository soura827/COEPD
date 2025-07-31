<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true"
    CodeFile="ParticipantDueList.aspx.cs" Inherits="ParticipantDueList" %>

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
                        Participant Due List
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-md-1">
                            <h5>Batch</h5>
                        </div>
                        <div class="col-md-4">
                            <asp:DropDownList ID="ddlBatch" runat="server" AutoPostBack="true"
                                OnSelectedIndexChanged="ddlBatch_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                        <div class="col-md-6">
                            &nbsp;
                        </div>
                        <div class="col-md-1">
                            <asp:Button ID="btnDownload" runat="server" Text="Download" OnClick="btnDownload_Click" />
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="table-responsive">
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" Width="100%">
                                <Columns>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Participant" DataField="Participant" />
                                    <asp:BoundField HeaderText="Mobile" DataField="Mobile" />
                                    <asp:BoundField HeaderText="Email" DataField="Email" />
                                    <asp:BoundField HeaderText="Batch Date" DataField="StartDate" DataFormatString="{0: dd MMM yyyy}" />
                                    <asp:BoundField HeaderText="BatchType" DataField="BatchType" />
                                    <asp:BoundField HeaderText="Location" DataField="Location" />
                                    <asp:BoundField HeaderText="Trainer" DataField="Employee" />
                                    <asp:BoundField HeaderText="Fee" DataField="Fee" />
                                    <asp:BoundField HeaderText="Received Amount" DataField="ReceivedAmount" />
                                    <asp:BoundField HeaderText="Due" DataField="Due" />
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

