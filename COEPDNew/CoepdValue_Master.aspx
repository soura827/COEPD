<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CoepdValue_Master.aspx.cs" Inherits="CoepdValue_Master" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>COEPD Value </title>
    <link rel="canonical" href="https://www.coepd.com/coepdValue_Master.html" />
    <link rel="icon" href="img/Fevicons/favicon.ico" />
    <link href="css/landingstyle.css" rel="stylesheet" />
    <link rel="stylesheet" href="css/bootstrap.css" />
    <link rel="stylesheet" href="css/font-awesome.min.css" />
    <script src="js/jquery.js" type=""></script>
    <script src="js/bootstrap.min.js" type=""></script>

    <style type="text/css">

        
a:link {
  color: White;
  background-color: transparent;
  text-decoration: none;
 
}
a:visited {
  color: White;
  background-color: transparent;
  text-decoration: none;
}
a:hover {
  color: white;
  background-color: transparent;
  text-decoration: underline;
}
a:active {
  color: yellow;
  background-color: transparent;
  text-decoration: underline;
}

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
<body style="height: 1751px">
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
                                    <asp:Label ID="lblTitle" Text="Business Analyst Training" runat="server"> </asp:Label></h1>
                            </div>
                            <div class="item-section1" runat="server">
                                <p class="left-top-body"></p>

                                <%--<asp:Button ID="Button5" runat="server"   CssClass="btn btn-primary send-me" BackColor="#286090" BorderColor="#286090" Text="Button" />--%>
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
                            <div class="right-title-page">
                                    <h1 style="/*padding-left: 1.2em*/; padding-bottom: 0.10em; text-align: center">Choose Your Location</h1>
                                </div>
                            <div class="form-bg right-form-row">

                              
<center><a href="CoepdValue_Hyderbad.aspx"target="_blank" onmousemove="true"><h3>Hyderabad</h3></a> </center>
<center><a href="CoepdValue_Pune.aspx"target="_blank" onmousemove="true"><h3>Pune</h3></a> </center>
<center><a href="CoepdValue_Chennai.aspx"target="_blank" onmousemove="true"><h3>Chennai</h3></a> </center>
<center><a href="CoepdValue_Delhi.aspx"target="_blank" onmousemove="true"><h3>Delhi-NCR</h3></a> </center>
<center><a href="CoepdValue_Mumbai.aspx"target="_blank" onmousemove="true"><h3>Mumbai</h3></a> </center>
<center><a href="CoepdValue_Visakhapatnam.aspx"target="_blank" onmousemove="true"><h3>Visakhapatnam</h3></a> </center>
<center><a href="CoepdValue_Banglore.aspx"target="_blank" onmousemove="true"><h3>Banglore</h3></a> </center>

                                    
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
    

</body>
</html>
