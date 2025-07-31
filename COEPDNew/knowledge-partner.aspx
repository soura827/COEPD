<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true" CodeFile="knowledge-partner.aspx.cs" Inherits="knowledge_partner" %>

<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    Knowledge Partner
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="canonical" href="https://www.coepd.com/knowledge-partner.html" />
    <meta name="description" content="knowledge partner with coepd on Business Analysis." />
    <meta name="keywords" content="business analyst knowledge, knowledge of business analyst, BA knowledge" />
    
    <script src="js/jssor.slider.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpContent" Runat="Server">
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
                        knowledge partner
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
                            <div>
                                <a href="img/Gallery/LBS-001.jpg" target="_blank">
                                    <img src="img/Gallery/LBS-001.jpg" alt="LBS-001" /></a></div>
                            <div>
                                <a href="img/Gallery/LBS-002.png" target="_blank">
                                    <img src="img/Gallery/LBS-002.png" alt="LBS-002" /></a></div>
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
                        Centre of Excellence for Professional development is committed to spread the awareness, improve on the efficiency, reskill the Business analysis contributions towards successful implementation of the IT projects.
                    </p>
                    <p>As a part of our commitment we have an initiative to induce business analysis skills to the budding professionals while they groom themselves in their management studies. COEPD has raised the standards of learning training and inducing knowledge through various techniques and implementing the skills during practice of Business Analysis. We stand tall with 800+ batches,5000+ participants,100+trainers and 10000+ practitioners.</p>
                    <p>We are training vendors to multiple corporate houses like Reliance Industry ltd, Volkswagen, DSL Satyam, Royal Bank of Scotland, DST World Wide Services, HP, Avenir, TCS, Iinterchange, Sysnik IT Solutions, Synchrony Financial, First American Financial Corporation, Verizon, Genpact, KPIT Technologies Ltd, Sphinax info systems etc.</p>
                    <p>We provide staffing, consulting and Hr services to MNC’s and we provide BA skilled resources to IT companies. We are also recruitment partners for various IT companies and fulfil their Hr requirements by conducting campus interviews.</p>
                    <p>With all the above qualifications we announce that we can be knowledge partners for academic institutions, B-schools and Universities. We welcome all organizations to collaborate with us on Business analysis space and improve their student placement opportunities.</p>
                </div>
            </div>
            <div class="col-md-3 our-locations">
                <uc2:Locations ID="Locations" runat="server" />
            </div>
        </div>
    </div>
    <!-- Inner page Content End -->
</asp:Content>