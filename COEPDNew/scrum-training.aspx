<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true"
    CodeFile="scrum-training.aspx.cs" Inherits="scrum_training" %>
<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    Certified IT Scrum Master (CITSM) Course | CITSM Course in Bangalore
</asp:Content>
<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="canonical" href="https://www.coepd.com/scrum-training.html" />
    <meta name="description" content="COEPD is a professional body of Certified IT Scrum Master (CITSM) Course in Bangalore, Hyderabad. It is formed to contribute in the area of Business Analyst. Course is specifically targeted to Scrum Masters. Personalized support by an Expert Faculty." />
    <meta name="keywords" content="Certified IT Scrum Master (CITSM) Training in Bangalore, Certification Training on PMP, Scrum, Agile and Kanban, CITSM Training, csmtraining, agiletraining, Scaling Agile, Scrum training in Marathahalli, Scrum training, Scrum training in Hyderabad, Scrum Master, Scrum Product Owner, Certified Scrum Master, Certified Scrum Product Owner, Certified Scrum master Training, Scrum Certification and Training, Scrum Training Courses." />
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
                    <h1 class="title-blue">Scrum Training for Business Analysis</h1>
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
                    <div id="slider1_container" style="position: relative; padding: 15px 0px; left: 0px; width: 809px; height: 150px; overflow: hidden;">
                        <!-- Loading Screen -->
                        <div u="loading" style="position: absolute; top: 0px; left: 0px;">
                            <div style="filter: alpha(opacity=70); opacity: 0.7; position: absolute; display: block; background-color: #000; top: 0px; left: 0px; width: 100%; height: 100%;">
                            </div>
                            <div style="position: absolute; display: block; background: url(../img/loading.gif) no-repeat center center; top: 0px; left: 0px; width: 100%; height: 100%;">
                            </div>
                        </div>
                        <!-- Slides Container -->
                        <div u="slides" style="cursor: move; position: absolute; left: 0px; top: 0px; width: 809px; height: 150px; overflow: hidden;">
                            <div>
                                <a href="img/Gallery/internship1.jpg" target="_blank">
                                    <img src="img/Gallery/t_internship1.jpg" alt="Internship" /></a>
                            </div>
                            <div>
                                <a href="img/Gallery/internship2.jpg" target="_blank">
                                    <img src="img/Gallery/t_internship2.jpg" alt="Internship" /></a>
                            </div>
                            <div>
                                <a href="img/Gallery/internship4.jpg" target="_blank">
                                    <img src="img/Gallery/t_internship4.jpg" alt="Internship" /></a>
                            </div>
                            <div>
                                <a href="img/Gallery/internship5.jpg" target="_blank">
                                    <img src="img/Gallery/t_internship5.jpg" alt="Internship" /></a>
                            </div>
                            <div>
                                <a href="img/Gallery/internship6.jpg" target="_blank">
                                    <img src="img/Gallery/t_internship6.jpg" alt="Internship" /></a>
                            </div>
                            <div>
                                <a href="img/Gallery/internship7.jpg" target="_blank">
                                    <img src="img/Gallery/t_internship7.jpg" alt="Internship" /></a>
                            </div>
                            <div>
                                <a href="img/Gallery/internship8.jpg" target="_blank">
                                    <img src="img/Gallery/t_internship8.jpg" alt="Internship" /></a>
                            </div>
                            <div>
                                <a href="img/Gallery/internship9.jpg" target="_blank">
                                    <img src="img/Gallery/t_internship9.jpg" alt="Internship" /></a>
                            </div>
                            <%--<div>
                                <a href="img/Gallery/internship10.jpg" target="_blank">
                                    <img src="img/Gallery/t_internship10.jpg" alt="Internship" /></a></div>
                            <div>
                                <a href="img/Gallery/internship11.jpg" target="_blank">
                                    <img src="img/Gallery/t_internship11.jpg" alt="Internship" /></a></div>--%>
                            <div>
                                <a href="img/Gallery/internship12.jpg" target="_blank">
                                    <img src="img/Gallery/t_internship12.jpg" alt="Internship" /></a>
                            </div>
                            <div>
                                <a href="img/Gallery/internship13.jpg" target="_blank">
                                    <img src="img/Gallery/t_internship13.jpg" alt="Internship" /></a>
                            </div>
                            <div>
                                <a href="img/Gallery/internship14.jpg" target="_blank">
                                    <img src="img/Gallery/t_internship14.jpg" alt="Internship" /></a>
                            </div>
                            <div>
                                <a href="img/Gallery/internship15.jpg" target="_blank">
                                    <img src="img/Gallery/t_internship15.jpg" alt="Internship" /></a>
                            </div>
                            <div>
                                <a href="img/Gallery/internship16.jpg" target="_blank">
                                    <img src="img/Gallery/t_internship16.jpg" alt="Internship" /></a>
                            </div>
                            <div>
                                <a href="img/Gallery/internship17.jpg" target="_blank">
                                    <img src="img/Gallery/t_internship17.jpg" alt="Internship" /></a>
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
                        <strong>Scrum is an Agile framework for completing complex projects. Scrum originally
                            was formalized for software development projects, but it works well for any complex,
                            innovative scope of work. The possibilities are endless. The Scrum framework is
                            deceptively simple.</strong>
                        <br />
                    </p>
                    <p>
                        <strong>Certified IT Scrum Master (CITSM) :</strong>
                        <br />
                        The Certified IT Scrum Master (CITSM) course is a two-day, entry-level course taught
                        by a Certified Scrum Trainer®. The CITSM course is designed to cover all the basics
                        of Scrum so you can begin to fulfill the Scrum Master role.
                    </p>
                    <p>
                        In the CITSM course, you will learn about:
                        <ul>
                            <li>Scrum basics and core values</li>
                            <li>How the Scrum framework compares to other methods, such as waterfall</li>
                            <li>How to identify when to use Scrum</li>
                            <li>A Scrum team’s three roles and responsibilities</li>
                            <li>Scrum meetings, including the Sprint Review, Sprint Retrospective and Release Planning</li>
                            <li>Sprint Backlog and Product Backlog</li>
                            <li>Scrum artifacts, including the Product Backlog, Sprint Backlog and Burndown Charts</li>
                        </ul>
                    </p>
                    <p>
                        <strong>Audience</strong><br />
                        The Professional Scrum Master course is specifically targeted to Scrum Masters ,
                        but the lessons are applicable to anyone in a role that supports a software development
                        team's efficiency, effectiveness, and continual improvement. If you are a manager
                        or a team leader responsible for the successful use and/or rollout of Scrum in a
                        project or enterprise, this course is likely to be a good fit.
                    </p>
                    <p>
                        <strong>Prerequisite</strong><br />
                        There is no formal prerequisite for this certification.However it is highly recommended
                        to a 2-day SMC Workshop provided by COEPD.
                    </p>
                    <p>
                        <strong>What are the benefits of a ScrumMaster certification?</strong> By earning
                        a Certified ScrumMaster certification you:
                        <ul>
                            <li>Expand your career opportunities by staying relevant and marketable across all industry
                                sectors adopting Agile practices.</li>
                            <li>Demonstrate to employers and peers your attainment of core Scrum knowledge.</li>
                            <li>Learn the foundation of Scrum and the scope of the Certified ScrumMaster’s role
                                from the best minds in Scrum.</li>
                            <li>Engage with a community of recognized Scrum experts who are committed to continuous
                                improvement.</li>
                        </ul>
                    </p>
                </div>
            </div>
            <div class="col-md-3 our-locations">
                <uc2:Locations ID="Locations" runat="server" />
            </div>
        </div>
    </div>
    <!-- Inner page Content End -->
</asp:Content>
