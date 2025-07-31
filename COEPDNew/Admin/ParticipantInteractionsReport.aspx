<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ParticipantInteractionsReport.aspx.cs" Inherits="Admin_ParticipantInteractionsReport" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .ui-widget-content .ui-icon {
    /*background-image: url("../App_Themes/admin//images/ui-icons_222222_256x240.png")*/ 
    /*background-image:url("../App_Themes/admin/img/ui-icons_444444_256x240.png")*/
     background-image:url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png")      
            !important;}
    .ui-widget-header .ui-icon {
    /*background-image: url("../App_Themes/admin/img/ui-icons_444444_256x240.png")*/ 
    background-image:url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png")  
        !important;}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Student Interactions
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="form-group">
                            <div class="col-lg-3 col-md-3">
                                <asp:TextBox runat="server" ID="txtActivityCategory" MaxLength="500" placeholder="Search By Activity Category" OnTextChanged="txtActivityCategory_TextChanged" AutoPostBack="true"></asp:TextBox>
                            </div>
                            <div class="col-lg-3 col-md-3">
                                <asp:TextBox runat="server" ID="txtActivitySubCategory" MaxLength="500" placeholder="Search By Activity Subcategory" OnTextChanged="txtActivitySubCategory_TextChanged" AutoPostBack="true"></asp:TextBox>
                            </div>
                            <div class="col-lg-3 col-md-3">
                                <asp:TextBox runat="server" ID="txtActivity" MaxLength="500" placeholder="Search By Activity" OnTextChanged="txtActivity_TextChanged" AutoPostBack="true"></asp:TextBox>
                            </div>
                            <div class="col-lg-3 col-md-3">
                                <asp:TextBox runat="server" ID="txtInputsEnteredBy" MaxLength="500" placeholder="Search By Inputs Entered By" OnTextChanged="txtInputsEnteredBy_TextChanged" AutoPostBack="true"></asp:TextBox>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="form-group">
                            <div class="col-lg-4 col-md-4">
                                <asp:TextBox runat="server" ID="txtInvolvedEmployees" placeholder="Search By Involved Employees" OnTextChanged="txtInvolvedEmployees_TextChanged" AutoPostBack="true"></asp:TextBox>
                            </div>
                            <div class="col-lg-4 col-md-4">
                                <asp:TextBox runat="server" ID="txtInvolvedParticipants" placeholder="Search By Involved Participants" OnTextChanged="txtInvolvedParticipants_TextChanged" AutoPostBack="true"></asp:TextBox>
                            </div>
                            <div class="col-lg-4 col-md-4">
                                <asp:TextBox runat="server" ID="txtBranch" MaxLength="100" placeholder="Search By Branch Name" OnTextChanged="txtBranch_TextChanged" AutoPostBack="true"></asp:TextBox>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="form-group">

                            <div class="col-lg-1 col-md-1">
                                <label>From Date:</label>
                            </div>
                            <div class="col-lg-3 col-md-3">
                                <asp:TextBox ID="txtFromDate" runat="server" CssClass="form-control" Placeholder="From Date"></asp:TextBox>
                            </div>
                            <div class="col-lg-1 col-md-1">
                                <label>To Date: </label>
                            </div>
                            <div class="col-lg-3 col-md-3">
                                <asp:TextBox ID="txtToDate" runat="server" CssClass="form-control" Placeholder="To Date" OnTextChanged="txtToDate_TextChanged" AutoPostBack="true"></asp:TextBox>
                            </div>
                            <div class="col-lg-4 col-md-4">
                            </div>
                        </div>
                    </div>
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
                                <asp:BoundField HeaderText="Created On" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                <asp:BoundField HeaderText="Task Inputs" DataField="ActivityInteractionInputs" />
                                <asp:BoundField HeaderText="Target Date" DataField="DateToWorkOn" DataFormatString="{0:dd MMM yyyy}" />
                                <asp:BoundField HeaderText="Status" DataField="Status" />
                                <asp:BoundField HeaderText="Involved Employees" DataField="InvolvedEmployees" />
                                <asp:BoundField HeaderText="Involved Participants" DataField="InvolvedParticipants" />
                                <asp:BoundField HeaderText="Inputs By" DataField="Fullname" />
                                <asp:BoundField HeaderText="SStart Time" DataField="SystemStartTime" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                <asp:BoundField HeaderText="SDur.(Min.)" DataField="SystemMinutes" />
                                <asp:BoundField HeaderText="EStart Time" DataField="EnteredStartTime" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                <asp:BoundField HeaderText="EDur.(Min.)" DataField="EnteredMinutes" />
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
    <script type="text/javascript" src="../App_Themes/admin/js/jquery.js"></script>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery-ui-v1.10.3.js"></script>
    <script type="text/javascript">
        $(document).ready(function ($) {

            $("input[id$=txtFromDate]").datepicker({
                value: new Date().toDateString(),
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
                maxDate: 1
            });
        });
    </script>
</asp:Content>
