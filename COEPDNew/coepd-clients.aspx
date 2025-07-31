<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true" CodeFile="coepd-clients.aspx.cs" Inherits="coepd_clients" %>

<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>

<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    COEPD Clients
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="canonical" href="https://www.coepd.com/coepd-clients.html" />
    <meta name="description" content="COEPD Placement Wing is committed to place our BA Trained Students. Clients share JD Job Descriptions with us. Our Placement Wing will share the resumes, which are matching with JD, of our Students and see that Client conducts interviews." />
    <meta name="keywords" content="COEPD Placement Wing, Business Analyst placement, BA placements" />
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
                <h1>COEPD Clients</h1>
            <p>
                COEPD Placement Wing is a very strong Department and is one of the pillars of COEPD BA Framework to place our BA Trained Students. COEPD has a dedicated Team to acquire Clients to 
                place our Students. When these Clients have BA Requirements, Clients share JD Job Description with COEPD Placement Wing. Our Placement Wing will maintain a Resume Database of our Students who 
                completed the Training, the Nurturing Process and well prepared for the interviews. Our Placement Wing will share the resumes which are mapping with the JD of the Client. We discuss with 
                the Client and get the resumes shortlisted and will push the Client towards interview conduction.
            </p>
                <h4>Present Active COEPD Clients are: <asp:Label ID="lblTotalCOEPDClients" runat="server"></asp:Label></h4>
               
                <div>
                    <div class="col-md-12">
                        <asp:DataList ID="dl" runat="server" RepeatLayout="Flow" RepeatDirection="Horizontal">
                            <ItemTemplate>
                                <div class="col-md-3">
                                    <a href='UserDocs/COEPDClients/<%#Eval("ImagePath")%>' target="_blank">
                                        <img src='UserDocs/COEPDClients/<%#Eval("ImagePath")%>' alt='<%#Eval("COEPDClientsName")%>'
                                            class="img-rounded img-responsive" title='<%#Eval("COEPDClientsName")%>' />
                                    </a>
                                    <b><%#Eval("COEPDClientsName") %></b>
                                </div>
                            </ItemTemplate>
                        </asp:DataList>
                    </div>
                </div>

                <div class="row">
                    &nbsp;
                </div>

                <div class="row text-right" style="padding-right: 30px; margin-top: 20px">
                    <a href="coepd-clients-all.html">
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

