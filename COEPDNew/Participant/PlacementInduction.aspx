<%@ Page Title="" Language="C#" MasterPageFile="~/Participant/Participant.master" AutoEventWireup="true" CodeFile="PlacementInduction.aspx.cs" Inherits="Participant_PlacementInduction" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
      <style type="text/css">
        .ui-widget-content .ui-icon {
    /*background-image: url("../App_Themes/admin//images/ui-icons_222222_256x240.png")*/ 
    /*background-image:url("../App_Themes/admin/img/ui-icons_444444_256x240.png")*/
     background-image:url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png")      
            !important;}
    .ui-widget-header .ui-icon {
    /*background-image: url("../App_Themes/admin/img/ui-icons_444444_256x240.png")*/ 
    background-image:url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png")  
        !important;}
    </style>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery.js"></script>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery-ui-v1.10.3.js"></script>
    <script type="text/javascript">
        $(document).ready(function ($) {
            $("input[id$=txtAttendedOn]").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: 'dd/mm/yy',
                maxDate: "0"
            });
        });
        function alertmeSave() {
            Swal.fire(
                      'BA Job market  Induction Status Added Successfully',
                      '',
                      'success'
                    )
        }
        function alertmeUpdate() {
            Swal.fire(
                      'BA Job market  Induction Status Updated Successfully',
                      '',
                      'success'
                    )
        }

        function alertmeDuplicate() {
            Swal.fire(
                      'BA Job market  Induction Status already exist',
                      '',
                      'warning'
                    )
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="row">
        <div class="col-lg-1 col-md-1">

        </div>
        <div class="col-lg-9 col-md-9">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        BA Job market  Induction Status
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">
                        <div class="form-group">
                            <label class="col-sm-12 text-right">
                                <i><span style="color: red">*</span> indicates manditory field</i>
                            </label>
                        </div>
                       
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                BA Job market  Induction Attended On <span style="color: red">*</span>
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtAttendedOn" runat="server" required="" placeholder="Select Attended On"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-1">
                                <asp:CheckBox ID="chkTermsAccepted" runat="server" AutoPostBack="true" Font-Size="Large" />

                            </div>
                            <div class="col-sm-11">
                                <asp:Label ID="lblTerms" runat="server">
                                    <p style="color:red; font-size:large"><strong>I understood all JobMarket Terms of COEPD and I agree to abide by them.</strong></p>
                                    <%--<p style="color:red; font-size:large"><strong>I have read all Terms and conditions of COEPD given in student portal and I agree to abide by them.</strong></p>--%>
                                </asp:Label>
                                
                            </div>
                        </div>

                        
                        <div class="form-group">
                            <div class="col-sm-offset-3 col-sm-9">
                                <asp:Button ID="btnSubmit" runat="server" Text="Submit" Enabled="false" OnClick="btnSubmit_Click" />
                                <asp:Button ID="btnBack" runat="server" SkinID="delete" CssClass="btn btn-danger btn-md" Text="Back To List" OnClick="btnBack_Click" UseSubmitBehavior="false" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

