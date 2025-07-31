<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true"
    CodeFile="login.aspx.cs" Inherits="login" %>
<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    COEPD student login | Business Analyst student login
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="cananical" href="https://www.coepd.com/login.html" />
    <meta name="description" content="Student Login – Learning Management System – LMS, Online Exams, Interaction with Mentors, Student Coordinators, Exams, Nurturing Activities evaluation and Feedback, UML, Tools like Visio, Balsamiq mockups, Axure Prototypes, BA Resume Preparation" />
    <meta name="keywords" content="Student Login – Learning Management System – LMS, Online Exams, Interaction with Mentors, Student Coordinators, Exams, Nurturing Activities evaluation and Feedback, UML, Tools like Visio, Balsamiq mockups, Axure Prototypes, BA Resume Preparation, coepd student login" />

  <%--  <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpContent" runat="Server">
        <div class="container">
            <div class="col-md-12">
                <uc1:NewsAll ID="NewsAll" runat="server" />
            </div>
        </div>
    </div>
    <!--  Inner page Content start -->
    <div id="inner-cont">
        <div class="container">
            <div class="col-md-9">
                <div class="row">
                <div class="col-md-3"></div>
                <div class="col-md-6">
                <div class="login-box">
                    <div class="box-title">
                        <span class="login-title">Coepd student login </span>
                    </div>
                    <div class="form-horizontal">
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-3 control-label">
                                Username</label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtUserName" runat="server" CssClass="form-control" Required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="inputPassword3" class="col-sm-3 control-label">
                                Password</label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control"
                                    Required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-offset-6 col-sm-4">
                                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"  CssClass="btn btn-danger" />
                                <%--  <span><a href="#">&nbsp;Forgot Password</a></span>--%>
                               
                            </div>
                             <div class="col-sm-offset-3 col-sm-9">
                            <asp:label id="lblmessage" runat="server" Font-Bold="true" ></asp:label>
                        </div>
                        </div>
                </div>
            </div>
                </div>
                </div>
                <div class="row">
            <h1>Welcome to COEPD Learning Management System (LMS)</h1>
            <p>
                 specially crafted to suit the learning needs of the present new learners. COEPD LMS have Online Exams, Nurturing process supported by Mentor’s Interactions, 
                Student Coordinators assigning the tasks, Nurturing Activities evaluation and Feedback, practice on UML diagrams like Use Case Diagrams Activity Diagrams, Hands on experience 
                with Tools like Visio, Balsamiq mockups, Axure Prototypes. In LMS, we have Resume Preparation support. Mentors and HR will help the learner to prepare the resume from the BA 
                perspective. LMS helped many learners in their BA Knowledge Improvement and played a key role in grooming learners into a BA role. COEPD Students are provided with login 
                credentials. Our Students have special access to download Documents and Certificate. They can see the Calendar and give Feedback in the special option provided for them. 
                For you get your login - contact <a href="mailto:helpdesk@coepd.com"> <strong>helpdesk@coepd.com</strong></a> or <a href="tel:+ 91-9000155700"><strong >call 9000155700</strong></a>.
            </p>

                </div>
                </div>
            <div class="col-md-3 our-locations">
                <uc2:Locations ID="Locations" runat="server" />
            </div>
            </div>
        </div>
    <!--  Inner page Content End -->
</asp:Content>
