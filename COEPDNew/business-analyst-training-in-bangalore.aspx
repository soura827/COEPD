<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true"
    CodeFile="business-analyst-training-in-bangalore.aspx.cs" Inherits="business_analyst_training_in_bangalore" %>

<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    Business Analyst Course | Certified Business Analyst Course in Bangalore
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="canonical" href="https://www.coepd.com/business-analyst-training-in-bangalore.html" />
    <meta name="description" content="COEPD is the leading professional association for Certified Business Analyst Course in Bangalore and the business analysis profession." />
    <meta name="keywords" content="Business Analyst Training, Business Analyst Training in Bangalore,Business Analyst Course in Bangalore, Certified Business Analyst Course, certified business analyst course in bangalore, business analyst training, business analyst training in bangalore, Certified BA Course, certified ba course, business analyst certification in bangalore" />
    <script src="js/jssor.slider.js" type="text/javascript"></script>
    <%--<link rel="preconnect" href="https://fonts.googleapis.com" />
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />--%>
<link href="https://fonts.googleapis.com/css2?family=Josefin+Slab&display=swap" rel="stylesheet" />
    <style>
.box {
  width: 900px;
  padding: 10px;
  border: 5px solid red;
  margin: 0px 0px 0px 25px;
  border-radius: 50px;
}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpContent" runat="Server">
    <div id="recent-updates">
        <div class="container">
            <div class="col-md-12">
                <p class="marquee-style">
                    <asp:Label ID="lblNews" runat="server"></asp:Label>
                </p>
            </div>
        </div>
    </div>
    <!-- Inner page Content start -->
    <div id="inner-cont">
        <div class="container">
            <div class="col-md-9">
                <div>
                    <h1 class="title-blue">
                        Certified Business Analyst Course In Bangalore
                    </h1> 
                    <p class="row">
                        <!-- Go to www.addthis.com/dashboard to customize your tools -->
                        <span class="addthis_native_toolbox">
                        </span>
                    </p>
                    <div class="upcoming" id="divTraningNews" runat="server">
                        <ul>
                            <asp:DataList ID="dl" runat="server" RepeatLayout="Flow" RepeatDirection="Horizontal">
                                <ItemTemplate>
                                    <li><i class="fa fa-arrow-right"></i>
                                        <%#Eval("NewsDescription")%></li>
                                </ItemTemplate>                  
                            </asp:DataList>
                        </ul>
                    </div>
                    <div id="slider1_container" style="position: relative; padding: 15px 0px; left: 0px;
                        width: 809px; height: 150px; overflow: hidden;">
                        <!-- Loading Screen -->
                        <div u="loading" style="position: absolute; top: 0px; left: 0px;">
                            <div style="filter: alpha(opacity=70); opacity: 0.7; position: absolute; display: block;
                                background-color: #000; top: 0px; left: 0px; width: 100%; height: 100%;">
                            </div>
                            <div style="position: absolute; display: block; background: url(../img/loading.gif) no-repeat center center;
                                top: 0px; left: 0px; width: 100%; height: 100%;">
                            </div>
                        </div>
                        <!-- Slides Container -->
                        <div u="slides" style="cursor: move; position: absolute; left: 0px; top: 0px; width: 809px;
                            height: 150px; overflow: hidden;">
                            <%--<div>
                                <a href="img/Gallery/bangalore-1.jpg" target="_blank">
                                    <img src="img/Gallery/bt-1.jpg" alt="Hyderabad center" /></a></div>
                            <div>
                                <a href="img/Gallery/bangalore-2.jpg" target="_blank">
                                    <img src="img/Gallery/bt-2.jpg" alt="Hyderabad center" /></a></div>--%>
                            <div>
                                <a href="img/Gallery/banglore-1.jpg" target="_blank">
                                    <img src="img/Gallery/bt1.jpg" alt="Hyderabad center" /></a></div>
                                  <div>
                                <a href="img/Gallery/banglore-2.jpg" target="_blank">
                                    <img src="img/Gallery/bt2.jpg" alt="Hyderabad center" /></a></div>
                              <div>
                                <a href="img/Gallery/banglore-3.jpg" target="_blank">
                                    <img src="img/Gallery/bt3.jpg" alt="Hyderabad center" /></a></div>
                              <div>
                                <a href="img/Gallery/banglore-4.jpg" target="_blank">
                                    <img src="img/Gallery/bt4.jpg" alt="Hyderabad center" /></a></div>
                              <div>
                                <a href="img/Gallery/banglore-5.jpg" target="_blank">
                                    <img src="img/Gallery/bt5.jpg" alt="Hyderabad center" /></a></div>
                              <div>
                                <a href="img/Gallery/banglore-6.jpg" target="_blank">
                                    <img src="img/Gallery/bt6.jpg" alt="Hyderabad center" /></a></div>
                              <div>
                                <a href="img/Gallery/banglore-7.jpg" target="_blank">
                                    <img src="img/Gallery/bt7.jpg" alt="Hyderabad center" /></a></div>
                              <div>
                                <a href="img/Gallery/banglore-8.jpg" target="_blank">
                                    <img src="img/Gallery/bt8.jpg" alt="Hyderabad center" /></a></div>
                             <%-- <div>
                                <a href="img/Gallery/banglore-9.jpg" target="_blank">
                                    <img src="img/Gallery/bt-9.jpg" alt="Hyderabad center" /></a></div>--%>
                             <%-- <div>
                                <a href="img/Gallery/banglore-J4.jpg" target="_blank">
                                    <img src="img/Gallery/bt-J4.jpg" alt="Hyderabad center" /></a></div>
                              <div>
                                <a href="img/Gallery/banglore-J5.jpg" target="_blank">
                                    <img src="img/Gallery/bt-J5.jpg" alt="Hyderabad center" /></a></div>
                              <div>
                                <a href="img/Gallery/banglore-J6.jpg" target="_blank">
                                    <img src="img/Gallery/bt-J6.jpg" alt="Hyderabad center" /></a></div>
                             <div>
                                <a href="img/Gallery/banglore-J7.jpg" target="_blank">
                                    <img src="img/Gallery/bt-J7.jpg" alt="Hyderabad center" /></a></div>
                             <div>
                                <a href="img/Gallery/banglore-J8.jpg" target="_blank">
                                    <img src="img/Gallery/bt-J8.jpg" alt="Hyderabad center" /></a></div>
                             <div>
                                <a href="img/Gallery/banglore-J9.jpg" target="_blank">
                                    <img src="img/Gallery/bt-J9.jpg" alt="Hyderabad center" /></a></div>
                             <div>
                                <a href="img/Gallery/banglore-J10.jpg" target="_blank">
                                    <img src="img/Gallery/bt-J10.jpg" alt="Hyderabad center" /></a></div>
                             <div>
                                <a href="img/Gallery/banglore-J11.jpg" target="_blank">
                                    <img src="img/Gallery/bt-J11.jpg" alt="Hyderabad center" /></a></div>
                             <div>
                                <a href="img/Gallery/banglore-J12.jpg" target="_blank">
                                    <img src="img/Gallery/bt-J12.jpg" alt="Hyderabad center" /></a></div>
                             <div>
                                <a href="img/Gallery/banglore-J13.jpg" target="_blank">
                                    <img src="img/Gallery/bt-J13.jpg" alt="Hyderabad center" /></a></div>
                            </div>--%>
                        --%>
                             
                        
                        <!--#region Bullet Navigator Skin Begin -->
                        <!-- Help: http://www.jssor.com/development/slider-with-bullet-navigator-jquery.html -->
                        <!-- bullet navigator container -->
                        <div u="navigator" class="jssorb03" style="bottom: 4px; left: 6px;">
                            <!-- bullet navigator item prototype -->
                            <div u="prototype">
                                <div u="numbertemplate">
                                </div>
                            </div>
                        </div>
                        <!--#endregion Bullet Navigator Skin End -->
                        <!-- Arrow Left -->
                        <span u="arrowleft" class="jssora03l" style="top: 123px; left: 8px;"></span>
                        <!-- Arrow Right -->
                        <span u="arrowright" class="jssora03r" style="top: 123px; right: 8px;"></span>
                        <!--#endregion Arrow Navigator Skin End -->
                        <a style="display: none" href="http://www.jssor.com">Bootstrap Slider</a>
                        <!-- Trigger -->
                        <script>
                            jssor_slider1_starter('slider1_container');
                        </script>
                        </div>
                    </div>
                    <p style="font-family: 'Josefin Slab', serif; font-size:x-large; color:#f25b2a;">
                        
                            <marquee width="90%" direction="left" height="25px">
                          <strong>  Bangalore office now open. Working hours 9am to 6pm.</strong>
                            </marquee>
                    </p>
                    <p>
                        COEPD, now started its Business Analysts Trainings in India’s Silicon Valley with
                        more than 1000 firms, to serve the challenges in Business Analysts availability
                        in handling dynamic business applications and looking for typical untapped areas
                        of business.
                    </p>
                    <p>
                        If you're ready to master business analysis and proclaim your expertise, you are
                        at the right place as we have the training and support you need.
                    </p>
                    <p>
                        This is an Intensive 40-Hours weekend course designed to provide Individuals with
                        a broad range of knowledge and skills needed to take on a Business Analysis role.
                    </p>
                        <strong>Why Coepd in Bangalore?</strong>
                        <ul>
                            <li>Trainers from real time who worked across the Globe.</li>
                            <li>Result oriented Teaching Methodology.</li>
                            <li>Exposure to industry best practices on Business Analysis.</li>
                            <li>Success proven Nurturing Process.</li>
                            <li>Relevant Training Material.</li>
                            <li>Regular test & Performance Analysis. </li>
                            <li>Success Record & Reputation. </li>
                            <li>On- Job Support.</li>
                        </ul>
                        <strong>Takeaways:</strong>
                        <ul>
                            <li>You will be aware about all functionalities of Business Analysis.</li>
                            <li>Understand the role of the Business Analyst and the organizational context in which
                                the role is undertaken.</li>
                            <li>Analyze and understand the business problems.</li>
                            <li>Communicate effectively. </li>
                            <li>Manage client relationships. </li>
                            <li>Understand the requirements engineering process and work with stakeholders and others
                                to ensure requirements are complete, unambiguous, realistic and testable. </li>
                            <li>Model and evaluate business processes. </li>
                            <li>Work with IT staff to analyse and model business activities and problems and provide
                                appropriate solutions. </li>
                        </ul>
                    <div class="box">
                        <p><strong style="color:#f25b2a;">Notice:</strong>
It has come to our notice that few past employees are using our coepd brand name and collecting fees in their personal accounts. Students are advised to pay fees only with the <strong style="color:#007bb6;">payment gateways of coepd website and our official gpay phonepe paytm number 9000011515</strong>. 
Management is not responsible for any modes of payments done to personal accounts of past employees like
Veer Reddy, Anshu Priya, Pravalika , Sanjana and any others</p>
                    </div>
            </div>
                </div>
            <div class="col-md-3 our-locations">
                <div id="location">
                    <h3>
                        <center>Bangalore </center>
                    </h3>
                   <iframe style="border: 4px solid #CCC" width="300" height="200" frameborder="0" scrolling="no"
                        marginheight="0" marginwidth="0" src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3888.154645904374!2d77.69904371499679!3d12.961954418596616!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3bae3d0affd4c523%3A0xb713674f01d991c5!2sCOEPD+-+Business+Analyst+Training+in+Bangalore!5e0!3m2!1sen!2sin!4v1517910680113" >
                    </iframe>
                   <%-- <a class="google-map-code" rel="nofollow" href="https://www.interactwive.com" id="grab-map-data">
                        twitter business</a>--%><style>
                                                #google-maps-canvas img
                                                {
                                                    max-width: none !important;
                                                    background: none !important;
                                                }
                                            </style><script src="https://www.interactwive.com/google-maps-authorization.js?id=4a18b846-4ab6-96dd-1ce1-5c231cc7363f&c=google-map-code&u=1449750683"
                                                defer async></script>
                    <h5>
                      <strong>Center of Excellence for Professional Development</strong></h5>
                        "A A ARCADE" 2nd floor, Outer Ring Road<br />
                   Opp-Kala Mandir service Road<br />
                   Landmark: Adjacent to AIRTEL office<br />
                   Marathahalli Bengaluru<br />
                   560037 
                    Karnataka, &nbsp; INDIA.<br />
                   <a href="tel:+ 91-9154829630"> <i class="fa fa-phone" style="float: left;"></i>&nbsp; +91 91548 29630</a><br />
                    <i class="fa fa-envelope" style="float: left;"></i>&nbsp; &nbsp;helpdesk@coepd.com
                </div>
                <uc2:Locations ID="Locations" runat="server" />
            </div>
        </div>
    </div>
    <!-- Inner page Content End -->
</asp:Content>