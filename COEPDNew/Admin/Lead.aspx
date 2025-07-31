<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="Lead.aspx.cs" Inherits="Lead" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <meta name="description" content="coepd Verify Employee certificates" />
    <meta name="keywords" content="certificate verification, BA certificate verification, check certificate number, verify IIBA certification, Coepd certificate verification." />
    <link rel="canonical" href="https://www.coepd.com/certification-verify.html" />

<%--    <script type="text/javascript" src="../App_Themes/admin/js/jquery.js"></script>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery-ui-v1.10.3.js"></script>
    <script type="text/javascript">
        function alertmeSave() {
            Swal.fire(
                'Details successfully Added',
                '',
                'success'
            )
        }
        function alertmeUpdate() {
            Swal.fire(
                'Details successfully updated',
                '',
                'success'
            )
        }
        function alertmeDuplicateMobile() {
            Swal.fire(
                'Mobile Number already exist in our Record',
                'Record exists ',
                'warning'
            )
        }

        function alertmeDuplicateEmail() {
            Swal.fire(
                'Email already exist in our Record',
                'Record exists ',
                'warning'
            )
        }
    </script>--%>
    
    <script src="../js/bootstrap.js" type="text/javascript"></script>
    <script src="../js/style.js" type="text/javascript"></script>
    <script  src="https://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js" type="text/javascript"></script>
    <script src="https://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.9/jquery-ui.js" type="text/javascript"></script>
    <link href="https://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.9/themes/start/jquery-ui.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        function ShowPopup(message) {
            $(function () {
                $("#dialog").html(message);
                $("#dialog").dialog({
                    title: "COEPD Lead Data",
                    buttons: {
                        Close: function () {
                            $(this).dialog('close');
                        }
                    },
                    modal: true
                });
            });
        };
    </script>



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


                    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>



                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Search Lead Owner
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtLeadSource" runat="server" OnTextChanged="txtLeadSource_TextChanged" Required="" AutoPostBack="true"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Select Lead Owner
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlLeadOwner" runat="server" Required="">
                                </asp:DropDownList>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Lead Source
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlLeadSource" runat="server" Required="">
                                </asp:DropDownList>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Course
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlCourse" runat="server" Required="">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Batch Type
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlBatchType" runat="server" Required="">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Location Name:
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlLocation" runat="server" Required="">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Name
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtLead" runat="server" Required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Primary Mobile
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtPrimaryMobile" runat="server" AutoPostBack="true" Required="" type="number" OnTextChanged="txtPrimaryMobile_TextChanged"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Secondary Mobile
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtSeondaryMobile" runat="server" type="number"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Primary Email
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtPrimaryEmail" runat="server" type="email" AutoPostBack="true" OnTextChanged="txtPrimaryEmail_TextChanged"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Secondary Email
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtSeondaryEmail" runat="server" type="email"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Phone
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Address
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Domain
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtdomain" runat="server" TextMode="MultiLine"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Expirence
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtexp" runat="server" TextMode="MultiLine"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Save" />
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
