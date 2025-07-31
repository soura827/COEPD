<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true"
    CodeFile="careers.aspx.cs" Inherits="Careers" %>
<%@ Register Src="~/Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    Careers At Coepd
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
     <link rel="canonical" href="https://www.coepd.com/careers.html" />
    <meta name="description" content="Current Openings at coepd" />
    <meta name="keywords" content="career at coepd, coepd openings, job details, current openings, coepd careers" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpContent" runat="Server">
    <div id="recent-updates">
        <uc1:NewsAll ID="NewsAll" runat="server" />
    </div>
    <div class="container">
        <div class="col-md-9">
            <div>
                <h2 class="title-blue">Current Openings at COEPD</h2>
                <div class="panel-group" id="accordion">
                    <p>
                        <asp:DataList ID="dl" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical">
                            <ItemTemplate>
                                <div class="panel panel-info">
                                    <div class="panel-heading">
                                        <h4 class="panel-title">
                                            <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapse<%#Eval("CareerId")%>">
                                                <%#Eval("JobTitle")%>
                                            </a>
                                        </h4>
                                    </div>
                                    <div id="collapse<%#Eval("CareerId")%>" class="panel-collapse collapse">
                                        <div class="panel-body">
                                            <strong>Key Skills: </strong><%#Eval("KeySkills")%>
                                            <br />
                                            <br />
                                            <strong>Experience: </strong>
                                            <%#Eval("Experience")%>
                                            <br />
                                            <br />
                                            <strong>Job Description: </strong>
                                            <%#Eval("JobDescription")%>
                                            <br />
                                            <a href="careerdetails.aspx?Id=<%#Eval("CareerId")%>" class="btn btn-info btn-md">Apply</a>
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:DataList>
                    </p>
                </div>
            </div>
            <div>
                <h5>For more information Contact : +91 90001 55700/040-66612216</h5>
            </div>
        </div>
        <div class="col-md-3 our-locations">
            <uc2:Locations ID="Locations" runat="server" />
        </div>
    </div>
</asp:Content>