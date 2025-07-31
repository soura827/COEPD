<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true"
    CodeFile="business-analyst-training-enquiry-form.aspx.cs" Inherits="business_analyst_training_enquiry_form" %>
<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    Business Analyst course Enquiry Form | COEPD Enquiry Form
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
     <link rel="canonical" href="https://coepd.com/business-analyst-training-enquiry-form.html" />
    <meta name="description" content="Coepd rated as the top institute for a Job-based Business analyst training course,Business Analyst training Enquiry form" />
    <meta name="keywords" content="Business Analyst Training, Business Analyst Training Institute, Business Analyst Training in Hyderabad, Business Analyst Training in Pune, coepd, coepd BA training, Business Analyst training in Chennai, Business Analyst Workshop, Business Analyst Job Openings, BA Certification" />
        <script type="text/javascript">
            function alertmeSave() {
                Swal.fire(
                    'Enquiry Added Successfully',
                    '',
                    'success'
                )
            }
            function alertmeUpdate() {
                Swal.fire(
                    'Enquiry Updated Successfully',
                    '',
                    'success'
                )
            }
            function alertmeDuplicate() {
                Swal.fire(
                    'Enquiry already exist',
                    '',
                    'warning'
                )
            }
        </script>
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
            <div class="col-md-2">
            </div>
            <div class="col-md-7">
                <div class="login-box">
                    <div class="box-title">
                        <span class="login-title">Quick Enquiry
                        </span>
                    </div>
                    <div class="form-horizontal">
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Name<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtName" runat="server" CssClass="form-control" required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Email<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtEmail" type="Email" runat="server" CssClass="form-control" required="" AutoPostBack="true" OnTextChanged="txtEmail_TextChanged"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Mobile<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtMobile" runat="server" pattern="[6789][0-9]{9}" CssClass="form-control"
                                    title="Enter valid 10 digit mobile Number" Required="" AutoPostBack="true" OnTextChanged="txtEmail_TextChanged"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                City<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtCity" runat="server" CssClass="form-control" required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                State
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtState" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Course Enquiry<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:DropDownList ID="ddlCourse" runat="server" required="" CssClass="form-control">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group col-sm-offset-3 col-sm-9">
                            <input id="txtCourse" type="text" name="txtCourse" class="form-control"
                                placeholder="Mention Course Name"  />
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Planning To Take Course<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:DropDownList ID="ddlPlan" runat="server" CssClass="form-control" required="">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label"><br />
                                Enquiry Details<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtEnquiry" runat="server" CssClass="form-control"  required="" TextMode="MultiLine" Height="100px" ></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group col-xs-offset-4 col-sm-offset-5">
                            <asp:Button ID="btnSubmit" runat="server" Text="Send Enquiry" OnClick="btnSubmit_Click" />
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-3 our-locations">
                <uc2:Locations ID="Locations2" runat="server" />
            </div>
        </div>
    </div>
    <script type="text/javascript">
        Unvisible();
        function Unvisible() {
            $('[id*="txtCourse"]').hide();
        }
        $(function () {
            $('[id*="ddlCourse"]').on('change', function () {
                if (this.value === "0") {
                    $('[id*="txtCourse"]').show();
                    $('[id*="txtCourse"]').attr("required", true);
                }
                else {
                    $('[id*="txtCourse"]').hide();
                    $('[id*="txtCourse"]').attr("required", false);
                }
            })
        });
    </script>
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
                        <b>Thank you for contacting us. We will reach you soon</b>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>