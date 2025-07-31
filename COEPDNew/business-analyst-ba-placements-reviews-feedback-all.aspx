<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true" CodeFile="business-analyst-ba-placements-reviews-feedback-all.aspx.cs" Inherits="business_analyst_ba_placements_reviews_feedback_all" %>

<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>

<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    Business Analyst Placements | BA Pleacements Reviews | BA Placements Feedback All
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="canonical" href="https://www.coepd.com/business-analyst-ba-placements-reviews-feedback-all.html" />
    <meta name="description" content="Business analyst training course with 100% Placement assistance. Enroll now to learn basics to advanced Concepts of Business analyst" />
    <meta name="keywords" content="Business Analyst reviews, students feedbac, COEPD reviews, ba course reviews, COEPD appreciations, business analyst placement feedback." />
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
                        <h1>Business Analyst - BA - Placements - Reviews – Feedback All</h1>
                    <div id="testimonials-page">
                        <div class="col-md-12">
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" Width="100%" ShowHeader="false" OnPageIndexChanging="gv_PageIndexChanging" AllowPaging="true" PageSize="10">
                                <PagerSettings Mode="NumericFirstLast" FirstPageText="First" LastPageText="Last" />
                                <Columns>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <b><%#Eval("PlacementReviewsName") %></b>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <a href='UserDocs/PlacementReviews/<%#Eval("ImagePath")%>' target="_blank">
                                            <img src='UserDocs/PlacementReviews/<%#Eval("ImagePath")%>' alt='<%#Eval("PlacementReviewsName")%>' width="100px"
                                                class="img-rounded img-responsive" title='<%#Eval("PlacementReviewsName")%>' />
                                            </a>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <PagerStyle HorizontalAlign="Center" VerticalAlign="Bottom" />
                                <EmptyDataTemplate>
                                    <center>
                                        No Records Found
                                    </center>
                                </EmptyDataTemplate>
                            </asp:GridView>
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

