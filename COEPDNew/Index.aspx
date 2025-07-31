<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true"
    CodeFile="index.aspx.cs" Inherits="Index" %>
<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Business Analyst Course | Business Analyst Training Institute
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="Server">
    <link rel="canonical" href="https://www.coepd.com/" />
    <meta name="description" content="COEPD offers the best business analyst training course online/classroom and placement in Hyderabad, Bangalore, Chennai, Pune, Delhi/NCR and Mumbai." />
    <meta name="keywords" content="Business Analyst course online and classroom in Hyderabad, Business Analyst Training, ba training, BA Training, Business analyst training, Business Analyst Course, Business analyst course, Coepd, coepd, COEPD" />
    <meta name="google-site-verification" content="fDqO4RAVxujw3_xxuoF4w3PxZxRZPwNNqZQSXYFJwlM" />
        <%-- Festival wishes style start--%>
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
   <%-- <script type="text/javascript" src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>--%>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#myModal").modal('show');
            setTimeout(function () {
                $('#myModal').modal('hide');
            }, 4000);
        });
         </script>
    <style type="text/css">
        .modal {
            text-align: center;
            padding: 0 !important;
        }

            .modal:before {
                content: '';
                display: inline-block;
                height: 100%;
                vertical-align: middle;
                margin-right: -4px;
            }

        .modal-dialog {
            display: inline-block;
            text-align: left;
            vertical-align: middle;
        }
    </style>
<%-- Festival wishes code style End--%>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cpContent" runat="Server">
    <%-- Festival wishes code Start--%>
   <div id="myModal" class="modal fade" data-backdrop="static" data-keyboard="false">
        <div class="modal-dialog modal-lg">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                </div>
                <div class="modal-body">
                    <div class="form-group">
                        
                            <img src='UserDocs/PopUpImages/COEPDPopUpImage.png' alt='COEPD-PopUp-Image' class="img-responsive"/>
                            <!-- Slider Section Start -->
    <%--<div id="myCarousel" class="carousel slide" data-ride="carousel">
        <!-- Indicators -->
        <ol class="carousel-indicators">
            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
            <li data-target="#myCarousel" data-slide-to="1"></li>
        </ol>
        <div class="carousel-inner">
            <div class="item active">
                <img src="img/Independence day.PNG" style="width: 100%" alt="Coepd" />
            </div>
            <div class="item">
                <img src="img/Rakshabandhan.PNG" style="width: 100%" data-src="" alt="Coepd" />
            </div>
        </div>
        <a class="left carousel-control" href="#myCarousel" data-slide="prev"><span class="glyphicon glyphicon-chevron-left">
            <i class="fa fa-caret-left fa-3x"></i></span></a><a class="right carousel-control"
                href="#myCarousel" data-slide="next"><span class="glyphicon glyphicon-chevron-right">
                    <i class="fa fa-caret-right fa-3x"></i></span></a>
    </div>--%>
    <!-- Slider Section End -->
                     
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                </div>
            </div>
        </div>
    </div>
    <%-- Festival wishes code End--%>

    <!-- Slider Section Start -->
    <div id="myCarousel" class="carousel slide" data-ride="carousel">
        <!-- Indicators -->
        <ol class="carousel-indicators">
            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
            <li data-target="#myCarousel" data-slide-to="1"></li>
            <li data-target="#myCarousel" data-slide-to="2"></li>
        </ol>
        <div class="carousel-inner">
            <div class="item active">
                <img src="img/slide1.jpg" style="width: 100%" alt="Coepd" />
            </div>
            <div class="item">
                <img src="img/slide2.jpg" style="width: 100%" alt="Coepd" />
            </div>
            <div class="item">
                <img src="img/slide3.jpg" style="width: 100%" alt="Coepd" />
            </div>
        </div>
        <a class="left carousel-control" href="#myCarousel" data-slide="prev"><span class="glyphicon glyphicon-chevron-left">
            <i class="fa fa-caret-left fa-3x"></i></span></a><a class="right carousel-control"
                href="#myCarousel" data-slide="next"><span class="glyphicon glyphicon-chevron-right">
                    <i class="fa fa-caret-right fa-3x"></i></span></a>
    </div>
    <!-- Slider Section End -->
    <div id="recent-updates-home">
        <div class="container">
            <div class="col-md-12">
                <uc1:NewsAll ID="NewsAll" runat="server" />
            </div>
        </div>
    </div>
    <div class="container">
        <div id="inner-cont">
            <div class="col-md-9">
                <div class="col-sm-4 col-xs-12">
                    <div class="cours-box">
                        
                            <h3>BA Training</h3>
                            <div class="course-img">
                               <a href="https://www.coepd.com/business-analyst-training.html"> <img src="img/Ba.png" alt="BA Training" /></a>
                            </div>
                        
                    </div>
                </div>
                <div class="col-sm-4 col-xs-12">
                    <div class="cours-box">
                       
                            <h3>BA Online Training</h3>
                            <div class="course-img">
                               <a href="https://www.coepd.com/business-analyst-online-training.html">  <img src="img/online.png" alt="Online Training" /></a>
                            </div>
                        
                    </div>
                </div>
                <%--                <div class="col-sm-4 col-xs-12">
                    <div class="cours-box">
                        <a href="project-management-training.html">
                            <h3>PMP Training</h3>
                            <div class="course-img">
                                <img src="img/pmp2.png" alt="PMP Training" />
                            </div>
                        </a>
                    </div>
                </div>
               --%>
                <div class="col-sm-4 col-xs-12">
                    <div class="cours-box">
                            <h3>Scrum</h3>
                            <div class="course-img">
                              <a href="https://www.coepd.com/scrum-training.html">  <img src="img/Ba.png" alt="Scrum" /></a>
                            </div>
                    </div>
                </div>
                <div style="clear: both;"></div>
                <div id="text-content">
                    <h1 class="title-blue">Welcome to COEPD! Business analyst training online/classroom course</h1>
                       <p> is a
                        primarily a community of Business Analysts. Objective of COEPD is to minimize project
                        failures by contributing in the areas of Business Analysis. All BAs who are committed
                        towards this cause, gathered and formed this COEPD Community. Through COEPD, we
                        are striving to bring awareness of
                        <strong>Business Analyst
                        </strong>
                        role and also the benefits of having a BA in project. As a part of this, we are
                        imparting Business Analysis knowledge to all enthusiastic professionals, who are
                        keen in getting into this BA role.
                    </p>
                    <p>
                        COEPD conducts 4-day workshops throughout the year for all participants in various
                        locations i.e. <a href="https://www.coepd.com/business-analyst-training-in-hyderabad.html">Hyderabad</a>,
                        <a href="https://www.coepd.com/business-analyst-training-in-vizag.html">Visakhapatnam</a>, <a href="https://www.coepd.com/business-analyst-training-in-chennai.html">Chennai</a>, <a href="https://www.coepd.com/business-analyst-training-in-pune.html">Pune</a>, <a href="https://www.coepd.com/business-analyst-training-in-mumbai.html">Mumbai</a>, <a href="https://www.coepd.com/business-analyst-training-in-bangalore.html">Bangalore</a>
                        & <a href="https://www.coepd.com/business-analyst-training-in-delhi.html">Delhi-NCR</a> The workshops
                        are also conducted on Saturdays and Sundays for the convenience of working professionals.
                    </p>
                    <p>
                        COEPD has innate leaders running the organization with an irrevocable human element
                        to serve the ever changing dynamic environment of the IT industry. COEPD takes personal
                        care in grooming our BA aspirants from the initial phases of conducting counseling
                        sessions to the final phases of nurturing them into the IT industry Business Analyst
                        role, our forte.
                    </p>
                    <p>
                        Business Analyst a key role in creating project success stories to every IT company
                        in the industry. We at COEPD teach the subject with professional interest keeping
                        in view of the challenging areas of the IT Industry.
                    </p>
                    <p>
                        COEPD workshops will be conducted and delivered by industry experts having more
                        than a decade of work experience in handling IT projects in the ranks of a Project
                        Manager, Principal Business Analyst , Senior Business Analyst and CIO.
                    </p>
                    <p>
                        COEPD delivers training through various channels: Workshops, Online Trainings, Corporate
                        Trainings, Classroom Trainings and Certificate Trainings.
                    </p>
                </div>
            </div>
            <div class="col-md-3 our-locations">
                <uc2:Locations ID="Locations" runat="server" />
            </div>
        </div>
    </div>
    <!-- Courses and Locations Section End -->
</asp:Content>
