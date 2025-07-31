<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true"
    CodeFile="business-analyst-online-exams.aspx.cs" Inherits="business_analyst_online_exams" %>
<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    Business Analyst Online Exam | BA Online Exam | Business Analyst Mock Exam
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="canonical" href="https://www.coepd.com/business-analyst-online-exams.html" />
    <meta name="description" content="Online Exams, BA Preparatory Exams, BA Interview Test, Certification Exams ECBA, CCBA, CBAP, IVY Global Academy CITBA CITBAP CITSM CITPO CITSD, Pass Guarantee Exams, Instant results check right answers and retake the exam any number of times." />
    <meta name="keywords" content="Online Exams, BA Preparatory Exams, BA Interview Test, Certification Exams ECBA, CCBA, CBAP, IVY Global Academy CITBA CITBAP CITSM CITPO CITSD, Pass Guarantee Exams, Instant results check right answers and retake the exam any number of times." />
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
            <div class="col-md-9 online-exam-bg">
                
                <div class="col-md-12">
                    <h2 class="title-blue">
                        COEPD Business Analyst - BA - Online Exams</h2>
                    
                    <p>
                        Expose to the competitive world of exams with right inputs and right strategies. Update the knack of attempting the IIBA, IVY Global Academy, PMI certifications through unlimited practice 
                        of simulated exams from COEPD. Our Online Exams have BA Preparatory Exams, BA Interview Test, Certification Exams ECBA, CCBA, CBAP, IVY Global Academy CITBA CITBAP CITSM CITPO CITSD. 
                        Our prep exams can be considered as Pass Guarantee Exams if you practice until you are perfect in the topics. After the exam is answered and you submit the exam, Instant result will come. 
                        You can check right answers and retake the exam any number of times. To take these online exams you must register with COEPD. For details contact our Helpdesk on 
                        <a href="mailto:helpdesk@coepd.com"><strong>helpdesk@coepd.com</strong></a> and <a href="tel:+ 91-9000155700"><strong>9000155700</strong></a>.
                        </p>
                    <br />
                    <h3>
                        COEPD Members !</h3>
                    <br />
                    <h3>
                        Please <a style="cursor: pointer; color: #FF5555; font-size: large;" href="https://www.coepd.com/login.html">
                            Log in</a> to access the Exams...</h3>
                </div>
                <%--<div class="col-md-6">
                    <img src="img/online-exam.png" alt="Online-Exam" class="online-img" />
                </div>--%>
            </div>
            <div class="col-md-3 our-locations">
                <uc2:Locations ID="Locations" runat="server" />
            </div>
        </div>
    </div>
    <!--  Inner page Content End -->
</asp:Content>