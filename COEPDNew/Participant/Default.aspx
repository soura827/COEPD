<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "https://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>.: COEPD Participant :.</title>
    <script type="text/javascript" language="JavaScript">
        this.history.forward(-1);
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="dashboard-container">
        <div class="container">
            <!-- Row Start -->
            <div class="row">
                <div class="col-lg-4 col-md-4 col-md-offset-4">
                    <div class="sign-in-container">
                        <div class="login-wrapper">
                            <div class="header">
                                <div class="row">
                                    <div class="col-md-12 col-lg-12">
                                        <h3>
                                            Participant Login<img src="img/logo.png" alt="Logo" class="pull-right" /></h3>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12 col-lg-12">
                                    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                                </div>
                            </div>
                            <div class="content">
                                <div class="form-group">
                                    <label>
                                        User Name</label>
                                    <div class="form-group">
                                        <asp:TextBox ID="txtUserName" runat="server" required=""></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label>
                                        Password</label>
                                    <div class="form-group">
                                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" required=""></asp:TextBox>
                                    </div>
                                </div>
                                <div class="actions">
                                    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" CssClass="btn btn-danger" />
                                    <div class="clearfix">
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script type="text/javascript" src="js/jquery.min.js"></script>
    <script type="text/javascript" src="js/bootstrap.min.js"></script>
    <script type="text/javascript" src="js/ie10-viewport-bug-workaround.js"></script>
    </form>
</body>
</html>