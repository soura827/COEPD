<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true" CodeFile="Gallery.aspx.cs" Inherits="Gallery" %>

<%@ Register Src="~/Controls/Locations.ascx" TagPrefix="uc1" TagName="Locations" %>
<%@ Register Src="~/Controls/NewsAll.ascx" TagPrefix="uc2" TagName="NewsAll" %>

<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    Gallery
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <link rel="canonical" href="https://www.coepd.com/Gallery.html" />
    <meta name="description" content="Gallery - COEPD" />
    <meta name="keywords" content="Gallery - COEPD" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpContent" Runat="Server">
    <div id="recent-updates">
        <div class="container">
            <div class="col-md-12">
                <uc2:NewsAll ID="NewsAll" runat="server" />
            </div>
        </div>
    </div>
    <!-- Inner page Content start -->
    <div id="inner-cont">
        <div class="container">
            <div class="col-md-9">
                <div>
                    <h2 class="title-blue">
                        Gallery
                    </h2>               
                </div>
            <div>
                    <div class="col-md-12">
                        <asp:DataList ID="dl" runat="server" RepeatLayout="Flow" RepeatDirection="Horizontal">
                            <ItemTemplate>
                                <div class="col-md-3">
                                    <a href='UserDocs/Gallery/<%#Eval("ImagePath")%>' target="_blank">                                   
                                        <img src='UserDocs/Gallery/<%#Eval("ImagePath")%>' alt='<%#Eval("Name")%>'
                                            class="img-rounded img-responsive" title='<%#Eval("Name")%>' />

                                    </a>
                                   <b><%#Eval("Name") %></b>
                                </div>
                            </ItemTemplate>
                        </asp:DataList>
                    </div>
                </div>
                </div>
            <div class="col-md-3 our-locations">
                <uc1:Locations ID="Locations" runat="server" />
            </div>
        </div>
    </div>
    <!-- Inner page Content End -->
</asp:Content>

