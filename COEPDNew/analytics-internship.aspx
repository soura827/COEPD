<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true" CodeFile="analytics-internship.aspx.cs" Inherits="Analytics_Internship" %>
<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
internship for Data Science | Data Science Internship In Hyderabad
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="Server">
    <link rel="canonical" href="https://www.coepd.com/analytics-internship.html" />
    <meta name="description" content="COEPD provide Data Science Internship In Hyderabad to get hands on experience on real time projects. We also provide R Language training with experienced trainers." />
    <meta name="keywords" content="data science internship,data science internship in Hyderabad,data science course,data science certification,r language,r programming,data science jobs,data science jobs in hyderabad." />
    <script src="js/jssor.slider.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cpContent" runat="Server">
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
                    <h1 class="title-blue">Data Science Internship Programs
                    </h1>
                    <p class="row">
                        <!-- Go to www.addthis.com/dashboard to customize your tools -->
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
                    <strong>We are glad to announce that we have introduced Data Science Internship Programs (Self sponsored) for professionals who want to have hands on experience. </strong>
                    <p>
                        With associations with IT Companies, we are providing this program. Presently, this program is available in COEPD Hyderabad premises. 
                    </p>
                    <p>
                        R language has been the game changer in Data Analytics industry.  It is the most popular analytical software compared to any of its rival commercial
                         Data Analytics products. R has the potential to offer bright job prospects for both fresher and experienced. R Language is ranked at 8th position 
                        in TIOBE language rankings.  At COEPD, we provide finest Data Science and R-Language training. At COEPD, we provide finest Datascience training.
                    </p>
                    <p>
                        This internship is intelligently dedicated to our avid and passionate participants predominantly acknowledging and appreciating the fact that they are on the path of making a career in Data Science discipline. 
                       This internship is designed to ensure that in addition to gaining the requisite theoretical knowledge, the readers gain sufficient hands-on practice and practical know-how to master the nitty-gritty of the Data Science profession.  
                       More than a training institute, COEPD today stands differentiated as a mission to help you "Build your dream career" - COEPD way.
                    </p>
                    <strong>Pre - Requisites: </strong>
                    <ul>
                        <li>Should be Graduate</li>
                        <li>Basic Communication Skills</li>
                        <li>Basic Computer awareness Skills.</li>
                    </ul>
                    <strong>What you will do as an Intern?</strong>
                    <ul class="hand-bullets">
                        <li>Undergo training for required courses </li>
                        <li>Understand client requirements</li>
                        <li>Develop required code to meet clients requirements</li>
                        <li>Document the in line code</li>
                        <li>Test the developed code</li>
                        <li>Deploy the code</li>
                        <li>Capture client’s acceptance</li>&nbsp
                        <li><b>"Complete one International Certification" - expense covered in Internship Fees.</b></li>
                    </ul>
                    <h2>Highlights of the course</h2>
                    <ul class="nav nav-pills tab-size">
                        <li class="active">
                            <a data-toggle="pill" href="#home">R-Language</a>
                        </li>
                    </ul>
                    <li>Introduction to R  
                        <ul type="circle">
                            <li>What is R?</li>
                            <li>Downloading and Installing R</li>
                         </ul> 
                    </li>   
                     <li>Getting data into R 
                         <ul type="circle">
                             <li>Typing in small data sets </li>
                                <li>Concatenating data with the c function </li>
                                <li>Combining variables with c, cbind & rbind functions </li>
                                <li>Combining data with the vector function </li>
                                <li>Combining data with the matrix function </li>
                                <li>Combining data with the data.frame function </li>
                                <li>Combining data with the list function </li>
                                <li>Importing data </li>
                         </ul>
                     </li>
                       <li>Accessing variables and managing subsets of data
                        <ul type="circle">
                            <li>Accessing variables from a data frame</li>
                            <li>Accessing subsets of data</li>
                            <li>Combining two data sets</li>
                            <li>Exporting data</li>
                        </ul> 
                       </li>
                        <li>Simple functions
                            <ul type="circle">
                                <li>The tapply Function </li>
                                <li>The sapply and lapply functions</li>
                                <li>The summary function and table function</li>
                            </ul>
                        </li>
                    <li>An introduction to basic plotting tools
                            <ul type="circle">
                                <li>The plot function</li>
                                <li>Symbols, colors, and sizes</li>
                                <li>Adding a smoothing line</li>
                            </ul>
                    </li>
                    <li>Loops and functions
                           <ul type="circle">
                               <li>Introduction to loops</li>
                               <li>Loops</li>
                               <li>Functions</li>
                           </ul>
                    </li>
                    <li>Graphing tools
                            <ul type="circle">
                                <li>Pie chart</li>
                                <li>Bar and strip chart</li>
                                <li>Boxplot</li>
                                <li>Cleveland dot plots</li>
                                <li>Revisiting the plot function</li>
                                <li>The pair plot</li>
                                <li>The co plot</li>
                            </ul>
                    </li>
                    <li>An Introduction to the lattice package
                            <ul type="circle">
                                <li>High-level lattice functions</li>
                                <li>Multi panel scatterplots: xy plot</li>
                                <li>Multi panel boxplots: bw plot</li>
                                <li>Multi panel Cleveland Dot plots</li>
                                <li>Multi panel histograms: histogram</li>
                                <li>Panel functions</li>
                                <li>3-D scatterplots and surface and contour plots</li>
                             
                            </ul>
                    </li>
                    <li>Statistics basics with R
                        <ul type="circle">
                            <li>Probability &amp; Distributions</li>
                            <li>Random Numbers</li>
                            <li>Descriptive Statistics and graphics</li>
                        </ul>
                    </li>
                    <li>Simple regression and correlation 
                        <ul type="circle">
                            <li>Simple linear regression</li>
                            <li>Residuals and fitted values</li>
                            <li>Prediction and confidence bands</li>
                        </ul>
                    </li>
                    <li> Analysis of variance and the kruskal-wallis test
                        <ul type="circle">
                            <li>One-way analysis of variance</li>
                            <li>Kruskal-wallis test</li>
                            <li>Two-way analysis of variance</li>
                            <li>The friedman test</li>
                        </ul>
                    </li>
                    <li>Multiple regression
                        <ul type="circle">
                            <li>Plotting multivariate data</li>
                            <li>Model specification and output</li>
                            <li>Model search</li>
                        </ul>
                    </li>
                    <li>Logistic regression
                        <ul type="circle">
                            <li>Generalized linear models</li>
                            <li>Logistic regression on tabular data</li>
                            <li>Likelihood profiling</li>
                            <li>Logistic regression using raw data</li>
                            <li>Prediction</li>
                            <li>Model checking</li>
                        </ul>
                    </li>
                    <li>Rates and poisson regression
                        <ul type="circle">
                            <li>Basic idea</li>
                            <li>Fitting poisson models</li>
                            <li>Computing rates</li>
                        </ul>
                    </li>
                    <li>Non-linear curve fitting
                        <ul type="circle">
                            <li>Basic usage</li>
                            <li>Finding starting values</li>
                            <li>Self-starting models</li>
                            <li>Profiling</li>
                        </ul>
                    </li>

                    <li>Common R mistakes
                           <ul type="circle">
                               <li>Problems importing data</li>
                               <li>Attach misery</li>
                               <li>Non- attach misery ($) & log of zero</li>
                               <li>Log of zero</li>
                               <li>Miscellaneous errors</li>
                           </ul>
                    </li>
                    <strong>Data Science – R Language Implementation.</strong>
                    <li>Points and space
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R Language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                     <li>Set theory
                         <ul type="circle">
                             <li>Concept</li>
                             <li>Application of the concept</li>
                             <li>R language implementation</li>
                             <li>Visualization</li>
                         </ul>
                     </li>
                    <li>Vectors
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R Language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                    <li>Matrices
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R Language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                    <li>Graphs
                       <ul type="circle">
                            <li>Concept</li>
                            <li>Application of the concept</li>
                            <li>R language implementation</li>
                            <li>Visualization</li>
                        </ul>
                    </li>
                    <li>Differential equations
                            <ul type="circle">
                                <li>Concept</li>                               
                                <li>Application of the concept</li>
                                <li>R Language implementation</li>
                                <li>Visualization</li>
                              </ul>
                    </li>
                    <li>Linear algebra
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                    <li>Generalized linear models
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                           </ul>
                    </li>
                    <li>Multinomial data
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                    <li> Data pre-processing
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                    <li> Data transformations
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                    <li> High dimensional data
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                    <li> Dimensionality reduction
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                    <li> Data visualization
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                          </li>
                      <li>Stationary processes
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R Language implementation</li>
                                <li>Visualization</li>
                             </ul>
                       </li>
                       <li>Frequency distribution
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>  
                            </ul>
                      </li>
                      <li>Measures of dispersion
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>  
                            </ul>
                      </li>
                      <li> Skewness
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                      <li>  Normal distributions
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                      <li>  Binomial distribution
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                      <li> Probability
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                      <li>  Conditional probability
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                      <li>  Subjective probability
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                      <li> Multiplication law of probability
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                      <li> Mutually exclusive events and independent events
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                      <li>  Bayes theorem
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language Implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                      <li>  Random variables
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                      <li>  Correlation and regression
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                      <li>  Logistic regression
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                      <li>  Multinominal logistic regression
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                     <li>  Count regression or poisson regression
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                     <li>   Non parametric regression
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                     <li>  Multivariate analysis
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                     <li>   Single factor studies
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                     <li> Multi factor studies
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                     <li>  Specialized study designs
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                     <li>   Testing of hypothesis
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                     <li>   Sampling
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                     <li>   Design and analysis of experiments
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                     <li>  Analysis of variance (ANOVA)
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                     <li>   Linear regression
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                    <li>  Non-linear regression
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                     <li>   Design of experiments
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                     <li>  Multivariate analysis
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                     <li> Canonical correlation
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                     <li> Discriminant analysis
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                     <li> Factor analysis
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                     <li>  Cluster analysis
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                    <li>Multivariate analysis of variance (MANOVA)
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li> 
                            </ul>
                    </li>
                     <li>  Time series analysis
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                     <li> Forecasting analysis
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                     <li>  Quality control
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                     <li> Linear programming problem
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                     <li>  Game theory
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                    <li>  Transportation problem
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                    <li>   Simulation
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                    <li>   Decision analysis
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                    <li>   Decision trees
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                    <li>  Assignment problems
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                            </ul>
                    </li>
                    <li>   Predictive analysis
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                               
                            </ul>
                    </li>
                    <li>   Data mining concepts
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                               
                            </ul>
                    </li>
                    <li>   Neural networks
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                               
                            </ul>
                    </li>
                    <li>   Weka data mining
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                               
                            </ul>
                    </li>
                    <li>   Item set mining
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                               
                            </ul>
                    </li>
                    <li>   Sequence mining
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                               
                            </ul>
                    </li>
                    <li> Graph pattern mining
                        <ul type="circle">
                            <li>Concept</li>
                            <li>Application of the concept</li>
                            <li>R language implementation</li>
                            <li>Visualization</li>
                        </ul>

                    </li>
                    <li>    Kernal methods
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                               
                            </ul>
                    </li>
                    <li>  Classification tree
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                               
                            </ul>
                    </li>
                    <li>   Likelihood theory
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                               
                            </ul>
                    </li>
                    <li>  Arbitrage theory
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                               
                            </ul>
                    </li>
                    <li>    Machine learning
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                               
                            </ul>
                    </li>
                    <li>    Ensemble learning
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                               
                            </ul>
                    </li>
                    <li>    Estimation
                            <ul type="circle">
                                <li>Concept</li>
                                <li>Application of the concept</li>
                                <li>R language implementation</li>
                                <li>Visualization</li>
                               
                            </ul>
                    </li>
                    <b>Program can be tailor made to 2 months, 3 months, 6 months and 1 year.</b>
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