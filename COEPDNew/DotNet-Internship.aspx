<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true" CodeFile="dotnet-internship.aspx.cs" Inherits="DotNet_Internship" %>

<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    .net internship | internship for .net in Hyderabad|.net training
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
     <link rel="canonical" href="https://www.coepd.com/dotnet-internship.html" />
    <meta name="description" content="Coepd offers .NET in the browser, build your first app, or dig into advanced resources for building for web, mobile, desktop, games, machine learning, and IoT apps with .NET. hands on experience using HTML, JAVA, C+, Oracle and so on." />
    <meta name="keywords" content=".net internship,.net internship in hyderabad,Dot net internship,Dot net internship in Hyderabad,internship program,software intern,software engineer internship,software jobs." />
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
                    <h1 class="title-blue">DotNet Internship Programs
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
                        <p>
                            <strong>We are glad to announce that in COEPD we have introduced Dot Net Technologies Internship Programs (Self sponsored) for professionals who 
                            want to have hands on experience.</strong>
                        </p>
                        <p>
                            With associations with IT Companies, we are providing this program. Presently, this program is 
                            available in COEPD Hyderabad premises.
                        </p>
                        <p>
                            .NET technology has been the most popular technology product from Microsoft and .NET programming has been 
                            one of the best choices for web development. It continues to create multiple .NET jobs in the country 
                            and worldwide.  Microsoft .NET is program language independent and It is being shared on other platforms 
                            like  Microsoft Dynamics, Microsoft SQL Server,  Microsoft Office,  Microsoft SharePoint and Microsoft 
                            Data Mining - This means more jobs for .Net Professionals. Learning .NET does not restrict you to a 
                            single language. As a .NET professional, your work would require you to develop programming logic 
                            that will allow computer systems to communicate with databases, networks and applications. You could be 
                            involved in developing a new application, or making changes, upgrading or repairing existing ones.  
                            At COEPD, we provide finest Dot Net Technologies training.
                        </p>
                        <p>
                            This internship is intelligently dedicated to our avid and passionate participants predominantly 
                            acknowledging and appreciating the fact that they are on the path of making a career in Dot Net 
                            Technologies discipline. This internship is designed to ensure that in addition to gaining the 
                            requisite theoretical knowledge, the readers gain sufficient hands-on practice and practical 
                            know-how to master the nitty-gritty of the Dot Net developer profession.  More than a training 
                            institute, COEPD today stands differentiated as a mission to help you "Build your dream career" - 
                            COEPD way.
                        </p>
                        <p><strong>Pre - Requisites:</strong></p>
                        <ul>
                            <li>Should be Graduate</li>
                            <li>Basic Communication Skills</li>
                            <li>Basic Computer awareness Skills.</li>
                        </ul>
                        <p><strong>What you will do as an Intern</strong></p>
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
                        <h2>Highlights of the course</h2>
                        <br />
                        <ul class="nav nav-pills tab-size">
                            <li class="active"><a data-toggle="pill" href="#home">.Net Platform</a></li>
                            <li><a data-toggle="pill" href="#menu1">C#</a></li>
                            <li><a data-toggle="pill" href="#menu2">Asp.Net</a></li>
                            <li><a data-toggle="pill" href="#menu3">SQL</a></li>
                            <li><a data-toggle="pill" href="#menu4">MVC</a></li>
                            <li><a data-toggle="pill" href="#menu5">Advanced Technologies</a></li>
                        </ul>
                        <div class="tab-content">
                            <div id="home" class="tab-pane fade in active">
                                <h2 class="title-blue">.Net Platform Training</h2>

                                <strong>.Net platform training topics
                                    <br />
                                </strong>
                                <ul>
                                    <li>Existing development scenario</li>
                                    <li>Challenges faced by developers</li>
                                    <li>Where does .NET fits in</li>
                                    <li>.NET platform layers</li>
                                    <li>Structure of .NET application</li>
                                    <li>Flavors of .NET</li>
                                    <li>Features of .NET</li>
                                    <li>Different types of applications supported by .NET platform</li>
                                    <li>Code management - JIT (Just In time compiling) and debugging</li>
                                    <li>Managed versus un-managed methods and transactions</li>
                                    <li>Object oriented programming concepts</li>
                                    <li>Error and exceptions handling</li>
                                    <li>Assemblies and application domains</li>
                                </ul>
                            </div>
                            <div id="menu1" class="tab-pane fade">
                                <h2 class="title-blue">C# Training</h2>

                                <strong>C# Training Topics
                                    <br />
                                </strong>
                                <ul>
                                    <li>Introduction</li>
                                    <li>Visual studio.net</li>
                                    <ul type="circle">
                                        <li>Introduction to Integrated Development Environment (IDE)</li>
                                        <li>Visual studio installation process</li>
                                        <li>Restarting your computer</li>
                                        <li>Launching visual studio enterprise 2015</li>
                                        <li>Activating visual studio</li>
                                        <li>Visual studio web development environment</li>
                                        <li>Get ready to visual studio</li>
                                        <li>Solution explorer	</li>
                                        <li>Tool box</li>
                                        <li>Editors and designers</li>
                                        <li>Properties window</li>
                                        <li>Build and debug tools</li>
                                        <li>Run and compile the program	</li>
                                        <li>Creating and using ASP.NET master pages in visual web developer </li>
                                    </ul>
                                    <li>Dot NET</li>
                                    <ul type="circle">
                                        <li>Machine dependency</li>
                                        <li>Features of.Net</li>
                                        <li>.Net framework</li>
                                        <li>Development of.net framework</li>
                                        <li>.Net framework versions</li>
                                        <li>.Net framework architecture</li>
                                        <li>Concerns and criticisms related to.Net</li>
                                    </ul>
                                    <li>C# Programming language</li>
                                    <ul type="circle">
                                        <li>History of language</li>
                                        <li>Design Goals of C#</li>
                                        <li>Versions of c# language</li>
                                        <li>Features of c# 2.0</li>
                                        <li>Features of c# 3.0</li>
                                        <li>Features of c# 4.0</li>
                                        <li>Features of c# 5.0</li>
                                        <li>Features of c# 6.0</li>
                                        <li>Features of c# 7.0</li>
                                        <li>Features of c# 7.1</li>
                                        <li>Features of c# 7.2</li>
                                        <li>Programming approaches</li>
                                        <li>What is a class?</li>
                                        <li>How to consume a datatype?</li>
                                        <li>OOPS in Java and C#</li>
                                        <li>Writing programs in c# languages</li>
                                        <li>System Requirements</li>
                                        <li>Syntax to define a class in c#</li>
                                        <li>Syntax to define main method in the class</li>
                                        <li>System.Console.Writeline</li>
                                        <li>Importing a namespace</li>
                                        <li>Importing a class</li>
                                        <li>Data types in c#</li>
                                        <li>String formatting</li>
                                        <li>Data types</li>
                                        <li>Nullable types</li>
                                        <li>Implicitly typed variable using ‘var’ keyword</li>
                                        <li>Dynamic type</li>
                                        <li>Boxing and unboxing</li>
                                        <li>Operators</li>
                                        <li>Conditional statements in c#</li>
                                        <li>Jump statements</li>
                                        <li>Arrays</li>
                                        <li>Command line parameters</li>
                                    </ul>
                                    <li>Object Oriented Programming in c#</li>
                                    <ul type="circle">
                                        <li>Encapsulation</li>
                                        <li>Abstraction</li>
                                        <li>Inheritance</li>
                                        <li>Polymorphism</li>
                                        <li>Class</li>
                                        <li>Method</li>
                                        <li>Defining Methods</li>
                                        <li>Consuming class</li>
                                        <li>Parameters</li>
                                        <li>Killing the instance of a class</li>
                                        <li>Creating multiple instances to a class</li>
                                        <li>Reference of a class</li>
                                        <li>Constructors</li>                                        
                                        <li>Inheritance</li>
                                        <li>Rules and regulations for inheritance</li>
                                        <li>Types of Inheritance</li>
                                        <li>Encapsulation</li>
                                        <li>Abstraction</li>
                                        <li>Polymorphism</li>
                                        <li>Overloading</li>
                                        <li>Difference between Method overloading and overriding</li>
                                        <li>Interfaces</li>
                                        <li>Sealed class</li>
                                        <li>Sealed method</li>
                                        <li>Extension methods</li>
                                        <li>Rules for defining extension methods</li>
                                        <li>Working with multiple Projects and Solutions</li>
                                    </ul>                                   
                                    <li>Access Specifiers</li>
                                    <ul type="circle">
                                        <li>Private</li>
                                        <li>Internal</li>
                                        <li>Protected</li>
                                        <li>Protected Internal</li>
                                        <li>Public</li>
                                    </ul>
                                    <li>Language Interoperability</li>
                                    <ul type="circle">
                                        <li>Consuming VB.Net code in C#</li>
                                    </ul>
                                    <li>Destructor</li>
                                    <ul type="circle">
                                        <li>Destructor and inheritance</li>
                                        <li>Conclusion about Destructors</li>
                                    </ul>
                                    <li>Properties</li>
                                    <ul type="circle">
                                        <li>Syntax to define a property</li>
                                        <li>Enumarated property</li>
                                        <li>Auto implemented properties</li>
                                    </ul>
                                    <li>Object Initialization</li>
                                    <li>Indexers</li>
                                    <li>Exceptions and exception handling</li>
                                    <ul type="circle">
                                        <li>Exception</li>
                                        <li>Exception hierarchy</li>
                                        <li>Exception handling</li>
                                        <li>How to Handle exception</li>
                                        <li>Application exception</li>
                                    </ul>
                                    <li>Multi Threading</li>
                                    <ul type="circle">
                                        <li>Thread</li>
                                        <li>Multi Threading</li>
                                        <li>Thread life cycle</li>
                                        <li>Why we should not use threads in our application?</li>
                                        <li>Why should we use Threads?</li>
                                        <li>Using threads with C# applications</li>
                                    </ul>
                                    <li>Collections</li>
                                    <ul type="circle">
                                        <li>Auto resizing of collections</li>
                                        <li>Array list</li>
                                        <li>Hash tables</li>
                                        <li>Generics</li>
                                    </ul>
                                    <li>Delegates</li>
                                    <ul type="circle">
                                        <li>Define a delegate</li>
                                        <li>Instantiate the delegate</li>
                                        <li>Using the delegate and calling a method</li>
                                        <li>Types of delegates</li>
                                        <li>Anonymous methods</li>
                                        <li>Lambda expressions</li>
                                        <li>Partial classes</li>
                                        <li>Partial methods</li>
                                    </ul>
                                    <li>Windows programming</li>
                                    <ul type="circle">
                                        <li>Developing graphical user interface</li>
                                        <li>How to develop a Desktop application (GUI)</li>
                                        <li>Developing windows application using notepad</li>
                                        <li>Developing windows application using Visual Studio</li>
                                        <li>Adding new forms in project</li>
                                        <li>Event</li>
                                        <li>How to define an event procedure manually</li>
                                        <li>Defining event procedures in notepad</li>
                                        <li>Placing controls on a form</li>
                                        <li>How does form gets created</li>
                                        <li>Default events</li>
                                        <li>working with Events and event procedures</li>
                                        <li>Binding event procedure with multiple events of control</li>
                                    </ul>
                                    <li>Working with controls</li>
                                    <ul type="circle">
                                        <li>Radio button</li>
                                        <li>Check box control</li>
                                        <li>Button</li>
                                        <li>Label</li>
                                        <li>Text box</li>
                                        <li>Message box</li>
                                        <li>Combo box</li>
                                        <li>Checked list box</li>
                                        <li>Picture box</li>
                                        <li>Dialog control</li>
                                        <li>Dock Property</li>
                                        <li>Timer control</li>
                                        <li>Form control</li>
                                        <li>Masked text box</li>
                                    </ul>
                                    <li>User Controls</li>
                                    <ul type="circle">
                                        <li>Component Developers</li>
                                        <li>Application Developers</li>
                                        <li>Creating a stop clock control</li>
                                        <li>Developing an inherited or extended control</li>
                                    </ul>
                                    <li>.NET Data Access framework providers</li>
                                    <ul type="circle">
                                        <li>Ado.Net</li>
                                        <li>Ado.Net Architecture</li>
                                        <li>Ado.Net Namespaces</li>
                                        <li>Performing operations on Data Source</li>
                                        <li>Establishing Connection with Data Source</li>
                                        <li>Constructors of the class</li>
                                        <li>Members of Connection Class</li>
                                        <li>Methods of Command Class</li>
                                        <li>Access data from a data reader</li>
                                        <li>Working with SQL Server</li>
                                        <li>Data Reader</li>
                                        <li>Dataset</li>
                                        <li>Data Adapter</li>
                                        <li>Configuration Files</li>
                                        <li>Data Grid View</li>                                       
                                        <li>Data View</li>
                                        <li>Data Relation</li>
                                        <li>Communication with data sources using odbc drivers</li>
                                        <li>Accessing MS Excel data from .net applications</li>
                                        <li>Stored Procedures</li>
                                        <li>Introduction to LinQ</li>
                                        <li>LinQ to SQL</li>
                                        <li>Ado.Net Entity Framework</li>
                                        <li>Entity Data Model</li>
                                        <li>Developing an EDM (Entity Data Model) project, Configuring with SQL SERVER</li>
                                        <li>Code under first form</li>
                                        <li>Code under second form</li>
                                        <li>Retrieving data from tables</li>
                                    </ul>
                                    <li>Assemblies</li>
                                    <ul type="circle">
                                        <li>Private Assemblies</li>
                                        <li>Shared Assemblies</li>
                                        <li>Creating a Shared Assembly</li>
                                        <li>Versioning of assemblies</li>
                                        <li>Assemblies and side by side execution</li>
                                        <li>Assembly manifest</li>
                                        <li>Type Metadata</li>
                                        <li>MSIL Code or CIL Code</li>
                                        <li>Compilation and Execution process of C# Project</li>
                                        <li>Process of designing data logic layers</li>
                                    </ul>
                                    <li>Setup and Deployment</li>
                                    <li>Remoting</li>
                                    <ul type="circle">
                                        <li>Application Architecture's</li>
                                        <li>Remoting</li>
                                        <li>Developing Remoting application</li>
                                        <li>Application Server or Remote server</li>
                                        <li>Remote interface</li>
                                        <li>Developing an interface</li>
                                        <li>Developing a Remote class</li>
                                        <li>Process to develop a Remote server</li>
                                        <li>Installing the service on your machine</li>
                                        <li>Process to develop Remote server</li>
                                        <li>Developing the client</li>
                                        <li>Execution of the application</li>
                                        <li>Singleton VS SingleCall</li>
                                    </ul>
                                </ul>
                            </div>
                            <div id="menu2" class="tab-pane fade">
                                <h2 class="title-blue">ASP.NET Training</h2>
                                <strong>ASP.NET Training Topics
                                    <br />
                                </strong>
                                <li>Introduction to web Application</li>
                                <ul type="circle">
                                    <li>Web Application and Web SERVER</li>
                                </ul>
                                <li>Markup Language</li>
                                <ul type="circle">
                                    <li>HTML</li>
                                    <li>Java SCRIPT</li>
                                </ul>
                                <li>ASP</li>
                                <ul type="circle">
                                    <li>Introduction to ASP</li>
                                    <li>What is an ASP file?</li>
                                    <li>How does it work?</li>
                                    <li>ASP Page Deployment</li>
                                    <li>ASP Forms</li>
                                    <li>ASP Objects</li>
                                    <li>Database Connection using ADO</li>
                                    <li>Working with Global.asa</li>
                                </ul>
                                <li>ASP.NET</li>
                                <ul type="circle">
                                    <li>Introduction to ASP.NET</li>
                                    <li>ASP.NET overview</li>
                                    <li>Creating ASP.NET Application</li>
                                    <li>Designing web forms, HTML</li>
                                    <li>Installing IIS SERVER</li>
                                    <li>ASP.NET Project folder structure</li>
                                    <li>ASP.NET Life cycle</li>
                                    <li>Understanding the rendering nature of Controls developing</li>
                                </ul>
                                <li>Web Forms Architecture</li>
                                <ul type="circle">
                                    <li>Parts of Web form</li>
                                    <li>Page class</li>
                                    <li>Web Forms Lifecycle</li>
                                    <li>Web Forms Event Model</li>
                                </ul>
                                <li>ASP.NET and HTTP</li>
                                <ul type="circle">
                                    <li>Request/Response programming</li>
                                    <li>HTTP Request class</li>
                                    <li>HTTP Collections</li>
                                    <li>HTTP Response class</li>
                                    <li>Redirection</li>
                                </ul>
                                <li>Working with controls</li>
                                <ul type="circle">
                                    <li>Introduction to web controls</li>
                                    <li>Simple input controls</li>
                                    <li>List controls</li>
                                    <li>Controlling Focus</li>
                                </ul>
                                <li>Using Rich Server Controls</li>
                                <ul type="circle">
                                    <li>Introduction to Rich Controls</li>
                                    <li>Calendar Control</li>
                                    <li>Ad Rotator Control</li>
                                    <li>XML Control</li>
                                    <li>File Upload</li>
                                    <li>MultiView control</li>
                                </ul>
                                <li>Working with validation controls</li>
                                <ul type="circle">
                                    <li>Overview of validation controls</li>
                                    <li>Required field validator</li>
                                    <li>Range Validator</li>
                                    <li>Compare Validator</li>
                                    <li>Regular Expression Validator</li>
                                    <li>Custom Validator</li>
                                    <li>Validation Summary</li>
                                </ul>
                                <li>User Control</li>
                                <ul type="circle">
                                    <li>Creating user control</li>
                                </ul>
                                <li>State Management</li>
                                <ul type="circle">
                                    <li>Client side state management</li>
                                    <ul type="circle">
                                        <li>View State</li>
                                        <li>Control State</li>
                                        <li>Hidden Fields</li>
                                        <li>Cookies</li>
                                        <li>Query Strings</li>
                                    </ul>
                                </ul>
                                <ul type="circle">
                                    <li>Server Side state Management Techniques</li>
                                    <ul type="circle">
                                        <li>Application state</li>
                                        <li>Session State</li>                                                            
                                    </ul>
                                </ul>
                               <li>ADO.Net</li>
                                <ul type="circle">
                                    <li>Introduction to ADO.Net</li>
                                    <li>Data Providers</li>
                                    <li>DataSet</li>
                                    <li>Advantages of ADO.Net over ADO</li>
                                    <li>Connected and Disconnected data access architecture</li>
                                </ul>
                                <li>DataAccess in ASP.NET4.0 </li>
                                <ul type="circle">
                                    <li>Data Source Controls</li>
                                    <li>Repeater Control</li>
                                    <li>Data Grid control</li>
                                    <li>GridView Control</li>
                                    <li>Details View Control</li>
                                    <li>Form View</li>
                                    <li>Object Data Sources</li>
                                    <li>List View control</li>
                                    <li>Entity Data Model</li>
                                </ul>
                                <li>Personalization and Security</li>
                                <ul type="circle">
                                    <li>Configuration overview</li>
                                    <li>Themes, Skins</li>
                                    <li>Master Pages</li>
                                </ul>
                                <li>ASP.NET and AJAX</li>
                                <ul type="circle">
                                    <li>Introduction to Microsoft Ajax (Codename: ATLAS)</li>
                                    <li>XML HTTP Object</li>
                                    <li>Advantages and disadvantages of using Ajax</li>
                                    <li>Script Manager</li>
                                    <li>Update Panel</li>
                                    <li>Triggers</li>
                                    <li>Ajax Control Toolkit</li>
                                </ul>
                                <li>ASP.NET Error Handling and Configuration</li>
                                <ul type="circle">
                                    <li>Error Handling and .Net runtime</li>
                                    <li>Page Level Error Handling</li>
                                    <li>Application Level Error Handling</li>
                                    <li>Code Level Error Handling</li>
                                    <li>Configuration overview</li>
                                    <li>Authentication and Authorization</li>
                                    <li>Forms Authentication</li>
                                    <li>Windows Authentication and IIS</li>
                                    <li>Passport Authentication</li>
                                    <li>Anonymous Authentication</li>
                                    <li>Open Authentication</li>
                                    <li>Security and ASP.NET</li>
                                    <li>Memberships</li>
                                </ul>
                                <li>Cache Services</li>
                                <ul type="circle">
                                    <li>Cache Overview</li>
                                    <li>Why caching?</li>
                                    <li>The Process</li>
                                    <li>Multiple sorts of pages</li>
                                    <li>What a cache does?</li>
                                    <li>Page-Level Caching</li>
                                    <li>Application Caching</li>
                                    <li>Caching a page</li>
                                    <li>Data Caching</li>
                                </ul>
                                <li>Navigation Controls</li>
                                <ul type="circle">
                                    <li>Sitemap Navigation control</li>
                                    <li>Menu Control</li>
                                    <li>Tree View Control</li>
                                </ul>
                                <li>Deployment</li>
                                <ul type="circle">
                                    <li>Deploying ASP.NET Application</li>
                                    <li>Creating Setup for ASP.NET application</li>
                                </ul>
                                <li>ASP.NET and Web Services</li>
                                <ul type="circle">
                                    <li>Introducing Web SERVICES</li>
                                    <li>Writing a simple web service</li>
                                    <li>SOAP, WSDL, UDDI</li>
                                    <li>Web service Type Martialling</li>
                                    <li>Using Data in webservice</li>
                                    <li>Web Service Security</li>
                                    <li>Web Service with data set</li>
                                    <li>Using Objects and intrinsic</li>
                                    <li>Overview of WCF</li>
                                    <li>Sample of WCF application</li>
                                </ul>
                                <li>WebParts</li>
                                <ul type="circle">
                                    <li>Overview on Web Parts</li>
                                    <li>Webparts page display modes</li>
                                </ul>
                                <li>Crystal Reports in ASP.NET</li>
                                <ul type="circle">
                                    <li>Introduction to crystal reports, Advantages</li>
                                    <li>Strongly typed and Untyped reports</li>
                                    <li>Creating Crystal Report</li>
                                    <li>Working with Crystal Report Viewer</li>
                                    <li>Accessing Filtered Data through crystal reports</li>
                                    <li>Exporting Crystal Report</li>
                                </ul>
                                <li>ASP.NET4.0 Features</li>
                                <ul type="circle">
                                    <li>Extensible Output Caching</li>
                                    <li>Permanently redirecting a page</li>
                                    <li>Routing in ASP.NET4</li>
                                    <li>Shrinking Session State</li>
                                    <li>Setting Meta Tags</li>
                                    <li>Setting Client IDs</li>
                                    <li>Chart Control</li>
                                </ul>
                                <li>How Web pages are Processing</li>
                                <li>Difference between Response.Redirect and Server.transfer</li>
                                <li>Tracing</li>
                                <ul type="circle">
                                    <li>Page level</li>
                                    <li>Application Level</li>
                                    <li>Custom message in Trace</li>
                                </ul>
                                <li>Changing Language Settings in IE</li>
                                <li>Culture info</li>
                                <li>Resource files</li>
                                <ul type="circle">
                                    <li>Types of Resource files</li>
                                </ul>
                                <li>Storing Images in Database</li>
                                <li>LINQ</li>
                                <ul type="circle">
                                    <li>Linq to Object</li>
                                    <li>Linq to DataSource</li>
                                    <li>Linq to XML</li>
                                    <li>Linq to Database</li>
                                    <li>Advantages of Linq</li>
                                    <li>Calling SP by using Linq</li>
                                </ul>                                
                            </div>
                            <div id="menu3" class="tab-pane fade">
                                <h2 class="title-blue">SQL Training </h2>
                                <strong>SQL Training Topics
                                    <br />
                                </strong>
                                <li>Introduction</li>
                                <ul type="circle">
                                    <li>What is Data</li>
                                    <li>Storing Data in Books and Files</li>
                                    <li>Disadvantages</li>
                                    <li>Flat files or Text files in computer</li>
                                    <li>Drawbacks</li>
                                    <li>Database</li>
                                    <li>Data Store or Data Source</li>
                                    <li>Data Retrieval</li>
                                    <li>Sequel</li>
                                    <li>Security</li>
                                    <li>Data Redundancy and Data inconsistency</li>
                                    <li>Data Integrity</li>
                                    <li>Indexing</li>
                                    <li>OLTP</li>
                                    <li>OLAP</li>
                                </ul>
                                <li>DBMS</li>
                                <ul type="circle">
                                    <li>HDBMS</li>
                                    <li>NDBMS</li>
                                    <li>RDBMS</li>
                                    <li>ORDBMS</li>
                                    <li>OORDBMS</li>
                                </ul>
                                <li>CODD rules</li>
                                <ul type="circle">
                                    <li>Rule1 : Information Rule:</li>
                                    <li>Rule2 : Guaranteed Access Rule</li>
                                    <li>Rule 3: Systematic Treatment of Null Values</li>
                                    <li>Rule 4: Dynamic On-line Catalog Based on the Relational Model</li>
                                    <li>Rule5 : Comprehensive Data Sub-language Rule</li>
                                    <li>Rule6 : View-updating Rule</li>
                                    <li>Rule7 : High-level Insert, Update and Delete</li>
                                    <li>Rule8 : Physical Data Independence</li>
                                    <li>Rule9 : Logical Data Independence</li>
                                    <li>Rule 10: Integrity Independence</li>
                                    <li>Rule 11: Distribution Independence</li>
                                    <li>Rule 12: Non-subversion Rule</li>
                                </ul>
                                <li>Normalization</li>
                                <ul type="circle">
                                    <li>Anomalies DBMS</li>
                                    <li>First Normal Form</li>
                                    <li>Second Normal Form</li>
                                    <li>Third Normal Form</li>
                                    <li>Boyce Codd normal form (BCNF)</li>
                                    <li>NF (Fourth Normal Form) Rules</li>
                                    <li>NF (Fifth Normal Form) Rules</li>
                                    <li>NF (Sixth Normal Form) Proposed</li>
                                </ul>
                                <li>SQL Commands types</li>
                                <ul type="circle">
                                    <li>DDL</li>
                                    <li>DML</li>
                                    <li>DQL</li>
                                    <li>DCL</li>
                                    <li>TCL</li>
                                </ul>
                                <li>SQL Server</li>
                                <ul type="circle">
                                    <li>Other Popular Databases</li>
                                    <li>SQL Versions</li>
                                    <li>Database Types</li>
                                    <li>Server Types</li>
                                    <li>Authentication</li>
                                    <li>Working with SQL Server</li>
                                    <li>Express Edition</li>
                                    <li>SQL Database Components</li>
                                </ul>
                                <li>Data Types in SQL Server</li>
                                <ul type="circle">
                                    <li>Numeric data type</li>
                                    <li>Date and Time</li>
                                    <li>Character Strings</li>
                                    <li>Binary data types</li>
                                    <li>Other Data Types</li>
                                </ul>
                                <li>Table</li>
                                <ul type="circle">
                                    <li>Creating a Table</li>
                                    <li>Inserting Values into a Table</li>
                                    <li>Inserting Values into selected columns</li>
                                    <li>Retrieving all records of the data</li>
                                    <li>Retrieving selected columns</li>
                                    <li>Update Command</li>
                                    <li>Delete Command</li>
                                    <li>Dropping a Table</li>
                                </ul>
                                <li>Data Integrity</li>
                                <ul type="circle">
                                    <li>Entity Integrity</li>
                                    <li>Domain Integrity</li>
                                    <li>Referential Integrity</li>
                                </ul>
                                <li>Constraints</li>
                                <ul type="circle">
                                    <li>Primary Key</li>
                                    <li>Not Null</li>
                                    <li>Null</li>
                                    <li>Unique</li>
                                    <li>Unique + not null or Candidate key</li>
                                    <li>Composite primary key</li>
                                    <li>Checked</li>
                                    <li>Default</li>
                                    <li>Foreign key</li>
                                    <li>Delete Rules</li>
                                    <li>Update Rules</li>
                                    <li>Providing default value for a column</li>
                                    <li>Self Referential Integrity</li>
                                </ul>
                                <li>Alter Table Command</li>
                                <ul type="circle">
                                    <li>Adding a new column under a table</li>
                                    <li>Add a new Constraint</li>
                                    <li>Adding a primary key on existing column</li>
                                    <li>Drop an existing constraint in a table</li>
                                    <li>Disable or Re enable check constraint of a table</li>
                                    <li>Drop a Table Command</li>
                                    <li>Truncate Table Command</li>
                                    <li>Select Command</li>
                                </ul>
                                <li>Clauses</li>
                                <ul type="circle">
                                    <li>Where Clause</li>
                                    <li>Group by Clause</li>
                                    <li>Having Clause</li>
                                    <li>Order by Clause</li>
                                    <li>Clarifications</li>
                                </ul>
                                <li>Built-in Functions</li>
                                <ul type="circle">
                                    <li>Mathematical Functions</li>
                                    <li>String Functions</li>
                                    <li>DataTypes Functions</li>
                                </ul>
                                <li>Date And Time Functions</li>
                                <ul type="circle">
                                    <li>GetDate()</li>
                                    <li>GetUTCDate()</li>
                                    <li>SystemDateTime()</li>
                                    <li>SysDateTimeOffset()</li>
                                    <li>SysUTCDateTime()</li>
                                    <li>DateName()</li>
                                    <li>DatePart(DatePart,Date)</li>
                                    <li>Day(Date)</li>
                                    <li>Month(Date)</li>
                                    <li>Year(Date)</li>
                                    <li>DateDiff</li>
                                    <li>DateAdd</li>
                                    <li>DateFromParts</li>
                                    <li>TimeFromParts</li>
                                    <li>IsDate(expression)</li>
                                    <li>SetDateFormat(Format)</li>
                                </ul>
                                <li>Conversion Functions</li>
                                <ul type="circle">
                                    <li>Cast (Expression AS Data Type(Length))</li>
                                    <li>Convert()</li>
                                </ul>
                                <li>SystemFunctions</li>
                                <ul type="circle">
                                    <li>Host_ID()</li>
                                    <li>Host_Name()</li>
                                    <li>IsNumeric(Expression)</li>
                                    <li>IsNull()</li>
                                    <li>Coalesce(expression)</li>
                                    <li>NullIf(expression, expression)</li>
                                </ul>
                                <li>Case</li>
                                <ul type="circle">
                                    <li>Simple Case Expression</li>
                                    <li>Searched Case Expression</li>
                                </ul>
                                <li>MetaData Functions</li>
                                <ul type="circle">
                                    <li>App_Name()</li>
                                    <li>Col_Length ()</li>
                                    <li>DB_ID ()</li>
                                    <li>DB_Name ()</li>
                                    <li>Object_ID ()</li>
                                    <li>Object Name ()</li>
                                    <li>Call Name ()</li>
                                </ul>
                                <li>Ranking Functions</li>
                                <ul type="circle">
                                    <li>Top Clause</li>
                                    <li>Rank() over()</li>
                                    <li>Dense Rank() over()</li>
                                    <li>Row Number() over()</li>
                                    <li>NTILE() over()</li>
                                </ul>
                                <li>Aggregate Functions</li>
                                <ul type="circle">
                                    <li>Distinct keyword</li>
                                    <li>Count()</li>
                                    <li>Count big()</li>
                                    <li>Sum(Distinct)</li>
                                    <li>AVG(Distinct)</li>
                                    <li>Min(Distinct)</li>
                                    <li>Max(Distinct)</li>
                                    <li>STDEV(Distinct)</li>
                                    <li>Var(Distinct)</li>
                                </ul>
                                <li>Operators</li>
                                <ul type="circle">
                                    <li>Arithmetic Operators (+, , *, /, %)</li>
                                    <li>Assignment Operators (=)</li>
                                    <li>Comparisons Operators (=, &gt;, &lt;, &gt;=, &lt;=, &lt;&gt;, !=, !&lt;, !&gt;)</li>
                                    <li>Compound Operators(+=, =, *=, /=, %=)</li>
                                    <li>Logical Operators</li>
                                    <li>Set Operators</li>
                                    <li>String Concatenation operators</li>
                                </ul>
                                <li>Giving Alias Names to Columns</li>
                                <li>Offset and Fetch Options</li>
                                <ul type="circle">
                                    <li>Fetch</li>
                                    <li>Sub-Queries</li>
                                    <li>Co-related Sub Queries</li>
                                </ul>
                                <li>Joins</li>
                                <ul type="circle">
                                    <li>Inner join</li>
                                    <li>Outer join</li>
                                    <li>Self Join</li>
                                    <li>Equijoin</li>
                                    <li>NonEquijoin</li>
                                    <li>Cross join or Cartesian join</li>
                                </ul>
                                <li>Sequence</li>
                                <ul type="circle">
                                    <li>Cache</li>
                                </ul>
                                <li>View</li>
                                <ul type="circle">
                                    <li>Create View:</li>
                                    <li>Force View Creation</li>
                                    <li>Update a View</li>
                                    <li>NonUpdatable OR Read-Only View</li>
                                    <li>Check option in view</li>
                                    <li>Deleting Rows into a View</li>
                                    <li>Dropping Views</li>
                                    <li>View Classification</li>
                                    <li>Benefits of View</li>
                                    <li>View with Encryption</li>
                                    <li>View With Schema Binding</li>
                                </ul>
                                <li>Meta Data Tables</li>
                                <ul type="circle">
                                    <li>SysObjects</li>
                                    <li>SysColumns</li>
                                    <li>SysComments</li>
                                    <li>How Data is stored under a database</li>
                                    <li>How Database engine retrieves data information from database</li>
                                </ul>
                                <li>Index</li>
                                <ul type="circle">
                                    <li>why do you need to index your tables?</li>
                                    <li>Clustered index</li>
                                    <li>Non Clustered Index</li>
                                    <li>Difference between clustered and non clustered index</li>
                                    <li>Unique Index</li>
                                    <li>How many indexes a table can have?</li>
                                    <li>When SQL Server uses indexes</li>
                                    <li>When should we create indexes on a table</li>
                                    <li>Indexed Views</li>
                                </ul>
                                <li>PL/SQL or TSQL</li>
                                <ul type="circle">
                                    <li>Drawbacks of SQL</li>
                                    <li>Anonymous Blocks</li>
                                    <li>PL/SQL Program structure</li>
                                    <li>Conditional statements</li>
                                </ul>
                                <li>Cursor</li>
                                <ul type="circle">
                                    <li>Types of Cursors</li>
                                    <li>Components of Cursors</li>
                                    <li>Cursor Scope</li>
                                    <li>Data Fetch Option in Cursors</li>
                                    <li>Types of cursors</li>
                                    <li>Types of Locks</li>
                                    <li>Example with Cursors</li>
                                </ul>
                                <li>SubPrograms</li>
                                <li>Stored Procedures</li>
                                <ul type="circle">
                                    <li>Types of stored procedure</li>
                                    <li>Create stored procedure</li>
                                    <li>Calling a stored Procedures</li>
                                    <li>Procedure with parameters</li>
                                    <li>Calling a procedure with parameters</li>
                                    <li>Stored Procedure with default values</li>
                                    <li>Stored Procedure with output parameters</li>
                                    <li>Stored Procedure Help Text</li>
                                    <li>Procedure attributes</li>
                                </ul>
                                <li>Error Handling</li>
                                <ul type="circle">
                                    <li>Handling Errors in SQL Server</li>
                                    <li>Pre-Defined Errors</li>
                                    <li>Raising Errors explicitly in a programming</li>
                                    <li>Deleting Our Error Messages from SysMessages</li>
                                </ul>
                                <li>Functions</li>
                                <ul type="circle">
                                    <li>Difference between Function and Procedure</li>
                                    <li>Different Types of functions</li>
                                </ul>
                                <li>Triggers</li>
                                <ul type="circle">
                                    <li>DML Triggers</li>
                                    <li>DDL Triggers</li>
                                    <li>Syntax</li>
                                    <li>Types of Triggers</li>
                                    <li>DDL Triggers and Logon Triggers</li>
                                    <li>Logon Triggers</li>
                                </ul>
                                <li>Temporary Tables</li>
                                <li>Copying database from one machine to another</li>
                                <ul type="circle">
                                    <li>Backup and Restore</li>
                                    <li>Copying mdf and ldf files with database</li>
                                    <li>Generating a script file to the complete database and its objects</li>
                                </ul>
                                <li>SQL Server Reporting Services</li>
                                <ul type="circle">
                                    <li>Creating a simple report</li>
                                    <li>Creating a new Report</li>
                                    <li>Shared Data Resources</li>
                                    <li>Drilldown reports</li>
                                    <li>Matrix Reports</li>
                                    <li>Parameterized Reports</li>
                                    <li>Designing Reports Manually</li>
                                    <li>Displaying Images into Reports</li>
                                </ul>
                            </div>
                            <div id="menu4" class="tab-pane fade">
                                <h2 class="title-blue">MVC Training </h2>
                                <strong>MVC Training Topics
                                    <br />
                                </strong>
                                <li>MVC</li>
                                <ul type="circle">
                                    <li>What is MVC</li>
                                </ul>
                                <li>Modules in MVC</li>
                                <ul type="circle">
                                    <li>Model</li>
                                    <li>View</li>
                                    <li>Controller</li>
                                </ul>
                                <li>Technologies Supporting MVC</li>
                                <li>ASP.NET MVC</li>
                                <ul type="circle">
                                    <li>What is ASP.NET MVC</li>
                                    <li>Version History of ASP.NET MVC</li>
                                    <li>ASP.NET MVC features</li>
                                </ul>
                                <li>Developing ASP.NET MVC Application</li>
                                <ul type="circle">
                                    <li>ASP.NET framework provides templates</li>
                                </ul>
                                <li>Folder Structure of ASP.NET application</li>
                                <ul type="circle">
                                    <li>APP_Start</li>
                                    <li>Content</li>
                                    <li>Controller</li>
                                    <li>Models</li>
                                    <li>Scripts</li>
                                    <li>Views</li>
                                    <li>MVC Application Example</li>
                                </ul>
                                <li>Controllers in ASP.NET MVC</li>
                                <ul type="circle">
                                    <li>Responsibilities of Controller</li>
                                    <li>Developing Controllers</li>
                                    <li>Rules for Creating Controller</li>
                                    <li>Controller class hierarchy</li>
                                    <li>Library Information</li>
                                    <li>Action Methods</li>
                                    <li>Developing action Methods</li>
                                    <li>Details about action Method</li>
                                    <li>Rules to create action Method</li>
                                    <li>Controller class hierarchy</li>
                                </ul>
                                <li>Action Methods</li>
                                <ul type="circle">
                                    <li>Types of Action Methods</li>
                                </ul>
                                <li>Views in ASP.NET MVC</li>
                                <ul type="circle">
                                    <li>View Engine</li>
                                    <li>Roger Programming</li>
                                    <li>Developing Data Entry Forms in ASP.NET MVC Application</li>
                                    <li>Identifying Request Type in Views</li>
                                    <li>HTML helpers in MVC View development</li>
                                </ul>
                                <li>Action Method Parameters</li>
                                <ul type="circle">
                                    <li>Request Type Attribute</li>
                                    <li>Action Method Parameters</li>
                                </ul>
                                <li>Model Class Objects</li>
                                <ul type="circle">
                                    <li>Get Action Method Parameters</li>
                                    <li>Data Sharing between Control to View</li>
                                    <li>Benefits</li>
                                    <li>Steps to work with strongly typed view</li>
                                    <li>Models in ASP.NET MVC</li>
                                    <li>Classes in model</li>
                                </ul>
                                <li>Entity Framework</li>
                                <ul type="circle">
                                    <li>What is ORM</li>
                                    <li>ORM tools</li>
                                    <li>ORM tools Classes</li>
                                    <li>Entity Framework Methods</li>
                                    <li>Scaffolding templates in MVC</li>
                                    <li>Lambda Expressions</li>
                                    <li>Applications of Lambda Expression</li>
                                </ul>
                                <li>LinQ</li>
                                <ul type="circle">
                                    <li>What is LinQ</li>
                                    <li>LinQ Programming Implementation</li>
                                    <li>Relationship in Entity Framework</li>
                                    <li>Entity Framework Implementation Approaches</li>
                                </ul>
                                <li>Data Annotations and Validations</li>
                                <ul type="circle">
                                    <li>What is Data Annotations</li>
                                    <li>Library Info</li>
                                    <li>Validation Attributes</li>
                                    <li>Additional Attributes</li>
                                </ul>
                                <li>Layout Views in MVC Application</li>
                                <ul type="circle">
                                    <li>What is Layout View</li>
                                    <li>Advantages</li>
                                    <li>Files that are involved in View processing</li>
                                    <li>Important Statements in Layout View</li>
                                    <li>Steps for creating Layout Views</li>
                                </ul>
                                <li>Filters in ASP.NET MVC</li>
                                <ul type="circle">
                                    <li>Pre Defined Filters</li>
                                    <li>What is custom filters</li>
                                    <li>Types of Filters in MVC</li>
                                    <li>How to develop custom filters</li>
                                    <li>Method Arguments</li>
                                    <li>Security in ASP.NET MVC Application</li>
                                    <li>Steps to implement security</li>
                                </ul>
                                <li>Ajax programming in ASP.NET MVC using JQuery</li>
                                <li>How to implement Ajax Programming</li>
                                <ul type="circle">
                                    <li>What is JQuery</li>
                                </ul>
                                <li>Routing in ASP.NET MVC</li>
                                <ul type="circle">
                                    <li>What is customizing Routes</li>
                                    <li>What are the advantages of Routing</li>
                                </ul>
                                <li>Web API</li>
                                <ul type="circle">
                                    <li>What is Web API</li>
                                    <li>HTTP Client class Methods</li>
                                </ul>
                                <li>BootStrap in MVC</li>
                                <ul type="circle">
                                    <li>What is Bootstrap</li>
                                    <li>How to Apply BootStrap CSS classes to HTML Tags</li>
                                    <li>What is minification</li>
                                    <li>Advantages</li>
                                    <li>What is bundling</li>
                                    <li>What is view model? Why do we use this concept</li>
                                    <li>How to use output cache attribute in ASP.NET MVC</li>
                                    <li>What is partial view in MVC</li>
                                    <li>How to create Partial View</li>
                                </ul>
                                <li>Glossary</li>
                            </div>

                            <div id="menu5" class="tab-pane fade">
                                <h3 class="title-blue">Advanced Technologies</h3>
                                <div class="container">
                                    <ul class="nav nav-pills tab-size">
                                        <li class="active"><a data-toggle="pill" href="#menu6">JQuery</a></li>
                                        <li><a data-toggle="pill" href="#menu7">AJAX</a></li>
                                        <li><a data-toggle="pill" href="#menu8">Angular JS</a></li>
                                        <li><a data-toggle="pill" href="#menu9">XML</a></li>
                                    </ul>

                                    <div class="tab-content">
                                        <div id="menu6" class="tab-pane fade in active">
                                            <strong>JQuery Trining Topics
                                                <br />
                                            </strong>
                                            <li>What is Jquery</li>
                                            <li>Supported Browsers</li>
                                            <li>Jquery Library</li>
                                            <ul type="circle">
                                                <li>How to integrate Jquery in web pages</li>
                                                <li>Import Jquery library in your web pages</li>
                                            </ul>
                                            <li>Jquery Features</li>
                                            <ul type="circle">
                                                <li>DOM Traversing</li>
                                                <li>DOM manipulation</li>
                                                <li>Effects in Jquery</li>
                                                <li>Ajax Supporting in Jquery</li>
                                                <li>Light-weight</li>
                                                <li>CSS complaint</li>
                                                <li>Cross browser</li>
                                            </ul>
                                            <li>JavaScript programming Basics</li>
                                            <ul type="circle">
                                                <li>Programming Rules in JavaScript</li>
                                            <ul type="circle">
                                                <li>Include JavaScript in web pages</li>
                                                <li>Accessing reference of html elements</li>
                                                <li>Creating variables</li>
                                                <li>Numeric Conversion</li>
                                                <li>Creating functions in JavaScript</li>
                                                <li>Event Handling in JavaScript</li>
                                            </ul>
                                            </ul>
                                            
                                            <li>Appling Styles in Web pages</li>
                                            <ul type="circle">
                                                <li>Defining Styles</li>
                                                <li>Implementation of CSS</li>
                                                <li>Advantages</li>
                                                <li>Style Properties</li>
                                            </ul>
                                            <li>Developing Web pages using JQuery</li>
                                            <ul type="circle">
                                                <li>Required Software</li>
                                                <li>Steps to implement</li>
                                            </ul>
                                            <li>Programming Items of Jquery</li>
                                            <ul type="circle">
                                                <li>$(Document)</li>
                                                <li>Ready()</li>
                                                <li>Function()</li>
                                            </ul>
                                            <li>Selectors in JQuery</li>
                                            <ul type="circle">
                                                <li>Tag based</li>
                                                <li>Id based</li>
                                                <li>Class based</li>
                                                <li>Select all elements</li>
                                                <li>Select multiple elements</li>
                                                <li>Select Document</li>
                                                <li>Current Item Selection</li>
                                            </ul>
                                            <li>Jquery Methods to get and set the content of html elements</li>
                                            <ul type="circle">
                                                <li>Val()</li>
                                                <li>Text()</li>
                                                <li>Html()</li>
                                                <li>Attr()</li>
                                            </ul>
                                            <li>Styles in JQuery</li>
                                            <ul type="circle">
                                                <li>CSS (Prop, Value)</li>
                                                <li>Multiple Properties</li>
                                                <li>Add()</li>
                                                <li>Remove class()</li>
                                                <li>Toggle Class()</li>
                                            </ul>
                                            <li>DOM Traversing in JQuery</li>
                                            <ul type="circle">
                                                <li>Traversing individual items</li>
                                                <li>Traversing alternative items</li>
                                                <li>DOM Tree based Traversing</li>
                                                <li>Traveling filtered items</li>
                                                <li>Traversing not filtered elements</li>
                                            </ul>
                                            <li>DOM Manipulations</li>
                                            <ul type="circle">
                                                <li>Content Based</li>
                                                <li>Structure Based</li>
                                            </ul>
                                            <li>Effects in JQuery</li>
                                            <ul type="circle">
                                                <li>Functions used to apply effects in Jquery</li>
                                            </ul>
                                            <li>Data Handling using Jquery</li>
                                            <ul type="circle">
                                                <li>Scalar Data</li>
                                                <li>Array</li>
                                                <li>Object</li>
                                                <li>Array of Objects</li>
                                            </ul>
                                            <li>Ajax Programming in Jquery</li>
                                            <ul type="circle">
                                                <li>Advantages of Ajax</li>
                                                <li>Disadvantages of Ajax</li>
                                                <li>Implement Ajax Programming</li>
                                            </ul>
                                            <li>JSON</li>
                                            <ul type="circle">
                                                <li>Advantages of JSON over XML</li>
                                                <li>Example of JSON objects</li>
                                            </ul>
                                            <li>Jquery UI</li>
                                            <ul type="circle">
                                                <li>Implementation</li>
                                                <li>Jquery-UI interaction</li>
                                            </ul>
                                            <li>Jquery-UI widgets</li>
                                            <ul type="circle">
                                                <li>Button()</li>
                                                <li>Accordian Panel</li>
                                                <li>Tooltip</li>
                                                <li>Tabs</li>
                                                <li>Auto Complete</li>
                                                <li>Date Picker</li>
                                                <li>Dialog</li>
                                                <li>Menu()</li>
                                            </ul>
                                            <li>Jquery-UI Themes</li>
                                            <ul type="circle">
                                                <li>The Jquery UI themes folder structure</li>
                                            </ul>
                                            <li>Jquery-UI effects</li>
                                            <ul type="circle">
                                                <li>Add Class</li>
                                                <li>Color Animation</li>
                                                <li>Easing</li>
                                                <li>Effect</li>
                                                <li>Hide</li>
                                                <li>Remove Class</li>
                                                <li>Show</li>
                                                <li>Switch Class</li>
                                                <li>Toggle</li>
                                                <li>Toggle Class</li>
                                            </ul>
                                            <li>JQuery-Utilities</li>
                                            <ul type="circle">
                                                <li>Position</li>
                                                <li>Widget Factory</li>
                                            </ul>
                                            <li>Jquery Plug-ins</li>
                                            <ul type="circle">
                                                <li>How to Install Jquery Plug-in</li>
                                                <li>Types off JQuery Plug-in's</li>
                                            </ul>
                                        </div>
                                        <div id="menu7" class="tab-pane fade">
                                            <strong>AJAX Trining Topics
                                                <br />
                                            </strong>
                                            <li>Introduction to Ajax</li>
                                            <li>What is Ajax</li>
                                            <li>Advantages of AJAX</li>
                                            <li>Disadvantages of AJAX</li>
                                            <li>What is Asp.Net AJAX?</li>
                                            <li>Ajax in ASP.Net</li>
                                            <li>Programming Techniques of Ajax</li>
                                            <li>Basic Controls of ASP.NET AJAX</li>
                                            <ul type="circle">
                                                <li>Script Manager</li>
                                                <li>Script Manager Proxy</li>
                                                <li>Timer</li>
                                                <li>Update Panel</li>
                                                <li>Update Progress</li>
                                            </ul>
                                            <li>How to Download Add Ajax Toolkit to Visual Studio 2015 IDE</li>
                                            <li>Extender Controls</li>
                                            <ul type="circle">
                                                <li>Confirm Button Extender</li>
                                                <li>Calendar Extender</li>
                                                <li>Filtered Textbox Control</li>
                                                <li>NumericUpDown Extender</li>
                                                <li>Paging Bulleted List Control</li>
                                                <li>Password Strength Control</li>
                                                <li>Drag Panel Extender Control</li>
                                                <li>Drop Down Extender Control</li>
                                                <li>Collapsible Panel Extender Control</li>
                                                <li>Slider Extender Control</li>
                                                <li>Resizable Control Extender</li>
                                                <li>Mutually Exclusive Checkbox Extender</li>
                                                <li>Popup Control Extender</li>
                                                <li>Validator Callout Extender</li>
                                                <li>Model Popup Extender</li>
                                                <li>List search extender control</li>
                                                <li>Drop Shadow Extender control</li>
                                                <li>Hover menu Extender control</li>
                                                <li>Masked edit Extender and Masked edit Validator</li>
                                                <li>Rounded corner control</li>
                                                <li>Always visible Extender control</li>
                                                <li>Textbox water mark extender control</li>
                                                <li>Cascading dropdown extender control</li>
                                                <li>Auto complete extender control</li>
                                                <li>Slide show extender control</li>
                                                <li>Toggle Button Extender control</li>
                                            </ul>
                                            <li>Non-Extender Controls</li>
                                            <ul type="circle">
                                                <li>Accordian and Accordian Pane</li>
                                                <li>Tab container</li>
                                                <li>Rating</li>
                                                <li>Nobot Control</li>
                                            </ul>
                                        </div>
                                        <div id="menu8" class="tab-pane fade">
                                            <strong>Angular JS Trining Topics
                                                <br />
                                            </strong>
                                            <li>Introduction to Angular JS</li>
                                            <li>Single Page Application</li>
                                            <li>Challenges for SPA(Simple Page Application) using JS and HTML</li>
                                            <li>Challenges in Modern web application development</li>
                                            <li>Java Script VS JQuery VS Angular JS</li>
                                            <li>Java Script Request Flow</li>
                                            <li>JQuery Library and Execution Flow</li>
                                            <li>Angular Framework</li>                                 
                                            <li>MVC Framework</li>
                                            <li>Angular MVC Pattern</li>
                                            <li>Execution Flow</li>
                                            <li>Features of Angular JS</li>
                                            <li>Create End to End Application</li>                                                                      
                                            <li>JavaScript language basics</li>
                                            <ul type="circle">
                                                <li>Variables</li>
                                                <li>Shadowing</li>
                                                <li>JavaScript Data types</li>
                                                <ul type="circle">
                                                    <li>Primitive Type</li>
                                                    <li>Non Primitive Type</li>
                                                </ul>
                                            </ul>
                                            <li>Creating a new Angular application in Web Storm</li>
                                            <ul type="circle">
                                                <li>Components of Angular</li>
                                            </ul>
                                            <li>Directives</li>                                        
                                            <li>Commonly use Directives in Angular</li>
                                            <li>Modules in Angular</li>
                                            <ul type="circle">
                                                <li>Why a Module is required in Angular JS</li>
                                            </ul>
                                            <li>Controllers</li>                                           
                                            <ul type="circle">
                                                <li>ng- src Directive</li>
                                                <li>nested ng-repeat</li>
                                                <li>ng-repeat directive</li>
                                                <li>ng-init directive</li>
                                                <li>ng-include directive</li>
                                                <li>ng-bind-html directive</li>
                                                <li>ng-bind template</li>
                                                <li>ng-blur directive</li>
                                                <li>ng-checked</li>
                                                <li>ng-copy</li>
                                                <li>ng-cut</li>
                                                <li>ng-paste</li>
                                                <li>ng-class</li>
                                                <li>ng-class-even, ng-class-odd</li>
                                                <li>ng-class-with CSS Animation</li>
                                                <li>ng-pattern</li>
                                                <li>ng-href</li>
                                                <li>ng-maxlength</li>
                                                <li>ng-minlength</li>
                                                <li>ng-if</li>
                                                <li>ng-required</li>
                                                <li>ng-open</li>
                                                <li>ng-required(copy)</li>
                                                <li>ng-selected</li>
                                                <li>ng-style</li>
                                                <li>ng-animate</li>
                                            </ul>
                                            <li>Qualifiers</li>
                                            <li>Angular directives to handle key-events</li>
                                            <li>Attributes</li>
                                            <li>Mouse Events</li>
                                            <ul type="circle">
                                                <li>Member of Mouse Events</li>
                                            </ul>
                                            <li>Filters</li>
                                            <ul>
                                                <li>Validate date formats in date filters</li>
                                                <li>Applying filters on product table</li>
                                                <li>Displaying Numbers</li>
                                                <li>Displaying Currency</li>
                                                <li>Sorting on any field</li>
                                                <li>Filtering records based on specified static values</li>
                                                <li>Enabling Strict search</li>
                                                <li>Sorting Data</li>
                                            </ul>
                                            <li>Angular Functions</li>
                                            <ul type="circle">
                                                <li>Bootstrap method</li>
                                                <li>Element method</li>
                                                <li>Copy method</li>
                                                <li>Equals method</li>
                                            </ul>
                                            <li>Services</li>
                                            <ul type="circle">
                                                <li>Angular Services</li>
                                                <li>$HTTP Services</li>
                                                <li>$Timeout Service</li>
                                                <li>$Interval</li>
                                                <li>$Log Service</li>
                                                <li>$Window Service</li>
                                                <li>$filter Service</li>
                                                <li>$Location Service</li>
                                                <li>Location Hash Service</li>
                                                <li>Accessing the recent location</li>
                                            </ul>
                                            <li>Validations</li>
                                            <ul type="circle">
                                                <li>Validations using patterns</li>
                                                <li>Validations using functions</li>
                                            </ul>
                                            <li>Angular form states for validation</li>
                                            <li>Input field states for validation</li>
                                            <li>Angular styles for form validation</li>
                                            <li>Form validations with bootstrap</li>
                                            <li>Form validations in angular</li>
                                            <ul type="circle">
                                                <li>Form validations using angular messages</li>
                                            </ul>
                                            <li>Distributed Computing</li>
                                            <ul type="circle">
                                                <li>CORBA</li>
                                                <li>DCOM</li>
                                                <li>RMI</li>
                                          
                                                <li>EJB</li>
                                                <li>Remoting</li>
                                            </ul>
                                            <li>Web services</li>
                                            <ul type="circle">
                                                <li>SOAP</li>
                                                <li>REST</li>
                                                <li>JSON</li>
                                            </ul>
                                            <li>Java Script Ajax Request to handle JSON</li>
                                            <li>JQuery Ajax Request to handle JSON</li>
                                            <li>Angular Ajax Request to handle JSON</li>
                                            <li>Ajax options for Angular</li>
                                            <li>Tracking the status of Ajax Requests</li>
                                            <li>Routing in Angular</li>
                                            <strong>Node JS Training Topics</strong>
                                            <ul>
                                                <li>Working with Node JS</li>
                                                <li>Installation of Node JS</li>
                                                <li>Configuring Node JS with Angular Project</li>
                                                <li>Features of Node JS</li>
                                                <li>Components of Node JS</li>
                                                <li>Working with Node Terminal</li>
                                                <li>REPL Commands</li>
                                                <li>Connecting with MySQL database using Node JS</li>
                                                <li>Code for production to communicate with Database</li>
                                                <li>Connection Pool</li>
                                                <li>Executing queries to manipulate data using Node JS</li>
                                                <li>Creating a Rest API in Node JS</li>
                                                <li>Requirements to create a rest API</li>
                                                <li>Web application framework in Node JS</li>
                                                <li>Creating a server in Node JS to integrate with client and access files from web server</li>
                                            </ul>
                                            <strong>Express JS Training Topics</strong>
                                            <ul>
                                                <li>Install the packages</li>
                                                <li>Create a middleware to access the root folder using node server</li>
                                                <li>Routing in Express</li>
                                                <li>Accessing data from MySQLDatabase using Node JS and Express</li>
                                                <li>Routing in CRUD - Project to access the product details, create edit and delete views</li>
                                                <li>Details controller</li>
                                                <li>Edit controller</li>
                                                <li>Delete Controller</li>
                                                <li>Mango DB</li>
                                                <li>Features of Mango DB</li>
                                                <li>Connecting with Mango DB and accessing Data</li>
                                                <li>Connecting from angular application</li>
                                                <li>Custom Directive</li>
                                                <li>Create a custom directive</li>
                                                <li>Restricting an element and accessing parallel view</li>
                                                <li>Custom Filter	</li>
                                                <li>Custom Services</li>
                                                <li>Servletwith Angular Integration</li>
                                                <li>Shopping Cart</li>

                                            </ul>

                                        </div>
                                        <div id="menu9" class="tab-pane fade">
                                            <strong>XML Training Topics Trining Topics </strong>
                                            <br />
                                            <li>XML introduction</li>
                                            <ul type="circle">
                                                <li>Xml</li>
                                                <li>Markup</li>
                                                <li>XML Purpose</li>
                                                <li>Elements</li>
                                                <li>XML Elements Naming Rules</li>
                                            </ul>
                                            <li>Attributes</li>
                                            <ul type="circle">
                                                <li>Entity References</li>
                                                <li>Comments in XML</li>
                                            </ul>
                                            <li>Examples on XML document</li>
                                            <ul type="circle">
                                                <li>Similarities between HTML and XML</li>
                                                <li>Differences between HTML and XML</li>
                                                <li>What is well-formed XML document</li>
                                            </ul>
                                            <li>DTD (Data Type Definition)</li>
                                            <ul type="circle">
                                                <li>Element Declaration</li>
                                                <li>Attribute Declaration</li>
                                                <li>Entities Declaration</li>
                                                <li>PCDATA Section</li>
                                                <li>CDATA Section</li>
                                                <li>Internal DTD</li>
                                                <li>External DTD</li>
                                            </ul>
                                            <li>DTD Types of Elements</li>
                                            <ul type="circle">
                                                <li>Text-Only Elements</li>
                                                <li>Child Only Elements</li>
                                                <li>Mixed Elements</li>
                                                <li>Empty Elements</li>
                                                <li>ANY Elements</li>
                                            </ul>
                                            <li>Declaring Attributes</li>
                                            <ul type="circle">
                                                <li>A Default Attribute Value</li>
                                                <li>#Required Attributes</li>
                                                <li>Enumerated type Attributes</li>
                                                <li>ID type Attribute</li>
                                                <li>IDREF type Attribute</li>
                                                <li>NMTOKEN type Attribute</li>
                                                <li>NOTATION type</li>
                                                <li>Entity type Attribute</li>
                                                <li>Entities type Attribute</li>
                                            </ul>
                                            <li>XSD (XML Schema Definition)</li>
                                            <ul type="circle">
                                                <li>What is XSD</li>
                                                <li>Difference between DTD and XSD</li>
                                                <li>XSD Data Types</li>
                                                <li>XSD Namespace</li>
                                                <li>XSD Restrictions</li>
                                                <li>Non-Atomic Data Types</li>
                                                <li>Complex Type Data Types</li>
                                            </ul>
                                            <li>JAX-P</li>
                                            <ul>
                                                <li>Overview of JAX-P</li>
                                                <li>Responsibilities of Parsers</li>
                                                <li>DOM parser</li>
                                                <li>SAX Parser</li>
                                                <li>STAX Parser</li>
                                            </ul>
                                            <li>JAXB-Notes</li>
                                            <ul>
                                                <li>Features of JAXB</li>
                                                <li>JAX-B Annotations</li>
                                            </ul>

                                        </div>

                                    </div>
                                </div>
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