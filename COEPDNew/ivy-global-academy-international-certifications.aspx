<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true" CodeFile="ivy-global-academy-international-certifications.aspx.cs" Inherits="ivy_global_academy_international_certifications" %>

<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    IVY Global Academy International Certification
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="canonical" href="https://www.coepd.com/ivy-global-academy-international-certifications.html" />
    <meta name="description" content="IVY Global Academy is an independent worldwide certification organization headquartered in Texas, USA. IVY global academy provide a range of globally recognized IT certifications for skill sets across the spectrum – from project management, business analysis and development to product management. We work closely with establishments as well as individuals to impart world class knowledge to produce top quality graduates that are best equipped to enter a global workforce." />
    <meta name="keywords" content="Business Analyst IVY global academy international certification, BA international certification, IVY global academy, BA certification" />
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
                    <h2 class="title-blue">
                        About IVY Global Academy</h2>
                    
                     <p>
                        <strong>Mission</strong></p>
                    <p>
                       To set new benchmarking in identifying the skills of individual to enhance employability while helping corporates to identify the skillful resource.
                    </p>
                    <p>
                        <strong>Vision</strong></p>
                    <p>
                        To transform thoughts into acts to leverage industry expectations through continuous research, building world class training programs and be a leading certifying body.
                    </p>
                    <p>
                        <strong>Goal</strong></p>
                    <p>
                        To improve the employability of 20% of knowledge workers every year.
                    </p>
                    <p>
                        <strong>Objective</strong></p>
                    <p>
                        Build and empower ecosystem such that no knowledge worker is left behind</p>
                    
                            
                    <p>
                        <strong>What is Unique about IVY Global Academy?</strong></p>
                    <p>
                        The uniqueness if IVY is that it is the only body with dedicated SME’s, panel members and board of advisors having industry connects and expert thought leaders.</p>
                    <p>
                        <strong>Certifications offered by IVY Global Academy</strong></p>
                   <ol>
                       <li><a href="https://www.coepd.com/ivy-global-academy-citba-certified-it-business-analyst.html">CITBA</a> – Certified IT Business Analyst</li>
                       <li><a href="https://www.coepd.com/ivy-global-academy-citbap-certified-it-business-analyst-practitioner-professional.html">CITBAP</a> – Certified IT Business Analyst – Practitioner</li>
                       <li><a href="https://www.coepd.com/ivy-global-academy-citsm-certified-it-scrum-master.html">CITSM</a> – Certified IT Scrum Master</li>
                       <li><a href="https://www.coepd.com/ivy-global-academy-citpo-certified-it-product-owner.html">CITPO</a> – Certified IT Product Owner</li>
                       <li><a href="https://www.coepd.com/ivy-global-academy-citsd-certified-it-scrum-developer.html">CITSD</a> – Certified IT Scrum Developer</li>
                   </ol>
                    <p><strong>General Information</strong></p>
                    <div  class="table-responsive">
                        <table class="table table-responsive" border="1">
                            <tr>
                        
                                <th>Certification Level</th>
                                <th>No of Questions</th>
                                <th>Duration(Min)</th>
                                <th>Validity</th>
                                <th>Min Score %</th>
                        
                            </tr>
                            <tr>
                                <td>Beginner</td>
                                <td>50</td>
                                <td>60</td>
                                <td rowspan="4" align="center">Life</td>
                                <td rowspan="4" align="center">70</td>
                            </tr>
                            <tr>
                                <td>Intermediate</td>
                                <td>80</td>
                                <td>90</td>
                            </tr>
                            <tr>
                                <td>Advance</td>
                                <td>120</td>
                                <td>120</td>
                            </tr>
                        </table>
                    </div>
                    <p>
                        <strong>Exam retake: </strong> Minimum gap of 14 calendar days from your previous attempt.</p>
                    <p>
                        <strong>Exam Pattern: </strong> Multiple choice questions.</p>

                    <img src="img/Certificate-CITSM.jpg" alt="GAQM"  class="img-responsive" />
                </div>
            </div>
            <div class="col-md-3 our-locations">
                <uc2:Locations ID="Locations" runat="server" />
            </div>
        </div>
    </div>
    <!-- Inner page Content End -->
</asp:Content>