<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true"
    CodeFile="business-analyst-certifications.aspx.cs" Inherits="business_analyst_certifications" %>
<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    Business Analyst Certifications | BA Certification
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="canonical" href="https://www.coepd.com/business-analyst-certifications.html" />
    <meta name="description" content="Business Analyst Certifications, Iiba BABoK V3 ECBA CCBA CBAP, PMI PBA, BCS Certificate levels Foundation Practitioner Professional Consultant Expert, IVY Global Academy CITBA CITBAP CITSM CITPO CITSD, Certified IT Business Analyst Professional" />
    <meta name="keywords" content="Business Analyst Certifications, Iiba BABoK V3 ECBA CCBA CBAP, PMI PBA, BCS Certificate levels Foundation Practitioner Professional Consultant Expert, IVY Global Academy CITBA CITBAP CITSM CITPO CITSD, Certified IT Business Analyst Professional" />
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
                    <h1>COEPD Business Analyst Certifications | BA course certifications</h1>
                    <p>
                        Many BA Governing Bodies have proposed standards on Business Analysis from multiple perspectives.

                    </p>
                    <p>Iiba released BABoK V3</p>
                    <p>Certificates are</p>
                    <ul>
                        <li>ECBA – Entry Certificate in Business Analysis</li>
                        <li>CCBA – Certificate of Capability in Business Analysis</li>
                        <li>CBAP – Certified Business Analysis Professional</li>
                        <li>AAC – Agile Analysis Certification</li>
                    </ul>
                    <p>PMI</p>
                    <ul>
                        <li>PMI PBA – PMI Professional in Business Analysis</li>
                    </ul>
                    <p> BCS </p>
                    <ul>
                        <li> Foundation Certificates
                            <ul>
                                <li> Business Analysis Foundation</li>
                                <li>Business Change</li>
                                <li>Organisation Behaviour</li>
                            </ul>
                        </li>
                        <li>Practitioner
                            <ul>
                                <li>Business Analysis Practice</li>
                                <li>Benefits Management and Business Acceptance</li>
                                <li>Modelling Business Processes</li>
                                <li>Data Management Essentials</li>
                                <li>Requirements Engineering</li>
                                <li>International Diploma in Business Analysis</li>
                            </ul>
                        </li>
                        <li>Professional
                            <ul>
                                <li>Advanced Requirements Engineering</li>
                                <li>Agile Business Analysis</li>
                                <li>Benefits Planning and Realisation</li>
                                <li>Business Architecture</li>
                                <li>Business Finance</li>
                                <li>Data Analysis</li>
                                <li>Stakeholder Engagement</li>
                                <li>Team Leadership</li>
                            </ul>
                        </li>
                        <li>Consultant
                            <ul>
                                <li>Advanced International Diploma in Business Analysis</li>
                            </ul>
                        </li>
                        <li>Expert
                            <ul>
                                <li>Expert BA Award</li>
                            </ul>
                        </li>
                    </ul>
                    
                    </div>
            </div>
            <div class="col-md-3 our-locations">
                <uc2:Locations ID="Locations" runat="server" />
            </div>
        </div>
    </div>
    <!-- Inner page Content End -->
</asp:Content>