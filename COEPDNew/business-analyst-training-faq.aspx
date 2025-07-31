<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true"
    CodeFile="business-analyst-training-faq.aspx.cs" Inherits="business_analyst_training_faq" %>
<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    Business Analyst Training FAQs
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="canonical" href="https://coepd.com/business-analyst-training-faq.html" />
    <meta name="description" content="Frequently Asked Questions about Business Analysis can be found in the FAQ section of coepd portal" />
    <meta name="keywords" content="Business analyst FAQs, interview questions of business Analyst, how to become a business analyst, how to improve business analysis skills" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpContent" runat="Server">
    <!-- Inner page Content start -->
    <div id="inner-cont">
        <div class="container">
            <div class="col-md-9">
                <div>
                    <h2 class="title-blue">
                        Frequently Asked Questions</h2>
                    <div class="panel-group" id="accordion">
                        <p>
                            <asp:DataList ID="dl" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical">
                                <ItemTemplate>
                                    <div class="panel panel-default">
                                        <div class="panel-heading">
                                            <h4 class="panel-title">
                                                <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapse<%#Eval("SNO")%>">
                                                    <%#Eval("Faq")%>
                                                </a><i class="fa fa-question  pull-right"></i>
                                            </h4>
                                        </div>
                                        <div id="collapse<%#Eval("SNO")%>" class="panel-collapse collapse out">
                                            <div class="panel-body">
                                                <%#Eval("Description")%>
                                            </div>
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:DataList>
                        </p>
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