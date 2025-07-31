<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true" CodeFile="coepd-business-analyst-ba-success-stories.aspx.cs" Inherits="coepd_business_analyst_ba_success_stories" %>

<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>

<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    COEPD Business Analyst Success Stories | BA Success Stories
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="canonical" href="https://www.coepd.com/business-analyst-ba-placements-jobs-vacancies.html" />
    <meta name="description" content="COEPD honors all our placed Students by conducting Honors Program. Their Success Stories are shared to motivate other BA Aspirants. COEPD have a perfect platform to make BA Aspirants get into BA role and settle down as BA in IT Industry." />
    <meta name="keywords" content="COEPD honors program" />
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
                <h1>COEPD Success Stories | Business analyst success stories</h1>
            <p>
                 Good work always pays back. COEPD honors all our placed Students by conducting Honors Program. Their Success Stories are shared to motivate other BA Aspirants. COEPD have a perfect platform to 
                make BA Aspirants get into BA role and settle down as BA in IT Industry. Our Placed Students form BA Community and we help each other in the community. We share challenges faced and how to 
                overcome them. We train ourselves on the best practices of the current BA practices. Every quarter community meets to discuss the GAP between the training and the BA industry and we finetune the 
                learning concepts to match the latest trends.
            </p>
                <div>
                    <div class="col-md-12">
                        <asp:DataList ID="dl" runat="server" RepeatLayout="Flow" RepeatDirection="Horizontal">
                            <ItemTemplate>
                                <div class="col-md-3">
                                    <a href='UserDocs/SuccessStories/<%#Eval("ImagePath")%>' target="_blank">
                                        <img src='UserDocs/SuccessStories/<%#Eval("ImagePath")%>' alt='<%#Eval("SuccessStoriesName")%>'
                                            class="img-rounded img-responsive" title='<%#Eval("SuccessStoriesName")%>' />
                                    </a>
                                    <b><%#Eval("SuccessStoriesName") %></b>
                                </div>
                            </ItemTemplate>
                        </asp:DataList>
                    </div>
                </div>

                <div class="row">
                    &nbsp;
                </div>

                <div class="row text-right" style="padding-right: 30px; margin-top: 20px">
                    <a href="coepd-business-analyst-ba-success-stories-all.html">
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

