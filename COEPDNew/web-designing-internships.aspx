<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true" CodeFile="web-designing-internships.aspx.cs" Inherits="WebDesigning_Internships" %>

<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>

<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    internship for web Design | Web Designing Internship in Hyderabad
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
     <link rel="canonical" href="https://www.coepd.com/web-designing-internships.html" />
    <meta name="description" content="Internship on web designing makes a developer perfect. COEPD provide web designing internship in Hyderabad to help participants perfect in all areas.At COEPD, we provide finest web designing technology covering Photoshop, HTML, CSS, HTML5, CSS3, JavaScript, Boot Strap, and JQuery." />
    <meta name="keywords" content="internships for web design, internships for web design in Hyderabad, internship for web developer, web designing course, web design jobs, web design internship, web designing internship" />
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
                    <h1 class="title-blue">Web Designing Internship Programs
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
                    <div class="container">
                        <p><strong>
                            We are glad to announce that in COEPD we have introduced Web Designing  Internship Programs (Self sponsored) 
                           for professionals who want to have hands on experience.</strong>
                        </p>
                        <p>With associations with IT Companies, we are providing this program. Presently, this program is available in COEPD Hyderabad premises.</p>
                         <p>
                        Web designing is an ever growing field of demand in the technology oriented software stream.  A web designer is the one who
                        brings creativity and uses technology to fulfil clients designing needs. At COEPD, we provide finest web designing technology 
                        covering Photoshop, HTML, CSS, HTML5, CSS3, JavaScript, Boot Strap, and JQuery.  We train participants to be solution providers
                        and creative engineers.
                    </p>
                        <p>
                        This internship is intelligently dedicated to our avid and passionate participants predominantly acknowledging and appreciating the fact that they are on the path of making a career in Web Designing discipline. 
                       This internship is designed to ensure that in addition to gaining the requisite theoretical knowledge, the readers gain sufficient hands-on practice and practical know-how to master the nitty-gritty of the Web Designing profession.  
                       More than a training institute, COEPD today stands differentiated as a mission to help you "Build your dream career" - COEPD way.
                    </p>
                        <strong>Pre - Requisites:</strong>
                        <ul>
                            <li>Should be Graduate</li>
                            <li>Basic Communication Skills</li>
                            <li>Basic Programming Skills.</li>
                        </ul>
                        <strong>What you will do as an Intern</strong>
                        <ul>
                            <li>Undergo training for required courses</li>
                            <li>Work on assigned projects</li>
                            <li>Understand client requirements</li>
                            <li>Develop required code to meet clients requirements</li>
                            <li>Document the in line code</li>
                            <li>Test the developed code</li>
                            <li>Deploy the code</li>
                            <li>Capture client’s acceptance</li>&nbsp
                            <li><b>"Complete one International Certification" - expense covered in Internship Fees.</b></li>
                        </ul>                        
                    </div>
                    <div class="container" style="padding: 35px;">
                        <h2>Highlights of the course</h2><br />
                        <ul class="nav nav-pills tab-size">
                            <li class="active"><a data-toggle="pill" href="#home">Photoshop</a></li>
                            <li><a data-toggle="pill" href="#menu1">HTML, HTML5</a></li>
                            <li><a data-toggle="pill" href="#menu2">CSS, CSS3</a></li>
                            <li><a data-toggle="pill" href="#menu3">JavaScript</a></li>
                            <li><a data-toggle="pill" href="#menu4">BootStrap</a></li>
                        </ul>
                        <div class="tab-content">
                            <div id="home" class="tab-pane fade in active">
                                <h2 class="title-blue">Photoshop Training </h2>
                               
                                <strong>Photoshop Training Topics
                                    <br />
                                </strong>
                                <ul>
                                    <li>Move</li>
                                    <li>Marquee</li>
                                    <li>Lasso</li>
                                    <li>Quick Selection</li>
                                    <li>Crop</li>
                                    <li>Eyedropper</li>
                                    <li>Spot Healing</li>
                                    <li>Brush</li>
                                    <li>Clone Stamp</li>
                                    <li>History Brush</li>
                                    <li>Eraser</li>
                                    <li>Gradient</li>
                                    <li>Blur (no shortcut)</li>
                                    <li>Dodge</li>
                                    <li>Pen</li>
                                    <li>Horizontal Type</li>
                                    <li>Path Selection</li>
                                    <li>Rectangle</li>
                                    <li>Hand</li>
                                </ul>
                            </div>
                            <div id="menu1" class="tab-pane fade">
                                <h2 class="title-blue">HTML,HTML5 Training </h2>
                                
                                <strong>HTML,HTML5 Training Topics
                                    <br />
                                </strong>
                              <ul>
                                  <p><strong>Internet Basics</strong></p>
                                        <ul>
                                        <li>Network</li>
                                        <li>ARPANET</li>
                                        <li>Internet</li>
                                        <li>Email</li>
                                        <li>SMTP</li>
                                        <li>MIME</li>
                                        <li>WC</li>
                                        </ul>
                                        <p><strong>WEB Architecture</strong></p>
                                        <ul>
                                        <li>Presentation Layer</li>
                                        <li>Business Layer</li>
                                        <li>Data Access Layer</li>
                                        </ul>
                                        <p><strong>Major Web Browsers</strong></p>
                                        <p><strong>Blog</strong></p>
                                        <p><strong>Forum</strong></p>
                                        <p><strong>HTTP</strong></p>
                                        <p><strong>HTTPS</strong></p>
                                        <p><strong>Plug-In</strong></p>
                                        <p><strong>Webpage</strong></p>
                                        <ul>
                                        <li>Static Webpage</li>
                                        <li>Dynamic Webpage</li>
                                        </ul>
                                        <p><strong>Script</strong></p>
                                        <ul>
                                        <li>Client Side Script</li>
                                        <li>Server Side Script</li>
                                        </ul>
                                        <p><strong>Introduction to HTML</strong></p>
                                        <ul>
                                        <li>HTML History</li>
                                        <li>HTML Versions</li>
                                        <li>Tags</li>
                                        <li>TYPES OF TAGS</li>
                                        <li>Structure of HTML</li>
                                        <li>HTML Critical Elements</li>
                                        <li>How to create a Webpage</li>
                                        <li>Comments</li>
                                        <li>Parts in HTML documents</li>
                                        <li>Version Information</li>
                                        <li>Head Section</li>
                                        <li>Body Section</li>
                                        <li>Hexadecimal color coding system</li>
                                        <li>HTML attributes</li>
                                        <li>Element specific Attributes</li>
                                        <li>Global Attributes</li>
                                        <li>Event Attributes</li>
                                        <li>Special characters</li>
                                        <li>HTML drawback</li>
                                        </ul>
                                        <p><strong>Deprecated elements</strong></p>
                                        <ul>
                                        <li>Acronym</li>
                                        <li>Applet</li>
                                        <li>Basefont</li>
                                        <li>Big</li>
                                        <li>Center</li>
                                        <li>Dir</li>
                                        <li>Font</li>
                                        <li>Frame</li>
                                        <li>Frameset</li>
                                        <li>Isindex</li>
                                        <li>Noframes</li>
                                        <li>S</li>
                                        <li>Strike</li>
                                        <li>Tt</li>
                                        <li>U</li>
                                        <li>Xmp</li>
                                        </ul>
                                        <p><strong>Features of HTML</strong></p>
                                        <p><strong>HTML&nbsp; page layouts</strong></p>
                                        <p><strong>HTML&nbsp; page layouts</strong></p>
                                        <p><strong>HTML&nbsp; structure</strong></p>
                                        <p><strong>HTML&nbsp; semantics</strong></p>
                                        <ul>
                                        <li>General semantics
                                           <%-- <ul>
                                                <li>Architecture for semantics</li>
                                                <li>Section</li>
                                                <li>Article</li>
                                                <li>Header</li>
                                                <li>Footer</li>
                                                <li>Hgroup</li>
                                                <li>Aside</li>
                                                <li>Command</li>
                                                <li>Details</li>
                                                <li>Summary</li>
                                                <li>Figure</li>
                                                <li>Figcaption</li>
                                                <li>Nav</li>
                                                <li>Wbr</li>
                                                <li>Bdi</li>
                                                <li>Bdo</li>
                                            </ul>--%>
                                        </li>
                                     
                                        <li>Chinese semantics
                                            <%--<ul>
                                                <li>Ruby</li>
                                                <li>Rt</li>
                                                <li>Rp</li>
                                            </ul>--%>
                                        </li>
                                        
                                        </ul>
                                        <p><strong>HTML5 inline elements</strong></p>
                                        <ul>
                                        <li>Mark</li>
                                        <li>Meter</li>
                                        <li>Progress</li>
                                        <li>Time</li>
                                        </ul>
                                        <p><strong>HTML4 forms</strong></p>
                                        <ul>
                                        <li>Forms tags types</li>
                                        <li>Types of form fields</li>
                                        <li>Input fields</li>
                                        <li>Select fields</li>
                                        </ul>
                                        <p><strong>HTTP</strong></p>
                                        <ul>
                                        <li>Http requests methods</li>
                                           <%-- <ul>
                                                <li>Get</li>
                                                <li>Post</li>--%>
                                  
                                        <li>Action attributes</li>
                                        </ul>
                                        <p><strong>Working with HTML5 advanced forms</strong></p>
                                        <ul>
                                        <li>HTML new form attributes</li>
                                        <%--<li>Auto complete</li>
                                        <li>No validate</li>--%>
                                        <li>Input Types</li>
                                       <%-- <li>Date pickers</li>
                                        <li>General form controls</li>--%>
                                        <li>HTML input attributes</li>
                                       <%-- <li>Placeholder</li>
                                        <li>Autofocus</li>
                                        <li>Required</li>
                                        <li>Autocomplete</li>
                                        <li>Form</li>
                                        <li>Form action</li>
                                        <li>Form enctype</li>
                                        <li>Form method</li>
                                        <li>Form novalidate</li>
                                        <li>Formtarget</li>
                                        <li>Height and width</li>
                                        <li>List</li>
                                        <li>Min and max</li>
                                        <li>Multiple</li>
                                        <li>Pattern</li>
                                        <li>Step</li>
                                        <li>Spell check</li>
                                        <li>Content editable</li>
                                        <li>Access key</li>--%>
                                        </ul>
                                        <p><strong>HTML5&nbsp; new form elements</strong></p>
                                        <ul>
                                        <li>Data list</li>
                                        <li>Keygen</li>
                                        <li>Output</li>
                                        </ul>
                                        <p><strong>ParseInt global functions</strong></p>
                                        <p><strong>Working with HTML5 multimedia</strong></p>
                                        <ul>
                                        <li>Audio formats</li>
                                        <li>Tag-Specific Attributes</li>
                                        <li>Video formats</li>
                                        <li>HTML track element</li>
                                        </ul>
                                        <p><strong>Web VTT</strong></p>
                                        <ul>
                                        <li>How to create web VTT file</li>
                                        </ul>
                                        <p><strong>HTML5&nbsp; graphics</strong></p>
                                        <ul>
                                        <li>Canvas</li>
                                        <%--<li>Graphs and chats</li>
                                        <li>Animations</li>
                                        <li>Games</li>
                                        <li>Diagrams</li>
                                        <li>Videos and photo galleries</li>
                                        <li>Special image effects</li>
                                        <li>Drawing applications</li>
                                        <li>User interface enhancement</li>--%>
                                        <li>Attributes (Explained in )</li>
                                       <%-- <li>Global attributes (Explained in )</li>
                                        <li>Event attributes (Explained in )</li>--%>
                                        <li>Canvas shapes</li>
                                        <%--<li>Create canvas</li>
                                        <li>Draw on to the canvas with JavaScript</li>
                                        <li>Canvas co-ordinations</li>
                                        <li>Canvas-paths (Lines, Circles)</li>
                                        <li>Canvas-text</li>--%>
                                        <%--<li>Canvas-gradients</li>--%>
                                        </ul>
                                        <p><strong>HTML5 SVG</strong></p>
                                        <ul>
                                        <li>Jpeg (Joint photo graphic expert group)</li>
                                        <li>Png (Portable Network Graphics)</li>
                                        <li>Gif (Graphic Interchange Format)</li>
                                        <li>SVG versions and features</li>
                                        <li>SVG Versions</li>
                                        <li>SVG Features</li>
                                        <li>SVG Shapes</li>
                                       <%-- <li>Rectangle</li>
                                        <li>Circle</li>
                                        <li>Ellipse</li>
                                        <li>Line</li>
                                        <li>Polyline</li>--%>
                                        <li>Difference between canvas and SVG</li>
                                        </ul>
                                        <p><strong>HTMLMath ML (mathematical markup language)</strong></p>
                                        <ul>
                                        <li>Math ML Versions</li>
                                        <li>Features of MathML</li>
                                        <%--<li>Line Breaking and Indentation:</li>
                                        <li>Elementary Math:</li>
                                        <li>Bidirectional Layout Support</li>
                                        <li>MathML is a part of HTML</li>--%>
                                        <li>MathML Tags</li>
                                       <%-- <li>Identifier - &lt;mi&gt;</li>
                                        <li>Operators - &lt;mo&gt;</li>
                                        <li>Numbers - &lt;mn&gt;</li>
                                        <li>Text - &lt;mtext&gt;</li>
                                        <li>Horizontal Row of Item - &lt;mrow&gt;</li>
                                        <li>Fractions - &lt;mfrac&gt;</li>--%>
                                        <li>MSup</li>
                                        <li>MSub</li>
                                        <li>MSubSup</li>
                                        <li>Mroot</li>
                                        <li>Msqrt</li>
                                        <li>Menclose</li>
                                        </ul>
                                        <p><strong>Web Hosting</strong></p>
                                        <ul>
                                        <li>Types of web Hosting</li>
                                       <%-- <li>Free hosting</li>
                                        <li>Shared hosting</li>
                                        <li>Dedicated hosting</li>--%>
                                        <li>Providers and services</li>
                                        <%--<li>Connection Speed</li>
                                        <li>Powerfal Hardware</li>
                                        <li>Security and Stability</li>
                                        <li>hrs support</li>
                                        <li>Daily Backup</li>
                                        <li>Email Capabilities</li>--%>
                                        <li>Web hosting technologies</li>
                                        <%--<li>Windows hosting</li>
                                        <li>Linux hosting</li>
                                        <li>UNIX hosting</li>--%>
                                        <li>Web hosting database technologies</li>
                                       <%-- <li>SQL server</li>
                                        <li>Oracle</li>
                                        <li>MySQL</li>--%>
                                        <li>What is Domain Name?</li>
                                        <li>How to register a domain?</li>
                                        <li>How to upload a file?</li>
                                        <li>How to modify web page in live?</li>
                                        <li>How to upload multiple resources?</li>
                                        <li>How to unzip a folder in server?</li>
                                        <li>How to create security layer?</li>
                                        </ul>
                              </ul>
                            </div>
                            <div id="menu2" class="tab-pane fade">
                                <h2 class="title-blue">CSS, CSS3 Training </h2>
                                <strong>CSS, CSS3 Training Topics
                                    <br />
                                </strong>
                                <ul>
                                    <p><strong>Introduction to CSS</strong></p>
                                    <ul>
                                   <%-- <li>Cascading Style Sheets</li>--%>
                                    </ul>
                                    <p><strong>What is Cascading Style Sheets?</strong></p>
                                    <p><strong>Features of CSS</strong></p>
                                    <p><strong>Why CSS</strong></p>
                                    <p><strong>CSS Version history</strong></p>
                                    <p><strong>CSS Structure</strong></p>
                                    <p><strong>CSS Comments</strong></p>
                                    <p><strong>CSS basic syntax</strong></p>
                                    <ul>
                                    <li>Selector</li>
                                    <li>Property</li>
                                    <li>Value</li>
                                    </ul>
                                    <p><strong>Types of Style Sheets</strong></p>
                                    <ul>
                                    <li>Inline Style Sheets</li>
                                    <li>Internal Embedded Style Sheets</li>
                                    <li>External Style Sheets</li>
                                    <li>Imported CSS-@Import Rule</li>
                                    </ul>
                                    <p><strong>Working with CSS Selectors</strong></p>
                                    <ul>
                                    <li>Tag Selector</li>
                                    <li>Type Selector</li>
                                    <li>Id Selector</li>
                                    <li>Class Selector</li>
                                    <li>Grouping Selector</li>
                                    <li>Universal Selector</li>
                                    <li>Descendent Selector</li>
                                    <li>Customized Selector</li>
                                    </ul>
                                    <p><strong>CSS units or measurements</strong></p>
                                    <ul>
                                    <li>EM</li>
                                    <li>EX</li>
                                    <li>PX</li>
                                    <li>IN</li>
                                    <li>CM</li>
                                    <li>MM</li>
                                    </ul>
                                    <p><strong>CSS Background property</strong></p>
                                    <ul>
                                    <li>Background-Color</li>
                                    <li>Background-Image</li>
                                    <li>Background-Repeat</li>
                                    <li>Background-Attachment</li>
                                    <li>Background-Position</li>
                                    </ul>
                                    <p><strong>Font Family</strong></p>
                                    <p><strong>Text Properties</strong></p>
                                    <ul>
                                    <li>Color</li>
                                    <li>Direction</li>
                                    <li>Text-Decoration</li>
                                    <li>Text-indent</li>
                                    <li>Text-align</li>
                                    <li>Letter-Spacing</li>
                                    <li>Word-Spacing</li>
                                    <li>Text-Transformation</li>
                                    <li>White-Space</li>
                                    <li>Verticle-Align</li>
                                    </ul>
                                    <p><strong>CSS Borders</strong></p>
                                    <ul>
                                    <li>Border-Color</li>
                                    <li>Border-Style</li>
                                    </ul>
                                    <p><strong>CSS3</strong></p>
                                    <p><strong>Browsers supporting CSS3</strong></p>
                                    <p><strong>CSS Multiple column properties</strong></p>
                                    <ul>
                                    <li>Column-Count</li>
                                    <li>Column-Gap</li>
                                    <li>Column-rule</li>
                                    <li>Column-Fill</li>
                                    <li>Column-Span</li>
                                    <li>Column-Width</li>
                                    <li>Columns</li>
                                    </ul>
                                    <p><strong>CSS3 background properties</strong></p>
                                    <ul>
                                    <li>Background Size</li>
                                    <li>Background Clip</li>
                                    <li>Background with origin</li>
                                    </ul>
                                    <p><strong>CSS3 Borders</strong></p>
                                    <ul>
                                    <li>Border-image</li>
                                    <li>Border-Radius</li>
                                    <li>Box-Shadow</li>
                                    </ul>
                                    <p><strong>CSS3 Text Properties</strong></p>
                                    <ul>
                                    <li>Text-Justify</li>
                                    <li>Text-Overflow</li>
                                    <li>Text-Shadow</li>
                                    <li>Text-Wrap</li>
                                    <li>Word-Break</li>
                                    <li>Word-Wrap</li>
                                    </ul>
                                    <p><strong>CSS3 Font properties</strong></p>
                                    <ul>
                                    <li>Font-Face</li>
                                    <li>Font-Size-Adjust</li>
                                    <li>Font-Stretch</li>
                                    </ul>
                                    <p><strong>CSS3 Transforms</strong></p>
                                    <ul>
                                    <li>Transform</li>
                                    <li>Transform-origin</li>
                                    <li>Transform-Style</li>
                                    </ul>
                                    <p><strong>CSS3 Transitions</strong></p>
                                    <ul>
                                    <li>Transitions Properties</li>
                                    <li>Transitions Delay</li>
                                    </ul>
                                    <p><strong>CSS3 Animations</strong></p>
                                    <ul>
                                    <li>How to Implement Animations</li>
                                    <li>Animation Properties</li>
                                    </ul>
                                    <p><strong>Advanced Selectors</strong></p>
                                    <ul>
                                    <li>[Attribute ^=values] Selector</li>
                                    <li>Css [attribute$=Value] Selector</li>
                                    <li>Css [attribute*=Value]Selector</li>
                                    <li>Css-First of type Selector</li>
                                    <li>Css-Only-Of-type-Selector</li>
                                    <li>Css-nth-Child-Selector</li>
                                    </ul>
                                    <p><strong>CSS3 User Interface</strong></p>
                                    <ul>
                                    <li>Css Resizing</li>
                                    <li>Css Outline-offset</li>
                                    </ul>
                                    <p><strong>HTML5 WebStorage</strong></p>
                                    <ul>
                                    <li>Local Storage</li>
                                    <li>Session Storage</li>
                                    </ul>
                                    <p><strong>Web SQL</strong></p>
                                    <ul>
                                    <li>Opening Database</li>
                                    </ul>
                                    <p><strong>Index DB</strong></p>
                                    <ul>
                                    <li>Why to use indexeddb?</li>
                                    <li>Features</li>
                                    </ul>
                                    <p><strong>HTMl5 Geo location</strong></p>
                                    <ul>
                                    <li>Define Latitude</li>
                                    <li>Define Longitude</li>
                                    <li>Types Of Maps</li>
                                    </ul>
                                    <p><strong>Google Maps controls</strong></p>
                                    <ul>
                                    <li>Geo location Methods</li>
                                    </ul>
                                    <p><strong>Working with HTML5 drag and drop</strong></p>
                                    <ul>
                                    <li>Define Drag and Drop</li>
                                    <li>Creating Draggable Content</li>
                                    <li>Drag and Drop Events</li>
                                    <li>Allow Drop</li>
                                    <li>What to Drag</li>
                                    <li>Do the Drop</li>
                                    </ul>
                                </ul>
                            </div>
                            <div id="menu3" class="tab-pane fade">
                              <h2 class="title-blue">Javascript Training</h2>
                                            <p><strong>Javascript Training Topics&nbsp;<br /></strong></p>
                                            <p><strong>JavaScript Introduction</strong></p>
                                            <ul>
                                            <li>JavaScript Can Change HTML Content</li>
                                            <li>JavaScript Can Change HTML Attributes</li>
                                            <li>JavaScript Can Change HTML Styles (CSS)</li>
                                            <li>JavaScript Can Hide HTML Elements</li>
                                            <li>JavaScript Can Show HTML Elements</li>
                                            </ul>
                                            <p><strong>JavaScript Where To</strong></p>
                                            <ul>
                                            <li>The &lt;script&gt; Tag</li>
                                            <li>JavaScript Functions and Events</li>
                                            <li>JavaScript in &lt;head&gt; or &lt;body&gt;</li>
                                            <li>JavaScript in &lt;head&gt;</li>
                                            <li>JavaScript in &lt;body&gt;</li>
                                            <li>External JavaScript</li>
                                            <li>External JavaScript Advantages</li>
                                            </ul>
                                            <p><strong>JavaScript Output</strong></p>
                                            <ul>
                                            <li>JavaScript Display Possibilities</li>
                                            <li>Using innerHTML</li>
                                            <li>Using documentwrite()</li>
                                            <li>Using windowalert()</li>
                                            <li>Using consolelog()</li>
                                            </ul>
                                            <p><strong>JavaScript Statements</strong></p>
                                            <ul>
                                            <li>JavaScript Programs</li>
                                            <li>JavaScript Statements</li>
                                            <li>Semicolons</li>
                                            <li>JavaScript White Space</li>
                                            <li>JavaScript Line Length and Line Breaks</li>
                                            <li>JavaScript Code Blocks</li>
                                            </ul>
                                            <p><strong>JavaScript Syntax</strong></p>
                                            <ul>
                                            <li>JavaScript Values</li>
                                            <li>JavaScript Literals</li>
                                            <li>JavaScript Variables</li>
                                            <li>JavaScript Operators</li>
                                            <li>JavaScript Expressions</li>
                                            <li>JavaScript Keywords</li>
                                            <li>JavaScript Comments</li>
                                            <li>JavaScript Identifiers</li>
                                            <li>JavaScript is Case Sensitive</li>
                                            </ul>
                                            <p><strong>JavaScript Operators</strong></p>
                                            <ul>
                                            <li>JavaScript Arithmetic Operators</li>
                                            <li>Operators And Operands</li>
                                            <li>JavaScript Assignment Operators</li>
                                            <li>JavaScript Comparison Operators</li>
                                            <li>JavaScript Logical Operators</li>
                                            <li>JavaScript Type Operators</li>
                                            <li>JavaScript Bitwise Operators</li>
                                            <li>Operator Precedence</li>
                                            <li>JavaScript Operator Precedence Values</li>
                                            </ul> 
                                           <p><strong>JavaScript Data Types</strong></p> 
                                            <ul>                                          
                                            <li>JavaScript Data Types</li>
                                            <li>JavaScript Types are Dynamic</li>
                                            <li>JavaScript Strings</li>
                                            <li>JavaScript Numbers</li>
                                            <li>JavaScript Booleans</li>
                                            <li>JavaScript Arrays</li>
                                            <li>JavaScript Objects</li>
                                            <li>The typeof Operator</li>
                                            </ul>
                                            <p><strong>JavaScript Functions</strong></p>
                                            <ul>
                                            <li>JavaScript Function Syntax</li>
                                            <li>Function Invocation</li>
                                            <li>Function Return</li>
                                            <li>Why Functions?</li>
                                            <li>Functions Used as Variable Values</li>
                                            </ul>
                                            <p><strong>JavaScript Objects</strong></p>
                                            <ul>
                                            <li>JavaScript Objects</li>
                                            <li>Object Properties</li>
                                            <li>Object Methods</li>
                                            <li>Object Definition</li>
                                            <li>Accessing Object Properties</li>
                                            <li>Accessing Object Methods</li>
                                            <li>Do Not Declare Strings, Numbers, and Booleans as Objects!</li>
                                            </ul>
                                            <p><strong>JavaScript Scope</strong></p>
                                            <ul>
                                            <li>JavaScript Function Scope</li>
                                            <li>Local JavaScript Variables</li>
                                            <li>Global JavaScript Variables</li>
                                            <li>JavaScript Variables</li>
                                            <li>Automatically Global</li>
                                            <li>Global Variables in HTML</li>
                                            <li>The Lifetime of JavaScript Variables</li>
                                            <li>Function Arguments</li>
                                            </ul>
                                            <p><strong>JavaScript Events</strong></p>
                                            <ul>
                                            <li>HTML Events</li>
                                            <li>Common HTML Events</li>
                                            <li>What can JavaScript Do?</li>
                                            </ul>
                                            <p><strong>JavaScript Strings</strong></p>
                                            <ul>
                                            <li>JavaScript Strings</li>
                                            <li>String Length</li>
                                            <li>Special Characters</li>
                                            </ul>
                                            <p><strong>JavaScript String Methods</strong></p>
                                            <ul>
                                            <li>Finding a String in a String</li>
                                            <li>Searching for a String in a String</li>
                                            <li>Extracting String Parts</li>
                                            <li>Replacing String Content</li>
                                            <li>Converting to Upper and Lower Case</li>
                                            <li>The concat() Method</li>
                                            <li>Complete String Reference</li>
                                            </ul>
                                            <p><strong>JavaScript Numbers</strong></p>
                                            <ul>
                                            <li>JavaScript Numbers are Always -bit Floating Point</li>
                                            <li>Precision</li>
                                            <li>Adding Numbers and Strings</li>
                                            <li>Numeric Strings</li>
                                            <li>NaN - Not a Number</li>
                                            <li>Infinity</li>
                                            <li>Hexadecimal</li>
                                            <li>Numbers can be Objects</li>
                                            </ul>
                                            <p><strong>JavaScript Number Methods</strong></p>
                                            <ul>
                                            <li>Number Methods and Properties</li>
                                            <li>The toString() Method</li>
                                            <li>The toExponential() Method</li>
                                            <li>The toFixed() Method</li>
                                            <li>The toPrecision() Method</li>
                                            <li>The valueOf() Method</li>
                                            <li>Converting Variables to Numbers</li>
                                            <li>Global Methods</li>
                                            <li>The Number() Method</li>
                                            <li>The parseInt() Method</li>
                                            <li>The parseFloat() Method</li>
                                            <li>Number Properties</li>
                                            </ul>
                                            <p><strong>JavaScript Math Object</strong></p>
                                            <ul>
                                            <li>Mathround()</li>
                                            <li>Mathpow()</li>
                                            <li>Mathsqrt()</li>
                                            <li>Mathabs()</li>
                                            <li>Mathceil()</li>
                                            <li>Mathfloor()</li>
                                            <li>Mathsin()</li>
                                            <li>Mathmin() and Mathmax()</li>
                                            <li>Mathrandom()</li>
                                            </ul>
                                            <p><strong>JavaScript Dates</strong></p>
                                            <ul>
                                            <li>Creating Date Objects</li>
                                            </ul>
                                            <p><strong>JavaScript Date Formats</strong></p>
                                            <ul>
                                            <li>JavaScript Date Input</li>
                                            <li>JavaScript Date Output</li>
                                            <li>ISO Dates (Year and Month)</li>
                                            <li>ISO Dates (Only Year)</li>
                                            <li>ISO Dates (Date-Time)</li>
                                            <li>JavaScript Short Dates</li>
                                            <li>JavaScript Full Date</li>
                                            <li>JavaScript Long Dates</li>
                                            </ul>
                                            <p><strong>JavaScript Long Dates</strong></p>
                                            <ul>
                                            <li>The Date Methods</li>
                                            </ul>
                                            <p> <strong>JavaScript Arrays</strong></p>
                                            <ul>                                           
                                            <li>What is an Array?</li>
                                            <li>Creating an Array</li>
                                            <li>Using the JavaScript Keyword new</li>
                                            <li>Access the Elements of an Array</li>
                                            <li>Access the Full Array</li>
                                            <li>Arrays are Objects</li>
                                            <li>Array Elements Can Be Objects</li>
                                            <li>Array Properties and Methods</li>
                                            <li>The length Property</li>
                                            <li>Looping Array Elements</li>
                                            <li>Adding Array Elements</li>
                                            <li>The Difference between Arrays and Objects</li>
                                            <li>When to Use Arrays When to use Objects</li>
                                            </ul>
                                            <p><strong>JavaScript Array Methods</strong></p>
                                            <ul>
                                            <li>Converting Arrays to Strings</li>
                                            <li>Popping and Pushing</li>
                                            <li>Popping</li>
                                            <li>Pushing</li>
                                            <li>Shifting Elements</li>
                                            <li>Changing Elements</li>
                                            <li>Deleting Elements</li>
                                            <li>Splicing an Array</li>
                                            <li>Automatic toString()</li>
                                            </ul>
                                            <p><strong>JavaScript Sorting Arrays</strong></p>
                                            <ul>
                                            <li>Sorting an Array</li>
                                            <li>Reversing an Array</li>
                                            <li>Numeric Sort</li>
                                            <li>Sorting an Array in Random Order</li>
                                            <li>Find the Highest (or Lowest) Array Value</li>
                                            <li>Using Mathmax() on an Array</li>
                                            <li>Using Mathmin() on an Array</li>
                                            <li>My Min / Max JavaScript Methods</li>
                                            <li>Sorting Object Arrays</li>
                                            </ul>
                                            <p><strong>JavaScript Booleans</strong></p>
                                            <ul>
                                            <li>Boolean Values</li>
                                            <li>The Boolean() Function</li>
                                            <li>Comparisons and Conditions</li>
                                            <li>Everything With a "Value" is True</li>
                                            <li>Everything without a "Value" is False</li>
                                            <li>Booleans Can be Objects</li>
                                            </ul>
                                            <p><strong>JavaScript Comparison and Logical Operators</strong></p>
                                            <ul>
                                            <li>Comparison Operators</li>
                                            <li>How can it be used</li>
                                            <li>Logical Operators</li>
                                            <li>Conditional (Ternary) Operator</li>
                                            </ul>
                                            <p><strong>JavaScript IfElse Statement</strong></p>
                                            <ul>
                                            <li>Conditional Statements</li>
                                            <li>The if Statement</li>
                                            <li>The else Statement</li>
                                            <li>The else if Statement</li>
                                            </ul>
                                            <p><strong>JavaScript Switch Statement</strong></p>
                                            <ul>
                                            <li>The JavaScript Switch Statement</li>
                                            <li>The break Keyword</li>
                                            <li>The default Keyword</li>
                                            </ul>
                                            <p><strong>JavaScript For Loop</strong></p>
                                            <ul>
                                            <li>JavaScript Loops</li>
                                            <li>Different Kinds of Loops</li>
                                            <li>The For Loop</li>
                                            <li>The For/In Loop</li>
                                            </ul>
                                            <p><strong>JavaScript While Loop</strong></p>
                                            <ul>
                                            <li>The While Loop</li>
                                            <li>The Do/While Loop</li>
                                            </ul>
                                            <p><strong>JavaScript Break and Continue</strong></p>
                                            <ul>
                                            <li>The Break Statement</li>
                                            <li>The Continue Statement</li>
                                            <li>JavaScript Labels</li>
                                            </ul>
                                            <p><strong>JavaScript Type Conversion</strong></p>
                                            <ul>
                                            <li>JavaScript Data Types</li>
                                            <li>The typeof Operator</li>
                                            <li>The Data Type of typeof</li>
                                            <li>The constructor Property</li>
                                            <li>JavaScript Type Conversion</li>
                                            <li>Converting Numbers to Strings</li>
                                            <li>Converting Booleans to Strings</li>
                                            <li>Converting Dates to Strings</li>
                                            <li>Converting Strings to Numbers</li>
                                            <li>The Unary + Operator</li>
                                            <li>Converting Booleans to Numbers</li>
                                            <li>Converting Dates to Numbers</li>
                                            <li>Automatic Type Conversion</li>
                                            <li>Automatic String Conversion</li>
                                            </ul>
                                            <p><strong>JavaScript Bitwise Operations</strong></p>
                                            <ul>
                                            <li>JavaScript Bitwise Operator</li>
                                            <li>JavaScript Bitwise Operators</li>
                                            <li>JavaScript Uses bits Bitwise Operand</li>
                                            <li>Bitwise AND</li>
                                            <li>Bitwise OR</li>
                                            <li>Bitwise XOR</li>
                                            <li>JavaScript Bitwise AND (&amp;)</li>
                                            <li>JavaScript Bitwise AND (&amp;)</li>
                                            <li>JavaScript Bitwise OR (|)</li>
                                            <li>JavaScript Bitwise XOR (^)</li>
                                            <li>JavaScript Bitwise NOT (~)</li>
                                            <li>JavaScript (Zero Fill) Bitwise Left Shift (&lt;&lt;)</li>
                                            <li>JavaScript (Sign Preserving) Bitwise Right Shift (&gt;&gt;)</li>
                                            <li>JavaScript (Zero Fill) Right Shift (&gt;&gt;&gt;)</li>
                                            </ul>
                                            <p><strong>JavaScript Regular Expression</strong></p>
                                            <ul>
                                            <li>What Is a Regular Expression?</li>
                                            <li>Using String Methods</li>
                                            <li>Using String search() with a Regular Expression</li>
                                            <li>Using String search() with String</li>
                                            <li>Use String replace() with a Regular Expression</li>
                                            <li>Using String replace() with a String</li>
                                            <li>Regular Expression Modifiers</li>
                                            <li>Regular Expression Patterns</li>
                                            <li>Using the RegExp Object</li>
                                            <li>Using test()</li>
                                            <li>Using exec()</li>
                                            </ul>
                                            <p><strong>JavaScript Errors - Throw and Try to Catch</strong></p>
                                            <ul>
                                            <li>Errors Will Happen!</li>
                                            <li>JavaScript try and catch</li>
                                            <li>The throw Statement</li>
                                            <li>Input Validation Example</li>
                                            <li>The finally Statement</li>
                                            <li>The Error Object</li>
                                            <li>Error Name Values</li>
                                            <li>Eval Error</li>
                                            <li>Range Error</li>
                                            <li>Reference Error</li>
                                            <li>Type Error</li>
                                            <li>Syntax Error</li>
                                            <li>URI Error</li>
                                            </ul>
                                            <p><strong>JavaScript Debugging</strong></p>
                                            <ul>
                                            <li>Code Debugging</li>
                                            <li>JavaScript Debuggers</li>
                                            <li>The consolelog() Method</li>
                                            <li>Setting Breakpoints</li>
                                            <li>The debugger Keyword</li>
                                            <li>Major Browsers' Debugging Tools</li>
                                            </ul>
                                            <p><strong>JavaScript Hoisting</strong></p>
                                            <ul>
                                            <li>JavaScript Declarations are Hoisted</li>
                                            <li>JavaScript Initializations are not Hoisted</li>
                                            <li>Declare Your Variables At the Top !</li>
                                            </ul>
                                            <p><strong>JavaScript Use Strict</strong></p>
                                            <ul>
                                            <li>The "use strict" Directive</li>
                                            <li>Why Strict Mode?</li>
                                            </ul>
                                            <p><strong>JavaScript Form</strong></p>
                                            <ul>
                                            <li>JavaScript Form Validation</li>
                                            <li>JavaScript Can Validate Numeric Input</li>
                                            <li>Automatic HTML Form Validation</li>
                                            <li>Data Validation</li>
                                            <li>HTML Constraint Validation</li>
                                            <li>Constraint Validation HTML Input Attributes</li>
                                            <li>Constraint Validation CSS Pseudo Selectors</li>
                                            </ul>
                                            <p><strong>JavaScript Validation API</strong></p>
                                            <ul>
                                            <li>Constraint Validation DOM Methods</li>
                                            <li>Constraint Validation DOM Properties</li>
                                            <li>Validity Properties</li>
                                            </ul>
                                            <p><strong>JavaScript Objects</strong></p>
                                            <ul>
                                            <li>JavaScript Primitives</li>
                                            <li>Objects are Variables Containing Variables</li>
                                            <li>Object Properties</li>
                                            <li>Object Methods</li>
                                            <li>Creating a JavaScript Object</li>
                                            <li>Using an Object Literal</li>
                                            <li>Using the JavaScript Keyword new</li>
                                            <li>JavaScript Objects are Mutable</li>
                                            </ul>
                                            <p><strong>JavaScript Object Properties</strong></p>
                                            <ul>
                                            <li>JavaScript Properties</li>
                                            <li>Accessing JavaScript Properties</li>
                                            <li>JavaScript forin Loop</li>
                                            <li>Adding New Properties</li>
                                            <li>Deleting Properties</li>
                                            <li>Property Attributes</li>
                                            <li>Prototype Properties</li>
                                            </ul>
                                            <p><strong>JavaScript Object Methods</strong></p>
                                            <ul>
                                            <li>JavaScript Methods</li>
                                            <li>The this Keyword</li>
                                            <li>Accessing Object Methods</li>
                                            <li>Using Built-In Methods</li>
                                            <li>Adding a Method to an Object</li>
                                            </ul>
                                            <p><strong>JavaScript Object Constructors</strong></p>
                                            <ul>
                                            <li>Object Types (Blueprints) (Classes)</li>
                                            <li>Built-in JavaScript Constructors</li>
                                            </ul>
                                            <p><strong>JavaScript Object Prototypes</strong></p>
                                            <ul>
                                            <li>Prototype Inheritance</li>
                                            <li>Using the prototype Property</li>
                                            </ul>
                                            <p><strong>JavaScript Function Definitions</strong></p>
                                            <ul>
                                            <li>Function Declarations</li>
                                            <li>Function Expressions</li>
                                            <li>The Function() Constructor</li>
                                            <li>Self-Invoking Functions</li>
                                            </ul>
                                            <p><strong>JavaScript Function Parameters</strong></p>
                                            <ul>
                                            <li>Function Parameters and Arguments</li>
                                            <li>Parameter Rules</li>
                                            <li>Parameter Defaults</li>
                                            <li>The Arguments Object</li>
                                            <li>Arguments are passed by Value</li>
                                            <li>Objects are passed by Reference</li>
                                            </ul>
                                            <p><strong>JavaScript Function Call</strong></p>
                                            <ul>
                                            <li>The JavaScript call() Method</li>
                                            </ul>
                                            <p><strong>JavaScript Function Apply</strong></p>
                                            <ul>
                                            <li>The JavaScript apply() Method</li>
                                            <li>The Difference Between call() and apply()</li>
                                            </ul>
                                            <p><strong>JavaScript Closures</strong></p>
                                            <ul>
                                            <li>Global Variables</li>
                                            <li>Variable Lifetime</li>
                                            <li>A Counter Dilemma</li>
                                            <li>JavaScript Nested Functions</li>
                                            <li>JavaScript Closures</li>
                                            </ul>
                                            <p><strong>JavaScript HTML DOM</strong></p>
                                            <ul>
                                            <li>The HTML DOM (Document Object Model)</li>
                                            <li>What is the DOM?</li>
                                            <li>What is the HTML DOM?</li>
                                            </ul>
                                            <p><strong>JavaScript - HTML DOM Methods</strong></p>
                                            <ul>
                                            <li>The DOM Programming Interface</li>
                                            <li>The getElementById Method</li>
                                            <li>The innerHTML Property</li>
                                            </ul>
                                            <p><strong>JavaScript HTML DOM Document</strong></p>
                                            <ul>
                                            <li>The HTML DOM Document Object</li>
                                            <li>Finding HTML Element</li>
                                            <li>Changing HTML Elements</li>
                                            <li>Adding and Deleting Elements</li>
                                            <li>Adding Events Handlers</li>
                                            <li>Finding HTML Objects</li>
                                            </ul>
                                            <p><strong>JavaScript HTML DOM Elements</strong></p>
                                            <ul>
                                            <li>Finding HTML Elements</li>
                                            <li>Finding HTML Element by Id</li>
                                            <li>Finding HTML Elements by Tag Name</li>
                                            <li>Finding HTML Elements by Class Name</li>
                                            <li>Finding HTML Elements by CSS Selectors</li>
                                            <li>Finding HTML Elements by HTML Object Collections</li>
                                            </ul>
                                            <p><strong>JavaScript HTML DOM - Changing HTML</strong></p>
                                            <ul>
                                            <li>Changing the HTML Output Stream</li>
                                            <li>Changing the Value of an Attribute</li>
                                            </ul>
                                            <p><strong>JavaScript HTML DOM - Changing CSS</strong></p>
                                            <ul>
                                            <li>Changing HTML Style</li>
                                            <li>Using Events</li>
                                            </ul>
                                            <p><strong>JavaScript HTML DOM Animation</strong></p>
                                            <ul>
                                            <li>A Basic Web Page</li>
                                            <li>Create an Animation Container</li>
                                            <li>Style the Elements</li>
                                            <li>Create the Animation Using JavaScript</li>
                                            </ul>
                                            <p><strong>JavaScript HTML DOM Events</strong></p>
                                            <ul>
                                            <li>Reacting to Events</li>
                                            <li>HTML Event Attributes</li>
                                            <li>Assign Events Using the HTML DOM</li>
                                            <li>The onload and onunload Events</li>
                                            <li>The onchange Event</li>
                                            <li>The onmouseover and onmouseout Events</li>
                                            <li>The onmousedown, onmouseup and onclick Events</li>
                                            </ul>
                                            <p><strong>JavaScript HTML DOM EventListener</strong></p>
                                            <ul>
                                            <li>The addEventListener() method</li>
                                            <li>Add an Event Handler to an Element</li>
                                            <li>Add Many Event Handlers to the Same Element</li>
                                            <li>Passing Parameters</li>
                                            <li>Event Bubbling or Event Capturing?</li>
                                            <li>The removeEventListener() method</li>
                                            </ul>
                                            <p><strong>JavaScript HTML DOM Navigation</strong></p>
                                            <ul>
                                            <li>DOM Nodes</li>
                                            <li>Node Relationships</li>
                                            </ul>
                                            <p><strong>JavaScript HTML DOM Elements (Nodes)</strong></p>
                                            <ul>
                                            <li>Creating New HTML Elements (Nodes)</li>
                                            <li>Creating new HTML Elements - insertBefore()</li>
                                            <li>Removing Existing HTML Elements</li>
                                            <li>Replacing HTML Elements</li>
                                            </ul>
                                            <p><strong>JavaScript HTML DOM Collections</strong></p>
                                            <ul>
                                            <li>The HTMLCollection Object</li>
                                            <li>The HTMLCollection Length</li>
                                            </ul>
                                            <p><strong>JavaScript HTML DOM Node Lists</strong></p>
                                            <ul>
                                            <li>The HTML DOM NodeList Object</li>
                                            <li>HTML DOM Node List Length</li>
                                            <li>The Difference between an HTMLCollection and a NodeList</li>
                                            </ul>
                                            <p><strong>JavaScript Window - The Browser Object Model</strong></p>
                                            <ul>
                                            <li>The Window Object</li>
                                            <li>Window Size</li>
                                            <li>Other Window Methods</li>
                                            </ul>
                                            <p><strong>JavaScript Window Screen</strong></p>
                                            <p><strong>JavaScript Window Location</strong></p>
                                            <ul>
                                            <li>Window Location Assign</li>
                                            </ul>
                                            <p><strong>JavaScript Window History</strong></p>
                                            <ul>
                                            <li>Window History</li>
                                            <li>Window History Back</li>
                                            <li>Window History Forward</li>
                                            </ul>
                                            <p><strong>JavaScript Window Navigator</strong></p>
                                            <ul>
                                            <li>Window Navigator</li>
                                            </ul>
                                            <p><strong>JavaScript Popup Boxes</strong></p>
                                            <ul>
                                            <li>Alert Box</li>
                                            <li>Confirm Box</li>
                                            <li>Prompt Box</li>
                                            <li>Line Breaks</li>
                                            </ul>
                                            <p><strong>JavaScript Timing Events</strong></p>
                                            <ul>
                                            <li>Timing Events</li>
                                            <li>The setTimeout() Method</li>
                                            <li>How to Stop the Execution?</li>
                                            <li>The setInterval() Method</li>
                                            </ul>
                                            <p><strong>JavaScript Cookies</strong></p>
                                            <ul>
                                            <li>What are Cookies?</li>
                                            </ul>
                            </div>
                            <div id="menu4" class="tab-pane fade">
                                <h2 class="title-blue">Bootstrap Training </h2>
                                <strong>Bootstrap Training Topics
                                    <br />
                                </strong>
                                <ul>
                                        <p><strong>Introduction to mobile technology</strong></p>
                                        <ul>
                                        <li>Telephone </li>
                                        <li>Mobile</li>
                                        <li>Whatis Smart Phone</li>
                                        <li>Who implemented first mobile</li>
                                        </ul>
                                        <p><strong>Generations of mobile Tele communication</strong></p>
                                        <ul>
                                        <li>1G</li>
                                        <li>2G</li>
                                        <li>3G</li>
                                        <li>4G</li>
                                        </ul>
                                        <p><strong>Mobile frontend</strong></p>
                                        <p><strong>Bootstrap framework</strong></p>
                                        <p><strong>Introduction to HTML</strong></p>
                                        <ul>
                                        <li>Basic html program</li>
                                        <li>Example explained</li>
                                        <li>History of html</li>
                                        <li>Html versions</li>
                                        <li>Structure of html document</li>
                                        </ul>
                                        <p><strong>UTF-8</strong></p>
                                        <p><strong>Bootstrap structure</strong></p>
                                        <ul>
                                        <li>CSS library</li>
                                        <li>JS library</li>
                                        </ul>
                                        <p><strong>How to configure bootstrap framework</strong></p>
                                        <ul>
                                        <li>Standard install</li>
                                        <li>Bootstrap download</li>
                                        </ul>
                                        <p><strong>Why to use bootstrap</strong></p>
                                        <ul>
                                        <li>Easy to use</li>
                                        <li>Responsiveness</li>
                                        <li>The speed of the development</li>
                                        <li>Customizable bootstrap</li>
                                        <li>Consistency</li>
                                        <li>Support</li>
                                        <li>Packaged java script components</li>
                                        <li>Simple integration</li>
                                        <li>Grid</li>
                                        <li>Pre-styled components</li>
                                        </ul>
                                        <p><strong>What bootstrap includes</strong></p>
                                        <p><strong>How to add jquery library to bootstrap</strong></p>
                                        <p><strong>What are the features of bootstrap</strong></p>
                                        <p><strong>Bootstrap optional add-Ons</strong></p>
                                        <p><strong>How to start bootstrap script</strong></p>
                                        <ul>
                                        <li>Html doc type</li>
                                        <li>Html lang attribute</li>
                                        <li>Mobile first</li>
                                        <li>Adding bootstrap to web pages</li>
                                        </ul>
                                        <p><strong>CDN bootstrap framework</strong></p>
                                        <ul>
                                        <li>Css resources</li>
                                        <li>Jquery resources</li>
                                        <li>Java script resources</li>
                                        <li>CDN with glyphicons</li>
                                        <li>Bootstrap local resources</li>
                                        </ul>
                                        <p><strong>Bootstrap containers</strong></p>
                                        <ul>
                                        <li>Container</li>
                                        <li>Container fluid</li>
                                        </ul>
                                        <p><strong>Javascript</strong></p>
                                        <ul>
                                        <li>Features of javascript</li>
                                        <li>How to insert html tag in javascript</li>
                                        <li>Documentwrite() method</li>
                                        <li>Documentwriteln() method</li>
                                        <li>Javascript place in html file</li>
                                        <li>External java scripts</li>
                                        <li>Java script pop up box- alert boxx</li>
                                        <li>Javascript pop up box-confirm box</li>
                                        <li>Javascript pop up box –promt boxx</li>
                                        <li>Javascript variables</li>
                                        <li>Data types in javascript</li>
                                        <li>Primitive data types</li>
                                        <li>Non-primitive data types</li>
                                        <li>Dynamic data types</li>
                                        </ul>
                                        <p><strong>HTML&lt;noscript&gt;tag</strong></p>
                                        <p><strong>Bootstrap typography</strong></p>
                                        <ul>
                                        <li>Bootstrap headings</li>
                                        <li>Inlinesubheading-&lt;small&gt;</li>
                                        <li>Inlinesubheading-&lt;big&gt;</li>
                                        <li>Inlinesubheading-&lt;mark&gt;</li>
                                        <li>Inlinesubheading-&lt;abbr&gt;</li>
                                        <li>Inlinesubheading-&lt;blockquote&gt;</li>
                                        <li>Inlinesubheading-&lt;dl&gt;</li>
                                        <li>Inlinesubheading-&lt;code&gt;</li>
                                        <li>Inlinesubheading-&lt;kbd&gt;</li>
                                        <li>Inlinesubheading-&lt;pre&gt;</li>
                                        </ul>
                                        <p><strong>Contextual colors and backgrounds</strong></p>                                        
                                        <ul>
                                        <li>Classes for text</li>
                                        <li>Classes for back ground colors</li>
                                        <li>More typography classes</li>
                                        </ul>
                                        <p><strong>Closing alerts</strong></p>
                                        <p><strong>Bootstrap list</strong></p>
                                        <ul>
                                        <li>Ordered list</li>
                                        <li>Un-Ordered list</li>
                                        </ul>
                                        <p><strong>Bootstrap grid system</strong></p>
                                        <ul>
                                        <li>What is grid</li>
                                        <li>What are bootstrap grids</li>
                                        <li>Grid system rules</li>
                                        <li>Grid options</li>
                                        <li>Offsetting columns</li>
                                        </ul>
                                        <p><strong>Bootstrap tables</strong></p>
                                        <ul>
                                        <li>Html tables</li>
                                        <li>How to apply bootstrap classes</li>
                                        <li>Responsive tables</li>
                                        </ul>
                                        <p><strong>Bootstrap css textual classes</strong></p>
                                        <p><strong> Bootstrap carets</strong></p>
                                        <p><strong> Bootstrap button classes</strong></p>
                                        <ul>
                                        <li>Button colors</li>
                                        <li>Button sizes</li>
                                        <li>Info button</li>
                                        <li>Active info button</li>
                                        <li>Disabled info button</li>
                                        <li>Normal buttons</li>
                                        <li>Different button sizes</li>
                                        <li>Block level buttons</li>
                                        </ul>
                                        <p><strong>Images</strong></p>
                                        <ul>
                                        <li>Responsive images</li>
                                        <li>Image shapes</li>
                                        </ul>
                                        <p><strong>Html basic forms</strong></p>
                                        <ul>
                                        <li>Form</li>
                                        <li>Form attributes</li>
                                        <li>Form tags</li>
                                        <li>Input fields</li>
                                        <li>Attributes</li>
                                        </ul>
                                        <p><strong>HTML5 forms</strong></p>
                                        <ul>
                                        <li>Advanced controls</li>
                                        </ul>
                                        <p><strong>Html forms with bootstrap</strong></p>
                                        <p><strong> Html form with files and images</strong></p>
                                        <p><strong>Bootstrap forms</strong></p>
                                        <ul>
                                        <li>Bootstrap form layouts</li>
                                        <li>Supported control</li>
                                        <li>Static control</li>
                                        <li>Help text</li>
                                        <li>Control sizing</li>
                                        </ul>
                                        <p><strong>Bootstrap button groups</strong></p>
                                        <ul>
                                        <li>Button toolbar</li>
                                        <li>Button sizing</li>
                                        <li>Vertical button groups</li>
                                        <li>Justified button groups</li>
                                        <li>Nesting button groups and dropdown menus</li>
                                        </ul>
                                        <p><strong>Html progress bars with bootstrap</strong></p>
                                        <ul>
                                        <li>Basic progress bar</li>
                                        <li>Progress bar with labels</li>
                                        <li>Colored progress bars</li>
                                        <li>Animated progress bars</li>
                                        <li>Stacked progress bar</li>
                                        <li>Striped progress bars</li>
                                        </ul>
                                        <p><strong>Bootstrap pagers </strong></p>
                                        <p><strong>Bootstrap Js collapse </strong></p>
                                        <p><strong>Bootstrap wells </strong></p>
                                        <p><strong>Bootstrap alerts </strong></p>
                                        <ul>
                                        <li>Alerts</li>
                                        <li>Alert links</li>
                                        <li>Closing alerts</li>
                                        </ul>
                                        <p><strong>Input group </strong></p>
                                        <p><strong>Bootstrap form control states </strong></p>
                                        <p><strong>Bootstrap form control states </strong></p>
                                        <p><strong>Input sizing informs </strong></p>
                                        <p><strong>Boot strap jumbotron and page header </strong></p>
                                        <ul>
                                        <li>Jumbotron inside container</li>
                                        <li>Jumbotron outside container</li>
                                        <li>Creating a page header</li>
                                        </ul>
                                        <p><strong>Bootstrap badges and labels </strong></p>
                                        <ul>
                                        <li>Badges</li>
                                        <li>Labels</li>
                                        </ul>
                                        <p><strong>Bootstrap pagination </strong></p>
                                        <ul>
                                        <li>Basic pagination</li>
                                        <li>ActiveS sateP pgination</li>
                                        <li>Disabled state pagination</li>
                                        <li>Pagination sizing</li>
                                        <li>Breadcrumbs</li>
                                        </ul>
                                        <p><strong>Bootstrap list groups </strong></p>
                                        <ul>
                                        <li>Basic list groups</li>
                                        <li>List group with badges</li>
                                        <li>List group with linked items</li>
                                        <li>Active state</li>
                                        <li>Disabled item</li>
                                        <li>Contextual classes</li>
                                        </ul>
                                        <p><strong>Panel </strong></p>
                                        <ul>
                                        <li>Basic panel</li>
                                        <li>Panel heading</li>
                                        <li>Panel footer</li>
                                        <li>Panel group</li>
                                        <li>Panels with contextual classes</li>
                                        </ul>
                                        <p><strong>Bootstrap tabs and pills</strong></p>
                                        <ul>
                                        <li>Menus</li>
                                        <li>Tabs</li>
                                        <li>Tabs with dropdown menu</li>
                                        <li>Pills</li>
                                        <li>Vertical pills</li>
                                        <li>Vertical pills in arrow</li>
                                        <li>Pills with dropdown menu</li>
                                        <li>Centered tabs and pills</li>
                                        <li>Toggleable/dynamictabs</li>
                                        <li>Toggleable/dynamic pills</li>
                                        </ul>
                                        <p><strong>Navigationbars </strong></p>
                                        <ul>
                                        <li>Navigationbar</li>
                                        <li>Inverted navigationbar</li>
                                        <li>Fixed navigationbar</li>
                                        <li>Navigationbar with dropdown</li>
                                        <li>Right-aligned navigationbar</li>
                                        <li>Collapsing navigationbar</li>
                                        </ul>
                                        <p><strong>Model plugin </strong></p>
                                        <ul>
                                        <li>Create a modal</li>
                                        <li>Model size options, Methods</li>
                                        </ul>
                                        <p><strong>Carousel plugin</strong></p>
                                        <ul>
                                        <li>Example explained</li>
                                        <li>Carousel with caption</li>
                                        </ul>
                                        <p><strong>Tooltip </strong></p>
                                        <ul>
                                        <li>Create a tooltip</li>
                                        <li>Positioning tooltips</li>
                                        <li>Tooltip options</li>
                                        <li>Custom tooltip design</li>
                                        </ul>
                                        <p><strong>Bootstrap plugin popover </strong></p>
                                        <ul>
                                        <li>Create a popover</li>
                                        <li>Positioning popovers</li>
                                        <li>Closing pop overs</li>
                                        </ul>
                                        <p><strong>Scrollspy plugin </strong></p>
                                        <ul>
                                        <li>How to create a scrollspy</li>
                                        </ul>
                                        <p><strong>Webhosting </strong></p>
                                        <ul>
                                        <li>Types of webhosting</li>
                                        <li>Web hosting providers</li>
                                        <li>Webhosting technologies</li>
                                        <li>Common email services</li>
                                        <li>Webhosting database technologies</li>
                                        <li>Domain name</li>
                                        <li>Sub domains</li>
                                        <li>Selecting a domain</li>
                                        <li>Registering a domain</li>
                                        </ul>                                        
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

