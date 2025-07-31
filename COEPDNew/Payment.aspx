<%@ Page Language="C#" AutoEventWireup="true" CodeFile="payment.aspx.cs" Inherits="Payment" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "https://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Coepd Participant Payment</title>
    <meta name="description" content="Coepd Participant Payment" />
    <meta name="keywords" content="Coepd Participant Payment" />

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
                        <img src="img/sign-up-icon.png" alt="Sign-Up-icon" />&nbsp; &nbsp;CC Avenue Payment Gateway
                    </div>
                    <div class="header">
                    </div>
                    <div>
                        <p><strong>EMI Facility Available for below Credit Cards:</strong> ICICI Bank, Axis Bank, IndusInd Bank, RBL Bank, Kotak Mahindra Bank, Corporation Bank, HSBC Bank, 
                            Standard Chartered Bank, Yes Bank, IDBI Bank, Bank of Baroda and HDFC Bank.</p>
                        <p><strong>EMI Facility Available for below Debit Cards:</strong> HDFC Bank.</p>
                    </div>
                    <div class="form">
                        <div class="name">
                            Participant Name
                        </div>
                        <div>
                            <asp:TextBox ID="txtName" runat="server" required="" Width="250px"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidatorName" runat="server" ControlToValidate="txtName"
                                        ValidationExpression="[a-zA-Z ]*$" ErrorMessage="Valid characters: Alphabets and space." />
                        </div>
                    </div>
                    <div class="form">
                        <div class="name">
                            Mobile
                        </div>
                        <div>
                            <asp:TextBox ID="txtMobile" runat="server" required="" Width="250px" type="number"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidatorMobile" runat="server" 
      ControlToValidate="txtMobile" ErrorMessage="Must be 10 Numbers" 
    ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>
                        </div>
                    </div>
                    <div class="form">
                        <div class="name">
                            E-mail
                        </div>
                        <div>
                            <asp:TextBox ID="txtEmail" runat="server" required="" Width="250px" type="email"></asp:TextBox>
                            <asp:RegularExpressionValidator runat="server" ID="RegularExpressionValidatorEmail" ErrorMessage="Invalid Email" ControlToValidate="txtEmail" ForeColor="Red" 
                                         ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                                        </asp:RegularExpressionValidator>
                        </div>
                    </div>
                    <div class="form">
                        <div class="name">
                            Address
                        </div>
                        <div>
                            <asp:TextBox ID="txtAddress" runat="server" required="" Width="250px" TextMode="MultiLine"></asp:TextBox>
                        </div>
                    </div>
                      <div class="form">
                        <div class="name">
                             Currency
                        </div>
                        <div>
                            <asp:DropDownList ID="ddlCurrency" runat="server" OnSelectedIndexChanged="ddlCurrency_SelectedIndexChanged" AutoPostBack="true" >
                                <asp:ListItem>INR</asp:ListItem>
                                <asp:ListItem>USD</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="form">
                        <div class="name">
                            Amount(<asp:Label ID="lblamount" runat="server" Text="INR"></asp:Label>)
                        </div>
                        <div>
                            <asp:TextBox ID="txtAmount" runat="server" required="" Width="250px" type="number"></asp:TextBox>
                            <asp:RegularExpressionValidator runat="server" ControlToValidate="txtAmount" ValidationExpression="[1-9][0-9]*" ErrorMessage="Please enter a valid amount"></asp:RegularExpressionValidator>
                        </div>
                     </div>
                    <div class="form" id="divmsg" runat="server" visible="false" style="margin-left:70px;" >
                        <asp:Label ID="lblmsg" runat="server" Font-Bold="true" ForeColor="#2F5095" Text="Only AMEX cards are accepted now for USD payments"></asp:Label>
                    </div>
                    <div class="button">
                        <asp:Button ID="btnPayment" runat="server" Text="Make Payment" OnClick="btnPayment_Click" />
                        <input  value="Reset" type="reset"  class="btn btn-info"/>
                    </div>
                    <div class="footer">
                        &nbsp;</div>
                </div>
                </form>
            </div>
        </div>
      <%--  <div class="row">
                        <div class="col-md-6">
                <form action="http://coepd.net/" method="post" target="_top"
                align="center">
                <div class="jumbotron">
                    <div class="header">
                        Citrus Payment Gateway(INR only)
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
<input type="image" src="https://www.paypalobjects.com/en_GB/i/btn/btn_paynowCC_LG.gif" border="0" name="submit" alt="PayPal – The safer, easier way to pay online!" />
<img alt="pixel" border="0" src="https://www.paypalobjects.com/en_GB/i/scr/pixel.gif" width="1" height="1" />
                        </div>
                    </div>
                    <div class="footer">
                        &nbsp;</div>
                </div>
                </form>
            </div>
            <div class="col-md-6">
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
        </div>--%>
    </div>
</body>
</html>