<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true"
    CodeFile="careerdetails.aspx.cs" Inherits="CareerDetails" %>
<%@ Register Src="~/Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    Careers At Coepd
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
     <link rel="canonical" href="https://www.coepd.com/careerdetails.html" />
    <script type="text/javascript" src="js/jquery.js"></script>
        <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
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
                        <span class="login-title">
                            <asp:Label ID="lblPost" runat="server"></asp:Label>
                        </span>
                    </div>
                    <div class="form-horizontal">
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Name
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtName" runat="server" CssClass="form-control" Required=""></asp:TextBox>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidatorName" runat="server" ControlToValidate="txtName"
                                        ValidationExpression="^[a-zA-Z\s\.]+$" ErrorMessage="Valid characters: Alphabets and space." />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Email
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtReasonForChange" type="Email" runat="server" CssClass="form-control" Required="" OnTextChanged="txtReasonForChange_TextChanged" AutoPostBack="true"></asp:TextBox>
                                 <asp:RegularExpressionValidator runat="server" ID="RegularExpressionValidatorEmail" ErrorMessage="Invalid Email" ControlToValidate="txtReasonForChange" ForeColor="Red" 
                                         ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                                 </asp:RegularExpressionValidator>
                            </div>
                         </div>
                          <%-- <div class="form-group" id="divEmail" runat="server" visible="false">
                                    <label class="col-sm-3 control-label"></label>--%>
                                <div class="col-sm-12 control-label" id="divEmail" runat="server" visible="false">
                                    <asp:Label ID="lblEmail" runat="server" Visible="false"></asp:Label>
                                </div>
                        <%--    </div>--%>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Mobile
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtAddress" runat="server" type="number" CssClass="form-control" Required="" OnTextChanged="txtAddress_TextChanged" AutoPostBack="true"></asp:TextBox>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidatorMobile" runat="server"  ControlToValidate="txtAddress" ErrorMessage="Must be 10 Numbers" ValidationExpression="[0-9]{10}">
                                </asp:RegularExpressionValidator>
                            </div>
                            <div class="col-sm-12 control-label" runat="server" id="divMobile" visible="false">
                                <asp:Label ID="lbMobile" runat="server" Visible="false"></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Father's Name
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtFName" runat="server" CssClass="form-control" Required=""></asp:TextBox>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtFName"
                                        ValidationExpression="^[a-zA-Z\s\.]+$" ErrorMessage="Valid characters: Alphabets and space." />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Date of Birth
                            </label>
                            <div class="col-sm-9 col-md-9" >
                             <div  class="col-md-2">
                              <asp:DropDownList ID="ddlDay" Width="100%" runat="server">
                                  <asp:ListItem Text="Day" Value="0"></asp:ListItem>
                              </asp:DropDownList>
                              <asp:RequiredFieldValidator id="reqDay" Text="Required" InitialValue="0" ControlToValidate="ddlDay" Runat="server" /> 
                            </div>                          
                             <div class="col-md-2">
                              <asp:DropDownList ID="ddlMonth" Width="100%" runat="server" >
                                   <asp:ListItem Text="Month" Value="0"></asp:ListItem>
                              </asp:DropDownList>
                              <asp:RequiredFieldValidator id="reqMonth" Text="Required" InitialValue="0" ControlToValidate="ddlMonth" Runat="server" /> 
                            </div>                            
                             <div class="col-md-2">
                              <asp:DropDownList ID="ddlYear" Width="100%" runat="server" >
                                   <asp:ListItem Text="Year" Value="0"></asp:ListItem>
                              </asp:DropDownList>
                              <asp:RequiredFieldValidator id="reqYear" Text="Required" InitialValue="0" ControlToValidate="ddlYear" Runat="server" />                                      
                            </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Total Experience
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtTotalExp" runat="server" CssClass="form-control" Required=""></asp:TextBox>
                                 <asp:RegularExpressionValidator ID="txtTExp" runat="server" ControlToValidate="txtTotalExp"
                                        ValidationExpression="^[a-zA-Z0-9\s\.]+$" ErrorMessage="Valid characters: Alphabets,numbers and space." />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Relevant Experience
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtRelevantExp" runat="server" CssClass="form-control" Required=""></asp:TextBox>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtRelevantExp"
                                        ValidationExpression="^[a-zA-Z0-9\s\.]+$" ErrorMessage="Valid characters: Alphabets,numbers and space." />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Key Skills
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtSkills" runat="server" CssClass="form-control" MaxLength="500" Required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Strengths
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtStrengths" runat="server" CssClass="form-control" MaxLength="300" Required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Present Designation
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtDesignation" runat="server" CssClass="form-control" MaxLength="50" Required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label" style="margin-top:35px;">
                                Company Address
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtCompanyAdd" runat="server" CssClass="form-control" TextMode="MultiLine" Required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Present CTC
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtPresentCTC" runat="server" CssClass="form-control" Required=""></asp:TextBox>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtPresentCTC"
                                        ValidationExpression="^[a-zA-Z0-9\s\.]+$" ErrorMessage="Valid characters: Alphabets,numbers and space." />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Expected CTC
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtExpectedCTC" runat="server" CssClass="form-control" Required=""></asp:TextBox>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtExpectedCTC"
                                        ValidationExpression="^[a-zA-Z0-9\s\.]+$" ErrorMessage="Valid characters: Alphabets,numbers and space." />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Notice Period
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtNotice" runat="server" CssClass="form-control" Required=""></asp:TextBox>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txtNotice"
                                        ValidationExpression="^[a-zA-Z0-9\s]+$" ErrorMessage="Valid characters: Alphabets,numbers and space." />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Upload Resume
                            </label>
                            <div class="col-sm-9">
                                <asp:FileUpload ID="flUpload" runat="server" required="" />
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="flUpload"
                                        ValidationExpression="^.+(.doc|.DOC|.docx|.DOCX|.rtf|.RTF|.pdf|.PDF)$" ErrorMessage="Valid Formats: .doc,.docx,.pdf,.rtf" />
                            </div>
                        </div>
                        <div class="form-group col-sm-offset-3">
                            <asp:Button ID="btnSubmit" runat="server" Text="Send Resume" OnClick="btnSubmit_Click" />
                            <asp:HiddenField ID="hdnPost" runat="server" />
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
                        <b>Your Details are successfully saved. Our HR Executive will contact you shortly.</b>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script src="https://code.jquery.com/jquery-1.9.1.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $("input[id$=flUpload]").bind('change', function () {
                var size = parseFloat($("input[id$=flUpload]")[0].files[0].size / 1024).toFixed(2);
                if (size > 10240) {
                    alert('File size should be less than 10 MB.');
                    $("input[id$=flUpload]").val("");
                    return false;
                }
                else {
                    return true;
                }
            });
        });
    </script>
</asp:Content>