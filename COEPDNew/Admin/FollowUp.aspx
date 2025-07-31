<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="FollowUp.aspx.cs" Inherits="FollowUp" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">






    <script language="javascript" type="text/javascript">
        function myselection(rbtnid) {
            var rbtn = document.getElementById(rbtnid);
            var rbtnlist = document.getElementsByTagName("input");
            for (i = 0; i < rbtnlist.length; i++) {
                if (rbtnlist[i].text == "radio" && rbtnlist[i].id != rbtn.id) {
                    rbtnlist[i].checked = false;

                }
            }
        }
    </script>

   <%-- <script type="text/javascript">
        function ValidateColorList(source, args) {
            var chkListModules = document.getElementById('<%= chkBxLstColors.ClientID %>');
        
            var chkListinputs = chkListModules.getElementsByTagName("input");
            for (var i = 0; i < chkListinputs.length; i++) {
                if (chkListinputs[i].checked) {
                    args.IsValid = true;
                    return;
                }
            }
            args.IsValid = false;
        }

    </script>--%>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Row Start -->
<%--<asp:customvalidator runat="server" forecolor="Red" id="cvmodulelist" clientvalidationfunction="ValidateColorList" errormessage="Please select atleast minimum 3 and maximum 10 Options."></asp:customvalidator>--%>

    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        <asp:Label ID="lblTitle" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
















                        <div class="col-lg-4 col-md-4">
                            <div class="form-horizontal no-margin">
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
                                        BatchType
                                    </label>
                                    <div class="col-sm-10">
                                        <asp:DropDownList ID="ddlBatchType" runat="server" Required="">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Location
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
                                        Pri.Mobile
                                    </label>
                                    <div class="col-sm-10">
                                        <asp:TextBox ID="txtPrimaryMobile" runat="server" Required="" type="number"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Secd.Mobile
                                    </label>
                                    <div class="col-sm-10">
                                        <asp:TextBox ID="txtSecondaryMobile" runat="server" type="number"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Pri.Email
                                    </label>
                                    <div class="col-sm-10">
                                        <asp:TextBox ID="txtPrimaryEmail" runat="server" type="email"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Secd.Email
                                    </label>
                                    <div class="col-sm-10">
                                        <asp:TextBox ID="txtSecondaryEmail" runat="server" type="email"></asp:TextBox>
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
                                    <label class="col-sm-8 control-label">
                                        <asp:Label ID="Label4" runat="server" Text="Up Coming Demo" ForeColor="#FF3300"></asp:Label>
                                    </label>
                                </div>
                                <div class="form-group">
                                    <div class="col-sm-12">
                                        <div class="table-responsive">
                                            <asp:GridView ID="gv1" runat="server" AutoGenerateColumns="false" PageSize="2" Width="100%" AllowPaging="true" AllowSorting="true" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!">
                                                <Columns>
                                                    <asp:TemplateField HeaderText="Is Demo Intrested">
                                                        <ItemTemplate>
                                                            <input name="RadioButton1" type="radio" value='<%# Eval("SNo") %>' onclick="javascript.myselection(this.id)" />
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:BoundField HeaderText="S.No" DataField="SNo" />
                                                    <asp:BoundField HeaderText="DemoId" DataField="DemoId" />
                                                    <asp:BoundField HeaderText="Demo Trainer Name " DataField="DemoTrainerFullName" />
                                                    <asp:BoundField HeaderText="Demo Date" DataField="DemoDateTime" DataFormatString="{0: dd MMM yyyy}" />
                                                    <asp:BoundField HeaderText="Demo Time" DataField="DemoDateTime" DataFormatString="{0: hh:mm tt}" />
                                                </Columns>
                                                <EmptyDataTemplate>
                                                    <center>
                                                        No Records Found
                                                    </center>
                                                </EmptyDataTemplate>
                                            </asp:GridView>
                                        </div>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <div class="col-sm-offset-4 col-sm-9">
                                        <asp:Button ID="btnDemoParticipant" runat="server" Text="Add To Demo" OnClick="btnDemoParticipant_Click" UseSubmitBehavior="false" />
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label class="col-sm-8 control-label">
                                        <asp:Label ID="Label7" runat="server" Text="Demo Attendence" ForeColor="#FF3300"></asp:Label>
                                    </label>
                                </div>

                                <div class="form-group">

                                    <div class="col-md-5 col-lg-5">
                                        <asp:DropDownList ID="ddlAttendence" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlAttendence_SelectedIndexChanged">
                                            <asp:ListItem Text="Not Attended" Value="False"></asp:ListItem>
                                            <asp:ListItem Text="Attended" Value="True" Selected="True"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <div class="col-sm-12">
                                        <div class="table-responsive">
                                            <asp:GridView ID="gv2" runat="server" AutoGenerateColumns="false" PageSize="20" Width="100%" AllowPaging="true" AllowSorting="true" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnRowDataBound="gv2_RowDataBound">
                                                <Columns>
                                                    <asp:TemplateField HeaderText="Attendence">
                                                        <ItemTemplate>
                                                            <input name="RadioButton1" type="radio" value='<%# Eval("SNo") %>' onclick="javascript.myselection(this.id)" />
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:BoundField HeaderText="S.No" DataField="SNo" />
                                                    <asp:BoundField HeaderText="DemoAttendanceId" DataField="DemoAttendenceId" />
                                                    <asp:BoundField HeaderText="Trainer name" DataField="Employee" />
                                                    <asp:BoundField HeaderText="Demo Date" DataField="DemoDateTime" DataFormatString="{0: dd MMM yyyy }" />
                                                    <asp:BoundField HeaderText="Demo Time" DataField="DemoDateTime" DataFormatString="{0: hh:mm tt}" />

                                                   <%-- <asp:TemplateField HeaderText="Attendence">
                                                        <ItemTemplate>
                                                            <%# (Boolean.Parse(Eval("IsDemoAttended").ToString()) ? "Attended" : "Not Attended" )%>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>--%>
                                                    <asp:TemplateField HeaderText=" Attendence" ItemStyle-HorizontalAlign="Center">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblstatus" runat="server" Text='<%# Bind("IsDemoAttended") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>

                                                </Columns>
                                                <EmptyDataTemplate>
                                                    <center>
                                                        No Records Found
                                                    </center>
                                                </EmptyDataTemplate>
                                            </asp:GridView>
                                        </div>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <div class="col-sm-offset-4 col-sm-9">
                                        <asp:Button ID="btnAttendence" runat="server" OnClick="btnAttendence_Click" Text="Demo Attendence" UseSubmitBehavior="false" />
                                    </div>
                                </div>



                            </div>
                        </div>





                        <div class="col-lg-8 col-md-8">
                            <div class="form-horizontal no-margin">




                                <div class="form-group">
                                    <div class="col-sm-12">
                                        <div class="table-responsive">
                                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" Width="100%">
                                                <Columns>
                                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                                    <asp:BoundField HeaderText="History" DataField="LeadLink" ItemStyle-Width="500px" />
                                                    <asp:BoundField HeaderText="Name" DataField="Username" />
                                                    <asp:BoundField HeaderText="Date" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                                </Columns>
                                                <EmptyDataTemplate>
                                                    <center>
                                                        No Records Found
                                                    </center>
                                                </EmptyDataTemplate>
                                            </asp:GridView>
                                        </div>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Lead Source
                                    </label>
                                    <div class="col-sm-9">
                                        <asp:DropDownList ID="ddlLeadSource" runat="server" required="">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Lead Status
                                    </label>
                                    <div class="col-sm-9">
                                        <asp:DropDownList ID="ddlLeadCategory" runat="server" required="">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Communication
                                    </label>
                                    <div class="col-sm-9">
                                        <asp:DropDownList ID="ddlCommunicationType" runat="server" required="">
                                        </asp:DropDownList>
                                    </div>
                                </div>















































                               
                                 <div class="form-group">
                                <div class="col-sm-offset-2 col-sm-12">
                                <asp:Label ID="Label9" runat="server" Text="***Please Select minimum 3 and maximum 10 Options ***" ForeColor="#ff0066" Font-Bold="true"></asp:Label>
                                    </div>
                                     </div>


                                <div class="form-group">
                                    <div class="col-sm-3">
                                    </div>
                                    <div class="col-sm-3">
                                        <asp:Label ID="Label5" runat="server" Text="Training Needs" ForeColor="#FF3300" Font-Bold="true"></asp:Label>
                                    </div>

                                    <div class="col-sm-3">
                                        <asp:Label ID="Label6" runat="server" Text="Context/Situation" ForeColor="#FF3300" Font-Bold="true"></asp:Label>
                                    </div>

                                    <div class="col-sm-3">
                                        <asp:Label ID="Label8" runat="server" Text="Decision Parameters" ForeColor="#FF3300" Font-Bold="true"></asp:Label>
                                    </div>
                                </div>
















































                               <!--satheeshReddy -->

<%--<asp:checkboxlist id="chkBxLstColors" runat="server">
<asp:listitem text="Red" value="1"></asp:listitem>
<asp:listitem text="Green" value="2"></asp:listitem>
<asp:listitem text="Blue" value="3"></asp:listitem>
<asp:listitem text="Yellow" value="4"></asp:listitem>
<asp:listitem text="Orange" value="5"></asp:listitem>
<asp:listitem text="Black" value="6"></asp:listitem>
</asp:checkboxlist>--%>


  <!--satheeshReddy -->




                                <div class="form-group">
                                    <div class="col-sm-3">
                                    </div>
                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="chkBetterPay" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                        Better Pay
                                    </div>
                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="chkJobLess" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                        Job Less
                                    </div>
                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="chkFriendsAdvise" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                        Friends Advise
                                    </div>
                                </div>





                                <div class="form-group">
                                    <div class="col-sm-3">
                                    </div>
                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="chkIJM" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                        IJM
                                    </div>

                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="chkNoMoney" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                        No Money
                                    </div>

                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="chkFamilyMemberGuidence" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                        Family Member Guidence
                                    </div>
                                </div>





                                <div class="form-group">
                                    <div class="col-sm-3">
                                    </div>
                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="chkCertifications" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                        Certifications
                                    </div>
                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="chkPresentWorking" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                        Present Working
                                    </div>

                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="chkCoepdPreviousPlacement" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                        Coepd Previous Placement
                                    </div>
                                </div>






                                <div class="form-group">
                                    <div class="col-sm-3">
                                    </div>
                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="chkKnowledgeEnhancement" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                        Knowledge Enhancement
                                    </div>
                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="chkweekendsAvailable" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                        weekends Available
                                    </div>

                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="chkCOEPDgoodreviews" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                        COEPD good reviews
                                    </div>
                                </div>




                                <div class="form-group">
                                    <div class="col-sm-3">
                                    </div>
                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="chkWantToShiftToIT" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                        Want To Shift To IT
                                    </div>
                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="chkWeekDaysDailyOnehour" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                        WeekDays Daily 1 hour
                                    </div>

                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="chkFees" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                        Fees
                                    </div>
                                </div>



                                <div class="form-group">
                                    <div class="col-sm-3">
                                    </div>
                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="chkMarriage" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                        Marriage
                                    </div>
                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="chkPutDownPapers" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                        Put Down Papers
                                    </div>

                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="chkDiscounts" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                        Discounts
                                    </div>
                                </div>





                                <div class="form-group">
                                    <div class="col-sm-3">
                                    </div>
                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="chkMoveToDifferentCity" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                        Move to different city
                                    </div>
                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="chkInThreeMonthsWantANewJob" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                        In 3 Months want a new job
                                    </div>

                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="chkSelfSponsored" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                        Self-Sponsored
                                    </div>
                                </div>





                                <div class="form-group">
                                    <div class="col-sm-3">
                                    </div>
                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="chkStableJob" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                        Stable Job
                                    </div>
                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="chkDontWantToKeepPseudoExperience" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                        Don't want to keep pseudo experience
                                    </div>

                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="chkSponsoredByAFriendAndFamilyMember" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                        Sponsored By a friend/family member
                                    </div>
                                </div>



                                <div class="form-group">
                                    <div class="col-sm-3">
                                    </div>
                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="chkNoTensionJob" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                        No Tension Job
                                    </div>
                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="chkKeenToRetainPreviousExperience" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                        Keen to retain previous experience
                                    </div>

                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="chkTimeSlotsAvailability" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                        Time slots Availability
                                    </div>
                                </div>








                                <div class="form-group">
                                    <div class="col-sm-4">
                                    </div>
                                    <div class="col-sm-2">
                                    </div>
                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="chkSlowLearner" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                        Slow Learner
                                    </div>

                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="chkClassRoomPreferences" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                        Class Room preferences
                                    </div>
                                </div>



                                <div class="form-group">
                                    <div class="col-sm-4">
                                    </div>
                                    <div class="col-sm-2">
                                    </div>
                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="chkNewToThisSubjectBA" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                        new to this Subject BA
                                    </div>

                                    <div class="col-sm-1">
                                        <asp:CheckBox ID="chkConfiedenceOfDoingThisCourseAndGettingAJob" runat="server" />
                                    </div>
                                    <div class="col-sm-2">
                                        Confiedence of doing this course and getting a job
                                    </div>
                                </div>










































                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        FollowUp Date
                                    </label>
                                    <div class="col-md-9">
                                        <label class="control-label">
                                            <asp:Label ID="lblFollowupDate" runat="server"></asp:Label>
                                        </label>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Next FollowUp
                                    </label>
                                    <div class="col-md-2">
                                        <asp:TextBox ID="txtFDay" runat="server" required="" type="number" Min="1" Max="31" Placeholder="DD"> </asp:TextBox>
                                    </div>
                                    <div class="col-md-2">
                                        <asp:TextBox ID="txtFMonth" runat="server" required="" type="number" Min="1" Max="12" Placeholder="MM"></asp:TextBox>
                                    </div>
                                    <div class="col-md-3">
                                        <asp:TextBox ID="txtFYear" runat="server" required="" type="number" Min="2000" Placeholder="YYYY"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        FollowUp Time
                                    </label>
                                    <div class="col-md-2">
                                        <asp:TextBox ID="txtFromHTime" runat="server" required="" type="number" Min="1" Max="12" Placeholder="HH"> </asp:TextBox>
                                    </div>
                                    <div class="col-md-2">
                                        <asp:TextBox ID="txtFromMTime" runat="server" required="" type="number" Min="0" Max="59" Placeholder="MM"></asp:TextBox>
                                    </div>
                                    <div class="col-md-1">
                                        <label class="col-sm-1 control-label">
                                            To
                                        </label>
                                    </div>
                                    <div class="col-md-2">
                                        <asp:TextBox ID="txtToHTime" runat="server" required="" type="number" Min="1" Max="12" Placeholder="HH"> </asp:TextBox>
                                    </div>
                                    <div class="col-md-2">
                                        <asp:TextBox ID="txtToMTime" runat="server" required="" type="number" Min="0" Max="59" Placeholder="MM"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Current Followup
                                    </label>
                                    <div class="col-sm-9">
                                        <asp:TextBox ID="txtNotes" runat="server" required="" TextMode="MultiLine">
                                        </asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Batch
                                    </label>
                                    <div class="col-sm-9">
                                        <asp:DropDownList ID="ddlBatch" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlBatch_SelectedIndexChanged">
                                        </asp:DropDownList>
                                        <asp:HiddenField ID="hdnSubscriptionExpiryDate" runat="server" />
                                    </div>
                                </div>


                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Course Fee
                                    </label>
                                    <div class="col-sm-9">
                                        <asp:TextBox ID="txtCourseFee" runat="server" type="number"></asp:TextBox>
                                    </div>
                                </div>









                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                    </label>
                                    <div class="col-sm-9">

                                        <asp:Label ID="lblInfo" runat="server" Text="Referal Amount should be Given only if the participant joins with out any Discount " ForeColor="Red"></asp:Label>

                                    </div>
                                </div>


                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        <asp:Label ID="Label3" runat="server" Text="Referal Amount"></asp:Label>
                                    </label>
                                    <div class="col-sm-9">
                                        <asp:TextBox ID="txtReferalAmount" runat="server" type="number"></asp:TextBox>
                                    </div>
                                </div>



                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        <asp:Label ID="Label2" runat="server" Text="Upload Proof Of Payment"></asp:Label>
                                    </label>
                                    <div class="col-sm-9">
                                        <asp:FileUpload ID="flUpload" runat="server" />
                                    </div>
                                </div>




                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        <asp:Label ID="Label1" runat="server" Text="Attachments" Visible="false"></asp:Label>
                                    </label>
                                    <div class="col-sm-9">
                                        <asp:HyperLink ID="hplProof" runat="server" CssClass="btn btn-success btn-sm" Target="_blank" Visible="false">View Attachments</asp:HyperLink>
                                    </div>
                                </div>














                                <div class="form-group">
                                    <div class="col-sm-offset-3 col-sm-9">
                                        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Save" />
                                        <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Register Now"
                                            EnableTheming="false" CssClass="btn btn-warning" UseSubmitBehavior="false" />
                                        <asp:Button ID="btnCancel" runat="server" Text="Back to list" UseSubmitBehavior="false"
                                            OnClick="btnCancel_Click" />
                                        <asp:Button ID="btnNoFollowup" runat="server" Text="No Follow-up " UseSubmitBehavior="false"
                                            OnClick="btnNoFollowup_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Row End -->
</asp:Content>
