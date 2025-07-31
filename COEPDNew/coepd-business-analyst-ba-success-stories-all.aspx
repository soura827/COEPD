<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true" CodeFile="coepd-business-analyst-ba-success-stories-all.aspx.cs" Inherits="coepd_business_analyst_ba_success_stories_all" %>

<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    Business Analyst Success Stories | COEPD success stories
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="canonical" href="https://www.coepd.com/coepd-business-analyst-ba-success-stories-all.html" />
    <meta name="description" content="Coepd Success Stories are shared to motivate other BA Aspirants. COEPD have a perfect platform to make BA Aspirants get into BA role and settle down as BA in IT Industry." />
    <meta name="keywords" content="Business Analyst success stories, Coepd honours program, ba success stories, BA success stories" />
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
                        <h1>COEPD - BA - Success Stories</h1>
                    <div id="testimonials-page">
                        <div class="col-md-12">
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" Width="100%" ShowHeader="false" OnPageIndexChanging="gv_PageIndexChanging" AllowPaging="true" PageSize="10">
                                <PagerSettings Mode="NumericFirstLast" FirstPageText="First" LastPageText="Last" />
                                <Columns>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <b><%#Eval("SuccessStoriesName") %></b>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <a href="UserDocs/SuccessStories/<%#Eval("ImagePath")%>" target="_blank">
                                            <img src='UserDocs/SuccessStories/<%#Eval("ImagePath")%>' alt='<%#Eval("SuccessStoriesName")%>' width="100px"
                                                class="img-rounded img-responsive" title='<%#Eval("SuccessStoriesName")%>' />
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

