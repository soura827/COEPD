<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true" CodeFile="refundpolicy.aspx.cs" Inherits="RefundPolicy" %>

<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>

<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    Refund Policy- COEPD
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <link rel="canonical" href="https://www.coepd.com/refundpolicy.html" />
    <meta name="description" content="Coepd Return and Refund policy agreement" />
    <meta name="keywords" content="Return and Refund policy agreement" />
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
                    <h1 class="title-blue">
                        COEPD- Refund Policy
                    </h1>
                    <p>Thank you for purchasing our courses. By purchasing any of the training course's from COEPD, you agree to our Privacy Policy ,Terms of Use and Refund policy.</p>
                    <p>
					<strong>Courses & Fees</strong>
					</p>
					<ul>
                        <%--<li>Classroom Training – Rs. 40,000/- + Taxes</li>
                       <li>Internships (After Training) – Rs. 30,000/- + Taxes</li>
                       <li>Online Training – USD 650</li>
                       <li>Online Mentoring – USD 550</li>--%>
                        <li>Only Workshop- 20,886/-(Including taxes)</li>
                       <li>Workshop + Nurturing + IIBA Certificate - 35000/- (Including taxes)</li>
                       <li>Workshop + Nurturing + Placement assistance + On job support + IIBA Certificate - 41,300/-</li>
					</ul>
					
                     <p>
                        <strong>Refund-Cancellation:</strong>
                    </p>
                    
                        <ul>
                            <li>
                               COEPD reserves the right to postpone/cancel the training, because of insufficient enrollments, instructor illness or Catastrophic events (like floods, earthquakes, political instability, etc.)
                            </li>
                            <li> In case of any unforeseen circumstances the participant is entitled to reschedule for a future scheduled date of the training course.</li>
                           
                        </ul>
                 <p>
                        <strong>Refund-Duplicate payment:</strong>
                    </p>
                    
                        <ul>
                            <li>
                               Refund of the duplicate payment made by the participant will be processed via the same source (original method of payment) in 10 working days post intimation by the participant and after approval by COEPD.
                            </li>
                            
                        </ul>
                 <p>
                        <strong> Refund-Training:</strong>
                    </p>
                    
                        <ul>
                            <li>
                              Participants shall pay the course fee to COEPD as agreed.
                            </li>
                             <li>
                              Fees payment shall be done only after the Participant agrees that s/he understand all the services offered by COEPD and agree to the terms of COEPD.
                            </li>
                             <li>
                              Fees once paid, will NOT be REFUNDED under any circumstances.
                            </li>
                             <li>
                              If the participant wants the refund of money after attending sessions, COEPD will not provide any refund, as the participant will attend demo sessions ( sometimes personal couselling) and understand thoroughly about the services offered by COEPD.
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

