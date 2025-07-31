<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true"
    CodeFile="business-analyst-corporate-trainings.aspx.cs" Inherits="business_analyst_corporate_trainings" %>
<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    Business Analyst Corporate Training | BA Corporate Training
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="canonical" href="https://www.coepd.com/business-analyst-corporate-trainings.html" />
    <meta name="description" content="COEPD purely focuses on Business Analyst Corporate Training of different dimensions. COEPD delivers interactive -Corporate training programs to participants all over the world." />
    <meta name="keywords" content="Business Analyst course, Business Analyst Corporate Training, Business Analyst Corporate Training Institute, Business Analyst Training in Hyderabad, Business Analyst Training in Pune, Business Analyst training in Chennai, Business Analyst training in Mumbai" />
    <script src="js/jssor.slider.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpContent" runat="Server">
    <div id="recent-updates">
        <div class="container">
            <div class="col-md-12">
                <uc1:NewsAll ID="NewsAll" runat="server" />
            </div>
        </div>
    </div>
    <!-- Inner page Content start -->
    <div id="inner-cont">
        <div class="container">
            <div class="col-md-9">
                <div>
                    <h1 class="title-blue">
                        Business Analyst Corporate training</h1>
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
                            <div>
                                <a href="img/Gallery/Corporate-img1.jpg" target="_blank">
                                    <img src="img/Gallery/Corporate-img1.jpg" alt="Corporate-img1" /></a></div>
                            <div>
                                <a href="img/Gallery/Corporate-img2.jpg" target="_blank">
                                    <img src="img/Gallery/Corporate-img2.jpg" alt="Corporate-img2" /></a>
                            </div>
                        </div>
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
                        <script type="text/javascript">
                            jssor_slider1_starter('slider1_container');
                        </script>
                    </div>
                    <p>
                        <strong>COEPD - Center of Excellence for Professional Development</strong> is reputed
                        for delivering the training sessions in most practical way which plugs the skill
                        gaps. The sessions effectively contribute an extra edge to prepare smart workforce
                        in this volatile and highly competitive working environment.
                    </p>
                    <p>
                        Face-to-face learning, a classroom training approach would be definitely the most
                        effective delivery being delivered by an efficient faculty. We believe in participate
                        interaction in a most convenient which exposes the participant multi-dimensional
                        diverse representation of exposure at the same time with backing of real-time experience
                        in a lucid way.
                    </p>
                    <strong>Our Focus</strong>
                    <p>
                        COEPD offers purely focuses on Business Analyst training of different dimensions;
                        which comprises Requirements Management, Requirements Engineering, Elicitation Techniques,
                        SDLC Models & Methodologies, Proficiency in using UML diagrams ( practice with software
                        and on paper) etc.
                    </p>
                    <ul>
                        <li>Delivery of sessions to meet your work schedules and timelines.</li>
                        <li>Engineered training standards and objectives to suit the needs of client. </li>
                        <li>Offline and online support addressing issues pertaining to clarifications.</li>
                        <li>Dedicated Faculty which is client-specific. </li>
                    </ul>
                    <strong>Skills to be Imparted in Workshop</strong>
                    <p>
                        A comprehensive Business Analysis Workshop which addresses the following aspects.</p>
                    <ul>
                        <li>Overview on Document Analysis comprehensively.</li>
                        <li>Hands on practice on UML diagrams (on paper and on software).</li>
                        <li>Deliver with cases, activities, scenarios, apt examples etc.</li>
                        <li>Through light on Elicitation Techniques.</li>
                        <li>Prepare for larger role of BA.</li>
                    </ul>
                </div>
            </div>
            <div class="col-md-3 our-locations">
                <uc2:Locations ID="Locations" runat="server" />
            </div>
        </div>
    </div>
    <!-- Inner page Content End -->
</asp:Content>