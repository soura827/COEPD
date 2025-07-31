<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true" CodeFile="cpoa-certification.aspx.cs" Inherits="cpoa_certification" %>

<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="Server">
    CPOA Certification | IIBA CPOA Certification
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="Server">
    <link rel="canonical" href="https://www.coepd.com/cpoa-certification.html" />
    <meta name="description" content="IIBA CPOA Certification" />
    <meta name="keywords" content="CPOA Certification, CPOA certification, Product owner certificate, Scrum master certificate, Agile BA, AGILE SCRUM PO, IIBA  certification, International certificate" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cpContent" runat="Server">
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
                    <h1 class="title-blue">IIBA CPOA Certification Training</h1>
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
                    <p>
                        <strong>Course Overview</strong>
                    </p>
                    <p>
                        Product owners play an essential role in guiding the development and deployment of many organizations' most important products and services. In this course, Business Analysis for Product Owners (IIBA®-CPOA), you'll see how to integrate the mindset and best practices of business analysis into this role, and greatly enhance the value you offer to your product team and the value your product offers to customers. First, you'll learn more about the roles of product owners and business analysts, understanding the core functions and traits that make each so critical to organizational success. Next, you'll discover how to bring these two disciplines together, harnessing the combined power of product ownership analysis. Then, you'll explore the role of product ownership within the organization at large, and how an ownership analysis mindset can generate value even beyond the scope of your product team. Finally, you'll know how to align your product development efforts with organizational goals, ensuring the work that you and your team undertake is always helping to achieve your shared mission. By the end of this course, you'll understand why supplementing traditional product ownership with the insight and knowledge offered by business analysis practices will help you succeed as a product owner.
                    </p>
                    <p>
                        <strong>Exam Blueprint - CPOA Exam:</strong>
                    </p>
                    <ul>
                        <li>Type: 60 multiple choice, knowledge-based questions</li>
                        <li>Duration: 90 minutes</li>
                    </ul>
                    <p><strong>Knowledge areas:</strong></p>
                    <div class="table-responsive">
                        <table class="table table-responsive" border="1">
                            <tr>

                                <th>POA Domain</th>
                                <th>Percentage of Exam Coverage</th>
                            </tr>
                            <tr>
                                <td>Apply Foundational Concepts</td>
                                <td>10%</td>
                            </tr>
                            <tr>
                                <td>Cultivate Customer Intimacy</td>
                                <td>15%</td>
                            </tr>
                            <tr>
                                <td>Engage the Whole Team</td>
                                <td>15%</td>
                            </tr>
                            <tr>
                                <td>Make an Impact</td>
                                <td>15%</td>
                            </tr>
                            <tr>
                                <td>Deliver Often</td>
                                <td>15%</td>
                            </tr>
                            <tr>
                                <td>Learn Fast</td>
                                <td>15%</td>
                            </tr>
                            <tr>
                                <td>Obsess About Value</td>
                                <td>15%</td>
                            </tr>
                        </table>
                    </div>

                    <p>
                        <strong>Target audience/Who can attend</strong>
                    </p>

                    <ul>
                        <li>Product Owner professionals</li>
                        <li>Support Product Owners</li>
                        <li>Business analysis professionals</li>
                        <li>Professionals who execute different product ownership related works</li>
                        <li>Aspiring professionals who want to consider the exciting career path of Product Owner</li>
                    </ul>
                    <p>
                        <strong>Key Features/What you’ll learnt/Learning Objectives</strong>
                    </p>

                    <ul>
                        <li>You will understand the responsibilities of product management</li>
                        <li>Explore the frameworks, techniques, competencies, and concepts of POA</li>
                        <li>With over real-life case study examples, you will become a proficient expert</li>
                        <li>Learn how to apply POA with brilliant techniques</li>
                        <li>Learn how to apply product ownership and business analysis.</li>
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

