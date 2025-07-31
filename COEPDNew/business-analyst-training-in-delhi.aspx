<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true"
    CodeFile="business-analyst-training-in-delhi.aspx.cs" Inherits="business_analyst_training_in_delhi" %>
<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    Certified Business Analyst Course | Certified Business Analyst Course in Delhi-NCR
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="canonical" href="https://www.coepd.com/business-analyst-training-in-delhi.html" />
    <meta name="description" content="COEPD has initiated Business Analyst Course in Delhi-NCR region to meet the demand. BA Courses are organized for all the working professionals." />
    <meta name="keywords" content="Business Analyst Training, business analyst training, Business Analyst Training in Delhi, business analyst training in Delhi, Business Analyst Course, business analyst course, Business Analyst Course in Delhi, business analyst course in Delhi, Certified Business Analyst Course in Delhi, certified business analyst course in Delhi, BA Training in Delhi, ba training in Delhi, BA Course in Delhi, ba course in Delhi, business analyst certification in delhi, business analyst certification in NCR" />
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
                        Certified Business Analyst Course in Delhi-NCR | Business Analyst Course in Delhi-NCR
                    </h1>    <p class="row">
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
                        <strong>COEPD</strong> extends its operations to Delhi-NCR to support unburden the
                        load the IT players bears day in day out. This region has a strong presence of govt.
                        ministries, NGOs, and diverse corporate industries. Due to the vast demand for skilled
                        Business Analysts resources, COEPD has initiated Business Analysts Trainings in
                        Delhi-NCR region to meet the demand. BA Trainings are organized in weekends for
                        all the working professionals who want to enhance their career as Business Analyst.
                    </p>
                    <p>
                        <strong>Select COEPD for the Business Analyst Training for the following:</strong>
                        <ul>
                            <li>It’s a 40 hours Class room training.</li>
                            <li>Interactive Sessions with Industry Experts</li>
                            <li>Experts share their knowledge using scenarios, Case Studies, Activities and their
                                experiences.</li>
                            <li>Train in Project Management, Software Engineering, Inter Personal skills concepts.</li>
                            <li>Through Nurturing process will fine tune the participant in Presentations, document
                                preparation, Resume Preparation, Mock Interview.</li>
                            <li>Will provide job assistance by sharing day-to-day BA openings</li>
                        </ul>
                    </p>
                </div>
            </div>
            <div class="col-md-3 our-locations">
                <div id="location">
                    <!--<h3>Delhi-NCR </h3>
                      	<iframe style="border:4px solid #CCC" width="300" height="200" frameborder="0" scrolling="no" marginheight="0"
                                                            marginwidth="0" src="https://maps.google.com/maps?f=q&amp;source=s_q&amp;hl=en&amp;geocode=&amp;q=coepd+in+hyderabad&amp;aq=&amp;sll=37.0625,-95.677068&amp;sspn=42.901912,86.572266&amp;ie=UTF8&amp;hq=coepd&amp;hnear=Hyderabad,+Ranga+Reddy,+Andhra+Pradesh,+India&amp;filter=0&amp;update=1&amp;ll=17.441256,78.447506&amp;spn=0.006336,0.010568&amp;t=m&amp;z=14&amp;iwloc=A&amp;cid=11999568280209546250&amp;output=embed">
                                                        </iframe>
                         <h5><strong>Center of Excellence for Professional Development</strong></h5>
                                        3<sup>rd</sup> Floor,&nbsp;Sahithi Arcade,<br />
                                        Besides SR Nagar Police Station,<br>
                                        S R Nagar,<br>
                                        Hyderabad 500 038,&nbsp; India.<br />
                                        <i class="fa fa-phone" style="float:left;"></i>&nbsp; +91 90001 55700,<br />
                                        <i class="fa fa-envelope" style="float:left;"></i>&nbsp; &nbsp;helpdesk@coepd.com   -->
                </div>
                <uc2:Locations ID="Locations" runat="server" />
            </div>
        </div>
    </div>
    <!-- Inner page Content End -->
</asp:Content>