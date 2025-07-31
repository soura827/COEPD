<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ParticipantPlacementAssistanceDataSheet.aspx.cs" Inherits="Admin_ParticipantPlacementAssistanceDataSheet" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .ui-widget-content .ui-icon {
            /*background-image: url("../App_Themes/admin//images/ui-icons_222222_256x240.png")*/
            /*background-image:url("../App_Themes/admin/img/ui-icons_444444_256x240.png")*/
            background-image: url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png") !important;
        }

        .ui-widget-header .ui-icon {
            /*background-image: url("../App_Themes/admin/img/ui-icons_444444_256x240.png")*/
            background-image: url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png") !important;
        }
    </style>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery.js"></script>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery-ui-v1.10.3.js"></script>
    <script type="text/javascript">
        $(document).ready(function ($) {
            $("[id*=txtDateofBirth]").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: 'dd/mm/yy',
                maxDate: "0",
                yearRange: '-100:+0',
            });
            $("input[id$=txtResumeFinalizedOn]").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: 'dd/mm/yy',
                maxDate: "0"
            });
        });
        function alertmeSave() {
            Swal.fire(
                'BA Job market  Assistance DataSheet Added Successfully',
                '',
                'success'
            )
        }
        function alertmeUpdate() {
            Swal.fire(
                'BA Job market  Assistance DataSheet Updated Successfully',
                '',
                'success'
            )
        }

        function alertmeDuplicate() {
            Swal.fire(
                'BA Job market  Assistance DataSheet already exist',
                '',
                'warning'
            )
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-lg-1 col-md-1">
        </div>
        <div class="col-lg-9 col-md-9">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Participant BA Job market  Assistance Data Sheet
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">
                        <div class="form-group">
                            <label class="col-sm-12 text-right">
                                <i><sup class="sup">*</sup> indicates manditory field</i>
                            </label>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Full Name <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtFullName" runat="server" required="" placeholder="Enter Your Full Name"></asp:TextBox>
                                <asp:HiddenField ID="hdnParticipantId" runat="server" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Date of Birth <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtDateofBirth" runat="server" required="" placeholder="Select Date of Birth"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Active Mobile Number <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtActiveMobile" runat="server" Type="number" MaxLength="50" required="" placeholder="Enter Active Mobile Number"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Email Id <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtEmailId" runat="server" Type="email" MaxLength="100" required="" placeholder="Enter Your Email ID"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Batch Date <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtBatchDate" runat="server" required="" placeholder="Batch"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Trainer's Name <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtTrainerName" runat="server" required="" placeholder="Trainer"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Location of Training <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtTrainingLocation" runat="server" required="" placeholder="Location"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Nurturing Status <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:DropDownList ID="ddlNurturingStatus" runat="server" required="">
                                    <asp:ListItem Text="-- select Nurturing Status --" Value=""></asp:ListItem>
                                    <asp:ListItem Text="Not Started" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="Inprogress" Value="2"></asp:ListItem>
                                    <asp:ListItem Text="Completed" Value="3"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Total Fees Paid <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtTotalFeesPaid" Type="number" runat="server" required="" placeholder="Enter Total Fee Paid"></asp:TextBox>
                            </div>
                        </div>




                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Total Experience In Years<span style="color: red">*</span>
                            </label>
                            <div class="col-sm-2">
                                <asp:DropDownList ID="ddlExperienceInYears" runat="server" required="">
                                    <asp:ListItem Text="-- select Total Experience --" Value=""></asp:ListItem>
                                    <asp:ListItem Text="0" Value="0"></asp:ListItem>
                                    <asp:ListItem Text="1" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="2" Value="2"></asp:ListItem>
                                    <asp:ListItem Text="3" Value="3"></asp:ListItem>
                                    <asp:ListItem Text="4" Value="4"></asp:ListItem>
                                    <asp:ListItem Text="5" Value="5"></asp:ListItem>
                                    <asp:ListItem Text="6" Value="6"></asp:ListItem>
                                    <asp:ListItem Text="7" Value="7"></asp:ListItem>
                                    <asp:ListItem Text="8" Value="8"></asp:ListItem>
                                    <asp:ListItem Text="9" Value="9"></asp:ListItem>
                                    <asp:ListItem Text="10" Value="10"></asp:ListItem>
                                    <asp:ListItem Text="11" Value="11"></asp:ListItem>
                                    <asp:ListItem Text="12" Value="12"></asp:ListItem>
                                    <asp:ListItem Text="13" Value="13"></asp:ListItem>
                                    <asp:ListItem Text="14" Value="14"></asp:ListItem>
                                    <asp:ListItem Text="15" Value="15"></asp:ListItem>
                                    <asp:ListItem Text="16" Value="16"></asp:ListItem>
                                    <asp:ListItem Text="17" Value="17"></asp:ListItem>
                                    <asp:ListItem Text="18" Value="18"></asp:ListItem>
                                    <asp:ListItem Text="19" Value="19"></asp:ListItem>
                                    <asp:ListItem Text="20" Value="20"></asp:ListItem>
                                    <asp:ListItem Text="21" Value="21"></asp:ListItem>
                                    <asp:ListItem Text="22" Value="22"></asp:ListItem>
                                    <asp:ListItem Text="23" Value="23"></asp:ListItem>
                                    <asp:ListItem Text="24" Value="24"></asp:ListItem>
                                    <asp:ListItem Text="25" Value="25"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-sm-1">
                                <label class="control-label">
                                    Months
                                </label>
                            </div>
                            <div class="col-sm-2">
                                <asp:DropDownList ID="ddlExperienceInMonths" runat="server" required="" AutoPostBack="true">
                                    <asp:ListItem Text="-- select Total Experience --" Value=""></asp:ListItem>
                                    <asp:ListItem Text="0" Value="0"></asp:ListItem>
                                    <asp:ListItem Text="1" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="2" Value="2"></asp:ListItem>
                                    <asp:ListItem Text="3" Value="3"></asp:ListItem>
                                    <asp:ListItem Text="4" Value="4"></asp:ListItem>
                                    <asp:ListItem Text="5" Value="5"></asp:ListItem>
                                    <asp:ListItem Text="6" Value="6"></asp:ListItem>
                                    <asp:ListItem Text="7" Value="7"></asp:ListItem>
                                    <asp:ListItem Text="8" Value="8"></asp:ListItem>
                                    <asp:ListItem Text="9" Value="9"></asp:ListItem>
                                    <asp:ListItem Text="10" Value="10"></asp:ListItem>
                                    <asp:ListItem Text="11" Value="11"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Relevant Experience In Years<span style="color: red">*</span>
                            </label>
                            <div class="col-sm-2 col-md-2 col-lg-2">
                                <asp:DropDownList ID="ddlRelevantExperience" runat="server" required="">
                                    <asp:ListItem Text="-- select Relevant Experience --" Value=""></asp:ListItem>
                                    <asp:ListItem Text="0" Value="0"></asp:ListItem>
                                    <asp:ListItem Text="1" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="2" Value="2"></asp:ListItem>
                                    <asp:ListItem Text="3" Value="3"></asp:ListItem>
                                    <asp:ListItem Text="4" Value="4"></asp:ListItem>
                                    <asp:ListItem Text="5" Value="5"></asp:ListItem>
                                    <asp:ListItem Text="6" Value="6"></asp:ListItem>
                                    <asp:ListItem Text="7" Value="7"></asp:ListItem>
                                    <asp:ListItem Text="8" Value="8"></asp:ListItem>
                                    <asp:ListItem Text="9" Value="9"></asp:ListItem>
                                    <asp:ListItem Text="10" Value="10"></asp:ListItem>
                                    <asp:ListItem Text="11" Value="11"></asp:ListItem>
                                    <asp:ListItem Text="12" Value="12"></asp:ListItem>
                                    <asp:ListItem Text="13" Value="13"></asp:ListItem>
                                    <asp:ListItem Text="14" Value="14"></asp:ListItem>
                                    <asp:ListItem Text="15" Value="15"></asp:ListItem>
                                    <asp:ListItem Text="16" Value="16"></asp:ListItem>
                                    <asp:ListItem Text="17" Value="17"></asp:ListItem>
                                    <asp:ListItem Text="18" Value="18"></asp:ListItem>
                                    <asp:ListItem Text="19" Value="19"></asp:ListItem>
                                    <asp:ListItem Text="20" Value="20"></asp:ListItem>
                                    <asp:ListItem Text="21" Value="21"></asp:ListItem>
                                    <asp:ListItem Text="22" Value="22"></asp:ListItem>
                                    <asp:ListItem Text="23" Value="23"></asp:ListItem>
                                    <asp:ListItem Text="24" Value="24"></asp:ListItem>
                                    <asp:ListItem Text="25" Value="25"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-sm-1">
                                <label class="control-label">
                                    Months
                                </label>
                            </div>
                            <div class="col-sm-2">
                                <asp:DropDownList ID="ddlRelevantExperienceMonths" runat="server" AutoPostBack="true" required="">
                                    <asp:ListItem Text="-- select Total Experience --" Value=""></asp:ListItem>
                                    <asp:ListItem Text="0" Value="0"></asp:ListItem>
                                    <asp:ListItem Text="1" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="2" Value="2"></asp:ListItem>
                                    <asp:ListItem Text="3" Value="3"></asp:ListItem>
                                    <asp:ListItem Text="4" Value="4"></asp:ListItem>
                                    <asp:ListItem Text="5" Value="5"></asp:ListItem>
                                    <asp:ListItem Text="6" Value="6"></asp:ListItem>
                                    <asp:ListItem Text="7" Value="7"></asp:ListItem>
                                    <asp:ListItem Text="8" Value="8"></asp:ListItem>
                                    <asp:ListItem Text="9" Value="9"></asp:ListItem>
                                    <asp:ListItem Text="10" Value="10"></asp:ListItem>
                                    <asp:ListItem Text="11" Value="11"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>




                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Job Experience Domain <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtJobExperienceDomain" runat="server" Required="" Text="" placeholder="Enter Experience Domains"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Job Expected Domain <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtJobExpectedDomain" runat="server" Text="" Required="" placeholder="Enter Expected Domain"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Communication Skills(rate from 1-10)<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:DropDownList ID="ddlCommunicationRating" runat="server" required="">
                                    <asp:ListItem Text="-- select 1-10 --" Value=""></asp:ListItem>
                                    <asp:ListItem Text="0" Value="0"></asp:ListItem>
                                    <asp:ListItem Text="1" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="2" Value="2"></asp:ListItem>
                                    <asp:ListItem Text="3" Value="3"></asp:ListItem>
                                    <asp:ListItem Text="4" Value="4"></asp:ListItem>
                                    <asp:ListItem Text="5" Value="5"></asp:ListItem>
                                    <asp:ListItem Text="6" Value="6"></asp:ListItem>
                                    <asp:ListItem Text="7" Value="7"></asp:ListItem>
                                    <asp:ListItem Text="8" Value="8"></asp:ListItem>
                                    <asp:ListItem Text="9" Value="9"></asp:ListItem>
                                    <asp:ListItem Text="10" Value="10"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                BA Skills 
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtBASkills" runat="server" placeholder="Please name them and rate them"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Current CTC
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtCurrentCTC" runat="server" min="0" Type="Number" placeholder="Enter Current Salary" Text="" required=""></asp:TextBox>
                                <%--   <asp:RangeValidator ID="RangeValidator1" runat="server" Type="Integer"  ErrorMessage="Please valid salary" ForeColor="#FF3300" MaximumValue="9999999999" MinimumValue="0" ControlToValidate="txtExpectedSalary"></asp:RangeValidator>--%>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Expected CTC
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtExpectedSalary" runat="server" min="0" Type="Number" placeholder="Enter Expected Salary" Text="" required=""></asp:TextBox>
                                <%--   <asp:RangeValidator ID="RangeValidator1" runat="server" Type="Integer"  ErrorMessage="Please valid salary" ForeColor="#FF3300" MaximumValue="9999999999" MinimumValue="0" ControlToValidate="txtExpectedSalary"></asp:RangeValidator>--%>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Current Location<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtCurrentLocation" runat="server" Text="" Required="" placeholder="Enter Current Location"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Preferred Locations <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtPreferredLocation" runat="server" Required="" placeholder="Enter Preferred Locations"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Resume Finalized On 
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtResumeFinalizedOn" runat="server" placeholder="Enter Resume Finalized On"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Notice Period: <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:DropDownList ID="ddlNoticePeriod" runat="server" Required=""></asp:DropDownList>
                            </div>
                        </div>
                        <%--  <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Notice Period: 
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtNoticePeriod" runat="server" placeholder="Enter Notice Period"></asp:TextBox>
                            </div>
                        </div>--%>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Attachments
                            </label>
                            <div class="col-sm-9">
                                <h5>:
                                <asp:HyperLink ID="hplPhotoFile" runat="server" CssClass="btn btn-success btn-sm" Target="_blank">View Photo</asp:HyperLink>
                                    <asp:HyperLink ID="hplAadharFrontFile" runat="server" CssClass="btn btn-primary btn-sm" Target="_blank">View Aadhar Card Front</asp:HyperLink>
                                    <asp:HyperLink ID="hplAadharBackFile" runat="server" CssClass="btn btn-success btn-sm" Target="_blank">View Aadhar Card Back</asp:HyperLink>
                                    <asp:HyperLink ID="hplSalarySlipFile" runat="server" CssClass="btn btn-success btn-sm" Target="_blank">View Salary Slip</asp:HyperLink>
                                    <asp:HyperLink ID="hplServiceForm" runat="server" CssClass="btn btn-success btn-sm" Target="_blank">Service Form</asp:HyperLink>
                                </h5>
                            </div>
                        </div>
                        <div class="form-group" id="fuPhoto" runat="server">
                            <label class="col-sm-3 control-label">
                                Upload Passport Size Photo<small>(Up to 10 MB)</small>
                            </label>
                            <div class="col-sm-9">
                                <asp:FileUpload ID="flUploadPhoto" runat="server" />
                            </div>
                        </div>
                        <div class="form-group" id="fuAadharFront" runat="server">
                            <label class="col-sm-3 control-label">
                                Upload Aadhar Card Front<small>(Up to 10 MB)</small>
                            </label>
                            <div class="col-sm-9">
                                <asp:FileUpload ID="flUploadAadharFront" runat="server" />
                            </div>
                        </div>
                        <div class="form-group" id="fuAadharBack" runat="server">
                            <label class="col-sm-3 control-label">
                                Upload Aadhar Card Back<small>(Up to 10 MB)</small>
                            </label>
                            <div class="col-sm-9">
                                <asp:FileUpload ID="flUploadAadharBack" runat="server" />
                            </div>
                        </div>
                        <div class="form-group" id="fluSalarySlip" runat="server">
                            <asp:Label ID="lblSalarySlip" runat="server"> 
                                 <label class="col-sm-3 control-label">
                                Upload Latest SalarySlip<small>(Up to 10 MB)</small>
                            </label>
                            </asp:Label>

                            <div class="col-sm-9">
                                <asp:FileUpload ID="flUploadSalarySlip" runat="server" />
                            </div>
                        </div>



                        <div class="form-group" id="fluServiceForm" runat="server">
                            <asp:Label ID="lblServiceForm" runat="server"> 
                                 <label class="col-sm-3 control-label">
                                Upload Placement Wing Service form<small>(Up to 10 MB)</small>
                            </label>
                            </asp:Label>
                            <div class="col-sm-9">
                                <asp:FileUpload ID="flUploadPlacementWingServiceForm" runat="server" />
                            </div>
                            <asp:Label ID="lblFormDoc" runat="server">
                                 <p style="color:red"><strong>You will Find Form in Documents NO 42</strong></p>
                            </asp:Label>
                        </div>










                        <%--<div class="form-group">
                            <div class="col-sm-1">
                                <asp:CheckBox ID="chkTermsAccepted" runat="server" Font-Size="Large" />

                            </div>
                            <div class="col-sm-11">
                                <p style="color:red; font-size:large"><strong>I have read all Terms and conditions of COEPD given in student portal and I agree to abide by them.</strong></p>
                            </div>
                        </div>--%>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Update Status <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-9">
                                <asp:DropDownList ID="ddlIsDataSheetApproved" runat="server" required="">
                                    <asp:ListItem Text="-- select Pending / Approved --" Value=""></asp:ListItem>
                                    <asp:ListItem Text="Pending" Value="False"></asp:ListItem>
                                    <asp:ListItem Text="Approved" Value="True"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>

                        <div class="form-group">
                            <div class="col-sm-offset-3 col-sm-9">
                                <asp:Button ID="btnSubmit" runat="server" Text="Submit Data Sheet" OnClick="btnSubmit_Click" />
                                <asp:Button ID="btnBack" runat="server" SkinID="delete" CssClass="btn btn-danger btn-md" Text="Back To List" OnClick="btnBack_Click" UseSubmitBehavior="false" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

