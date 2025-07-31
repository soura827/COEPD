<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true" CodeFile="trainer-profile.aspx.cs" Inherits="Trainer_profile" %>

<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    Trainer Profiles
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
      <link rel="canonical" href="https://www.coepd.com/trainer-profile.html" />
    <meta name="description" content="Professional trainers with vast industrial experience to instruct students are here at coepd" />
    <meta name="keywords" content="business analyst trainers, ba trainers, business analyst trainer, ba trainer" />
    <style type="text/css"> .entry-content {font-family: Tahoma;} </style>
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
                    <div class="row">
                        <h1 class="title-blue" style="padding-left:25px;">
                            Coach - Business Analysis n PO, Enterprise Architect  and Agile Coach</h1>
                    </div>
                    <div id="testimonials-page">
                        <div class="col-md-12">
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" 
                                 Width="100%" ShowHeader="false">
                                <Columns>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <blockquote class="bg-strip profile" style="background-color:white;">
                                                    <strong><%#Eval("Name")%></strong><br />
                                                 <img src='UserDocs/TrainerProfile/<%#Eval("Profile")%>' style="float:right;padding:10px;" alt='<%#Eval("Profile")%>'
                                            class="img-rounded img-responsive" title='<%#Eval("Name")%>' />  
                                                    <p style="text-align:justify;font-style:italic;"><%#Eval("Description")%></p>
                                                                                                  
                                            </blockquote>
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
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row text-right" style="padding-right: 30px; margin-top: 20px">
                        <a href="https://www.coepd.com/trainer-profile-all.aspx">
                            <button type="button" class="btn btn-success">
                                View all Trainers Profiles
                            </button>
                        </a>
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

