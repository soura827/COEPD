<%@ Page Title="" Language="C#" MasterPageFile="~/Participant/Participant.master" AutoEventWireup="true" CodeFile="HrProcess.aspx.cs" Inherits="Participant_HrProcess" %>

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
            $("[id*=txtSlotDate]").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: 'dd/mm/yy',
                minDate: "0",
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Row Start -->
    <%--<asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>--%>

    <%-- <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>--%>

    <div class="row">
        <div class="col-sm-6 col-xs-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        <asp:Label ID="lblTitle" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">
                       
                       
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Evaluator Comments
                            </label>
                            <div class="col-sm-9">
                                <h5>:
                                    <asp:Label ID="lblNotes" runat="server"></asp:Label></h5>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Status
                            </label>
                            <div class="col-sm-9">
                                <h5>:
                                    <asp:Label ID="lblStatus" runat="server"></asp:Label></h5>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Target Date
                            </label>
                            <div class="col-sm-9">
                                <h5>:
                                    <asp:Label ID="lblTargetDate" runat="server"></asp:Label></h5>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                <asp:Label ID="lblSelectSlotDate" runat="server" Text="Select Slot Date"></asp:Label>
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtSlotDate" runat="server" required="" autoComplete="off" OnTextChanged="txtSlotDate_TextChanged" AutoPostBack="true"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                <asp:Label runat="server" ID="lblSelectSlot" Text="Select Slot"></asp:Label>
                            </label>
                            <div class="col-sm-9">
                                <asp:DropDownList ID="ddlAvilableSlots" runat="server" required="">
                                </asp:DropDownList>
                       <%--         <h5>
                                    <asp:Label ID="lblAvilableSlots" runat="server"></asp:Label></h5>--%>
                            </div>
                        </div>
                       <%-- <div class="form-group">
                            <label class="col-sm-3 control-label">
                            </label>
                            <div class="col-sm-9">
                                <h5>
                                    <asp:Label ID="lblNextAvailableSlots" runat="server" ForeColor="red" Font-Bold="true"></asp:Label>
                                </h5>
                            </div>
                        </div>--%>
                       <%-- <div class="form-group">
                            <div class="col-sm-12">
                                <h4>
                                    <asp:Label ID="lblNotice" runat="server" Text=" Notice : Before the student book an evaluation slot, ensure that you have prepared well and your work will not get REDO. For redo terms please refer to student terms." ForeColor="red" Font-Bold="true"></asp:Label>
                                </h4>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-12">
                                <h4>
                                    <asp:Label ID="lblNotice2" runat="server" Text="If any student has not attended two consecutive slots or overall 5 Slots, then COEPD has the right to block their services." ForeColor="red" Font-Bold="true"></asp:Label>
                                </h4>
                            </div>
                        </div>
                        <div class="form-group" id="FileUpload1" runat="server" required="">
                            <label class="col-sm-3 control-label">
                                Upload Answer Sheet 

                                        <sup class="sup">*</sup>
                                <br />
                                <small>(Max 10 MB)</small>
                            </label>
                            <div class="col-sm-9">
                                <h5>:
                                    <asp:FileUpload ID="flUpload" runat="server" required="" />
                                </h5>
                            </div>
                        </div>--%>
                        <%-- <div class="form-group">
                                     <div class="col-sm-offset-3 col-sm-9">
                                    <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                                        <ProgressTemplate>
                                            <div class="div1" style="margin-left: 10px">
                                                <asp:Image ID="Image1" ImageUrl="/img/CoepdLoad.gif" AlternateText="Processing" runat="server" />
                                                <asp:Label ID="Label1" runat="server" Text="The Inputs are Loading so Please Wait"></asp:Label>
                                            </div>
                                        </ProgressTemplate>
                                    </asp:UpdateProgress>
                                         </div>
                                </div>--%>
                        <div class="form-group">
                            <div class="col-sm-offset-3 col-sm-9">
                                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Book Evaluation Slot" />
                             <%--   <asp:Button ID="btnUploadFile" runat="server" OnClick="btnUploadFile_Click" Text="Submit New Answer Sheet" Visible="false" />--%>
                                <asp:Button ID="btnCancel" runat="server" Text="Back to list" UseSubmitBehavior="false" CssClass="btn btn-warning btn-md"
                                    SkinID="delete" OnClick="btnCancel_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class="col-sm-6 col-xs-12">
           <%-- <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Previous Hr Team Inputs
                    </div>
                </div>
                <div class="widget-body" style="height: 550px; overflow-y: scroll">
                    <div class="viewport">
                        <div class="overview">
                            <ul class="chats">
                                <asp:Repeater ID="rp" runat="server" OnItemDataBound="rp_OnItemDataBound">
                                    <ItemTemplate>
                                        <asp:HiddenField ID="hdnRoleId" runat="server" Value='<%# Eval("RoleId")%>' />
                                        <asp:Panel ID="pnlIn" runat="server" Visible="false">
                                            <li class="in">
                                                <img class="avatar" alt="" src="../img/profile.png" />
                                                <div class="message">
                                                    <span class="arrow"></span><a href="#" class="name">
                                                        <%# Eval("Participant")%>
                                                    </a><span class="date-time">at
                                                        <%# Eval("CreatedOn", "{0:MMM dd, yyyy hh:mm tt}")%>
                                                    </span><span class="body">
                                                        <%# Eval("Chat") %></span>
                                                </div>
                                            </li>
                                        </asp:Panel>
                                        <asp:Panel ID="PnlOut" runat="server" Visible="false">
                                            <li class="out">
                                                <img class="avatar" alt="" src="../img/profile.png">
                                                <div class="message">
                                                    <span class="arrow"></span><a href="#" class="name">
                                                        <%# Eval("Employee")%>
                                                    </a><span class="date-time">at
                                                        <%# Eval("CreatedOn", "{0:MMM dd, yyyy hh:mm tt}")%>
                                                    </span><span class="body">
                                                        <%# Eval("Chat") %>
                                                    </span>
                                                </div>
                                            </li>
                                        </asp:Panel>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>--%>
            <%--<div class="widget">
                <div class="form-horizontal no-margin">
                    <div class="widget-header">
                        <div class="title">
                            Contact Hr Team - Service Request (Minimum 150 characters)
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-12">
                            <asp:TextBox ID="txtNotes" runat="server" TextMode="MultiLine" Height="200px"
                                placeholder="Enter Service Request in Detail (Minimum 150 characters)">
                            </asp:TextBox>
                            
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-offset-3 col-sm-9">
                            <asp:Button ID="btnSend" runat="server" Text="Send Service Request" UseSubmitBehavior="false"
                                OnClick="btnSend_Click" />
                        </div>
                    </div>
                </div>
            </div>--%>
        </div>


    </div>
    <!-- Row End -->
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
   <%-- <script type="text/javascript">
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
    </script>--%>
    <script type="text/javascript">
        jQuery(document).ready(function () {

            $("[id*=btnSend]").click(function () {
                var mesg = $("[id*=txtNotes]").val();

                if (mesg.length == 0) {
                    alert('Please Enter your Query');
                    $("[id*=txtNotes]").focus();
                    //return false;
                }
            });
        });
    </script>
    <%--</ContentTemplate>
    </asp:UpdatePanel>--%>
</asp:Content>

