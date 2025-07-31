<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="NurturingAvilableSlots.aspx.cs" Inherits="Admin_NurturingAvilableSlots" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
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
            $("[id*=txtSelectDate]").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: 'dd/mm/yy',
                minDate: "0",
            });
        });
    </script>
        <script type="text/javascript">
        function alertmeSave() {
            Swal.fire(
                      'Slot Added Successfully',
                      '',
                      'success'
                    )
        }
        function alertmeUpdate() {
            Swal.fire(
                      'Slot Updated Successfully',
                      '',
                      'success'
                    )
        }

        function alertmeDuplicate() {
            Swal.fire(
                      'Slot already exist',
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
    <asp:ScriptManager ID="ScriptManager2" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
    <!-- Row Start -->
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Nurturing Process - Enter Slots
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                       
                        <div class="col-lg-6 col-md-6">
                            <asp:Label ID="lblHeading" runat="server" Text="Mentor Skillset in Nurturing Process" Font-Bold="true"></asp:Label>
                            <asp:BulletedList runat="server" ID="blNurturingTasks" BulletStyle="Numbered"></asp:BulletedList>
                        </div>
                         <div class="col-lg-6 col-md-6">
                            <div class="form-group">
                            <label class="col-sm-2 control-label">
                               Select Date<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtSelectDate" runat="server" required="" autoComplete="off" AutoPostBack="true"></asp:TextBox>
                            </div>
                        </div>
                              <div class="form-group">
                                     <div class="col-sm-offset-3 col-sm-9">
                                    <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                                        <ProgressTemplate>
                                            <div class="div1" style="margin-left: 10px">
                                                <asp:Image ID="Image1" ImageUrl="/img/CoepdLoad.gif" AlternateText="Processing" runat="server" />
                                                <%--<asp:Label ID="Label1" runat="server" Text="The Inputs are Loading so Please Wait"></asp:Label>--%>
                                            </div>
                                        </ProgressTemplate>
                                    </asp:UpdateProgress>
                                         </div>
                                </div>
                             <br />&nbsp;
                             <div class="form-group">
                                  <div class="col-sm-2">
                                <asp:Button ID="btn1" runat="server" OnClick="btn1_Click" Text="0:00-0:30AM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                 <div class="col-sm-2">
                                <asp:Button ID="btn2" runat="server" OnClick="btn2_Click" Text="0:30-1:00AM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                 <div class="col-sm-2">
                                <asp:Button ID="btn3" runat="server" OnClick="btn3_Click" Text="1:00-1:30AM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                  <div class="col-sm-2">
                                <asp:Button ID="btn4" runat="server" OnClick="btn4_Click" Text="1:30-2:00AM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                 <div class="col-sm-2">
                                <asp:Button ID="btn5" runat="server" OnClick="btn5_Click" Text="2:00-2:30AM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                  <div class="col-sm-2">
                                <asp:Button ID="btn6" runat="server" OnClick="btn6_Click" Text="2:30-3:00AM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>

                             </div>

                             <br />&nbsp;
                             <div class="form-group">
                                  <div class="col-sm-2">
                                <asp:Button ID="btn7" runat="server" OnClick="btn7_Click" Text="3:00-3:30AM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                 <div class="col-sm-2">
                                <asp:Button ID="btn8" runat="server" OnClick="btn8_Click" Text="3:30-4:00AM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                 <div class="col-sm-2">
                                <asp:Button ID="btn9" runat="server" OnClick="btn9_Click" Text="4:00-4:30AM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                  <div class="col-sm-2">
                                <asp:Button ID="btn10" runat="server" OnClick="btn10_Click" Text="4:30-5:00AM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                 <div class="col-sm-2">
                                <asp:Button ID="btn11" runat="server" OnClick="btn11_Click" Text="5:00-5:30AM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                  <div class="col-sm-2">
                                <asp:Button ID="btn12" runat="server" OnClick="btn12_Click" Text="5:30-6:00AM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>

                             </div>

                             <br />&nbsp;
                             <div class="form-group">
                                  <div class="col-sm-2">
                                <asp:Button ID="btn13" runat="server" OnClick="btn13_Click" Text="6:00-6:30AM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                 <div class="col-sm-2">
                                <asp:Button ID="btn14" runat="server" OnClick="btn14_Click" Text="6:30-7:00AM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                 <div class="col-sm-2">
                                <asp:Button ID="btn15" runat="server" OnClick="btn15_Click" Text="7:00-7:30AM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                  <div class="col-sm-2">
                                <asp:Button ID="btn16" runat="server" OnClick="btn16_Click" Text="7:30-8:00AM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                 <div class="col-sm-2">
                                <asp:Button ID="btn17" runat="server" OnClick="btn17_Click" Text="8:00-8:30AM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                  <div class="col-sm-2">
                                <asp:Button ID="btn18" runat="server" OnClick="btn18_Click" Text="8:30-9:00AM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>

                             </div>

                             <br />&nbsp;
                             <div class="form-group">
                                  <div class="col-sm-2">
                                <asp:Button ID="btn19" runat="server" OnClick="btn19_Click" Text="9:00-9:30AM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                 <div class="col-sm-2">
                                <asp:Button ID="btn20" runat="server" OnClick="btn20_Click" Text="9:30-10AM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                 <div class="col-sm-2">
                                <asp:Button ID="btn21" runat="server" OnClick="btn21_Click" Text="10-10:30AM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                  <div class="col-sm-2">
                                <asp:Button ID="btn22" runat="server" OnClick="btn22_Click" Text="10:30-11AM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                 <div class="col-sm-2">
                                <asp:Button ID="btn23" runat="server" OnClick="btn23_Click" Text="11-11:30AM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                  <div class="col-sm-2">
                                <asp:Button ID="btn24" runat="server" OnClick="btn24_Click" Text="11:30-12PM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>

                             </div>

                             <br />&nbsp;
                             <div class="form-group">
                                  <div class="col-sm-2">
                                <asp:Button ID="btn25" runat="server" OnClick="btn25_Click" Text="12-12:30PM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                 <div class="col-sm-2">
                                <asp:Button ID="btn26" runat="server" OnClick="btn26_Click" Text="12:30-1PM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                 <div class="col-sm-2">
                                <asp:Button ID="btn27" runat="server" OnClick="btn27_Click" Text="1:00-1:30PM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                  <div class="col-sm-2">
                                <asp:Button ID="btn28" runat="server" OnClick="btn28_Click" Text="1:30-2:00PM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                 <div class="col-sm-2">
                                <asp:Button ID="btn29" runat="server" OnClick="btn29_Click" Text="2:00-2:30PM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                  <div class="col-sm-2">
                                <asp:Button ID="btn30" runat="server" OnClick="btn30_Click" Text="2:30-3:00PM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>

                             </div>

                             <br />&nbsp;
                             <div class="form-group">
                                  <div class="col-sm-2">
                                <asp:Button ID="btn31" runat="server" OnClick="btn31_Click" Text="3:00-3:30PM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                 <div class="col-sm-2">
                                <asp:Button ID="btn32" runat="server" OnClick="btn32_Click" Text="3:30-4:00PM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                 <div class="col-sm-2">
                                <asp:Button ID="btn33" runat="server" OnClick="btn33_Click" Text="4:00-4:30PM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                  <div class="col-sm-2">
                                <asp:Button ID="btn34" runat="server" OnClick="btn34_Click" Text="4:30-5:00PM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                 <div class="col-sm-2">
                                <asp:Button ID="btn35" runat="server" OnClick="btn35_Click" Text="5:00-5:30PM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                  <div class="col-sm-2">
                                <asp:Button ID="btn36" runat="server" OnClick="btn36_Click" Text="5:30-6:00PM" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>

                             </div>

                             <br />&nbsp;
                             <div class="form-group">
                                  <div class="col-sm-2">
                                <asp:Button ID="btn37" runat="server" Text="6:00-6:30PM" OnClick="btn37_Click" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                 <div class="col-sm-2">
                                <asp:Button ID="btn38" runat="server" Text="6:30-7:00PM" OnClick="btn38_Click" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                 <div class="col-sm-2">
                                <asp:Button ID="btn39" runat="server" Text="7:00-7:30PM" OnClick="btn39_Click" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                  <div class="col-sm-2">
                                <asp:Button ID="btn40" runat="server" Text="7:30-8:00PM" OnClick="btn40_Click" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                 <div class="col-sm-2">
                                <asp:Button ID="btn41" runat="server" Text="8:00-8:30PM" OnClick="btn41_Click" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                  <div class="col-sm-2">
                                <asp:Button ID="btn42" runat="server" Text="8:30-9:00PM" OnClick="btn42_Click" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>

                             </div>
                             <br />&nbsp;
                             <div class="form-group">
                                  <div class="col-sm-2">
                                <asp:Button ID="btn43" runat="server" Text="9:00-9:30PM" OnClick="btn43_Click" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                 <div class="col-sm-2">
                                <asp:Button ID="btn44" runat="server" Text="9:30-10PM" OnClick="btn44_Click" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                 <div class="col-sm-2">
                                <asp:Button ID="btn45" runat="server" Text="10-10:30PM" OnClick="btn45_Click" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                  <div class="col-sm-2">
                                <asp:Button ID="btn46" runat="server" Text="10:30-11PM" OnClick="btn46_Click" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                 <div class="col-sm-2">
                                <asp:Button ID="btn47" runat="server" Text="11-11:30PM" OnClick="btn47_Click" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>
                                  <div class="col-sm-2">
                                <asp:Button ID="btn48" runat="server" Text="11:30-12AM" OnClick="btn48_Click" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                            </div>

                             </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
         <div class="row">
                      <div class="col-sm-offset-5 col-sm-10">
                           <asp:Button runat="server" ID="btnBack" Text="Go To Slots Page" OnClick="btnBack_Click" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please Wait...';" />
                      </div> 
                        </div>
    </div>
            </ContentTemplate>
    </asp:UpdatePanel>
    <!-- Row End -->
</asp:Content>

