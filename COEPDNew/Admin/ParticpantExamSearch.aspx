<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="ParticpantExamSearch.aspx.cs" Inherits="ParticpantExamSearch" %>

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
    <!-- Row Start -->
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                     Online Exams
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        
                        <div class="col-lg-1 col-md-1">
                            <label>Batch</label>
                        </div>
                        <div class="col-lg-4 col-md-4">
                            <asp:DropDownList ID="ddlBatch" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlBatch_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                       
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                      <div class="row">
                         <div class="col-lg-1 col-md-1">
                            <label>Location</label>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:DropDownList ID="ddlLocation" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlLocation_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-1 col-md-1">
                            <label>Topic</label>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:DropDownList ID="ddlTopic" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlTopic_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                    </div>
                      <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="col-lg-1 col-md-1">
                            <label>From Date</label>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox runat="server" ID="txtFromDate" placeholder="Search"></asp:TextBox>
                        </div>
                        <div class="col-lg-1 col-md-1">
                            <label>To Date</label>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox runat="server" ID="txtToDate" placeholder="Search"></asp:TextBox>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:TextBox runat="server" ID="txtSearch" placeholder="Search"></asp:TextBox>
                        </div>
                        <div class="col-lg-1 col-md-1">
                            <asp:Button ID="btnSearch" runat="server" Text="Find" OnClick="btnSearch_Click" />
                        </div>
                        <div class="col-lg-2 col-md-2">
                        </div>
                        <div class="col-lg-1 col-md-1">
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
                                <asp:BoundField HeaderText="Batch" DataField="BatchDate" DataFormatString="{0:MMM dd, yyyy}" />
                                <asp:BoundField HeaderText="Participant" DataField="Participant" />
                                <asp:BoundField HeaderText="Location" DataField="Location" />
                                <asp:BoundField HeaderText="Topic" DataField="Topic" />
                                <asp:BoundField HeaderText="Start Time" DataField="StartDate" DataFormatString="{0:dd MMM yyyy hh:mm tt}" />
                                <asp:BoundField HeaderText="Duration" DataField="ExamTime" />
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
                maxDate: 0
            });
        });
    </script>
</asp:Content>
