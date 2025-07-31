<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaypalPayment.aspx.cs" Inherits="PaypalPayment" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "https://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Coepd Participant Paypal Payment | Business Analyst Participant Payment</title>
    <link rel="cananical" href="https://www.coepd.com/PaypalPayment.html" />
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
        <form action="https://www.paypal.com/cgi-bin/webscr" method="post" target="_top"
                align="center">
                <div class="jumbotron">
                    <div class="header">
                        Paypal Payment Gateway ($ USD only)
                    </div>
                    <div class="form">
                        <div class="name">
                            &nbsp;
                        </div>
                    </div>
                    <div class="form">
                        <div class="row">
                            &nbsp;
                        </div>
                        <div class="row pay">
<input type="hidden" name="cmd" value="_s-xclick" />
<input type="hidden" name="hosted_button_id" value="XDS7VDDDZ8BXQ" />
<input type="image" src="https://www.paypalobjects.com/en_GB/i/btn/btn_paynowCC_LG.gif" border="0" name="submit" alt="PayPal – The safer, easier way to pay online!" />
<img alt="pixel" border="0" src="https://www.paypalobjects.com/en_GB/i/scr/pixel.gif" width="1" height="1" />
                        </div>
                    </div>
                    <div class="footer">
                        &nbsp;</div>
                </div>
                </form>
        </div>
</body>
</html>
