<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true"
    CodeFile="coepd-talent-in-corporates.aspx.cs" Inherits="coepd_talent_in_corporates" %>
<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    Business Analyst Placements | Business Analyst Training & Placement Assistance
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="canonical" href="https://www.coepd.com/coepd-talent-in-corporates.html" />
    <meta name="description" content="Business Analyst Training & Placement assistance from real time Business Analyst experts, training with live projects, illustrative scenarios, role place and case studies to make learners to start a successful career." />
    <meta name="keywords" content="Business Analyst Placements, Business Analyst Training & Placements, Business Analyst Training & Placement Assistance, Business Analyst placements in Hyderabad Business Analyst Jobs, Business Analyst Job Openings, Business Analyst Skills, COEPD's Talent in Corporate." />
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
                <h2 class="title-blue">
                    COEPD's Talent in Corporates</h2>
                <div>
                    <div class="col-md-12">
                        <asp:DataList ID="dl" runat="server" RepeatLayout="Flow" RepeatDirection="Horizontal">
                            <ItemTemplate>
                                <div class="col-md-3">
                                    <a href='UserDocs/Corporate/<%#Eval("ImagePath")%>' target="_blank">
                                        <img src='UserDocs/Corporate/<%#Eval("ImagePath")%>' alt='<%#Eval("Corporate")%>'
                                            class="img-rounded img-responsive" title='<%#Eval("Corporate")%>' />
                                    </a>
                                </div>
                            </ItemTemplate>
                        </asp:DataList>
                    </div>
                </div>
                <div class="row">
                    &nbsp;
                </div>
                <div class="row text-right" style="padding-right: 30px; margin-top: 20px">
                    <a href="coepd-talent-in-corporates-all.html">
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