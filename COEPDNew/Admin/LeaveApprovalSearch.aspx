<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="LeaveApprovalSearch.aspx.cs" Inherits="LeaveApprovalSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <script type="text/javascript" src="../App_Themes/admin/js/jquery.js"></script>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery-ui-v1.10.3.js"></script>

    <script type="text/javascript">
        $(document).ready(function ($) {

            $("input[id$=txtFromDate]").datepicker({
                value: new Date().toDateString(-15),
                changeMonth: true,
                changeYear: true,
                changeprevious: true,
                dateFormat: 'dd/mm/yy',
                maxDate: "0",
            });

            $("input[id$=txtToDate]").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: 'dd/mm/yy',
                maxDate: "0"
            });
        });
    </script>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Leaves Search
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox runat="server" ID="txtemployeename" Visible="false" MaxLength="500" placeholder="Search By Employee" OnTextChanged="txtemployeename_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                        <div class="col-lg-3 col-lg-3">
                            <asp:DropDownList ID="ddllocation" runat="server" AutoPostBack="true" Visible="false" OnSelectedIndexChanged="ddllocation_SelectedIndexChanged"></asp:DropDownList>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox ID="txtFromDate" runat="server" CssClass="form-control" Placeholder="From Date" OnTextChanged="txtFromDate_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox ID="txtToDate" runat="server" CssClass="form-control" Placeholder="To Date" OnTextChanged="txtToDate_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div>
                        <asp:Label ID="PageNumberHeader" runat="server"></asp:Label>
                    </div>
                    <div class="row">
                        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" OnRowCommand="gv_RowCommand" OnRowDataBound="gv_RowDataBound"
                            Width="100%">
                            <Columns>
                                <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkEdit" runat="server" Text="Approve" CommandName="cmdApprove" SkinID="view"
                                            CommandArgument='<%#Eval("LeaveId")%>'></asp:LinkButton>
                                        <asp:LinkButton ID="LinkButton1" runat="server" Text="Reject" CommandName="cmdReject" SkinID="view"
                                            CommandArgument='<%#Eval("LeaveId")%>'></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                <asp:BoundField HeaderText="Employee Name" DataField="EmployeeName" />
                                <asp:BoundField HeaderText="LeaveType" DataField="LeaveType" />
                                <asp:BoundField HeaderText="From Date" DataField="FromDate" DataFormatString="{0:dd MMM yyyy}" />
                                <%--    <asp:BoundField HeaderText="To Date" DataField="ToDate" DataFormatString="{0:dd MMM yyyy}" />--%>
                                <asp:BoundField HeaderText="Reason" DataField="Notes" />
                                <asp:BoundField HeaderText="Location" DataField="Location" />
                                <asp:BoundField HeaderText="Reporting To" DataField="ReportingManager" />
                                <asp:TemplateField HeaderText="Status">
                                    <ItemTemplate>
                                        <%# Eval("IsApproved").ToString()=="0" ? "Pending": Eval("IsApproved").ToString()=="1"?"Approved":"Rejected" %>
                                    </ItemTemplate>
                                </asp:TemplateField>
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
            </div>
        </div>
    </div>
    <div class="container">
        <div class="modal fade" id="myModal" role="dialog">
            <div class="modal-dialog">

                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h2>Leave Approval is successfull   </h2>
                    </div>
                    <div class="modal-body" id="alert-success">
                        <b>Employee</b>
                        <span>leave Approved</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="container">
        <div class="modal fade" id="myModal1" role="dialog">
            <div class="modal-dialog">

                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h2>Leave Approval is Rejected   </h2>
                    </div>
                    <div class="modal-body" id="alert-success">
                        <b>Employee</b>
                        <span>leave Rejected</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
