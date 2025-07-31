<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="NurturingTask.aspx.cs" Inherits="Admin_NurturingTask" %>

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
            $("[id*=txtTargetDateInterval]").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: 'dd/mm/yy',
                minDate: "0",
            });
        });
        function alertmeSave() {
            Swal.fire(
                'Task Successfully Added',
                '',
                'success'
            )
        }
        function alertmeUpdate() {
            Swal.fire(
                'Task Successfully updated',
                '',
                'success'
            )
        }

        function alertmeDuplicate() {
            Swal.fire(
                'Task already exist',
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
    <!-- Row Start -->
    <div class="row">
        <div class="col-sm-8 col-xs-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        <asp:Label ID="lblTitle" Text="Add Nurturing Process Stage Task" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Select Stage<sup class="sup">*</sup>
                                <%-- <asp:HiddenField ID="hdnNurturingProcessSlotsId" Value="0" runat="server" />--%>
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlNurturingProcessStage" runat="server" required="" AutoPostBack="true" OnSelectedIndexChanged="ddlNurturingProcessStage_SelectedIndexChanged1">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Select Stage Task<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlNurturingProcessStageTask" runat="server" required="" AutoPostBack="true" OnSelectedIndexChanged="ddlNurturingProcessStageTask_SelectedIndexChanged1">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group" id="divAttachments" runat="server">
                            <label class="col-sm-2 control-label">
                                Attachments
                            </label>
                            <div class="col-sm-9">
                                <h5>
                                    <asp:HyperLink ID="hplSentFile" runat="server" CssClass="btn btn-success btn-sm" Target="_blank">View Question Paper</asp:HyperLink>
                                    <%--<asp:HyperLink ID="hplReplyFile" runat="server" CssClass="btn btn-primary btn-sm" Target="_blank">View Answer Paper</asp:HyperLink>--%>
                                </h5>
                            </div>
                        </div>
                        <div class="form-group" id="divUpload" runat="server">
                            <label class="col-sm-2 control-label">
                                Upload File 
                            </label>
                            <div class="col-sm-4">
                                <asp:FileUpload ID="flUpload" runat="server" />
                            </div>
                            <div class="col-sm-6">
                                <small>( Max 10 MB )</small>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Target Date Interval  <sup class="sup">*</sup>
                            </label>
                        <div class="col-sm-10">
                            <asp:DropDownList ID="ddlTargetDateInterval" runat="server" required="">
                                <asp:ListItem Text="--Select Target Date--" Value=""></asp:ListItem>
                                <asp:ListItem Text="1 day" Value="1"></asp:ListItem>
                                <asp:ListItem Text="2 days" Value="2"></asp:ListItem>
                                <asp:ListItem Text="3 days" Value="3"></asp:ListItem>
                                <asp:ListItem Text="4 days" Value="4"></asp:ListItem>
                                <asp:ListItem Text="5 days" Value="5"></asp:ListItem>
                                <asp:ListItem Text="6 days" Value="6"></asp:ListItem>
                                <asp:ListItem Text="7 days" Value="7"></asp:ListItem>
                                <asp:ListItem Text="8 days" Value="8"></asp:ListItem>
                                <asp:ListItem Text="9 days" Value="9"></asp:ListItem>
                                <asp:ListItem Text="10 days" Value="10"></asp:ListItem> 
                            </asp:DropDownList>
                        </div>
                            </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Task Inputs<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtTaskInputs" runat="server" required="" TextMode="MultiLine"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Save" />
                                <asp:Button ID="btnCancel" runat="server" SkinID="delete" CssClass="btn btn-warning btn-md" Text="Back to list" UseSubmitBehavior="false" CausesValidation="false"
                                    OnClick="btnCancel_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

