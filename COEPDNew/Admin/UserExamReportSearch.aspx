<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="UserExamReportSearch.aspx.cs" Inherits="Admin_UserExamReportSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .ui-widget-content .ui-icon {
            /*background-image: url("../App_Themes/admin//images/ui-icons_222222_256x240.png")*/
            /*background-image:url("../App_Themes/admin/img/ui-icons_444444_256x240.png")*/
            background-image: url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png") !important;
        }

        .ui-widget-header .ui-icon {
            /*background-image: url("../App_Themes/admin/img/ui-icons_444444_256x240.png")*/
            background-image: url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png") !important;
        }
    </style>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery.js"></script>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery-ui-v1.10.3.js"></script>
    <script type="text/javascript">
        $(document).ready(function ($) {
            $("[id*=txtFromDate]").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: 'dd/mm/yy',
                maxDate: "0",
            });
        });
        $(document).ready(function ($) {
            $("[id*=txtToDate]").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: 'dd/mm/yy',
                maxDate: "0",
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
                        User Exam Report
                    </div>
                </div>

                <div class="widget-body">
                    <div class="row">
                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox ID="txtFromDate" runat="server" CssClass="form-control" Placeholder="From Date" OnTextChanged="txtFromDate_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox ID="txtToDate" runat="server" CssClass="form-control" Placeholder="To Date" OnTextChanged="txtFromDate_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                        <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtParticipant" MaxLength="500" placeholder="Participate-Name,Email,Mobile,ID" AutoPostBack="true" OnTextChanged="txtFromDate_TextChanged"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:DropDownList ID="ddlLocation" runat="server" AutoPostBack="true" OnSelectedIndexChanged="txtFromDate_TextChanged">
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:DropDownList ID="ddlTrainer" runat="server" AutoPostBack="true" OnSelectedIndexChanged="txtFromDate_TextChanged">
                            </asp:DropDownList>
                        </div>
                        <br />
                    </div>
                    <div class="row">
                        <br />
                        <div class="col-lg-3 col-md-2">
                            <asp:DropDownList ID="ddlCategory" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:DropDownList ID="ddlTopic" runat="server" AutoPostBack="true" OnSelectedIndexChanged="txtFromDate_TextChanged">
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-6 col-md-6">
                            <div class="col-lg-3 col-md-3">
                                <div class="form-group">
                                    <label class="col-sm-5 control-label">
                                        Active
                                    </label>
                                    <div class="col-sm-7">
                                        <asp:RadioButton runat="server" ID="rbActive" AutoPostBack="true" GroupName="radio" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-3 col-md-3">
                                <div class="form-group">
                                    <label class="col-sm-5 control-label">
                                        In Active
                                    </label>
                                    <div class="col-sm-7">
                                        <asp:RadioButton runat="server" ID="rbDeleted" AutoPostBack="true" GroupName="radio" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="table-responsive">
                        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" OnPageIndexChanging="gv_PageIndexChanging" PageSize="50" AllowPaging="true">
                            <PagerSettings Mode="NumericFirstLast" FirstPageText="First" LastPageText="Last" />
                            <Columns>
                                <asp:BoundField HeaderText="SNo" DataField="Sno" />
                                <asp:BoundField HeaderText="Participant" DataField="Fullname" />
                                <asp:BoundField HeaderText="BatchDate" DataField="BatchDate" DataFormatString="{0:dd MMM yyyy}" />
                                <asp:BoundField HeaderText="Location" DataField="Location" />
                                <asp:BoundField HeaderText="Trainer" DataField="Employee" />
                                <asp:BoundField HeaderText="ExamId" DataField="ExamId" />
                                <asp:BoundField HeaderText="Category" DataField="Category" />
                                <asp:BoundField HeaderText="Topic" DataField="Topic" />
                                <asp:BoundField HeaderText="TotalQuestions" DataField="TotalQuestions" />
                                <asp:BoundField HeaderText="CorrectAnswers" DataField="CorrectAnswers" />
                                <asp:BoundField HeaderText="%" DataField="MarksPersontage" />
                                <asp:BoundField HeaderText="StartDate" DataField="StartDate" DataFormatString="{0:dd MMM yyyy hh:mm tt}" />
                                <asp:BoundField HeaderText="Start Time" DataField="StartTime" DataFormatString="{0:hh:mm tt}" />
                                <asp:TemplateField HeaderText="End Time">
                                    <ItemTemplate>
                                        <%#Eval("EndTime", "{0:hh:mm tt}") %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Duration">
                                    <ItemTemplate>
                                        <%#Eval("Duration", "{0:hh:mm tt}") %>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:BoundField HeaderText="Exam Retake Count" DataField="RetakeExamCount" />
                            </Columns>
                            <PagerStyle HorizontalAlign="Center" VerticalAlign="Bottom" Font-Size="Large" />
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
   
</asp:Content>

