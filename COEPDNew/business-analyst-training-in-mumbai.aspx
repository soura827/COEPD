<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true"
    CodeFile="business-analyst-training-in-mumbai.aspx.cs" Inherits="business_analyst_training_in_mumbai" %>
<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    Business Analyst Training | Business Analyst course in Mumbai
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="canonical" href="https://www.coepd.com/business-analyst-training-in-mumbai.html" />
    <meta name="description" content="COEPD is best in Business Analyst course in Mumbai. Many Business Analysts are nurtured and placed in MNCs" />
    <meta name="keywords" content="Business Analyst Training, Business Analyst Training in Mumbai, Business Analyst Online Training in Mumbai, Business Analyst Training Institute in Mumbai, BA Training in Mumbai, coepd, Business Analyst Workshop, Business Analyst Job Openings, Business Analyst Internship, BA Certification, business analyst course in mumbai, business analyst certification in mumbai." />
    <script src="js/jssor.slider.js" type="text/javascript"></script>
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
                        Business Analyst Certified course in Mumbai
                    </h1>     <p class="row">
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
                                <a href="img/Gallery/Mumbai1.JPEG" target="_blank">
                                    <img src="img/Gallery/M1.JPEG" alt="Mumbai center" /></a></div>
                            <div>
                                <a href="img/Gallery/Mumbai2.JPEG" target="_blank">
                                    <img src="img/Gallery/M2.JPEG" alt="Mumbai center" /></a></div>
                            <div>
                                <a href="img/Gallery/Mumbai3.JPEG" target="_blank">
                                    <img src="img/Gallery/M3.JPEG" alt="Mumbai center" /></a></div>
                            <div>
                                <a href="img/Gallery/picture4.JPEG" target="_blank">
                                    <img src="img/Gallery/M4.JPEG" alt="Mumbai center" /></a></div>  
                             <div>
                                <a href="img/Gallery/Mumbai1.JPEG" target="_blank">
                                    <img src="img/Gallery/M1.JPEG" alt="Mumbai center" /></a></div>
                                                                                 
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
                        <strong>Business Analyst</strong> is an evolving concept and with emergence and
                        booming of software industry, need of BAs raised. Business Analyst will understand
                        business needs, assess the impact of changes on the clients’ organisation. BA will
                        ect Contribute in a project through proper analysis and documenting requirements
                        according to industry standards. He facilitates the requirements nurturing to a
                        solution.</p>
                    <p>
                        <strong>Why choose COEPD for Business Analysis training in Mumbai?</strong>
                        <ul>
                            <li>COEPD is in Business Analyst Training based in Mumbai from last 5 years.</li>
                            <li>Workshop delivery by Real- Time Experts.</li>
                            <li>Pedagogy Methodology is Case Studies, Activities, Scenarios, Role – Plays through
                                interactive mode.</li>
                            <li>Updated material with real-life scenarios, business problems and issues.</li>
                            <li>Nurturing and Grooming support is provided post BA training to sustain and evolve
                                as successful BAs.</li>
                        </ul>
                    </p>
                    
                </div>
            </div>
            <div class="col-md-3 our-locations">
                <div id="location">
                    <h3>
                        Mumbai
                    </h3>
                    <iframe style="border: 4px solid #CCC" width="300" height="200" frameborder="0" scrolling="no"
                        marginheight="0" marginwidth="0" src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3769.779713554082!2d72.86340351490179!3d19.117317487064224!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3be7c99d1ecbef63%3A0x38eff2b3b317f9d0!2sCOEPD%20-%20Business%20Analyst%20Training%20In%20Mumbai!5e0!3m2!1sen!2sin!4v1597851512958!5m2!1sen!2sin">
                    </iframe>
                    <h5>
                        <strong>Center of Excellence for Professional Development</strong></h5>
                    
                    International Hotel, Marol Depo,<br />
                    P&S Corporate House Behind Tunga,<br /> 
                    M.I.D.C, Andheri East,<br />
                    Mumbai, Maharashtra, India - 4000930.<br />
                    <a href="tel:+ 91-7414917172"><i class="fa fa-phone" style="float: left;"></i>&nbsp; +91 74149 17172,</a><br />
                    <i class="fa fa-envelope" style="float: left;"></i>&nbsp; &nbsp;helpdesk@coepd.com
                </div>
                <uc2:Locations ID="Locations" runat="server" />
            </div>
        </div>
    </div>
    <!-- Inner page Content End -->
</asp:Content>