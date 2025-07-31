<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="Employee.aspx.cs" Inherits="Employee" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Row Start -->
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        <asp:Label ID="lblTitle" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Code
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtCode" runat="server" type="number" MaxLength="500" required="" OnTextChanged="txtCode_TextChanged" AutoPostBack="true"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group" id="divcode" runat="server" visible="false">
                            <label class="col-sm-9 control-label">
                            </label>
                            <div class="col-sm-3">
                                <asp:Label ID="lblcode" runat="server" Font-Bold="true" Visible="false"></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Employee
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtEmployee" MaxLength="500" runat="server" required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Location Name
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlLocation" runat="server" required="" AutoPostBack="true" OnSelectedIndexChanged="ddlLocation_SelectedIndexChanged">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Branch Name
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlBranch" runat="server" AutoPostBack="true" required="">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Designation
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlDesignation" runat="server" required="">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Department
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlDepartment" runat="server" required="">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Join Date
                            </label>
                            <div class="row">
                                <div class="col-lg-1 col-md-1">
                                    <asp:TextBox ID="txtDay" runat="server" MaxLength="2" type="number" Required=""></asp:TextBox>
                                </div>
                                <div class="col-lg-1 col-md-1">
                                    <asp:TextBox ID="txtMonth" runat="server" MaxLength="2" type="number" Required=""></asp:TextBox>
                                </div>
                                <div class="col-lg-2 col-md-2">
                                    <asp:TextBox ID="txtYear" runat="server" MaxLength="4" type="number" Required=""></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Office Email
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtOfficeEmail" MaxLength="500" runat="server" Type="Email"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Personal Email
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtEmail" MaxLength="500" runat="server" Type="Email"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Mobile
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtMobile" runat="server" MaxLength="50" type="number" required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                CUG Mobile
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtCUGMobile" MaxLength="50" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Phone
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtPhone" MaxLength="50" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Summary
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtSummary" MaxLength="5000" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Remarks
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtRemarks" MaxLength="2000" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Salary
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtSalary" MaxLength="20" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Address
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtAddress" MaxLength="3000" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                City
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtCity" MaxLength="500" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                State
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtState" MaxLength="500" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Zip
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtZipCode" MaxLength="500" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Emergency Contact
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtEmergencyContact" MaxLength="500" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Emergency Phone
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtEmergencyPhone" Type="numbers" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Phonepe Number
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtPhonePay" Type="Number" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                GooglePay Number
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtGooglePay" Type="Number" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Paytm Number
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtPaytm" Type="Number" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Account Holder Name
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtAccountHolderName" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Account Number
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtAccountNumber" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                IFSC Code
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtIFSCCode" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Bank Name
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtBankName" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Branch Name & Address
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtBranchName" runat="server"></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Upload Passbook
                            </label>
                            <div class="col-sm-10">
                                <asp:FileUpload ID="BankAccountFileUpload" runat="server" data-max-size="2048" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Upload Pan Card
                            </label>
                            <div class="col-sm-10">
                                <asp:FileUpload ID="PanCardFileUpload" runat="server" data-max-size="2048" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Upload Aadhar Front Side
                            </label>
                            <div class="col-sm-10">
                                <asp:FileUpload ID="AadharFrontFileUpload" runat="server" data-max-size="2048" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Upload Aadhar Back Side
                            </label>
                            <div class="col-sm-10">
                                <asp:FileUpload ID="AadharBackFileUpload" runat="server" data-max-size="2048" />
                            </div>
                        </div>




                        <div class="form-group">



                            <label class="col-sm-2 control-label">
                                Is Lead Permit
                            </label>
                            <div class="col-sm-1">
                                <asp:CheckBox ID="chkIsLeadPermit" runat="server" />
                            </div>



                            <label class="col-sm-2 control-label">
                                Nurture Permit
                            </label>
                            <div class="col-sm-1">
                                <asp:CheckBox ID="chkNurturePermit" runat="server" />
                            </div>


                            <label class="col-sm-2 control-label">
                                Is Trainer
                            </label>
                            <div class="col-sm-1">
                                <asp:CheckBox ID="chkIsTrainer" runat="server" />
                            </div>



                            <label class="col-sm-2 control-label">
                                Is Process
                            </label>
                            <div class="col-sm-1">
                                <asp:CheckBox ID="chkIsProcess" runat="server" />
                            </div>




                        </div>




                        <div class="form-group">



                            <label class="col-sm-2 control-label">
                                Is Mentor
                            </label>
                            <div class="col-sm-1">
                                <asp:CheckBox ID="chkIsMentor" runat="server" />
                            </div>



                            <label class="col-sm-2 control-label">
                                Is Discounter
                            </label>
                            <div class="col-sm-1">
                                <asp:CheckBox ID="chkIsDiscounter" runat="server" />
                            </div>


                            <label class="col-sm-2 control-label">
                                Is ReportingManager
                            </label>
                            <div class="col-sm-1">
                                <asp:CheckBox ID="chkIsReportingManager" runat="server" />
                            </div>

                            <label class="col-sm-2 control-label">
                                IsAssociate
                            </label>
                            <div class="col-sm-1">
                                <asp:CheckBox ID="chkIsAssociate" runat="server" Checked="true" />
                            </div>






                        </div>














                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Is Active
                            </label>
                            <div class="col-sm-1">
                                <asp:CheckBox ID="chkIsActive" runat="server" />
                            </div>
                            <label class="col-sm-2 control-label">
                                Is VerticalHead
                            </label>
                            <div class="col-sm-1">
                                <asp:CheckBox ID="chkIsVerticalHead" runat="server" />
                            </div>
                        </div>


                

















                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Upload Resume
                            </label>
                            <div class="col-sm-10">
                                <asp:FileUpload ID="ResumeFileUpload" runat="server" data-max-size="2048" />
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Roles
                            </label>
                            <div class="col-sm-10">
                                <CKEditor:CKEditorControl runat="server" ID="txtRoles">

                                </CKEditor:CKEditorControl>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Save and Continue to Assign Employee Features" />

                                <asp:Button ID="btnCancel" runat="server" Text="Back to list" UseSubmitBehavior="false"
                                    OnClick="btnCancel_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Row End -->
</asp:Content>
