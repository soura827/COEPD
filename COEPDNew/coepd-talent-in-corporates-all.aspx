<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true"
    CodeFile="coepd-talent-in-corporates-all.aspx.cs" Inherits="coepd_talent_in_corporates_all" %>
<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    Business Analyst Placements | Business Analyst Training & Placements Assistance
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
     <link rel="canonical" href="https://www.coepd.com/coepd-talent-in-corporates-all.html" />
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
                <div>
                    <h2 class="title-blue">
                        COEPD's Talent in Corporates</h2>
                    <div id="testimonials-page">
                        <div class="col-md-12">
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" Width="100%" ShowHeader="false"
                                OnPageIndexChanging="gv_PageIndexChanging" AllowPaging="true" PageSize="10">
                                <PagerSettings Mode="NumericFirstLast" FirstPageText="First" LastPageText="Last" />
                                <Columns>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <img src='UserDocs/Corporate/<%#Eval("ImagePath")%>' alt='<%#Eval("Corporate")%>' width="100px"
                                                class="img-rounded img-responsive" title='<%#Eval("Corporate")%>' />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <%--<asp:TemplateField>
                                        <ItemTemplate>
                                            <a href='http://<%#Eval("Website")%>' target="_blank">
                                                <%#Eval("Website")%>
                                            </a>
                                        </ItemTemplate>
                                    </asp:TemplateField>--%>
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