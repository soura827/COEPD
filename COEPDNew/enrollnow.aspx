<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true"
    CodeFile="enrollnow.aspx.cs" Inherits="enrollnow" %>

<%@ Register Src="~/Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    Enroll Now | register now | Business Analyst Training Enroll now
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <meta name="description" content="register here for business analyst course offered in hyderababd, bangalore, chennai, pune, mumbai, delhi/ncr" />
    <meta name="keywords" content="Enroll for Business Analyst, register for business analyst course, business analyst course registration" />
    <link rel="canonical" href="https://www.coepd.com/enrollnow.html" />
    <script src="js/jquery.js" type="text/javascript"></script>
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
                <div class="login-box">
                    <div class="box-title">
                        <span class="login-title">Enroll Now
                        </span>
                    </div>
                    <div class="form-horizontal">
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Name
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtName" runat="server" CssClass="form-control" required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Email
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtEmail" type="Email" runat="server" CssClass="form-control" required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Mobile
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtMobile" runat="server"  pattern="[789][0-9]{9}" CssClass="form-control" required="" 
                                    title="Enter valid 10 digit mobile Number"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group col-sm-offset-4">
                            <asp:Button ID="btnSubmit" runat="server" Text="Send" OnClick="btnSubmit_Click" />
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-3 our-locations">
                <uc2:Locations ID="Locations2" runat="server" />
            </div>
        </div>
    </div>
    <!-- Inner page Content End -->
    <div class="container">
        <!-- Trigger the modal with a button -->
        <!-- Modal -->
        <div class="modal fade" id="myModal" role="dialog">
            <div class="modal-dialog">

                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h2>Thank you!    </h2>
                    </div>
                    <div class="modal-body" id="alert-success">
                        <b>Your Details are successfully saved.</b>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>