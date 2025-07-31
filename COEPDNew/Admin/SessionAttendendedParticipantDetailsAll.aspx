<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="SessionAttendendedParticipantDetailsAll.aspx.cs" Inherits="Admin_SessionAttendendedParticipantDetailsAll" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type='text/javascript' src='https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js?ver=1.4.2'></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.12.0/jquery-ui.min.js"
        type="text/javascript"></script>
    <script type="text/javascript">

        $(document).ready(function ($) {
            $("input[id$=txtFromDate]").datepicker({
                dateFormat: 'dd/mm/yy',
                changeMonth: true,
                changeYear: true,
                changeprevious: true,
                maxDate: "0",
            });

            $("input[id$=txtToDate]").datepicker({
                dateFormat: 'dd/mm/yy',
                changeMonth: true,
                changeYear: true,
                maxDate: 0
            });
        });
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">



    <!-- Row Start -->
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Session Attend Details
                    </div>
                </div>

                <div class="widget-body">
                    <div class="row">
                        <div class="form-group">

                            <div class="col-sm-2">
                                <asp:TextBox ID="txtSessionName" runat="server" Placeholder="Search by SessionName" OnTextChanged="txtSessionName_TextChanged" AutoPostBack="true"></asp:TextBox>
                            </div>

                            <div class="col-sm-3">
                                <asp:TextBox ID="txtKeywords" runat="server" Placeholder="Search by Participants,Mobile,Email" OnTextChanged="txtKeywords_TextChanged" AutoPostBack="true"></asp:TextBox>
                            </div>





                            <div class="col-lg-2 col-md-2">
                                <asp:TextBox ID="txtFromDate" runat="server" Placeholder="From Date" required="" OnTextChanged="txtFromDate_TextChanged" AutoPostBack="true"></asp:TextBox>
                            </div>

                            <div class="col-lg-2 col-md-2">
                                <asp:TextBox ID="txtToDate" runat="server" Placeholder="To Date" required="" OnTextChanged="txtToDate_TextChanged" AutoPostBack="true"></asp:TextBox>
                            </div>

                            <div class="col-lg-1 col-md-1">
                                <asp:Button ID="btnDownload" runat="server" Text="Download" OnClick="btnDownload_Click" UseSubmitBehavior="false" />
                            </div>

                            <div class="col-lg-1 col-md-1">
                                <asp:Button ID="btnCancel" runat="server" Text="Back to list" UseSubmitBehavior="false" OnClick="btnCancel_Click" />
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>

                    <div class="row">
                        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" PageSize="100" HeaderStyle-HorizontalAlign="Center" Width="100%" AllowPaging="true" AllowSorting="true" OnPageIndexChanging="gv_PageIndexChanging" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!">
                            <Columns>
                                <asp:BoundField HeaderText="S.No" DataField="SNo" />
                                <asp:BoundField HeaderText="Session Name" DataField="TotalSession" />
                                <asp:BoundField HeaderText="Participant" DataField="Participant" />
                                <asp:BoundField HeaderText="Mobile" DataField="Mobile" />
                                <asp:BoundField HeaderText="Email" DataField="Email" />
                                <asp:BoundField HeaderText="Session Date" DataField="Date" DataFormatString="{0: dd MMM yyyy }" />

                            </Columns>
                        </asp:GridView>

                    </div>
                </div>
            </div>
        </div>
    </div>




</asp:Content>

