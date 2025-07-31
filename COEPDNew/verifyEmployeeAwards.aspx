<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true" CodeFile="verifyEmployeeAwards.aspx.cs" Inherits="verifyEmployeeAwards" %>

<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<%@ Register Src="Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc3" %>
<%@ Register Src="Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc4" %>

<asp:Content ID="Content3" ContentPlaceHolderID="title" runat="Server">
    Verify COEPD Employees Certificates
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="Server">
    <meta name="description" content="coepd Verify Employee certificates" />
    <meta name="keywords" content="certificate verification, BA certificate verification, check certificate number, verify IIBA certification, Coepd certificate verification." />
    <link rel="canonical" href="https://www.coepd.com/certification-verify.html" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="cpContent" runat="Server">
    <script src="js/bootstrap.js" type="text/javascript"></script>
    <script src="js/style.js" type="text/javascript"></script>
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js"></script>
    <script src="https://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.9/jquery-ui.js" type="text/javascript"></script>
    <link href="https://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.9/themes/start/jquery-ui.css"
        rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        function ShowPopup(message) {
            $(function () {
                $("#dialog").html(message);
                $("#dialog").dialog({
                    title: "COEPD Verify Awards",
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
    <div id="dialog" style="display: none">
    </div>
    <div id="recent-updates">
        <div class="container">
            <div class="col-md-12">
                <uc1:NewsAll ID="NewsAll" runat="server" />
            </div>
        </div>
    </div>
    <!--  Inner page Content start -->
    <div id="inner-cont">
        <div class="container">
            <div id="main-content">
                <div class="col-md-7">
                    <div class="login-box">
                        <div class="box-title">
                            <span class="login-title">COEPD Verify Employee Certifications</span>
                        </div>
                        <div class="form-horizontal">
                            <div class="form-group">
                                <div class="col-sm-12">
                                    <uc3:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
                                    <uc4:FormMessage ID="FormMessage" runat="server" Visible="false" />
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-3 control-label">
                                    Search By <sup class="sup">*</sup>
                                </label>
                                <div class="col-sm-7">
                                    <asp:DropDownList ID="ddlSearchBy" runat="server" required="" AutoPostBack="true" OnSelectedIndexChanged="ddlSearchBy_SelectedIndexChanged">
                                        <asp:ListItem Text="--Select Certificate Id / E-Mail --" Value=""></asp:ListItem>
                                        <asp:ListItem Text="Certificate Id" Value="1"></asp:ListItem>
                                        <asp:ListItem Text="E Mail" Value="2"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div id="divCertificate" runat="server" visible="false">
                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Certificate Id :
                                    </label>
                                    <div class="col-sm-7">
                                        <asp:TextBox ID="txtCertificateId" required="" AutoPostBack="true" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div id="divEmail" runat="server" visible="false">


                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        E Mail :
                                    </label>
                                    <div class="col-sm-7">
                                        <asp:TextBox ID="txtEmail" required="" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-sm-3 control-label">
                                </label>
                                <div class="col-sm-9">
                                    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Verify" />&nbsp
                                    <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" UseSubmitBehavior="false" />
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            &nbsp;
                        </div>
                    </div>
                    <div class="col-md-2">
                    </div>

                </div>
                <div class="col-md-3 our-locations">
                    <uc2:Locations ID="Locations" runat="server" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>

