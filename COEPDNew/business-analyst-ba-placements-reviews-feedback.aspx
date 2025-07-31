<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true" CodeFile="business-analyst-ba-placements-reviews-feedback.aspx.cs" Inherits="business_analyst_ba_placements_reviews_feedback" %>

<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Business Analyst Placements | BA Placement Reviews | BA Placements Feedback
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
    <link rel="canonical" href="https://www.coepd.com/business-analyst-ba-placements-reviews-feedback.html" />
    <meta name="description" content="Our Students shares their experiences with COEPD. Placement Reviews, Their Google reviews, personal chats for appreciations, Dedicated services offered during Training, Nurturing, internships, resume Preparation, Mock Interviews and placement support." />
    <meta name="keywords" content="Business Analyst reviews, students feedback, COEPD reviews, ba course reviews, COEPD appreciations, business analyst placement feedback, " />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cpContent" Runat="Server">
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
                <h1>Business Analyst -Business Analyst placement Reviews - Feedback</h1>
            <p>
                Our Students are happy to share their experiences with COEPD. Placement Reviews, Their Google reviews, personal chats for appreciations can be viewed here in this page. COEPD Dedicated services 
                offered during Training, Nurturing, Mentor calls, Doubts clarifications, online exams, Forums, Blogs, internships, resume Preparation, Mock Interviews and placement support are all appreciated by 
                the Students. In Nurturing process, Students will get hands-on experience working on Diagrams, Documents and Real Time Scenarios. These workouts give lot of confidence to the students while 
                attending interviews. The Good Feedback encourages our Team to be more responsible and offer the best service.
            </p>
               
                <div>
                    <div class="col-md-12">
                        <asp:DataList ID="dl" runat="server" RepeatLayout="Flow" RepeatDirection="Horizontal">
                            <ItemTemplate>
                                <div class="col-md-3">
                                    <a href='UserDocs/PlacementReviews/<%#Eval("ImagePath")%>' target="_blank">
                                        <img src='UserDocs/PlacementReviews/<%#Eval("ImagePath")%>' alt='<%#Eval("PlacementReviewsName")%>'
                                            class="img-rounded img-responsive" title='<%#Eval("PlacementReviewsName")%>' />
                                    </a>
                                    <b><%#Eval("PlacementReviewsName") %></b>
                                </div>
                            </ItemTemplate>
                        </asp:DataList>
                    </div>
                </div>

                <div class="row">
                    &nbsp;
                </div>

                <div class="row text-right" style="padding-right: 30px; margin-top: 20px">
                    <a href="business-analyst-ba-placements-reviews-feedback-all.html">
                        <button type="button" class="btn btn-success">
                            View all
                        </button>
                    </a>
                </div>
            </div>
            <div class="col-md-3 our-locations">
                <uc2:Locations ID="Locations" runat="server" />
            </div>
        </div>
    </div>
    <!-- Inner page Content End -->
</asp:Content>

