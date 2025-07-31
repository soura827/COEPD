<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true"
    CodeFile="trainings-calendar.aspx.cs" Inherits="trainings_calendar" %>

<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    Batches Dates & Training Calendar - COEPD
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="canonical" href="https://www.coepd.com/trainings-calendar.html" />
    <meta name="description" content="All Business Analysis workshops and tasks for respective students are scheduled in the training calendar provided by coepd" />
    <meta name="keywords" content="usiness Analysis workshops calendar" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpContent" runat="Server">
    <div id="recent-updates">
        <div class="container">
            <div class="col-md-12 table-responsive">
                <uc1:NewsAll ID="NewsAll" runat="server" />
            </div>
        </div>
    </div>
    <!-- Inner page Content start -->
    <div id="inner-cont">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="col-md-7">
                        <h1 class="title-blue">Batch Dates & Training Calendar - COEPD
                        </h1>
                    </div>
                </div>
            </div>
            <div class="col-md-12">
                <div class="widget-body">
                    <div class="row">
                        <asp:Calendar ID="Calendar1" runat="server" OnDayRender="Calendar1_DayRender" Width="100%"
                            CssClass="table table-bordered table-responsive" SelectionMode="None" Font-Size="large"
                            >
                            <DayHeaderStyle BackColor="" Font-Size="Small" />
                        </asp:Calendar>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Inner page Content End -->
</asp:Content>
