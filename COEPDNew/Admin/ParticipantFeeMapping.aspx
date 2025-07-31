<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ParticipantFeeMapping.aspx.cs" Inherits="Admin_ParticipantFeeMapping" %>

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

        function alertmeSave() {
            Swal.fire(
                'Lead Fee MappingSuccessfully Added',
                '',
                'success'
            )
        }

        function alertmeSaving() {
            Swal.fire(
                'lead discount adding Successfully ',
                '',
                'success'
            )
        }
        function alertmeUpdate() {
            Swal.fire(
                'Lead Fee MappingSuccessfully Updated',
                '',
                'success'
            )
        }
        function alertmeUpdating() {
            Swal.fire(
                'Lead Discount Successfully Updated',
                '',
                'success'
            )
        }

        function alertmeDuplicate() {
            Swal.fire(
                'Lead Fee MappingAlready Exist',
                '',
                'warning'
            )
        }
        function alertmeSaveIn() {
            Swal.fire(
                'Lead Installment Successfully Added',
                '',
                'success'
            )
        }
        function alertmeUpdateIn() {
            Swal.fire(
                ' Updated Lead Installments Successfully',
                '',
                'success'
            )
        }
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
                        <asp:Label ID="lblTitle" Text="Participant Fee Mapping" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">
                        <div class="form-group" id="divParticipant" runat="server">
                            <label class="col-sm-1 control-label">
                                Lead <sup class="sup">*</sup>
                            </label>
                            <div class="col-lg-4 col-md-3">
                                <asp:TextBox ID="txtSearch" runat="server" AutoPostBack="true" OnTextChanged="txtSearch_TextChanged"></asp:TextBox>

                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-1 control-label">
                                select Lead<sup class="sup">*</sup>
                            </label>
                            <div class="col-lg-4 col-md-3">
                                <asp:DropDownList ID="ddllead" runat="server" AutoPostBack="true" OnTextChanged="ddllead_TextChanged">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-1 control-label">
                                Services Taken <sup class="sup">*</sup>
                            </label>
                            <div class="col-lg-4 col-md-3">
                                <asp:DropDownList ID="ddlServices" runat="server" OnSelectedIndexChanged="ddlServices_SelectedIndexChanged" AutoPostBack="true">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-1 control-label">
                                Batch 
                            </label>
                            <div class="col-lg-4 col-md-3">
                                <asp:DropDownList ID="ddlBatch" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlBatch_SelectedIndexChanged" AppendDataBoundItems="true">
                                  <asp:ListItem Selected="True" Value="0" Text="Select"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-1 control-label">
                                Actual Fee 
                            </label>
                            <div class="col-lg-4 col-md-3">
                                <asp:TextBox ID="txtActualFee" runat="server" MaxLength="500"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group" id="divdiscount" visible="false" runat="server">





                            <div class="form-group">
                                <label class="col-sm-7 control-label">
                                    Associate<sup class="sup">*</sup>
                                </label>

                                


                                    <div class="col-lg-4 col-md-1">
                                        <asp:TextBox ID="txtAssociates" Required="" runat="server" />
                                    </div>

                                 
                            </div>
                            <div class="form-group">
                                <label class="col-sm-7 control-label">
                                    Discount <sup class="sup">*</sup>
                                </label>
                                <div class="col-lg-4 col-md-1">
                                    <asp:TextBox ID="txtDiscount" Required="" runat="server" />
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-sm-offset-7 col-sm-8">
                                    <asp:Button ID="btndiscount" runat="server" SkinID="btnGreen" Text="Submit" OnClick="btndiscount_Click" />
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-1 control-label">
                                Discount
                            </label>
                            <div class="col-sm-4">
                                <asp:TextBox ID="txtDiscounts" runat="server" MaxLength="500"></asp:TextBox>
                            </div>

                            <div class="col-sm-offset-5 col-sm-1">
                                <asp:Button ID="btnView" runat="server" Text="View Discounts" OnClick="btnView_Click" />

                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-1 control-label">
                                Agreed Fee 
                            </label>
                            <div class="col-sm-4">
                                <asp:TextBox ID="txtAgreedFee" runat="server" MaxLength="500"></asp:TextBox>
                            </div>

                        </div>
                        <div class="form-group">
                            <label class="col-sm-1 control-label">
                                Service Owner:
                            </label>


                            <div class="col-lg-4 col-md-1">


                                 
                                        <asp:TextBox ID="txtServiceOwner" Required="" runat="server" />
                                    



                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-1 control-label">
                                Lead Owner:
                            </label>
                            <div class="col-lg-4 col-md-1">
                                <asp:DropDownList ID="ddlLeadOwner" runat="server">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-1 control-label">
                                Location:
                            </label>
                            <div class="col-lg-4 col-md-1">
                                <asp:DropDownList ID="ddlLocation" runat="server">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <br />
                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:Button ID="btnSubmit" runat="server" Text="Save" OnClick="btnSubmit_Click" />
                                <asp:Button ID="btnCancel" runat="server" Text="Back to list" UseSubmitBehavior="false" OnClick="btnCancel_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
