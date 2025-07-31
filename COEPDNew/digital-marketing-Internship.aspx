<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true" CodeFile="digital-marketing-internship.aspx.cs" Inherits="DM_Internship" %>

<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    internship for Digital marketing | Digital Marketing Internship in Hyderabad
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <link rel="canonical" href="https://www.coepd.com/digital-marketing-internship.html"/>
    <meta name="description" content="COEPD is the best institute to provide Digital Marketing Internship in Hyderabad. Great opportunity to work and grow in Digital Marketing industry." />
    <meta name="keywords" content="internship for Digital marketing, internship for Digital marketing in Hyderabad, digital marketing internship, seo internship, smm, digital marketing intern, digital marketing career, digital marketing jobs, seo executive" />
    <script src="js/jssor.slider.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpContent" Runat="Server">
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
                    <h1 class="title-blue">Digital Marketing Internship Programs
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
                                <a href="img/Gallery/picture1.jpg" target="_blank">
                                    <img src="img/Gallery/1.jpg" alt="Hyderabad center" /></a>
                            </div>
                            <div>
                                <a href="img/Gallery/picture2.jpg" target="_blank">
                                    <img src="img/Gallery/2.jpg" alt="Hyderabad center" /></a>
                            </div>
                            <div>
                                <a href="img/Gallery/picture3.jpg" target="_blank">
                                    <img src="img/Gallery/3.jpg" alt="Hyderabad center" /></a>
                            </div>
                            <div>
                                <a href="img/Gallery/picture4.jpg" target="_blank">
                                    <img src="img/Gallery/4.jpg" alt="Hyderabad center" /></a>
                            </div>
                            <div>
                                <a href="img/Gallery/picture5.jpg" target="_blank">
                                    <img src="img/Gallery/5.jpg" alt="Hyderabad center" /></a>
                            </div>
                            <div>
                                <a href="img/Gallery/picture6.jpg" target="_blank">
                                    <img src="img/Gallery/6.jpg" alt="Hyderabad center" /></a>
                            </div>
                            <div>
                                <a href="img/Gallery/picture7.jpg" target="_blank">
                                    <img src="img/Gallery/7.jpg" alt="Hyderabad center" /></a>
                            </div>
                            <div>
                                <a href="img/Gallery/picture8.jpg" target="_blank">
                                    <img src="img/Gallery/8.jpg" alt="Hyderabad center" /></a>
                            </div>
                            <div>
                                <a href="img/Gallery/picture9.jpg" target="_blank">
                                    <img src="img/Gallery/9.jpg" alt="Hyderabad center" /></a>
                            </div>
                            <div>
                                <a href="img/Gallery/picture11.jpg" target="_blank">
                                    <img src="img/Gallery/11.jpg" alt="Hyderabad center" /></a>
                            </div>
                            <div>
                                <a href="img/Gallery/picture12.jpg" target="_blank">
                                    <img src="img/Gallery/12.jpg" alt="Hyderabad center" /></a>
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
                     <div class="container" style="padding:35px;">
                    <strong>We are glad to announce  that in COEPD we have introduced Digital Marketing Internship Programs (Self sponsored) for 
                        professionals who want to have hands on experience.</strong>
                    <p>With associations with IT Companies, we are providing this program. Presently, this program is available in COEPD Hyderabad premises.</p>                    
                    <p>Digital Marketing industry is expanding to almost all the business domains across the world.  The elegance of digital marketing allows 
                        Geographical barriers to be wiped-off making all consumers and businesses globally potential customers and suppliers. It is being 
                        recognized for its ability to allow business to communicate and form a transaction anywhere and anytime. At COEPD, we provide finest 
                        Digital Marketing training.
                    </p>
                    <p>This internship is intelligently dedicated to our avid and passionate participants predominantly acknowledging and appreciating the fact 
                        that they are on the path of making a career in Digital Marketing discipline. This internship is designed to ensure that in addition to 
                        gaining the requisite theoretical knowledge, the readers gain sufficient hands-on practice and practical know-how to master the nitty-gritty of the 
                        Digital Marketing profession.  More than a training institute, COEPD today stands differentiated as a mission to help you "Build your dream career" - COEPD way.
                    </p>
                    <strong>Pre - Requisites:</strong>
                    <ul>
                        <li>Should be Graduate</li>
                        <li>Basic Communication Skills</li>
                        <li>Basic Computer awareness Skills</li>
                    </ul>
                    <strong>What you will do as an Intern</strong>
                    <ul>
                        <li>Undergo training for required courses</li>
                        <li>Work on assigned projects</li>
                        <li>Understand client requirements</li>
                        <li>Develop Digital Marketing Strategies as per client requirements.</li>
                        <li>Implement Digital Marketing Techniques.</li>
                        <li>Document Analytics Reports.</li>
                        <li>Analyze campaign outcomes</li>&nbsp
                        <li><b>"Complete one International Certification" - expense covered in Internship Fees.</b></li>
                    </ul>
                    <strong>Introduction</strong><br />
                         <ul>
                             <li>Understanding a company and management</li>
                             <li>What is marketing?</li>
                             <li>E-commerce</li>
                             <li>What is digital marketing </li>
                             <li>How digital marketing is different from traditional marketing</li>
                             <li>ROI - traditional marketing Vs digital marketing</li>
                             <li>Understanding marketing process</li>
                             <li>Benefits of digital marketing?</li>
                             <li>Comparing digital marketing with traditional marketing</li>
                             <li>Latest digital marketing trends</li>
                         </ul>
                    <strong>Website Planning and Designing</strong>
                    <ul>
                       <li>Internet</li>
                        <li>Website</li>
                        <li>Portal</li>
                        <li>Domain</li>
                        <li>Web server</li>
                       <li>Hosting</li>
                        <li>Website architecture</li>
                        <li>Website designing basics</li>
                        <li>Different types of websites by purpose of function</li>
                        <li>Personal websites</li>
                        <li>Business websites</li>
                        <li>Information websites</li>
                        <li>Different types of websites by building method</li>
                        <li>Static websites</li>
                        <li>Dynamic websites</li>
                        <li>Types of websites</li>
                        <li>Domain name suggestions</li>
                        <li>Behavioral flow designing</li>
                        <li>WordPress website designing</li>
                        <li>Building website using CMS in class</li>
                     
                    </ul>
                          </div>
                    <div class="container" style="padding: 35px;">
                        <h2>Highlights of the course</h2><br />           
                        <ul class="nav nav-pills tab-size">
                            <li class="active"><a data-toggle="pill" href="#home">SEO</a></li>
                            <li><a data-toggle="pill" href="#menu1">SEM</a></li>
                            <li><a data-toggle="pill" href="#menu2">SMO</a></li>
                            <li><a data-toggle="pill" href="#menu3">SMM</a></li>
                            <li><a data-toggle="pill" href="#menu4">Email Marketing</a></li>
                            <li><a data-toggle="pill" href="#menu5">Google Analytics</a></li>
                            <li><a data-toggle="pill" href="#menu6">Inbound Marketing</a></li>
                            <li><a data-toggle="pill" href="#menu7">Online Reputation Management</a></li>
                           <%-- <li><a data-toggle="pill" href="#menu8">Google AdSense</a></li>--%>
                            <li><a data-toggle="pill" href="#menu9">Affiliate Marketing</a></li>
                            <li><a data-toggle="pill" href="#menu10">Ecommerce marketing</a></li>
                            <li><a data-toggle="pill" href="#menu11">Mobile Marketing</a></li>
                            <li><a data-toggle="pill" href="#menu12">Content Marketing</a></li>
                             <li><a data-toggle="pill" href="#menu13">Internet Marketing Strategy</a></li>
                            <li><a data-toggle="pill" href="#menu14">Lead Generation</a></li>
                             <li><a data-toggle="pill" href="#menu15">Tools</a></li>
                           
                        </ul>
                        <div class="tab-content">
                            <div id="home" class="tab-pane fade in active">
                                <h2 class="title-blue">SEO Training</h2>
                                <strong>Search Engine Optimization</strong> <br />
                                <ul>
                                    <li>Introduction</li>
                                    <li>What is SERP?</li>
                                    <li>Importance of SEO in digital marketing</li>
                                    <li>Search engine Vs directory</li>
                                    <li>Major search engines Vs directories</li>
                                    <li>Page rank</li>
                                    <li>Sandbox effect</li>
                                    <li>Different types of search engines</li>
                                    <li>What are search engines?</li>
                                    <li>Search engines history</li>
                                    <li>How google search engine works?</li>
                                    <li>Major functions of a search engine</li>
                                    <li>Competition analysis</li>
                                    <li>Keywords analysis</li>
                                    <li>SEO best practices</li>
                                    <li>SEO checklist</li>
                                    <li>On page</li>
                                    <li>Off page</li>
                                    <li>Local SEO</li>
                                    <li>Google algorithms</li>
                                    <li>Recovery process</li>
                                    <li>SEO reporting</li>
                                    <li>Disadvantages of SEO</li>
                                </ul> 
                                
                            </div>
                            <div id="menu1" class="tab-pane fade">
                                <h2 class="title-blue">SEM Training</h2>


                                <strong>Search Engine Marketing</strong>
                                <ul>
                                    <li>Campaign creation</li>
                                    <li>Google Adwords</li>
                                    <li>Website optimizer</li>
                                    <li>Multi user access</li>
                                    <li>Bing ads</li>
                                    <li>Google Adsence</li>
                                    <li>Online display advertising</li>
                                    <li>Reports</li>
                                </ul>  
                            </div>
                            <div id="menu2" class="tab-pane fade">
                                <h2 class="title-blue">SMO Training</h2>

                                    <strong>Social media optimization</strong> 
                                <ul>
                                    <li>Overview</li>
                                    <li>Social media strategy</li>
                                    <li>Facebook</li>
                                    <li>Twitter</li>
                                    <li>LinkedIn</li>
                                    <li>Instagram</li>
                                    <li>Youtube</li>
                                    <li>Pinterest</li>
                                    <li>Google+</li>
                                    <li>Tumblr</li>
                                    <li>Viadeo</li>
                                    <li>Meetup</li>
                                    <li>Reddit</li>
                                    <li>Flickr</li>
                                    <li>Vk</li>
                                    <li>Myspce</li>
                                    <li>Slidshare</li>
                                    <li>Scribd</li>
                                    <li>Stumble upon</li>
                                    <li>Digg</li>
                                    <li>Delicious</li>
                                    <li>Blogging</li>
                                    <li>Forums</li>
                                </ul> 

                            </div>
                            <div id="menu3" class="tab-pane fade">
                                <h2 class="title-blue">SMM Training </h2>


                                
                            
                                <strong>Social Media Marketing</strong> 
                                <ul>
                                    <li>Introduction</li>
                                    <li>Facebook Marketing</li>
                                    <li>Twitter Marketing</li>
                                    <li>Linkedin Marketing</li>
                                    <li>Youtube Marketing</li>
                                    <li>Pinterest Marketing</li>
                                    <li>Instagram Marketing</li>

                                </ul>  
                            </div>
                            <div id="menu4" class="tab-pane fade">
                                <h2 class="title-blue">Email marketing training </h2>
                                <strong>Email marketing</strong>  
                                <ul>
                                    <li>Overview</li>
                                    <li>Email news letters</li>
                                    <li>What to write?</li>
                                    <li>How to write?</li>
                                    <li>Setting up email marketing account</li>
                                    <li>Types of emails</li>
                                    <li>Types of email marketing campaigns</li>
                                    <li>What are auto responders?</li>
                                    <li>Email scheduling</li>
                                    <li>Web forms and list creation</li>
                                    <li>OPT IN list</li>
                                    <li>Double OPT IN list</li>
                                    <li>E-Mail template design parameters</li>
                                    <li>Spam words not to be used in e-mail templates</li>
                                    <li>E-Mail reporting metrics</li>
                                    <li>Open rate calculations</li>
                                    <li>Click rate</li>
                                    <li>Unique opens</li>
                                    <li>Unique click</li>
                                    <li>Hard bounce</li>
                                    <li>Soft bounce</li>
                                    <li>Email verifier</li>
                                    <li>Email hunter</li>
                                    <li>A/B testing method</li>
                                    <li>Tricks to land in inbox instead of spam</li>
                                    <li>Best practices for sending bulk mails</li>
                                    <li>Email marketing software’s</li>
                                    <li>Reports</li>
                               </ul>
                                <%--<ul>
                                    <li>What is Email Marketing</li>
                                    <li>Email Newsletters</li>
                                    <li>Types of email marketing
                                        <ul>
                                            <li>Transactional Email</li>
                                            <li>Direct emails</li>
                                            <li>Mobile email marketing</li>
                                        </ul>
                                    </li>
                                    <li>How is Email Marketing important to DM?</li>
                                    <li>Cost-effectiveness</li>
                                    <li>The effects are easily measured</li>
                                    <li>Easy to use</li>
                                    <li>Targeted Marketing Opportunities</li>
                                    <li>More Personal and Targeted than Social Media</li>
                                    <li>Data-Driven & Measurable</li>
                                    <li>Permission to Contact Prospects & Clients</li>
                                    <li>Stay Top of Mind</li>
                                    <li>Generate Sales</li>
                                    <li>Cost Effective & Affordable</li>
                                    <li>Why Email Marketing
                                        <ul>
                                            <li>Email has larger reach</li>
                                            <li>Email delivers your message</li>
                                            <li>Email drives conversions</li>
                                        </ul>
                                    </li>
                                    <li>E-mail Scheduling</li>
                                    <li>A/B Testing
                                        <ul>
                                            <li>What Is A/B Testing?</li>
                                            <li>How A/B Testing Works?</li>
                                            <li>Why You Should A/B Test?</li>
                                        </ul>
                                    </li>
                                    <li>A/B Testing Process</li>
                                    <li>A/B Testing & SEO</li>
                                    <li>Benefits of email marketing</li>
                                    <li>Basic terminology in email marketing
                                        <ul>
                                            <li>Write a good subject line</li>
                                            <li>Personalize your emails</li>
                                            <li>Make your emails clear first and catchy second</li>
                                            <li>Keep your subject line related to your copy</li>
                                            <li>Keep it relevant</li>
                                            <li>Write all of your email copy in the second person</li>
                                            <li>Showcase the benefits rather than the features of your offer</li>
                                            <li>Keep it short</li>
                                            <li>Let your personality shine</li>
                                            <li>Don’t spam</li>
                                        </ul>
                                    </li>
                                    <li>Email Marketing Software</li>
                                    <li>Building email marketing strategy</li>
                                    <li>Building subscriber lists</li>
                                    <li>Designing Newsletters</li>
                                    <li>Types of Campaigns
                                        <ul>
                                            <li>Newsletter Email</li>
                                            <li>Catalog and Video Email</li>
                                            <li>Press Release Email</li>
                                            <li>Invitation and Survey Email</li>
                                            <li>Thank-You Email</li>
                                        </ul>
                                    </li>
                                    <li>Reports and Analytics</li>
                                </ul>--%>
                            </div>
                            <div id="menu5" class="tab-pane fade">
                                <h2 class="title-blue">Google Analytics Training </h2>
                                <strong>Google Analytics Training Topics
                                    <br />
                                </strong>
                                <ul>
                                    <li>Purpose of website analytics</li>
                                    <li>Tools for website analytics</li>
                                    <li>Installing Google Analytics code in website</li>
                                    <li>Audience Report</li>
                                    <li>Traffic Reports</li>
                                    <li>Behavior Reports</li>
                                    <li>Conversion Tracking</li>
                                    <li>Segmentation and Filters</li>
                                </ul>
                            </div>
                            <div id="menu6" class="tab-pane fade">
                            <h2 class="title-blue">Inbound Marketing Training </h2>
                                 <strong>Inbound marketing</strong>  
                                <ul>
                                    <li>Overview</li>
                                    <li>A/B testing method</li>
                                    <li>Target audience</li>
                                    <li>Strategy</li>
                                    <li>Creating landing pages</li>
                                    <li>Hub spot</li>
                                </ul> 
                          </div>
                            <div id="menu7" class="tab-pane fade">
                            <h2 class="title-blue">Online Reputation Management Training </h2>
                                <strong>Online Reputation Management</strong>  
                                <ul>
                                    <li>Overview</li>
                                    <li>Different ways to create positive brand image online</li>
                                    <li>How to deal with negative Reviews</li>
                                    <li>How to engage with customers</li>
                                    <li>Use of ORM</li>
                                    <li>Areas to analyze ORM</li>
                                    <li>Tools for managing</li>
                                    <li>ORM case studies</li>
                                </ul>  


                        </div>
                           <%-- <div id="menu8" class="tab-pane fade">
                            <h2 class="title-blue">Google AdSense Training </h2>
                            <strong>Google AdSense Training Topics
                                <br />
                            </strong>
                                <ul>
                                    <li>What is AdSense?</li>
                                    <li>Types of Bidding</li>
                                    <li>Implementing Ads in a Website</li>
                                </ul>
                        </div>--%>
                            <div id="menu9" class="tab-pane fade">
                            <h2 class="title-blue">Affiliate Marketing Training </h2>

                                <strong>Affiliate marketing</strong> 
                                <ul>
                                    <li>Overview</li>
                                    <li>How to create affiliate account</li>
                                    <li>How affiliate marketing works</li>
                                    <li>Different ways to do affiliate marketing</li>
                                    <li>Components present in affiliate works</li>
                                    <li>Affiliate marketing secrets</li>
                                    <li>How to increase ROI of business using affiliate marketing</li>
                                    <li>How your trainer makes money in affiliate marketing</li>
                                    <li>Costing techniques</li>
                                    <li>Attribution models</li>
                                    <li>How to identify publishers</li>
                                    <li>How to recruit publishers</li>
                                    <li>How to retain publishers</li>
                                    <li>What types of products are to be assigned to publishers</li>
                                    <li>How to identify merchants</li>
                                    <li>Types of affiliate programs</li>
                                    <li>Getting approved</li>
                                    <li>Payment</li>
                                    <li>Affiliate marketing tools</li>
                                </ul>
                        </div>
                            <div id="menu10" class="tab-pane fade">
                            <h2 class="title-blue">E-Commerce marketing Training </h2>
                            <strong>E-Commerce marketing Training Topics
                                <br />
                            </strong>
                                <ul>
                                    <li>What is e-commerce</li>
                                    <li>Top ecommerce websites around the world</li>
                                    <li>Ecommerce scenario in India</li>
                                    <li>How to do seo of an e commerce website?</li>
                                    <li>Why you need a solid ecommerce marketing strategy</li>
                                    <li>Formulating right ecommerce marketing strategy</li>
                                    <li>Using affiliate marketing to promote your</li>
                                     <li>E-commerce business</li>
                                     <li>Casestudies on e-commerce websites</li>                               
                                </ul>
                        </div>
                             <div id="menu11" class="tab-pane fade">
                            <h2 class="title-blue"> Mobile marketing </h2>

                                <strong>Mobile Marketing</strong>   
                                <ul>
                                    <li>Overview</li>
                                    <li>Mobile marketing and social media</li>
                                    <li>Mobile marketing measurement and analytics</li>
                                    <li>Fundamentals of mobile marketing</li>
                                    <li>Key industry terminology</li>
                                    <li>Creating mobile website through WordPress</li>
                                    <li>SMS marketing</li>
                                    <li>Whatsapp marketing</li>
                                    <li>Using tools to create mobile websites</li>
                                    <li>Using tools to create mobile app</li>
                                    <li>Mobile app management</li>
                                    <li>Creating mobile ads</li>
                                    <li>Content marketing on mobile</li>
                                    <li>Mobile strategy-segmentations option targeting and differentiation</li>
                                    <li>Uploading mobile app in android and iOS</li>
                                </ul>  
                        </div>
                            <div id="menu12" class="tab-pane fade">
                            <h2 class="title-blue">Content Marketing Training </h2>
                            <strong>Content marketing</strong>   
                                <ul>
                                    <li>Overview</li>
                                    <li>Content marketing strategy</li>
                                    <li>Types of content with examples</li>
                                    <li>How to write great compelling content</li>
                                    <li>Keyword research for content ideas</li>
                                    <li>Optimizing content for search engines</li>
                                    <li>Discussing authority blog</li>
                                    <li>Steps towards developing authority blog</li>
                                    <li>Ways to monetizing authority blog</li>
                                    <li>How to market your content</li>
                                    <li>Understanding second customer</li>
                                    <li>Importance of second customer</li>
                                    <li>How to increase second customer</li>
                                    <li>Understanding online influencers</li>
                                    <li>Different ways to connect with online influencers</li>
                                    <li>Unique ways to write magnetic headlines</li>
                                    <li>Different examples of magnetic headlines</li>
                                    <li>How to increase opt-in email list with content marketing with examples</li>
                                    <li>Case study on content marketing</li>
                                    <li>Grammerly</li>

                                </ul> 
                        </div>
                            <div id="menu13" class="tab-pane fade">
                            <h2 class="title-blue">Internet marketing strategy</h2>
                            <strong>Internet marketing strategy training topics </strong>
                                 <ul>
                                   <li>Setting up strategy for a project</li>
                                     <li>Project report</li>
                                     <li>Swot analysis</li>
                                     <li>Analysis of KPI's</li>
                               </ul>                             
                        </div>
                             <div id="menu14" class="tab-pane fade">
                            <h2 class="title-blue">Lead Generation</h2>
                            <strong>Lead Generation</strong>
                                 <ul>
                                        <li> Understanding lead generation for business</li>
                                        <li>Why lead generation is important</li>
                                        <li>Understanding landing pages</li>
                                        <li>Understanding thank-you page</li>
                                        <li>Landing page vs website</li>
                                        <li>Types of landing pages</li>
                                        <li>What is A/B testing?</li>
                                        <li>Converting leads into sales</li>
                                        <li>Creating lead nurturing strategy</li>
                                        <li>Understanding lead funnel</li>
                                        <li>Steps in leads nurturing</li>
                                 
                               </ul>                             
                        </div>
                             <div id="menu15" class="tab-pane fade">
                            <h2 class="title-blue">Tools</h2>
                            <strong>Tools </strong>
                                 <ul>                                   
                                     <li>Seo tools</li>
                               </ul>                             
                        </div>
                              <b>Program can be tailor made to 2 months, 3 months, 6 months and 1 year.</b>
                        </div>
                    </div>
                        
                </div>
                </div>
                <div class="col-md-3 our-locations">
                    <uc2:Locations ID="Locations" runat="server" />
                </div>
            </div>
        </div>
        <!-- Inner page Content End -->
</asp:Content>