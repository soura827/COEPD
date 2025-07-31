<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true" 
    CodeFile="business_analyst_training_hyderabad_enquiry_form.aspx.cs" Inherits="business_analyst_training_hyderabad_enquiry_form" %>

<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    Business Analyst course Enquiry Form Hyderabad| COEPD Enquiry Form
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
     <link rel="canonical" href="https://coepd.com/business_analyst_training_hyderabad_enquiry_form.html" />
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
                        <span class="login-title">Walkin-Counseling Form
                        </span>
                    </div>
                    <div class="form-horizontal">
                     <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Course Enquiry For:<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:DropDownList ID="ddlCourse" runat="server" required="" CssClass="form-control">
                                </asp:DropDownList>
                            </div>
                        </div>
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
                              Eduction Qualification:<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtQualification" runat="server" CssClass="form-control" required=""></asp:TextBox>
                            </div>
                        </div>
                            <div class="form-group">
                            <label class="col-sm-3 control-label">
                              Experience in Years:<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtExperience" runat="server" CssClass="form-control" required=""></asp:TextBox>
                            </div>
                        </div>
                         <div class="form-group">
                            <label class="col-sm-3 control-label">
                              Domains:<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtDomains" runat="server" CssClass="form-control" required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                               Primary EmailId<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtEmail1" type="Email" runat="server" CssClass="form-control" required="" OnTextChanged="txtEmail_TextChanged"></asp:TextBox>
                            </div>
                        </div>
                         <div class="form-group">
                            <label class="col-sm-3 control-label">
                               SecondaryEmailId
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtEmail2" type="Email" runat="server" CssClass="form-control"  OnTextChanged="txtEmail_TextChanged"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Primary Mobile<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtMobile1" runat="server" pattern="[6789][0-9]{9}" CssClass="form-control"
                                    title="Enter valid 10 digit mobile Number" Required="" OnTextChanged="txtEmail_TextChanged"></asp:TextBox>
                            </div>
                        </div>
                          <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Secondry Mobile
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtMobile2" runat="server" pattern="[6789][0-9]{9}" CssClass="form-control"
                                    title="Enter valid 10 digit mobile Number"  OnTextChanged="txtEmail_TextChanged"></asp:TextBox>
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
                               1.Please mention Your Expectations (Goal)<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtgoal1" runat="server" CssClass="form-control"  required="" TextMode="MultiLine" Height="100px" ></asp:TextBox>
                            </div>
                        </div>
                         <div class="form-group">
                            <label class="col-sm-3 control-label"><br />
                               2.TimeFrame You have to reach your Goal<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtgoal2" runat="server" CssClass="form-control"  required="" TextMode="MultiLine" Height="100px" ></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group">
                            <div class="col-sm-3">
                                Referred by:
                                    </div>
                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="SMS" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                        SMS
                                    </div>
                                     <div class="col-sm-1">
                                        <asp:CheckBox ID="Friend" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                       Friend
                                    </div>
                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="Email" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                       Email
                                    </div>
                                   
                            </div>
                         <div class="form-group">
                            <div class="col-sm-3">
                                    </div>
                                  <div class="col-sm-1">
                                        <asp:CheckBox ID="WebSite" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                       WebSite
                                    </div>
                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="SocialNetworking" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                       Social Networking
                                    </div>
                            <div class="col-sm-1">
                                        <asp:CheckBox ID="WalkIn" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                       Walk-In
                                    </div>
                            </div>


                            
                        
                         <div class="form-group">
                             &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                             <asp:CheckBox ID="Agree" runat="server" Text=" I  agree to receive updates from COEPD " BorderStyle="Groove" Font-Bold="true" Font-Size ="Large" ForeColor ="#ff3300" /><br />
                            
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

