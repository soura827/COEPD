<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true"
    CodeFile="post-job-requirement.aspx.cs" Inherits="post_job_requirement" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    Business Analyst post job Requirement | BA post job requirement
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="canonical" href="https://www.coepd.com/post-job-requirement.html" />
    <meta name="description" content="Post your job Requrirement on business analyst jobs" />
    <meta name="keywords" content="post requirements, latest openings, job postings, post your requirements, post business analyst requirements" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpContent" runat="Server">
    <script src="js/bootstrap.js" type="text/javascript"></script>
    <script src="js/style.js" type="text/javascript"></script>

    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js"></script>
    <script src="https://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.9/jquery-ui.js" type="text/javascript"></script>
    <link href="https://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.9/themes/start/jquery-ui.css"
        rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        function ShowPopup(message) {
            $(function () {
                $("#dialog").html(message);
                $("#dialog").dialog({
                    title: "Post Job Requirement",
                    buttons: {
                        Close: function () {
                            $(this).dialog('close');
                        }
                    },
                    modal: true
                });
            });
        };
    </script>
       <script type="text/javascript">
        function warn()
        {
            alert("Date should be greater than or equal to today.");
        }

    </script>
    <div id="dialog" style="display: none">
    </div>
    <div id="inner-cont">
        <div class="container">
            <div class="col-md-9">
                <div class="login-box">
                    <div class="box-title">
                        <span class="login-title">We are a BA Community of 10,000+ Members, post your BA Job to reach the most relevant Resources</span>
                    </div>
                    <div class="box-title">
                        <span class="login-title">Business Analyst post job Requirement | BA post job requirement</span>
                    </div>
                    <div class="form-horizontal">
                        <div class="form-group">
                            <label for="lblCompany" class="col-sm-3 control-label">
                                Company Name</label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtCompanyName" runat="server" CssClass="form-control" required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="lblPerson" class="col-sm-3 control-label">
                                Contact Person Name</label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtPerson" runat="server" CssClass="form-control" required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="lblEmail" class="col-sm-3 control-label">
                                Contact E-mail Address</label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" type="email" required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="lblMobile" class="col-sm-3 control-label">
                                Mobile</label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtMobile" runat="server" CssClass="form-control" type="number" MaxLength="10"
                                    required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="lblSkills" class="col-sm-3 control-label">
                                Key Skills</label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtSkills" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="lblContact" class="col-sm-3 control-label">
                                Prefered Time To Contact</label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtContact" runat="server" CssClass="form-control" required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="lblRole" class="col-sm-3 control-label">
                                Job Role</label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtRole" runat="server" CssClass="form-control" required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="lblLocation" class="col-sm-3 control-label">
                                Job Location</label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtLocation" runat="server" CssClass="form-control" required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="lblExp" class="col-sm-3 control-label">
                                Years Of Experience</label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtExp" runat="server" CssClass="form-control" type="number" step="any"
                                    required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                             <label for="lblExp" class="col-sm-3 control-label">
                                Expiry Date</label>
                            <div class="col-sm-4">
                                <asp:TextBox ID="txtExpiry" runat="server" CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please select the date" ControlToValidate="txtExpiry" ForeColor="Red"></asp:RequiredFieldValidator>
                                 
                            </div>
                         <%--   <div class="col-sm-2">
                                <asp:ImageButton ID="txtimg" runat="server" CssClass="form-control" ImageUrl="~/img/images.jpg" OnClick="txtimg_Click" AutoPostBack="true" Height="35px" Width="60px"/>
                                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" AutoPostBack="false" Font-Size="8pt" ForeColor="Black" Height="180px" OnSelectionChanged="Calendar1_SelectionChanged" Width="200px">
                                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                                    <NextPrevStyle VerticalAlign="Bottom" />
                                    <OtherMonthDayStyle ForeColor="#808080" />
                                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                                    <SelectorStyle BackColor="#CCCCCC" />
                                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                                    <WeekendDayStyle BackColor="#FFFFCC" />
                                </asp:Calendar>
                            </div>--%>
                        </div>
                        <div class="form-group">
                            <label for="lblExp" class="col-sm-3 control-label">
                                Job Description</label>
                            <div class="col-sm-9">
                                <CKEditor:CKEditorControl ID="txtDescription" runat="server" Height="300" CssClass="form-control"
                                    Toolbar="Basic">
                                </CKEditor:CKEditorControl>

                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-offset-2">
                                <div class="col-sm-2">
                                </div>
                                <asp:Button ID="btnLogin" runat="server" Text="Post Requirement" CssClass="btn btn-info"
                                    OnClick="btnLogin_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-3 our-locations">
                <uc2:Locations ID="Locations" runat="server" />
            </div>
        </div>
    </div>
     <script type="text/javascript" src="../App_Themes/admin/js/jquery.js"></script>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery-ui-v1.10.3.js"></script>
    <script type="text/javascript">

        $(document).ready(function ($) {

            $("[id*=txtExpiry]").datepicker({
                dateFormat: 'dd/mm/yy',
                minDate: "0",
            });

          
        });
    </script>
    <!--  Inner page Content End -->
    </div>
</asp:Content>
