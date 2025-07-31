<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true" CodeFile="business-analyst-training-internships.aspx.cs" Inherits="business_analyst_training_internships" %>
<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    Business Analyst Internships | Business Analyst Internship & Course
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="canonical" href="https://www.coepd.com/business-analyst-training-internships.html" />
    <meta name="description" content="COEPD believes that practice makes Participant perfect. So this is supported by Online Exams, Mock Interviews, and Internship program. We also offer On Job Support to Business Analyst Aspirants." />
    <meta name="keywords" content="Business Analyst Internship, Business Analyst Internship & training, BA Internship, BA Internship Program, Business Analyst Internship Program, coepd Internship program, Business Analyst Skills Assessment, BA skills Assessment." />
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
                        Business Analyst internship| BA internship
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
                                <a href="img/Gallery/internship1.jpg" target="_blank">
                                    <img src="img/Gallery/t_internship1.jpg" alt="Internship" /></a></div>
                            <div>
                                <a href="img/Gallery/internship2.jpg" target="_blank">
                                    <img src="img/Gallery/t_internship2.jpg" alt="Internship" /></a></div>
                            <div>
                                <a href="img/Gallery/internship4.jpg" target="_blank">
                                    <img src="img/Gallery/t_internship4.jpg" alt="Internship" /></a></div>
                            <div>
                                <a href="img/Gallery/internship5.jpg" target="_blank">
                                    <img src="img/Gallery/t_internship5.jpg" alt="Internship" /></a></div>
                            <div>
                                <a href="img/Gallery/internship6.jpg" target="_blank">
                                    <img src="img/Gallery/t_internship6.jpg" alt="Internship" /></a></div>
                            <div>
                                <a href="img/Gallery/internship7.jpg" target="_blank">
                                    <img src="img/Gallery/t_internship7.jpg" alt="Internship" /></a></div>
                            <div>
                                <a href="img/Gallery/internship8.jpg" target="_blank">
                                    <img src="img/Gallery/t_internship8.jpg" alt="Internship" /></a></div>
                            <div>
                                <a href="img/Gallery/internship9.jpg" target="_blank">
                                    <img src="img/Gallery/t_internship9.jpg" alt="Internship" /></a></div>
                            <%--<div>
                                <a href="img/Gallery/internship10.jpg" target="_blank">
                                    <img src="img/Gallery/t_internship10.jpg" alt="Internship" /></a></div>
                            <div>
                                <a href="img/Gallery/internship11.jpg" target="_blank">
                                    <img src="img/Gallery/t_internship11.jpg" alt="Internship" /></a></div>--%>
                            <div>
                                <a href="img/Gallery/internship12.jpg" target="_blank">
                                    <img src="img/Gallery/t_internship12.jpg" alt="Internship" /></a></div>
                            <div>
                                <a href="img/Gallery/internship13.jpg" target="_blank">
                                    <img src="img/Gallery/t_internship13.jpg" alt="Internship" /></a></div>
                            <div>
                                <a href="img/Gallery/internship14.jpg" target="_blank">
                                    <img src="img/Gallery/t_internship14.jpg" alt="Internship" /></a></div>
                            <div>
                                <a href="img/Gallery/internship15.jpg" target="_blank">
                                    <img src="img/Gallery/t_internship15.jpg" alt="Internship" /></a></div>
                            <div>
                                <a href="img/Gallery/internship16.jpg" target="_blank">
                                    <img src="img/Gallery/t_internship16.jpg" alt="Internship" /></a></div>
                            <div>
                                <a href="img/Gallery/internship17.jpg" target="_blank">
                                    <img src="img/Gallery/t_internship17.jpg" alt="Internship" /></a></div>
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
                    <strong>We are glad to announce BA Internship Programs (Self sponsored) for professionals
                        who want to have hands on experience . </strong>
                    <p>
                        With associations with IT Companies, we are able to provide this program. Presently
                        ,this program is available in Hyderabad & Pune locations.
                    </p>
                    <p>
                        This internship is intelligently dedicated to our avid and passionate participants predominantly acknowledging and appreciating the fact that they are on the path of making a career in Business Analyst discipline. 
                       This internship is designed to ensure that in addition to gaining the requisite theoretical knowledge, the readers gain sufficient hands-on practice and practical know-how to master the nitty-gritty of the Business Analyst profession.  
                       More than a training institute, COEPD today stands differentiated as a mission to help you "Build your dream career" - COEPD way.
                    </p>
                    <strong>Pre - Requisites: </strong>
                    <ul>
                        <li>Should be Graduate</li>
                        <li>Basic Communication Skills</li>
                        <li>BA Skills.</li>
                    </ul>
                    <strong>Procedure for Enrollment:</strong>
                    <p>
                        Will have take an exam on BA Skills. Upon satisfactory BA Concept Skills, Candidate
                        can be enrolled
                    </p>
                    <strong>Duration of Program</strong>
                    <ul class="hand-bullets">
                        <li>1 month </li>
                        <li>5 days a week</li>
                        <%--<li>8.30 am to 1.30 pm</li>--%>
                    </ul>
                    <strong>What you will do, as an Intern?</strong>
                    <ul class="hand-bullets">
                        <li>Working experience on Real Time Cases</li>
                        <li>Gain hands on Experience in Documenting
                            <ul>
                                <li>BRD</li>
                                <li>Functional</li>
                                <li>Spec</li>
                                <li>SRS</li>
                                <li>RTM</li>
                            </ul>
                        </li>
                        <li>Exposure on Documents like
                            <ul>
                                <li>Project Closure Document</li>
                                <li>Client Project Acceptance Document</li>
                                <li>Fit for support Document</li>
                                <li>Application Design Document</li>
                                <li>Project Charter</li>
                            </ul>
                        </li>
                        <li>Working on Agile - Scrum
                            <ul>
                                <li>Product Owner Role </li>
                                <li>One Project Implementation</li>
                            </ul>
                        </li>
                        <li>Tools usage
                            <ul>
                                <li>UML Tools</li>
                                <li>Wireframes Tools</li>
                                <li>Documentation and Presentation Tools</li>
                                <li>Reporting Tools</li>
                            </ul>
                        </li>
                        <li>Databases Exposure on
                            <ul>
                                <li>SQL/PLSQL</li>
                                <li>RDBMS</li>
                                <li>Database Design</li>
                                <li>Data Model</li>
                                <li>Data Mapping</li>
                            </ul>
                        </li>
                        <li>Testing experience on
                            <ul>
                                <li>Testing Types</li>
                                <li>UAT preparation</li>
                            </ul>
                        </li>
                        <li>Complimentary Sessions on
                            <ul>
                                <li>Power BI</li>
                                <li>Tableau</li>
                            </ul>
                        </li>
                        <li>Interactions with present Industry BA professionals</li>
                        <li>Development Team Interaction
                            <ul>
                                <li>Explaining user requirements to Developers</li>
                                <li>Review Functionality</li>
                                <li>Handling Change request</li>
                                <li>Testing and Feedback</li>
                            </ul>
                        </li>
                        <li>Hands on working knowledge on latest Project in resume
                            <ul>
                                <li>Project explanation</li>
                                <li>Workflows, Process flow, BPM</li>
                                <li>Project team members</li>
                                <li>BA contribution and Implementation</li>
                            </ul>
                        </li>
                        <li>Understanding BA Strategy
                            <ul>
                                <li>Stakeholder Analysis</li>
                                <li>Elicitation techniques </li>
                                <li>Business process Model</li>
                                <li>Requirements Management</li>
                                <li>Requirements Prioritization and Validation</li>
                                <li>UML diagrams</li>
                                <li>Documents </li>
                                <li>Tools used in Project</li>
                                <li>Communication Channels</li>
                                <li>UAT facilitation</li>
                            </ul>
                        </li>
                        <li>Additional Activities
                            <ul>
                                <li>Revision of BA Concepts</li>
                                <li>Daily One Exam</li>
                                <li>Presentations</li>
                                <li>Blog</li>
                                <li>Forums</li>
                                <li>Listening Skills lab</li>
                                <li>Email Etiquette</li>
                            </ul>
                        </li>
                        <li>Interview Ready
                            <ul>
                                <li>Resume Preparation</li>
                                <li>Projects Selections</li>
                                <li>Mock Interviews</li>
                            </ul>
                        </li>
                    </ul>
                    <p>
                        With associations with IT Companies, we are able to provide this program. Presently,
                        this program is available in Hyderabad & Pune locations.</p>
                </div>
            </div>
            <div class="col-md-3 our-locations">
                <uc2:Locations ID="Locations" runat="server" />
            </div>
        </div>
    </div>
    <!-- Inner page Content End -->
</asp:Content>