<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true"
    CodeFile="business-analyst-training-in-pune.aspx.cs" Inherits="business_analyst_training_in_pune" %>
<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    Business Analyst course | Business Analyst course in PUNE
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="canonical" href="https://www.coepd.com/business-analyst-training-in-pune.html" />
    <meta name="description" content="COEPD is a good Business Analyst course online and classroom in Pune. Many Professionals got trained and placed as Business Analysts." />
    <meta name="keywords" content="Business Analyst Training, Business Analyst Training in Pune, Business Analyst Training Institute in Pune, BA Training in Pune, coepd, coepd BA Training, Business Analyst Workshop, Business Analyst Job Openings, Business Analyst Internship, Business Analyst Online exams, BA Certification, business analyst course in pune, business analyst certification in pune" />
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
                        Business Analyst course online and classroom in pune
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
                            <div><a href="img/Gallery/pune1.jpg" target="_blank"><img src="img/Gallery/tpune1.jpg" alt="Pune center" /></a></div>
                            <div><a href="img/Gallery/pune2.jpg" target="_blank"><img src="img/Gallery/tpune2.jpg" alt="Pune center" /></a></div>
                            <div><a href="img/Gallery/pune3.jpg" target="_blank"><img src="img/Gallery/tpune3.jpg" alt="Pune center" /></a></div>
                            <div><a href="img/Gallery/pune4.jpg" target="_blank"><img src="img/Gallery/tpune4.jpg" alt="Pune center" /></a></div>
                            <div><a href="img/Gallery/pune5.jpg" target="_blank"><img src="img/Gallery/tpune5.jpg" alt="Pune center" /></a></div>
                            <div><a href="img/Gallery/pune6.jpg" target="_blank"><img src="img/Gallery/tpune6.jpg" alt="Pune center" /></a></div>
                            <div><a href="img/Gallery/pune7.jpg" target="_blank"><img src="img/Gallery/tpune7.jpg" alt="Pune center" /></a></div>
                            <div><a href="img/Gallery/pune8.jpg" target="_blank"><img src="img/Gallery/tpune8.jpg" alt="Pune center" /></a></div>
                            <div><a href="img/Gallery/pune9.jpg" target="_blank"><img src="img/Gallery/tpune9.jpg" alt="Pune center" /></a></div>
                            <div><a href="img/Gallery/pune10.jpg" target="_blank"><img src="img/Gallery/tpune10.jpg" alt="Pune center" /></a></div>
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
                        <script>
                            jssor_slider1_starter('slider1_container');
                        </script>
                    </div>
                    <p>
                        <strong>Business Analyst Role in Software Industry -</strong>Business Analysis is
                        not new concept, but with emergence and booming of software industry, need of BAs
                        raised. BA need to be part of understanding business needs, assessing the impact
                        of those changes on the clients’ organisation through proper analysis and documenting
                        requirements according to industry standards; which becomes the vital document in
                        the event of developing the clients need into application.
                    </p>
                    <h4>
                        Why BA Training with COEPD, Pune
                    </h4>
                    <ul>
                        <li>Our course curriculum is a hard work of ground work done by our expertise considering
                            IIBA CBAP BABOK standards. </li>
                        <li>Latest Industrial trends and feedbacks from both BA professions and people inspiring
                            to get into BA, Real time case studies. </li>
                        <li>Faculty has vast experience in working in various industries and has in-depth knowledge
                            of Business Analysis. </li>
                    </ul>
                    <h4>
                        Training highlights
                    </h4>
                    <ul>
                        <li>Interactive Learning at Learners convenience.</li>
                        <li>Industry Savvy Trainers.</li>
                        <li>Learn Right from Your Place – Pune.</li>
                        <li>Updated Curriculum.</li>
                        <li>Support after Training.</li>
                        <li>Resume Preparation.</li>
                        <li>Guidance provided for International BA Certifications.</li>
                        <li>Interview Assistance.</li>
                    </ul>
                    <h4>
                        BA Training Concentration by COEPD, Pune
                    </h4>
                    <ul>
                        <li><strong>Business Requirements Gathering -</strong> How to elicit, analyze and write
                            effective business requirements, project scope, functional and non functional specifications
                            utilizing the UML methodology and Use Cases. Business Analysis training in Pune
                            shall also cover techniques of facilitating JAD sessions. </li>
                        <li><strong>Documentation Skills -</strong> Document unambiguous and complete requirements
                            that are cover the scope and capture the spirit of the project. </li>
                        <li><strong>Use Cases and UML -</strong> Create and implementing effective use cases
                            and UML models for scope, business requirements, functional specifications and design.
                        </li>
                        <li><strong>Requirements Validation and Testing -</strong> Learn and plan functional
                            and usability testing at the business level and craft essential elements to document
                            that planning. As the end user test the implementation of the requirements including
                            assessing the product for stakeholder satisfaction. </li>
                    </ul>
                </div>
            </div>
            <div class="col-md-3 our-locations">
                <div id="location">
                    <h3>
                        Pune
                    </h3>
                   <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d236.46710390438625!2d73.80184246524698!3d18.507485561097745!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3bc2bfb6b6abee15%3A0xf60f9720b95207c1!2sBusiness+Analyst+Training+in+Pune+-+COEPD!5e0!3m2!1sen!2sin!4v1466570313096" width="300" height="250" frameborder="0" style="border:0" allowfullscreen></iframe>
                </div>
                <h5>
                    <strong>Center of Excellence for Professional Development</strong></h5>
                Office No: 301, 3rd Floor,
                <br />
                Walchand House Happy Colony Lane,<br />
                1, Warje Malwadi Road,<br />
                Kothrud,
                <br />
                Pune, Maharashtra, India.<br />
                Pin: 411 038<br />
              <a href="tel:+ 91-7722037493">  +91 77220 37493.</a><br />
                helpdesk@coepd.com.
                <uc2:Locations ID="Locations" runat="server" />
            </div>
        </div>
    </div>
    <!-- Inner page Content End -->
</asp:Content>