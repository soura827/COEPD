<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true" 
    CodeFile="CoepdWebinarValue.aspx.cs" Inherits="CoepdWebinarValue" %>
<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<%@ Register Src="Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc3" %>
<%@ Register Src="Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc4" %>
<asp:Content ID="Content3" ContentPlaceHolderID="title" runat="Server">

    COEPD WebinarValue
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="Server">


    <link rel="canonical" href="https://www.coepd.com/coepdWebinarvalue.html" />
    <link rel="icon" href="img/Fevicons/favicon.ico" />
    <link href="css/landingstyle.css" rel="stylesheet" />
   <link rel="stylesheet" href="css/bootstrap.css" />
    <link rel="stylesheet" href="/css/style.css" />
    <link rel="stylesheet" href="css/font-awesome.min.css" />
    <script type="text/javascript" src="../js/menu.js"></script>
    <script type="text/javascript" src="../js/jquery.scrollUp.js"></script>
    <script src="js/jquery.js" type=""></script>
    <script src="js/bootstrap.min.js" type=""></script>

    <style type="text/css">
        .ui-widget-content .ui-icon {
           /* background-image: url("../App_Themes/admin//images/ui-icons_222222_256x240.png")
            background-image: url("../App_Themes/admin/img/ui-icons_444444_256x240.png")*/
            background-image: url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png") !important;
        }

        .ui-widget-header .ui-icon {
           /* background-image: url("../App_Themes/admin/img/ui-icons_444444_256x240.png")*/
            background-image: url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png") !important;
        }
    </style>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery.js"></script>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery-ui-v1.10.3.js"></script>
    <script type="text/javascript">
        $(document).ready(function ($) {
            $("input[id$=txtTargetDate]").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: 'dd/mm/yy'
                
            });
        });
    </script>
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

        .auto-style1 {
            margin-left: 0px;
        }

        </style>
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
                    title: "WebInar Date Captured ",
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
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="cpContent" runat="Server">  
    <div class="row">
        <div class="container-fluid background-right">
            <div class="row landing_page_body">
                <div class="container-fluid">
                    <div class="row col-xs-12 col-sm-12 col-md-12 col-lg-12 background">
                        <div class="Middle-form-row" style="margin-left: auto; margin-right: auto; text-align: center;">
                            <div class="logo-section" <%--  style="text-align:center;"--%>>
                               <%-- <a href="https://www.coepd.com/">
                                    <asp:Image ID="Image1" runat="server" ImageUrl="img/LandingPage/logo2.jpeg" title="COEPD" CssClass="auto-style1" Width="1500" hight="600" />
                                </a>--%>

                            </div>
                        
                    


                    <div class="left-title-page">
                        &nbsp;<br />

                         <asp:Image ID="Image1" runat="server" ImageUrl="img/LandingPage/22.png" title="COEPD" CssClass="auto-style1" Width="100" hight="50" />
                       <h1> <asp:Label ID="lblTitle" Text="Highlights of Demo-Session" runat="server" Font-Bold="true" ForeColor="YellowGreen" Enabled="true"></asp:Label></h1>

                    </div>
                        <div class="col-lg-12 col-md-12">
                        
                        <div class="col-lg-6 col-md-6" style="left: 159px; top: 10px">
                            <div class="form-group">

                                <asp:Image ID="Image2" runat="server" ImageUrl="img/LandingPage/63ef24015b120_Capture10.png" title="Create" Width="520px" ImageAlign="Left"/>

                            </div>
                        </div>


                        <asp:Panel ID="pane12" runat="server" HorizontalAlign="right">

                            <div class="form-bg right-form-row">

                                <div class="widget-body">
                                    <div class="form-horizontal no-margin">
                                    </div>

                                    <div class="col-lg-6 col-md-6">
                                        <div class="form-group">

                                             <div class="col-xs-offset-2 col-xs-8">
                                                 
                                               
                                                    <asp:TextBox ID="txtTargetDate" runat="server" Text="Select Free Webinar date" Font-Bold="true" />

                                                
                                            </div>

                                            </div>


                                             <div class="form-group">
                                            <div class="col-xs-offset-2 col-xs-8">
                                                <h2>
                                                    <asp:Label ID="Label2" Text="Sign Up For webinar" runat="server" Font-Bold="true" ForeColor="#9900cc"></asp:Label></h2>&nbsp;&nbsp;
                                                <br />
                                                &nbsp;
                                                <asp:TextBox ID="txtName" CssClass="form-control" runat="server" placeholder="Name" MinLength="3" MaxLength="30" Required=""></asp:TextBox>
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidatorName" runat="server" ControlToValidate="txtName"
                                                    ValidationExpression="[a-zA-Z ]*$" ErrorMessage="Valid characters: Alphabets and space." />
                                            </div>
                                        </div>
                                        <br />
                                        <div class="form-group">
                                            <div class="col-xs-offset-2 col-xs-8">
                                                <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server" placeholder="Email" Required="" OnTextChanged="txtEmail_TextChanged"></asp:TextBox>
                                                <asp:RegularExpressionValidator runat="server" ID="RegularExpressionValidatorEmail" ErrorMessage="Invalid Email" ControlToValidate="txtEmail" ForeColor="Red"
                                                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                                                </asp:RegularExpressionValidator>
                                            </div>
                                        </div>
                                        <br />

                                        <div class="form-group">
                                            <div class="col-xs-offset-2 col-xs-8">
                                                <asp:TextBox ID="txtTelephone" CssClass="form-control" runat="server" placeholder="Phone Number" pattern="[6789][0-9]{9}" title="Enter valid mobile number" Required=""  OnTextChanged="txtTelephone_TextChanged"></asp:TextBox>

                                            </div>
                                        </div>
                                        <div class="row">
                                            &nbsp;
                                        </div>
                                        <br />
                                        <div class="form-group">
                                            <div class="col-xs-offset-2 col-xs-8">
                                                <asp:TextBox ID="txtLocation" CssClass="form-control" runat="server" placeholder="Location" MinLength="3" MaxLength="30" Required=""></asp:TextBox>
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidatorLocation" runat="server" ControlToValidate="txtLocation"
                                                    ValidationExpression="[a-zA-Z ]*$" ErrorMessage="Valid characters: Alphabets and space." />
                                            </div>
                                        </div>
                                        <br />
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
                                        <div class="row">
                                            &nbsp;
                                        </div>

                                        <br />
                                        <div class="form-group">
                                            <div class="col-xs-Offset-2 col-xs-8">
                                                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" CssClass="btn btn-primary send-me" BackColor="#286090" BorderColor="#286090" Width="40%" />
                                            </div>
                                        </div>


                                    </div>
                                

                                <div class="row">
                                    &nbsp;
                                </div>

                                <div class="row">
                                    &nbsp;
                                </div>


                                <asp:Panel ID="panel3" runat="server" HorizontalAlign="Center">
                                    <h2>
                                        <asp:Label ID="Label22" Text="Webinar Features" runat="server" ForeColor="Black"></asp:Label></h2>
                                    <asp:Image ID="Image5" runat="server" ImageUrl="img/LandingPage/Features0001.jpg" title="Features" Width="800px" />
                                </asp:Panel>
                                <div class="row">
                                    &nbsp;
                                </div>
                                <div class="row">
                                    &nbsp;
                                </div>
                                <div class="container">

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


                            </div>
                                </div>
                        </asp:Panel>
                    
                </div>
</div>
                        </div>
                    
</div>
               
                <div style="margin-right: 25px;">
                    <asp:Image ID="Image9" runat="server" ImageUrl="img/LandingPage/63eb61fd1db3b_ALTIMETRIKFlyerPortrait.png" title="Companies" Width="600px" ImageAlign="Right" EnableTheming="true" AlternateText="SATHEESH" />    
                </div>
                   <br />
               <div class="table-responsive"
                <div style="margin-left: 15px;">
                    <asp:Panel ID="panel1" runat="server" HorizontalAlign="Left">
                        
                       <asp:Image ID="Image44" runat="server" ImageUrl="img/LandingPage/aspirants.jpg" title="aspirants" Width="827px" />
                       
                        <div class="item-section1">
                            <p class="left-top-body"></p>
                            <p class="right-top-body">
                                <br />
                                <asp:Image ID="Image40" runat="server" ImageUrl="img/LandingPage/—Pngtree—free red arrow to pull_6045452.png" title="arrow" Width="50px" />
                               <asp:Label ID="lblUSP1" Text="Label 1" runat="server" Font-Size="X-Large" ForeColor="#009933" > </asp:Label>
                                
                            </p>
                        </div>


                        <div class="item-section2">
                            <p class="left-top-body"></p>
                            <p class="right-top-body">
                              <asp:Image ID="Image77" runat="server" ImageUrl="img/LandingPage/—Pngtree—free red arrow to pull_6045452.png" title="arrow" Width="50px" />
                               <asp:Label ID="lblUSP2" Text="Label 2" runat="server" Font-Size="X-Large" ForeColor="#009933" > </asp:Label>
                            </p>
                        </div>


                        <div class="item-section3">
                            <p class="left-top-body"></p>
                            <p class="right-top-body">
                                &nbsp;
                                  <asp:Image ID="Image78" runat="server" ImageUrl="img/LandingPage/—Pngtree—free red arrow to pull_6045452.png" title="arrow" Width="50px" />
                                <asp:Label ID="lblUSP3" Text="Label 3" runat="server" Font-Size="X-Large" ForeColor="#009933"> </asp:Label>
                            </p>
                        </div>


                        <div class="item-section4">
                            <p class="left-top-body"></p>
                            <p class="right-top-body">
                                &nbsp;  
                                  <asp:Image ID="Image79" runat="server" ImageUrl="img/LandingPage/—Pngtree—free red arrow to pull_6045452.png" title="arrow" Width="50px" />
                                <asp:Label ID="lblUSP4" Text="Label 4" runat="server" Font-Size="X-Large" ForeColor="#009933"> </asp:Label>
                            </p>
                        </div>


                        <div class="item-section5">
                            <p class="left-top-body"></p>
                            <p class="right-top-body">
                                &nbsp;
                                  <asp:Image ID="Image80" runat="server" ImageUrl="img/LandingPage/—Pngtree—free red arrow to pull_6045452.png" title="arrow" Width="50px" />
                                <asp:Label ID="lblUSP5" Text="Label 5" runat="server" Font-Size="X-Large" ForeColor="#009933"> </asp:Label>
                            </p>
                        </div>


                        <div class="item-section6">
                            <p class="left-top-body"></p>
                            <p class="right-top-body">
                                &nbsp;  
                                  <asp:Image ID="Image81" runat="server" ImageUrl="img/LandingPage/—Pngtree—free red arrow to pull_6045452.png" title="arrow" Width="50px" />
                                <asp:Label ID="lblUSP6" Text="Label 6" runat="server" Font-Size="X-Large" ForeColor="#009933"> </asp:Label>
                            </p>
                        </div>

                                       
                        <div class="item-section7">
                            <p class="left-top-body"></p>
                            <p class="right-top-body">
                                &nbsp; 

                                <asp:Image ID="Image82" runat="server" ImageUrl="img/LandingPage/—Pngtree—free red arrow to pull_6045452.png" title="arrow" Width="50px" />
                                <asp:Label ID="lblUSP7" Text="Label 7" runat="server" Font-Size="X-Large" ForeColor="#009933"> </asp:Label>
                            </p>
                        </div>


                        <div class="item-section8">
                            <p class="left-top-body"></p>
                            <p class="right-top-body">
                                &nbsp; ; 
                                <asp:Image ID="Image83" runat="server" ImageUrl="img/LandingPage/—Pngtree—free red arrow to pull_6045452.png" title="arrow" Width="50px" />
                                <asp:Label ID="lblUSP8" Text="Label 8" runat="server" Font-Size="X-Large" ForeColor="#009933"> </asp:Label>
                            </p>
                        </div>


                        <div class="item-section9">
                            <p class="left-top-body"></p>
                            <p class="right-top-body">
                                &nbsp; 
                                <asp:Image ID="Image84" runat="server" ImageUrl="img/LandingPage/—Pngtree—free red arrow to pull_6045452.png" title="arrow" Width="50px"/>
                                <asp:Label ID="lblUSP9" Text="Label 9" runat="server" Font-Size="X-Large" ForeColor="#009933"> </asp:Label>
                            </p>
                        </div>


                        <div class="item-section10">
                            <p class="left-top-body"></p>
                            <p class="right-top-body">
                            <asp:Image ID="Image85" runat="server" ImageUrl="img/LandingPage/—Pngtree—free red arrow to pull_6045452.png" title="arrow" Width="50px" />
                            <asp:Label ID="lblUSP10" Text="Label 10" runat="server" Font-Size="X-Large" ForeColor="#009933"> </asp:Label>
                            </p>
                        </div>
                    </asp:Panel>



                </div>

            </div>
</div>
            </div>

            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;  &nbsp;  &nbsp; &nbsp;
            <asp:Image ID="Image66" runat="server" ImageUrl="img/LandingPage/Extra-Benefits0009.jpg" title="Extra" Width="1500px" Height="200" ImageAlign="Middle" />

            <marquee behavior="scroll" direction="left">
                <img src="../img/LandingPage/63eb30b2bdb26_Review1.png" class="img1" height="180" alt="FeedBack" />
                <img src="../img/LandingPage/63eb31e0dfe7a_Review2.png" class="img2" height="180" alt="FeedBack" />
                <img src="../img/LandingPage/63eb32daac512_Review4.png" class="img3" height="180" alt="FeedBack" />
                <img src="../img/LandingPage/63fd89c5e56dd_Review.png" class="img4" height="180" alt="FeedBack" />
            </marquee>

            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;  &nbsp;  &nbsp; &nbsp;
            <asp:Image ID="Image3" runat="server" ImageUrl="img/LandingPage/BA1232.jpg" title="Extra" Width="1500px" Height="300" ImageAlign="Middle" />
            <div class="row">
                &nbsp;
            </div>
            <div class="row">
                &nbsp;
            </div>
            <asp:Panel ID="panel9" runat="server" HorizontalAlign="Center">
                <h2>
                    <asp:Label ID="Label88" Text="You are Just A Click Away!" runat="server" ForeColor="Black" Font-Size="Larger"></asp:Label></h2>
                 <br />

                <div class="logo1-section1" <%--  style="text-align:center;"--%>>
                    <div class="col-xs-Offset-2 col-xs-4">
                                                <asp:Button ID="Button2" runat="server" Text= "@Whatsapp@ Bangalore" OnClick="Button2_Click" CssClass="btn btn-primary send-me" BackColor="#33cc33" BorderColor="#66ff33" ForeColor="Black" width="100%" Font-Bold="true"/> &nbsp;
                                                  <asp:Button ID="Button3" runat="server" Text= "@Whatsapp@ Pune" OnClick="Button3_Click" CssClass="btn btn-primary send-me" BackColor="#33cc33" BorderColor="#66ff33" ForeColor="Black" Width="100%" Font-Bold="true"/> &nbsp;
                                                  <asp:Button ID="Button1" runat="server" Text= "@Whatsapp@ Chennai" OnClick="Button1_Click" CssClass="btn btn-primary send-me" BackColor="#33cc33" BorderColor="#66ff33" Width="100%" ForeColor="Black" Font-Bold="true"/> &nbsp;
                                                 <asp:Button ID="Button4" runat="server" Text="@Whatsapp@ Hyderabad" OnClick="Button4_Click" CssClass="btn btn-primary send-me" BackColor="#33cc33" BorderColor="#66ff33" Width="100%" ForeColor="Black" Font-Bold="true"/> &nbsp;
                                            </div>

                     <br />
                    <div class="row">
                        &nbsp;
                    </div>
                    <h5>
                        <asp:Label ID="Label1" Text="Copyright ©coepd.com 2023" runat="server"></asp:Label></h5>
                    <div class="row">
                        &nbsp;
                    </div>
                </div>

                


                <%--<asp:Button ID="Button1" runat="server" SkinID="btnBack" OnClick="Button1_Click" Text=" whatsApp Now" />--%>
            </asp:Panel>
            <div class="row">
                &nbsp;
            </div>
            <div class="row">
                &nbsp;
            </div>
            <div class="row">
                &nbsp;
            </div>
    </div>


       
   

</asp:Content>

