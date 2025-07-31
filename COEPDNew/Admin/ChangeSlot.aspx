<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ChangeSlot.aspx.cs" Inherits="Admin_ChangeSlot" %>

<%@ Register src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
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
            $("[id*=txtSlotDate]").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: 'dd/mm/yy',
                minDate: "0",
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" Runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!-- Row Start -->
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        <asp:Label ID="lblTitle" Text="Change Slot" runat="server"></asp:Label>
                    </div>
                </div>
                 <div class="widget-body">
                <div class="form-horizontal no-margin">
                    <div class="form-group">
                        <label class="col-sm-2 control-label">
                            Participant Name
                        </label>
                        <div class="col-sm-5">
                            <h5>:
                                <asp:Label ID="lblParticipant" runat="server"></asp:Label>
                            </h5>
                            
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-2 control-label">
                            Stage Task
                        </label>
                        <div class="col-sm-5">
                            <h5>:
                                <asp:Label ID="lblStageTask" runat="server" />
                            </h5>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-2 control-label">
                            Present Mentor
                        </label>
                        <div class="col-sm-5">
                            <h5>:
                                <asp:Label ID="lblMentor" runat="server"></asp:Label>
                            </h5>
                            
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-2 control-label">
                            Present Slot Date
                        </label>
                        <div class="col-sm-5">
                            <h5>:
                                <asp:Label ID="lblSlotDate" runat="server"></asp:Label>
                            </h5>
                        </div>
                        
                    </div>
                    <div class="form-group">
                        <label class="col-sm-2 control-label">
                            Present Slot Time
                        </label>
                        <div class="col-sm-5">
                            <h5>:
                                <asp:Label runat="server" ID="lblSlotTime"></asp:Label>
                            </h5>
                            
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-2 control-label">
                            Select Action
                        </label>
                        <div class="col-sm-5">
                            <asp:DropDownList runat="server" ID="ddlAction" AutoPostBack="true" OnSelectedIndexChanged="ddlAction_SelectedIndexChanged" required="">
                                <asp:ListItem Text="-- Select Action --" Value="0"></asp:ListItem>
                                <asp:ListItem Text="Cancel Slot" Value="1"></asp:ListItem>
                                <asp:ListItem Text="Change Slot" Value="2"></asp:ListItem>
                                <asp:ListItem Text="Change Mentor" Value="3"></asp:ListItem>
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="RFVddlAction" runat="server" ControlToValidate="ddlAction" InitialValue="0" ErrorMessage="Select Action" Font-Bold="true" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-2 control-label">
                            <asp:Label ID="lblNewSlotDate" runat="server" Text="New Slot Date" Visible="false"></asp:Label>
                        </label>
                        <div class="col-sm-5">
                            <asp:TextBox ID="txtSlotDate" runat="server" required="" autoComplete="off" OnTextChanged="txtSlotDate_TextChanged" AutoPostBack="true" Visible="false"></asp:TextBox>
                        </div>
                    </div>
                   
                    <div class="form-group">
                        <label class="col-sm-2 control-label">
                            <asp:Label runat="server" ID="lblNewSlotTime" Text="New Slot Time" Visible="false"></asp:Label>
                        </label>
                        <div class="col-sm-5">
                            <asp:DropDownList runat="server" ID="ddlSlotTime" required="" Visible="false">

                            </asp:DropDownList>
                        </div>    
                    </div>
                     <div class="form-group">
                        <label class="col-sm-2 control-label">
                            <asp:Label ID="lblNewMentor" runat="server" Text="New Mentor" Visible="false"></asp:Label>
                        </label>
                        <div class="col-sm-5">
                            <asp:DropDownList runat="server" ID="ddlMentor" required="" Visible="false">

                            </asp:DropDownList>
                            <asp:HiddenField ID="hdnStageTaskId" runat="server" />
                            <asp:HiddenField runat="server" ID="hdnSlotStartTime" />
                            <asp:HiddenField runat="server" ID="hdnParticipantId" />
                            <asp:HiddenField runat="server" ID="hdnNurturingProcessId" />
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-offset-2 col-sm-10">
                            <asp:Button ID="btnSelectAction" runat="server" Text="Select Action" OnClick="btnSelectAction_Click" />
                            <asp:Button ID="btnCalcelSlot" runat="server" Text="Cancel Slot" Visible="false" OnClick="btnCalcelSlot_Click" OnClientClick="return confirm('Are you sure you want to Cancel this Slot?')" />
                            <asp:Button ID="btnModifySlot" runat="server" Text="Change Slot" Visible="false" OnClick="btnModifySlot_Click" OnClientClick="return confirm('Are you sure you want to Change this Slot?')" />
                            <asp:Button ID="btnChangeMentor" runat="server" Text="Change Mentor" Visible="false" OnClick="btnChangeMentor_Click" OnClientClick="return confirm('are you sure you want to Change Mentor for this Slot?')" />
                            <asp:Button ID="btnCancel" runat="server" Text="Back To List" SkinID="delete" CssClass="btn btn-warning btn-md" UseSubmitBehavior="false" CausesValidation="false" OnClick="btnCancel_Click" />
                        </div>
                    </div>

                </div>
            </div>
            </div>
           
        </div>

    </div>
    <!-- Row End -->
</asp:Content>

