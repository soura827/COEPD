<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CoepdValue_Pune.aspx.cs" Inherits="CoepdValue_Pune" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>COEPD Value </title>
    <link rel="canonical" href="https://www.coepd.com/coepdvalue_Pune.html" />
    <link rel="icon" href="img/Fevicons/favicon.ico" />
    <link href="css/landingstyle.css" rel="stylesheet" />
    <link rel="stylesheet" href="css/bootstrap.css" />
    <link rel="stylesheet" href="css/font-awesome.min.css" />
    <script src="js/jquery.js" type=""></script>
    <script src="js/bootstrap.min.js" type=""></script>

    <style type="text/css">
        #ErrorMessage {
            color: white;
            font-weight: bold;
            font-size: 18px;
        }

        #FormMessage {
            color: white;
            font-weight: bold;
            font-size: 18px;
        }

            #FormMessage a {
                color: white;
                font-weight: bold;
                font-size: 18px;
            }
    </style>


</head>
<body>
    <div class="row">
        <div class="container-fluid background-right">
            <div class="row landing_page_body">
                <div class="container-fluid">
                    <div class="row col-xs-12 col-sm-12 col-md-7 col-lg-7 background">
                        <div class="logo-section">
                            <a href="https://www.coepd.com/">
                                <asp:Image ID="Image1" runat="server" ImageUrl="img/logo.jpeg" title="COEPD" />
                            </a>

                        </div>
                        <div class="left-form-row">
                            <div class="left-title-page">
                            <h1>
                                    <asp:Label ID="lblTitle" Text="Business Analyst Training Pune" runat="server"> </asp:Label></h1>
                            </div>
                            <div class="item-section1">
                                <p class="left-top-body"></p>
                                <p class="right-top-body">
                                    <%--<asp:Label ID="lblUSP1" Text="Label 1" runat="server"> </asp:Label>--%>
                                </p>
                            </div>
                            <div class="item-section2">
                                <p class="left-top-body"></p>
                                <p class="right-top-body">
                                    <%--<asp:Label ID="lblUSP2" Text="Label 2" runat="server"> </asp:Label>--%>
                                </p>
                            </div>
                            <div class="item-section3">
                                <p class="left-top-body"></p>
                                <p class="right-top-body">
                                    <%--<asp:Label ID="lblUSP3" Text="Label 3" runat="server"> </asp:Label>--%>
                                </p>
                            </div>
                            <div class="item-section4">
                                <p class="left-top-body"></p>
                                <p class="right-top-body">
                                    <%--<asp:Label ID="lblUSP4" Text="Label 4" runat="server"> </asp:Label>--%>
                                </p>
                            </div>
                            <div class="item-section5">
                                <p class="left-top-body"></p>
                                <p class="right-top-body">
                                    <%--<asp:Label ID="lblUSP5" Text="Label 5" runat="server"> </asp:Label>--%>
                                </p>
                            </div>
                            <div class="item-section6">
                                <p class="left-top-body"></p>
                                <p class="right-top-body">
                                    <%--<asp:Label ID="lblUSP6" Text="Label 6" runat="server"> </asp:Label>--%>
                                </p>
                            </div>
                            <div class="item-section7">
                                <p class="left-top-body"></p>
                                <p class="right-top-body">
                                    <%--<asp:Label ID="lblUSP7" Text="Label 7" runat="server"> </asp:Label>--%>
                                </p>
                            </div>
                            <div class="item-section8">
                                <p class="left-top-body"></p>
                                <p class="right-top-body">
                                    <%--<asp:Label ID="lblUSP8" Text="Label 8" runat="server"> </asp:Label>--%>
                                </p>
                            </div>
                            <div class="item-section9">
                                <p class="left-top-body"></p>
                                <p class="right-top-body">
                                    <%--<asp:Label ID="lblUSP9" Text="Label 9" runat="server"> </asp:Label>--%>
                                </p>
                            </div>
                            <div class="item-section10">
                                <p class="left-top-body"></p>
                                <p class="right-top-body">
                                    <%--<asp:Label ID="lblUSP10" Text="Label 10" runat="server"> </asp:Label>--%>
                                </p>
                            </div>
                        </div>
                        <div style="clear: both;"></div>
                    </div>
                    <div class="row col-xs-12 col-sm-12 col-md-5 col-lg-5 ">
                        <div class="row">

                            <div class="form-bg right-form-row">
                                <div class="right-title-page">
                                    <h1 style="/*padding-left: 1.2em*/; padding-bottom: 0.5em; text-align: center">Register</h1>
                                </div>
                                <form class="form-horizontal" runat="server">
                                    <div class="form-group">
                                        <div class="col-xs-offset-2 col-xs-8">

                                            <asp:TextBox ID="txtName" CssClass="form-control" runat="server" placeholder="Name" MinLength="3" MaxLength="30" Required=""></asp:TextBox>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidatorName" runat="server" ControlToValidate="txtName"
                                                ValidationExpression="[a-zA-Z ]*$" ErrorMessage="Valid characters: Alphabets and space." />
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="col-xs-offset-2 col-xs-8">
                                            <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server" placeholder="Email" Required="" AutoPostBack="true" OnTextChanged="txtEmail_TextChanged"></asp:TextBox>
                                            <asp:RegularExpressionValidator runat="server" ID="RegularExpressionValidatorEmail" ErrorMessage="Invalid Email" ControlToValidate="txtEmail" ForeColor="Red"
                                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                                            </asp:RegularExpressionValidator>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="col-xs-offset-2 col-xs-8">
                                            <asp:TextBox ID="txtTelephone" CssClass="form-control" runat="server" placeholder="Phone Number" pattern="[6789][0-9]{9}" title="Enter valid mobile number" Required="" AutoPostBack="true" OnTextChanged="txtTelephone_TextChanged"></asp:TextBox>
                                        </div>
                                    </div>
                                    <br />
                                    <div class="form-group">
                                        <div class="col-xs-offset-2 col-xs-8">
                                            <asp:TextBox ID="txtLocation" CssClass="form-control" runat="server" placeholder="Location" MinLength="3" MaxLength="30" Required=""></asp:TextBox>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidatorLocation" runat="server" ControlToValidate="txtLocation"
                                                ValidationExpression="[a-zA-Z ]*$" ErrorMessage="Valid characters: Alphabets and space." />
                                        </div>
                                    </div>

                                    <div class="form-group">
                                        <div class="col-xs-offset-2 col-xs-8">
                                            <asp:TextBox ID="txtSpecEnq" CssClass="form-control" runat="server" placeholder="Specific Enquiry" MaxLength="300" Required=""></asp:TextBox>
                                        </div>
                                    </div>
                                    <br />
                                    <div class="form-group">
                                        <div class="col-xs-offset-2 col-xs-8 Message">
                                            <asp:Label ID="ErrorMessage" runat="server"></asp:Label>
                                            <asp:Label ID="FormMessage" runat="server"></asp:Label>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="col-xs-12 landing-sun-btn">
                                            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" CssClass="btn btn-primary send-me" BackColor="#286090" BorderColor="#286090" Width="40%" />
                                        </div>
                                    </div>
                                    <div class="container">
                                        <!-- Trigger the modal with a button -->
                                        <!-- Modal -->
                                        <div class="modal fade" id="myModal" role="dialog">
                                            <div class="modal-dialog">
                                                <div class="modal-content">
                                                    <div class="modal-header">
                                                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                                                        <h2>Thank you!    </h2>
                                                    </div>
                                                    <div class="modal-body" id="alert-success">
                                                        <b>Thank you for contacting us. We will reach you soon</b>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </form>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</body>
</html>
