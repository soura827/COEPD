<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="RepLeads.aspx.cs" Inherits="Admin_RepLeads" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
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
      
      <style type="text/css">
        table caption {
            background-color: #5D7B9D;
            color: White;
            font-size: 16pt;
            text-align: center;
        }
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
    <!-- Row Start -->
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Leads Reports
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-lg-1 col-md-1">
                            <h4>Course</h4>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:DropDownList ID="ddlCourse" runat="server"  OnSelectedIndexChanged="ddlCourse_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                         <div class="col-lg-1 col-md-1">
                            <h4>BatchType</h4>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:DropDownList ID="ddlBatchType" runat="server" OnSelectedIndexChanged="ddlBatchType_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-1 col-md-1">
                            <h4>Location</h4>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:DropDownList ID="ddlLocation" runat="server"  OnSelectedIndexChanged="ddlLocation_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                        </div>
                    <div class="row">
                         &nbsp;
                    </div>
                    <div class="row">
                         <div class="col-lg-1 col-md-1">
                            <h4>Employee</h4>
                        </div>
                         <div class="col-lg-3 col-md-3">
                            <asp:DropDownList ID="ddlEmployee" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlEmployee_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                         <div class="col-lg-1 col-md-1">
                        <h4> FromDate</h4>
                        </div>
                         <div class="col-lg-2 col-md-2">
                                <asp:TextBox ID="txtFromDate" runat="server" Placeholder="From Date" ></asp:TextBox>
                            </div>
                        <div class="col-lg-1 col-md-1">
                       <h4> ToDate</h4>
                        </div>
                            <div class="col-lg-2 col-md-2">
                                <asp:TextBox ID="txtToDate" runat="server" Placeholder="To Date" required=""></asp:TextBox>
                            </div>
                        <div class="col-lg-2 col-md-2">
                            
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:Button ID="btnSearch" runat="server" Text="Find" OnClick="btnSearch_Click" />
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="table-responsive">
                        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" 
                            Width="100%" Caption>
                            <Columns>
                                <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                <asp:BoundField HeaderText="Course" DataField="Course" />
                                <asp:BoundField HeaderText="BatchType" DataField="BatchType" />
                                <asp:BoundField HeaderText="Location" DataField="Location" />
                                <asp:BoundField HeaderText="Aspirant Name" DataField="Lead" />
                                <asp:BoundField HeaderText="Mobile" DataField="PrimaryMobile" />
                                <asp:BoundField HeaderText="Email" DataField="PrimaryEmail" />
                                 <asp:BoundField HeaderText="Status" DataField="LeadStatus" />
                                 <asp:BoundField HeaderText="Employee" DataField="Username" />
                                <asp:BoundField HeaderText="Date" DataField="LeadDate" DataFormatString="{0:dd MMM yyyy}" />
                               
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

