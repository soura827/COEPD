<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true"
    CodeFile="business-analyst-jobopenings.aspx.cs" Inherits="business_analyst_jobopenings" %>
<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    Business Analyst Job Openings | Business Analyst Placements | BA Internship
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="canonical" href="https://www.coepd.com/business-analyst-jobopenings.html" />
    <meta name="description" content="Business Analyst -BA- Training – Workshop – Internships - Job Openings- vacancies – Placements – On-Job Support – Job Description- JD – Job Market – Demand for Trained BAs – Certificate Training – Internationally recognized 40 PD Hours Certificate." />
    <meta name="keywords" content="Business Analyst Job Openings, Business Analyst Job Openings in Hyderabad, BA Job Openings, Business Analyst Internship, BA Internship, Business Analyst Placements, Business Analyst Training and Placements, Business Analyst Internship, BA Internship, Business Analyst Job Openings in Bangalore, Business Analyst Job Openings in Chennai, business analyst placement, BA Placement, ba placement." />
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
                <h1 class="title-blue">
                    Current Job Openings on BA - All Jobs - Today Postings</h1>
                <div class="row">
                    <p>
                        COEPD conducts Business Analyst BA Training/Workshop, Certificate Training followed by Nurturing process /Internships. COEPD is IIBA premier Endorsed Education Partner and can issue Internationally recognized 40 PD Hours Certificate to the trained Students. There is a huge demand for Trained BAs in the BA Job Market. Last 6 months we have seen 2956 Job Openings in the BA Job Market. So many BA Vacancies are there in the Companies. Companies will release Job Description- JD for their BA Job Requirements. COEPD Placement Wing will provide Trained Candidates to the Companies and do follow-up on the shortlisting, conduct BA interviews and getting interview feedback. COEPD have many BA Placements done in the past and going to continue in the future as well

                    </p>
                </div>
                &nbsp;
                <div class="row">
                    <div class="col-md-2">
                        <asp:Button ID="BtnAll" runat="server" OnClick="BtnAll_Click" Text="All Jobs" />
                    </div>
                    <div class="col-md-2">
                        <asp:Button ID="BtnSubmit" runat="server" OnClick="BtnSubmit_Click" Text="Today Postings" />
                    </div>
                    <div class="col-md-2">
                        &nbsp;
                    </div>
                    <div class="col-md-6">
                        <asp:DropDownList ID="ddlCategory" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged"
                            CssClass="form-control">
                        </asp:DropDownList>
                    </div>
                </div><br />
                <div class="table-responsive ">
                    <asp:GridView ID="gv" runat="server" OnPageIndexChanging="gv_PageIndexChanging" AllowPaging="true"
                        ShowHeader="false" PageSize="10" AutoGenerateColumns="False" Width="100%">
                        <PagerSettings Mode="NumericFirstLast" FirstPageText="First" LastPageText="Last" />
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <div>
                                        <div class="job-date">
                                            <%#Eval("JobDate", "{0:dd MMM yyyy}")%></div>
                                        <div class="location">
                                            <%#Eval("Location")%></div>
                                        <br />
                                        <div class="job-designation">
                                            <%#Eval("JobTitle")%></div>
                                        <div class="text-right">
                                            <%#Eval("Company")%></div>
                                        <div class="job-years">
                                            <%#Eval("Experience")%>
                                        </div>
                                        <div class="job-more">
                                            <a href="https://www.coepd.com/login.html" title="COEPD members can access this link">more
                                                info...</a>
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
            <div class="col-md-3 our-locations">
                <uc2:Locations ID="Locations" runat="server" />
            </div>
        </div>
    </div>
    <!-- Inner page Content End -->
</asp:Content>