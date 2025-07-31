<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true"
    CodeFile="downloads.aspx.cs" Inherits="downloads" %>

<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    COEPD - Downloads
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <meta name="description" content="Business Analyst course content, reference material and guides can be downloaded at the download section in coepd portal" />
    <meta name="keywords" content="business analyst role, agile ba, ba responsibilities, ba role in scrum, Sample Resume, resume examples 2021, interview questions" />
    <link rel="canonical" href="https://www.coepd.com/downloads.html" />
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
                        Downloads</h2>
                    <div class="row">
                        <asp:GridView ID="gv" runat="server" ShowHeader="false" AutoGenerateColumns="False"
                            OnRowCommand="gv_RowCommand" Width="100%">
                            <Columns>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <div class="row" style="padding: 10px">
                                            <div class="col-md-8">
                                                <%#Eval("Download")%>
                                            </div>
                                         <%--   <div class="col-md-2">
                                                <a href='UserDocs/Download/<%#Eval("DownloadPath")%>' target="_blank">
                                                    <button type="button" class="btn btn-info">
                                                        View
                                                    </button>
                                                </a>
                                            </div>--%>
                                            <div class="col-md-4">
                                                <i class="fa fa-download"></i>&nbsp;<asp:LinkButton ID="lnk" runat="server" Text="Download"
                                                    CommandName="cmdDownload" CommandArgument='<%#Eval("DownloadPath")%>'></asp:LinkButton>
                                                </a>
                                            </div>
                                        </div>
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
            <div class="col-md-3 our-locations">
                <uc2:Locations ID="Locations" runat="server" />
            </div>
        </div>
    </div>
    <!-- Inner page Content End -->
</asp:Content>