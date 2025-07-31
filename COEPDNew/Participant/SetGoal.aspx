<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SetGoal.aspx.cs" Inherits="Participant_SetGoal" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "https://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link type="text/css" href="../css/adminnav.css" rel="stylesheet" />
    <title>.: COEPD Participant Login :.</title>
    <script type="text/javascript" language="JavaScript">
        this.history.forward(-1);
    </script>
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="../css/Admin/js/Sweetalert.js" type="text/javascript"></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />
    <style type="text/css">
        .sup {
            color: red;
            font-size: large;
            font-weight: bold;
        }
    </style>

    <style type="text/css">
        .ui-widget-content .ui-icon {
            /background-image: url("../App_Themes/admin//images/ui-icons_222222_256x240.png")/ /background-image:url("../App_Themes/admin/img/ui-icons_444444_256x240.png")/ background-image:url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png") !important;
        }

        .ui-widget-header .ui-icon {
            /background-image: url("../App_Themes/admin/img/ui-icons_444444_256x240.png")/ background-image:url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png") !important;
        }
    </style>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery.js"></script>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery-ui-v1.10.3.js"></script>
    <script type="text/javascript">
        $(document).ready(function ($) {
            $("[id*=txtTargetDate]").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: 'dd/mm/yy',
                minDate: "105",
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="dashboard-container">
            <div class="container">

                <div class="sub-nav">
                    <ul>
                        <li><a href="#" class="heading">
                            <asp:Label ID="lblUsername" runat="server"></asp:Label></a></li>
                        <li><a href="#" class="heading">
                            <%-- <asp:Label ID="lblSubscriptionExpiredOn" runat="server" ForeColor="#ff9900" Font-Bold="true"></asp:Label></a></li>--%>
                            <%--<li class=""><a href="library.aspx">Library</a></li>--%>
                    </ul>
                    <div class="custom-search">
                        <%--<div class="heading">--%>
                        <ul>
                            <%--<li class=""><a href="library.aspx">Library</a> <b>|</b></li>--%>
                            <%-- <li class=""><a href="terms_conditions.aspx">Terms and Conditions</a><b>|</b> </li>
                            <li class=""><a href="ChangePwd.aspx">Change Password</a> </li>
                            <li class=""><a href="logout.aspx">Signout</a> </li>--%>
                        </ul>
                    </div>
                </div>
                <div class="dashboard-wrapper">
                    <!-- Row Start -->
                    <!-- Row End -->
                    <!-- Row Start -->
                    <div class="row">
                        <div class="col-lg-offset-3 col-md-offset-3 col-lg-6 col-md-6">

                            <asp:ScriptManager ID="ScriptManager2" runat="server"></asp:ScriptManager>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <!-- Row Start -->
                                    <div class="Row">
                                        <div class="col-lg-12 col-md-12">
                                            <div class="widget">
                                                <div class="widget-header">
                                                    <div class="title">
                                                        <asp:Label runat="server" ID="lblTitle"></asp:Label>
                                                    </div>

                                                </div>
                                                <div class="widget-body">
                                                    <div class="form-horizontal no-margin">
                                                        <%--<div class="form-group">
                                                            <label class="col-sm-5 control-label">
                                                                Purpose of attending the Training?<sup class="sup">*</sup>
                                                            </label>
                                                            <div class="col-sm-7">
                                                                <asp:TextBox ID="txtPurposeOfAttending" runat="server" Placeholder="to get a BA Job" Required=""></asp:TextBox>
                                                            </div>
                                                        </div>--%>
                                                        <div class="form-group">
                                                            <label class="col-sm-5 control-label">
                                                                Purpose of attending the Training?<sup class="sup">*</sup>
                                                            </label>
                                                            <div class="col-sm-7">
                                                                <asp:CheckBoxList ID="chkModuleList" runat="server">
                                                                <asp:ListItem Value="to get a BA Job">To get a BA Job</asp:ListItem>
                                                                <asp:ListItem Value="to enhance BA Skills">To enhance BA Skills</asp:ListItem>
                                                            </asp:CheckBoxList>
                                                            </div>
                                                        </div>
                                                        <div class="form=group col-sm-offset-5">
                                                            <asp:CustomValidator runat="server" ID="cvmodulelist"
                                                            ClientValidationFunction="ValidateModuleList"
                                                            ErrorMessage="Please Select Atleast one Goal" Font-Bold="true" ForeColor="Red"></asp:CustomValidator>
                                                        </div>
                                                        <br />
                                                        <div class="form-group">
                                                            <label class="col-sm-5 control-label">
                                                                By when you want to achieve it?<sup class="sup">*</sup>
                                                            </label>

                                                            <div class="col-sm-7">
                                                                <asp:TextBox ID="txtTargetDate" runat="server" Required=""></asp:TextBox>
                                                            </div>
                                                        </div>
                                                        <div class="form-group">
                                                            <label class="col-sm-5 control-label">
                                                                Daily Time Investment? <sup class="sup">*</sup>
                                                            </label>

                                                            <div class="col-sm-7">
                                                                <asp:DropDownList ID="ddlDailyTimeSpend" runat="server" required="">
                                                                    <asp:ListItem Text="--Select Daily Time Investment--" Value=""></asp:ListItem>
                                                                    <%--<asp:ListItem Text="1 Hr" Value="1"></asp:ListItem>--%>
                                                                    <asp:ListItem Text="2 Hrs" Value="2"></asp:ListItem>
                                                                    <asp:ListItem Text="3 Hrs" Value="3"></asp:ListItem>
                                                                    <asp:ListItem Text="4 Hrs" Value="4"></asp:ListItem>
                                                                    <asp:ListItem Text="5 Hrs" Value="5"></asp:ListItem>
                                                                    <asp:ListItem Text="6 Hrs" Value="6"></asp:ListItem>
                                                                    <asp:ListItem Text="7 Hrs" Value="7"></asp:ListItem>
                                                                    <asp:ListItem Text="8 Hrs" Value="8"></asp:ListItem>
                                                                    <asp:ListItem Text="9 Hrs" Value="9"></asp:ListItem>
                                                                    <asp:ListItem Text="10 Hrs" Value="10"></asp:ListItem>
                                                                    <asp:ListItem Text="11 Hrs" Value="11"></asp:ListItem>
                                                                    <asp:ListItem Text="12 Hrs" Value="12"></asp:ListItem>
                                                                </asp:DropDownList>
                                                            </div>
                                                        </div>
                                                        <div class="form-group">
                                                            <div class="col-sm-offset-5 col-sm-7">
                                                                <asp:Button runat="server" SkinID="btnGreen" ID="btnSubmit" Text="Set Goal" OnClick="btnSubmit_Click" />
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            <!-- Row End -->

                        </div>
                    </div>
                    <!-- Row End -->
                </div>
                <footer>
                    <p>&nbsp;</p>
                </footer>
            </div>
        </div>

        <script type="text/javascript" src="../js/jquery.js"></script>
        <script type="text/javascript" src="../js/bootstrap.min.js"></script>
        <script type="text/javascript" src="../js/jquery.scrollUp.js"></script>
        <!-- Custom JS -->
        <script type="text/javascript" src="../js/menu.js"></script>
        <script type="text/javascript">
            function ValidateModuleList(source, args) {
                var chkListModules = document.getElementById('<%= chkModuleList.ClientID %>');
                var chkListinputs = chkListModules.getElementsByTagName("input");
                for (var i = 0; i < chkListinputs.length; i++) {
                    if (chkListinputs[i].checked) {
                        args.IsValid = true;
                        return;
                    }
                }
                args.IsValid = false;
            }
        </script>
    </form>
</body>
</html>
