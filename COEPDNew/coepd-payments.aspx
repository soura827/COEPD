<%@ Page Language="C#" AutoEventWireup="true" CodeFile="coepd-payments.aspx.cs" Inherits="coepd_payments" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "https://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>COEPD Payments</title>
    <meta name="description" content="coepd course payment" />
    <meta name="keywords" content="coepd payments, razorpay, cc Avenue, Citrus, payment gateway" />
     <link rel="canonical" href="https://www.coepd.com/coepd-payments.html" />
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/custom.css" rel="stylesheet" />
</head>
<body>
    <div class="container-fluid">
        <div class="row">
            <nav class="navbar navbar-default navbar-static-top">
              <div class="container">
                <center><img src="img/logo.jpeg" height="120px" width="250px" class="logo-img" alt="COEPD Logo"/></center>
                </div>
            </nav>
        </div>
        <div class="row">
            <div class="col-md-3">
            </div>
            <div class="col-md-7">
                <form id="form1" runat="server">
                <div class="jumbotron">
                    <div class="header">
                        <img src="img/sign-up-icon.png" alt="Sign-Up-icon" />&nbsp; &nbsp;COEPD Payment Gateways - Pay Using Below
                    </div>
                    <div class="header">
                    </div>
                    <div class="form">
                        <asp:RadioButtonList runat="server" ID="RButton">
                            <asp:ListItem Selected="True"><img src="img/PaymentGateway/RazorPay.PNG" alt="Razorpay Logo" />&nbsp;&nbsp;INR Only (No Cost EMI available for 3 Months on selected credit cards)</asp:ListItem>
                            <asp:ListItem><img src="img/PaymentGateway/CCAvenue.jpeg" alt="CC Avenue Logo" />&nbsp;&nbsp;INR, USD and EMI</asp:ListItem>
                            <asp:ListItem><img src="img/PaymentGateway/citrus.png" alt="Citrus Logo" />&nbsp;&nbsp;INR Only</asp:ListItem>
                        </asp:RadioButtonList>
                      
                    </div>
                    <div class="form">
                        <asp:Button runat="server" ID="btnPayNow" Text="Pay Now" OnClick="btnPayNow_Click" />

                    </div>
                   <%-- <div class="form">
                       <a href="#"> <img src="img/PaymentGateway/Paypal.png" alt="Paypal Logo" /></a>
                    </div>--%>
                    <div class="footer">
                        &nbsp;</div>
                </div>
                </form>
            </div>
        </div>
    </div>
</body>
</html>
