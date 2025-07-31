<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ZoomMeeting.aspx.cs" Inherits="Admin_ZoomMeeting" %>

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
            $("[id*=txtZoomMeetingDateOn]").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: 'dd/mm/yy',
                minDate: "0",

            });
        });
        $(document).ready(function ($) {
            $("[id*=txtZoomMeetingTime]").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: 'dd/mm/yy',


            });
        });
        //$(document).ready(function ($) {
        //    $("[id*=txtZoomMeetingEndTimeOn]").datepicker({
        //        changeMonth: true,
        //        changeYear: true,
        //        dateFormat: 'dd/mm/yy',
        //        minDate: "1",

        //    });
        //});
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

        function alertmeDuplicate() {
            Swal.fire(
                'Details already exist',
                '',
                'warning'
            )
        }
       
        function GiveCorrectTime() {
            Swal.fire(
                'please give Corerct time',
                '',
                'warning'
            )
        }


    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
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
                                Zoom Meeting Category: <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:DropDownList ID="ddlZoommeetingCategory" runat="server" Required="">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                URL: <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:TextBox ID="txtUrl" runat="server" Required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Zoom Meeting Id: <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:TextBox ID="txtZoomMeetingId" runat="server" Required=""></asp:TextBox>
                                
                                
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Pass Code: <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:TextBox ID="txtPasscode" runat="server" Required=""></asp:TextBox>
                            </div>
                        </div>


                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Host Employee:<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:DropDownList ID="ddlHostemployee" runat="server" Required="">
                                </asp:DropDownList>
                            </div>
                        </div>



                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Zoom MeetingDate On: <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-4">
                                <asp:TextBox ID="txtZoomMeetingDateOn" runat="server" Required="" />
                            </div>
                        </div>



                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                IsBatch Only <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-2">
                                <asp:CheckBox ID="chkIsBatchOnly" runat="server" AutoPostBack="true" OnCheckedChanged="chkIsBatchOnly_CheckedChanged" Required=""/>
                            </div>
                        </div>




                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                <asp:Label runat="server" ID="lblBatchOnly" Visible="false" Text="Batch"></asp:Label>
                            </label>
                            <div class="col-sm-6">
                                <asp:DropDownList ID="ddlBatch" runat="server" Required="" Visible="false">
                                </asp:DropDownList>
                            </div>
                        </div>




                        <%--  <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Zoom MeetingStarting Time: <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-4">
                                <asp:TextBox ID="txtZoomMeetingTime" runat="server" Required="" />
                            </div>
                          </div> --%>



                        <%--   <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Zoom MeetingEnding On: <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-4">
                                <asp:TextBox ID="txtZoomMeetingEndTimeOn" runat="server" Required="" />
                            </div>
                          </div>--%>
                        <div class="form-group">
                            <label class="col-sm-2 ">
                                <span style="color: red; font-size: 24px;">*</span>   Start Time:
                            </label>
                            <div class="col-sm-10">
                                <div class="row">
                                    <div class="col-lg-2 col-md-2">
                                        <asp:TextBox ID="txtsHours" runat="server" type="number" Required="" Placeholder="HH" 
                                            Width="70px" min="0" max="11"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-2 col-md-2">
                                        <asp:TextBox ID="txtsmints" runat="server" type="number" Required="" Placeholder="MM"
                                            Width="70px" min="0" max="59" MaxLength="2"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-2 col-md-2">
                                        <asp:DropDownList ID="ddlEStartAMPM" runat="server">
                                            <asp:ListItem Text="AM" Value="AM" ></asp:ListItem>
                                            <asp:ListItem Text="PM" Value="PM"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 ">
                                <span style="color: red; font-size: 24px;">*</span>   End Time:
                            </label>
                            <div class="col-sm-10">
                                <div class="row">
                                    <div class="col-lg-2 col-md-2">
                                        <asp:TextBox ID="txtEHours" runat="server" type="number" Required="" Placeholder="HH" Width="70px"
                                            min="0" max="11"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-2 col-md-2">
                                        <asp:TextBox ID="txtEmints" runat="server" type="number" Required="" Placeholder="MM" Width="70px"
                                            min="0" max="59" MaxLength="2"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-2 col-md-2">
                                        <asp:DropDownList ID="ddlEEndAMPM" runat="server" Required="">
                                            <asp:ListItem Text="AM" Value="AM"></asp:ListItem>
                                            <asp:ListItem Text="PM" Value="PM"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                        </div>


                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:button id="btnsubmit" runat="server" onclick="btnsubmit_Click" text="save" />
                                <asp:button id="btnCancel" runat="server" text="Back to List" UseSubmitBehavior="false" Onclick="btnCancel_Click" />
                                    
                            </div>
                        </div>

                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:Button ID="btnCreate" runat="server" Text="Create" UseSubmitBehavior="false"
                                    OnClick="btnCreate_Click" />
                                <h2>Host URL</h2> <asp:Label ID="Host" runat="server" Text="Link"></asp:Label> 
            <h2>Join URL</h2> <asp:Label ID="Join" runat="server" Text="Link"></asp:Label> 
            <h2>Response Code</h2> <asp:Label ID="Code" runat="server" Text="Code"></asp:Label> <br /> <br /> 
                            </div>
                        </div>
                        
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>

