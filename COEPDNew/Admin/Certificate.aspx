<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="Certificate.aspx.cs" Inherits="Admin_Certificate" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript" src="../App_Themes/admin/js/jquery.js"></script>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery-ui-v1.10.3.js"></script>
    <script type="text/javascript">
        $(document).ready(function ($) {
            $("[id*=txtCourseStartDate]").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: 'dd/mm/yy',
               
            });
        });
        $(document).ready(function ($) {
            $("[id*=txtCourseEndDate]").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: 'dd/mm/yy',
            });
        });
        function alertmeDuplicate() {
            Swal.fire(
                'CertificateID already exist',
                '',
                'warning'
            )
        }
        function alertmeDuplicates() {
            Swal.fire(
                'Participant Certificate already exist',
                '',
                'warning'
            )
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <%--    <asp:ScriptManager ID="script1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="panel1" runat="server">
        <ContentTemplate>--%>
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        <asp:Label ID="lblTitle" runat="server">Add IIBA Certificate</asp:Label>
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">
                        <asp:DropDownList ID="ddlParticipantId" runat="server" Enabled="false" Visible="false">
                        </asp:DropDownList>
                        <div class="form-group">

                            <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    Reference Number
                                <asp:Label runat="server" ID="ActivityStar" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                                </label>
                                <div class="col-sm-5">
                                    <asp:TextBox ID="txtSearch" runat="server" MaxLength="5000" required="" AutoPostBack="true" OnTextChanged="txtSearch_TextChanged"></asp:TextBox>
                                </div>
                            </div>


                            <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    Participant Name
                                <asp:Label runat="server" ID="Label6" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                                </label>
                                <div class="col-sm-5">
                                    <asp:DropDownList ID="ddlParticipant" runat="server" required="" Enabled="false">
                                    </asp:DropDownList>
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    Edit Participant Name
                                <asp:Label runat="server" ID="Label7" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                                </label>
                                <div class="col-sm-5">
                                    <asp:TextBox ID="txtEditParticipantName" runat="server" MaxLength="5000" required=""></asp:TextBox>
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    Course Start Date
                                <asp:Label runat="server" ID="Label1" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                                </label>
                                <div class="col-sm-5">
                                    <%--    <asp:DropDownList ID="ddlBatchDate" runat="server" required="" Enabled="false" DataTextFormatString="{0:d}">
                                    </asp:DropDownList>--%>

                                    <asp:TextBox ID="txtCourseStartDate" runat="server" MaxLength="5000" required=""></asp:TextBox>

                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    Course End Date
                                <asp:Label runat="server" ID="Label2" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                                </label>
                                <div class="col-sm-5">
                                    <asp:TextBox ID="txtCourseEndDate" runat="server" MaxLength="5000" required=""></asp:TextBox>
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    Certificate ID
                                <asp:Label runat="server" ID="Label4" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                                </label>
                                <asp:DropDownList ID="ddlReferrenceNumber" runat="server" required="" Visible="false">
                                </asp:DropDownList>
                                <div class="col-sm-5">
                                    <asp:TextBox ID="txtCertificateID" runat="server" MaxLength="5000" required="" ></asp:TextBox>
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    Upload Empty Certificate
                                <asp:Label runat="server" ID="Label5" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                                </label>
                                <div class="col-sm-5">
                                    <asp:FileUpload ID="flUpload" runat="server" required="" />
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-sm-offset-2 col-sm-10">

                                    <asp:Button ID="btnSave" runat="server" Text="Upload Certificate" OnClick="btnSave_Click" />
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <%--</ContentTemplate>
    </asp:UpdatePanel>--%>
</asp:Content>

